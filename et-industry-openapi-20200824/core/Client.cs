// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Et_industry_openapi20200824.Models;

namespace AlibabaCloud.SDK.Et_industry_openapi20200824
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "et-industry.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("et-industry-openapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// GetMqttConnectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMqttConnectResponse
        /// </returns>
        public GetMqttConnectResponse GetMqttConnectWithOptions(GetMqttConnectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMqttConnect",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/collaboration/pop/getmqttconnect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetMqttConnectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetMqttConnectResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// GetMqttConnectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMqttConnectResponse
        /// </returns>
        public async Task<GetMqttConnectResponse> GetMqttConnectWithOptionsAsync(GetMqttConnectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMqttConnect",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/collaboration/pop/getmqttconnect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetMqttConnectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetMqttConnectResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// GetMqttConnectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMqttConnectResponse
        /// </returns>
        public GetMqttConnectResponse GetMqttConnect(GetMqttConnectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMqttConnectWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// GetMqttConnectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMqttConnectResponse
        /// </returns>
        public async Task<GetMqttConnectResponse> GetMqttConnectAsync(GetMqttConnectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMqttConnectWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// GetNonceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNonceResponse
        /// </returns>
        public GetNonceResponse GetNonceWithOptions(GetNonceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNonce",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/collaboration/pop/getnonce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetNonceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetNonceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// GetNonceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNonceResponse
        /// </returns>
        public async Task<GetNonceResponse> GetNonceWithOptionsAsync(GetNonceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNonce",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/collaboration/pop/getnonce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetNonceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetNonceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// GetNonceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNonceResponse
        /// </returns>
        public GetNonceResponse GetNonce(GetNonceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNonceWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// GetNonceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNonceResponse
        /// </returns>
        public async Task<GetNonceResponse> GetNonceAsync(GetNonceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNonceWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// ListMeasurePointListByNodeCodePageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMeasurePointListByNodeCodePageResponse
        /// </returns>
        public ListMeasurePointListByNodeCodePageResponse ListMeasurePointListByNodeCodePageWithOptions(ListMeasurePointListByNodeCodePageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMeasurePointListByNodeCodePage",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/node/pop/measurepointlistbynodecodepage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListMeasurePointListByNodeCodePageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMeasurePointListByNodeCodePageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListMeasurePointListByNodeCodePageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMeasurePointListByNodeCodePageResponse
        /// </returns>
        public async Task<ListMeasurePointListByNodeCodePageResponse> ListMeasurePointListByNodeCodePageWithOptionsAsync(ListMeasurePointListByNodeCodePageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMeasurePointListByNodeCodePage",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/node/pop/measurepointlistbynodecodepage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListMeasurePointListByNodeCodePageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMeasurePointListByNodeCodePageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListMeasurePointListByNodeCodePageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMeasurePointListByNodeCodePageResponse
        /// </returns>
        public ListMeasurePointListByNodeCodePageResponse ListMeasurePointListByNodeCodePage(ListMeasurePointListByNodeCodePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMeasurePointListByNodeCodePageWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// ListMeasurePointListByNodeCodePageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMeasurePointListByNodeCodePageResponse
        /// </returns>
        public async Task<ListMeasurePointListByNodeCodePageResponse> ListMeasurePointListByNodeCodePageAsync(ListMeasurePointListByNodeCodePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMeasurePointListByNodeCodePageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多值批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiFieldBatchUploadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiFieldBatchUploadResponse
        /// </returns>
        public MultiFieldBatchUploadResponse MultiFieldBatchUploadWithOptions(MultiFieldBatchUploadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiFieldBatchUpload",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/multifieldbatchv2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<MultiFieldBatchUploadResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<MultiFieldBatchUploadResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多值批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiFieldBatchUploadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiFieldBatchUploadResponse
        /// </returns>
        public async Task<MultiFieldBatchUploadResponse> MultiFieldBatchUploadWithOptionsAsync(MultiFieldBatchUploadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiFieldBatchUpload",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/multifieldbatchv2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<MultiFieldBatchUploadResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<MultiFieldBatchUploadResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多值批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiFieldBatchUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiFieldBatchUploadResponse
        /// </returns>
        public MultiFieldBatchUploadResponse MultiFieldBatchUpload(MultiFieldBatchUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MultiFieldBatchUploadWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多值批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiFieldBatchUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiFieldBatchUploadResponse
        /// </returns>
        public async Task<MultiFieldBatchUploadResponse> MultiFieldBatchUploadAsync(MultiFieldBatchUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MultiFieldBatchUploadWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多源点位批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiSourcePointBatchUploadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiSourcePointBatchUploadResponse
        /// </returns>
        public MultiSourcePointBatchUploadResponse MultiSourcePointBatchUploadWithOptions(MultiSourcePointBatchUploadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiSourcePointBatchUpload",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/sourcepointbatchv2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<MultiSourcePointBatchUploadResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<MultiSourcePointBatchUploadResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多源点位批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiSourcePointBatchUploadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiSourcePointBatchUploadResponse
        /// </returns>
        public async Task<MultiSourcePointBatchUploadResponse> MultiSourcePointBatchUploadWithOptionsAsync(MultiSourcePointBatchUploadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiSourcePointBatchUpload",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/sourcepointbatchv2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<MultiSourcePointBatchUploadResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<MultiSourcePointBatchUploadResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多源点位批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiSourcePointBatchUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiSourcePointBatchUploadResponse
        /// </returns>
        public MultiSourcePointBatchUploadResponse MultiSourcePointBatchUpload(MultiSourcePointBatchUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MultiSourcePointBatchUploadWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多源点位批量上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiSourcePointBatchUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiSourcePointBatchUploadResponse
        /// </returns>
        public async Task<MultiSourcePointBatchUploadResponse> MultiSourcePointBatchUploadAsync(MultiSourcePointBatchUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MultiSourcePointBatchUploadWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryFieldLatestBySourcePointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFieldLatestBySourcePointResponse
        /// </returns>
        public QueryFieldLatestBySourcePointResponse QueryFieldLatestBySourcePointWithOptions(QueryFieldLatestBySourcePointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFieldLatestBySourcePoint",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldlatestbysourcepoint",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryFieldLatestBySourcePointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryFieldLatestBySourcePointResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryFieldLatestBySourcePointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFieldLatestBySourcePointResponse
        /// </returns>
        public async Task<QueryFieldLatestBySourcePointResponse> QueryFieldLatestBySourcePointWithOptionsAsync(QueryFieldLatestBySourcePointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFieldLatestBySourcePoint",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldlatestbysourcepoint",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryFieldLatestBySourcePointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryFieldLatestBySourcePointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryFieldLatestBySourcePointRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFieldLatestBySourcePointResponse
        /// </returns>
        public QueryFieldLatestBySourcePointResponse QueryFieldLatestBySourcePoint(QueryFieldLatestBySourcePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryFieldLatestBySourcePointWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryFieldLatestBySourcePointRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFieldLatestBySourcePointResponse
        /// </returns>
        public async Task<QueryFieldLatestBySourcePointResponse> QueryFieldLatestBySourcePointAsync(QueryFieldLatestBySourcePointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryFieldLatestBySourcePointWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryIndustryDeviceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceDataResponse
        /// </returns>
        public QueryIndustryDeviceDataResponse QueryIndustryDeviceDataWithOptions(QueryIndustryDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryDeviceData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldlatest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryIndustryDeviceDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryIndustryDeviceDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryIndustryDeviceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceDataResponse
        /// </returns>
        public async Task<QueryIndustryDeviceDataResponse> QueryIndustryDeviceDataWithOptionsAsync(QueryIndustryDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryDeviceData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldlatest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryIndustryDeviceDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryIndustryDeviceDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryIndustryDeviceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceDataResponse
        /// </returns>
        public QueryIndustryDeviceDataResponse QueryIndustryDeviceData(QueryIndustryDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryIndustryDeviceDataWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryIndustryDeviceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceDataResponse
        /// </returns>
        public async Task<QueryIndustryDeviceDataResponse> QueryIndustryDeviceDataAsync(QueryIndustryDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryIndustryDeviceDataWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryIndustryDeviceLimitsDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceLimitsDataResponse
        /// </returns>
        public QueryIndustryDeviceLimitsDataResponse QueryIndustryDeviceLimitsDataWithOptions(QueryIndustryDeviceLimitsDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryDeviceLimitsData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldrange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryIndustryDeviceLimitsDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryIndustryDeviceLimitsDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryIndustryDeviceLimitsDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceLimitsDataResponse
        /// </returns>
        public async Task<QueryIndustryDeviceLimitsDataResponse> QueryIndustryDeviceLimitsDataWithOptionsAsync(QueryIndustryDeviceLimitsDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryDeviceLimitsData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldrange",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryIndustryDeviceLimitsDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryIndustryDeviceLimitsDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryIndustryDeviceLimitsDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceLimitsDataResponse
        /// </returns>
        public QueryIndustryDeviceLimitsDataResponse QueryIndustryDeviceLimitsData(QueryIndustryDeviceLimitsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryIndustryDeviceLimitsDataWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryIndustryDeviceLimitsDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceLimitsDataResponse
        /// </returns>
        public async Task<QueryIndustryDeviceLimitsDataResponse> QueryIndustryDeviceLimitsDataAsync(QueryIndustryDeviceLimitsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryIndustryDeviceLimitsDataWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryIndustryDeviceStatusDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceStatusDataResponse
        /// </returns>
        public QueryIndustryDeviceStatusDataResponse QueryIndustryDeviceStatusDataWithOptions(QueryIndustryDeviceStatusDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryDeviceStatusData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldrangestatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryIndustryDeviceStatusDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryIndustryDeviceStatusDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryIndustryDeviceStatusDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceStatusDataResponse
        /// </returns>
        public async Task<QueryIndustryDeviceStatusDataResponse> QueryIndustryDeviceStatusDataWithOptionsAsync(QueryIndustryDeviceStatusDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryDeviceStatusData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/query/pop/multifieldrangestatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryIndustryDeviceStatusDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryIndustryDeviceStatusDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// QueryIndustryDeviceStatusDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceStatusDataResponse
        /// </returns>
        public QueryIndustryDeviceStatusDataResponse QueryIndustryDeviceStatusData(QueryIndustryDeviceStatusDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryIndustryDeviceStatusDataWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// QueryIndustryDeviceStatusDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndustryDeviceStatusDataResponse
        /// </returns>
        public async Task<QueryIndustryDeviceStatusDataResponse> QueryIndustryDeviceStatusDataAsync(QueryIndustryDeviceStatusDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryIndustryDeviceStatusDataWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// SourcePointBatchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SourcePointBatchResponse
        /// </returns>
        public SourcePointBatchResponse SourcePointBatchWithOptions(SourcePointBatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SourcePointBatch",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/sourcepointbatch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SourcePointBatchResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SourcePointBatchResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// SourcePointBatchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SourcePointBatchResponse
        /// </returns>
        public async Task<SourcePointBatchResponse> SourcePointBatchWithOptionsAsync(SourcePointBatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SourcePointBatch",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/sourcepointbatch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SourcePointBatchResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SourcePointBatchResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// SourcePointBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// SourcePointBatchResponse
        /// </returns>
        public SourcePointBatchResponse SourcePointBatch(SourcePointBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SourcePointBatchWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// SourcePointBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// SourcePointBatchResponse
        /// </returns>
        public async Task<SourcePointBatchResponse> SourcePointBatchAsync(SourcePointBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SourcePointBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// UploadIndustryDeviceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadIndustryDeviceDataResponse
        /// </returns>
        public UploadIndustryDeviceDataResponse UploadIndustryDeviceDataWithOptions(UploadIndustryDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadIndustryDeviceData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/multifieldbatch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UploadIndustryDeviceDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UploadIndustryDeviceDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// UploadIndustryDeviceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadIndustryDeviceDataResponse
        /// </returns>
        public async Task<UploadIndustryDeviceDataResponse> UploadIndustryDeviceDataWithOptionsAsync(UploadIndustryDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadIndustryDeviceData",
                Version = "2020-08-24",
                Protocol = "HTTPS",
                Pathname = "/api/igate/timeseries/upload/pop/multifieldbatch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UploadIndustryDeviceDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UploadIndustryDeviceDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// UploadIndustryDeviceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadIndustryDeviceDataResponse
        /// </returns>
        public UploadIndustryDeviceDataResponse UploadIndustryDeviceData(UploadIndustryDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadIndustryDeviceDataWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// UploadIndustryDeviceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadIndustryDeviceDataResponse
        /// </returns>
        public async Task<UploadIndustryDeviceDataResponse> UploadIndustryDeviceDataAsync(UploadIndustryDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadIndustryDeviceDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
