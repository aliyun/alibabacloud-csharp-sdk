// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dysmsapi20170525.Models;

namespace AlibabaCloud.SDK.Dysmsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "dysmsapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "dysmsapi-xman.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "dysmsapi-proxy.cn-beijing.aliyuncs.com"},
                {"cn-hongkong", "dysmsapi-xman.cn-hongkong.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dysmsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddShortUrlResponse AddShortUrlWithOptions(AddShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddShortUrlResponse>(DoRPCRequest("AddShortUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddShortUrlResponse> AddShortUrlWithOptionsAsync(AddShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddShortUrlResponse>(await DoRPCRequestAsync("AddShortUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddShortUrlResponse AddShortUrl(AddShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddShortUrlWithOptions(request, runtime);
        }

        public async Task<AddShortUrlResponse> AddShortUrlAsync(AddShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddShortUrlWithOptionsAsync(request, runtime);
        }

        public AddSmsSignResponse AddSmsSignWithOptions(AddSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSmsSignResponse>(DoRPCRequest("AddSmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSmsSignResponse> AddSmsSignWithOptionsAsync(AddSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSmsSignResponse>(await DoRPCRequestAsync("AddSmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSmsSignResponse AddSmsSign(AddSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSmsSignWithOptions(request, runtime);
        }

        public async Task<AddSmsSignResponse> AddSmsSignAsync(AddSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSmsSignWithOptionsAsync(request, runtime);
        }

        public AddSmsTemplateResponse AddSmsTemplateWithOptions(AddSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSmsTemplateResponse>(DoRPCRequest("AddSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSmsTemplateResponse> AddSmsTemplateWithOptionsAsync(AddSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSmsTemplateResponse>(await DoRPCRequestAsync("AddSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSmsTemplateResponse AddSmsTemplate(AddSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSmsTemplateWithOptions(request, runtime);
        }

        public async Task<AddSmsTemplateResponse> AddSmsTemplateAsync(AddSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSmsTemplateWithOptionsAsync(request, runtime);
        }

        public CreateCardSmsTemplateResponse CreateCardSmsTemplateWithOptions(CreateCardSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCardSmsTemplateShrinkRequest request = new CreateCardSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCardSmsTemplateResponse>(DoRPCRequest("CreateCardSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCardSmsTemplateResponse> CreateCardSmsTemplateWithOptionsAsync(CreateCardSmsTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCardSmsTemplateShrinkRequest request = new CreateCardSmsTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Template))
            {
                request.TemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Template, "Template", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCardSmsTemplateResponse>(await DoRPCRequestAsync("CreateCardSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCardSmsTemplateResponse CreateCardSmsTemplate(CreateCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCardSmsTemplateWithOptions(request, runtime);
        }

        public async Task<CreateCardSmsTemplateResponse> CreateCardSmsTemplateAsync(CreateCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCardSmsTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteShortUrlResponse DeleteShortUrlWithOptions(DeleteShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteShortUrlResponse>(DoRPCRequest("DeleteShortUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteShortUrlResponse> DeleteShortUrlWithOptionsAsync(DeleteShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteShortUrlResponse>(await DoRPCRequestAsync("DeleteShortUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteShortUrlResponse DeleteShortUrl(DeleteShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteShortUrlWithOptions(request, runtime);
        }

        public async Task<DeleteShortUrlResponse> DeleteShortUrlAsync(DeleteShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteShortUrlWithOptionsAsync(request, runtime);
        }

        public DeleteSmsSignResponse DeleteSmsSignWithOptions(DeleteSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsSignResponse>(DoRPCRequest("DeleteSmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmsSignResponse> DeleteSmsSignWithOptionsAsync(DeleteSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsSignResponse>(await DoRPCRequestAsync("DeleteSmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmsSignResponse DeleteSmsSign(DeleteSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsSignWithOptions(request, runtime);
        }

        public async Task<DeleteSmsSignResponse> DeleteSmsSignAsync(DeleteSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsSignWithOptionsAsync(request, runtime);
        }

        public DeleteSmsTemplateResponse DeleteSmsTemplateWithOptions(DeleteSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsTemplateResponse>(DoRPCRequest("DeleteSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplateWithOptionsAsync(DeleteSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsTemplateResponse>(await DoRPCRequestAsync("DeleteSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmsTemplateResponse DeleteSmsTemplate(DeleteSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplateAsync(DeleteSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsTemplateWithOptionsAsync(request, runtime);
        }

        public GetMediaResourceIdResponse GetMediaResourceIdWithOptions(GetMediaResourceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaResourceIdResponse>(DoRPCRequest("GetMediaResourceId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMediaResourceIdResponse> GetMediaResourceIdWithOptionsAsync(GetMediaResourceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMediaResourceIdResponse>(await DoRPCRequestAsync("GetMediaResourceId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMediaResourceIdResponse GetMediaResourceId(GetMediaResourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaResourceIdWithOptions(request, runtime);
        }

        public async Task<GetMediaResourceIdResponse> GetMediaResourceIdAsync(GetMediaResourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaResourceIdWithOptionsAsync(request, runtime);
        }

        public GetOSSInfoForCardTemplateResponse GetOSSInfoForCardTemplateWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetOSSInfoForCardTemplateResponse>(DoRPCRequest("GetOSSInfoForCardTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOSSInfoForCardTemplateResponse> GetOSSInfoForCardTemplateWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetOSSInfoForCardTemplateResponse>(await DoRPCRequestAsync("GetOSSInfoForCardTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOSSInfoForCardTemplateResponse GetOSSInfoForCardTemplate()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOSSInfoForCardTemplateWithOptions(runtime);
        }

        public async Task<GetOSSInfoForCardTemplateResponse> GetOSSInfoForCardTemplateAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOSSInfoForCardTemplateWithOptionsAsync(runtime);
        }

        public ModifySmsSignResponse ModifySmsSignWithOptions(ModifySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmsSignResponse>(DoRPCRequest("ModifySmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySmsSignResponse> ModifySmsSignWithOptionsAsync(ModifySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmsSignResponse>(await DoRPCRequestAsync("ModifySmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySmsSignResponse ModifySmsSign(ModifySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmsSignWithOptions(request, runtime);
        }

        public async Task<ModifySmsSignResponse> ModifySmsSignAsync(ModifySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmsSignWithOptionsAsync(request, runtime);
        }

        public ModifySmsTemplateResponse ModifySmsTemplateWithOptions(ModifySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmsTemplateResponse>(DoRPCRequest("ModifySmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySmsTemplateResponse> ModifySmsTemplateWithOptionsAsync(ModifySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmsTemplateResponse>(await DoRPCRequestAsync("ModifySmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySmsTemplateResponse ModifySmsTemplate(ModifySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmsTemplateWithOptions(request, runtime);
        }

        public async Task<ModifySmsTemplateResponse> ModifySmsTemplateAsync(ModifySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmsTemplateWithOptionsAsync(request, runtime);
        }

        public QueryCardSmsTemplateResponse QueryCardSmsTemplateWithOptions(QueryCardSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardSmsTemplateResponse>(DoRPCRequest("QueryCardSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCardSmsTemplateResponse> QueryCardSmsTemplateWithOptionsAsync(QueryCardSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCardSmsTemplateResponse>(await DoRPCRequestAsync("QueryCardSmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCardSmsTemplateResponse QueryCardSmsTemplate(QueryCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCardSmsTemplateWithOptions(request, runtime);
        }

        public async Task<QueryCardSmsTemplateResponse> QueryCardSmsTemplateAsync(QueryCardSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCardSmsTemplateWithOptionsAsync(request, runtime);
        }

        public QuerySendDetailsResponse QuerySendDetailsWithOptions(QuerySendDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySendDetailsResponse>(DoRPCRequest("QuerySendDetails", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySendDetailsResponse> QuerySendDetailsWithOptionsAsync(QuerySendDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySendDetailsResponse>(await DoRPCRequestAsync("QuerySendDetails", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySendDetailsResponse QuerySendDetails(QuerySendDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySendDetailsWithOptions(request, runtime);
        }

        public async Task<QuerySendDetailsResponse> QuerySendDetailsAsync(QuerySendDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySendDetailsWithOptionsAsync(request, runtime);
        }

        public QueryShortUrlResponse QueryShortUrlWithOptions(QueryShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryShortUrlResponse>(DoRPCRequest("QueryShortUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryShortUrlResponse> QueryShortUrlWithOptionsAsync(QueryShortUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryShortUrlResponse>(await DoRPCRequestAsync("QueryShortUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryShortUrlResponse QueryShortUrl(QueryShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryShortUrlWithOptions(request, runtime);
        }

        public async Task<QueryShortUrlResponse> QueryShortUrlAsync(QueryShortUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryShortUrlWithOptionsAsync(request, runtime);
        }

        public QuerySmsSignResponse QuerySmsSignWithOptions(QuerySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmsSignResponse>(DoRPCRequest("QuerySmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySmsSignResponse> QuerySmsSignWithOptionsAsync(QuerySmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmsSignResponse>(await DoRPCRequestAsync("QuerySmsSign", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySmsSignResponse QuerySmsSign(QuerySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsSignWithOptions(request, runtime);
        }

        public async Task<QuerySmsSignResponse> QuerySmsSignAsync(QuerySmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsSignWithOptionsAsync(request, runtime);
        }

        public QuerySmsTemplateResponse QuerySmsTemplateWithOptions(QuerySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmsTemplateResponse>(DoRPCRequest("QuerySmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySmsTemplateResponse> QuerySmsTemplateWithOptionsAsync(QuerySmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmsTemplateResponse>(await DoRPCRequestAsync("QuerySmsTemplate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySmsTemplateResponse QuerySmsTemplate(QuerySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsTemplateWithOptions(request, runtime);
        }

        public async Task<QuerySmsTemplateResponse> QuerySmsTemplateAsync(QuerySmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsTemplateWithOptionsAsync(request, runtime);
        }

        public SendBatchSmsResponse SendBatchSmsWithOptions(SendBatchSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendBatchSmsResponse>(DoRPCRequest("SendBatchSms", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendBatchSmsResponse> SendBatchSmsWithOptionsAsync(SendBatchSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendBatchSmsResponse>(await DoRPCRequestAsync("SendBatchSms", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendBatchSmsResponse SendBatchSms(SendBatchSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendBatchSmsWithOptions(request, runtime);
        }

        public async Task<SendBatchSmsResponse> SendBatchSmsAsync(SendBatchSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendBatchSmsWithOptionsAsync(request, runtime);
        }

        public SendCardSmsResponse SendCardSmsWithOptions(SendCardSmsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendCardSmsShrinkRequest request = new SendCardSmsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CardObjects))
            {
                request.CardObjectsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CardObjects, "CardObjects", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCardSmsResponse>(DoRPCRequest("SendCardSms", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCardSmsResponse> SendCardSmsWithOptionsAsync(SendCardSmsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendCardSmsShrinkRequest request = new SendCardSmsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CardObjects))
            {
                request.CardObjectsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CardObjects, "CardObjects", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCardSmsResponse>(await DoRPCRequestAsync("SendCardSms", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCardSmsResponse SendCardSms(SendCardSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCardSmsWithOptions(request, runtime);
        }

        public async Task<SendCardSmsResponse> SendCardSmsAsync(SendCardSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCardSmsWithOptionsAsync(request, runtime);
        }

        public SendMessageToGlobeResponse SendMessageToGlobeWithOptions(SendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageToGlobeResponse>(DoRPCRequest("SendMessageToGlobe", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendMessageToGlobeResponse> SendMessageToGlobeWithOptionsAsync(SendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageToGlobeResponse>(await DoRPCRequestAsync("SendMessageToGlobe", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendMessageToGlobeResponse SendMessageToGlobe(SendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageToGlobeWithOptions(request, runtime);
        }

        public async Task<SendMessageToGlobeResponse> SendMessageToGlobeAsync(SendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageToGlobeWithOptionsAsync(request, runtime);
        }

        public SendSmsResponse SendSmsWithOptions(SendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendSmsResponse>(DoRPCRequest("SendSms", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendSmsResponse> SendSmsWithOptionsAsync(SendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendSmsResponse>(await DoRPCRequestAsync("SendSms", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendSmsResponse SendSms(SendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendSmsWithOptions(request, runtime);
        }

        public async Task<SendSmsResponse> SendSmsAsync(SendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendSmsWithOptionsAsync(request, runtime);
        }

        public SendSmsSmartResponse SendSmsSmartWithOptions(SendSmsSmartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendSmsSmartResponse>(DoRPCRequest("SendSmsSmart", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendSmsSmartResponse> SendSmsSmartWithOptionsAsync(SendSmsSmartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendSmsSmartResponse>(await DoRPCRequestAsync("SendSmsSmart", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendSmsSmartResponse SendSmsSmart(SendSmsSmartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendSmsSmartWithOptions(request, runtime);
        }

        public async Task<SendSmsSmartResponse> SendSmsSmartAsync(SendSmsSmartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendSmsSmartWithOptionsAsync(request, runtime);
        }

    }
}
