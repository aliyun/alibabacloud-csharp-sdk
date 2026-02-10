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
        /// <para>调用aics openapi</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AicsOpenApiInvokeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AicsOpenApiInvokeResponse
        /// </returns>
        public AicsOpenApiInvokeResponse AicsOpenApiInvokeWithOptions(AicsOpenApiInvokeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AicsOpenApiInvokeShrinkRequest request = new AicsOpenApiInvokeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Param))
            {
                request.ParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Param, "Param", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamShrink))
            {
                body["Param"] = request.ParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AicsOpenApiInvoke",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AicsOpenApiInvokeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用aics openapi</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AicsOpenApiInvokeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AicsOpenApiInvokeResponse
        /// </returns>
        public async Task<AicsOpenApiInvokeResponse> AicsOpenApiInvokeWithOptionsAsync(AicsOpenApiInvokeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AicsOpenApiInvokeShrinkRequest request = new AicsOpenApiInvokeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Param))
            {
                request.ParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Param, "Param", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamShrink))
            {
                body["Param"] = request.ParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AicsOpenApiInvoke",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AicsOpenApiInvokeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用aics openapi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AicsOpenApiInvokeRequest
        /// </param>
        /// 
        /// <returns>
        /// AicsOpenApiInvokeResponse
        /// </returns>
        public AicsOpenApiInvokeResponse AicsOpenApiInvoke(AicsOpenApiInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AicsOpenApiInvokeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用aics openapi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AicsOpenApiInvokeRequest
        /// </param>
        /// 
        /// <returns>
        /// AicsOpenApiInvokeResponse
        /// </returns>
        public async Task<AicsOpenApiInvokeResponse> AicsOpenApiInvokeAsync(AicsOpenApiInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AicsOpenApiInvokeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建储能运行优化任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEssOptJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEssOptJobResponse
        /// </returns>
        public CreateEssOptJobResponse CreateEssOptJobWithOptions(CreateEssOptJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEssOptJobShrinkRequest request = new CreateEssOptJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ElecPrice))
            {
                request.ElecPriceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ElecPrice, "ElecPrice", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenPrice))
            {
                request.GenPriceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenPrice, "GenPrice", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SystemData))
            {
                request.SystemDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SystemData, "SystemData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElecPriceShrink))
            {
                body["ElecPrice"] = request.ElecPriceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenPriceShrink))
            {
                body["GenPrice"] = request.GenPriceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDataShrink))
            {
                body["SystemData"] = request.SystemDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopoType))
            {
                body["TopoType"] = request.TopoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEssOptJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEssOptJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建储能运行优化任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEssOptJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEssOptJobResponse
        /// </returns>
        public async Task<CreateEssOptJobResponse> CreateEssOptJobWithOptionsAsync(CreateEssOptJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEssOptJobShrinkRequest request = new CreateEssOptJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ElecPrice))
            {
                request.ElecPriceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ElecPrice, "ElecPrice", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenPrice))
            {
                request.GenPriceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenPrice, "GenPrice", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SystemData))
            {
                request.SystemDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SystemData, "SystemData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElecPriceShrink))
            {
                body["ElecPrice"] = request.ElecPriceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenPriceShrink))
            {
                body["GenPrice"] = request.GenPriceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDataShrink))
            {
                body["SystemData"] = request.SystemDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopoType))
            {
                body["TopoType"] = request.TopoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEssOptJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEssOptJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建储能运行优化任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEssOptJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEssOptJobResponse
        /// </returns>
        public CreateEssOptJobResponse CreateEssOptJob(CreateEssOptJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEssOptJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建储能运行优化任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEssOptJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEssOptJobResponse
        /// </returns>
        public async Task<CreateEssOptJobResponse> CreateEssOptJobAsync(CreateEssOptJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEssOptJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadForecastByFileUrlJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastByFileUrlJobResponse
        /// </returns>
        public CreateLoadForecastByFileUrlJobResponse CreateLoadForecastByFileUrlJobWithOptions(CreateLoadForecastByFileUrlJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryUrl))
            {
                body["HistoryUrl"] = request.HistoryUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeColumn))
            {
                body["TimeColumn"] = request.TimeColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueColumn))
            {
                body["ValueColumn"] = request.ValueColumn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadForecastByFileUrlJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadForecastByFileUrlJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadForecastByFileUrlJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastByFileUrlJobResponse
        /// </returns>
        public async Task<CreateLoadForecastByFileUrlJobResponse> CreateLoadForecastByFileUrlJobWithOptionsAsync(CreateLoadForecastByFileUrlJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryUrl))
            {
                body["HistoryUrl"] = request.HistoryUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeColumn))
            {
                body["TimeColumn"] = request.TimeColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueColumn))
            {
                body["ValueColumn"] = request.ValueColumn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadForecastByFileUrlJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadForecastByFileUrlJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadForecastByFileUrlJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastByFileUrlJobResponse
        /// </returns>
        public CreateLoadForecastByFileUrlJobResponse CreateLoadForecastByFileUrlJob(CreateLoadForecastByFileUrlJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadForecastByFileUrlJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadForecastByFileUrlJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastByFileUrlJobResponse
        /// </returns>
        public async Task<CreateLoadForecastByFileUrlJobResponse> CreateLoadForecastByFileUrlJobAsync(CreateLoadForecastByFileUrlJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadForecastByFileUrlJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateLoadForecastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastJobResponse
        /// </returns>
        public CreateLoadForecastJobResponse CreateLoadForecastJobWithOptions(CreateLoadForecastJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLoadForecastJobShrinkRequest request = new CreateLoadForecastJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HistoryData))
            {
                request.HistoryDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HistoryData, "HistoryData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryDataShrink))
            {
                body["HistoryData"] = request.HistoryDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadForecastJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadForecastJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateLoadForecastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastJobResponse
        /// </returns>
        public async Task<CreateLoadForecastJobResponse> CreateLoadForecastJobWithOptionsAsync(CreateLoadForecastJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLoadForecastJobShrinkRequest request = new CreateLoadForecastJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HistoryData))
            {
                request.HistoryDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HistoryData, "HistoryData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryDataShrink))
            {
                body["HistoryData"] = request.HistoryDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadForecastJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadForecastJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadForecastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastJobResponse
        /// </returns>
        public CreateLoadForecastJobResponse CreateLoadForecastJob(CreateLoadForecastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadForecastJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用电负荷预测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoadForecastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadForecastJobResponse
        /// </returns>
        public async Task<CreateLoadForecastJobResponse> CreateLoadForecastJobAsync(CreateLoadForecastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadForecastJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePowerForecastByFileUrlJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastByFileUrlJobResponse
        /// </returns>
        public CreatePowerForecastByFileUrlJobResponse CreatePowerForecastByFileUrlJobWithOptions(CreatePowerForecastByFileUrlJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePowerForecastByFileUrlJobShrinkRequest request = new CreatePowerForecastByFileUrlJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryUrl))
            {
                body["HistoryUrl"] = request.HistoryUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeColumn))
            {
                body["TimeColumn"] = request.TimeColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueColumn))
            {
                body["ValueColumn"] = request.ValueColumn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePowerForecastByFileUrlJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePowerForecastByFileUrlJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePowerForecastByFileUrlJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastByFileUrlJobResponse
        /// </returns>
        public async Task<CreatePowerForecastByFileUrlJobResponse> CreatePowerForecastByFileUrlJobWithOptionsAsync(CreatePowerForecastByFileUrlJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePowerForecastByFileUrlJobShrinkRequest request = new CreatePowerForecastByFileUrlJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryUrl))
            {
                body["HistoryUrl"] = request.HistoryUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeColumn))
            {
                body["TimeColumn"] = request.TimeColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueColumn))
            {
                body["ValueColumn"] = request.ValueColumn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePowerForecastByFileUrlJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePowerForecastByFileUrlJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePowerForecastByFileUrlJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastByFileUrlJobResponse
        /// </returns>
        public CreatePowerForecastByFileUrlJobResponse CreatePowerForecastByFileUrlJob(CreatePowerForecastByFileUrlJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePowerForecastByFileUrlJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务，历史数据来自文件url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePowerForecastByFileUrlJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastByFileUrlJobResponse
        /// </returns>
        public async Task<CreatePowerForecastByFileUrlJobResponse> CreatePowerForecastByFileUrlJobAsync(CreatePowerForecastByFileUrlJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePowerForecastByFileUrlJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePowerForecastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastJobResponse
        /// </returns>
        public CreatePowerForecastJobResponse CreatePowerForecastJobWithOptions(CreatePowerForecastJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePowerForecastJobShrinkRequest request = new CreatePowerForecastJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HistoryData))
            {
                request.HistoryDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HistoryData, "HistoryData", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryDataShrink))
            {
                body["HistoryData"] = request.HistoryDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePowerForecastJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePowerForecastJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePowerForecastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastJobResponse
        /// </returns>
        public async Task<CreatePowerForecastJobResponse> CreatePowerForecastJobWithOptionsAsync(CreatePowerForecastJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePowerForecastJobShrinkRequest request = new CreatePowerForecastJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HistoryData))
            {
                request.HistoryDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HistoryData, "HistoryData", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Location))
            {
                request.LocationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Location, "Location", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessKey))
            {
                body["BusinessKey"] = request.BusinessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMode))
            {
                body["DataMode"] = request.DataMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastHorizon))
            {
                body["ForecastHorizon"] = request.ForecastHorizon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freq))
            {
                body["Freq"] = request.Freq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryDataShrink))
            {
                body["HistoryData"] = request.HistoryDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationShrink))
            {
                body["Location"] = request.LocationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                body["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunDate))
            {
                body["RunDate"] = request.RunDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePowerForecastJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePowerForecastJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePowerForecastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastJobResponse
        /// </returns>
        public CreatePowerForecastJobResponse CreatePowerForecastJob(CreatePowerForecastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePowerForecastJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建发电功率预测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePowerForecastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePowerForecastJobResponse
        /// </returns>
        public async Task<CreatePowerForecastJobResponse> CreatePowerForecastJobAsync(CreatePowerForecastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePowerForecastJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询aivpp算法job</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAivppAlgoJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAivppAlgoJobResponse
        /// </returns>
        public GetAivppAlgoJobResponse GetAivppAlgoJobWithOptions(GetAivppAlgoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAivppAlgoJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAivppAlgoJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询aivpp算法job</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAivppAlgoJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAivppAlgoJobResponse
        /// </returns>
        public async Task<GetAivppAlgoJobResponse> GetAivppAlgoJobWithOptionsAsync(GetAivppAlgoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAivppAlgoJob",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAivppAlgoJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询aivpp算法job</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAivppAlgoJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAivppAlgoJobResponse
        /// </returns>
        public GetAivppAlgoJobResponse GetAivppAlgoJob(GetAivppAlgoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAivppAlgoJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询aivpp算法job</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAivppAlgoJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAivppAlgoJobResponse
        /// </returns>
        public async Task<GetAivppAlgoJobResponse> GetAivppAlgoJobAsync(GetAivppAlgoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAivppAlgoJobWithOptionsAsync(request, runtime);
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
        /// <para>获取用户AIVPP资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAivppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAivppResourcesResponse
        /// </returns>
        public ListAivppResourcesResponse ListAivppResourcesWithOptions(ListAivppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAivppResources",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAivppResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户AIVPP资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAivppResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAivppResourcesResponse
        /// </returns>
        public async Task<ListAivppResourcesResponse> ListAivppResourcesWithOptionsAsync(ListAivppResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAivppResources",
                Version = "2020-09-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAivppResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户AIVPP资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAivppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAivppResourcesResponse
        /// </returns>
        public ListAivppResourcesResponse ListAivppResources(ListAivppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAivppResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户AIVPP资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAivppResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAivppResourcesResponse
        /// </returns>
        public async Task<ListAivppResourcesResponse> ListAivppResourcesAsync(ListAivppResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAivppResourcesWithOptionsAsync(request, runtime);
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
