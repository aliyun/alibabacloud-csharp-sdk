// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EttrafficIsp20230830.Models;

namespace AlibabaCloud.SDK.EttrafficIsp20230830
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ettrafficisp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AkDisableResponse AkDisableWithOptions(AkDisableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkDisable",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/disable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkDisableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AkDisableResponse> AkDisableWithOptionsAsync(AkDisableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkDisable",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/disable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkDisableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AkDisableResponse AkDisable(AkDisableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AkDisableWithOptions(request, headers, runtime);
        }

        public async Task<AkDisableResponse> AkDisableAsync(AkDisableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AkDisableWithOptionsAsync(request, headers, runtime);
        }

        public AkEnableResponse AkEnableWithOptions(AkEnableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkEnable",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/enable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkEnableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AkEnableResponse> AkEnableWithOptionsAsync(AkEnableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkEnable",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/enable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkEnableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AkEnableResponse AkEnable(AkEnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AkEnableWithOptions(request, headers, runtime);
        }

        public async Task<AkEnableResponse> AkEnableAsync(AkEnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AkEnableWithOptionsAsync(request, headers, runtime);
        }

        public AkGenerateResponse AkGenerateWithOptions(AkGenerateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkGenerate",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/generate",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkGenerateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AkGenerateResponse> AkGenerateWithOptionsAsync(AkGenerateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkGenerate",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/generate",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkGenerateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AkGenerateResponse AkGenerate(AkGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AkGenerateWithOptions(request, headers, runtime);
        }

        public async Task<AkGenerateResponse> AkGenerateAsync(AkGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AkGenerateWithOptionsAsync(request, headers, runtime);
        }

        public AkListPageResponse AkListPageWithOptions(AkListPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkListPage",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/listPage",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkListPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AkListPageResponse> AkListPageWithOptionsAsync(AkListPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkListPage",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/listPage",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkListPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AkListPageResponse AkListPage(AkListPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AkListPageWithOptions(request, headers, runtime);
        }

        public async Task<AkListPageResponse> AkListPageAsync(AkListPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AkListPageWithOptionsAsync(request, headers, runtime);
        }

        public AkUpdateResponse AkUpdateWithOptions(AkUpdateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkUpdate",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/update",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkUpdateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AkUpdateResponse> AkUpdateWithOptionsAsync(AkUpdateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                body["accessKeyId"] = request.AccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyName))
            {
                body["accessKeyName"] = request.AccessKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AkUpdate",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/ak/update",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AkUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AkUpdateResponse AkUpdate(AkUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AkUpdateWithOptions(request, headers, runtime);
        }

        public async Task<AkUpdateResponse> AkUpdateAsync(AkUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AkUpdateWithOptionsAsync(request, headers, runtime);
        }

        public DimGroupResponse DimGroupWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DimGroup",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/dim/group",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DimGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DimGroupResponse> DimGroupWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DimGroup",
                Version = "2023-08-30",
                Protocol = "HTTPS",
                Pathname = "/console/dim/group",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DimGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DimGroupResponse DimGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DimGroupWithOptions(headers, runtime);
        }

        public async Task<DimGroupResponse> DimGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DimGroupWithOptionsAsync(headers, runtime);
        }

    }
}
