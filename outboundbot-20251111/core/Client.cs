// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OutboundBot20251111.Models;

namespace AlibabaCloud.SDK.OutboundBot20251111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "outboundbot.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("outboundbot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloneVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloneVoiceResponse
        /// </returns>
        public CreateCloneVoiceResponse CreateCloneVoiceWithOptions(CreateCloneVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloneVoice",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloneVoiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloneVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloneVoiceResponse
        /// </returns>
        public async Task<CreateCloneVoiceResponse> CreateCloneVoiceWithOptionsAsync(CreateCloneVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloneVoice",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloneVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloneVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloneVoiceResponse
        /// </returns>
        public CreateCloneVoiceResponse CreateCloneVoice(CreateCloneVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCloneVoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloneVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloneVoiceResponse
        /// </returns>
        public async Task<CreateCloneVoiceResponse> CreateCloneVoiceAsync(CreateCloneVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCloneVoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateFlashSmsAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashSmsAccessProfileResponse
        /// </returns>
        public CreateFlashSmsAccessProfileResponse CreateFlashSmsAccessProfileWithOptions(CreateFlashSmsAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlashSmsAccessProfileShrinkRequest request = new CreateFlashSmsAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccessProfile))
            {
                request.AccessProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccessProfile, "AccessProfile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileShrink))
            {
                body["AccessProfile"] = request.AccessProfileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlashSmsAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlashSmsAccessProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateFlashSmsAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashSmsAccessProfileResponse
        /// </returns>
        public async Task<CreateFlashSmsAccessProfileResponse> CreateFlashSmsAccessProfileWithOptionsAsync(CreateFlashSmsAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlashSmsAccessProfileShrinkRequest request = new CreateFlashSmsAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccessProfile))
            {
                request.AccessProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccessProfile, "AccessProfile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileShrink))
            {
                body["AccessProfile"] = request.AccessProfileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlashSmsAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlashSmsAccessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlashSmsAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashSmsAccessProfileResponse
        /// </returns>
        public CreateFlashSmsAccessProfileResponse CreateFlashSmsAccessProfile(CreateFlashSmsAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlashSmsAccessProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlashSmsAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlashSmsAccessProfileResponse
        /// </returns>
        public async Task<CreateFlashSmsAccessProfileResponse> CreateFlashSmsAccessProfileAsync(CreateFlashSmsAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlashSmsAccessProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMode))
            {
                body["ServiceMode"] = request.ServiceMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMode))
            {
                body["ServiceMode"] = request.ServiceMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOutboundCallRestrictionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundCallRestrictionResponse
        /// </returns>
        public CreateOutboundCallRestrictionResponse CreateOutboundCallRestrictionWithOptions(CreateOutboundCallRestrictionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOutboundCallRestrictionShrinkRequest request = new CreateOutboundCallRestrictionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundCallRestriction))
            {
                request.OutboundCallRestrictionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundCallRestriction, "OutboundCallRestriction", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallRestrictionShrink))
            {
                body["OutboundCallRestriction"] = request.OutboundCallRestrictionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOutboundCallRestriction",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOutboundCallRestrictionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOutboundCallRestrictionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundCallRestrictionResponse
        /// </returns>
        public async Task<CreateOutboundCallRestrictionResponse> CreateOutboundCallRestrictionWithOptionsAsync(CreateOutboundCallRestrictionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOutboundCallRestrictionShrinkRequest request = new CreateOutboundCallRestrictionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundCallRestriction))
            {
                request.OutboundCallRestrictionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundCallRestriction, "OutboundCallRestriction", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallRestrictionShrink))
            {
                body["OutboundCallRestriction"] = request.OutboundCallRestrictionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOutboundCallRestriction",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOutboundCallRestrictionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOutboundCallRestrictionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundCallRestrictionResponse
        /// </returns>
        public CreateOutboundCallRestrictionResponse CreateOutboundCallRestriction(CreateOutboundCallRestrictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOutboundCallRestrictionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOutboundCallRestrictionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundCallRestrictionResponse
        /// </returns>
        public async Task<CreateOutboundCallRestrictionResponse> CreateOutboundCallRestrictionAsync(CreateOutboundCallRestrictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOutboundCallRestrictionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public CreateScriptResponse CreateScriptWithOptions(CreateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                body["NluEngine"] = request.NluEngine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public async Task<CreateScriptResponse> CreateScriptWithOptionsAsync(CreateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                body["NluEngine"] = request.NluEngine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptResponse
        /// </returns>
        public async Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScriptVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptVersionResponse
        /// </returns>
        public CreateScriptVersionResponse CreateScriptVersionWithOptions(CreateScriptVersionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScriptVersionShrinkRequest request = new CreateScriptVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InteractionConfig))
            {
                request.InteractionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InteractionConfig, "InteractionConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelConfigs))
            {
                request.LabelConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelConfigs, "LabelConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScriptProfile))
            {
                request.ScriptProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScriptProfile, "ScriptProfile", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SynthesizerConfig))
            {
                request.SynthesizerConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SynthesizerConfig, "SynthesizerConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TranscriberConfig))
            {
                request.TranscriberConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TranscriberConfig, "TranscriberConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InteractionConfigShrink))
            {
                body["InteractionConfig"] = request.InteractionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelConfigsShrink))
            {
                body["LabelConfigs"] = request.LabelConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptProfileShrink))
            {
                body["ScriptProfile"] = request.ScriptProfileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVersionId))
            {
                body["SourceVersionId"] = request.SourceVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynthesizerConfigShrink))
            {
                body["SynthesizerConfig"] = request.SynthesizerConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscriberConfigShrink))
            {
                body["TranscriberConfig"] = request.TranscriberConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScriptVersion",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScriptVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptVersionResponse
        /// </returns>
        public async Task<CreateScriptVersionResponse> CreateScriptVersionWithOptionsAsync(CreateScriptVersionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScriptVersionShrinkRequest request = new CreateScriptVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InteractionConfig))
            {
                request.InteractionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InteractionConfig, "InteractionConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelConfigs))
            {
                request.LabelConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelConfigs, "LabelConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScriptProfile))
            {
                request.ScriptProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScriptProfile, "ScriptProfile", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SynthesizerConfig))
            {
                request.SynthesizerConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SynthesizerConfig, "SynthesizerConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TranscriberConfig))
            {
                request.TranscriberConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TranscriberConfig, "TranscriberConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InteractionConfigShrink))
            {
                body["InteractionConfig"] = request.InteractionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelConfigsShrink))
            {
                body["LabelConfigs"] = request.LabelConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptProfileShrink))
            {
                body["ScriptProfile"] = request.ScriptProfileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVersionId))
            {
                body["SourceVersionId"] = request.SourceVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynthesizerConfigShrink))
            {
                body["SynthesizerConfig"] = request.SynthesizerConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscriberConfigShrink))
            {
                body["TranscriberConfig"] = request.TranscriberConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScriptVersion",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScriptVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptVersionResponse
        /// </returns>
        public CreateScriptVersionResponse CreateScriptVersion(CreateScriptVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScriptVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScriptVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScriptVersionResponse
        /// </returns>
        public async Task<CreateScriptVersionResponse> CreateScriptVersionAsync(CreateScriptVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScriptVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateVoiceAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVoiceAccessProfileResponse
        /// </returns>
        public CreateVoiceAccessProfileResponse CreateVoiceAccessProfileWithOptions(CreateVoiceAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVoiceAccessProfileShrinkRequest request = new CreateVoiceAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Profile))
            {
                request.ProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Profile, "Profile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsEngine))
            {
                body["NlsEngine"] = request.NlsEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileShrink))
            {
                body["Profile"] = request.ProfileShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVoiceAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVoiceAccessProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateVoiceAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVoiceAccessProfileResponse
        /// </returns>
        public async Task<CreateVoiceAccessProfileResponse> CreateVoiceAccessProfileWithOptionsAsync(CreateVoiceAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVoiceAccessProfileShrinkRequest request = new CreateVoiceAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Profile))
            {
                request.ProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Profile, "Profile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsEngine))
            {
                body["NlsEngine"] = request.NlsEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileShrink))
            {
                body["Profile"] = request.ProfileShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVoiceAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVoiceAccessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVoiceAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVoiceAccessProfileResponse
        /// </returns>
        public CreateVoiceAccessProfileResponse CreateVoiceAccessProfile(CreateVoiceAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVoiceAccessProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVoiceAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVoiceAccessProfileResponse
        /// </returns>
        public async Task<CreateVoiceAccessProfileResponse> CreateVoiceAccessProfileAsync(CreateVoiceAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVoiceAccessProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCloneVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloneVoiceResponse
        /// </returns>
        public DeleteCloneVoiceResponse DeleteCloneVoiceWithOptions(DeleteCloneVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloneVoiceId))
            {
                body["CloneVoiceId"] = request.CloneVoiceId;
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
                Action = "DeleteCloneVoice",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloneVoiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCloneVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloneVoiceResponse
        /// </returns>
        public async Task<DeleteCloneVoiceResponse> DeleteCloneVoiceWithOptionsAsync(DeleteCloneVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloneVoiceId))
            {
                body["CloneVoiceId"] = request.CloneVoiceId;
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
                Action = "DeleteCloneVoice",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloneVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCloneVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloneVoiceResponse
        /// </returns>
        public DeleteCloneVoiceResponse DeleteCloneVoice(DeleteCloneVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCloneVoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCloneVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloneVoiceResponse
        /// </returns>
        public async Task<DeleteCloneVoiceResponse> DeleteCloneVoiceAsync(DeleteCloneVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCloneVoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪信配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlashSmsAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlashSmsAccessProfileResponse
        /// </returns>
        public DeleteFlashSmsAccessProfileResponse DeleteFlashSmsAccessProfileWithOptions(DeleteFlashSmsAccessProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
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
                Action = "DeleteFlashSmsAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlashSmsAccessProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪信配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlashSmsAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlashSmsAccessProfileResponse
        /// </returns>
        public async Task<DeleteFlashSmsAccessProfileResponse> DeleteFlashSmsAccessProfileWithOptionsAsync(DeleteFlashSmsAccessProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
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
                Action = "DeleteFlashSmsAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlashSmsAccessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪信配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlashSmsAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlashSmsAccessProfileResponse
        /// </returns>
        public DeleteFlashSmsAccessProfileResponse DeleteFlashSmsAccessProfile(DeleteFlashSmsAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlashSmsAccessProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除闪信配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlashSmsAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlashSmsAccessProfileResponse
        /// </returns>
        public async Task<DeleteFlashSmsAccessProfileResponse> DeleteFlashSmsAccessProfileAsync(DeleteFlashSmsAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlashSmsAccessProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes blacklists and whitelists.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteOutboundCallRestrictionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallRestrictionResponse
        /// </returns>
        public DeleteOutboundCallRestrictionResponse DeleteOutboundCallRestrictionWithOptions(DeleteOutboundCallRestrictionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteOutboundCallRestrictionShrinkRequest request = new DeleteOutboundCallRestrictionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RestrictionIdList))
            {
                request.RestrictionIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RestrictionIdList, "RestrictionIdList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestrictionIdListShrink))
            {
                body["RestrictionIdList"] = request.RestrictionIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOutboundCallRestriction",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOutboundCallRestrictionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes blacklists and whitelists.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteOutboundCallRestrictionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallRestrictionResponse
        /// </returns>
        public async Task<DeleteOutboundCallRestrictionResponse> DeleteOutboundCallRestrictionWithOptionsAsync(DeleteOutboundCallRestrictionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteOutboundCallRestrictionShrinkRequest request = new DeleteOutboundCallRestrictionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RestrictionIdList))
            {
                request.RestrictionIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RestrictionIdList, "RestrictionIdList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestrictionIdListShrink))
            {
                body["RestrictionIdList"] = request.RestrictionIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOutboundCallRestriction",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOutboundCallRestrictionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes blacklists and whitelists.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOutboundCallRestrictionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallRestrictionResponse
        /// </returns>
        public DeleteOutboundCallRestrictionResponse DeleteOutboundCallRestriction(DeleteOutboundCallRestrictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOutboundCallRestrictionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes blacklists and whitelists.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOutboundCallRestrictionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundCallRestrictionResponse
        /// </returns>
        public async Task<DeleteOutboundCallRestrictionResponse> DeleteOutboundCallRestrictionAsync(DeleteOutboundCallRestrictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOutboundCallRestrictionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public DeleteScriptResponse DeleteScriptWithOptions(DeleteScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public async Task<DeleteScriptResponse> DeleteScriptWithOptionsAsync(DeleteScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public DeleteScriptResponse DeleteScript(DeleteScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScriptResponse
        /// </returns>
        public async Task<DeleteScriptResponse> DeleteScriptAsync(DeleteScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除三方语音配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVoiceAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVoiceAccessProfileResponse
        /// </returns>
        public DeleteVoiceAccessProfileResponse DeleteVoiceAccessProfileWithOptions(DeleteVoiceAccessProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
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
                Action = "DeleteVoiceAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVoiceAccessProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除三方语音配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVoiceAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVoiceAccessProfileResponse
        /// </returns>
        public async Task<DeleteVoiceAccessProfileResponse> DeleteVoiceAccessProfileWithOptionsAsync(DeleteVoiceAccessProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
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
                Action = "DeleteVoiceAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVoiceAccessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除三方语音配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVoiceAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVoiceAccessProfileResponse
        /// </returns>
        public DeleteVoiceAccessProfileResponse DeleteVoiceAccessProfile(DeleteVoiceAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVoiceAccessProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除三方语音配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVoiceAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVoiceAccessProfileResponse
        /// </returns>
        public async Task<DeleteVoiceAccessProfileResponse> DeleteVoiceAccessProfileAsync(DeleteVoiceAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVoiceAccessProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用消息订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSubscriptionResponse
        /// </returns>
        public DisableSubscriptionResponse DisableSubscriptionWithOptions(DisableSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DisableSubscription",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用消息订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSubscriptionResponse
        /// </returns>
        public async Task<DisableSubscriptionResponse> DisableSubscriptionWithOptionsAsync(DisableSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DisableSubscription",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用消息订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSubscriptionResponse
        /// </returns>
        public DisableSubscriptionResponse DisableSubscription(DisableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用消息订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSubscriptionResponse
        /// </returns>
        public async Task<DisableSubscriptionResponse> DisableSubscriptionAsync(DisableSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取prompt场景模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScriptProfileTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScriptProfileTemplateResponse
        /// </returns>
        public GetScriptProfileTemplateResponse GetScriptProfileTemplateWithOptions(GetScriptProfileTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScriptProfileTemplate",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScriptProfileTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取prompt场景模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScriptProfileTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScriptProfileTemplateResponse
        /// </returns>
        public async Task<GetScriptProfileTemplateResponse> GetScriptProfileTemplateWithOptionsAsync(GetScriptProfileTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScriptProfileTemplate",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScriptProfileTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取prompt场景模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScriptProfileTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScriptProfileTemplateResponse
        /// </returns>
        public GetScriptProfileTemplateResponse GetScriptProfileTemplate(GetScriptProfileTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScriptProfileTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取prompt场景模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScriptProfileTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScriptProfileTemplateResponse
        /// </returns>
        public async Task<GetScriptProfileTemplateResponse> GetScriptProfileTemplateAsync(GetScriptProfileTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScriptProfileTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MQ配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionResponse
        /// </returns>
        public GetSubscriptionResponse GetSubscriptionWithOptions(GetSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetSubscription",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MQ配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionResponse
        /// </returns>
        public async Task<GetSubscriptionResponse> GetSubscriptionWithOptionsAsync(GetSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetSubscription",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MQ配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionResponse
        /// </returns>
        public GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MQ配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionResponse
        /// </returns>
        public async Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色可用模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoiceModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoiceModelsResponse
        /// </returns>
        public ListCloneVoiceModelsResponse ListCloneVoiceModelsWithOptions(ListCloneVoiceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloneVoiceModels",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloneVoiceModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色可用模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoiceModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoiceModelsResponse
        /// </returns>
        public async Task<ListCloneVoiceModelsResponse> ListCloneVoiceModelsWithOptionsAsync(ListCloneVoiceModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloneVoiceModels",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloneVoiceModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色可用模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoiceModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoiceModelsResponse
        /// </returns>
        public ListCloneVoiceModelsResponse ListCloneVoiceModels(ListCloneVoiceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloneVoiceModelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色可用模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoiceModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoiceModelsResponse
        /// </returns>
        public async Task<ListCloneVoiceModelsResponse> ListCloneVoiceModelsAsync(ListCloneVoiceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloneVoiceModelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoicesResponse
        /// </returns>
        public ListCloneVoicesResponse ListCloneVoicesWithOptions(ListCloneVoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloneVoices",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloneVoicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoicesResponse
        /// </returns>
        public async Task<ListCloneVoicesResponse> ListCloneVoicesWithOptionsAsync(ListCloneVoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloneVoices",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloneVoicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoicesResponse
        /// </returns>
        public ListCloneVoicesResponse ListCloneVoices(ListCloneVoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloneVoicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取克隆音色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloneVoicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloneVoicesResponse
        /// </returns>
        public async Task<ListCloneVoicesResponse> ListCloneVoicesAsync(ListCloneVoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloneVoicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsAccessProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsAccessProfilesResponse
        /// </returns>
        public ListFlashSmsAccessProfilesResponse ListFlashSmsAccessProfilesWithOptions(ListFlashSmsAccessProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsAccessProfiles",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsAccessProfilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsAccessProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsAccessProfilesResponse
        /// </returns>
        public async Task<ListFlashSmsAccessProfilesResponse> ListFlashSmsAccessProfilesWithOptionsAsync(ListFlashSmsAccessProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsAccessProfiles",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsAccessProfilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsAccessProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsAccessProfilesResponse
        /// </returns>
        public ListFlashSmsAccessProfilesResponse ListFlashSmsAccessProfiles(ListFlashSmsAccessProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlashSmsAccessProfilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsAccessProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsAccessProfilesResponse
        /// </returns>
        public async Task<ListFlashSmsAccessProfilesResponse> ListFlashSmsAccessProfilesAsync(ListFlashSmsAccessProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlashSmsAccessProfilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsProvidersResponse
        /// </returns>
        public ListFlashSmsProvidersResponse ListFlashSmsProvidersWithOptions(ListFlashSmsProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ListFlashSmsProviders",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsProvidersResponse
        /// </returns>
        public async Task<ListFlashSmsProvidersResponse> ListFlashSmsProvidersWithOptionsAsync(ListFlashSmsProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ListFlashSmsProviders",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsProvidersResponse
        /// </returns>
        public ListFlashSmsProvidersResponse ListFlashSmsProviders(ListFlashSmsProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlashSmsProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsProvidersResponse
        /// </returns>
        public async Task<ListFlashSmsProvidersResponse> ListFlashSmsProvidersAsync(ListFlashSmsProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlashSmsProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public ListFlashSmsTemplatesResponse ListFlashSmsTemplatesWithOptions(ListFlashSmsTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsTemplates",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public async Task<ListFlashSmsTemplatesResponse> ListFlashSmsTemplatesWithOptionsAsync(ListFlashSmsTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsTemplates",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public ListFlashSmsTemplatesResponse ListFlashSmsTemplates(ListFlashSmsTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlashSmsTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪信模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlashSmsTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsTemplatesResponse
        /// </returns>
        public async Task<ListFlashSmsTemplatesResponse> ListFlashSmsTemplatesAsync(ListFlashSmsTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlashSmsTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves instance details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves instance details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves instance details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves instance details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the blacklists and whitelists of an outbound robot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOutboundCallRestrictionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallRestrictionsResponse
        /// </returns>
        public ListOutboundCallRestrictionsResponse ListOutboundCallRestrictionsWithOptions(ListOutboundCallRestrictionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutboundCallRestrictions",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundCallRestrictionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the blacklists and whitelists of an outbound robot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOutboundCallRestrictionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallRestrictionsResponse
        /// </returns>
        public async Task<ListOutboundCallRestrictionsResponse> ListOutboundCallRestrictionsWithOptionsAsync(ListOutboundCallRestrictionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutboundCallRestrictions",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundCallRestrictionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the blacklists and whitelists of an outbound robot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOutboundCallRestrictionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallRestrictionsResponse
        /// </returns>
        public ListOutboundCallRestrictionsResponse ListOutboundCallRestrictions(ListOutboundCallRestrictionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundCallRestrictionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the blacklists and whitelists of an outbound robot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOutboundCallRestrictionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundCallRestrictionsResponse
        /// </returns>
        public async Task<ListOutboundCallRestrictionsResponse> ListOutboundCallRestrictionsAsync(ListOutboundCallRestrictionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundCallRestrictionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景配置模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptProfileTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptProfileTemplatesResponse
        /// </returns>
        public ListScriptProfileTemplatesResponse ListScriptProfileTemplatesWithOptions(ListScriptProfileTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                body["NluEngine"] = request.NluEngine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptProfileTemplates",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptProfileTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景配置模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptProfileTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptProfileTemplatesResponse
        /// </returns>
        public async Task<ListScriptProfileTemplatesResponse> ListScriptProfileTemplatesWithOptionsAsync(ListScriptProfileTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluEngine))
            {
                body["NluEngine"] = request.NluEngine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScriptProfileTemplates",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptProfileTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景配置模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptProfileTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptProfileTemplatesResponse
        /// </returns>
        public ListScriptProfileTemplatesResponse ListScriptProfileTemplates(ListScriptProfileTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptProfileTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景配置模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptProfileTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptProfileTemplatesResponse
        /// </returns>
        public async Task<ListScriptProfileTemplatesResponse> ListScriptProfileTemplatesAsync(ListScriptProfileTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptProfileTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public ListScriptsResponse ListScriptsWithOptions(ListScriptsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListScriptsShrinkRequest request = new ListScriptsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScriptIds))
            {
                request.ScriptIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScriptIds, "ScriptIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishOnly))
            {
                body["PublishOnly"] = request.PublishOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptIdsShrink))
            {
                body["ScriptIds"] = request.ScriptIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScripts",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public async Task<ListScriptsResponse> ListScriptsWithOptionsAsync(ListScriptsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListScriptsShrinkRequest request = new ListScriptsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScriptIds))
            {
                request.ScriptIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScriptIds, "ScriptIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishOnly))
            {
                body["PublishOnly"] = request.PublishOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptIdsShrink))
            {
                body["ScriptIds"] = request.ScriptIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScripts",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsResponse
        /// </returns>
        public async Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsByFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsByFlowResponse
        /// </returns>
        public ListScriptsByFlowResponse ListScriptsByFlowWithOptions(ListScriptsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
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
                Action = "ListScriptsByFlow",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsByFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsByFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsByFlowResponse
        /// </returns>
        public async Task<ListScriptsByFlowResponse> ListScriptsByFlowWithOptionsAsync(ListScriptsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
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
                Action = "ListScriptsByFlow",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsByFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsByFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsByFlowResponse
        /// </returns>
        public ListScriptsByFlowResponse ListScriptsByFlow(ListScriptsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptsByFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据流程ID获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScriptsByFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScriptsByFlowResponse
        /// </returns>
        public async Task<ListScriptsByFlowResponse> ListScriptsByFlowAsync(ListScriptsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptsByFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSystemConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigsResponse
        /// </returns>
        public ListSystemConfigsResponse ListSystemConfigsWithOptions(ListSystemConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["ObjectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemConfigs",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSystemConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigsResponse
        /// </returns>
        public async Task<ListSystemConfigsResponse> ListSystemConfigsWithOptionsAsync(ListSystemConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["ObjectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemConfigs",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSystemConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigsResponse
        /// </returns>
        public ListSystemConfigsResponse ListSystemConfigs(ListSystemConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSystemConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigsResponse
        /// </returns>
        public async Task<ListSystemConfigsResponse> ListSystemConfigsAsync(ListSystemConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音接入配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceAccessProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceAccessProfilesResponse
        /// </returns>
        public ListVoiceAccessProfilesResponse ListVoiceAccessProfilesWithOptions(ListVoiceAccessProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVoiceAccessProfiles",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVoiceAccessProfilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音接入配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceAccessProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceAccessProfilesResponse
        /// </returns>
        public async Task<ListVoiceAccessProfilesResponse> ListVoiceAccessProfilesWithOptionsAsync(ListVoiceAccessProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVoiceAccessProfiles",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVoiceAccessProfilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音接入配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceAccessProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceAccessProfilesResponse
        /// </returns>
        public ListVoiceAccessProfilesResponse ListVoiceAccessProfiles(ListVoiceAccessProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVoiceAccessProfilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音接入配置列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceAccessProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceAccessProfilesResponse
        /// </returns>
        public async Task<ListVoiceAccessProfilesResponse> ListVoiceAccessProfilesAsync(ListVoiceAccessProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVoiceAccessProfilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public PublishScriptResponse PublishScriptWithOptions(PublishScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public async Task<PublishScriptResponse> PublishScriptWithOptionsAsync(PublishScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public PublishScriptResponse PublishScript(PublishScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishScriptResponse
        /// </returns>
        public async Task<PublishScriptResponse> PublishScriptAsync(PublishScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloneVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloneVoiceResponse
        /// </returns>
        public UpdateCloneVoiceResponse UpdateCloneVoiceWithOptions(UpdateCloneVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloneVoiceId))
            {
                body["CloneVoiceId"] = request.CloneVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCloneVoice",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCloneVoiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloneVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloneVoiceResponse
        /// </returns>
        public async Task<UpdateCloneVoiceResponse> UpdateCloneVoiceWithOptionsAsync(UpdateCloneVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloneVoiceId))
            {
                body["CloneVoiceId"] = request.CloneVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCloneVoice",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCloneVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloneVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloneVoiceResponse
        /// </returns>
        public UpdateCloneVoiceResponse UpdateCloneVoice(UpdateCloneVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCloneVoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新克隆音色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCloneVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCloneVoiceResponse
        /// </returns>
        public async Task<UpdateCloneVoiceResponse> UpdateCloneVoiceAsync(UpdateCloneVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCloneVoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪信配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateFlashSmsAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlashSmsAccessProfileResponse
        /// </returns>
        public UpdateFlashSmsAccessProfileResponse UpdateFlashSmsAccessProfileWithOptions(UpdateFlashSmsAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlashSmsAccessProfileShrinkRequest request = new UpdateFlashSmsAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccessProfile))
            {
                request.AccessProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccessProfile, "AccessProfile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileShrink))
            {
                body["AccessProfile"] = request.AccessProfileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlashSmsAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlashSmsAccessProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪信配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateFlashSmsAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlashSmsAccessProfileResponse
        /// </returns>
        public async Task<UpdateFlashSmsAccessProfileResponse> UpdateFlashSmsAccessProfileWithOptionsAsync(UpdateFlashSmsAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlashSmsAccessProfileShrinkRequest request = new UpdateFlashSmsAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccessProfile))
            {
                request.AccessProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccessProfile, "AccessProfile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileShrink))
            {
                body["AccessProfile"] = request.AccessProfileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderId))
            {
                body["ProviderId"] = request.ProviderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlashSmsAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlashSmsAccessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪信配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlashSmsAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlashSmsAccessProfileResponse
        /// </returns>
        public UpdateFlashSmsAccessProfileResponse UpdateFlashSmsAccessProfile(UpdateFlashSmsAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlashSmsAccessProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新闪信配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlashSmsAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlashSmsAccessProfileResponse
        /// </returns>
        public async Task<UpdateFlashSmsAccessProfileResponse> UpdateFlashSmsAccessProfileAsync(UpdateFlashSmsAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlashSmsAccessProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScriptResponse
        /// </returns>
        public UpdateScriptResponse UpdateScriptWithOptions(UpdateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScriptResponse
        /// </returns>
        public async Task<UpdateScriptResponse> UpdateScriptWithOptionsAsync(UpdateScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptId))
            {
                body["ScriptId"] = request.ScriptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScript",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScriptResponse
        /// </returns>
        public UpdateScriptResponse UpdateScript(UpdateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScriptResponse
        /// </returns>
        public async Task<UpdateScriptResponse> UpdateScriptAsync(UpdateScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新MQ配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(UpdateSubscriptionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSubscriptionShrinkRequest request = new UpdateSubscriptionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventSubscriptions))
            {
                request.EventSubscriptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventSubscriptions, "EventSubscriptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                body["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSubscriptionsShrink))
            {
                body["EventSubscriptions"] = request.EventSubscriptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqInstanceId))
            {
                body["MqInstanceId"] = request.MqInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqType))
            {
                body["MqType"] = request.MqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProducerId))
            {
                body["ProducerId"] = request.ProducerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新MQ配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(UpdateSubscriptionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSubscriptionShrinkRequest request = new UpdateSubscriptionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventSubscriptions))
            {
                request.EventSubscriptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventSubscriptions, "EventSubscriptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                body["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSubscriptionsShrink))
            {
                body["EventSubscriptions"] = request.EventSubscriptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqInstanceId))
            {
                body["MqInstanceId"] = request.MqInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqType))
            {
                body["MqType"] = request.MqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProducerId))
            {
                body["ProducerId"] = request.ProducerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubscription",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新MQ配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或更新MQ配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSubscriptionResponse
        /// </returns>
        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新系统配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSystemConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSystemConfigsResponse
        /// </returns>
        public UpdateSystemConfigsResponse UpdateSystemConfigsWithOptions(UpdateSystemConfigsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSystemConfigsShrinkRequest request = new UpdateSystemConfigsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["ObjectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSystemConfigs",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSystemConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新系统配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSystemConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSystemConfigsResponse
        /// </returns>
        public async Task<UpdateSystemConfigsResponse> UpdateSystemConfigsWithOptionsAsync(UpdateSystemConfigsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSystemConfigsShrinkRequest request = new UpdateSystemConfigsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["ObjectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSystemConfigs",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSystemConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新系统配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSystemConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSystemConfigsResponse
        /// </returns>
        public UpdateSystemConfigsResponse UpdateSystemConfigs(UpdateSystemConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSystemConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新系统配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSystemConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSystemConfigsResponse
        /// </returns>
        public async Task<UpdateSystemConfigsResponse> UpdateSystemConfigsAsync(UpdateSystemConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSystemConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateVoiceAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceAccessProfileResponse
        /// </returns>
        public UpdateVoiceAccessProfileResponse UpdateVoiceAccessProfileWithOptions(UpdateVoiceAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateVoiceAccessProfileShrinkRequest request = new UpdateVoiceAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Profile))
            {
                request.ProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Profile, "Profile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsEngine))
            {
                body["NlsEngine"] = request.NlsEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileShrink))
            {
                body["Profile"] = request.ProfileShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVoiceAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVoiceAccessProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateVoiceAccessProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceAccessProfileResponse
        /// </returns>
        public async Task<UpdateVoiceAccessProfileResponse> UpdateVoiceAccessProfileWithOptionsAsync(UpdateVoiceAccessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateVoiceAccessProfileShrinkRequest request = new UpdateVoiceAccessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Profile))
            {
                request.ProfileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Profile, "Profile", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessProfileId))
            {
                body["AccessProfileId"] = request.AccessProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsEngine))
            {
                body["NlsEngine"] = request.NlsEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileShrink))
            {
                body["Profile"] = request.ProfileShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVoiceAccessProfile",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVoiceAccessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVoiceAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceAccessProfileResponse
        /// </returns>
        public UpdateVoiceAccessProfileResponse UpdateVoiceAccessProfile(UpdateVoiceAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVoiceAccessProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新语音接入配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVoiceAccessProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVoiceAccessProfileResponse
        /// </returns>
        public async Task<UpdateVoiceAccessProfileResponse> UpdateVoiceAccessProfileAsync(UpdateVoiceAccessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVoiceAccessProfileWithOptionsAsync(request, runtime);
        }

    }
}
