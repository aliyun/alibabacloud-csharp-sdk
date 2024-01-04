// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.XrEngine20230313.Models;

namespace AlibabaCloud.SDK.XrEngine20230313
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "xrengine-daily.aliyuncs.com"},
                {"ap-northeast-2-pop", "xrengine-daily.aliyuncs.com"},
                {"ap-south-1", "xrengine-daily.aliyuncs.com"},
                {"ap-southeast-1", "xrengine-daily.aliyuncs.com"},
                {"ap-southeast-2", "xrengine-daily.aliyuncs.com"},
                {"ap-southeast-3", "xrengine-daily.aliyuncs.com"},
                {"ap-southeast-5", "xrengine-daily.aliyuncs.com"},
                {"cn-beijing", "xrengine-daily.aliyuncs.com"},
                {"cn-beijing-finance-1", "xrengine-daily.aliyuncs.com"},
                {"cn-beijing-finance-pop", "xrengine-daily.aliyuncs.com"},
                {"cn-beijing-gov-1", "xrengine-daily.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "xrengine-daily.aliyuncs.com"},
                {"cn-chengdu", "xrengine-daily.aliyuncs.com"},
                {"cn-edge-1", "xrengine-daily.aliyuncs.com"},
                {"cn-fujian", "xrengine-daily.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-finance", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "xrengine-daily.aliyuncs.com"},
                {"cn-hangzhou-test-306", "xrengine-daily.aliyuncs.com"},
                {"cn-hongkong", "xrengine-daily.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "xrengine-daily.aliyuncs.com"},
                {"cn-huhehaote", "xrengine-daily.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "xrengine-daily.aliyuncs.com"},
                {"cn-north-2-gov-1", "xrengine-daily.aliyuncs.com"},
                {"cn-qingdao", "xrengine-daily.aliyuncs.com"},
                {"cn-qingdao-nebula", "xrengine-daily.aliyuncs.com"},
                {"cn-shanghai", "xrengine-daily.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "xrengine-daily.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "xrengine-daily.aliyuncs.com"},
                {"cn-shanghai-finance-1", "xrengine-daily.aliyuncs.com"},
                {"cn-shanghai-inner", "xrengine-daily.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "xrengine-daily.aliyuncs.com"},
                {"cn-shenzhen", "xrengine-daily.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "xrengine-daily.aliyuncs.com"},
                {"cn-shenzhen-inner", "xrengine-daily.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "xrengine-daily.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "xrengine-daily.aliyuncs.com"},
                {"cn-wuhan", "xrengine-daily.aliyuncs.com"},
                {"cn-wulanchabu", "xrengine-daily.aliyuncs.com"},
                {"cn-yushanfang", "xrengine-daily.aliyuncs.com"},
                {"cn-zhangbei", "xrengine-daily.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "xrengine-daily.aliyuncs.com"},
                {"cn-zhangjiakou", "xrengine-daily.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "xrengine-daily.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "xrengine-daily.aliyuncs.com"},
                {"eu-central-1", "xrengine-daily.aliyuncs.com"},
                {"eu-west-1", "xrengine-daily.aliyuncs.com"},
                {"eu-west-1-oxs", "xrengine-daily.aliyuncs.com"},
                {"me-east-1", "xrengine-daily.aliyuncs.com"},
                {"rus-west-1-pop", "xrengine-daily.aliyuncs.com"},
                {"us-east-1", "xrengine-daily.aliyuncs.com"},
                {"us-west-1", "xrengine-daily.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("xrengine", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AuthUserResponse AuthUserWithOptions(AuthUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthUser",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthUserResponse> AuthUserWithOptionsAsync(AuthUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthUser",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthUserResponse AuthUser(AuthUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthUserWithOptions(request, runtime);
        }

        public async Task<AuthUserResponse> AuthUserAsync(AuthUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthUserWithOptionsAsync(request, runtime);
        }

        public BatchQueryMotionShopTaskStatusResponse BatchQueryMotionShopTaskStatusWithOptions(BatchQueryMotionShopTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryMotionShopTaskStatus",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryMotionShopTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchQueryMotionShopTaskStatusResponse> BatchQueryMotionShopTaskStatusWithOptionsAsync(BatchQueryMotionShopTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryMotionShopTaskStatus",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryMotionShopTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchQueryMotionShopTaskStatusResponse BatchQueryMotionShopTaskStatus(BatchQueryMotionShopTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryMotionShopTaskStatusWithOptions(request, runtime);
        }

        public async Task<BatchQueryMotionShopTaskStatusResponse> BatchQueryMotionShopTaskStatusAsync(BatchQueryMotionShopTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryMotionShopTaskStatusWithOptionsAsync(request, runtime);
        }

        public CreateDigitalHumanProjectResponse CreateDigitalHumanProjectWithOptions(CreateDigitalHumanProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioId))
            {
                body["AudioId"] = request.AudioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioUrl))
            {
                body["AudioUrl"] = request.AudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundId))
            {
                body["BackgroundId"] = request.BackgroundId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundUrl))
            {
                body["BackgroundUrl"] = request.BackgroundUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForegroundId))
            {
                body["ForegroundId"] = request.ForegroundId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForegroundUrl))
            {
                body["ForegroundUrl"] = request.ForegroundUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HumanLayerStyle))
            {
                body["HumanLayerStyle"] = request.HumanLayerStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                body["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceId))
            {
                body["TtsVoiceId"] = request.TtsVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageUrl))
            {
                body["WatermarkImageUrl"] = request.WatermarkImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkStyle))
            {
                body["WatermarkStyle"] = request.WatermarkStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalHumanProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalHumanProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDigitalHumanProjectResponse> CreateDigitalHumanProjectWithOptionsAsync(CreateDigitalHumanProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioId))
            {
                body["AudioId"] = request.AudioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioUrl))
            {
                body["AudioUrl"] = request.AudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundId))
            {
                body["BackgroundId"] = request.BackgroundId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundUrl))
            {
                body["BackgroundUrl"] = request.BackgroundUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForegroundId))
            {
                body["ForegroundId"] = request.ForegroundId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForegroundUrl))
            {
                body["ForegroundUrl"] = request.ForegroundUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HumanLayerStyle))
            {
                body["HumanLayerStyle"] = request.HumanLayerStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                body["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceId))
            {
                body["TtsVoiceId"] = request.TtsVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageUrl))
            {
                body["WatermarkImageUrl"] = request.WatermarkImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkStyle))
            {
                body["WatermarkStyle"] = request.WatermarkStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalHumanProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalHumanProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDigitalHumanProjectResponse CreateDigitalHumanProject(CreateDigitalHumanProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDigitalHumanProjectWithOptions(request, runtime);
        }

        public async Task<CreateDigitalHumanProjectResponse> CreateDigitalHumanProjectAsync(CreateDigitalHumanProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDigitalHumanProjectWithOptionsAsync(request, runtime);
        }

        public CreateLivePortraitProjectResponse CreateLivePortraitProjectWithOptions(CreateLivePortraitProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioId))
            {
                body["AudioId"] = request.AudioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioUrl))
            {
                body["AudioUrl"] = request.AudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LightModel))
            {
                body["LightModel"] = request.LightModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                body["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceId))
            {
                body["TtsVoiceId"] = request.TtsVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageUrl))
            {
                body["WatermarkImageUrl"] = request.WatermarkImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkStyle))
            {
                body["WatermarkStyle"] = request.WatermarkStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLivePortraitProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLivePortraitProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLivePortraitProjectResponse> CreateLivePortraitProjectWithOptionsAsync(CreateLivePortraitProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioId))
            {
                body["AudioId"] = request.AudioId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioUrl))
            {
                body["AudioUrl"] = request.AudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LightModel))
            {
                body["LightModel"] = request.LightModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                body["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceId))
            {
                body["TtsVoiceId"] = request.TtsVoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageUrl))
            {
                body["WatermarkImageUrl"] = request.WatermarkImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkStyle))
            {
                body["WatermarkStyle"] = request.WatermarkStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLivePortraitProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLivePortraitProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLivePortraitProjectResponse CreateLivePortraitProject(CreateLivePortraitProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLivePortraitProjectWithOptions(request, runtime);
        }

        public async Task<CreateLivePortraitProjectResponse> CreateLivePortraitProjectAsync(CreateLivePortraitProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLivePortraitProjectWithOptionsAsync(request, runtime);
        }

        public GenerateMotionShopVideoUploadUrlResponse GenerateMotionShopVideoUploadUrlWithOptions(GenerateMotionShopVideoUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMotionShopVideoUploadUrl",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMotionShopVideoUploadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateMotionShopVideoUploadUrlResponse> GenerateMotionShopVideoUploadUrlWithOptionsAsync(GenerateMotionShopVideoUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMotionShopVideoUploadUrl",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMotionShopVideoUploadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateMotionShopVideoUploadUrlResponse GenerateMotionShopVideoUploadUrl(GenerateMotionShopVideoUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateMotionShopVideoUploadUrlWithOptions(request, runtime);
        }

        public async Task<GenerateMotionShopVideoUploadUrlResponse> GenerateMotionShopVideoUploadUrlAsync(GenerateMotionShopVideoUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateMotionShopVideoUploadUrlWithOptionsAsync(request, runtime);
        }

        public GetMapDataResponse GetMapDataWithOptions(GetMapDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMapData",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMapDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMapDataResponse> GetMapDataWithOptionsAsync(GetMapDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMapData",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMapDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMapDataResponse GetMapData(GetMapDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMapDataWithOptions(request, runtime);
        }

        public async Task<GetMapDataResponse> GetMapDataAsync(GetMapDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMapDataWithOptionsAsync(request, runtime);
        }

        public GetMapPublishDataResponse GetMapPublishDataWithOptions(GetMapPublishDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMapPublishData",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMapPublishDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMapPublishDataResponse> GetMapPublishDataWithOptionsAsync(GetMapPublishDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMapPublishData",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMapPublishDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMapPublishDataResponse GetMapPublishData(GetMapPublishDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMapPublishDataWithOptions(request, runtime);
        }

        public async Task<GetMapPublishDataResponse> GetMapPublishDataAsync(GetMapPublishDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMapPublishDataWithOptionsAsync(request, runtime);
        }

        public InitLocateResponse InitLocateWithOptions(InitLocateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitLocate",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitLocateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitLocateResponse> InitLocateWithOptionsAsync(InitLocateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitLocate",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitLocateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitLocateResponse InitLocate(InitLocateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitLocateWithOptions(request, runtime);
        }

        public async Task<InitLocateResponse> InitLocateAsync(InitLocateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitLocateWithOptionsAsync(request, runtime);
        }

        public ListCommonMaterialsResponse ListCommonMaterialsWithOptions(ListCommonMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
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
                Action = "ListCommonMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCommonMaterialsResponse> ListCommonMaterialsWithOptionsAsync(ListCommonMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
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
                Action = "ListCommonMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCommonMaterialsResponse ListCommonMaterials(ListCommonMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCommonMaterialsWithOptions(request, runtime);
        }

        public async Task<ListCommonMaterialsResponse> ListCommonMaterialsAsync(ListCommonMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCommonMaterialsWithOptionsAsync(request, runtime);
        }

        public ListDigitalHumanMaterialsResponse ListDigitalHumanMaterialsWithOptions(ListDigitalHumanMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyPersonalMaterials))
            {
                body["OnlyPersonalMaterials"] = request.OnlyPersonalMaterials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                body["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalHumanMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalHumanMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDigitalHumanMaterialsResponse> ListDigitalHumanMaterialsWithOptionsAsync(ListDigitalHumanMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyPersonalMaterials))
            {
                body["OnlyPersonalMaterials"] = request.OnlyPersonalMaterials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                body["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalHumanMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalHumanMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDigitalHumanMaterialsResponse ListDigitalHumanMaterials(ListDigitalHumanMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDigitalHumanMaterialsWithOptions(request, runtime);
        }

        public async Task<ListDigitalHumanMaterialsResponse> ListDigitalHumanMaterialsAsync(ListDigitalHumanMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDigitalHumanMaterialsWithOptionsAsync(request, runtime);
        }

        public ListLocationServiceResponse ListLocationServiceWithOptions(ListLocationServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLocationService",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLocationServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLocationServiceResponse> ListLocationServiceWithOptionsAsync(ListLocationServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLocationService",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLocationServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLocationServiceResponse ListLocationService(ListLocationServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLocationServiceWithOptions(request, runtime);
        }

        public async Task<ListLocationServiceResponse> ListLocationServiceAsync(ListLocationServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLocationServiceWithOptionsAsync(request, runtime);
        }

        public ListMotionShopTasksResponse ListMotionShopTasksWithOptions(ListMotionShopTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMotionShopTasks",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMotionShopTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMotionShopTasksResponse> ListMotionShopTasksWithOptionsAsync(ListMotionShopTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMotionShopTasks",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMotionShopTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMotionShopTasksResponse ListMotionShopTasks(ListMotionShopTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMotionShopTasksWithOptions(request, runtime);
        }

        public async Task<ListMotionShopTasksResponse> ListMotionShopTasksAsync(ListMotionShopTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMotionShopTasksWithOptionsAsync(request, runtime);
        }

        public LivePortraitFaceDetectResponse LivePortraitFaceDetectWithOptions(LivePortraitFaceDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LivePortraitFaceDetect",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LivePortraitFaceDetectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LivePortraitFaceDetectResponse> LivePortraitFaceDetectWithOptionsAsync(LivePortraitFaceDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LivePortraitFaceDetect",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LivePortraitFaceDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LivePortraitFaceDetectResponse LivePortraitFaceDetect(LivePortraitFaceDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LivePortraitFaceDetectWithOptions(request, runtime);
        }

        public async Task<LivePortraitFaceDetectResponse> LivePortraitFaceDetectAsync(LivePortraitFaceDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LivePortraitFaceDetectWithOptionsAsync(request, runtime);
        }

        public LocateResponse LocateWithOptions(LocateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Locate",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LocateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LocateResponse> LocateWithOptionsAsync(LocateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Locate",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LocateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LocateResponse Locate(LocateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LocateWithOptions(request, runtime);
        }

        public async Task<LocateResponse> LocateAsync(LocateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LocateWithOptionsAsync(request, runtime);
        }

        public LoginModelScopeResponse LoginModelScopeWithOptions(LoginModelScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpId))
            {
                body["EmpId"] = request.EmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpName))
            {
                body["EmpName"] = request.EmpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginModelScope",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginModelScopeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LoginModelScopeResponse> LoginModelScopeWithOptionsAsync(LoginModelScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpId))
            {
                body["EmpId"] = request.EmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpName))
            {
                body["EmpName"] = request.EmpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginModelScope",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginModelScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LoginModelScopeResponse LoginModelScope(LoginModelScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoginModelScopeWithOptions(request, runtime);
        }

        public async Task<LoginModelScopeResponse> LoginModelScopeAsync(LoginModelScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoginModelScopeWithOptionsAsync(request, runtime);
        }

        public MotionShopVideoDetectResponse MotionShopVideoDetectWithOptions(MotionShopVideoDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MotionShopVideoDetect",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MotionShopVideoDetectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MotionShopVideoDetectResponse> MotionShopVideoDetectWithOptionsAsync(MotionShopVideoDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MotionShopVideoDetect",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MotionShopVideoDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MotionShopVideoDetectResponse MotionShopVideoDetect(MotionShopVideoDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MotionShopVideoDetectWithOptions(request, runtime);
        }

        public async Task<MotionShopVideoDetectResponse> MotionShopVideoDetectAsync(MotionShopVideoDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MotionShopVideoDetectWithOptionsAsync(request, runtime);
        }

        public PopBatchQueryObjectGenerationProjectStatusResponse PopBatchQueryObjectGenerationProjectStatusWithOptions(PopBatchQueryObjectGenerationProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                body["ProjectIds"] = request.ProjectIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBatchQueryObjectGenerationProjectStatus",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBatchQueryObjectGenerationProjectStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBatchQueryObjectGenerationProjectStatusResponse> PopBatchQueryObjectGenerationProjectStatusWithOptionsAsync(PopBatchQueryObjectGenerationProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                body["ProjectIds"] = request.ProjectIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBatchQueryObjectGenerationProjectStatus",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBatchQueryObjectGenerationProjectStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBatchQueryObjectGenerationProjectStatusResponse PopBatchQueryObjectGenerationProjectStatus(PopBatchQueryObjectGenerationProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBatchQueryObjectGenerationProjectStatusWithOptions(request, runtime);
        }

        public async Task<PopBatchQueryObjectGenerationProjectStatusResponse> PopBatchQueryObjectGenerationProjectStatusAsync(PopBatchQueryObjectGenerationProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBatchQueryObjectGenerationProjectStatusWithOptionsAsync(request, runtime);
        }

        public PopBatchQueryObjectProjectStatusResponse PopBatchQueryObjectProjectStatusWithOptions(PopBatchQueryObjectProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                body["ProjectIds"] = request.ProjectIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBatchQueryObjectProjectStatus",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBatchQueryObjectProjectStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBatchQueryObjectProjectStatusResponse> PopBatchQueryObjectProjectStatusWithOptionsAsync(PopBatchQueryObjectProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                body["ProjectIds"] = request.ProjectIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBatchQueryObjectProjectStatus",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBatchQueryObjectProjectStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBatchQueryObjectProjectStatusResponse PopBatchQueryObjectProjectStatus(PopBatchQueryObjectProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBatchQueryObjectProjectStatusWithOptions(request, runtime);
        }

        public async Task<PopBatchQueryObjectProjectStatusResponse> PopBatchQueryObjectProjectStatusAsync(PopBatchQueryObjectProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBatchQueryObjectProjectStatusWithOptionsAsync(request, runtime);
        }

        public PopBuildFeatureToAvatarProjectResponse PopBuildFeatureToAvatarProjectWithOptions(PopBuildFeatureToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildFeatureToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildFeatureToAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBuildFeatureToAvatarProjectResponse> PopBuildFeatureToAvatarProjectWithOptionsAsync(PopBuildFeatureToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildFeatureToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildFeatureToAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBuildFeatureToAvatarProjectResponse PopBuildFeatureToAvatarProject(PopBuildFeatureToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBuildFeatureToAvatarProjectWithOptions(request, runtime);
        }

        public async Task<PopBuildFeatureToAvatarProjectResponse> PopBuildFeatureToAvatarProjectAsync(PopBuildFeatureToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBuildFeatureToAvatarProjectWithOptionsAsync(request, runtime);
        }

        public PopBuildLivePortraitModelScopeProjectResponse PopBuildLivePortraitModelScopeProjectWithOptions(PopBuildLivePortraitModelScopeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildLivePortraitModelScopeProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildLivePortraitModelScopeProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBuildLivePortraitModelScopeProjectResponse> PopBuildLivePortraitModelScopeProjectWithOptionsAsync(PopBuildLivePortraitModelScopeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildLivePortraitModelScopeProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildLivePortraitModelScopeProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBuildLivePortraitModelScopeProjectResponse PopBuildLivePortraitModelScopeProject(PopBuildLivePortraitModelScopeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBuildLivePortraitModelScopeProjectWithOptions(request, runtime);
        }

        public async Task<PopBuildLivePortraitModelScopeProjectResponse> PopBuildLivePortraitModelScopeProjectAsync(PopBuildLivePortraitModelScopeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBuildLivePortraitModelScopeProjectWithOptionsAsync(request, runtime);
        }

        public PopBuildObjectGenerationProjectResponse PopBuildObjectGenerationProjectWithOptions(PopBuildObjectGenerationProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildObjectGenerationProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildObjectGenerationProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBuildObjectGenerationProjectResponse> PopBuildObjectGenerationProjectWithOptionsAsync(PopBuildObjectGenerationProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildObjectGenerationProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildObjectGenerationProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBuildObjectGenerationProjectResponse PopBuildObjectGenerationProject(PopBuildObjectGenerationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBuildObjectGenerationProjectWithOptions(request, runtime);
        }

        public async Task<PopBuildObjectGenerationProjectResponse> PopBuildObjectGenerationProjectAsync(PopBuildObjectGenerationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBuildObjectGenerationProjectWithOptionsAsync(request, runtime);
        }

        public PopBuildObjectProjectResponse PopBuildObjectProjectWithOptions(PopBuildObjectProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildObjectProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildObjectProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBuildObjectProjectResponse> PopBuildObjectProjectWithOptionsAsync(PopBuildObjectProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildObjectProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildObjectProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBuildObjectProjectResponse PopBuildObjectProject(PopBuildObjectProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBuildObjectProjectWithOptions(request, runtime);
        }

        public async Task<PopBuildObjectProjectResponse> PopBuildObjectProjectAsync(PopBuildObjectProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBuildObjectProjectWithOptionsAsync(request, runtime);
        }

        public PopBuildPakRenderProjectResponse PopBuildPakRenderProjectWithOptions(PopBuildPakRenderProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildPakRenderProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildPakRenderProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBuildPakRenderProjectResponse> PopBuildPakRenderProjectWithOptionsAsync(PopBuildPakRenderProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildPakRenderProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildPakRenderProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBuildPakRenderProjectResponse PopBuildPakRenderProject(PopBuildPakRenderProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBuildPakRenderProjectWithOptions(request, runtime);
        }

        public async Task<PopBuildPakRenderProjectResponse> PopBuildPakRenderProjectAsync(PopBuildPakRenderProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBuildPakRenderProjectWithOptionsAsync(request, runtime);
        }

        public PopBuildTextToAvatarProjectResponse PopBuildTextToAvatarProjectWithOptions(PopBuildTextToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildTextToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildTextToAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopBuildTextToAvatarProjectResponse> PopBuildTextToAvatarProjectWithOptionsAsync(PopBuildTextToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopBuildTextToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopBuildTextToAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopBuildTextToAvatarProjectResponse PopBuildTextToAvatarProject(PopBuildTextToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopBuildTextToAvatarProjectWithOptions(request, runtime);
        }

        public async Task<PopBuildTextToAvatarProjectResponse> PopBuildTextToAvatarProjectAsync(PopBuildTextToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopBuildTextToAvatarProjectWithOptionsAsync(request, runtime);
        }

        public PopCreateFeatureToAvatarProjectResponse PopCreateFeatureToAvatarProjectWithOptions(PopCreateFeatureToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateFeatureToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateFeatureToAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreateFeatureToAvatarProjectResponse> PopCreateFeatureToAvatarProjectWithOptionsAsync(PopCreateFeatureToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateFeatureToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateFeatureToAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreateFeatureToAvatarProjectResponse PopCreateFeatureToAvatarProject(PopCreateFeatureToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreateFeatureToAvatarProjectWithOptions(request, runtime);
        }

        public async Task<PopCreateFeatureToAvatarProjectResponse> PopCreateFeatureToAvatarProjectAsync(PopCreateFeatureToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreateFeatureToAvatarProjectWithOptionsAsync(request, runtime);
        }

        public PopCreateLivePortraitModelScopeProjectResponse PopCreateLivePortraitModelScopeProjectWithOptions(PopCreateLivePortraitModelScopeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateLivePortraitModelScopeProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateLivePortraitModelScopeProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreateLivePortraitModelScopeProjectResponse> PopCreateLivePortraitModelScopeProjectWithOptionsAsync(PopCreateLivePortraitModelScopeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateLivePortraitModelScopeProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateLivePortraitModelScopeProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreateLivePortraitModelScopeProjectResponse PopCreateLivePortraitModelScopeProject(PopCreateLivePortraitModelScopeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreateLivePortraitModelScopeProjectWithOptions(request, runtime);
        }

        public async Task<PopCreateLivePortraitModelScopeProjectResponse> PopCreateLivePortraitModelScopeProjectAsync(PopCreateLivePortraitModelScopeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreateLivePortraitModelScopeProjectWithOptionsAsync(request, runtime);
        }

        public PopCreateMaterialResponse PopCreateMaterialWithOptions(PopCreateMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStatus))
            {
                body["CheckStatus"] = request.CheckStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["Ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                body["ListStatus"] = request.ListStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateMaterial",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreateMaterialResponse> PopCreateMaterialWithOptionsAsync(PopCreateMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStatus))
            {
                body["CheckStatus"] = request.CheckStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ext))
            {
                body["Ext"] = request.Ext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                body["ListStatus"] = request.ListStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateMaterial",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreateMaterialResponse PopCreateMaterial(PopCreateMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreateMaterialWithOptions(request, runtime);
        }

        public async Task<PopCreateMaterialResponse> PopCreateMaterialAsync(PopCreateMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreateMaterialWithOptionsAsync(request, runtime);
        }

        public PopCreateObjectGenerationProjectResponse PopCreateObjectGenerationProjectWithOptions(PopCreateObjectGenerationProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUsage))
            {
                body["BizUsage"] = request.BizUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateObjectGenerationProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateObjectGenerationProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreateObjectGenerationProjectResponse> PopCreateObjectGenerationProjectWithOptionsAsync(PopCreateObjectGenerationProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUsage))
            {
                body["BizUsage"] = request.BizUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateObjectGenerationProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateObjectGenerationProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreateObjectGenerationProjectResponse PopCreateObjectGenerationProject(PopCreateObjectGenerationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreateObjectGenerationProjectWithOptions(request, runtime);
        }

        public async Task<PopCreateObjectGenerationProjectResponse> PopCreateObjectGenerationProjectAsync(PopCreateObjectGenerationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreateObjectGenerationProjectWithOptionsAsync(request, runtime);
        }

        public PopCreateObjectProjectResponse PopCreateObjectProjectWithOptions(PopCreateObjectProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuild))
            {
                body["AutoBuild"] = request.AutoBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUsage))
            {
                body["BizUsage"] = request.BizUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSource))
            {
                body["CustomSource"] = request.CustomSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dependencies))
            {
                body["Dependencies"] = request.Dependencies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignUid))
            {
                body["ForeignUid"] = request.ForeignUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendStatus))
            {
                body["RecommendStatus"] = request.RecommendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateObjectProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateObjectProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreateObjectProjectResponse> PopCreateObjectProjectWithOptionsAsync(PopCreateObjectProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuild))
            {
                body["AutoBuild"] = request.AutoBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUsage))
            {
                body["BizUsage"] = request.BizUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSource))
            {
                body["CustomSource"] = request.CustomSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dependencies))
            {
                body["Dependencies"] = request.Dependencies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignUid))
            {
                body["ForeignUid"] = request.ForeignUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendStatus))
            {
                body["RecommendStatus"] = request.RecommendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateObjectProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateObjectProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreateObjectProjectResponse PopCreateObjectProject(PopCreateObjectProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreateObjectProjectWithOptions(request, runtime);
        }

        public async Task<PopCreateObjectProjectResponse> PopCreateObjectProjectAsync(PopCreateObjectProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreateObjectProjectWithOptionsAsync(request, runtime);
        }

        public PopCreatePakRenderProjectResponse PopCreatePakRenderProjectWithOptions(PopCreatePakRenderProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreatePakRenderProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreatePakRenderProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreatePakRenderProjectResponse> PopCreatePakRenderProjectWithOptionsAsync(PopCreatePakRenderProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreatePakRenderProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreatePakRenderProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreatePakRenderProjectResponse PopCreatePakRenderProject(PopCreatePakRenderProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreatePakRenderProjectWithOptions(request, runtime);
        }

        public async Task<PopCreatePakRenderProjectResponse> PopCreatePakRenderProjectAsync(PopCreatePakRenderProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreatePakRenderProjectWithOptionsAsync(request, runtime);
        }

        public PopCreateTextToAvatarProjectResponse PopCreateTextToAvatarProjectWithOptions(PopCreateTextToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateTextToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateTextToAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopCreateTextToAvatarProjectResponse> PopCreateTextToAvatarProjectWithOptionsAsync(PopCreateTextToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intro))
            {
                body["Intro"] = request.Intro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateTextToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateTextToAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopCreateTextToAvatarProjectResponse PopCreateTextToAvatarProject(PopCreateTextToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopCreateTextToAvatarProjectWithOptions(request, runtime);
        }

        public async Task<PopCreateTextToAvatarProjectResponse> PopCreateTextToAvatarProjectAsync(PopCreateTextToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopCreateTextToAvatarProjectWithOptionsAsync(request, runtime);
        }

        public PopDeleteMaterialResponse PopDeleteMaterialWithOptions(PopDeleteMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopDeleteMaterial",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopDeleteMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopDeleteMaterialResponse> PopDeleteMaterialWithOptionsAsync(PopDeleteMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopDeleteMaterial",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopDeleteMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopDeleteMaterialResponse PopDeleteMaterial(PopDeleteMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopDeleteMaterialWithOptions(request, runtime);
        }

        public async Task<PopDeleteMaterialResponse> PopDeleteMaterialAsync(PopDeleteMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopDeleteMaterialWithOptionsAsync(request, runtime);
        }

        public PopGetAITryOnJobResponse PopGetAITryOnJobWithOptions(PopGetAITryOnJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithMaterial))
            {
                query["WithMaterial"] = request.WithMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithResult))
            {
                query["WithResult"] = request.WithResult;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopGetAITryOnJob",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopGetAITryOnJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopGetAITryOnJobResponse> PopGetAITryOnJobWithOptionsAsync(PopGetAITryOnJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithMaterial))
            {
                query["WithMaterial"] = request.WithMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithResult))
            {
                query["WithResult"] = request.WithResult;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopGetAITryOnJob",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopGetAITryOnJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopGetAITryOnJobResponse PopGetAITryOnJob(PopGetAITryOnJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopGetAITryOnJobWithOptions(request, runtime);
        }

        public async Task<PopGetAITryOnJobResponse> PopGetAITryOnJobAsync(PopGetAITryOnJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopGetAITryOnJobWithOptionsAsync(request, runtime);
        }

        public PopListAITryOnJobsResponse PopListAITryOnJobsWithOptions(PopListAITryOnJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListAITryOnJobs",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListAITryOnJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListAITryOnJobsResponse> PopListAITryOnJobsWithOptionsAsync(PopListAITryOnJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListAITryOnJobs",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListAITryOnJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListAITryOnJobsResponse PopListAITryOnJobs(PopListAITryOnJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListAITryOnJobsWithOptions(request, runtime);
        }

        public async Task<PopListAITryOnJobsResponse> PopListAITryOnJobsAsync(PopListAITryOnJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListAITryOnJobsWithOptionsAsync(request, runtime);
        }

        public PopListCommonMaterialsAllResponse PopListCommonMaterialsAllWithOptions(PopListCommonMaterialsAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                query["ListStatus"] = request.ListStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListCommonMaterialsAll",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListCommonMaterialsAllResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListCommonMaterialsAllResponse> PopListCommonMaterialsAllWithOptionsAsync(PopListCommonMaterialsAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                query["ListStatus"] = request.ListStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListCommonMaterialsAll",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListCommonMaterialsAllResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListCommonMaterialsAllResponse PopListCommonMaterialsAll(PopListCommonMaterialsAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListCommonMaterialsAllWithOptions(request, runtime);
        }

        public async Task<PopListCommonMaterialsAllResponse> PopListCommonMaterialsAllAsync(PopListCommonMaterialsAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListCommonMaterialsAllWithOptionsAsync(request, runtime);
        }

        public PopListFeatureToAvatarMaterialsResponse PopListFeatureToAvatarMaterialsWithOptions(PopListFeatureToAvatarMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                body["ListStatus"] = request.ListStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListFeatureToAvatarMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListFeatureToAvatarMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListFeatureToAvatarMaterialsResponse> PopListFeatureToAvatarMaterialsWithOptionsAsync(PopListFeatureToAvatarMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                body["ListStatus"] = request.ListStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListFeatureToAvatarMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListFeatureToAvatarMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListFeatureToAvatarMaterialsResponse PopListFeatureToAvatarMaterials(PopListFeatureToAvatarMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListFeatureToAvatarMaterialsWithOptions(request, runtime);
        }

        public async Task<PopListFeatureToAvatarMaterialsResponse> PopListFeatureToAvatarMaterialsAsync(PopListFeatureToAvatarMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListFeatureToAvatarMaterialsWithOptionsAsync(request, runtime);
        }

        public PopListFeatureToAvatarProjectResponse PopListFeatureToAvatarProjectWithOptions(PopListFeatureToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListFeatureToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListFeatureToAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListFeatureToAvatarProjectResponse> PopListFeatureToAvatarProjectWithOptionsAsync(PopListFeatureToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListFeatureToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListFeatureToAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListFeatureToAvatarProjectResponse PopListFeatureToAvatarProject(PopListFeatureToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListFeatureToAvatarProjectWithOptions(request, runtime);
        }

        public async Task<PopListFeatureToAvatarProjectResponse> PopListFeatureToAvatarProjectAsync(PopListFeatureToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListFeatureToAvatarProjectWithOptionsAsync(request, runtime);
        }

        public PopListLivePortraitModelScopeMaterialsResponse PopListLivePortraitModelScopeMaterialsWithOptions(PopListLivePortraitModelScopeMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                body["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListLivePortraitModelScopeMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListLivePortraitModelScopeMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListLivePortraitModelScopeMaterialsResponse> PopListLivePortraitModelScopeMaterialsWithOptionsAsync(PopListLivePortraitModelScopeMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                body["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListLivePortraitModelScopeMaterials",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListLivePortraitModelScopeMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListLivePortraitModelScopeMaterialsResponse PopListLivePortraitModelScopeMaterials(PopListLivePortraitModelScopeMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListLivePortraitModelScopeMaterialsWithOptions(request, runtime);
        }

        public async Task<PopListLivePortraitModelScopeMaterialsResponse> PopListLivePortraitModelScopeMaterialsAsync(PopListLivePortraitModelScopeMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListLivePortraitModelScopeMaterialsWithOptionsAsync(request, runtime);
        }

        public PopListObjectCaseResponse PopListObjectCaseWithOptions(PopListObjectCaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListObjectCase",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListObjectCaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListObjectCaseResponse> PopListObjectCaseWithOptionsAsync(PopListObjectCaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListObjectCase",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListObjectCaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListObjectCaseResponse PopListObjectCase(PopListObjectCaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListObjectCaseWithOptions(request, runtime);
        }

        public async Task<PopListObjectCaseResponse> PopListObjectCaseAsync(PopListObjectCaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListObjectCaseWithOptionsAsync(request, runtime);
        }

        public PopListObjectGenerationProjectResponse PopListObjectGenerationProjectWithOptions(PopListObjectGenerationProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListObjectGenerationProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListObjectGenerationProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListObjectGenerationProjectResponse> PopListObjectGenerationProjectWithOptionsAsync(PopListObjectGenerationProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListObjectGenerationProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListObjectGenerationProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListObjectGenerationProjectResponse PopListObjectGenerationProject(PopListObjectGenerationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListObjectGenerationProjectWithOptions(request, runtime);
        }

        public async Task<PopListObjectGenerationProjectResponse> PopListObjectGenerationProjectAsync(PopListObjectGenerationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListObjectGenerationProjectWithOptionsAsync(request, runtime);
        }

        public PopListObjectProjectResponse PopListObjectProjectWithOptions(PopListObjectProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                body["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSource))
            {
                body["CustomSource"] = request.CustomSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithSource))
            {
                body["WithSource"] = request.WithSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListObjectProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListObjectProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListObjectProjectResponse> PopListObjectProjectWithOptionsAsync(PopListObjectProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                body["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSource))
            {
                body["CustomSource"] = request.CustomSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithSource))
            {
                body["WithSource"] = request.WithSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListObjectProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListObjectProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListObjectProjectResponse PopListObjectProject(PopListObjectProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListObjectProjectWithOptions(request, runtime);
        }

        public async Task<PopListObjectProjectResponse> PopListObjectProjectAsync(PopListObjectProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListObjectProjectWithOptionsAsync(request, runtime);
        }

        public PopListPakRenderExpressionResponse PopListPakRenderExpressionWithOptions(PopListPakRenderExpressionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                query["ListStatus"] = request.ListStatus;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListPakRenderExpression",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListPakRenderExpressionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListPakRenderExpressionResponse> PopListPakRenderExpressionWithOptionsAsync(PopListPakRenderExpressionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListStatus))
            {
                query["ListStatus"] = request.ListStatus;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListPakRenderExpression",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListPakRenderExpressionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListPakRenderExpressionResponse PopListPakRenderExpression(PopListPakRenderExpressionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListPakRenderExpressionWithOptions(request, runtime);
        }

        public async Task<PopListPakRenderExpressionResponse> PopListPakRenderExpressionAsync(PopListPakRenderExpressionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListPakRenderExpressionWithOptionsAsync(request, runtime);
        }

        public PopListTextToAvatarProjectResponse PopListTextToAvatarProjectWithOptions(PopListTextToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListTextToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListTextToAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopListTextToAvatarProjectResponse> PopListTextToAvatarProjectWithOptionsAsync(PopListTextToAvatarProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopListTextToAvatarProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopListTextToAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopListTextToAvatarProjectResponse PopListTextToAvatarProject(PopListTextToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopListTextToAvatarProjectWithOptions(request, runtime);
        }

        public async Task<PopListTextToAvatarProjectResponse> PopListTextToAvatarProjectAsync(PopListTextToAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopListTextToAvatarProjectWithOptionsAsync(request, runtime);
        }

        public PopObjectProjectDetailResponse PopObjectProjectDetailWithOptions(PopObjectProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopObjectProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopObjectProjectDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopObjectProjectDetailResponse> PopObjectProjectDetailWithOptionsAsync(PopObjectProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopObjectProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopObjectProjectDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopObjectProjectDetailResponse PopObjectProjectDetail(PopObjectProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopObjectProjectDetailWithOptions(request, runtime);
        }

        public async Task<PopObjectProjectDetailResponse> PopObjectProjectDetailAsync(PopObjectProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopObjectProjectDetailWithOptionsAsync(request, runtime);
        }

        public PopObjectRetrievalResponse PopObjectRetrievalWithOptions(PopObjectRetrievalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopObjectRetrieval",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopObjectRetrievalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopObjectRetrievalResponse> PopObjectRetrievalWithOptionsAsync(PopObjectRetrievalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopObjectRetrieval",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopObjectRetrievalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopObjectRetrievalResponse PopObjectRetrieval(PopObjectRetrievalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopObjectRetrievalWithOptions(request, runtime);
        }

        public async Task<PopObjectRetrievalResponse> PopObjectRetrievalAsync(PopObjectRetrievalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopObjectRetrievalWithOptionsAsync(request, runtime);
        }

        public PopObjectRetrievalUploadDataResponse PopObjectRetrievalUploadDataWithOptions(PopObjectRetrievalUploadDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopObjectRetrievalUploadData",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopObjectRetrievalUploadDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopObjectRetrievalUploadDataResponse> PopObjectRetrievalUploadDataWithOptionsAsync(PopObjectRetrievalUploadDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopObjectRetrievalUploadData",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopObjectRetrievalUploadDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopObjectRetrievalUploadDataResponse PopObjectRetrievalUploadData(PopObjectRetrievalUploadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopObjectRetrievalUploadDataWithOptions(request, runtime);
        }

        public async Task<PopObjectRetrievalUploadDataResponse> PopObjectRetrievalUploadDataAsync(PopObjectRetrievalUploadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopObjectRetrievalUploadDataWithOptionsAsync(request, runtime);
        }

        public PopQueryAvatarProjectDetailResponse PopQueryAvatarProjectDetailWithOptions(PopQueryAvatarProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryAvatarProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryAvatarProjectDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopQueryAvatarProjectDetailResponse> PopQueryAvatarProjectDetailWithOptionsAsync(PopQueryAvatarProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryAvatarProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryAvatarProjectDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopQueryAvatarProjectDetailResponse PopQueryAvatarProjectDetail(PopQueryAvatarProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopQueryAvatarProjectDetailWithOptions(request, runtime);
        }

        public async Task<PopQueryAvatarProjectDetailResponse> PopQueryAvatarProjectDetailAsync(PopQueryAvatarProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopQueryAvatarProjectDetailWithOptionsAsync(request, runtime);
        }

        public PopQueryLatestAvatarProjectDetailByUserResponse PopQueryLatestAvatarProjectDetailByUserWithOptions(PopQueryLatestAvatarProjectDetailByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryLatestAvatarProjectDetailByUser",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryLatestAvatarProjectDetailByUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopQueryLatestAvatarProjectDetailByUserResponse> PopQueryLatestAvatarProjectDetailByUserWithOptionsAsync(PopQueryLatestAvatarProjectDetailByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryLatestAvatarProjectDetailByUser",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryLatestAvatarProjectDetailByUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopQueryLatestAvatarProjectDetailByUserResponse PopQueryLatestAvatarProjectDetailByUser(PopQueryLatestAvatarProjectDetailByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopQueryLatestAvatarProjectDetailByUserWithOptions(request, runtime);
        }

        public async Task<PopQueryLatestAvatarProjectDetailByUserResponse> PopQueryLatestAvatarProjectDetailByUserAsync(PopQueryLatestAvatarProjectDetailByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopQueryLatestAvatarProjectDetailByUserWithOptionsAsync(request, runtime);
        }

        public PopQueryLivePortraitModelScopeProjectDetailResponse PopQueryLivePortraitModelScopeProjectDetailWithOptions(PopQueryLivePortraitModelScopeProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryLivePortraitModelScopeProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryLivePortraitModelScopeProjectDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopQueryLivePortraitModelScopeProjectDetailResponse> PopQueryLivePortraitModelScopeProjectDetailWithOptionsAsync(PopQueryLivePortraitModelScopeProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryLivePortraitModelScopeProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryLivePortraitModelScopeProjectDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopQueryLivePortraitModelScopeProjectDetailResponse PopQueryLivePortraitModelScopeProjectDetail(PopQueryLivePortraitModelScopeProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopQueryLivePortraitModelScopeProjectDetailWithOptions(request, runtime);
        }

        public async Task<PopQueryLivePortraitModelScopeProjectDetailResponse> PopQueryLivePortraitModelScopeProjectDetailAsync(PopQueryLivePortraitModelScopeProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopQueryLivePortraitModelScopeProjectDetailWithOptionsAsync(request, runtime);
        }

        public PopQueryObjectGenerationProjectDetailResponse PopQueryObjectGenerationProjectDetailWithOptions(PopQueryObjectGenerationProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryObjectGenerationProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryObjectGenerationProjectDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopQueryObjectGenerationProjectDetailResponse> PopQueryObjectGenerationProjectDetailWithOptionsAsync(PopQueryObjectGenerationProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopQueryObjectGenerationProjectDetail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopQueryObjectGenerationProjectDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopQueryObjectGenerationProjectDetailResponse PopQueryObjectGenerationProjectDetail(PopQueryObjectGenerationProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopQueryObjectGenerationProjectDetailWithOptions(request, runtime);
        }

        public async Task<PopQueryObjectGenerationProjectDetailResponse> PopQueryObjectGenerationProjectDetailAsync(PopQueryObjectGenerationProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopQueryObjectGenerationProjectDetailWithOptionsAsync(request, runtime);
        }

        public PopRetryAITryOnTaskResponse PopRetryAITryOnTaskWithOptions(PopRetryAITryOnTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopRetryAITryOnTask",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopRetryAITryOnTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopRetryAITryOnTaskResponse> PopRetryAITryOnTaskWithOptionsAsync(PopRetryAITryOnTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopRetryAITryOnTask",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopRetryAITryOnTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopRetryAITryOnTaskResponse PopRetryAITryOnTask(PopRetryAITryOnTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopRetryAITryOnTaskWithOptions(request, runtime);
        }

        public async Task<PopRetryAITryOnTaskResponse> PopRetryAITryOnTaskAsync(PopRetryAITryOnTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopRetryAITryOnTaskWithOptionsAsync(request, runtime);
        }

        public PopSubmitAITryOnJobResponse PopSubmitAITryOnJobWithOptions(PopSubmitAITryOnJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BottomsId))
            {
                query["BottomsId"] = request.BottomsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClothingType))
            {
                query["ClothingType"] = request.ClothingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShoeType))
            {
                query["ShoeType"] = request.ShoeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuitId))
            {
                query["SuitId"] = request.SuitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopsId))
            {
                query["TopsId"] = request.TopsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopSubmitAITryOnJob",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopSubmitAITryOnJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopSubmitAITryOnJobResponse> PopSubmitAITryOnJobWithOptionsAsync(PopSubmitAITryOnJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BottomsId))
            {
                query["BottomsId"] = request.BottomsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClothingType))
            {
                query["ClothingType"] = request.ClothingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShoeType))
            {
                query["ShoeType"] = request.ShoeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuitId))
            {
                query["SuitId"] = request.SuitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopsId))
            {
                query["TopsId"] = request.TopsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopSubmitAITryOnJob",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopSubmitAITryOnJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopSubmitAITryOnJobResponse PopSubmitAITryOnJob(PopSubmitAITryOnJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopSubmitAITryOnJobWithOptions(request, runtime);
        }

        public async Task<PopSubmitAITryOnJobResponse> PopSubmitAITryOnJobAsync(PopSubmitAITryOnJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopSubmitAITryOnJobWithOptionsAsync(request, runtime);
        }

        public PopUploadMaterialResponse PopUploadMaterialWithOptions(PopUploadMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopUploadMaterial",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopUploadMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopUploadMaterialResponse> PopUploadMaterialWithOptionsAsync(PopUploadMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopUploadMaterial",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopUploadMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopUploadMaterialResponse PopUploadMaterial(PopUploadMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopUploadMaterialWithOptions(request, runtime);
        }

        public async Task<PopUploadMaterialResponse> PopUploadMaterialAsync(PopUploadMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopUploadMaterialWithOptionsAsync(request, runtime);
        }

        public PopVideoSaveSourceResponse PopVideoSaveSourceWithOptions(PopVideoSaveSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopVideoSaveSource",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopVideoSaveSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PopVideoSaveSourceResponse> PopVideoSaveSourceWithOptionsAsync(PopVideoSaveSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopVideoSaveSource",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopVideoSaveSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PopVideoSaveSourceResponse PopVideoSaveSource(PopVideoSaveSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PopVideoSaveSourceWithOptions(request, runtime);
        }

        public async Task<PopVideoSaveSourceResponse> PopVideoSaveSourceAsync(PopVideoSaveSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PopVideoSaveSourceWithOptionsAsync(request, runtime);
        }

        public QueryDigitalHumanProjectResponse QueryDigitalHumanProjectWithOptions(QueryDigitalHumanProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDigitalHumanProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDigitalHumanProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDigitalHumanProjectResponse> QueryDigitalHumanProjectWithOptionsAsync(QueryDigitalHumanProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDigitalHumanProject",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDigitalHumanProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDigitalHumanProjectResponse QueryDigitalHumanProject(QueryDigitalHumanProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDigitalHumanProjectWithOptions(request, runtime);
        }

        public async Task<QueryDigitalHumanProjectResponse> QueryDigitalHumanProjectAsync(QueryDigitalHumanProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDigitalHumanProjectWithOptionsAsync(request, runtime);
        }

        public QueryLongTtsResultResponse QueryLongTtsResultWithOptions(QueryLongTtsResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLongTtsResult",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLongTtsResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLongTtsResultResponse> QueryLongTtsResultWithOptionsAsync(QueryLongTtsResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLongTtsResult",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLongTtsResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLongTtsResultResponse QueryLongTtsResult(QueryLongTtsResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLongTtsResultWithOptions(request, runtime);
        }

        public async Task<QueryLongTtsResultResponse> QueryLongTtsResultAsync(QueryLongTtsResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLongTtsResultWithOptionsAsync(request, runtime);
        }

        public QueryMotionShopVideoDetectResultResponse QueryMotionShopVideoDetectResultWithOptions(QueryMotionShopVideoDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMotionShopVideoDetectResult",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMotionShopVideoDetectResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMotionShopVideoDetectResultResponse> QueryMotionShopVideoDetectResultWithOptionsAsync(QueryMotionShopVideoDetectResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMotionShopVideoDetectResult",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMotionShopVideoDetectResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMotionShopVideoDetectResultResponse QueryMotionShopVideoDetectResult(QueryMotionShopVideoDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMotionShopVideoDetectResultWithOptions(request, runtime);
        }

        public async Task<QueryMotionShopVideoDetectResultResponse> QueryMotionShopVideoDetectResultAsync(QueryMotionShopVideoDetectResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMotionShopVideoDetectResultWithOptionsAsync(request, runtime);
        }

        public SubmitLongTtsTaskResponse SubmitLongTtsTaskWithOptions(SubmitLongTtsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceId))
            {
                body["TtsVoiceId"] = request.TtsVoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLongTtsTask",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLongTtsTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitLongTtsTaskResponse> SubmitLongTtsTaskWithOptionsAsync(SubmitLongTtsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                query["JwtToken"] = request.JwtToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceId))
            {
                body["TtsVoiceId"] = request.TtsVoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLongTtsTask",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLongTtsTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitLongTtsTaskResponse SubmitLongTtsTask(SubmitLongTtsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLongTtsTaskWithOptions(request, runtime);
        }

        public async Task<SubmitLongTtsTaskResponse> SubmitLongTtsTaskAsync(SubmitLongTtsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLongTtsTaskWithOptionsAsync(request, runtime);
        }

        public SubmitMotionShopTaskResponse SubmitMotionShopTaskWithOptions(SubmitMotionShopTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                body["AvatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                body["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMotionShopTask",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMotionShopTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitMotionShopTaskResponse> SubmitMotionShopTaskWithOptionsAsync(SubmitMotionShopTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                body["AvatarId"] = request.AvatarId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                body["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMotionShopTask",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMotionShopTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitMotionShopTaskResponse SubmitMotionShopTask(SubmitMotionShopTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMotionShopTaskWithOptions(request, runtime);
        }

        public async Task<SubmitMotionShopTaskResponse> SubmitMotionShopTaskAsync(SubmitMotionShopTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMotionShopTaskWithOptionsAsync(request, runtime);
        }

        public UpdateUserEmailResponse UpdateUserEmailWithOptions(UpdateUserEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserEmail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserEmailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateUserEmailResponse> UpdateUserEmailWithOptionsAsync(UpdateUserEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JwtToken))
            {
                body["JwtToken"] = request.JwtToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserEmail",
                Version = "2023-03-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateUserEmailResponse UpdateUserEmail(UpdateUserEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserEmailWithOptions(request, runtime);
        }

        public async Task<UpdateUserEmailResponse> UpdateUserEmailAsync(UpdateUserEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserEmailWithOptionsAsync(request, runtime);
        }

    }
}
