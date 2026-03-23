// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudwifi_pop20191118.Models;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "cloudwf.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudwifi-pop", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="tmpReq">
        /// AddApListToApgroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddApListToApgroupResponse
        /// </returns>
        public AddApListToApgroupResponse AddApListToApgroupWithOptions(AddApListToApgroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddApListToApgroupShrinkRequest request = new AddApListToApgroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApMacList))
            {
                request.ApMacListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApMacList, "ApMacList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupId))
            {
                query["ApGroupId"] = request.ApGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMacListShrink))
            {
                body["ApMacList"] = request.ApMacListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApListToApgroup",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApListToApgroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// AddApListToApgroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddApListToApgroupResponse
        /// </returns>
        public async Task<AddApListToApgroupResponse> AddApListToApgroupWithOptionsAsync(AddApListToApgroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddApListToApgroupShrinkRequest request = new AddApListToApgroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApMacList))
            {
                request.ApMacListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApMacList, "ApMacList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupId))
            {
                query["ApGroupId"] = request.ApGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMacListShrink))
            {
                body["ApMacList"] = request.ApMacListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApListToApgroup",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApListToApgroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddApListToApgroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddApListToApgroupResponse
        /// </returns>
        public AddApListToApgroupResponse AddApListToApgroup(AddApListToApgroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddApListToApgroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddApListToApgroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddApListToApgroupResponse
        /// </returns>
        public async Task<AddApListToApgroupResponse> AddApListToApgroupAsync(AddApListToApgroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddApListToApgroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelApThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelApThirdAppResponse
        /// </returns>
        public DelApThirdAppResponse DelApThirdAppWithOptions(DelApThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAssetId))
            {
                query["ApAssetId"] = request.ApAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelApThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelApThirdAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelApThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelApThirdAppResponse
        /// </returns>
        public async Task<DelApThirdAppResponse> DelApThirdAppWithOptionsAsync(DelApThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAssetId))
            {
                query["ApAssetId"] = request.ApAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelApThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelApThirdAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelApThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DelApThirdAppResponse
        /// </returns>
        public DelApThirdAppResponse DelApThirdApp(DelApThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelApThirdAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DelApThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DelApThirdAppResponse
        /// </returns>
        public async Task<DelApThirdAppResponse> DelApThirdAppAsync(DelApThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelApThirdAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteApSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApSsidConfigResponse
        /// </returns>
        public DeleteApSsidConfigResponse DeleteApSsidConfigWithOptions(DeleteApSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RadioIndex))
            {
                query["RadioIndex"] = request.RadioIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ssid))
            {
                query["Ssid"] = request.Ssid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApSsidConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteApSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApSsidConfigResponse
        /// </returns>
        public async Task<DeleteApSsidConfigResponse> DeleteApSsidConfigWithOptionsAsync(DeleteApSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RadioIndex))
            {
                query["RadioIndex"] = request.RadioIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ssid))
            {
                query["Ssid"] = request.Ssid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApSsidConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteApSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApSsidConfigResponse
        /// </returns>
        public DeleteApSsidConfigResponse DeleteApSsidConfig(DeleteApSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApSsidConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteApSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApSsidConfigResponse
        /// </returns>
        public async Task<DeleteApSsidConfigResponse> DeleteApSsidConfigAsync(DeleteApSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApSsidConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteApgroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupConfigResponse
        /// </returns>
        public DeleteApgroupConfigResponse DeleteApgroupConfigWithOptions(DeleteApgroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApgroupConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApgroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteApgroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupConfigResponse
        /// </returns>
        public async Task<DeleteApgroupConfigResponse> DeleteApgroupConfigWithOptionsAsync(DeleteApgroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApgroupConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApgroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteApgroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupConfigResponse
        /// </returns>
        public DeleteApgroupConfigResponse DeleteApgroupConfig(DeleteApgroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApgroupConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteApgroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupConfigResponse
        /// </returns>
        public async Task<DeleteApgroupConfigResponse> DeleteApgroupConfigAsync(DeleteApgroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApgroupConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AP组上的SSID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupSsidConfigResponse
        /// </returns>
        public DeleteApgroupSsidConfigResponse DeleteApgroupSsidConfigWithOptions(DeleteApgroupSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApgroupSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApgroupSsidConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AP组上的SSID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupSsidConfigResponse
        /// </returns>
        public async Task<DeleteApgroupSsidConfigResponse> DeleteApgroupSsidConfigWithOptionsAsync(DeleteApgroupSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApgroupSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApgroupSsidConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AP组上的SSID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupSsidConfigResponse
        /// </returns>
        public DeleteApgroupSsidConfigResponse DeleteApgroupSsidConfig(DeleteApgroupSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApgroupSsidConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AP组上的SSID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupSsidConfigResponse
        /// </returns>
        public async Task<DeleteApgroupSsidConfigResponse> DeleteApgroupSsidConfigAsync(DeleteApgroupSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApgroupSsidConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupThirdAppResponse
        /// </returns>
        public DeleteApgroupThirdAppResponse DeleteApgroupThirdAppWithOptions(DeleteApgroupThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApgroupThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApgroupThirdAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupThirdAppResponse
        /// </returns>
        public async Task<DeleteApgroupThirdAppResponse> DeleteApgroupThirdAppWithOptionsAsync(DeleteApgroupThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApgroupThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApgroupThirdAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupThirdAppResponse
        /// </returns>
        public DeleteApgroupThirdAppResponse DeleteApgroupThirdApp(DeleteApgroupThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApgroupThirdAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApgroupThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApgroupThirdAppResponse
        /// </returns>
        public async Task<DeleteApgroupThirdAppResponse> DeleteApgroupThirdAppAsync(DeleteApgroupThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApgroupThirdAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetDeviceInfoResponse
        /// </returns>
        public DeleteNetDeviceInfoResponse DeleteNetDeviceInfoWithOptions(DeleteNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetDeviceInfoResponse
        /// </returns>
        public async Task<DeleteNetDeviceInfoResponse> DeleteNetDeviceInfoWithOptionsAsync(DeleteNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetDeviceInfoResponse
        /// </returns>
        public DeleteNetDeviceInfoResponse DeleteNetDeviceInfo(DeleteNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetDeviceInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetDeviceInfoResponse
        /// </returns>
        public async Task<DeleteNetDeviceInfoResponse> DeleteNetDeviceInfoAsync(DeleteNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditApgroupThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditApgroupThirdAppResponse
        /// </returns>
        public EditApgroupThirdAppResponse EditApgroupThirdAppWithOptions(EditApgroupThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppData))
            {
                query["AppData"] = request.AppData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyToSubGroup))
            {
                query["ApplyToSubGroup"] = request.ApplyToSubGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InheritParentGroup))
            {
                query["InheritParentGroup"] = request.InheritParentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAppName))
            {
                query["ThirdAppName"] = request.ThirdAppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditApgroupThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditApgroupThirdAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditApgroupThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditApgroupThirdAppResponse
        /// </returns>
        public async Task<EditApgroupThirdAppResponse> EditApgroupThirdAppWithOptionsAsync(EditApgroupThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppData))
            {
                query["AppData"] = request.AppData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyToSubGroup))
            {
                query["ApplyToSubGroup"] = request.ApplyToSubGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InheritParentGroup))
            {
                query["InheritParentGroup"] = request.InheritParentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAppName))
            {
                query["ThirdAppName"] = request.ThirdAppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditApgroupThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditApgroupThirdAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditApgroupThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// EditApgroupThirdAppResponse
        /// </returns>
        public EditApgroupThirdAppResponse EditApgroupThirdApp(EditApgroupThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditApgroupThirdAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditApgroupThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// EditApgroupThirdAppResponse
        /// </returns>
        public async Task<EditApgroupThirdAppResponse> EditApgroupThirdAppAsync(EditApgroupThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditApgroupThirdAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EffectApConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EffectApConfigResponse
        /// </returns>
        public EffectApConfigResponse EffectApConfigWithOptions(EffectApConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EffectApConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EffectApConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EffectApConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EffectApConfigResponse
        /// </returns>
        public async Task<EffectApConfigResponse> EffectApConfigWithOptionsAsync(EffectApConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EffectApConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EffectApConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EffectApConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// EffectApConfigResponse
        /// </returns>
        public EffectApConfigResponse EffectApConfig(EffectApConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EffectApConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EffectApConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// EffectApConfigResponse
        /// </returns>
        public async Task<EffectApConfigResponse> EffectApConfigAsync(EffectApConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EffectApConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EffectApgroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EffectApgroupConfigResponse
        /// </returns>
        public EffectApgroupConfigResponse EffectApgroupConfigWithOptions(EffectApgroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EffectApgroupConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EffectApgroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EffectApgroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EffectApgroupConfigResponse
        /// </returns>
        public async Task<EffectApgroupConfigResponse> EffectApgroupConfigWithOptionsAsync(EffectApgroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EffectApgroupConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EffectApgroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EffectApgroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// EffectApgroupConfigResponse
        /// </returns>
        public EffectApgroupConfigResponse EffectApgroupConfig(EffectApgroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EffectApgroupConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EffectApgroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// EffectApgroupConfigResponse
        /// </returns>
        public async Task<EffectApgroupConfigResponse> EffectApgroupConfigAsync(EffectApgroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EffectApgroupConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询蚂蚁环境终端状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAntStaStatusByMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAntStaStatusByMacResponse
        /// </returns>
        public GetAntStaStatusByMacResponse GetAntStaStatusByMacWithOptions(GetAntStaStatusByMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAntStaStatusByMac",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAntStaStatusByMacResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询蚂蚁环境终端状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAntStaStatusByMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAntStaStatusByMacResponse
        /// </returns>
        public async Task<GetAntStaStatusByMacResponse> GetAntStaStatusByMacWithOptionsAsync(GetAntStaStatusByMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAntStaStatusByMac",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAntStaStatusByMacResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询蚂蚁环境终端状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAntStaStatusByMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAntStaStatusByMacResponse
        /// </returns>
        public GetAntStaStatusByMacResponse GetAntStaStatusByMac(GetAntStaStatusByMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAntStaStatusByMacWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询蚂蚁环境终端状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAntStaStatusByMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAntStaStatusByMacResponse
        /// </returns>
        public async Task<GetAntStaStatusByMacResponse> GetAntStaStatusByMacAsync(GetAntStaStatusByMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAntStaStatusByMacWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApAddressByMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApAddressByMacResponse
        /// </returns>
        public GetApAddressByMacResponse GetApAddressByMacWithOptions(GetApAddressByMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApAddressByMac",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApAddressByMacResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApAddressByMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApAddressByMacResponse
        /// </returns>
        public async Task<GetApAddressByMacResponse> GetApAddressByMacWithOptionsAsync(GetApAddressByMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApAddressByMac",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApAddressByMacResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApAddressByMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApAddressByMacResponse
        /// </returns>
        public GetApAddressByMacResponse GetApAddressByMac(GetApAddressByMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApAddressByMacWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApAddressByMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApAddressByMacResponse
        /// </returns>
        public async Task<GetApAddressByMacResponse> GetApAddressByMacAsync(GetApAddressByMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApAddressByMacWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApAssetResponse
        /// </returns>
        public GetApAssetResponse GetApAssetWithOptions(GetApAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApAsset",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApAssetResponse
        /// </returns>
        public async Task<GetApAssetResponse> GetApAssetWithOptionsAsync(GetApAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApAsset",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApAssetResponse
        /// </returns>
        public GetApAssetResponse GetApAsset(GetApAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApAssetWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApAssetResponse
        /// </returns>
        public async Task<GetApAssetResponse> GetApAssetAsync(GetApAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApAssetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApDetailStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailStatusResponse
        /// </returns>
        public GetApDetailStatusResponse GetApDetailStatusWithOptions(GetApDetailStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedApgroupInfo))
            {
                query["NeedApgroupInfo"] = request.NeedApgroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRadioStatus))
            {
                query["NeedRadioStatus"] = request.NeedRadioStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApDetailStatus",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApDetailStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApDetailStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailStatusResponse
        /// </returns>
        public async Task<GetApDetailStatusResponse> GetApDetailStatusWithOptionsAsync(GetApDetailStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedApgroupInfo))
            {
                query["NeedApgroupInfo"] = request.NeedApgroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRadioStatus))
            {
                query["NeedRadioStatus"] = request.NeedRadioStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApDetailStatus",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApDetailStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApDetailStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailStatusResponse
        /// </returns>
        public GetApDetailStatusResponse GetApDetailStatus(GetApDetailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApDetailStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApDetailStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailStatusResponse
        /// </returns>
        public async Task<GetApDetailStatusResponse> GetApDetailStatusAsync(GetApDetailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApDetailStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApDetailedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailedConfigResponse
        /// </returns>
        public GetApDetailedConfigResponse GetApDetailedConfigWithOptions(GetApDetailedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApDetailedConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApDetailedConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApDetailedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailedConfigResponse
        /// </returns>
        public async Task<GetApDetailedConfigResponse> GetApDetailedConfigWithOptionsAsync(GetApDetailedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApDetailedConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApDetailedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApDetailedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailedConfigResponse
        /// </returns>
        public GetApDetailedConfigResponse GetApDetailedConfig(GetApDetailedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApDetailedConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApDetailedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApDetailedConfigResponse
        /// </returns>
        public async Task<GetApDetailedConfigResponse> GetApDetailedConfigAsync(GetApDetailedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApDetailedConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApInfoFromPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApInfoFromPoolResponse
        /// </returns>
        public GetApInfoFromPoolResponse GetApInfoFromPoolWithOptions(GetApInfoFromPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApInfoFromPool",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApInfoFromPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApInfoFromPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApInfoFromPoolResponse
        /// </returns>
        public async Task<GetApInfoFromPoolResponse> GetApInfoFromPoolWithOptionsAsync(GetApInfoFromPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApInfoFromPool",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApInfoFromPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApInfoFromPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApInfoFromPoolResponse
        /// </returns>
        public GetApInfoFromPoolResponse GetApInfoFromPool(GetApInfoFromPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApInfoFromPoolWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApInfoFromPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApInfoFromPoolResponse
        /// </returns>
        public async Task<GetApInfoFromPoolResponse> GetApInfoFromPoolAsync(GetApInfoFromPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApInfoFromPoolWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApRunHistoryTimeSerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApRunHistoryTimeSerResponse
        /// </returns>
        public GetApRunHistoryTimeSerResponse GetApRunHistoryTimeSerWithOptions(GetApRunHistoryTimeSerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApRunHistoryTimeSer",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApRunHistoryTimeSerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApRunHistoryTimeSerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApRunHistoryTimeSerResponse
        /// </returns>
        public async Task<GetApRunHistoryTimeSerResponse> GetApRunHistoryTimeSerWithOptionsAsync(GetApRunHistoryTimeSerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApRunHistoryTimeSer",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApRunHistoryTimeSerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApRunHistoryTimeSerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApRunHistoryTimeSerResponse
        /// </returns>
        public GetApRunHistoryTimeSerResponse GetApRunHistoryTimeSer(GetApRunHistoryTimeSerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApRunHistoryTimeSerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApRunHistoryTimeSerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApRunHistoryTimeSerResponse
        /// </returns>
        public async Task<GetApRunHistoryTimeSerResponse> GetApRunHistoryTimeSerAsync(GetApRunHistoryTimeSerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApRunHistoryTimeSerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApStatusByGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApStatusByGroupIdResponse
        /// </returns>
        public GetApStatusByGroupIdResponse GetApStatusByGroupIdWithOptions(GetApStatusByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
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
                Action = "GetApStatusByGroupId",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApStatusByGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApStatusByGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApStatusByGroupIdResponse
        /// </returns>
        public async Task<GetApStatusByGroupIdResponse> GetApStatusByGroupIdWithOptionsAsync(GetApStatusByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
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
                Action = "GetApStatusByGroupId",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApStatusByGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApStatusByGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApStatusByGroupIdResponse
        /// </returns>
        public GetApStatusByGroupIdResponse GetApStatusByGroupId(GetApStatusByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApStatusByGroupIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApStatusByGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApStatusByGroupIdResponse
        /// </returns>
        public async Task<GetApStatusByGroupIdResponse> GetApStatusByGroupIdAsync(GetApStatusByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApStatusByGroupIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组的基本信息（名称之类）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupConfigByIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupConfigByIdentityResponse
        /// </returns>
        public GetApgroupConfigByIdentityResponse GetApgroupConfigByIdentityWithOptions(GetApgroupConfigByIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupConfigByIdentity",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupConfigByIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组的基本信息（名称之类）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupConfigByIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupConfigByIdentityResponse
        /// </returns>
        public async Task<GetApgroupConfigByIdentityResponse> GetApgroupConfigByIdentityWithOptionsAsync(GetApgroupConfigByIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupConfigByIdentity",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupConfigByIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组的基本信息（名称之类）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupConfigByIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupConfigByIdentityResponse
        /// </returns>
        public GetApgroupConfigByIdentityResponse GetApgroupConfigByIdentity(GetApgroupConfigByIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApgroupConfigByIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组的基本信息（名称之类）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupConfigByIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupConfigByIdentityResponse
        /// </returns>
        public async Task<GetApgroupConfigByIdentityResponse> GetApgroupConfigByIdentityAsync(GetApgroupConfigByIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApgroupConfigByIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组的完整配置(含ssid、portal等）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupDetailedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupDetailedConfigResponse
        /// </returns>
        public GetApgroupDetailedConfigResponse GetApgroupDetailedConfigWithOptions(GetApgroupDetailedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupDetailedConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupDetailedConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组的完整配置(含ssid、portal等）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupDetailedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupDetailedConfigResponse
        /// </returns>
        public async Task<GetApgroupDetailedConfigResponse> GetApgroupDetailedConfigWithOptionsAsync(GetApgroupDetailedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupDetailedConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupDetailedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组的完整配置(含ssid、portal等）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupDetailedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupDetailedConfigResponse
        /// </returns>
        public GetApgroupDetailedConfigResponse GetApgroupDetailedConfig(GetApgroupDetailedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApgroupDetailedConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组的完整配置(含ssid、portal等）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApgroupDetailedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupDetailedConfigResponse
        /// </returns>
        public async Task<GetApgroupDetailedConfigResponse> GetApgroupDetailedConfigAsync(GetApgroupDetailedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApgroupDetailedConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApgroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupIdResponse
        /// </returns>
        public GetApgroupIdResponse GetApgroupIdWithOptions(GetApgroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupId",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApgroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupIdResponse
        /// </returns>
        public async Task<GetApgroupIdResponse> GetApgroupIdWithOptionsAsync(GetApgroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupId",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApgroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupIdResponse
        /// </returns>
        public GetApgroupIdResponse GetApgroupId(GetApgroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApgroupIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApgroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupIdResponse
        /// </returns>
        public async Task<GetApgroupIdResponse> GetApgroupIdAsync(GetApgroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApgroupIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetApgroupSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupSsidConfigResponse
        /// </returns>
        public GetApgroupSsidConfigResponse GetApgroupSsidConfigWithOptions(GetApgroupSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupSsidConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApgroupSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupSsidConfigResponse
        /// </returns>
        public async Task<GetApgroupSsidConfigResponse> GetApgroupSsidConfigWithOptionsAsync(GetApgroupSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApgroupSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApgroupSsidConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetApgroupSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupSsidConfigResponse
        /// </returns>
        public GetApgroupSsidConfigResponse GetApgroupSsidConfig(GetApgroupSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApgroupSsidConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetApgroupSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApgroupSsidConfigResponse
        /// </returns>
        public async Task<GetApgroupSsidConfigResponse> GetApgroupSsidConfigAsync(GetApgroupSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApgroupSsidConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批量任务的执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskProgressResponse
        /// </returns>
        public GetBatchTaskProgressResponse GetBatchTaskProgressWithOptions(GetBatchTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
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
                Action = "GetBatchTaskProgress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批量任务的执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskProgressResponse
        /// </returns>
        public async Task<GetBatchTaskProgressResponse> GetBatchTaskProgressWithOptionsAsync(GetBatchTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
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
                Action = "GetBatchTaskProgress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批量任务的执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskProgressResponse
        /// </returns>
        public GetBatchTaskProgressResponse GetBatchTaskProgress(GetBatchTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchTaskProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批量任务的执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskProgressResponse
        /// </returns>
        public async Task<GetBatchTaskProgressResponse> GetBatchTaskProgressAsync(GetBatchTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchTaskProgressWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetGroupMiscAggTimeSerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupMiscAggTimeSerResponse
        /// </returns>
        public GetGroupMiscAggTimeSerResponse GetGroupMiscAggTimeSerWithOptions(GetGroupMiscAggTimeSerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroupMiscAggTimeSer",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupMiscAggTimeSerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetGroupMiscAggTimeSerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupMiscAggTimeSerResponse
        /// </returns>
        public async Task<GetGroupMiscAggTimeSerResponse> GetGroupMiscAggTimeSerWithOptionsAsync(GetGroupMiscAggTimeSerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroupMiscAggTimeSer",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupMiscAggTimeSerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetGroupMiscAggTimeSerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupMiscAggTimeSerResponse
        /// </returns>
        public GetGroupMiscAggTimeSerResponse GetGroupMiscAggTimeSer(GetGroupMiscAggTimeSerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupMiscAggTimeSerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetGroupMiscAggTimeSerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupMiscAggTimeSerResponse
        /// </returns>
        public async Task<GetGroupMiscAggTimeSerResponse> GetGroupMiscAggTimeSerAsync(GetGroupMiscAggTimeSerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupMiscAggTimeSerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoResponse
        /// </returns>
        public GetNetDeviceInfoResponse GetNetDeviceInfoWithOptions(GetNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idc))
            {
                query["Idc"] = request.Idc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicNetPod))
            {
                query["LogicNetPod"] = request.LogicNetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Manufacturer))
            {
                query["Manufacturer"] = request.Manufacturer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MgnIp))
            {
                query["MgnIp"] = request.MgnIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetPod))
            {
                query["NetPod"] = request.NetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTag))
            {
                query["ServiceTag"] = request.ServiceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoResponse
        /// </returns>
        public async Task<GetNetDeviceInfoResponse> GetNetDeviceInfoWithOptionsAsync(GetNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idc))
            {
                query["Idc"] = request.Idc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicNetPod))
            {
                query["LogicNetPod"] = request.LogicNetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Manufacturer))
            {
                query["Manufacturer"] = request.Manufacturer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MgnIp))
            {
                query["MgnIp"] = request.MgnIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetPod))
            {
                query["NetPod"] = request.NetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTag))
            {
                query["ServiceTag"] = request.ServiceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoResponse
        /// </returns>
        public GetNetDeviceInfoResponse GetNetDeviceInfo(GetNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNetDeviceInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoResponse
        /// </returns>
        public async Task<GetNetDeviceInfoResponse> GetNetDeviceInfoAsync(GetNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNetDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetNetDeviceInfoWithSizeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoWithSizeResponse
        /// </returns>
        public GetNetDeviceInfoWithSizeResponse GetNetDeviceInfoWithSizeWithOptions(GetNetDeviceInfoWithSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idc))
            {
                query["Idc"] = request.Idc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicNetPod))
            {
                query["LogicNetPod"] = request.LogicNetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Manufacturer))
            {
                query["Manufacturer"] = request.Manufacturer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MgnIp))
            {
                query["MgnIp"] = request.MgnIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetPod))
            {
                query["NetPod"] = request.NetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTag))
            {
                query["ServiceTag"] = request.ServiceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetDeviceInfoWithSize",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetDeviceInfoWithSizeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNetDeviceInfoWithSizeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoWithSizeResponse
        /// </returns>
        public async Task<GetNetDeviceInfoWithSizeResponse> GetNetDeviceInfoWithSizeWithOptionsAsync(GetNetDeviceInfoWithSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idc))
            {
                query["Idc"] = request.Idc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicNetPod))
            {
                query["LogicNetPod"] = request.LogicNetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Manufacturer))
            {
                query["Manufacturer"] = request.Manufacturer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MgnIp))
            {
                query["MgnIp"] = request.MgnIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetPod))
            {
                query["NetPod"] = request.NetPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTag))
            {
                query["ServiceTag"] = request.ServiceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetDeviceInfoWithSize",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetDeviceInfoWithSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNetDeviceInfoWithSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoWithSizeResponse
        /// </returns>
        public GetNetDeviceInfoWithSizeResponse GetNetDeviceInfoWithSize(GetNetDeviceInfoWithSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNetDeviceInfoWithSizeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetNetDeviceInfoWithSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetDeviceInfoWithSizeResponse
        /// </returns>
        public async Task<GetNetDeviceInfoWithSizeResponse> GetNetDeviceInfoWithSizeAsync(GetNetDeviceInfoWithSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNetDeviceInfoWithSizeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取体验加PV/UV信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageVisitDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPageVisitDataResponse
        /// </returns>
        public GetPageVisitDataResponse GetPageVisitDataWithOptions(GetPageVisitDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPageVisitData",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPageVisitDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取体验加PV/UV信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageVisitDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPageVisitDataResponse
        /// </returns>
        public async Task<GetPageVisitDataResponse> GetPageVisitDataWithOptionsAsync(GetPageVisitDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPageVisitData",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPageVisitDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取体验加PV/UV信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageVisitDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPageVisitDataResponse
        /// </returns>
        public GetPageVisitDataResponse GetPageVisitData(GetPageVisitDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPageVisitDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取体验加PV/UV信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageVisitDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPageVisitDataResponse
        /// </returns>
        public async Task<GetPageVisitDataResponse> GetPageVisitDataAsync(GetPageVisitDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPageVisitDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRadioRunHistoryTimeSerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRadioRunHistoryTimeSerResponse
        /// </returns>
        public GetRadioRunHistoryTimeSerResponse GetRadioRunHistoryTimeSerWithOptions(GetRadioRunHistoryTimeSerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRadioRunHistoryTimeSer",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRadioRunHistoryTimeSerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRadioRunHistoryTimeSerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRadioRunHistoryTimeSerResponse
        /// </returns>
        public async Task<GetRadioRunHistoryTimeSerResponse> GetRadioRunHistoryTimeSerWithOptionsAsync(GetRadioRunHistoryTimeSerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRadioRunHistoryTimeSer",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRadioRunHistoryTimeSerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRadioRunHistoryTimeSerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRadioRunHistoryTimeSerResponse
        /// </returns>
        public GetRadioRunHistoryTimeSerResponse GetRadioRunHistoryTimeSer(GetRadioRunHistoryTimeSerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRadioRunHistoryTimeSerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRadioRunHistoryTimeSerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRadioRunHistoryTimeSerResponse
        /// </returns>
        public async Task<GetRadioRunHistoryTimeSerResponse> GetRadioRunHistoryTimeSerAsync(GetRadioRunHistoryTimeSerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRadioRunHistoryTimeSerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端设备的详细状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaDetailedStatusByMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaDetailedStatusByMacResponse
        /// </returns>
        public GetStaDetailedStatusByMacResponse GetStaDetailedStatusByMacWithOptions(GetStaDetailedStatusByMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStaDetailedStatusByMac",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaDetailedStatusByMacResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端设备的详细状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaDetailedStatusByMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaDetailedStatusByMacResponse
        /// </returns>
        public async Task<GetStaDetailedStatusByMacResponse> GetStaDetailedStatusByMacWithOptionsAsync(GetStaDetailedStatusByMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStaDetailedStatusByMac",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaDetailedStatusByMacResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端设备的详细状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaDetailedStatusByMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaDetailedStatusByMacResponse
        /// </returns>
        public GetStaDetailedStatusByMacResponse GetStaDetailedStatusByMac(GetStaDetailedStatusByMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStaDetailedStatusByMacWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端设备的详细状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStaDetailedStatusByMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaDetailedStatusByMacResponse
        /// </returns>
        public async Task<GetStaDetailedStatusByMacResponse> GetStaDetailedStatusByMacAsync(GetStaDetailedStatusByMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStaDetailedStatusByMacWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetStaStatusListByApRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaStatusListByApResponse
        /// </returns>
        public GetStaStatusListByApResponse GetStaStatusListByApWithOptions(GetStaStatusListByApRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
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
                Action = "GetStaStatusListByAp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaStatusListByApResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetStaStatusListByApRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStaStatusListByApResponse
        /// </returns>
        public async Task<GetStaStatusListByApResponse> GetStaStatusListByApWithOptionsAsync(GetStaStatusListByApRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
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
                Action = "GetStaStatusListByAp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStaStatusListByApResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetStaStatusListByApRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaStatusListByApResponse
        /// </returns>
        public GetStaStatusListByApResponse GetStaStatusListByAp(GetStaStatusListByApRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStaStatusListByApWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetStaStatusListByApRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStaStatusListByApResponse
        /// </returns>
        public async Task<GetStaStatusListByApResponse> GetStaStatusListByApAsync(GetStaStatusListByApRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStaStatusListByApWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断是否刑天的业务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeXingTianBusinessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JudgeXingTianBusinessResponse
        /// </returns>
        public JudgeXingTianBusinessResponse JudgeXingTianBusinessWithOptions(JudgeXingTianBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealmId))
            {
                query["RealmId"] = request.RealmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JudgeXingTianBusiness",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JudgeXingTianBusinessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断是否刑天的业务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeXingTianBusinessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JudgeXingTianBusinessResponse
        /// </returns>
        public async Task<JudgeXingTianBusinessResponse> JudgeXingTianBusinessWithOptionsAsync(JudgeXingTianBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealmId))
            {
                query["RealmId"] = request.RealmId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JudgeXingTianBusiness",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JudgeXingTianBusinessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断是否刑天的业务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeXingTianBusinessRequest
        /// </param>
        /// 
        /// <returns>
        /// JudgeXingTianBusinessResponse
        /// </returns>
        public JudgeXingTianBusinessResponse JudgeXingTianBusiness(JudgeXingTianBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JudgeXingTianBusinessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>判断是否刑天的业务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JudgeXingTianBusinessRequest
        /// </param>
        /// 
        /// <returns>
        /// JudgeXingTianBusinessResponse
        /// </returns>
        public async Task<JudgeXingTianBusinessResponse> JudgeXingTianBusinessAsync(JudgeXingTianBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JudgeXingTianBusinessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢除蚂蚁环境的终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickAntStaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickAntStaResponse
        /// </returns>
        public KickAntStaResponse KickAntStaWithOptions(KickAntStaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickAntSta",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickAntStaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢除蚂蚁环境的终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickAntStaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickAntStaResponse
        /// </returns>
        public async Task<KickAntStaResponse> KickAntStaWithOptionsAsync(KickAntStaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickAntSta",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickAntStaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢除蚂蚁环境的终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickAntStaRequest
        /// </param>
        /// 
        /// <returns>
        /// KickAntStaResponse
        /// </returns>
        public KickAntStaResponse KickAntSta(KickAntStaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KickAntStaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>踢除蚂蚁环境的终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KickAntStaRequest
        /// </param>
        /// 
        /// <returns>
        /// KickAntStaResponse
        /// </returns>
        public async Task<KickAntStaResponse> KickAntStaAsync(KickAntStaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KickAntStaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// KickStaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickStaResponse
        /// </returns>
        public KickStaResponse KickStaWithOptions(KickStaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickSta",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickStaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// KickStaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KickStaResponse
        /// </returns>
        public async Task<KickStaResponse> KickStaWithOptionsAsync(KickStaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaMac))
            {
                query["StaMac"] = request.StaMac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KickSta",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KickStaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// KickStaRequest
        /// </param>
        /// 
        /// <returns>
        /// KickStaResponse
        /// </returns>
        public KickStaResponse KickSta(KickStaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KickStaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// KickStaRequest
        /// </param>
        /// 
        /// <returns>
        /// KickStaResponse
        /// </returns>
        public async Task<KickStaResponse> KickStaAsync(KickStaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KickStaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组内第一级子组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApgroupDescendantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApgroupDescendantResponse
        /// </returns>
        public ListApgroupDescendantResponse ListApgroupDescendantWithOptions(ListApgroupDescendantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
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
                Action = "ListApgroupDescendant",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApgroupDescendantResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组内第一级子组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApgroupDescendantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApgroupDescendantResponse
        /// </returns>
        public async Task<ListApgroupDescendantResponse> ListApgroupDescendantWithOptionsAsync(ListApgroupDescendantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupUuid))
            {
                query["ApgroupUuid"] = request.ApgroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
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
                Action = "ListApgroupDescendant",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApgroupDescendantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组内第一级子组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApgroupDescendantRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApgroupDescendantResponse
        /// </returns>
        public ListApgroupDescendantResponse ListApgroupDescendant(ListApgroupDescendantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApgroupDescendantWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据组id查组内第一级子组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApgroupDescendantRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApgroupDescendantResponse
        /// </returns>
        public async Task<ListApgroupDescendantResponse> ListApgroupDescendantAsync(ListApgroupDescendantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApgroupDescendantWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListJobOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersResponse
        /// </returns>
        public ListJobOrdersResponse ListJobOrdersWithOptions(ListJobOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangingType))
            {
                query["ChangingType"] = request.ChangingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystem))
            {
                query["ClientSystem"] = request.ClientSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUniqueId))
            {
                query["ClientUniqueId"] = request.ClientUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                query["Handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobOrders",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersResponse
        /// </returns>
        public async Task<ListJobOrdersResponse> ListJobOrdersWithOptionsAsync(ListJobOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangingType))
            {
                query["ChangingType"] = request.ChangingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystem))
            {
                query["ClientSystem"] = request.ClientSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUniqueId))
            {
                query["ClientUniqueId"] = request.ClientUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                query["Handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobOrders",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersResponse
        /// </returns>
        public ListJobOrdersResponse ListJobOrders(ListJobOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobOrdersWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListJobOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersResponse
        /// </returns>
        public async Task<ListJobOrdersResponse> ListJobOrdersAsync(ListJobOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobOrdersWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListJobOrdersWithSizeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersWithSizeResponse
        /// </returns>
        public ListJobOrdersWithSizeResponse ListJobOrdersWithSizeWithOptions(ListJobOrdersWithSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangingType))
            {
                query["ChangingType"] = request.ChangingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystem))
            {
                query["ClientSystem"] = request.ClientSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUniqueId))
            {
                query["ClientUniqueId"] = request.ClientUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                query["Handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobOrdersWithSize",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobOrdersWithSizeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobOrdersWithSizeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersWithSizeResponse
        /// </returns>
        public async Task<ListJobOrdersWithSizeResponse> ListJobOrdersWithSizeWithOptionsAsync(ListJobOrdersWithSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangingType))
            {
                query["ChangingType"] = request.ChangingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystem))
            {
                query["ClientSystem"] = request.ClientSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUniqueId))
            {
                query["ClientUniqueId"] = request.ClientUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                query["Handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobOrdersWithSize",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobOrdersWithSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListJobOrdersWithSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersWithSizeResponse
        /// </returns>
        public ListJobOrdersWithSizeResponse ListJobOrdersWithSize(ListJobOrdersWithSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobOrdersWithSizeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListJobOrdersWithSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobOrdersWithSizeResponse
        /// </returns>
        public async Task<ListJobOrdersWithSizeResponse> ListJobOrdersWithSizeAsync(ListJobOrdersWithSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobOrdersWithSizeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// NewApgroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NewApgroupConfigResponse
        /// </returns>
        public NewApgroupConfigResponse NewApgroupConfigWithOptions(NewApgroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentApgroupId))
            {
                query["ParentApgroupId"] = request.ParentApgroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NewApgroupConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NewApgroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// NewApgroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NewApgroupConfigResponse
        /// </returns>
        public async Task<NewApgroupConfigResponse> NewApgroupConfigWithOptionsAsync(NewApgroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentApgroupId))
            {
                query["ParentApgroupId"] = request.ParentApgroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NewApgroupConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NewApgroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// NewApgroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// NewApgroupConfigResponse
        /// </returns>
        public NewApgroupConfigResponse NewApgroupConfig(NewApgroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NewApgroupConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// NewApgroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// NewApgroupConfigResponse
        /// </returns>
        public async Task<NewApgroupConfigResponse> NewApgroupConfigAsync(NewApgroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NewApgroupConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// NewJobOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NewJobOrderResponse
        /// </returns>
        public NewJobOrderResponse NewJobOrderWithOptions(NewJobOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            NewJobOrderShrinkRequest request = new NewJobOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeType))
            {
                query["ChangeType"] = request.ChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystem))
            {
                query["ClientSystem"] = request.ClientSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUniqueId))
            {
                query["ClientUniqueId"] = request.ClientUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferUrl))
            {
                query["ReferUrl"] = request.ReferUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NewJobOrder",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NewJobOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// NewJobOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NewJobOrderResponse
        /// </returns>
        public async Task<NewJobOrderResponse> NewJobOrderWithOptionsAsync(NewJobOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            NewJobOrderShrinkRequest request = new NewJobOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeType))
            {
                query["ChangeType"] = request.ChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystem))
            {
                query["ClientSystem"] = request.ClientSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUniqueId))
            {
                query["ClientUniqueId"] = request.ClientUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferUrl))
            {
                query["ReferUrl"] = request.ReferUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NewJobOrder",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NewJobOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// NewJobOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// NewJobOrderResponse
        /// </returns>
        public NewJobOrderResponse NewJobOrder(NewJobOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NewJobOrderWithOptions(request, runtime);
        }

        /// <param name="request">
        /// NewJobOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// NewJobOrderResponse
        /// </returns>
        public async Task<NewJobOrderResponse> NewJobOrderAsync(NewJobOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NewJobOrderWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// NewNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NewNetDeviceInfoResponse
        /// </returns>
        public NewNetDeviceInfoResponse NewNetDeviceInfoWithOptions(NewNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["Devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NewNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NewNetDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// NewNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NewNetDeviceInfoResponse
        /// </returns>
        public async Task<NewNetDeviceInfoResponse> NewNetDeviceInfoWithOptionsAsync(NewNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["Devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NewNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NewNetDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// NewNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// NewNetDeviceInfoResponse
        /// </returns>
        public NewNetDeviceInfoResponse NewNetDeviceInfo(NewNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NewNetDeviceInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// NewNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// NewNetDeviceInfoResponse
        /// </returns>
        public async Task<NewNetDeviceInfoResponse> NewNetDeviceInfoAsync(NewNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NewNetDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PutAppConfigAndSaveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutAppConfigAndSaveResponse
        /// </returns>
        public PutAppConfigAndSaveResponse PutAppConfigAndSaveWithOptions(PutAppConfigAndSaveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureType))
            {
                query["ConfigureType"] = request.ConfigureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentTime))
            {
                query["CurrentTime"] = request.CurrentTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAppConfigAndSave",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutAppConfigAndSaveResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PutAppConfigAndSaveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutAppConfigAndSaveResponse
        /// </returns>
        public async Task<PutAppConfigAndSaveResponse> PutAppConfigAndSaveWithOptionsAsync(PutAppConfigAndSaveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureType))
            {
                query["ConfigureType"] = request.ConfigureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentTime))
            {
                query["CurrentTime"] = request.CurrentTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAppConfigAndSave",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutAppConfigAndSaveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PutAppConfigAndSaveRequest
        /// </param>
        /// 
        /// <returns>
        /// PutAppConfigAndSaveResponse
        /// </returns>
        public PutAppConfigAndSaveResponse PutAppConfigAndSave(PutAppConfigAndSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutAppConfigAndSaveWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PutAppConfigAndSaveRequest
        /// </param>
        /// 
        /// <returns>
        /// PutAppConfigAndSaveResponse
        /// </returns>
        public async Task<PutAppConfigAndSaveResponse> PutAppConfigAndSaveAsync(PutAppConfigAndSaveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutAppConfigAndSaveWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryJobOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryJobOrderResponse
        /// </returns>
        public QueryJobOrderResponse QueryJobOrderWithOptions(QueryJobOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryJobOrder",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryJobOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryJobOrderResponse
        /// </returns>
        public async Task<QueryJobOrderResponse> QueryJobOrderWithOptionsAsync(QueryJobOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryJobOrder",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryJobOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryJobOrderResponse
        /// </returns>
        public QueryJobOrderResponse QueryJobOrder(QueryJobOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobOrderWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryJobOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryJobOrderResponse
        /// </returns>
        public async Task<QueryJobOrderResponse> QueryJobOrderAsync(QueryJobOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobOrderWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RebootApRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootApResponse
        /// </returns>
        public RebootApResponse RebootApWithOptions(RebootApRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootAp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootApResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RebootApRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootApResponse
        /// </returns>
        public async Task<RebootApResponse> RebootApWithOptionsAsync(RebootApRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootAp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootApResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RebootApRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootApResponse
        /// </returns>
        public RebootApResponse RebootAp(RebootApRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootApWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RebootApRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootApResponse
        /// </returns>
        public async Task<RebootApResponse> RebootApAsync(RebootApRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootApWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RegisterApAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterApAssetResponse
        /// </returns>
        public RegisterApAssetResponse RegisterApAssetWithOptions(RegisterApAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterApAsset",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterApAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RegisterApAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterApAssetResponse
        /// </returns>
        public async Task<RegisterApAssetResponse> RegisterApAssetWithOptionsAsync(RegisterApAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroupUUId))
            {
                query["ApGroupUUId"] = request.ApGroupUUId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterApAsset",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterApAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RegisterApAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterApAssetResponse
        /// </returns>
        public RegisterApAssetResponse RegisterApAsset(RegisterApAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterApAssetWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RegisterApAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterApAssetResponse
        /// </returns>
        public async Task<RegisterApAssetResponse> RegisterApAssetAsync(RegisterApAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterApAssetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RepairApRadioRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RepairApRadioResponse
        /// </returns>
        public RepairApRadioResponse RepairApRadioWithOptions(RepairApRadioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RadioIndex))
            {
                query["RadioIndex"] = request.RadioIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepairApRadio",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepairApRadioResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RepairApRadioRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RepairApRadioResponse
        /// </returns>
        public async Task<RepairApRadioResponse> RepairApRadioWithOptionsAsync(RepairApRadioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RadioIndex))
            {
                query["RadioIndex"] = request.RadioIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepairApRadio",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepairApRadioResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RepairApRadioRequest
        /// </param>
        /// 
        /// <returns>
        /// RepairApRadioResponse
        /// </returns>
        public RepairApRadioResponse RepairApRadio(RepairApRadioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RepairApRadioWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RepairApRadioRequest
        /// </param>
        /// 
        /// <returns>
        /// RepairApRadioResponse
        /// </returns>
        public async Task<RepairApRadioResponse> RepairApRadioAsync(RepairApRadioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RepairApRadioWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApBasicConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApBasicConfigResponse
        /// </returns>
        public SaveApBasicConfigResponse SaveApBasicConfigWithOptions(SaveApBasicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dai))
            {
                query["Dai"] = request.Dai;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EchoInt))
            {
                query["EchoInt"] = request.EchoInt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Failover))
            {
                query["Failover"] = request.Failover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureAllowed))
            {
                query["InsecureAllowed"] = request.InsecureAllowed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanIp))
            {
                query["LanIp"] = request.LanIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanMask))
            {
                query["LanMask"] = request.LanMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanStatus))
            {
                query["LanStatus"] = request.LanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogIp))
            {
                query["LogIp"] = request.LogIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                query["LogLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Passwd))
            {
                query["Passwd"] = request.Passwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Route))
            {
                query["Route"] = request.Route;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scan))
            {
                query["Scan"] = request.Scan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenServer))
            {
                query["TokenServer"] = request.TokenServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vpn))
            {
                query["Vpn"] = request.Vpn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkMode))
            {
                query["WorkMode"] = request.WorkMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApBasicConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApBasicConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApBasicConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApBasicConfigResponse
        /// </returns>
        public async Task<SaveApBasicConfigResponse> SaveApBasicConfigWithOptionsAsync(SaveApBasicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dai))
            {
                query["Dai"] = request.Dai;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EchoInt))
            {
                query["EchoInt"] = request.EchoInt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Failover))
            {
                query["Failover"] = request.Failover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureAllowed))
            {
                query["InsecureAllowed"] = request.InsecureAllowed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanIp))
            {
                query["LanIp"] = request.LanIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanMask))
            {
                query["LanMask"] = request.LanMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanStatus))
            {
                query["LanStatus"] = request.LanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogIp))
            {
                query["LogIp"] = request.LogIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                query["LogLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Passwd))
            {
                query["Passwd"] = request.Passwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Route))
            {
                query["Route"] = request.Route;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scan))
            {
                query["Scan"] = request.Scan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenServer))
            {
                query["TokenServer"] = request.TokenServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vpn))
            {
                query["Vpn"] = request.Vpn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkMode))
            {
                query["WorkMode"] = request.WorkMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApBasicConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApBasicConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApBasicConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApBasicConfigResponse
        /// </returns>
        public SaveApBasicConfigResponse SaveApBasicConfig(SaveApBasicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApBasicConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApBasicConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApBasicConfigResponse
        /// </returns>
        public async Task<SaveApBasicConfigResponse> SaveApBasicConfigAsync(SaveApBasicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApBasicConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的portal</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveApPortalConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApPortalConfigResponse
        /// </returns>
        public SaveApPortalConfigResponse SaveApPortalConfigWithOptions(SaveApPortalConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveApPortalConfigShrinkRequest request = new SaveApPortalConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortalTypes))
            {
                request.PortalTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortalTypes, "PortalTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApConfigId))
            {
                query["ApConfigId"] = request.ApConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAuthUrl))
            {
                query["AppAuthUrl"] = request.AppAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientDownload))
            {
                query["ClientDownload"] = request.ClientDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUpload))
            {
                query["ClientUpload"] = request.ClientUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Countdown))
            {
                query["Countdown"] = request.Countdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalTypesShrink))
            {
                query["PortalTypes"] = request.PortalTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalUrl))
            {
                query["PortalUrl"] = request.PortalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalDownload))
            {
                query["TotalDownload"] = request.TotalDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalUpload))
            {
                query["TotalUpload"] = request.TotalUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAuthUrl))
            {
                query["WebAuthUrl"] = request.WebAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                query["Whitelist"] = request.Whitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApPortalConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApPortalConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的portal</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveApPortalConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApPortalConfigResponse
        /// </returns>
        public async Task<SaveApPortalConfigResponse> SaveApPortalConfigWithOptionsAsync(SaveApPortalConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveApPortalConfigShrinkRequest request = new SaveApPortalConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortalTypes))
            {
                request.PortalTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortalTypes, "PortalTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApConfigId))
            {
                query["ApConfigId"] = request.ApConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAuthUrl))
            {
                query["AppAuthUrl"] = request.AppAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientDownload))
            {
                query["ClientDownload"] = request.ClientDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUpload))
            {
                query["ClientUpload"] = request.ClientUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Countdown))
            {
                query["Countdown"] = request.Countdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalTypesShrink))
            {
                query["PortalTypes"] = request.PortalTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalUrl))
            {
                query["PortalUrl"] = request.PortalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalDownload))
            {
                query["TotalDownload"] = request.TotalDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalUpload))
            {
                query["TotalUpload"] = request.TotalUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAuthUrl))
            {
                query["WebAuthUrl"] = request.WebAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                query["Whitelist"] = request.Whitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApPortalConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApPortalConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的portal</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApPortalConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApPortalConfigResponse
        /// </returns>
        public SaveApPortalConfigResponse SaveApPortalConfig(SaveApPortalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApPortalConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的portal</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApPortalConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApPortalConfigResponse
        /// </returns>
        public async Task<SaveApPortalConfigResponse> SaveApPortalConfigAsync(SaveApPortalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApPortalConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveApRadioConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApRadioConfigResponse
        /// </returns>
        public SaveApRadioConfigResponse SaveApRadioConfigWithOptions(SaveApRadioConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcastRate))
            {
                query["BcastRate"] = request.BcastRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeaconInt))
            {
                query["BeaconInt"] = request.BeaconInt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frag))
            {
                query["Frag"] = request.Frag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Htmode))
            {
                query["Htmode"] = request.Htmode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hwmode))
            {
                query["Hwmode"] = request.Hwmode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McastRate))
            {
                query["McastRate"] = request.McastRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MgmtRate))
            {
                query["MgmtRate"] = request.MgmtRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minrate))
            {
                query["Minrate"] = request.Minrate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Noscan))
            {
                query["Noscan"] = request.Noscan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Probereq))
            {
                query["Probereq"] = request.Probereq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireMode))
            {
                query["RequireMode"] = request.RequireMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rts))
            {
                query["Rts"] = request.Rts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shortgi))
            {
                query["Shortgi"] = request.Shortgi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Txpower))
            {
                query["Txpower"] = request.Txpower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uapsd))
            {
                query["Uapsd"] = request.Uapsd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApRadioConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApRadioConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveApRadioConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApRadioConfigResponse
        /// </returns>
        public async Task<SaveApRadioConfigResponse> SaveApRadioConfigWithOptionsAsync(SaveApRadioConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcastRate))
            {
                query["BcastRate"] = request.BcastRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeaconInt))
            {
                query["BeaconInt"] = request.BeaconInt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frag))
            {
                query["Frag"] = request.Frag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Htmode))
            {
                query["Htmode"] = request.Htmode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hwmode))
            {
                query["Hwmode"] = request.Hwmode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McastRate))
            {
                query["McastRate"] = request.McastRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MgmtRate))
            {
                query["MgmtRate"] = request.MgmtRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Minrate))
            {
                query["Minrate"] = request.Minrate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Noscan))
            {
                query["Noscan"] = request.Noscan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Probereq))
            {
                query["Probereq"] = request.Probereq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireMode))
            {
                query["RequireMode"] = request.RequireMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rts))
            {
                query["Rts"] = request.Rts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shortgi))
            {
                query["Shortgi"] = request.Shortgi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Txpower))
            {
                query["Txpower"] = request.Txpower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uapsd))
            {
                query["Uapsd"] = request.Uapsd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApRadioConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApRadioConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveApRadioConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApRadioConfigResponse
        /// </returns>
        public SaveApRadioConfigResponse SaveApRadioConfig(SaveApRadioConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApRadioConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveApRadioConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApRadioConfigResponse
        /// </returns>
        public async Task<SaveApRadioConfigResponse> SaveApRadioConfigAsync(SaveApRadioConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApRadioConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveApSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApSsidConfigResponse
        /// </returns>
        public SaveApSsidConfigResponse SaveApSsidConfigWithOptions(SaveApSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctPort))
            {
                query["AcctPort"] = request.AcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctSecret))
            {
                query["AcctSecret"] = request.AcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctServer))
            {
                query["AcctServer"] = request.AcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctStatusServerWork))
            {
                query["AcctStatusServerWork"] = request.AcctStatusServerWork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAssetId))
            {
                query["ApAssetId"] = request.ApAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArpProxyEnable))
            {
                query["ArpProxyEnable"] = request.ArpProxyEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCache))
            {
                query["AuthCache"] = request.AuthCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPort))
            {
                query["AuthPort"] = request.AuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthServer))
            {
                query["AuthServer"] = request.AuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatusServerWork))
            {
                query["AuthStatusServerWork"] = request.AuthStatusServerWork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cir))
            {
                query["Cir"] = request.Cir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CirStep))
            {
                query["CirStep"] = request.CirStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CirType))
            {
                query["CirType"] = request.CirType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CirUl))
            {
                query["CirUl"] = request.CirUl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeClient))
            {
                query["DaeClient"] = request.DaeClient;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaePort))
            {
                query["DaePort"] = request.DaePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeSecret))
            {
                query["DaeSecret"] = request.DaeSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocLowAck))
            {
                query["DisassocLowAck"] = request.DisassocLowAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocWeakRssi))
            {
                query["DisassocWeakRssi"] = request.DisassocWeakRssi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicVlan))
            {
                query["DynamicVlan"] = request.DynamicVlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncKey))
            {
                query["EncKey"] = request.EncKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["Encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FourthAuthPort))
            {
                query["FourthAuthPort"] = request.FourthAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FourthAuthSecret))
            {
                query["FourthAuthSecret"] = request.FourthAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FourthAuthServer))
            {
                query["FourthAuthServer"] = request.FourthAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FtOverDs))
            {
                query["FtOverDs"] = request.FtOverDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                query["Hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ieee80211r))
            {
                query["Ieee80211r"] = request.Ieee80211r;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ieee80211w))
            {
                query["Ieee80211w"] = request.Ieee80211w;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreWeakProbe))
            {
                query["IgnoreWeakProbe"] = request.IgnoreWeakProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isolate))
            {
                query["Isolate"] = request.Isolate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiteEffect))
            {
                query["LiteEffect"] = request.LiteEffect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInactivity))
            {
                query["MaxInactivity"] = request.MaxInactivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maxassoc))
            {
                query["Maxassoc"] = request.Maxassoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilityDomain))
            {
                query["MobilityDomain"] = request.MobilityDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MulticastForward))
            {
                query["MulticastForward"] = request.MulticastForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nasid))
            {
                query["Nasid"] = request.Nasid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NdProxyWork))
            {
                query["NdProxyWork"] = request.NdProxyWork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ownip))
            {
                query["Ownip"] = request.Ownip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RadioIndex))
            {
                query["RadioIndex"] = request.RadioIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctPort))
            {
                query["SecondaryAcctPort"] = request.SecondaryAcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctSecret))
            {
                query["SecondaryAcctSecret"] = request.SecondaryAcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctServer))
            {
                query["SecondaryAcctServer"] = request.SecondaryAcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthPort))
            {
                query["SecondaryAuthPort"] = request.SecondaryAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthSecret))
            {
                query["SecondaryAuthSecret"] = request.SecondaryAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthServer))
            {
                query["SecondaryAuthServer"] = request.SecondaryAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfigToAp))
            {
                query["SendConfigToAp"] = request.SendConfigToAp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortPreamble))
            {
                query["ShortPreamble"] = request.ShortPreamble;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ssid))
            {
                query["Ssid"] = request.Ssid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsidLb))
            {
                query["SsidLb"] = request.SsidLb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAuthPort))
            {
                query["ThirdAuthPort"] = request.ThirdAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAuthSecret))
            {
                query["ThirdAuthSecret"] = request.ThirdAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAuthServer))
            {
                query["ThirdAuthServer"] = request.ThirdAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VlanDhcp))
            {
                query["VlanDhcp"] = request.VlanDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wmm))
            {
                query["Wmm"] = request.Wmm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApSsidConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveApSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApSsidConfigResponse
        /// </returns>
        public async Task<SaveApSsidConfigResponse> SaveApSsidConfigWithOptionsAsync(SaveApSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctPort))
            {
                query["AcctPort"] = request.AcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctSecret))
            {
                query["AcctSecret"] = request.AcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctServer))
            {
                query["AcctServer"] = request.AcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctStatusServerWork))
            {
                query["AcctStatusServerWork"] = request.AcctStatusServerWork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAssetId))
            {
                query["ApAssetId"] = request.ApAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArpProxyEnable))
            {
                query["ArpProxyEnable"] = request.ArpProxyEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCache))
            {
                query["AuthCache"] = request.AuthCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPort))
            {
                query["AuthPort"] = request.AuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthServer))
            {
                query["AuthServer"] = request.AuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatusServerWork))
            {
                query["AuthStatusServerWork"] = request.AuthStatusServerWork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cir))
            {
                query["Cir"] = request.Cir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CirStep))
            {
                query["CirStep"] = request.CirStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CirType))
            {
                query["CirType"] = request.CirType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CirUl))
            {
                query["CirUl"] = request.CirUl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeClient))
            {
                query["DaeClient"] = request.DaeClient;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaePort))
            {
                query["DaePort"] = request.DaePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeSecret))
            {
                query["DaeSecret"] = request.DaeSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocLowAck))
            {
                query["DisassocLowAck"] = request.DisassocLowAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocWeakRssi))
            {
                query["DisassocWeakRssi"] = request.DisassocWeakRssi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicVlan))
            {
                query["DynamicVlan"] = request.DynamicVlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncKey))
            {
                query["EncKey"] = request.EncKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["Encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FourthAuthPort))
            {
                query["FourthAuthPort"] = request.FourthAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FourthAuthSecret))
            {
                query["FourthAuthSecret"] = request.FourthAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FourthAuthServer))
            {
                query["FourthAuthServer"] = request.FourthAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FtOverDs))
            {
                query["FtOverDs"] = request.FtOverDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                query["Hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ieee80211r))
            {
                query["Ieee80211r"] = request.Ieee80211r;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ieee80211w))
            {
                query["Ieee80211w"] = request.Ieee80211w;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreWeakProbe))
            {
                query["IgnoreWeakProbe"] = request.IgnoreWeakProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isolate))
            {
                query["Isolate"] = request.Isolate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiteEffect))
            {
                query["LiteEffect"] = request.LiteEffect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInactivity))
            {
                query["MaxInactivity"] = request.MaxInactivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maxassoc))
            {
                query["Maxassoc"] = request.Maxassoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilityDomain))
            {
                query["MobilityDomain"] = request.MobilityDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MulticastForward))
            {
                query["MulticastForward"] = request.MulticastForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nasid))
            {
                query["Nasid"] = request.Nasid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NdProxyWork))
            {
                query["NdProxyWork"] = request.NdProxyWork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ownip))
            {
                query["Ownip"] = request.Ownip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RadioIndex))
            {
                query["RadioIndex"] = request.RadioIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctPort))
            {
                query["SecondaryAcctPort"] = request.SecondaryAcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctSecret))
            {
                query["SecondaryAcctSecret"] = request.SecondaryAcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctServer))
            {
                query["SecondaryAcctServer"] = request.SecondaryAcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthPort))
            {
                query["SecondaryAuthPort"] = request.SecondaryAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthSecret))
            {
                query["SecondaryAuthSecret"] = request.SecondaryAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthServer))
            {
                query["SecondaryAuthServer"] = request.SecondaryAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfigToAp))
            {
                query["SendConfigToAp"] = request.SendConfigToAp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortPreamble))
            {
                query["ShortPreamble"] = request.ShortPreamble;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ssid))
            {
                query["Ssid"] = request.Ssid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsidLb))
            {
                query["SsidLb"] = request.SsidLb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAuthPort))
            {
                query["ThirdAuthPort"] = request.ThirdAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAuthSecret))
            {
                query["ThirdAuthSecret"] = request.ThirdAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAuthServer))
            {
                query["ThirdAuthServer"] = request.ThirdAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VlanDhcp))
            {
                query["VlanDhcp"] = request.VlanDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wmm))
            {
                query["Wmm"] = request.Wmm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApSsidConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveApSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApSsidConfigResponse
        /// </returns>
        public SaveApSsidConfigResponse SaveApSsidConfig(SaveApSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApSsidConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveApSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApSsidConfigResponse
        /// </returns>
        public async Task<SaveApSsidConfigResponse> SaveApSsidConfigAsync(SaveApSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApSsidConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApThirdAppResponse
        /// </returns>
        public SaveApThirdAppResponse SaveApThirdAppWithOptions(SaveApThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddStyle))
            {
                query["AddStyle"] = request.AddStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAssetId))
            {
                query["ApAssetId"] = request.ApAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppData))
            {
                query["AppData"] = request.AppData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAppName))
            {
                query["ThirdAppName"] = request.ThirdAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApThirdAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApThirdAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApThirdAppResponse
        /// </returns>
        public async Task<SaveApThirdAppResponse> SaveApThirdAppWithOptionsAsync(SaveApThirdAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddStyle))
            {
                query["AddStyle"] = request.AddStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAssetId))
            {
                query["ApAssetId"] = request.ApAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppData))
            {
                query["AppData"] = request.AppData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdAppName))
            {
                query["ThirdAppName"] = request.ThirdAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApThirdApp",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApThirdAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApThirdAppResponse
        /// </returns>
        public SaveApThirdAppResponse SaveApThirdApp(SaveApThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApThirdAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备的三方app</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApThirdAppRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApThirdAppResponse
        /// </returns>
        public async Task<SaveApThirdAppResponse> SaveApThirdAppAsync(SaveApThirdAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApThirdAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备组的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApgroupBasicConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupBasicConfigResponse
        /// </returns>
        public SaveApgroupBasicConfigResponse SaveApgroupBasicConfigWithOptions(SaveApgroupBasicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dai))
            {
                query["Dai"] = request.Dai;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EchoInt))
            {
                query["EchoInt"] = request.EchoInt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Failover))
            {
                query["Failover"] = request.Failover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureAllowed))
            {
                query["InsecureAllowed"] = request.InsecureAllowed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsConfigStrongConsistency))
            {
                query["IsConfigStrongConsistency"] = request.IsConfigStrongConsistency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanIp))
            {
                query["LanIp"] = request.LanIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanMask))
            {
                query["LanMask"] = request.LanMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanStatus))
            {
                query["LanStatus"] = request.LanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogIp))
            {
                query["LogIp"] = request.LogIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                query["LogLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentApgroupId))
            {
                query["ParentApgroupId"] = request.ParentApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Passwd))
            {
                query["Passwd"] = request.Passwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Route))
            {
                query["Route"] = request.Route;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scan))
            {
                query["Scan"] = request.Scan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenServer))
            {
                query["TokenServer"] = request.TokenServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vpn))
            {
                query["Vpn"] = request.Vpn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkMode))
            {
                query["WorkMode"] = request.WorkMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApgroupBasicConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApgroupBasicConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备组的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApgroupBasicConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupBasicConfigResponse
        /// </returns>
        public async Task<SaveApgroupBasicConfigResponse> SaveApgroupBasicConfigWithOptionsAsync(SaveApgroupBasicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dai))
            {
                query["Dai"] = request.Dai;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EchoInt))
            {
                query["EchoInt"] = request.EchoInt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Failover))
            {
                query["Failover"] = request.Failover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureAllowed))
            {
                query["InsecureAllowed"] = request.InsecureAllowed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsConfigStrongConsistency))
            {
                query["IsConfigStrongConsistency"] = request.IsConfigStrongConsistency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanIp))
            {
                query["LanIp"] = request.LanIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanMask))
            {
                query["LanMask"] = request.LanMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanStatus))
            {
                query["LanStatus"] = request.LanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogIp))
            {
                query["LogIp"] = request.LogIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                query["LogLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentApgroupId))
            {
                query["ParentApgroupId"] = request.ParentApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Passwd))
            {
                query["Passwd"] = request.Passwd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Route))
            {
                query["Route"] = request.Route;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scan))
            {
                query["Scan"] = request.Scan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenServer))
            {
                query["TokenServer"] = request.TokenServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vpn))
            {
                query["Vpn"] = request.Vpn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkMode))
            {
                query["WorkMode"] = request.WorkMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApgroupBasicConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApgroupBasicConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备组的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApgroupBasicConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupBasicConfigResponse
        /// </returns>
        public SaveApgroupBasicConfigResponse SaveApgroupBasicConfig(SaveApgroupBasicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApgroupBasicConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存设备组的基本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApgroupBasicConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupBasicConfigResponse
        /// </returns>
        public async Task<SaveApgroupBasicConfigResponse> SaveApgroupBasicConfigAsync(SaveApgroupBasicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApgroupBasicConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的portal</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveApgroupPortalConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupPortalConfigResponse
        /// </returns>
        public SaveApgroupPortalConfigResponse SaveApgroupPortalConfigWithOptions(SaveApgroupPortalConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveApgroupPortalConfigShrinkRequest request = new SaveApgroupPortalConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortalTypes))
            {
                request.PortalTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortalTypes, "PortalTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAuthUrl))
            {
                query["AppAuthUrl"] = request.AppAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientDownload))
            {
                query["ClientDownload"] = request.ClientDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUpload))
            {
                query["ClientUpload"] = request.ClientUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Countdown))
            {
                query["Countdown"] = request.Countdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalTypesShrink))
            {
                query["PortalTypes"] = request.PortalTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalUrl))
            {
                query["PortalUrl"] = request.PortalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalDownload))
            {
                query["TotalDownload"] = request.TotalDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalUpload))
            {
                query["TotalUpload"] = request.TotalUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAuthUrl))
            {
                query["WebAuthUrl"] = request.WebAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                query["Whitelist"] = request.Whitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApgroupPortalConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApgroupPortalConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的portal</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveApgroupPortalConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupPortalConfigResponse
        /// </returns>
        public async Task<SaveApgroupPortalConfigResponse> SaveApgroupPortalConfigWithOptionsAsync(SaveApgroupPortalConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveApgroupPortalConfigShrinkRequest request = new SaveApgroupPortalConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortalTypes))
            {
                request.PortalTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortalTypes, "PortalTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppAuthUrl))
            {
                query["AppAuthUrl"] = request.AppAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientDownload))
            {
                query["ClientDownload"] = request.ClientDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUpload))
            {
                query["ClientUpload"] = request.ClientUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Countdown))
            {
                query["Countdown"] = request.Countdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalTypesShrink))
            {
                query["PortalTypes"] = request.PortalTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortalUrl))
            {
                query["PortalUrl"] = request.PortalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalDownload))
            {
                query["TotalDownload"] = request.TotalDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalUpload))
            {
                query["TotalUpload"] = request.TotalUpload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAuthUrl))
            {
                query["WebAuthUrl"] = request.WebAuthUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                query["Whitelist"] = request.Whitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApgroupPortalConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApgroupPortalConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的portal</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApgroupPortalConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupPortalConfigResponse
        /// </returns>
        public SaveApgroupPortalConfigResponse SaveApgroupPortalConfig(SaveApgroupPortalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApgroupPortalConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置设备组的portal</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveApgroupPortalConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupPortalConfigResponse
        /// </returns>
        public async Task<SaveApgroupPortalConfigResponse> SaveApgroupPortalConfigAsync(SaveApgroupPortalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApgroupPortalConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveApgroupSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupSsidConfigResponse
        /// </returns>
        public SaveApgroupSsidConfigResponse SaveApgroupSsidConfigWithOptions(SaveApgroupSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctPort))
            {
                query["AcctPort"] = request.AcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctSecret))
            {
                query["AcctSecret"] = request.AcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctServer))
            {
                query["AcctServer"] = request.AcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCache))
            {
                query["AuthCache"] = request.AuthCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPort))
            {
                query["AuthPort"] = request.AuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthServer))
            {
                query["AuthServer"] = request.AuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Binding))
            {
                query["Binding"] = request.Binding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cir))
            {
                query["Cir"] = request.Cir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeClient))
            {
                query["DaeClient"] = request.DaeClient;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaePort))
            {
                query["DaePort"] = request.DaePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeSecret))
            {
                query["DaeSecret"] = request.DaeSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocLowAck))
            {
                query["DisassocLowAck"] = request.DisassocLowAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocWeakRssi))
            {
                query["DisassocWeakRssi"] = request.DisassocWeakRssi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicVlan))
            {
                query["DynamicVlan"] = request.DynamicVlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                query["Effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncKey))
            {
                query["EncKey"] = request.EncKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["Encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                query["Hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ieee80211w))
            {
                query["Ieee80211w"] = request.Ieee80211w;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreWeakProbe))
            {
                query["IgnoreWeakProbe"] = request.IgnoreWeakProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isolate))
            {
                query["Isolate"] = request.Isolate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiteEffect))
            {
                query["LiteEffect"] = request.LiteEffect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInactivity))
            {
                query["MaxInactivity"] = request.MaxInactivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maxassoc))
            {
                query["Maxassoc"] = request.Maxassoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MulticastForward))
            {
                query["MulticastForward"] = request.MulticastForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nasid))
            {
                query["Nasid"] = request.Nasid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSsid))
            {
                query["NewSsid"] = request.NewSsid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ownip))
            {
                query["Ownip"] = request.Ownip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctPort))
            {
                query["SecondaryAcctPort"] = request.SecondaryAcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctSecret))
            {
                query["SecondaryAcctSecret"] = request.SecondaryAcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctServer))
            {
                query["SecondaryAcctServer"] = request.SecondaryAcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthPort))
            {
                query["SecondaryAuthPort"] = request.SecondaryAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthSecret))
            {
                query["SecondaryAuthSecret"] = request.SecondaryAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthServer))
            {
                query["SecondaryAuthServer"] = request.SecondaryAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortPreamble))
            {
                query["ShortPreamble"] = request.ShortPreamble;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ssid))
            {
                query["Ssid"] = request.Ssid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsidLb))
            {
                query["SsidLb"] = request.SsidLb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VlanDhcp))
            {
                query["VlanDhcp"] = request.VlanDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wmm))
            {
                query["Wmm"] = request.Wmm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApgroupSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApgroupSsidConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveApgroupSsidConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupSsidConfigResponse
        /// </returns>
        public async Task<SaveApgroupSsidConfigResponse> SaveApgroupSsidConfigWithOptionsAsync(SaveApgroupSsidConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctPort))
            {
                query["AcctPort"] = request.AcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctSecret))
            {
                query["AcctSecret"] = request.AcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcctServer))
            {
                query["AcctServer"] = request.AcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApgroupId))
            {
                query["ApgroupId"] = request.ApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCache))
            {
                query["AuthCache"] = request.AuthCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPort))
            {
                query["AuthPort"] = request.AuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSecret))
            {
                query["AuthSecret"] = request.AuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthServer))
            {
                query["AuthServer"] = request.AuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Binding))
            {
                query["Binding"] = request.Binding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cir))
            {
                query["Cir"] = request.Cir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeClient))
            {
                query["DaeClient"] = request.DaeClient;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaePort))
            {
                query["DaePort"] = request.DaePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaeSecret))
            {
                query["DaeSecret"] = request.DaeSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocLowAck))
            {
                query["DisassocLowAck"] = request.DisassocLowAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassocWeakRssi))
            {
                query["DisassocWeakRssi"] = request.DisassocWeakRssi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicVlan))
            {
                query["DynamicVlan"] = request.DynamicVlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                query["Effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncKey))
            {
                query["EncKey"] = request.EncKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["Encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                query["Hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ieee80211w))
            {
                query["Ieee80211w"] = request.Ieee80211w;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreWeakProbe))
            {
                query["IgnoreWeakProbe"] = request.IgnoreWeakProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isolate))
            {
                query["Isolate"] = request.Isolate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiteEffect))
            {
                query["LiteEffect"] = request.LiteEffect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInactivity))
            {
                query["MaxInactivity"] = request.MaxInactivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maxassoc))
            {
                query["Maxassoc"] = request.Maxassoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MulticastForward))
            {
                query["MulticastForward"] = request.MulticastForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nasid))
            {
                query["Nasid"] = request.Nasid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSsid))
            {
                query["NewSsid"] = request.NewSsid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ownip))
            {
                query["Ownip"] = request.Ownip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctPort))
            {
                query["SecondaryAcctPort"] = request.SecondaryAcctPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctSecret))
            {
                query["SecondaryAcctSecret"] = request.SecondaryAcctSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAcctServer))
            {
                query["SecondaryAcctServer"] = request.SecondaryAcctServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthPort))
            {
                query["SecondaryAuthPort"] = request.SecondaryAuthPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthSecret))
            {
                query["SecondaryAuthSecret"] = request.SecondaryAuthSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryAuthServer))
            {
                query["SecondaryAuthServer"] = request.SecondaryAuthServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortPreamble))
            {
                query["ShortPreamble"] = request.ShortPreamble;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ssid))
            {
                query["Ssid"] = request.Ssid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsidLb))
            {
                query["SsidLb"] = request.SsidLb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VlanDhcp))
            {
                query["VlanDhcp"] = request.VlanDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wmm))
            {
                query["Wmm"] = request.Wmm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveApgroupSsidConfig",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveApgroupSsidConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveApgroupSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupSsidConfigResponse
        /// </returns>
        public SaveApgroupSsidConfigResponse SaveApgroupSsidConfig(SaveApgroupSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveApgroupSsidConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveApgroupSsidConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveApgroupSsidConfigResponse
        /// </returns>
        public async Task<SaveApgroupSsidConfigResponse> SaveApgroupSsidConfigAsync(SaveApgroupSsidConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveApgroupSsidConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SetApAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetApAddressResponse
        /// </returns>
        public SetApAddressResponse SetApAddressWithOptions(SetApAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAreaName))
            {
                query["ApAreaName"] = request.ApAreaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApBuildingName))
            {
                query["ApBuildingName"] = request.ApBuildingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApCampusName))
            {
                query["ApCampusName"] = request.ApCampusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApCityName))
            {
                query["ApCityName"] = request.ApCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApFloor))
            {
                query["ApFloor"] = request.ApFloor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroup))
            {
                query["ApGroup"] = request.ApGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApName))
            {
                query["ApName"] = request.ApName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApNationName))
            {
                query["ApNationName"] = request.ApNationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApProvinceName))
            {
                query["ApProvinceName"] = request.ApProvinceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApUnitId))
            {
                query["ApUnitId"] = request.ApUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApUnitName))
            {
                query["ApUnitName"] = request.ApUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lat))
            {
                query["Lat"] = request.Lat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lng))
            {
                query["Lng"] = request.Lng;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SetApAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetApAddressResponse
        /// </returns>
        public async Task<SetApAddressResponse> SetApAddressWithOptionsAsync(SetApAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApAreaName))
            {
                query["ApAreaName"] = request.ApAreaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApBuildingName))
            {
                query["ApBuildingName"] = request.ApBuildingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApCampusName))
            {
                query["ApCampusName"] = request.ApCampusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApCityName))
            {
                query["ApCityName"] = request.ApCityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApFloor))
            {
                query["ApFloor"] = request.ApFloor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApGroup))
            {
                query["ApGroup"] = request.ApGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApName))
            {
                query["ApName"] = request.ApName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApNationName))
            {
                query["ApNationName"] = request.ApNationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApProvinceName))
            {
                query["ApProvinceName"] = request.ApProvinceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApUnitId))
            {
                query["ApUnitId"] = request.ApUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApUnitName))
            {
                query["ApUnitName"] = request.ApUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lat))
            {
                query["Lat"] = request.Lat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lng))
            {
                query["Lng"] = request.Lng;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SetApAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// SetApAddressResponse
        /// </returns>
        public SetApAddressResponse SetApAddress(SetApAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApAddressWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SetApAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// SetApAddressResponse
        /// </returns>
        public async Task<SetApAddressResponse> SetApAddressAsync(SetApAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApAddressWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SetApNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetApNameResponse
        /// </returns>
        public SetApNameResponse SetApNameWithOptions(SetApNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApName",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApNameResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SetApNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetApNameResponse
        /// </returns>
        public async Task<SetApNameResponse> SetApNameWithOptionsAsync(SetApNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                query["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetApName",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetApNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SetApNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetApNameResponse
        /// </returns>
        public SetApNameResponse SetApName(SetApNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApNameWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SetApNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetApNameResponse
        /// </returns>
        public async Task<SetApNameResponse> SetApNameAsync(SetApNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注销AP设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnRegisterApAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterApAssetResponse
        /// </returns>
        public UnRegisterApAssetResponse UnRegisterApAssetWithOptions(UnRegisterApAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetApgroupId))
            {
                query["AssetApgroupId"] = request.AssetApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseFor))
            {
                query["UseFor"] = request.UseFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnRegisterApAsset",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnRegisterApAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注销AP设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnRegisterApAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterApAssetResponse
        /// </returns>
        public async Task<UnRegisterApAssetResponse> UnRegisterApAssetWithOptionsAsync(UnRegisterApAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetApgroupId))
            {
                query["AssetApgroupId"] = request.AssetApgroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseFor))
            {
                query["UseFor"] = request.UseFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnRegisterApAsset",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnRegisterApAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注销AP设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnRegisterApAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterApAssetResponse
        /// </returns>
        public UnRegisterApAssetResponse UnRegisterApAsset(UnRegisterApAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnRegisterApAssetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注销AP设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnRegisterApAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterApAssetResponse
        /// </returns>
        public async Task<UnRegisterApAssetResponse> UnRegisterApAssetAsync(UnRegisterApAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnRegisterApAssetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetDeviceInfoResponse
        /// </returns>
        public UpdateNetDeviceInfoResponse UpdateNetDeviceInfoWithOptions(UpdateNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["Devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNetDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateNetDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetDeviceInfoResponse
        /// </returns>
        public async Task<UpdateNetDeviceInfoResponse> UpdateNetDeviceInfoWithOptionsAsync(UpdateNetDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["Devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNetDeviceInfo",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNetDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetDeviceInfoResponse
        /// </returns>
        public UpdateNetDeviceInfoResponse UpdateNetDeviceInfo(UpdateNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNetDeviceInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateNetDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetDeviceInfoResponse
        /// </returns>
        public async Task<UpdateNetDeviceInfoResponse> UpdateNetDeviceInfoAsync(UpdateNetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNetDeviceInfoWithOptionsAsync(request, runtime);
        }

    }
}
