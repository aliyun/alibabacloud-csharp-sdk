// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aliding20230426.Models;

namespace AlibabaCloud.SDK.Aliding20230426
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aliding", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateSheetResponse CreateSheetWithOptions(CreateSheetRequest tmpReq, CreateSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSheetShrinkRequest request = new CreateSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateSheetShrinkHeaders headers = new CreateSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSheetResponse> CreateSheetWithOptionsAsync(CreateSheetRequest tmpReq, CreateSheetHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSheetShrinkRequest request = new CreateSheetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            CreateSheetShrinkHeaders headers = new CreateSheetShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/createSheet",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSheetResponse CreateSheet(CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return CreateSheetWithOptions(request, headers, runtime);
        }

        public async Task<CreateSheetResponse> CreateSheetAsync(CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return await CreateSheetWithOptionsAsync(request, headers, runtime);
        }

        public InsertRowsBeforeResponse InsertRowsBeforeWithOptions(InsertRowsBeforeRequest tmpReq, InsertRowsBeforeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertRowsBeforeShrinkRequest request = new InsertRowsBeforeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InsertRowsBeforeShrinkHeaders headers = new InsertRowsBeforeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRowsBefore",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/insertRowsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRowsBeforeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeWithOptionsAsync(InsertRowsBeforeRequest tmpReq, InsertRowsBeforeHeaders tmpHeader, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertRowsBeforeShrinkRequest request = new InsertRowsBeforeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            InsertRowsBeforeShrinkHeaders headers = new InsertRowsBeforeShrinkHeaders();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpHeader, headers);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpHeader.AccountContext))
            {
                headers.AccountContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpHeader.AccountContext, "AccountContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantContext))
            {
                request.TenantContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantContext, "TenantContext", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                body["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                body["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetId))
            {
                body["SheetId"] = request.SheetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantContextShrink))
            {
                body["TenantContext"] = request.TenantContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkbookId))
            {
                body["WorkbookId"] = request.WorkbookId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccountContextShrink))
            {
                realHeaders["AccountContext"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccountContextShrink);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRowsBefore",
                Version = "2023-04-26",
                Protocol = "HTTPS",
                Pathname = "/dingtalk/v1/documents/insertRowsBefore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRowsBeforeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertRowsBeforeResponse InsertRowsBefore(InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return InsertRowsBeforeWithOptions(request, headers, runtime);
        }

        public async Task<InsertRowsBeforeResponse> InsertRowsBeforeAsync(InsertRowsBeforeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRowsBeforeHeaders headers = new InsertRowsBeforeHeaders();
            return await InsertRowsBeforeWithOptionsAsync(request, headers, runtime);
        }

    }
}
