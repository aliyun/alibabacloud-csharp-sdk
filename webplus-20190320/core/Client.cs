// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.WebPlus20190320.Models;

namespace AlibabaCloud.SDK.WebPlus20190320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "webplus.cn-hangzhou.aliyuncs.com"},
                {"cn-zhangjiakou", "webplus.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "webplus.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "webplus.cn-hangzhou.aliyuncs.com"},
                {"ap-northeast-1", "webplus.aliyuncs.com"},
                {"ap-south-1", "webplus.aliyuncs.com"},
                {"ap-southeast-1", "webplus.aliyuncs.com"},
                {"ap-southeast-2", "webplus.aliyuncs.com"},
                {"ap-southeast-3", "webplus.aliyuncs.com"},
                {"ap-southeast-5", "webplus.aliyuncs.com"},
                {"cn-chengdu", "webplus.aliyuncs.com"},
                {"cn-hongkong", "webplus-vpc.cn-hongkong.aliyuncs.com"},
                {"cn-huhehaote", "webplus.aliyuncs.com"},
                {"cn-qingdao", "webplus.aliyuncs.com"},
                {"eu-central-1", "webplus.aliyuncs.com"},
                {"eu-west-1", "webplus.aliyuncs.com"},
                {"me-east-1", "webplus.aliyuncs.com"},
                {"us-east-1", "webplus.aliyuncs.com"},
                {"us-west-1", "webplus.aliyuncs.com"},
                {"cn-hangzhou-finance", "webplus.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "webplus.aliyuncs.com"},
                {"cn-shanghai-finance-1", "webplus.aliyuncs.com"},
                {"cn-north-2-gov-1", "webplus.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("webplus", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AbortChangeResponse AbortChange(AbortChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortChangeWithOptions(request, headers, runtime);
        }

        public async Task<AbortChangeResponse> AbortChangeAsync(AbortChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortChangeWithOptionsAsync(request, headers, runtime);
        }

        public AbortChangeResponse AbortChangeWithOptions(AbortChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                body["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AbortChangeResponse>(DoROARequestWithForm("AbortChange", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/change/abort", "json", req, runtime));
        }

        public async Task<AbortChangeResponse> AbortChangeWithOptionsAsync(AbortChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                body["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AbortChangeResponse>(await DoROARequestWithFormAsync("AbortChange", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/change/abort", "json", req, runtime));
        }

        public CreateAppEnvResponse CreateAppEnv(CreateAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<CreateAppEnvResponse> CreateAppEnvAsync(CreateAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public CreateAppEnvResponse CreateAppEnvWithOptions(CreateAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvName))
            {
                body["EnvName"] = request.EnvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvDescription))
            {
                body["EnvDescription"] = request.EnvDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                body["ProfileName"] = request.ProfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEnvId))
            {
                body["SourceEnvId"] = request.SourceEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraProperties))
            {
                body["ExtraProperties"] = request.ExtraProperties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateAppEnvResponse>(DoROARequestWithForm("CreateAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public async Task<CreateAppEnvResponse> CreateAppEnvWithOptionsAsync(CreateAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvName))
            {
                body["EnvName"] = request.EnvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvDescription))
            {
                body["EnvDescription"] = request.EnvDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                body["ProfileName"] = request.ProfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEnvId))
            {
                body["SourceEnvId"] = request.SourceEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraProperties))
            {
                body["ExtraProperties"] = request.ExtraProperties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateAppEnvResponse>(await DoROARequestWithFormAsync("CreateAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationWithOptions(request, headers, runtime);
        }

        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationWithOptionsAsync(request, headers, runtime);
        }

        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                body["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsingSharedStorage))
            {
                body["UsingSharedStorage"] = request.UsingSharedStorage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateApplicationResponse>(DoROARequestWithForm("CreateApplication", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                body["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsingSharedStorage))
            {
                body["UsingSharedStorage"] = request.UsingSharedStorage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await DoROARequestWithFormAsync("CreateApplication", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public CreateConfigTemplateResponse CreateConfigTemplate(CreateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigTemplateWithOptions(request, headers, runtime);
        }

        public async Task<CreateConfigTemplateResponse> CreateConfigTemplateAsync(CreateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigTemplateWithOptionsAsync(request, headers, runtime);
        }

        public CreateConfigTemplateResponse CreateConfigTemplateWithOptions(CreateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDescription))
            {
                body["TemplateDescription"] = request.TemplateDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTemplateId))
            {
                body["SourceTemplateId"] = request.SourceTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEnvId))
            {
                body["SourceEnvId"] = request.SourceEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                body["ProfileName"] = request.ProfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateConfigTemplateResponse>(DoROARequestWithForm("CreateConfigTemplate", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public async Task<CreateConfigTemplateResponse> CreateConfigTemplateWithOptionsAsync(CreateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDescription))
            {
                body["TemplateDescription"] = request.TemplateDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTemplateId))
            {
                body["SourceTemplateId"] = request.SourceTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEnvId))
            {
                body["SourceEnvId"] = request.SourceEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                body["ProfileName"] = request.ProfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateConfigTemplateResponse>(await DoROARequestWithFormAsync("CreateConfigTemplate", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOrderWithOptions(request, headers, runtime);
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOrderWithOptionsAsync(request, headers, runtime);
        }

        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateOrderResponse>(DoROARequestWithForm("CreateOrder", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/paas/createOrder", "json", req, runtime));
        }

        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateOrderResponse>(await DoROARequestWithFormAsync("CreateOrder", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/paas/createOrder", "json", req, runtime));
        }

        public CreatePkgVersionResponse CreatePkgVersion(CreatePkgVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePkgVersionWithOptions(request, headers, runtime);
        }

        public async Task<CreatePkgVersionResponse> CreatePkgVersionAsync(CreatePkgVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePkgVersionWithOptionsAsync(request, headers, runtime);
        }

        public CreatePkgVersionResponse CreatePkgVersionWithOptions(CreatePkgVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionLabel))
            {
                body["PkgVersionLabel"] = request.PkgVersionLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionDescription))
            {
                body["PkgVersionDescription"] = request.PkgVersionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageSource))
            {
                body["PackageSource"] = request.PackageSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreatePkgVersionResponse>(DoROARequestWithForm("CreatePkgVersion", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/pkgVersion", "json", req, runtime));
        }

        public async Task<CreatePkgVersionResponse> CreatePkgVersionWithOptionsAsync(CreatePkgVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionLabel))
            {
                body["PkgVersionLabel"] = request.PkgVersionLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionDescription))
            {
                body["PkgVersionDescription"] = request.PkgVersionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageSource))
            {
                body["PackageSource"] = request.PackageSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreatePkgVersionResponse>(await DoROARequestWithFormAsync("CreatePkgVersion", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/pkgVersion", "json", req, runtime));
        }

        public CreateStorageResponse CreateStorage()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateStorageWithOptions(headers, runtime);
        }

        public async Task<CreateStorageResponse> CreateStorageAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateStorageWithOptionsAsync(headers, runtime);
        }

        public CreateStorageResponse CreateStorageWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateStorageResponse>(DoROARequest("CreateStorage", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/storage", "json", req, runtime));
        }

        public async Task<CreateStorageResponse> CreateStorageWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateStorageResponse>(await DoROARequestAsync("CreateStorage", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/storage", "json", req, runtime));
        }

        public DeleteAppEnvResponse DeleteAppEnv(DeleteAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<DeleteAppEnvResponse> DeleteAppEnvAsync(DeleteAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public DeleteAppEnvResponse DeleteAppEnvWithOptions(DeleteAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppEnvResponse>(DoROARequest("DeleteAppEnv", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public async Task<DeleteAppEnvResponse> DeleteAppEnvWithOptionsAsync(DeleteAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppEnvResponse>(await DoROARequestAsync("DeleteAppEnv", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(DoROARequest("DeleteApplication", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await DoROARequestAsync("DeleteApplication", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public DeleteChangeResponse DeleteChange(DeleteChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteChangeWithOptions(request, headers, runtime);
        }

        public async Task<DeleteChangeResponse> DeleteChangeAsync(DeleteChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteChangeWithOptionsAsync(request, headers, runtime);
        }

        public DeleteChangeResponse DeleteChangeWithOptions(DeleteChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteChangeResponse>(DoROARequest("DeleteChange", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/change", "json", req, runtime));
        }

        public async Task<DeleteChangeResponse> DeleteChangeWithOptionsAsync(DeleteChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteChangeResponse>(await DoROARequestAsync("DeleteChange", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/change", "json", req, runtime));
        }

        public DeleteConfigTemplateResponse DeleteConfigTemplate(DeleteConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigTemplateWithOptions(request, headers, runtime);
        }

        public async Task<DeleteConfigTemplateResponse> DeleteConfigTemplateAsync(DeleteConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigTemplateWithOptionsAsync(request, headers, runtime);
        }

        public DeleteConfigTemplateResponse DeleteConfigTemplateWithOptions(DeleteConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteConfigTemplateResponse>(DoROARequest("DeleteConfigTemplate", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public async Task<DeleteConfigTemplateResponse> DeleteConfigTemplateWithOptionsAsync(DeleteConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteConfigTemplateResponse>(await DoROARequestAsync("DeleteConfigTemplate", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public DeletePkgVersionResponse DeletePkgVersion(DeletePkgVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePkgVersionWithOptions(request, headers, runtime);
        }

        public async Task<DeletePkgVersionResponse> DeletePkgVersionAsync(DeletePkgVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePkgVersionWithOptionsAsync(request, headers, runtime);
        }

        public DeletePkgVersionResponse DeletePkgVersionWithOptions(DeletePkgVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                query["PkgVersionId"] = request.PkgVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeletePkgVersionResponse>(DoROARequest("DeletePkgVersion", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/pkgVersion", "json", req, runtime));
        }

        public async Task<DeletePkgVersionResponse> DeletePkgVersionWithOptionsAsync(DeletePkgVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                query["PkgVersionId"] = request.PkgVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeletePkgVersionResponse>(await DoROARequestAsync("DeletePkgVersion", "2019-03-20", "HTTPS", "DELETE", "AK", "/pop/v1/wam/pkgVersion", "json", req, runtime));
        }

        public DeployAppEnvResponse DeployAppEnv(DeployAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<DeployAppEnvResponse> DeployAppEnvAsync(DeployAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public DeployAppEnvResponse DeployAppEnvWithOptions(DeployAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                body["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchPercent))
            {
                body["BatchPercent"] = request.BatchPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInterval))
            {
                body["BatchInterval"] = request.BatchInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseBetweenBatches))
            {
                body["PauseBetweenBatches"] = request.PauseBetweenBatches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeployAppEnvResponse>(DoROARequestWithForm("DeployAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/deploy", "json", req, runtime));
        }

        public async Task<DeployAppEnvResponse> DeployAppEnvWithOptionsAsync(DeployAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                body["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchPercent))
            {
                body["BatchPercent"] = request.BatchPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInterval))
            {
                body["BatchInterval"] = request.BatchInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseBetweenBatches))
            {
                body["PauseBetweenBatches"] = request.PauseBetweenBatches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DeployAppEnvResponse>(await DoROARequestWithFormAsync("DeployAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/deploy", "json", req, runtime));
        }

        public DescribeAppEnvInstanceHealthResponse DescribeAppEnvInstanceHealth(DescribeAppEnvInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppEnvInstanceHealthWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppEnvInstanceHealthResponse> DescribeAppEnvInstanceHealthAsync(DescribeAppEnvInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppEnvInstanceHealthWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppEnvInstanceHealthResponse DescribeAppEnvInstanceHealthWithOptions(DescribeAppEnvInstanceHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppEnvInstanceHealthResponse>(DoROARequest("DescribeAppEnvInstanceHealth", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/instanceHealth", "json", req, runtime));
        }

        public async Task<DescribeAppEnvInstanceHealthResponse> DescribeAppEnvInstanceHealthWithOptionsAsync(DescribeAppEnvInstanceHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppEnvInstanceHealthResponse>(await DoROARequestAsync("DescribeAppEnvInstanceHealth", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/instanceHealth", "json", req, runtime));
        }

        public DescribeAppEnvsResponse DescribeAppEnvs(DescribeAppEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppEnvsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppEnvsResponse> DescribeAppEnvsAsync(DescribeAppEnvsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppEnvsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppEnvsResponse DescribeAppEnvsWithOptions(DescribeAppEnvsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTerminated))
            {
                query["IncludeTerminated"] = request.IncludeTerminated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvName))
            {
                query["EnvName"] = request.EnvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvSearch))
            {
                query["EnvSearch"] = request.EnvSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentUpdated))
            {
                query["RecentUpdated"] = request.RecentUpdated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackSearch))
            {
                query["StackSearch"] = request.StackSearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppEnvsResponse>(DoROARequest("DescribeAppEnvs", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public async Task<DescribeAppEnvsResponse> DescribeAppEnvsWithOptionsAsync(DescribeAppEnvsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTerminated))
            {
                query["IncludeTerminated"] = request.IncludeTerminated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvName))
            {
                query["EnvName"] = request.EnvName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvSearch))
            {
                query["EnvSearch"] = request.EnvSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentUpdated))
            {
                query["RecentUpdated"] = request.RecentUpdated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackSearch))
            {
                query["StackSearch"] = request.StackSearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppEnvsResponse>(await DoROARequestAsync("DescribeAppEnvs", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public DescribeAppEnvStatusResponse DescribeAppEnvStatus(DescribeAppEnvStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppEnvStatusWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppEnvStatusResponse> DescribeAppEnvStatusAsync(DescribeAppEnvStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppEnvStatusWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppEnvStatusResponse DescribeAppEnvStatusWithOptions(DescribeAppEnvStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppEnvStatusResponse>(DoROARequest("DescribeAppEnvStatus", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/status", "json", req, runtime));
        }

        public async Task<DescribeAppEnvStatusResponse> DescribeAppEnvStatusWithOptionsAsync(DescribeAppEnvStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppEnvStatusResponse>(await DoROARequestAsync("DescribeAppEnvStatus", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/status", "json", req, runtime));
        }

        public DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationsResponse DescribeApplicationsWithOptions(DescribeApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSearch))
            {
                query["AppSearch"] = request.AppSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvSearch))
            {
                query["EnvSearch"] = request.EnvSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackSearch))
            {
                query["StackSearch"] = request.StackSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategorySearch))
            {
                query["CategorySearch"] = request.CategorySearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeApplicationsResponse>(DoROARequest("DescribeApplications", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public async Task<DescribeApplicationsResponse> DescribeApplicationsWithOptionsAsync(DescribeApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSearch))
            {
                query["AppSearch"] = request.AppSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvSearch))
            {
                query["EnvSearch"] = request.EnvSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackSearch))
            {
                query["StackSearch"] = request.StackSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategorySearch))
            {
                query["CategorySearch"] = request.CategorySearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeApplicationsResponse>(await DoROARequestAsync("DescribeApplications", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public DescribeCategoriesResponse DescribeCategories()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCategoriesWithOptions(headers, runtime);
        }

        public async Task<DescribeCategoriesResponse> DescribeCategoriesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCategoriesWithOptionsAsync(headers, runtime);
        }

        public DescribeCategoriesResponse DescribeCategoriesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeCategoriesResponse>(DoROARequest("DescribeCategories", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/category", "json", req, runtime));
        }

        public async Task<DescribeCategoriesResponse> DescribeCategoriesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeCategoriesResponse>(await DoROARequestAsync("DescribeCategories", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/category", "json", req, runtime));
        }

        public DescribeChangeResponse DescribeChange(DescribeChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChangeWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChangeResponse> DescribeChangeAsync(DescribeChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChangeWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChangeResponse DescribeChangeWithOptions(DescribeChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChangeResponse>(DoROARequest("DescribeChange", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/changeInfo", "json", req, runtime));
        }

        public async Task<DescribeChangeResponse> DescribeChangeWithOptionsAsync(DescribeChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChangeResponse>(await DoROARequestAsync("DescribeChange", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/changeInfo", "json", req, runtime));
        }

        public DescribeChangesResponse DescribeChanges(DescribeChangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChangesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChangesResponse> DescribeChangesAsync(DescribeChangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChangesWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChangesResponse DescribeChangesWithOptions(DescribeChangesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionName))
            {
                query["ActionName"] = request.ActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChangesResponse>(DoROARequest("DescribeChanges", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/change", "json", req, runtime));
        }

        public async Task<DescribeChangesResponse> DescribeChangesWithOptionsAsync(DescribeChangesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionName))
            {
                query["ActionName"] = request.ActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChangesResponse>(await DoROARequestAsync("DescribeChanges", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/change", "json", req, runtime));
        }

        public DescribeConfigIndexResponse DescribeConfigIndex(DescribeConfigIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigIndexWithOptions(request, headers, runtime);
        }

        public async Task<DescribeConfigIndexResponse> DescribeConfigIndexAsync(DescribeConfigIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigIndexWithOptionsAsync(request, headers, runtime);
        }

        public DescribeConfigIndexResponse DescribeConfigIndexWithOptions(DescribeConfigIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                query["ProfileName"] = request.ProfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigIndexResponse>(DoROARequest("DescribeConfigIndex", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/config/configIndex", "json", req, runtime));
        }

        public async Task<DescribeConfigIndexResponse> DescribeConfigIndexWithOptionsAsync(DescribeConfigIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                query["ProfileName"] = request.ProfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigIndexResponse>(await DoROARequestAsync("DescribeConfigIndex", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/config/configIndex", "json", req, runtime));
        }

        public DescribeConfigOptionsResponse DescribeConfigOptions(DescribeConfigOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigOptionsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeConfigOptionsResponse> DescribeConfigOptionsAsync(DescribeConfigOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigOptionsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeConfigOptionsResponse DescribeConfigOptionsWithOptions(DescribeConfigOptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                query["ProfileName"] = request.ProfileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigOptionsResponse>(DoROARequest("DescribeConfigOptions", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/config/configOption", "json", req, runtime));
        }

        public async Task<DescribeConfigOptionsResponse> DescribeConfigOptionsWithOptionsAsync(DescribeConfigOptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileName))
            {
                query["ProfileName"] = request.ProfileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigOptionsResponse>(await DoROARequestAsync("DescribeConfigOptions", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/config/configOption", "json", req, runtime));
        }

        public DescribeConfigSettingsResponse DescribeConfigSettings(DescribeConfigSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigSettingsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeConfigSettingsResponse> DescribeConfigSettingsAsync(DescribeConfigSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigSettingsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeConfigSettingsResponse DescribeConfigSettingsWithOptions(DescribeConfigSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathName))
            {
                query["PathName"] = request.PathName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionName))
            {
                query["OptionName"] = request.OptionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigSettingsResponse>(DoROARequest("DescribeConfigSettings", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/config/configSetting", "json", req, runtime));
        }

        public async Task<DescribeConfigSettingsResponse> DescribeConfigSettingsWithOptionsAsync(DescribeConfigSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathName))
            {
                query["PathName"] = request.PathName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionName))
            {
                query["OptionName"] = request.OptionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigSettingsResponse>(await DoROARequestAsync("DescribeConfigSettings", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/config/configSetting", "json", req, runtime));
        }

        public DescribeConfigTemplatesResponse DescribeConfigTemplates(DescribeConfigTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigTemplatesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeConfigTemplatesResponse> DescribeConfigTemplatesAsync(DescribeConfigTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigTemplatesWithOptionsAsync(request, headers, runtime);
        }

        public DescribeConfigTemplatesResponse DescribeConfigTemplatesWithOptions(DescribeConfigTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSearch))
            {
                query["TemplateSearch"] = request.TemplateSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigTemplatesResponse>(DoROARequest("DescribeConfigTemplates", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public async Task<DescribeConfigTemplatesResponse> DescribeConfigTemplatesWithOptionsAsync(DescribeConfigTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSearch))
            {
                query["TemplateSearch"] = request.TemplateSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConfigTemplatesResponse>(await DoROARequestAsync("DescribeConfigTemplates", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public DescribeEnvResourceResponse DescribeEnvResource(DescribeEnvResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEnvResourceWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEnvResourceResponse> DescribeEnvResourceAsync(DescribeEnvResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEnvResourceWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEnvResourceResponse DescribeEnvResourceWithOptions(DescribeEnvResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEnvResourceResponse>(DoROARequest("DescribeEnvResource", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/envResource", "json", req, runtime));
        }

        public async Task<DescribeEnvResourceResponse> DescribeEnvResourceWithOptionsAsync(DescribeEnvResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEnvResourceResponse>(await DoROARequestAsync("DescribeEnvResource", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/envResource", "json", req, runtime));
        }

        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEventsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEventsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastChangeEvents))
            {
                query["LastChangeEvents"] = request.LastChangeEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseByTimestamp))
            {
                query["ReverseByTimestamp"] = request.ReverseByTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEventsResponse>(DoROARequest("DescribeEvents", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/event", "json", req, runtime));
        }

        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastChangeEvents))
            {
                query["LastChangeEvents"] = request.LastChangeEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseByTimestamp))
            {
                query["ReverseByTimestamp"] = request.ReverseByTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await DoROARequestAsync("DescribeEvents", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/event", "json", req, runtime));
        }

        public DescribeGatherLogResultResponse DescribeGatherLogResult(DescribeGatherLogResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGatherLogResultWithOptions(request, headers, runtime);
        }

        public async Task<DescribeGatherLogResultResponse> DescribeGatherLogResultAsync(DescribeGatherLogResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGatherLogResultWithOptionsAsync(request, headers, runtime);
        }

        public DescribeGatherLogResultResponse DescribeGatherLogResultWithOptions(DescribeGatherLogResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeGatherLogResultResponse>(DoROARequest("DescribeGatherLogResult", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/gatherLog", "json", req, runtime));
        }

        public async Task<DescribeGatherLogResultResponse> DescribeGatherLogResultWithOptionsAsync(DescribeGatherLogResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeGatherLogResultResponse>(await DoROARequestAsync("DescribeGatherLogResult", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/gatherLog", "json", req, runtime));
        }

        public DescribeGatherStatsResultResponse DescribeGatherStatsResult(DescribeGatherStatsResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGatherStatsResultWithOptions(request, headers, runtime);
        }

        public async Task<DescribeGatherStatsResultResponse> DescribeGatherStatsResultAsync(DescribeGatherStatsResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGatherStatsResultWithOptionsAsync(request, headers, runtime);
        }

        public DescribeGatherStatsResultResponse DescribeGatherStatsResultWithOptions(DescribeGatherStatsResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeGatherStatsResultResponse>(DoROARequest("DescribeGatherStatsResult", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/gatherStats", "json", req, runtime));
        }

        public async Task<DescribeGatherStatsResultResponse> DescribeGatherStatsResultWithOptionsAsync(DescribeGatherStatsResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                query["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeGatherStatsResultResponse>(await DoROARequestAsync("DescribeGatherStatsResult", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/appEnv/gatherStats", "json", req, runtime));
        }

        public DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceHealthWithOptions(request, headers, runtime);
        }

        public async Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceHealthWithOptionsAsync(request, headers, runtime);
        }

        public DescribeInstanceHealthResponse DescribeInstanceHealthWithOptions(DescribeInstanceHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeInstanceHealthResponse>(DoROARequest("DescribeInstanceHealth", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/instance/health", "json", req, runtime));
        }

        public async Task<DescribeInstanceHealthResponse> DescribeInstanceHealthWithOptionsAsync(DescribeInstanceHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeInstanceHealthResponse>(await DoROARequestAsync("DescribeInstanceHealth", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/instance/health", "json", req, runtime));
        }

        public DescribePkgVersionsResponse DescribePkgVersions(DescribePkgVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePkgVersionsWithOptions(request, headers, runtime);
        }

        public async Task<DescribePkgVersionsResponse> DescribePkgVersionsAsync(DescribePkgVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePkgVersionsWithOptionsAsync(request, headers, runtime);
        }

        public DescribePkgVersionsResponse DescribePkgVersionsWithOptions(DescribePkgVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionLabel))
            {
                query["PkgVersionLabel"] = request.PkgVersionLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionSearch))
            {
                query["PkgVersionSearch"] = request.PkgVersionSearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePkgVersionsResponse>(DoROARequest("DescribePkgVersions", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/pkgVersion", "json", req, runtime));
        }

        public async Task<DescribePkgVersionsResponse> DescribePkgVersionsWithOptionsAsync(DescribePkgVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionLabel))
            {
                query["PkgVersionLabel"] = request.PkgVersionLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionSearch))
            {
                query["PkgVersionSearch"] = request.PkgVersionSearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePkgVersionsResponse>(await DoROARequestAsync("DescribePkgVersions", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/pkgVersion", "json", req, runtime));
        }

        public DescribePublicConfigTemplatesResponse DescribePublicConfigTemplates(DescribePublicConfigTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePublicConfigTemplatesWithOptions(request, headers, runtime);
        }

        public async Task<DescribePublicConfigTemplatesResponse> DescribePublicConfigTemplatesAsync(DescribePublicConfigTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePublicConfigTemplatesWithOptionsAsync(request, headers, runtime);
        }

        public DescribePublicConfigTemplatesResponse DescribePublicConfigTemplatesWithOptions(DescribePublicConfigTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePublicConfigTemplatesResponse>(DoROARequest("DescribePublicConfigTemplates", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/publicConfigTemplate", "json", req, runtime));
        }

        public async Task<DescribePublicConfigTemplatesResponse> DescribePublicConfigTemplatesWithOptionsAsync(DescribePublicConfigTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePublicConfigTemplatesResponse>(await DoROARequestAsync("DescribePublicConfigTemplates", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/publicConfigTemplate", "json", req, runtime));
        }

        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeStacksWithOptions(request, headers, runtime);
        }

        public async Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeStacksWithOptionsAsync(request, headers, runtime);
        }

        public DescribeStacksResponse DescribeStacksWithOptions(DescribeStacksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendedOnly))
            {
                query["RecommendedOnly"] = request.RecommendedOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeStacksResponse>(DoROARequest("DescribeStacks", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/stack", "json", req, runtime));
        }

        public async Task<DescribeStacksResponse> DescribeStacksWithOptionsAsync(DescribeStacksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendedOnly))
            {
                query["RecommendedOnly"] = request.RecommendedOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeStacksResponse>(await DoROARequestAsync("DescribeStacks", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/stack", "json", req, runtime));
        }

        public DescribeStorageResponse DescribeStorage(DescribeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeStorageWithOptions(request, headers, runtime);
        }

        public async Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeStorageWithOptionsAsync(request, headers, runtime);
        }

        public DescribeStorageResponse DescribeStorageWithOptions(DescribeStorageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsingSharedStorage))
            {
                query["UsingSharedStorage"] = request.UsingSharedStorage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeStorageResponse>(DoROARequest("DescribeStorage", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/storage", "json", req, runtime));
        }

        public async Task<DescribeStorageResponse> DescribeStorageWithOptionsAsync(DescribeStorageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsingSharedStorage))
            {
                query["UsingSharedStorage"] = request.UsingSharedStorage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeStorageResponse>(await DoROARequestAsync("DescribeStorage", "2019-03-20", "HTTPS", "GET", "AK", "/pop/v1/wam/storage", "json", req, runtime));
        }

        public GatherAppEnvLogResponse GatherAppEnvLog(GatherAppEnvLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GatherAppEnvLogWithOptions(request, headers, runtime);
        }

        public async Task<GatherAppEnvLogResponse> GatherAppEnvLogAsync(GatherAppEnvLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GatherAppEnvLogWithOptionsAsync(request, headers, runtime);
        }

        public GatherAppEnvLogResponse GatherAppEnvLogWithOptions(GatherAppEnvLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstances))
            {
                body["TargetInstances"] = request.TargetInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogPath))
            {
                body["LogPath"] = request.LogPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GatherAppEnvLogResponse>(DoROARequestWithForm("GatherAppEnvLog", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/gatherLog", "json", req, runtime));
        }

        public async Task<GatherAppEnvLogResponse> GatherAppEnvLogWithOptionsAsync(GatherAppEnvLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstances))
            {
                body["TargetInstances"] = request.TargetInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogPath))
            {
                body["LogPath"] = request.LogPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GatherAppEnvLogResponse>(await DoROARequestWithFormAsync("GatherAppEnvLog", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/gatherLog", "json", req, runtime));
        }

        public GatherAppEnvStatsResponse GatherAppEnvStats(GatherAppEnvStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GatherAppEnvStatsWithOptions(request, headers, runtime);
        }

        public async Task<GatherAppEnvStatsResponse> GatherAppEnvStatsAsync(GatherAppEnvStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GatherAppEnvStatsWithOptionsAsync(request, headers, runtime);
        }

        public GatherAppEnvStatsResponse GatherAppEnvStatsWithOptions(GatherAppEnvStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstances))
            {
                body["TargetInstances"] = request.TargetInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GatherAppEnvStatsResponse>(DoROARequestWithForm("GatherAppEnvStats", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/gatherStats", "json", req, runtime));
        }

        public async Task<GatherAppEnvStatsResponse> GatherAppEnvStatsWithOptionsAsync(GatherAppEnvStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstances))
            {
                body["TargetInstances"] = request.TargetInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GatherAppEnvStatsResponse>(await DoROARequestWithFormAsync("GatherAppEnvStats", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/gatherStats", "json", req, runtime));
        }

        public PauseChangeResponse PauseChange(PauseChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseChangeWithOptions(request, headers, runtime);
        }

        public async Task<PauseChangeResponse> PauseChangeAsync(PauseChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseChangeWithOptionsAsync(request, headers, runtime);
        }

        public PauseChangeResponse PauseChangeWithOptions(PauseChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                body["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PauseChangeResponse>(DoROARequestWithForm("PauseChange", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/change/pause", "json", req, runtime));
        }

        public async Task<PauseChangeResponse> PauseChangeWithOptionsAsync(PauseChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                body["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PauseChangeResponse>(await DoROARequestWithFormAsync("PauseChange", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/change/pause", "json", req, runtime));
        }

        public RebuildAppEnvResponse RebuildAppEnv(RebuildAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RebuildAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<RebuildAppEnvResponse> RebuildAppEnvAsync(RebuildAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RebuildAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public RebuildAppEnvResponse RebuildAppEnvWithOptions(RebuildAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RebuildAppEnvResponse>(DoROARequestWithForm("RebuildAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/rebuild", "json", req, runtime));
        }

        public async Task<RebuildAppEnvResponse> RebuildAppEnvWithOptionsAsync(RebuildAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RebuildAppEnvResponse>(await DoROARequestWithFormAsync("RebuildAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/rebuild", "json", req, runtime));
        }

        public RestartAppEnvResponse RestartAppEnv(RestartAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<RestartAppEnvResponse> RestartAppEnvAsync(RestartAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public RestartAppEnvResponse RestartAppEnvWithOptions(RestartAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                body["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchPercent))
            {
                body["BatchPercent"] = request.BatchPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInterval))
            {
                body["BatchInterval"] = request.BatchInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseBetweenBatches))
            {
                body["PauseBetweenBatches"] = request.PauseBetweenBatches;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RestartAppEnvResponse>(DoROARequestWithForm("RestartAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/restart", "json", req, runtime));
        }

        public async Task<RestartAppEnvResponse> RestartAppEnvWithOptionsAsync(RestartAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                body["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchPercent))
            {
                body["BatchPercent"] = request.BatchPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInterval))
            {
                body["BatchInterval"] = request.BatchInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseBetweenBatches))
            {
                body["PauseBetweenBatches"] = request.PauseBetweenBatches;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RestartAppEnvResponse>(await DoROARequestWithFormAsync("RestartAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/restart", "json", req, runtime));
        }

        public ResumeChangeResponse ResumeChange(ResumeChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeChangeWithOptions(request, headers, runtime);
        }

        public async Task<ResumeChangeResponse> ResumeChangeAsync(ResumeChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeChangeWithOptionsAsync(request, headers, runtime);
        }

        public ResumeChangeResponse ResumeChangeWithOptions(ResumeChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                body["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ResumeChangeResponse>(DoROARequestWithForm("ResumeChange", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/change/resume", "json", req, runtime));
        }

        public async Task<ResumeChangeResponse> ResumeChangeWithOptionsAsync(ResumeChangeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeId))
            {
                body["ChangeId"] = request.ChangeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ResumeChangeResponse>(await DoROARequestWithFormAsync("ResumeChange", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/change/resume", "json", req, runtime));
        }

        public StartAppEnvResponse StartAppEnv(StartAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<StartAppEnvResponse> StartAppEnvAsync(StartAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public StartAppEnvResponse StartAppEnvWithOptions(StartAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StartAppEnvResponse>(DoROARequestWithForm("StartAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/start", "json", req, runtime));
        }

        public async Task<StartAppEnvResponse> StartAppEnvWithOptionsAsync(StartAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StartAppEnvResponse>(await DoROARequestWithFormAsync("StartAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/start", "json", req, runtime));
        }

        public StopAppEnvResponse StopAppEnv(StopAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<StopAppEnvResponse> StopAppEnvAsync(StopAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public StopAppEnvResponse StopAppEnvWithOptions(StopAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopAppEnvResponse>(DoROARequestWithForm("StopAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/stop", "json", req, runtime));
        }

        public async Task<StopAppEnvResponse> StopAppEnvWithOptionsAsync(StopAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<StopAppEnvResponse>(await DoROARequestWithFormAsync("StopAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/stop", "json", req, runtime));
        }

        public TerminateAppEnvResponse TerminateAppEnv(TerminateAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TerminateAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<TerminateAppEnvResponse> TerminateAppEnvAsync(TerminateAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TerminateAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public TerminateAppEnvResponse TerminateAppEnvWithOptions(TerminateAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<TerminateAppEnvResponse>(DoROARequestWithForm("TerminateAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/terminate", "json", req, runtime));
        }

        public async Task<TerminateAppEnvResponse> TerminateAppEnvWithOptionsAsync(TerminateAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<TerminateAppEnvResponse>(await DoROARequestWithFormAsync("TerminateAppEnv", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/appEnv/terminate", "json", req, runtime));
        }

        public UpdateAppEnvResponse UpdateAppEnv(UpdateAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppEnvWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAppEnvResponse> UpdateAppEnvAsync(UpdateAppEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppEnvWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAppEnvResponse UpdateAppEnvWithOptions(UpdateAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvDescription))
            {
                body["EnvDescription"] = request.EnvDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraProperties))
            {
                body["ExtraProperties"] = request.ExtraProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                body["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchPercent))
            {
                body["BatchPercent"] = request.BatchPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInterval))
            {
                body["BatchInterval"] = request.BatchInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseBetweenBatches))
            {
                body["PauseBetweenBatches"] = request.PauseBetweenBatches;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateAppEnvResponse>(DoROARequestWithForm("UpdateAppEnv", "2019-03-20", "HTTPS", "PUT", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public async Task<UpdateAppEnvResponse> UpdateAppEnvWithOptionsAsync(UpdateAppEnvRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvDescription))
            {
                body["EnvDescription"] = request.EnvDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkgVersionId))
            {
                body["PkgVersionId"] = request.PkgVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraProperties))
            {
                body["ExtraProperties"] = request.ExtraProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                body["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchPercent))
            {
                body["BatchPercent"] = request.BatchPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInterval))
            {
                body["BatchInterval"] = request.BatchInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseBetweenBatches))
            {
                body["PauseBetweenBatches"] = request.PauseBetweenBatches;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateAppEnvResponse>(await DoROARequestWithFormAsync("UpdateAppEnv", "2019-03-20", "HTTPS", "PUT", "AK", "/pop/v1/wam/appEnv", "json", req, runtime));
        }

        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationWithOptions(request, headers, runtime);
        }

        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationWithOptionsAsync(request, headers, runtime);
        }

        public UpdateApplicationResponse UpdateApplicationWithOptions(UpdateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                body["AppDescription"] = request.AppDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateApplicationResponse>(DoROARequestWithForm("UpdateApplication", "2019-03-20", "HTTPS", "PUT", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public async Task<UpdateApplicationResponse> UpdateApplicationWithOptionsAsync(UpdateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                body["AppDescription"] = request.AppDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateApplicationResponse>(await DoROARequestWithFormAsync("UpdateApplication", "2019-03-20", "HTTPS", "PUT", "AK", "/pop/v1/wam/application", "json", req, runtime));
        }

        public UpdateConfigTemplateResponse UpdateConfigTemplate(UpdateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigTemplateWithOptions(request, headers, runtime);
        }

        public async Task<UpdateConfigTemplateResponse> UpdateConfigTemplateAsync(UpdateConfigTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigTemplateWithOptionsAsync(request, headers, runtime);
        }

        public UpdateConfigTemplateResponse UpdateConfigTemplateWithOptions(UpdateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDescription))
            {
                body["TemplateDescription"] = request.TemplateDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateConfigTemplateResponse>(DoROARequestWithForm("UpdateConfigTemplate", "2019-03-20", "HTTPS", "PUT", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public async Task<UpdateConfigTemplateResponse> UpdateConfigTemplateWithOptionsAsync(UpdateConfigTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDescription))
            {
                body["TemplateDescription"] = request.TemplateDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateConfigTemplateResponse>(await DoROARequestWithFormAsync("UpdateConfigTemplate", "2019-03-20", "HTTPS", "PUT", "AK", "/pop/v1/wam/configTemplate", "json", req, runtime));
        }

        public ValidateConfigSettingResponse ValidateConfigSetting(ValidateConfigSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateConfigSettingWithOptions(request, headers, runtime);
        }

        public async Task<ValidateConfigSettingResponse> ValidateConfigSettingAsync(ValidateConfigSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateConfigSettingWithOptionsAsync(request, headers, runtime);
        }

        public ValidateConfigSettingResponse ValidateConfigSettingWithOptions(ValidateConfigSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ValidateConfigSettingResponse>(DoROARequestWithForm("ValidateConfigSetting", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/config/configSetting/validate", "json", req, runtime));
        }

        public async Task<ValidateConfigSettingResponse> ValidateConfigSettingWithOptionsAsync(ValidateConfigSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["EnvId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                body["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionSettings))
            {
                body["OptionSettings"] = request.OptionSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ValidateConfigSettingResponse>(await DoROARequestWithFormAsync("ValidateConfigSetting", "2019-03-20", "HTTPS", "POST", "AK", "/pop/v1/wam/config/configSetting/validate", "json", req, runtime));
        }

    }
}
