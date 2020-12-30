// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dm20151123.Models;

namespace AlibabaCloud.SDK.Dm20151123
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dm", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddIpfilterResponse AddIpfilterWithOptions(AddIpfilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIpfilterResponse>(DoRPCRequest("AddIpfilter", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddIpfilterResponse> AddIpfilterWithOptionsAsync(AddIpfilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIpfilterResponse>(await DoRPCRequestAsync("AddIpfilter", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddIpfilterResponse AddIpfilter(AddIpfilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIpfilterWithOptions(request, runtime);
        }

        public async Task<AddIpfilterResponse> AddIpfilterAsync(AddIpfilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIpfilterWithOptionsAsync(request, runtime);
        }

        public ApproveMailTemplateResponse ApproveMailTemplateWithOptions(ApproveMailTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveMailTemplateResponse>(DoRPCRequest("ApproveMailTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApproveMailTemplateResponse> ApproveMailTemplateWithOptionsAsync(ApproveMailTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveMailTemplateResponse>(await DoRPCRequestAsync("ApproveMailTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApproveMailTemplateResponse ApproveMailTemplate(ApproveMailTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveMailTemplateWithOptions(request, runtime);
        }

        public async Task<ApproveMailTemplateResponse> ApproveMailTemplateAsync(ApproveMailTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveMailTemplateWithOptionsAsync(request, runtime);
        }

        public ApproveReplyMailAddressResponse ApproveReplyMailAddressWithOptions(ApproveReplyMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveReplyMailAddressResponse>(DoRPCRequest("ApproveReplyMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApproveReplyMailAddressResponse> ApproveReplyMailAddressWithOptionsAsync(ApproveReplyMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveReplyMailAddressResponse>(await DoRPCRequestAsync("ApproveReplyMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApproveReplyMailAddressResponse ApproveReplyMailAddress(ApproveReplyMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveReplyMailAddressWithOptions(request, runtime);
        }

        public async Task<ApproveReplyMailAddressResponse> ApproveReplyMailAddressAsync(ApproveReplyMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveReplyMailAddressWithOptionsAsync(request, runtime);
        }

        public ApproveSmsTemplateResponse ApproveSmsTemplateWithOptions(ApproveSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveSmsTemplateResponse>(DoRPCRequest("ApproveSmsTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApproveSmsTemplateResponse> ApproveSmsTemplateWithOptionsAsync(ApproveSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveSmsTemplateResponse>(await DoRPCRequestAsync("ApproveSmsTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApproveSmsTemplateResponse ApproveSmsTemplate(ApproveSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveSmsTemplateWithOptions(request, runtime);
        }

        public async Task<ApproveSmsTemplateResponse> ApproveSmsTemplateAsync(ApproveSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveSmsTemplateWithOptionsAsync(request, runtime);
        }

        public ApproveTemplateResponse ApproveTemplateWithOptions(ApproveTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveTemplateResponse>(DoRPCRequest("ApproveTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApproveTemplateResponse> ApproveTemplateWithOptionsAsync(ApproveTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApproveTemplateResponse>(await DoRPCRequestAsync("ApproveTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApproveTemplateResponse ApproveTemplate(ApproveTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveTemplateWithOptions(request, runtime);
        }

        public async Task<ApproveTemplateResponse> ApproveTemplateAsync(ApproveTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveTemplateWithOptionsAsync(request, runtime);
        }

        public BatchSendMailResponse BatchSendMailWithOptions(BatchSendMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSendMailResponse>(DoRPCRequest("BatchSendMail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSendMailResponse> BatchSendMailWithOptionsAsync(BatchSendMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSendMailResponse>(await DoRPCRequestAsync("BatchSendMail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSendMailResponse BatchSendMail(BatchSendMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSendMailWithOptions(request, runtime);
        }

        public async Task<BatchSendMailResponse> BatchSendMailAsync(BatchSendMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSendMailWithOptionsAsync(request, runtime);
        }

        public CheckDomainResponse CheckDomainWithOptions(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDomainResponse>(DoRPCRequest("CheckDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDomainResponse> CheckDomainWithOptionsAsync(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDomainResponse>(await DoRPCRequestAsync("CheckDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDomainResponse CheckDomain(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainWithOptions(request, runtime);
        }

        public async Task<CheckDomainResponse> CheckDomainAsync(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainWithOptionsAsync(request, runtime);
        }

        public CheckInvalidAddressResponse CheckInvalidAddressWithOptions(CheckInvalidAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckInvalidAddressResponse>(DoRPCRequest("CheckInvalidAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckInvalidAddressResponse> CheckInvalidAddressWithOptionsAsync(CheckInvalidAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckInvalidAddressResponse>(await DoRPCRequestAsync("CheckInvalidAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckInvalidAddressResponse CheckInvalidAddress(CheckInvalidAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckInvalidAddressWithOptions(request, runtime);
        }

        public async Task<CheckInvalidAddressResponse> CheckInvalidAddressAsync(CheckInvalidAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckInvalidAddressWithOptionsAsync(request, runtime);
        }

        public CheckReplyToMailAddressResponse CheckReplyToMailAddressWithOptions(CheckReplyToMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckReplyToMailAddressResponse>(DoRPCRequest("CheckReplyToMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckReplyToMailAddressResponse> CheckReplyToMailAddressWithOptionsAsync(CheckReplyToMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckReplyToMailAddressResponse>(await DoRPCRequestAsync("CheckReplyToMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckReplyToMailAddressResponse CheckReplyToMailAddress(CheckReplyToMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckReplyToMailAddressWithOptions(request, runtime);
        }

        public async Task<CheckReplyToMailAddressResponse> CheckReplyToMailAddressAsync(CheckReplyToMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckReplyToMailAddressWithOptionsAsync(request, runtime);
        }

        public CreateDayuResponse CreateDayuWithOptions(CreateDayuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDayuResponse>(DoRPCRequest("CreateDayu", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDayuResponse> CreateDayuWithOptionsAsync(CreateDayuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDayuResponse>(await DoRPCRequestAsync("CreateDayu", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDayuResponse CreateDayu(CreateDayuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDayuWithOptions(request, runtime);
        }

        public async Task<CreateDayuResponse> CreateDayuAsync(CreateDayuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDayuWithOptionsAsync(request, runtime);
        }

        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainResponse>(DoRPCRequest("CreateDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainResponse>(await DoRPCRequestAsync("CreateDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainWithOptions(request, runtime);
        }

        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainWithOptionsAsync(request, runtime);
        }

        public CreateMailAddressResponse CreateMailAddressWithOptions(CreateMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMailAddressResponse>(DoRPCRequest("CreateMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMailAddressResponse> CreateMailAddressWithOptionsAsync(CreateMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMailAddressResponse>(await DoRPCRequestAsync("CreateMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMailAddressResponse CreateMailAddress(CreateMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMailAddressWithOptions(request, runtime);
        }

        public async Task<CreateMailAddressResponse> CreateMailAddressAsync(CreateMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMailAddressWithOptionsAsync(request, runtime);
        }

        public CreateReceiverResponse CreateReceiverWithOptions(CreateReceiverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateReceiverResponse>(DoRPCRequest("CreateReceiver", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateReceiverResponse> CreateReceiverWithOptionsAsync(CreateReceiverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateReceiverResponse>(await DoRPCRequestAsync("CreateReceiver", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateReceiverResponse CreateReceiver(CreateReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReceiverWithOptions(request, runtime);
        }

        public async Task<CreateReceiverResponse> CreateReceiverAsync(CreateReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReceiverWithOptionsAsync(request, runtime);
        }

        public CreateSignResponse CreateSignWithOptions(CreateSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSignResponse>(DoRPCRequest("CreateSign", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSignResponse> CreateSignWithOptionsAsync(CreateSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSignResponse>(await DoRPCRequestAsync("CreateSign", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSignResponse CreateSign(CreateSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSignWithOptions(request, runtime);
        }

        public async Task<CreateSignResponse> CreateSignAsync(CreateSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSignWithOptionsAsync(request, runtime);
        }

        public CreateTagResponse CreateTagWithOptions(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTagResponse>(DoRPCRequest("CreateTag", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTagResponse>(await DoRPCRequestAsync("CreateTag", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTagResponse CreateTag(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagWithOptions(request, runtime);
        }

        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagWithOptionsAsync(request, runtime);
        }

        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(DoRPCRequest("CreateTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await DoRPCRequestAsync("CreateTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(DoRPCRequest("DeleteDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await DoRPCRequestAsync("DeleteDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        public DeleteInvalidAddressResponse DeleteInvalidAddressWithOptions(DeleteInvalidAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInvalidAddressResponse>(DoRPCRequest("DeleteInvalidAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInvalidAddressResponse> DeleteInvalidAddressWithOptionsAsync(DeleteInvalidAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInvalidAddressResponse>(await DoRPCRequestAsync("DeleteInvalidAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInvalidAddressResponse DeleteInvalidAddress(DeleteInvalidAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInvalidAddressWithOptions(request, runtime);
        }

        public async Task<DeleteInvalidAddressResponse> DeleteInvalidAddressAsync(DeleteInvalidAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInvalidAddressWithOptionsAsync(request, runtime);
        }

        public DeleteIpfilterByEdmIdResponse DeleteIpfilterByEdmIdWithOptions(DeleteIpfilterByEdmIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpfilterByEdmIdResponse>(DoRPCRequest("DeleteIpfilterByEdmId", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpfilterByEdmIdResponse> DeleteIpfilterByEdmIdWithOptionsAsync(DeleteIpfilterByEdmIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpfilterByEdmIdResponse>(await DoRPCRequestAsync("DeleteIpfilterByEdmId", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpfilterByEdmIdResponse DeleteIpfilterByEdmId(DeleteIpfilterByEdmIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpfilterByEdmIdWithOptions(request, runtime);
        }

        public async Task<DeleteIpfilterByEdmIdResponse> DeleteIpfilterByEdmIdAsync(DeleteIpfilterByEdmIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpfilterByEdmIdWithOptionsAsync(request, runtime);
        }

        public DeleteMailAddressResponse DeleteMailAddressWithOptions(DeleteMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMailAddressResponse>(DoRPCRequest("DeleteMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMailAddressResponse> DeleteMailAddressWithOptionsAsync(DeleteMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMailAddressResponse>(await DoRPCRequestAsync("DeleteMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMailAddressResponse DeleteMailAddress(DeleteMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMailAddressWithOptions(request, runtime);
        }

        public async Task<DeleteMailAddressResponse> DeleteMailAddressAsync(DeleteMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMailAddressWithOptionsAsync(request, runtime);
        }

        public DeleteReceiverResponse DeleteReceiverWithOptions(DeleteReceiverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteReceiverResponse>(DoRPCRequest("DeleteReceiver", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteReceiverResponse> DeleteReceiverWithOptionsAsync(DeleteReceiverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteReceiverResponse>(await DoRPCRequestAsync("DeleteReceiver", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteReceiverResponse DeleteReceiver(DeleteReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteReceiverWithOptions(request, runtime);
        }

        public async Task<DeleteReceiverResponse> DeleteReceiverAsync(DeleteReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteReceiverWithOptionsAsync(request, runtime);
        }

        public DeleteReceiverDetailResponse DeleteReceiverDetailWithOptions(DeleteReceiverDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteReceiverDetailResponse>(DoRPCRequest("DeleteReceiverDetail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteReceiverDetailResponse> DeleteReceiverDetailWithOptionsAsync(DeleteReceiverDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteReceiverDetailResponse>(await DoRPCRequestAsync("DeleteReceiverDetail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteReceiverDetailResponse DeleteReceiverDetail(DeleteReceiverDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteReceiverDetailWithOptions(request, runtime);
        }

        public async Task<DeleteReceiverDetailResponse> DeleteReceiverDetailAsync(DeleteReceiverDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteReceiverDetailWithOptionsAsync(request, runtime);
        }

        public DeleteSignResponse DeleteSignWithOptions(DeleteSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSignResponse>(DoRPCRequest("DeleteSign", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSignResponse> DeleteSignWithOptionsAsync(DeleteSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSignResponse>(await DoRPCRequestAsync("DeleteSign", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSignResponse DeleteSign(DeleteSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSignWithOptions(request, runtime);
        }

        public async Task<DeleteSignResponse> DeleteSignAsync(DeleteSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSignWithOptionsAsync(request, runtime);
        }

        public DeleteTagResponse DeleteTagWithOptions(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagResponse>(DoRPCRequest("DeleteTag", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTagResponse> DeleteTagWithOptionsAsync(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagResponse>(await DoRPCRequestAsync("DeleteTag", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTagResponse DeleteTag(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithOptions(request, runtime);
        }

        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithOptionsAsync(request, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(DoRPCRequest("DeleteTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await DoRPCRequestAsync("DeleteTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        public DescAccountSummaryResponse DescAccountSummaryWithOptions(DescAccountSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescAccountSummaryResponse>(DoRPCRequest("DescAccountSummary", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescAccountSummaryResponse> DescAccountSummaryWithOptionsAsync(DescAccountSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescAccountSummaryResponse>(await DoRPCRequestAsync("DescAccountSummary", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescAccountSummaryResponse DescAccountSummary(DescAccountSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescAccountSummaryWithOptions(request, runtime);
        }

        public async Task<DescAccountSummaryResponse> DescAccountSummaryAsync(DescAccountSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescAccountSummaryWithOptionsAsync(request, runtime);
        }

        public DescAccountSummary2Response DescAccountSummary2WithOptions(DescAccountSummary2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescAccountSummary2Response>(DoRPCRequest("DescAccountSummary2", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescAccountSummary2Response> DescAccountSummary2WithOptionsAsync(DescAccountSummary2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescAccountSummary2Response>(await DoRPCRequestAsync("DescAccountSummary2", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescAccountSummary2Response DescAccountSummary2(DescAccountSummary2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescAccountSummary2WithOptions(request, runtime);
        }

        public async Task<DescAccountSummary2Response> DescAccountSummary2Async(DescAccountSummary2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescAccountSummary2WithOptionsAsync(request, runtime);
        }

        public DescDomainResponse DescDomainWithOptions(DescDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescDomainResponse>(DoRPCRequest("DescDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescDomainResponse> DescDomainWithOptionsAsync(DescDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescDomainResponse>(await DoRPCRequestAsync("DescDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescDomainResponse DescDomain(DescDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescDomainWithOptions(request, runtime);
        }

        public async Task<DescDomainResponse> DescDomainAsync(DescDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescDomainWithOptionsAsync(request, runtime);
        }

        public DescTemplateResponse DescTemplateWithOptions(DescTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescTemplateResponse>(DoRPCRequest("DescTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescTemplateResponse> DescTemplateWithOptionsAsync(DescTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescTemplateResponse>(await DoRPCRequestAsync("DescTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescTemplateResponse DescTemplate(DescTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescTemplateWithOptions(request, runtime);
        }

        public async Task<DescTemplateResponse> DescTemplateAsync(DescTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescTemplateWithOptionsAsync(request, runtime);
        }

        public EnableAccountResponse EnableAccountWithOptions(EnableAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAccountResponse>(DoRPCRequest("EnableAccount", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableAccountResponse> EnableAccountWithOptionsAsync(EnableAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAccountResponse>(await DoRPCRequestAsync("EnableAccount", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableAccountResponse EnableAccount(EnableAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAccountWithOptions(request, runtime);
        }

        public async Task<EnableAccountResponse> EnableAccountAsync(EnableAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAccountWithOptionsAsync(request, runtime);
        }

        public GetAccountListResponse GetAccountListWithOptions(GetAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAccountListResponse>(DoRPCRequest("GetAccountList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAccountListResponse> GetAccountListWithOptionsAsync(GetAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAccountListResponse>(await DoRPCRequestAsync("GetAccountList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAccountListResponse GetAccountList(GetAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountListWithOptions(request, runtime);
        }

        public async Task<GetAccountListResponse> GetAccountListAsync(GetAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountListWithOptionsAsync(request, runtime);
        }

        public GetIpfilterListResponse GetIpfilterListWithOptions(GetIpfilterListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIpfilterListResponse>(DoRPCRequest("GetIpfilterList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIpfilterListResponse> GetIpfilterListWithOptionsAsync(GetIpfilterListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIpfilterListResponse>(await DoRPCRequestAsync("GetIpfilterList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIpfilterListResponse GetIpfilterList(GetIpfilterListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIpfilterListWithOptions(request, runtime);
        }

        public async Task<GetIpfilterListResponse> GetIpfilterListAsync(GetIpfilterListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIpfilterListWithOptionsAsync(request, runtime);
        }

        public GetIpProtectionResponse GetIpProtectionWithOptions(GetIpProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIpProtectionResponse>(DoRPCRequest("GetIpProtection", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIpProtectionResponse> GetIpProtectionWithOptionsAsync(GetIpProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIpProtectionResponse>(await DoRPCRequestAsync("GetIpProtection", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIpProtectionResponse GetIpProtection(GetIpProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIpProtectionWithOptions(request, runtime);
        }

        public async Task<GetIpProtectionResponse> GetIpProtectionAsync(GetIpProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIpProtectionWithOptionsAsync(request, runtime);
        }

        public GetMailAddressMsgCallBackUrlResponse GetMailAddressMsgCallBackUrlWithOptions(GetMailAddressMsgCallBackUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMailAddressMsgCallBackUrlResponse>(DoRPCRequest("GetMailAddressMsgCallBackUrl", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMailAddressMsgCallBackUrlResponse> GetMailAddressMsgCallBackUrlWithOptionsAsync(GetMailAddressMsgCallBackUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMailAddressMsgCallBackUrlResponse>(await DoRPCRequestAsync("GetMailAddressMsgCallBackUrl", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMailAddressMsgCallBackUrlResponse GetMailAddressMsgCallBackUrl(GetMailAddressMsgCallBackUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMailAddressMsgCallBackUrlWithOptions(request, runtime);
        }

        public async Task<GetMailAddressMsgCallBackUrlResponse> GetMailAddressMsgCallBackUrlAsync(GetMailAddressMsgCallBackUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMailAddressMsgCallBackUrlWithOptionsAsync(request, runtime);
        }

        public GetRegionListResponse GetRegionListWithOptions(GetRegionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegionListResponse>(DoRPCRequest("GetRegionList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRegionListResponse> GetRegionListWithOptionsAsync(GetRegionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegionListResponse>(await DoRPCRequestAsync("GetRegionList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRegionListResponse GetRegionList(GetRegionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegionListWithOptions(request, runtime);
        }

        public async Task<GetRegionListResponse> GetRegionListAsync(GetRegionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegionListWithOptionsAsync(request, runtime);
        }

        public GetSenderAddressListResponse GetSenderAddressListWithOptions(GetSenderAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSenderAddressListResponse>(DoRPCRequest("GetSenderAddressList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSenderAddressListResponse> GetSenderAddressListWithOptionsAsync(GetSenderAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSenderAddressListResponse>(await DoRPCRequestAsync("GetSenderAddressList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSenderAddressListResponse GetSenderAddressList(GetSenderAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSenderAddressListWithOptions(request, runtime);
        }

        public async Task<GetSenderAddressListResponse> GetSenderAddressListAsync(GetSenderAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSenderAddressListWithOptionsAsync(request, runtime);
        }

        public GetTrackListResponse GetTrackListWithOptions(GetTrackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrackListResponse>(DoRPCRequest("GetTrackList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTrackListResponse> GetTrackListWithOptionsAsync(GetTrackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrackListResponse>(await DoRPCRequestAsync("GetTrackList", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTrackListResponse GetTrackList(GetTrackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrackListWithOptions(request, runtime);
        }

        public async Task<GetTrackListResponse> GetTrackListAsync(GetTrackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrackListWithOptionsAsync(request, runtime);
        }

        public GetTrackListByMailFromAndTagNameResponse GetTrackListByMailFromAndTagNameWithOptions(GetTrackListByMailFromAndTagNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrackListByMailFromAndTagNameResponse>(DoRPCRequest("GetTrackListByMailFromAndTagName", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTrackListByMailFromAndTagNameResponse> GetTrackListByMailFromAndTagNameWithOptionsAsync(GetTrackListByMailFromAndTagNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrackListByMailFromAndTagNameResponse>(await DoRPCRequestAsync("GetTrackListByMailFromAndTagName", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTrackListByMailFromAndTagNameResponse GetTrackListByMailFromAndTagName(GetTrackListByMailFromAndTagNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrackListByMailFromAndTagNameWithOptions(request, runtime);
        }

        public async Task<GetTrackListByMailFromAndTagNameResponse> GetTrackListByMailFromAndTagNameAsync(GetTrackListByMailFromAndTagNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrackListByMailFromAndTagNameWithOptionsAsync(request, runtime);
        }

        public MigrateMarketResponse MigrateMarketWithOptions(MigrateMarketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateMarketResponse>(DoRPCRequest("MigrateMarket", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MigrateMarketResponse> MigrateMarketWithOptionsAsync(MigrateMarketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MigrateMarketResponse>(await DoRPCRequestAsync("MigrateMarket", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MigrateMarketResponse MigrateMarket(MigrateMarketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateMarketWithOptions(request, runtime);
        }

        public async Task<MigrateMarketResponse> MigrateMarketAsync(MigrateMarketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateMarketWithOptionsAsync(request, runtime);
        }

        public ModifyAccountNotificationResponse ModifyAccountNotificationWithOptions(ModifyAccountNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountNotificationResponse>(DoRPCRequest("ModifyAccountNotification", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccountNotificationResponse> ModifyAccountNotificationWithOptionsAsync(ModifyAccountNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccountNotificationResponse>(await DoRPCRequestAsync("ModifyAccountNotification", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAccountNotificationResponse ModifyAccountNotification(ModifyAccountNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountNotificationWithOptions(request, runtime);
        }

        public async Task<ModifyAccountNotificationResponse> ModifyAccountNotificationAsync(ModifyAccountNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountNotificationWithOptionsAsync(request, runtime);
        }

        public ModifyMailAddressResponse ModifyMailAddressWithOptions(ModifyMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMailAddressResponse>(DoRPCRequest("ModifyMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMailAddressResponse> ModifyMailAddressWithOptionsAsync(ModifyMailAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMailAddressResponse>(await DoRPCRequestAsync("ModifyMailAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMailAddressResponse ModifyMailAddress(ModifyMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMailAddressWithOptions(request, runtime);
        }

        public async Task<ModifyMailAddressResponse> ModifyMailAddressAsync(ModifyMailAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMailAddressWithOptionsAsync(request, runtime);
        }

        public ModifyPWByDomainResponse ModifyPWByDomainWithOptions(ModifyPWByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPWByDomainResponse>(DoRPCRequest("ModifyPWByDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPWByDomainResponse> ModifyPWByDomainWithOptionsAsync(ModifyPWByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPWByDomainResponse>(await DoRPCRequestAsync("ModifyPWByDomain", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPWByDomainResponse ModifyPWByDomain(ModifyPWByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPWByDomainWithOptions(request, runtime);
        }

        public async Task<ModifyPWByDomainResponse> ModifyPWByDomainAsync(ModifyPWByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPWByDomainWithOptionsAsync(request, runtime);
        }

        public ModifySenderAddressNotificationResponse ModifySenderAddressNotificationWithOptions(ModifySenderAddressNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySenderAddressNotificationResponse>(DoRPCRequest("ModifySenderAddressNotification", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySenderAddressNotificationResponse> ModifySenderAddressNotificationWithOptionsAsync(ModifySenderAddressNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySenderAddressNotificationResponse>(await DoRPCRequestAsync("ModifySenderAddressNotification", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySenderAddressNotificationResponse ModifySenderAddressNotification(ModifySenderAddressNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySenderAddressNotificationWithOptions(request, runtime);
        }

        public async Task<ModifySenderAddressNotificationResponse> ModifySenderAddressNotificationAsync(ModifySenderAddressNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySenderAddressNotificationWithOptionsAsync(request, runtime);
        }

        public ModifyTagResponse ModifyTagWithOptions(ModifyTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTagResponse>(DoRPCRequest("ModifyTag", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTagResponse> ModifyTagWithOptionsAsync(ModifyTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTagResponse>(await DoRPCRequestAsync("ModifyTag", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTagResponse ModifyTag(ModifyTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTagWithOptions(request, runtime);
        }

        public async Task<ModifyTagResponse> ModifyTagAsync(ModifyTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTagWithOptionsAsync(request, runtime);
        }

        public ModifyTemplateResponse ModifyTemplateWithOptions(ModifyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTemplateResponse>(DoRPCRequest("ModifyTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTemplateResponse> ModifyTemplateWithOptionsAsync(ModifyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTemplateResponse>(await DoRPCRequestAsync("ModifyTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTemplateResponse ModifyTemplate(ModifyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTemplateWithOptions(request, runtime);
        }

        public async Task<ModifyTemplateResponse> ModifyTemplateAsync(ModifyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTemplateWithOptionsAsync(request, runtime);
        }

        public QueryDomainByParamResponse QueryDomainByParamWithOptions(QueryDomainByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainByParamResponse>(DoRPCRequest("QueryDomainByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainByParamResponse> QueryDomainByParamWithOptionsAsync(QueryDomainByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainByParamResponse>(await DoRPCRequestAsync("QueryDomainByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDomainByParamResponse QueryDomainByParam(QueryDomainByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByParamWithOptions(request, runtime);
        }

        public async Task<QueryDomainByParamResponse> QueryDomainByParamAsync(QueryDomainByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByParamWithOptionsAsync(request, runtime);
        }

        public QueryInvalidAddressResponse QueryInvalidAddressWithOptions(QueryInvalidAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInvalidAddressResponse>(DoRPCRequest("QueryInvalidAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryInvalidAddressResponse> QueryInvalidAddressWithOptionsAsync(QueryInvalidAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryInvalidAddressResponse>(await DoRPCRequestAsync("QueryInvalidAddress", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryInvalidAddressResponse QueryInvalidAddress(QueryInvalidAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInvalidAddressWithOptions(request, runtime);
        }

        public async Task<QueryInvalidAddressResponse> QueryInvalidAddressAsync(QueryInvalidAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInvalidAddressWithOptionsAsync(request, runtime);
        }

        public QueryReceiverByParamResponse QueryReceiverByParamWithOptions(QueryReceiverByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryReceiverByParamResponse>(DoRPCRequest("QueryReceiverByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryReceiverByParamResponse> QueryReceiverByParamWithOptionsAsync(QueryReceiverByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryReceiverByParamResponse>(await DoRPCRequestAsync("QueryReceiverByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryReceiverByParamResponse QueryReceiverByParam(QueryReceiverByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryReceiverByParamWithOptions(request, runtime);
        }

        public async Task<QueryReceiverByParamResponse> QueryReceiverByParamAsync(QueryReceiverByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryReceiverByParamWithOptionsAsync(request, runtime);
        }

        public QueryReceiverDetailResponse QueryReceiverDetailWithOptions(QueryReceiverDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryReceiverDetailResponse>(DoRPCRequest("QueryReceiverDetail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryReceiverDetailResponse> QueryReceiverDetailWithOptionsAsync(QueryReceiverDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryReceiverDetailResponse>(await DoRPCRequestAsync("QueryReceiverDetail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryReceiverDetailResponse QueryReceiverDetail(QueryReceiverDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryReceiverDetailWithOptions(request, runtime);
        }

        public async Task<QueryReceiverDetailResponse> QueryReceiverDetailAsync(QueryReceiverDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryReceiverDetailWithOptionsAsync(request, runtime);
        }

        public QuerySignByParamResponse QuerySignByParamWithOptions(QuerySignByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySignByParamResponse>(DoRPCRequest("QuerySignByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySignByParamResponse> QuerySignByParamWithOptionsAsync(QuerySignByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySignByParamResponse>(await DoRPCRequestAsync("QuerySignByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySignByParamResponse QuerySignByParam(QuerySignByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySignByParamWithOptions(request, runtime);
        }

        public async Task<QuerySignByParamResponse> QuerySignByParamAsync(QuerySignByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySignByParamWithOptionsAsync(request, runtime);
        }

        public QuerySmsStatisticsResponse QuerySmsStatisticsWithOptions(QuerySmsStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmsStatisticsResponse>(DoRPCRequest("QuerySmsStatistics", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySmsStatisticsResponse> QuerySmsStatisticsWithOptionsAsync(QuerySmsStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySmsStatisticsResponse>(await DoRPCRequestAsync("QuerySmsStatistics", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySmsStatisticsResponse QuerySmsStatistics(QuerySmsStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmsStatisticsWithOptions(request, runtime);
        }

        public async Task<QuerySmsStatisticsResponse> QuerySmsStatisticsAsync(QuerySmsStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmsStatisticsWithOptionsAsync(request, runtime);
        }

        public QueryTagByParamResponse QueryTagByParamWithOptions(QueryTagByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagByParamResponse>(DoRPCRequest("QueryTagByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTagByParamResponse> QueryTagByParamWithOptionsAsync(QueryTagByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagByParamResponse>(await DoRPCRequestAsync("QueryTagByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTagByParamResponse QueryTagByParam(QueryTagByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagByParamWithOptions(request, runtime);
        }

        public async Task<QueryTagByParamResponse> QueryTagByParamAsync(QueryTagByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagByParamWithOptionsAsync(request, runtime);
        }

        public QueryTaskByParamResponse QueryTaskByParamWithOptions(QueryTaskByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskByParamResponse>(DoRPCRequest("QueryTaskByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTaskByParamResponse> QueryTaskByParamWithOptionsAsync(QueryTaskByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskByParamResponse>(await DoRPCRequestAsync("QueryTaskByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTaskByParamResponse QueryTaskByParam(QueryTaskByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskByParamWithOptions(request, runtime);
        }

        public async Task<QueryTaskByParamResponse> QueryTaskByParamAsync(QueryTaskByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskByParamWithOptionsAsync(request, runtime);
        }

        public QueryTemplateByParamResponse QueryTemplateByParamWithOptions(QueryTemplateByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTemplateByParamResponse>(DoRPCRequest("QueryTemplateByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTemplateByParamResponse> QueryTemplateByParamWithOptionsAsync(QueryTemplateByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTemplateByParamResponse>(await DoRPCRequestAsync("QueryTemplateByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTemplateByParamResponse QueryTemplateByParam(QueryTemplateByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTemplateByParamWithOptions(request, runtime);
        }

        public async Task<QueryTemplateByParamResponse> QueryTemplateByParamAsync(QueryTemplateByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTemplateByParamWithOptionsAsync(request, runtime);
        }

        public SaveReceiverDetailResponse SaveReceiverDetailWithOptions(SaveReceiverDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveReceiverDetailResponse>(DoRPCRequest("SaveReceiverDetail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveReceiverDetailResponse> SaveReceiverDetailWithOptionsAsync(SaveReceiverDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveReceiverDetailResponse>(await DoRPCRequestAsync("SaveReceiverDetail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveReceiverDetailResponse SaveReceiverDetail(SaveReceiverDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveReceiverDetailWithOptions(request, runtime);
        }

        public async Task<SaveReceiverDetailResponse> SaveReceiverDetailAsync(SaveReceiverDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveReceiverDetailWithOptionsAsync(request, runtime);
        }

        public SenderStatisticsByTagNameAndBatchIDResponse SenderStatisticsByTagNameAndBatchIDWithOptions(SenderStatisticsByTagNameAndBatchIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SenderStatisticsByTagNameAndBatchIDResponse>(DoRPCRequest("SenderStatisticsByTagNameAndBatchID", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SenderStatisticsByTagNameAndBatchIDResponse> SenderStatisticsByTagNameAndBatchIDWithOptionsAsync(SenderStatisticsByTagNameAndBatchIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SenderStatisticsByTagNameAndBatchIDResponse>(await DoRPCRequestAsync("SenderStatisticsByTagNameAndBatchID", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SenderStatisticsByTagNameAndBatchIDResponse SenderStatisticsByTagNameAndBatchID(SenderStatisticsByTagNameAndBatchIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SenderStatisticsByTagNameAndBatchIDWithOptions(request, runtime);
        }

        public async Task<SenderStatisticsByTagNameAndBatchIDResponse> SenderStatisticsByTagNameAndBatchIDAsync(SenderStatisticsByTagNameAndBatchIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SenderStatisticsByTagNameAndBatchIDWithOptionsAsync(request, runtime);
        }

        public SenderStatisticsDetailByParamResponse SenderStatisticsDetailByParamWithOptions(SenderStatisticsDetailByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SenderStatisticsDetailByParamResponse>(DoRPCRequest("SenderStatisticsDetailByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SenderStatisticsDetailByParamResponse> SenderStatisticsDetailByParamWithOptionsAsync(SenderStatisticsDetailByParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SenderStatisticsDetailByParamResponse>(await DoRPCRequestAsync("SenderStatisticsDetailByParam", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SenderStatisticsDetailByParamResponse SenderStatisticsDetailByParam(SenderStatisticsDetailByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SenderStatisticsDetailByParamWithOptions(request, runtime);
        }

        public async Task<SenderStatisticsDetailByParamResponse> SenderStatisticsDetailByParamAsync(SenderStatisticsDetailByParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SenderStatisticsDetailByParamWithOptionsAsync(request, runtime);
        }

        public SendTestByTemplateResponse SendTestByTemplateWithOptions(SendTestByTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendTestByTemplateResponse>(DoRPCRequest("SendTestByTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendTestByTemplateResponse> SendTestByTemplateWithOptionsAsync(SendTestByTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendTestByTemplateResponse>(await DoRPCRequestAsync("SendTestByTemplate", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendTestByTemplateResponse SendTestByTemplate(SendTestByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendTestByTemplateWithOptions(request, runtime);
        }

        public async Task<SendTestByTemplateResponse> SendTestByTemplateAsync(SendTestByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendTestByTemplateWithOptionsAsync(request, runtime);
        }

        public SingleSendMailResponse SingleSendMailWithOptions(SingleSendMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleSendMailResponse>(DoRPCRequest("SingleSendMail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SingleSendMailResponse> SingleSendMailWithOptionsAsync(SingleSendMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleSendMailResponse>(await DoRPCRequestAsync("SingleSendMail", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SingleSendMailResponse SingleSendMail(SingleSendMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleSendMailWithOptions(request, runtime);
        }

        public async Task<SingleSendMailResponse> SingleSendMailAsync(SingleSendMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleSendMailWithOptionsAsync(request, runtime);
        }

        public SingleSendSmsResponse SingleSendSmsWithOptions(SingleSendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleSendSmsResponse>(DoRPCRequest("SingleSendSms", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SingleSendSmsResponse> SingleSendSmsWithOptionsAsync(SingleSendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleSendSmsResponse>(await DoRPCRequestAsync("SingleSendSms", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SingleSendSmsResponse SingleSendSms(SingleSendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleSendSmsWithOptions(request, runtime);
        }

        public async Task<SingleSendSmsResponse> SingleSendSmsAsync(SingleSendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleSendSmsWithOptionsAsync(request, runtime);
        }

        public UpdateDomainTrackNameResponse UpdateDomainTrackNameWithOptions(UpdateDomainTrackNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainTrackNameResponse>(DoRPCRequest("UpdateDomainTrackName", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDomainTrackNameResponse> UpdateDomainTrackNameWithOptionsAsync(UpdateDomainTrackNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainTrackNameResponse>(await DoRPCRequestAsync("UpdateDomainTrackName", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDomainTrackNameResponse UpdateDomainTrackName(UpdateDomainTrackNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainTrackNameWithOptions(request, runtime);
        }

        public async Task<UpdateDomainTrackNameResponse> UpdateDomainTrackNameAsync(UpdateDomainTrackNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainTrackNameWithOptionsAsync(request, runtime);
        }

        public UpdateIpProtectionResponse UpdateIpProtectionWithOptions(UpdateIpProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpProtectionResponse>(DoRPCRequest("UpdateIpProtection", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateIpProtectionResponse> UpdateIpProtectionWithOptionsAsync(UpdateIpProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpProtectionResponse>(await DoRPCRequestAsync("UpdateIpProtection", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateIpProtectionResponse UpdateIpProtection(UpdateIpProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpProtectionWithOptions(request, runtime);
        }

        public async Task<UpdateIpProtectionResponse> UpdateIpProtectionAsync(UpdateIpProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpProtectionWithOptionsAsync(request, runtime);
        }

        public UpdateMailAddressMsgCallBackUrlResponse UpdateMailAddressMsgCallBackUrlWithOptions(UpdateMailAddressMsgCallBackUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMailAddressMsgCallBackUrlResponse>(DoRPCRequest("UpdateMailAddressMsgCallBackUrl", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMailAddressMsgCallBackUrlResponse> UpdateMailAddressMsgCallBackUrlWithOptionsAsync(UpdateMailAddressMsgCallBackUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMailAddressMsgCallBackUrlResponse>(await DoRPCRequestAsync("UpdateMailAddressMsgCallBackUrl", "2015-11-23", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMailAddressMsgCallBackUrlResponse UpdateMailAddressMsgCallBackUrl(UpdateMailAddressMsgCallBackUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMailAddressMsgCallBackUrlWithOptions(request, runtime);
        }

        public async Task<UpdateMailAddressMsgCallBackUrlResponse> UpdateMailAddressMsgCallBackUrlAsync(UpdateMailAddressMsgCallBackUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMailAddressMsgCallBackUrlWithOptionsAsync(request, runtime);
        }

    }
}
