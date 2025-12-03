// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Metaspace20220307.Models;

namespace AlibabaCloud.SDK.Metaspace20220307
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("metaspace", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>用协同码发起协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyCoordinationWithCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationWithCodeResponse
        /// </returns>
        public ApplyCoordinationWithCodeResponse ApplyCoordinationWithCodeWithOptions(ApplyCoordinationWithCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoordinationCode))
            {
                body["CoordinationCode"] = request.CoordinationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyCoordinationWithCode",
                Version = "2022-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCoordinationWithCodeResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用协同码发起协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyCoordinationWithCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationWithCodeResponse
        /// </returns>
        public async Task<ApplyCoordinationWithCodeResponse> ApplyCoordinationWithCodeWithOptionsAsync(ApplyCoordinationWithCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoordinationCode))
            {
                body["CoordinationCode"] = request.CoordinationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyCoordinationWithCode",
                Version = "2022-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCoordinationWithCodeResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用协同码发起协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyCoordinationWithCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationWithCodeResponse
        /// </returns>
        public ApplyCoordinationWithCodeResponse ApplyCoordinationWithCode(ApplyCoordinationWithCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyCoordinationWithCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用协同码发起协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyCoordinationWithCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationWithCodeResponse
        /// </returns>
        public async Task<ApplyCoordinationWithCodeResponse> ApplyCoordinationWithCodeAsync(ApplyCoordinationWithCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyCoordinationWithCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Owner主动结束本次协同，同步失效协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndAllCoordinationByOwnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EndAllCoordinationByOwnerResponse
        /// </returns>
        public EndAllCoordinationByOwnerResponse EndAllCoordinationByOwnerWithOptions(EndAllCoordinationByOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                body["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndAllCoordinationByOwner",
                Version = "2022-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndAllCoordinationByOwnerResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Owner主动结束本次协同，同步失效协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndAllCoordinationByOwnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EndAllCoordinationByOwnerResponse
        /// </returns>
        public async Task<EndAllCoordinationByOwnerResponse> EndAllCoordinationByOwnerWithOptionsAsync(EndAllCoordinationByOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                body["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndAllCoordinationByOwner",
                Version = "2022-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndAllCoordinationByOwnerResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Owner主动结束本次协同，同步失效协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndAllCoordinationByOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// EndAllCoordinationByOwnerResponse
        /// </returns>
        public EndAllCoordinationByOwnerResponse EndAllCoordinationByOwner(EndAllCoordinationByOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EndAllCoordinationByOwnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Owner主动结束本次协同，同步失效协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndAllCoordinationByOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// EndAllCoordinationByOwnerResponse
        /// </returns>
        public async Task<EndAllCoordinationByOwnerResponse> EndAllCoordinationByOwnerAsync(EndAllCoordinationByOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EndAllCoordinationByOwnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public GenerateCoordinationCodeResponse GenerateCoordinationCodeWithOptions(GenerateCoordinationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                body["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCoordinationCode",
                Version = "2022-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCoordinationCodeResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public async Task<GenerateCoordinationCodeResponse> GenerateCoordinationCodeWithOptionsAsync(GenerateCoordinationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                body["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCoordinationCode",
                Version = "2022-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCoordinationCodeResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public GenerateCoordinationCodeResponse GenerateCoordinationCode(GenerateCoordinationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCoordinationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成协同码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public async Task<GenerateCoordinationCodeResponse> GenerateCoordinationCodeAsync(GenerateCoordinationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCoordinationCodeWithOptionsAsync(request, runtime);
        }

    }
}
