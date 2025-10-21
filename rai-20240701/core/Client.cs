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
        /// <para>CreateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelInstanceResponse
        /// </returns>
        public CreateModelInstanceResponse CreateModelInstanceWithOptions(CreateModelInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceId))
            {
                query["EasServiceId"] = request.EasServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                query["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCallName))
            {
                query["ModelCallName"] = request.ModelCallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategoryId))
            {
                query["ModelCategoryId"] = request.ModelCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelToken))
            {
                query["ModelToken"] = request.ModelToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelUrl))
            {
                query["ModelUrl"] = request.ModelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVpcUrl))
            {
                query["ModelVpcUrl"] = request.ModelVpcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelInstanceResponse
        /// </returns>
        public async Task<CreateModelInstanceResponse> CreateModelInstanceWithOptionsAsync(CreateModelInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceId))
            {
                query["EasServiceId"] = request.EasServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                query["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCallName))
            {
                query["ModelCallName"] = request.ModelCallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategoryId))
            {
                query["ModelCategoryId"] = request.ModelCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelToken))
            {
                query["ModelToken"] = request.ModelToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelUrl))
            {
                query["ModelUrl"] = request.ModelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVpcUrl))
            {
                query["ModelVpcUrl"] = request.ModelVpcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelInstanceResponse
        /// </returns>
        public CreateModelInstanceResponse CreateModelInstance(CreateModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelInstanceResponse
        /// </returns>
        public async Task<CreateModelInstanceResponse> CreateModelInstanceAsync(CreateModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreatePolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyShrinkRequest request = new CreatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HarmfulCategoryConfigInfoList))
            {
                request.HarmfulCategoryConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HarmfulCategoryConfigInfoList, "HarmfulCategoryConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfo))
            {
                request.PromptAttackInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfo, "PromptAttackInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfoList))
            {
                request.PromptAttackInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfoList, "PromptAttackInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegularExpressList))
            {
                request.RegularExpressListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegularExpressList, "RegularExpressList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveConfigList))
            {
                request.SensitiveConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveConfigList, "SensitiveConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveTopicList))
            {
                request.SensitiveTopicListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveTopicList, "SensitiveTopicList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveWordList))
            {
                request.SensitiveWordListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveWordList, "SensitiveWordList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicConfigInfoList))
            {
                request.TopicConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicConfigInfoList, "TopicConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WordGroupInfoList))
            {
                request.WordGroupInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WordGroupInfoList, "WordGroupInfoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeModelInstanceId))
            {
                query["ContentSafeModelInstanceId"] = request.ContentSafeModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveInputCheck))
            {
                query["EnableSensitiveInputCheck"] = request.EnableSensitiveInputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveOutputCheck))
            {
                query["EnableSensitiveOutputCheck"] = request.EnableSensitiveOutputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmfulCategoryConfigInfoListShrink))
            {
                query["HarmfulCategoryConfigInfoList"] = request.HarmfulCategoryConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswer))
            {
                query["InputSafeAnswer"] = request.InputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswerSwitch))
            {
                query["InputSafeAnswerSwitch"] = request.InputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswer))
            {
                query["OutputSafeAnswer"] = request.OutputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswerSwitch))
            {
                query["OutputSafeAnswerSwitch"] = request.OutputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoShrink))
            {
                query["PromptAttackInfo"] = request.PromptAttackInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoListShrink))
            {
                query["PromptAttackInfoList"] = request.PromptAttackInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackModelInstanceId))
            {
                query["PromptAttackModelInstanceId"] = request.PromptAttackModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegularExpressListShrink))
            {
                query["RegularExpressList"] = request.RegularExpressListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveConfigListShrink))
            {
                query["SensitiveConfigList"] = request.SensitiveConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicListShrink))
            {
                query["SensitiveTopicList"] = request.SensitiveTopicListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicModelInstanceId))
            {
                query["SensitiveTopicModelInstanceId"] = request.SensitiveTopicModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveWordListShrink))
            {
                query["SensitiveWordList"] = request.SensitiveWordListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicConfigInfoListShrink))
            {
                query["TopicConfigInfoList"] = request.TopicConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordGroupInfoListShrink))
            {
                query["WordGroupInfoList"] = request.WordGroupInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreatePolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyShrinkRequest request = new CreatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HarmfulCategoryConfigInfoList))
            {
                request.HarmfulCategoryConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HarmfulCategoryConfigInfoList, "HarmfulCategoryConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfo))
            {
                request.PromptAttackInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfo, "PromptAttackInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfoList))
            {
                request.PromptAttackInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfoList, "PromptAttackInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegularExpressList))
            {
                request.RegularExpressListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegularExpressList, "RegularExpressList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveConfigList))
            {
                request.SensitiveConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveConfigList, "SensitiveConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveTopicList))
            {
                request.SensitiveTopicListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveTopicList, "SensitiveTopicList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveWordList))
            {
                request.SensitiveWordListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveWordList, "SensitiveWordList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicConfigInfoList))
            {
                request.TopicConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicConfigInfoList, "TopicConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WordGroupInfoList))
            {
                request.WordGroupInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WordGroupInfoList, "WordGroupInfoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeModelInstanceId))
            {
                query["ContentSafeModelInstanceId"] = request.ContentSafeModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveInputCheck))
            {
                query["EnableSensitiveInputCheck"] = request.EnableSensitiveInputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveOutputCheck))
            {
                query["EnableSensitiveOutputCheck"] = request.EnableSensitiveOutputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmfulCategoryConfigInfoListShrink))
            {
                query["HarmfulCategoryConfigInfoList"] = request.HarmfulCategoryConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswer))
            {
                query["InputSafeAnswer"] = request.InputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswerSwitch))
            {
                query["InputSafeAnswerSwitch"] = request.InputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswer))
            {
                query["OutputSafeAnswer"] = request.OutputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswerSwitch))
            {
                query["OutputSafeAnswerSwitch"] = request.OutputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoShrink))
            {
                query["PromptAttackInfo"] = request.PromptAttackInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoListShrink))
            {
                query["PromptAttackInfoList"] = request.PromptAttackInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackModelInstanceId))
            {
                query["PromptAttackModelInstanceId"] = request.PromptAttackModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegularExpressListShrink))
            {
                query["RegularExpressList"] = request.RegularExpressListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveConfigListShrink))
            {
                query["SensitiveConfigList"] = request.SensitiveConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicListShrink))
            {
                query["SensitiveTopicList"] = request.SensitiveTopicListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicModelInstanceId))
            {
                query["SensitiveTopicModelInstanceId"] = request.SensitiveTopicModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveWordListShrink))
            {
                query["SensitiveWordList"] = request.SensitiveWordListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicConfigInfoListShrink))
            {
                query["TopicConfigInfoList"] = request.TopicConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordGroupInfoListShrink))
            {
                query["WordGroupInfoList"] = request.WordGroupInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreatePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreatePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateTopic</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public CreateTopicResponse CreateTopicWithOptions(CreateTopicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTopicShrinkRequest request = new CreateTopicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicDefinition))
            {
                query["TopicDefinition"] = request.TopicDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
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
                Action = "CreateTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateTopic</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public async Task<CreateTopicResponse> CreateTopicWithOptionsAsync(CreateTopicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTopicShrinkRequest request = new CreateTopicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicDefinition))
            {
                query["TopicDefinition"] = request.TopicDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
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
                Action = "CreateTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public async Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWordGroupResponse
        /// </returns>
        public CreateWordGroupResponse CreateWordGroupWithOptions(CreateWordGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWordGroupShrinkRequest request = new CreateWordGroupShrinkRequest();
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
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
                Action = "CreateWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWordGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWordGroupResponse
        /// </returns>
        public async Task<CreateWordGroupResponse> CreateWordGroupWithOptionsAsync(CreateWordGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWordGroupShrinkRequest request = new CreateWordGroupShrinkRequest();
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
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
                Action = "CreateWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWordGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWordGroupResponse
        /// </returns>
        public CreateWordGroupResponse CreateWordGroup(CreateWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWordGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWordGroupResponse
        /// </returns>
        public async Task<CreateWordGroupResponse> CreateWordGroupAsync(CreateWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWordGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteModelInstance</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelInstanceResponse
        /// </returns>
        public DeleteModelInstanceResponse DeleteModelInstanceWithOptions(DeleteModelInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteModelInstanceShrinkRequest request = new DeleteModelInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelInstanceIdList))
            {
                request.ModelInstanceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelInstanceIdList, "ModelInstanceIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelInstanceIdListShrink))
            {
                query["ModelInstanceIdList"] = request.ModelInstanceIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteModelInstance</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelInstanceResponse
        /// </returns>
        public async Task<DeleteModelInstanceResponse> DeleteModelInstanceWithOptionsAsync(DeleteModelInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteModelInstanceShrinkRequest request = new DeleteModelInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelInstanceIdList))
            {
                request.ModelInstanceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelInstanceIdList, "ModelInstanceIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelInstanceIdListShrink))
            {
                query["ModelInstanceIdList"] = request.ModelInstanceIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelInstanceResponse
        /// </returns>
        public DeleteModelInstanceResponse DeleteModelInstance(DeleteModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelInstanceResponse
        /// </returns>
        public async Task<DeleteModelInstanceResponse> DeleteModelInstanceAsync(DeleteModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeletePolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicyWithOptions(DeletePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePolicyShrinkRequest request = new DeletePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PolicyIdList))
            {
                request.PolicyIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PolicyIdList, "PolicyIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdListShrink))
            {
                query["PolicyIdList"] = request.PolicyIdListShrink;
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
                Action = "DeletePolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeletePolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(DeletePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePolicyShrinkRequest request = new DeletePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PolicyIdList))
            {
                request.PolicyIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PolicyIdList, "PolicyIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdListShrink))
            {
                query["PolicyIdList"] = request.PolicyIdListShrink;
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
                Action = "DeletePolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeletePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeletePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteTopic</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public DeleteTopicResponse DeleteTopicWithOptions(DeleteTopicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTopicShrinkRequest request = new DeleteTopicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicIdList))
            {
                request.TopicIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicIdList, "TopicIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicIdListShrink))
            {
                query["TopicIdList"] = request.TopicIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteTopic</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public async Task<DeleteTopicResponse> DeleteTopicWithOptionsAsync(DeleteTopicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTopicShrinkRequest request = new DeleteTopicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicIdList))
            {
                request.TopicIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicIdList, "TopicIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicIdListShrink))
            {
                query["TopicIdList"] = request.TopicIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteWordGroup</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWordGroupResponse
        /// </returns>
        public DeleteWordGroupResponse DeleteWordGroupWithOptions(DeleteWordGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteWordGroupShrinkRequest request = new DeleteWordGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIdList))
            {
                request.GroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIdList, "GroupIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdListShrink))
            {
                query["GroupIdList"] = request.GroupIdListShrink;
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
                Action = "DeleteWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWordGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteWordGroup</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWordGroupResponse
        /// </returns>
        public async Task<DeleteWordGroupResponse> DeleteWordGroupWithOptionsAsync(DeleteWordGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteWordGroupShrinkRequest request = new DeleteWordGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIdList))
            {
                request.GroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIdList, "GroupIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdListShrink))
            {
                query["GroupIdList"] = request.GroupIdListShrink;
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
                Action = "DeleteWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWordGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWordGroupResponse
        /// </returns>
        public DeleteWordGroupResponse DeleteWordGroup(DeleteWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWordGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWordGroupResponse
        /// </returns>
        public async Task<DeleteWordGroupResponse> DeleteWordGroupAsync(DeleteWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWordGroupWithOptionsAsync(request, runtime);
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
        /// <para>GetModelInputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInputContentDetectResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelInputContentDetectResultResponse
        /// </returns>
        public GetModelInputContentDetectResultResponse GetModelInputContentDetectResultWithOptions(GetModelInputContentDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetModelInputContentDetectResult",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelInputContentDetectResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInputContentDetectResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelInputContentDetectResultResponse
        /// </returns>
        public async Task<GetModelInputContentDetectResultResponse> GetModelInputContentDetectResultWithOptionsAsync(GetModelInputContentDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetModelInputContentDetectResult",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelInputContentDetectResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInputContentDetectResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelInputContentDetectResultResponse
        /// </returns>
        public GetModelInputContentDetectResultResponse GetModelInputContentDetectResult(GetModelInputContentDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelInputContentDetectResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInputContentDetectResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelInputContentDetectResultResponse
        /// </returns>
        public async Task<GetModelInputContentDetectResultResponse> GetModelInputContentDetectResultAsync(GetModelInputContentDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelInputContentDetectResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInstanceInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInstanceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelInstanceInfoResponse
        /// </returns>
        public GetModelInstanceInfoResponse GetModelInstanceInfoWithOptions(GetModelInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelInstanceId))
            {
                query["ModelInstanceId"] = request.ModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelInstanceInfo",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelInstanceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInstanceInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInstanceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelInstanceInfoResponse
        /// </returns>
        public async Task<GetModelInstanceInfoResponse> GetModelInstanceInfoWithOptionsAsync(GetModelInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelInstanceId))
            {
                query["ModelInstanceId"] = request.ModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelInstanceInfo",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelInstanceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInstanceInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInstanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelInstanceInfoResponse
        /// </returns>
        public GetModelInstanceInfoResponse GetModelInstanceInfo(GetModelInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelInstanceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelInstanceInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelInstanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelInstanceInfoResponse
        /// </returns>
        public async Task<GetModelInstanceInfoResponse> GetModelInstanceInfoAsync(GetModelInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelInstanceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelOutputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelOutputContentDetectResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelOutputContentDetectResultResponse
        /// </returns>
        public GetModelOutputContentDetectResultResponse GetModelOutputContentDetectResultWithOptions(GetModelOutputContentDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetModelOutputContentDetectResult",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelOutputContentDetectResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelOutputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelOutputContentDetectResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelOutputContentDetectResultResponse
        /// </returns>
        public async Task<GetModelOutputContentDetectResultResponse> GetModelOutputContentDetectResultWithOptionsAsync(GetModelOutputContentDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetModelOutputContentDetectResult",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelOutputContentDetectResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelOutputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelOutputContentDetectResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelOutputContentDetectResultResponse
        /// </returns>
        public GetModelOutputContentDetectResultResponse GetModelOutputContentDetectResult(GetModelOutputContentDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelOutputContentDetectResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetModelOutputContentDetectResult</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelOutputContentDetectResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelOutputContentDetectResultResponse
        /// </returns>
        public async Task<GetModelOutputContentDetectResultResponse> GetModelOutputContentDetectResultAsync(GetModelOutputContentDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelOutputContentDetectResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyDefaultOptions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyDefaultOptionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyDefaultOptionsResponse
        /// </returns>
        public GetPolicyDefaultOptionsResponse GetPolicyDefaultOptionsWithOptions(GetPolicyDefaultOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPolicyDefaultOptions",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyDefaultOptionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyDefaultOptions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyDefaultOptionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyDefaultOptionsResponse
        /// </returns>
        public async Task<GetPolicyDefaultOptionsResponse> GetPolicyDefaultOptionsWithOptionsAsync(GetPolicyDefaultOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPolicyDefaultOptions",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyDefaultOptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyDefaultOptions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyDefaultOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyDefaultOptionsResponse
        /// </returns>
        public GetPolicyDefaultOptionsResponse GetPolicyDefaultOptions(GetPolicyDefaultOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyDefaultOptionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyDefaultOptions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyDefaultOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyDefaultOptionsResponse
        /// </returns>
        public async Task<GetPolicyDefaultOptionsResponse> GetPolicyDefaultOptionsAsync(GetPolicyDefaultOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyDefaultOptionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyInfoResponse
        /// </returns>
        public GetPolicyInfoResponse GetPolicyInfoWithOptions(GetPolicyInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
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
                Action = "GetPolicyInfo",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyInfoResponse
        /// </returns>
        public async Task<GetPolicyInfoResponse> GetPolicyInfoWithOptionsAsync(GetPolicyInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
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
                Action = "GetPolicyInfo",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyInfoResponse
        /// </returns>
        public GetPolicyInfoResponse GetPolicyInfo(GetPolicyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetPolicyInfo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPolicyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyInfoResponse
        /// </returns>
        public async Task<GetPolicyInfoResponse> GetPolicyInfoAsync(GetPolicyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicResponse
        /// </returns>
        public GetTopicResponse GetTopicWithOptions(GetTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                query["TopicId"] = request.TopicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicResponse
        /// </returns>
        public async Task<GetTopicResponse> GetTopicWithOptionsAsync(GetTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                query["TopicId"] = request.TopicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicResponse
        /// </returns>
        public GetTopicResponse GetTopic(GetTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicResponse
        /// </returns>
        public async Task<GetTopicResponse> GetTopicAsync(GetTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWordGroupResponse
        /// </returns>
        public GetWordGroupResponse GetWordGroupWithOptions(GetWordGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
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
                Action = "GetWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWordGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWordGroupResponse
        /// </returns>
        public async Task<GetWordGroupResponse> GetWordGroupWithOptionsAsync(GetWordGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
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
                Action = "GetWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWordGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWordGroupResponse
        /// </returns>
        public GetWordGroupResponse GetWordGroup(GetWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWordGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWordGroupResponse
        /// </returns>
        public async Task<GetWordGroupResponse> GetWordGroupAsync(GetWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWordGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelCategory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelCategoryResponse
        /// </returns>
        public ListModelCategoryResponse ListModelCategoryWithOptions(ListModelCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeImageSupported))
            {
                query["ContentSafeImageSupported"] = request.ContentSafeImageSupported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeTextSupported))
            {
                query["ContentSafeTextSupported"] = request.ContentSafeTextSupported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategoryName))
            {
                query["ModelCategoryName"] = request.ModelCategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSource))
            {
                query["ModelSource"] = request.ModelSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackTextSupported))
            {
                query["PromptAttackTextSupported"] = request.PromptAttackTextSupported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicTextSupported))
            {
                query["SensitiveTopicTextSupported"] = request.SensitiveTopicTextSupported;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelCategory",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelCategory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelCategoryResponse
        /// </returns>
        public async Task<ListModelCategoryResponse> ListModelCategoryWithOptionsAsync(ListModelCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeImageSupported))
            {
                query["ContentSafeImageSupported"] = request.ContentSafeImageSupported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeTextSupported))
            {
                query["ContentSafeTextSupported"] = request.ContentSafeTextSupported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategoryName))
            {
                query["ModelCategoryName"] = request.ModelCategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSource))
            {
                query["ModelSource"] = request.ModelSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackTextSupported))
            {
                query["PromptAttackTextSupported"] = request.PromptAttackTextSupported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicTextSupported))
            {
                query["SensitiveTopicTextSupported"] = request.SensitiveTopicTextSupported;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelCategory",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelCategory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelCategoryResponse
        /// </returns>
        public ListModelCategoryResponse ListModelCategory(ListModelCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelCategory</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelCategoryResponse
        /// </returns>
        public async Task<ListModelCategoryResponse> ListModelCategoryAsync(ListModelCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelInstanceResponse
        /// </returns>
        public ListModelInstanceResponse ListModelInstanceWithOptions(ListModelInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                query["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportContentSafe))
            {
                query["IsSupportContentSafe"] = request.IsSupportContentSafe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportPromptAttack))
            {
                query["IsSupportPromptAttack"] = request.IsSupportPromptAttack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportSensitiveTopic))
            {
                query["IsSupportSensitiveTopic"] = request.IsSupportSensitiveTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSource))
            {
                query["ModelSource"] = request.ModelSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelInstanceResponse
        /// </returns>
        public async Task<ListModelInstanceResponse> ListModelInstanceWithOptionsAsync(ListModelInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                query["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportContentSafe))
            {
                query["IsSupportContentSafe"] = request.IsSupportContentSafe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportPromptAttack))
            {
                query["IsSupportPromptAttack"] = request.IsSupportPromptAttack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportSensitiveTopic))
            {
                query["IsSupportSensitiveTopic"] = request.IsSupportSensitiveTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSource))
            {
                query["ModelSource"] = request.ModelSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelInstanceResponse
        /// </returns>
        public ListModelInstanceResponse ListModelInstance(ListModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelInstanceResponse
        /// </returns>
        public async Task<ListModelInstanceResponse> ListModelInstanceAsync(ListModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyResponse
        /// </returns>
        public ListPolicyResponse ListPolicyWithOptions(ListPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyResponse
        /// </returns>
        public async Task<ListPolicyResponse> ListPolicyWithOptionsAsync(ListPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyResponse
        /// </returns>
        public ListPolicyResponse ListPolicy(ListPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyResponse
        /// </returns>
        public async Task<ListPolicyResponse> ListPolicyAsync(ListPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTopicResponse
        /// </returns>
        public ListTopicResponse ListTopicWithOptions(ListTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTopicResponse
        /// </returns>
        public async Task<ListTopicResponse> ListTopicWithOptionsAsync(ListTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTopicResponse
        /// </returns>
        public ListTopicResponse ListTopic(ListTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTopicResponse
        /// </returns>
        public async Task<ListTopicResponse> ListTopicAsync(ListTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWordGroupResponse
        /// </returns>
        public ListWordGroupResponse ListWordGroupWithOptions(ListWordGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWordGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWordGroupResponse
        /// </returns>
        public async Task<ListWordGroupResponse> ListWordGroupWithOptionsAsync(ListWordGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWordGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWordGroupResponse
        /// </returns>
        public ListWordGroupResponse ListWordGroup(ListWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWordGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWordGroupResponse
        /// </returns>
        public async Task<ListWordGroupResponse> ListWordGroupAsync(ListWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWordGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelInputContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentAsyncDetectResponse
        /// </returns>
        public ModelInputContentAsyncDetectResponse ModelInputContentAsyncDetectWithOptions(ModelInputContentAsyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelInputContentAsyncDetectShrinkRequest request = new ModelInputContentAsyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelInputContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelInputContentAsyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelInputContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentAsyncDetectResponse
        /// </returns>
        public async Task<ModelInputContentAsyncDetectResponse> ModelInputContentAsyncDetectWithOptionsAsync(ModelInputContentAsyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelInputContentAsyncDetectShrinkRequest request = new ModelInputContentAsyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelInputContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelInputContentAsyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelInputContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentAsyncDetectResponse
        /// </returns>
        public ModelInputContentAsyncDetectResponse ModelInputContentAsyncDetect(ModelInputContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModelInputContentAsyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelInputContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentAsyncDetectResponse
        /// </returns>
        public async Task<ModelInputContentAsyncDetectResponse> ModelInputContentAsyncDetectAsync(ModelInputContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModelInputContentAsyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelInputContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentSyncDetectResponse
        /// </returns>
        public ModelInputContentSyncDetectResponse ModelInputContentSyncDetectWithOptions(ModelInputContentSyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelInputContentSyncDetectShrinkRequest request = new ModelInputContentSyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelInputContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelInputContentSyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelInputContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentSyncDetectResponse
        /// </returns>
        public async Task<ModelInputContentSyncDetectResponse> ModelInputContentSyncDetectWithOptionsAsync(ModelInputContentSyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelInputContentSyncDetectShrinkRequest request = new ModelInputContentSyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelInputContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelInputContentSyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelInputContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentSyncDetectResponse
        /// </returns>
        public ModelInputContentSyncDetectResponse ModelInputContentSyncDetect(ModelInputContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModelInputContentSyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelInputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelInputContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelInputContentSyncDetectResponse
        /// </returns>
        public async Task<ModelInputContentSyncDetectResponse> ModelInputContentSyncDetectAsync(ModelInputContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModelInputContentSyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelOutputContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentAsyncDetectResponse
        /// </returns>
        public ModelOutputContentAsyncDetectResponse ModelOutputContentAsyncDetectWithOptions(ModelOutputContentAsyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelOutputContentAsyncDetectShrinkRequest request = new ModelOutputContentAsyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelOutputContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelOutputContentAsyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelOutputContentAsyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentAsyncDetectResponse
        /// </returns>
        public async Task<ModelOutputContentAsyncDetectResponse> ModelOutputContentAsyncDetectWithOptionsAsync(ModelOutputContentAsyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelOutputContentAsyncDetectShrinkRequest request = new ModelOutputContentAsyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelOutputContentAsyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelOutputContentAsyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelOutputContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentAsyncDetectResponse
        /// </returns>
        public ModelOutputContentAsyncDetectResponse ModelOutputContentAsyncDetect(ModelOutputContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModelOutputContentAsyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentAsyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelOutputContentAsyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentAsyncDetectResponse
        /// </returns>
        public async Task<ModelOutputContentAsyncDetectResponse> ModelOutputContentAsyncDetectAsync(ModelOutputContentAsyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModelOutputContentAsyncDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelOutputContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentSyncDetectResponse
        /// </returns>
        public ModelOutputContentSyncDetectResponse ModelOutputContentSyncDetectWithOptions(ModelOutputContentSyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelOutputContentSyncDetectShrinkRequest request = new ModelOutputContentSyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelOutputContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelOutputContentSyncDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModelOutputContentSyncDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentSyncDetectResponse
        /// </returns>
        public async Task<ModelOutputContentSyncDetectResponse> ModelOutputContentSyncDetectWithOptionsAsync(ModelOutputContentSyncDetectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModelOutputContentSyncDetectShrinkRequest request = new ModelOutputContentSyncDetectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIdentifier))
            {
                query["PolicyIdentifier"] = request.PolicyIdentifier;
            }
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
                Action = "ModelOutputContentSyncDetect",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelOutputContentSyncDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelOutputContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentSyncDetectResponse
        /// </returns>
        public ModelOutputContentSyncDetectResponse ModelOutputContentSyncDetect(ModelOutputContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModelOutputContentSyncDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModelOutputContentSyncDetect</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelOutputContentSyncDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelOutputContentSyncDetectResponse
        /// </returns>
        public async Task<ModelOutputContentSyncDetectResponse> ModelOutputContentSyncDetectAsync(ModelOutputContentSyncDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModelOutputContentSyncDetectWithOptionsAsync(request, runtime);
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
        /// <para>UpdateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelInstanceResponse
        /// </returns>
        public UpdateModelInstanceResponse UpdateModelInstanceWithOptions(UpdateModelInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceId))
            {
                query["EasServiceId"] = request.EasServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                query["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCallName))
            {
                query["ModelCallName"] = request.ModelCallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategoryId))
            {
                query["ModelCategoryId"] = request.ModelCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelInstanceId))
            {
                query["ModelInstanceId"] = request.ModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelToken))
            {
                query["ModelToken"] = request.ModelToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelUrl))
            {
                query["ModelUrl"] = request.ModelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVpcUrl))
            {
                query["ModelVpcUrl"] = request.ModelVpcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelInstanceResponse
        /// </returns>
        public async Task<UpdateModelInstanceResponse> UpdateModelInstanceWithOptionsAsync(UpdateModelInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceId))
            {
                query["EasServiceId"] = request.EasServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                query["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCallName))
            {
                query["ModelCallName"] = request.ModelCallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCategoryId))
            {
                query["ModelCategoryId"] = request.ModelCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelInstanceId))
            {
                query["ModelInstanceId"] = request.ModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelToken))
            {
                query["ModelToken"] = request.ModelToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelUrl))
            {
                query["ModelUrl"] = request.ModelUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVpcUrl))
            {
                query["ModelVpcUrl"] = request.ModelVpcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelInstance",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelInstanceResponse
        /// </returns>
        public UpdateModelInstanceResponse UpdateModelInstance(UpdateModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModelInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateModelInstance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelInstanceResponse
        /// </returns>
        public async Task<UpdateModelInstanceResponse> UpdateModelInstanceAsync(UpdateModelInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModelInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdatePolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicyWithOptions(UpdatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyShrinkRequest request = new UpdatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HarmfulCategoryConfigInfoList))
            {
                request.HarmfulCategoryConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HarmfulCategoryConfigInfoList, "HarmfulCategoryConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfo))
            {
                request.PromptAttackInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfo, "PromptAttackInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfoList))
            {
                request.PromptAttackInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfoList, "PromptAttackInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegularExpressList))
            {
                request.RegularExpressListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegularExpressList, "RegularExpressList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveConfigList))
            {
                request.SensitiveConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveConfigList, "SensitiveConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveTopicList))
            {
                request.SensitiveTopicListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveTopicList, "SensitiveTopicList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveWordList))
            {
                request.SensitiveWordListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveWordList, "SensitiveWordList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicConfigInfoList))
            {
                request.TopicConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicConfigInfoList, "TopicConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WordGroupInfoList))
            {
                request.WordGroupInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WordGroupInfoList, "WordGroupInfoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeModelInstanceId))
            {
                query["ContentSafeModelInstanceId"] = request.ContentSafeModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveInputCheck))
            {
                query["EnableSensitiveInputCheck"] = request.EnableSensitiveInputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveOutputCheck))
            {
                query["EnableSensitiveOutputCheck"] = request.EnableSensitiveOutputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmfulCategoryConfigInfoListShrink))
            {
                query["HarmfulCategoryConfigInfoList"] = request.HarmfulCategoryConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswer))
            {
                query["InputSafeAnswer"] = request.InputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswerSwitch))
            {
                query["InputSafeAnswerSwitch"] = request.InputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswer))
            {
                query["OutputSafeAnswer"] = request.OutputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswerSwitch))
            {
                query["OutputSafeAnswerSwitch"] = request.OutputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoShrink))
            {
                query["PromptAttackInfo"] = request.PromptAttackInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoListShrink))
            {
                query["PromptAttackInfoList"] = request.PromptAttackInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackModelInstanceId))
            {
                query["PromptAttackModelInstanceId"] = request.PromptAttackModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegularExpressListShrink))
            {
                query["RegularExpressList"] = request.RegularExpressListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveConfigListShrink))
            {
                query["SensitiveConfigList"] = request.SensitiveConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicListShrink))
            {
                query["SensitiveTopicList"] = request.SensitiveTopicListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicModelInstanceId))
            {
                query["SensitiveTopicModelInstanceId"] = request.SensitiveTopicModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveWordListShrink))
            {
                query["SensitiveWordList"] = request.SensitiveWordListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicConfigInfoListShrink))
            {
                query["TopicConfigInfoList"] = request.TopicConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordGroupInfoListShrink))
            {
                query["WordGroupInfoList"] = request.WordGroupInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdatePolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyWithOptionsAsync(UpdatePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyShrinkRequest request = new UpdatePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HarmfulCategoryConfigInfoList))
            {
                request.HarmfulCategoryConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HarmfulCategoryConfigInfoList, "HarmfulCategoryConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfo))
            {
                request.PromptAttackInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfo, "PromptAttackInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptAttackInfoList))
            {
                request.PromptAttackInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptAttackInfoList, "PromptAttackInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegularExpressList))
            {
                request.RegularExpressListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegularExpressList, "RegularExpressList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveConfigList))
            {
                request.SensitiveConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveConfigList, "SensitiveConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveTopicList))
            {
                request.SensitiveTopicListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveTopicList, "SensitiveTopicList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SensitiveWordList))
            {
                request.SensitiveWordListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SensitiveWordList, "SensitiveWordList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicConfigInfoList))
            {
                request.TopicConfigInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicConfigInfoList, "TopicConfigInfoList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WordGroupInfoList))
            {
                request.WordGroupInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WordGroupInfoList, "WordGroupInfoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentSafeModelInstanceId))
            {
                query["ContentSafeModelInstanceId"] = request.ContentSafeModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveInputCheck))
            {
                query["EnableSensitiveInputCheck"] = request.EnableSensitiveInputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSensitiveOutputCheck))
            {
                query["EnableSensitiveOutputCheck"] = request.EnableSensitiveOutputCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmfulCategoryConfigInfoListShrink))
            {
                query["HarmfulCategoryConfigInfoList"] = request.HarmfulCategoryConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswer))
            {
                query["InputSafeAnswer"] = request.InputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputSafeAnswerSwitch))
            {
                query["InputSafeAnswerSwitch"] = request.InputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSidecarPolicy))
            {
                query["IsSidecarPolicy"] = request.IsSidecarPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswer))
            {
                query["OutputSafeAnswer"] = request.OutputSafeAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputSafeAnswerSwitch))
            {
                query["OutputSafeAnswerSwitch"] = request.OutputSafeAnswerSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoShrink))
            {
                query["PromptAttackInfo"] = request.PromptAttackInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackInfoListShrink))
            {
                query["PromptAttackInfoList"] = request.PromptAttackInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptAttackModelInstanceId))
            {
                query["PromptAttackModelInstanceId"] = request.PromptAttackModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegularExpressListShrink))
            {
                query["RegularExpressList"] = request.RegularExpressListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveConfigListShrink))
            {
                query["SensitiveConfigList"] = request.SensitiveConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicListShrink))
            {
                query["SensitiveTopicList"] = request.SensitiveTopicListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveTopicModelInstanceId))
            {
                query["SensitiveTopicModelInstanceId"] = request.SensitiveTopicModelInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveWordListShrink))
            {
                query["SensitiveWordList"] = request.SensitiveWordListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicConfigInfoListShrink))
            {
                query["TopicConfigInfoList"] = request.TopicConfigInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordGroupInfoListShrink))
            {
                query["WordGroupInfoList"] = request.WordGroupInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicy",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdatePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdatePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateTopic</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicResponse
        /// </returns>
        public UpdateTopicResponse UpdateTopicWithOptions(UpdateTopicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTopicShrinkRequest request = new UpdateTopicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicDefinition))
            {
                query["TopicDefinition"] = request.TopicDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                query["TopicId"] = request.TopicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
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
                Action = "UpdateTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateTopic</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicResponse
        /// </returns>
        public async Task<UpdateTopicResponse> UpdateTopicWithOptionsAsync(UpdateTopicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTopicShrinkRequest request = new UpdateTopicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BodyData))
            {
                request.BodyDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BodyData, "BodyData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicDefinition))
            {
                query["TopicDefinition"] = request.TopicDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                query["TopicId"] = request.TopicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
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
                Action = "UpdateTopic",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicResponse
        /// </returns>
        public UpdateTopicResponse UpdateTopic(UpdateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateTopic</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicResponse
        /// </returns>
        public async Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWordGroupResponse
        /// </returns>
        public UpdateWordGroupResponse UpdateWordGroupWithOptions(UpdateWordGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWordGroupShrinkRequest request = new UpdateWordGroupShrinkRequest();
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordInfoListModified))
            {
                query["WordInfoListModified"] = request.WordInfoListModified;
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
                Action = "UpdateWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWordGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateWordGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWordGroupResponse
        /// </returns>
        public async Task<UpdateWordGroupResponse> UpdateWordGroupWithOptionsAsync(UpdateWordGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWordGroupShrinkRequest request = new UpdateWordGroupShrinkRequest();
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordInfoListModified))
            {
                query["WordInfoListModified"] = request.WordInfoListModified;
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
                Action = "UpdateWordGroup",
                Version = "2024-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWordGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWordGroupResponse
        /// </returns>
        public UpdateWordGroupResponse UpdateWordGroup(UpdateWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWordGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateWordGroup</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWordGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWordGroupResponse
        /// </returns>
        public async Task<UpdateWordGroupResponse> UpdateWordGroupAsync(UpdateWordGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWordGroupWithOptionsAsync(request, runtime);
        }

    }
}
