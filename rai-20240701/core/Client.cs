// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.RAI20240701.Models;

namespace AlibabaCloud.SDK.RAI20240701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>BatchContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchContentAsyncDetectResponse
        /// </returns>
        public BatchContentAsyncDetectResponse BatchContentAsyncDetectWithOptions(BatchContentAsyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameterList))
            {
                body["serviceParameterList"] = request.ServiceParameterList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchContentAsyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchContentAsyncDetectResponse
        /// </returns>
        public async Task<BatchContentAsyncDetectResponse> BatchContentAsyncDetectWithOptionsAsync(BatchContentAsyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameterList))
            {
                body["serviceParameterList"] = request.ServiceParameterList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchContentAsyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchContentAsyncDetectResponse
        /// </returns>
        public BatchContentAsyncDetectResponse BatchContentAsyncDetect(BatchContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchContentAsyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchContentAsyncDetectResponse
        /// </returns>
        public async Task<BatchContentAsyncDetectResponse> BatchContentAsyncDetectAsync(BatchContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchContentAsyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchContentSyncDetectResponse
        /// </returns>
        public BatchContentSyncDetectResponse BatchContentSyncDetectWithOptions(BatchContentSyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameterList))
            {
                body["serviceParameterList"] = request.ServiceParameterList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchContentSyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchContentSyncDetectResponse
        /// </returns>
        public async Task<BatchContentSyncDetectResponse> BatchContentSyncDetectWithOptionsAsync(BatchContentSyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameterList))
            {
                body["serviceParameterList"] = request.ServiceParameterList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchContentSyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchContentSyncDetectResponse
        /// </returns>
        public BatchContentSyncDetectResponse BatchContentSyncDetect(BatchContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchContentSyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>BatchContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchContentSyncDetectResponse
        /// </returns>
        public async Task<BatchContentSyncDetectResponse> BatchContentSyncDetectAsync(BatchContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchContentSyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查用户是否开通RAI服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAccountResponse
        /// </returns>
        public CheckAccountResponse CheckAccountWithOptions(CheckAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "CheckAccount",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查用户是否开通RAI服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAccountResponse
        /// </returns>
        public async Task<CheckAccountResponse> CheckAccountWithOptionsAsync(CheckAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "CheckAccount",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查用户是否开通RAI服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAccountResponse
        /// </returns>
        public CheckAccountResponse CheckAccount(CheckAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查用户是否开通RAI服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAccountResponse
        /// </returns>
        public async Task<CheckAccountResponse> CheckAccountAsync(CheckAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContentAsyncDetectResponse
        /// </returns>
        public ContentAsyncDetectResponse ContentAsyncDetectWithOptions(ContentAsyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameter))
            {
                body["serviceParameter"] = request.ServiceParameter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContentAsyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContentAsyncDetectResponse
        /// </returns>
        public async Task<ContentAsyncDetectResponse> ContentAsyncDetectWithOptionsAsync(ContentAsyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameter))
            {
                body["serviceParameter"] = request.ServiceParameter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContentAsyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ContentAsyncDetectResponse
        /// </returns>
        public ContentAsyncDetectResponse ContentAsyncDetect(ContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContentAsyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ContentAsyncDetectResponse
        /// </returns>
        public async Task<ContentAsyncDetectResponse> ContentAsyncDetectAsync(ContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContentAsyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContentSyncDetectResponse
        /// </returns>
        public ContentSyncDetectResponse ContentSyncDetectWithOptions(ContentSyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameter))
            {
                body["serviceParameter"] = request.ServiceParameter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContentSyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContentSyncDetectResponse
        /// </returns>
        public async Task<ContentSyncDetectResponse> ContentSyncDetectWithOptionsAsync(ContentSyncDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                query["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameter))
            {
                body["serviceParameter"] = request.ServiceParameter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContentSyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ContentSyncDetectResponse
        /// </returns>
        public ContentSyncDetectResponse ContentSyncDetect(ContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContentSyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ContentSyncDetectResponse
        /// </returns>
        public async Task<ContentSyncDetectResponse> ContentSyncDetectAsync(ContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContentSyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentDetectResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContentDetectResultResponse
        /// </returns>
        public GetContentDetectResultResponse GetContentDetectResultWithOptions(GetContentDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetContentDetectResult",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContentDetectResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentDetectResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContentDetectResultResponse
        /// </returns>
        public async Task<GetContentDetectResultResponse> GetContentDetectResultWithOptionsAsync(GetContentDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetContentDetectResult",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContentDetectResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentDetectResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContentDetectResultResponse
        /// </returns>
        public GetContentDetectResultResponse GetContentDetectResult(GetContentDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContentDetectResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContentDetectResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContentDetectResultResponse
        /// </returns>
        public async Task<GetContentDetectResultResponse> GetContentDetectResultAsync(GetContentDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContentDetectResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSensitiveWordResponse
        /// </returns>
        public ListSensitiveWordResponse ListSensitiveWordWithOptions(ListSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListSensitiveWord",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSensitiveWordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSensitiveWordResponse
        /// </returns>
        public async Task<ListSensitiveWordResponse> ListSensitiveWordWithOptionsAsync(ListSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListSensitiveWord",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSensitiveWordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSensitiveWordResponse
        /// </returns>
        public ListSensitiveWordResponse ListSensitiveWord(ListSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSensitiveWordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSensitiveWordResponse
        /// </returns>
        public async Task<ListSensitiveWordResponse> ListSensitiveWordAsync(ListSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSensitiveWordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册RAI账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountResponse
        /// </returns>
        public RegisterAccountResponse RegisterAccountWithOptions(RegisterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                query["Memo"] = request.Memo;
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
                Action = "RegisterAccount",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册RAI账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountResponse
        /// </returns>
        public async Task<RegisterAccountResponse> RegisterAccountWithOptionsAsync(RegisterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                query["Memo"] = request.Memo;
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
                Action = "RegisterAccount",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册RAI账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountResponse
        /// </returns>
        public RegisterAccountResponse RegisterAccount(RegisterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册RAI账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAccountResponse
        /// </returns>
        public async Task<RegisterAccountResponse> RegisterAccountAsync(RegisterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SyncSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSensitiveWordResponse
        /// </returns>
        public SyncSensitiveWordResponse SyncSensitiveWordWithOptions(SyncSensitiveWordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncSensitiveWordShrinkRequest request = new SyncSensitiveWordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commit))
            {
                query["Commit"] = request.Commit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyDataShrink))
            {
                body["BodyData"] = request.BodyDataShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSensitiveWord",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSensitiveWordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SyncSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSensitiveWordResponse
        /// </returns>
        public async Task<SyncSensitiveWordResponse> SyncSensitiveWordWithOptionsAsync(SyncSensitiveWordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncSensitiveWordShrinkRequest request = new SyncSensitiveWordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commit))
            {
                query["Commit"] = request.Commit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyDataShrink))
            {
                body["BodyData"] = request.BodyDataShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSensitiveWord",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSensitiveWordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SyncSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSensitiveWordResponse
        /// </returns>
        public SyncSensitiveWordResponse SyncSensitiveWord(SyncSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncSensitiveWordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SyncSensitiveWord</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSensitiveWordResponse
        /// </returns>
        public async Task<SyncSensitiveWordResponse> SyncSensitiveWordAsync(SyncSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncSensitiveWordWithOptionsAsync(request, runtime);
        }

    }
}
