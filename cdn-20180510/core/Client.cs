// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cdn20180510.Models;

namespace AlibabaCloud.SDK.Cdn20180510
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "cdn.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "cdn.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "cdn.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "cdn.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cdn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddCdnDomainResponse AddCdnDomainWithOptions(AddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCdnDomainResponse>(DoRPCRequest("AddCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCdnDomainResponse> AddCdnDomainWithOptionsAsync(AddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCdnDomainResponse>(await DoRPCRequestAsync("AddCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCdnDomainResponse AddCdnDomain(AddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCdnDomainWithOptions(request, runtime);
        }

        public async Task<AddCdnDomainResponse> AddCdnDomainAsync(AddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCdnDomainWithOptionsAsync(request, runtime);
        }

        public AddFCTriggerResponse AddFCTriggerWithOptions(AddFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFCTriggerResponse>(DoRPCRequest("AddFCTrigger", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFCTriggerResponse> AddFCTriggerWithOptionsAsync(AddFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFCTriggerResponse>(await DoRPCRequestAsync("AddFCTrigger", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddFCTriggerResponse AddFCTrigger(AddFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFCTriggerWithOptions(request, runtime);
        }

        public async Task<AddFCTriggerResponse> AddFCTriggerAsync(AddFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFCTriggerWithOptionsAsync(request, runtime);
        }

        public BatchAddCdnDomainResponse BatchAddCdnDomainWithOptions(BatchAddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAddCdnDomainResponse>(DoRPCRequest("BatchAddCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchAddCdnDomainResponse> BatchAddCdnDomainWithOptionsAsync(BatchAddCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAddCdnDomainResponse>(await DoRPCRequestAsync("BatchAddCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchAddCdnDomainResponse BatchAddCdnDomain(BatchAddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddCdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchAddCdnDomainResponse> BatchAddCdnDomainAsync(BatchAddCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddCdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchSetCdnDomainConfigResponse BatchSetCdnDomainConfigWithOptions(BatchSetCdnDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetCdnDomainConfigResponse>(DoRPCRequest("BatchSetCdnDomainConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetCdnDomainConfigResponse> BatchSetCdnDomainConfigWithOptionsAsync(BatchSetCdnDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetCdnDomainConfigResponse>(await DoRPCRequestAsync("BatchSetCdnDomainConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetCdnDomainConfigResponse BatchSetCdnDomainConfig(BatchSetCdnDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetCdnDomainConfigWithOptions(request, runtime);
        }

        public async Task<BatchSetCdnDomainConfigResponse> BatchSetCdnDomainConfigAsync(BatchSetCdnDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetCdnDomainConfigWithOptionsAsync(request, runtime);
        }

        public BatchSetCdnDomainServerCertificateResponse BatchSetCdnDomainServerCertificateWithOptions(BatchSetCdnDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetCdnDomainServerCertificateResponse>(DoRPCRequest("BatchSetCdnDomainServerCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetCdnDomainServerCertificateResponse> BatchSetCdnDomainServerCertificateWithOptionsAsync(BatchSetCdnDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetCdnDomainServerCertificateResponse>(await DoRPCRequestAsync("BatchSetCdnDomainServerCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetCdnDomainServerCertificateResponse BatchSetCdnDomainServerCertificate(BatchSetCdnDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetCdnDomainServerCertificateWithOptions(request, runtime);
        }

        public async Task<BatchSetCdnDomainServerCertificateResponse> BatchSetCdnDomainServerCertificateAsync(BatchSetCdnDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetCdnDomainServerCertificateWithOptionsAsync(request, runtime);
        }

        public BatchStartCdnDomainResponse BatchStartCdnDomainWithOptions(BatchStartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartCdnDomainResponse>(DoRPCRequest("BatchStartCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStartCdnDomainResponse> BatchStartCdnDomainWithOptionsAsync(BatchStartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartCdnDomainResponse>(await DoRPCRequestAsync("BatchStartCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStartCdnDomainResponse BatchStartCdnDomain(BatchStartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartCdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchStartCdnDomainResponse> BatchStartCdnDomainAsync(BatchStartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartCdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchStopCdnDomainResponse BatchStopCdnDomainWithOptions(BatchStopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopCdnDomainResponse>(DoRPCRequest("BatchStopCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStopCdnDomainResponse> BatchStopCdnDomainWithOptionsAsync(BatchStopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopCdnDomainResponse>(await DoRPCRequestAsync("BatchStopCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStopCdnDomainResponse BatchStopCdnDomain(BatchStopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopCdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchStopCdnDomainResponse> BatchStopCdnDomainAsync(BatchStopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopCdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchUpdateCdnDomainResponse BatchUpdateCdnDomainWithOptions(BatchUpdateCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUpdateCdnDomainResponse>(DoRPCRequest("BatchUpdateCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUpdateCdnDomainResponse> BatchUpdateCdnDomainWithOptionsAsync(BatchUpdateCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUpdateCdnDomainResponse>(await DoRPCRequestAsync("BatchUpdateCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUpdateCdnDomainResponse BatchUpdateCdnDomain(BatchUpdateCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateCdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchUpdateCdnDomainResponse> BatchUpdateCdnDomainAsync(BatchUpdateCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateCdnDomainWithOptionsAsync(request, runtime);
        }

        public CreateCdnCertificateSigningRequestResponse CreateCdnCertificateSigningRequestWithOptions(CreateCdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCdnCertificateSigningRequestResponse>(DoRPCRequest("CreateCdnCertificateSigningRequest", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCdnCertificateSigningRequestResponse> CreateCdnCertificateSigningRequestWithOptionsAsync(CreateCdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCdnCertificateSigningRequestResponse>(await DoRPCRequestAsync("CreateCdnCertificateSigningRequest", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCdnCertificateSigningRequestResponse CreateCdnCertificateSigningRequest(CreateCdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCdnCertificateSigningRequestWithOptions(request, runtime);
        }

        public async Task<CreateCdnCertificateSigningRequestResponse> CreateCdnCertificateSigningRequestAsync(CreateCdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCdnCertificateSigningRequestWithOptionsAsync(request, runtime);
        }

        public CreateIllegalUrlExportTaskResponse CreateIllegalUrlExportTaskWithOptions(CreateIllegalUrlExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIllegalUrlExportTaskResponse>(DoRPCRequest("CreateIllegalUrlExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIllegalUrlExportTaskResponse> CreateIllegalUrlExportTaskWithOptionsAsync(CreateIllegalUrlExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIllegalUrlExportTaskResponse>(await DoRPCRequestAsync("CreateIllegalUrlExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIllegalUrlExportTaskResponse CreateIllegalUrlExportTask(CreateIllegalUrlExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIllegalUrlExportTaskWithOptions(request, runtime);
        }

        public async Task<CreateIllegalUrlExportTaskResponse> CreateIllegalUrlExportTaskAsync(CreateIllegalUrlExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIllegalUrlExportTaskWithOptionsAsync(request, runtime);
        }

        public CreateRealTimeLogDeliveryResponse CreateRealTimeLogDeliveryWithOptions(CreateRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateRealTimeLogDeliveryResponse>(DoRPCRequest("CreateRealTimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateRealTimeLogDeliveryResponse> CreateRealTimeLogDeliveryWithOptionsAsync(CreateRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateRealTimeLogDeliveryResponse>(await DoRPCRequestAsync("CreateRealTimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateRealTimeLogDeliveryResponse CreateRealTimeLogDelivery(CreateRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRealTimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<CreateRealTimeLogDeliveryResponse> CreateRealTimeLogDeliveryAsync(CreateRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRealTimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public CreateUsageDetailDataExportTaskResponse CreateUsageDetailDataExportTaskWithOptions(CreateUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUsageDetailDataExportTaskResponse>(DoRPCRequest("CreateUsageDetailDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUsageDetailDataExportTaskResponse> CreateUsageDetailDataExportTaskWithOptionsAsync(CreateUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUsageDetailDataExportTaskResponse>(await DoRPCRequestAsync("CreateUsageDetailDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUsageDetailDataExportTaskResponse CreateUsageDetailDataExportTask(CreateUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsageDetailDataExportTaskWithOptions(request, runtime);
        }

        public async Task<CreateUsageDetailDataExportTaskResponse> CreateUsageDetailDataExportTaskAsync(CreateUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsageDetailDataExportTaskWithOptionsAsync(request, runtime);
        }

        public CreateUserUsageDataExportTaskResponse CreateUserUsageDataExportTaskWithOptions(CreateUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserUsageDataExportTaskResponse>(DoRPCRequest("CreateUserUsageDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserUsageDataExportTaskResponse> CreateUserUsageDataExportTaskWithOptionsAsync(CreateUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserUsageDataExportTaskResponse>(await DoRPCRequestAsync("CreateUserUsageDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserUsageDataExportTaskResponse CreateUserUsageDataExportTask(CreateUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserUsageDataExportTaskWithOptions(request, runtime);
        }

        public async Task<CreateUserUsageDataExportTaskResponse> CreateUserUsageDataExportTaskAsync(CreateUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserUsageDataExportTaskWithOptionsAsync(request, runtime);
        }

        public DeleteCdnDomainResponse DeleteCdnDomainWithOptions(DeleteCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCdnDomainResponse>(DoRPCRequest("DeleteCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCdnDomainResponse> DeleteCdnDomainWithOptionsAsync(DeleteCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCdnDomainResponse>(await DoRPCRequestAsync("DeleteCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCdnDomainResponse DeleteCdnDomain(DeleteCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCdnDomainWithOptions(request, runtime);
        }

        public async Task<DeleteCdnDomainResponse> DeleteCdnDomainAsync(DeleteCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCdnDomainWithOptionsAsync(request, runtime);
        }

        public DeleteFCTriggerResponse DeleteFCTriggerWithOptions(DeleteFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFCTriggerResponse>(DoRPCRequest("DeleteFCTrigger", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFCTriggerResponse> DeleteFCTriggerWithOptionsAsync(DeleteFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFCTriggerResponse>(await DoRPCRequestAsync("DeleteFCTrigger", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFCTriggerResponse DeleteFCTrigger(DeleteFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFCTriggerWithOptions(request, runtime);
        }

        public async Task<DeleteFCTriggerResponse> DeleteFCTriggerAsync(DeleteFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFCTriggerWithOptionsAsync(request, runtime);
        }

        public DeleteRealtimeLogDeliveryResponse DeleteRealtimeLogDeliveryWithOptions(DeleteRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteRealtimeLogDeliveryResponse>(DoRPCRequest("DeleteRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteRealtimeLogDeliveryResponse> DeleteRealtimeLogDeliveryWithOptionsAsync(DeleteRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("DeleteRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteRealtimeLogDeliveryResponse DeleteRealtimeLogDelivery(DeleteRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DeleteRealtimeLogDeliveryResponse> DeleteRealtimeLogDeliveryAsync(DeleteRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DeleteSpecificConfigResponse DeleteSpecificConfigWithOptions(DeleteSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSpecificConfigResponse>(DoRPCRequest("DeleteSpecificConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSpecificConfigResponse> DeleteSpecificConfigWithOptionsAsync(DeleteSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSpecificConfigResponse>(await DoRPCRequestAsync("DeleteSpecificConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSpecificConfigResponse DeleteSpecificConfig(DeleteSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteSpecificConfigResponse> DeleteSpecificConfigAsync(DeleteSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteSpecificStagingConfigResponse DeleteSpecificStagingConfigWithOptions(DeleteSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSpecificStagingConfigResponse>(DoRPCRequest("DeleteSpecificStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSpecificStagingConfigResponse> DeleteSpecificStagingConfigWithOptionsAsync(DeleteSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSpecificStagingConfigResponse>(await DoRPCRequestAsync("DeleteSpecificStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSpecificStagingConfigResponse DeleteSpecificStagingConfig(DeleteSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpecificStagingConfigWithOptions(request, runtime);
        }

        public async Task<DeleteSpecificStagingConfigResponse> DeleteSpecificStagingConfigAsync(DeleteSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpecificStagingConfigWithOptionsAsync(request, runtime);
        }

        public DeleteUsageDetailDataExportTaskResponse DeleteUsageDetailDataExportTaskWithOptions(DeleteUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUsageDetailDataExportTaskResponse>(DoRPCRequest("DeleteUsageDetailDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUsageDetailDataExportTaskResponse> DeleteUsageDetailDataExportTaskWithOptionsAsync(DeleteUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUsageDetailDataExportTaskResponse>(await DoRPCRequestAsync("DeleteUsageDetailDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUsageDetailDataExportTaskResponse DeleteUsageDetailDataExportTask(DeleteUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUsageDetailDataExportTaskWithOptions(request, runtime);
        }

        public async Task<DeleteUsageDetailDataExportTaskResponse> DeleteUsageDetailDataExportTaskAsync(DeleteUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUsageDetailDataExportTaskWithOptionsAsync(request, runtime);
        }

        public DeleteUserUsageDataExportTaskResponse DeleteUserUsageDataExportTaskWithOptions(DeleteUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserUsageDataExportTaskResponse>(DoRPCRequest("DeleteUserUsageDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserUsageDataExportTaskResponse> DeleteUserUsageDataExportTaskWithOptionsAsync(DeleteUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserUsageDataExportTaskResponse>(await DoRPCRequestAsync("DeleteUserUsageDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserUsageDataExportTaskResponse DeleteUserUsageDataExportTask(DeleteUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserUsageDataExportTaskWithOptions(request, runtime);
        }

        public async Task<DeleteUserUsageDataExportTaskResponse> DeleteUserUsageDataExportTaskAsync(DeleteUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserUsageDataExportTaskWithOptionsAsync(request, runtime);
        }

        public DescribeActiveVersionOfConfigGroupResponse DescribeActiveVersionOfConfigGroupWithOptions(DescribeActiveVersionOfConfigGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeActiveVersionOfConfigGroupResponse>(DoRPCRequest("DescribeActiveVersionOfConfigGroup", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeActiveVersionOfConfigGroupResponse> DescribeActiveVersionOfConfigGroupWithOptionsAsync(DescribeActiveVersionOfConfigGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeActiveVersionOfConfigGroupResponse>(await DoRPCRequestAsync("DescribeActiveVersionOfConfigGroup", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeActiveVersionOfConfigGroupResponse DescribeActiveVersionOfConfigGroup(DescribeActiveVersionOfConfigGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveVersionOfConfigGroupWithOptions(request, runtime);
        }

        public async Task<DescribeActiveVersionOfConfigGroupResponse> DescribeActiveVersionOfConfigGroupAsync(DescribeActiveVersionOfConfigGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveVersionOfConfigGroupWithOptionsAsync(request, runtime);
        }

        public DescribeCdnCertificateDetailResponse DescribeCdnCertificateDetailWithOptions(DescribeCdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnCertificateDetailResponse>(DoRPCRequest("DescribeCdnCertificateDetail", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnCertificateDetailResponse> DescribeCdnCertificateDetailWithOptionsAsync(DescribeCdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnCertificateDetailResponse>(await DoRPCRequestAsync("DescribeCdnCertificateDetail", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnCertificateDetailResponse DescribeCdnCertificateDetail(DescribeCdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeCdnCertificateDetailResponse> DescribeCdnCertificateDetailAsync(DescribeCdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeCdnCertificateListResponse DescribeCdnCertificateListWithOptions(DescribeCdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnCertificateListResponse>(DoRPCRequest("DescribeCdnCertificateList", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnCertificateListResponse> DescribeCdnCertificateListWithOptionsAsync(DescribeCdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnCertificateListResponse>(await DoRPCRequestAsync("DescribeCdnCertificateList", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnCertificateListResponse DescribeCdnCertificateList(DescribeCdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeCdnCertificateListResponse> DescribeCdnCertificateListAsync(DescribeCdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeCdnDomainByCertificateResponse DescribeCdnDomainByCertificateWithOptions(DescribeCdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainByCertificateResponse>(DoRPCRequest("DescribeCdnDomainByCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnDomainByCertificateResponse> DescribeCdnDomainByCertificateWithOptionsAsync(DescribeCdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainByCertificateResponse>(await DoRPCRequestAsync("DescribeCdnDomainByCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnDomainByCertificateResponse DescribeCdnDomainByCertificate(DescribeCdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainByCertificateWithOptions(request, runtime);
        }

        public async Task<DescribeCdnDomainByCertificateResponse> DescribeCdnDomainByCertificateAsync(DescribeCdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainByCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeCdnDomainConfigsResponse DescribeCdnDomainConfigsWithOptions(DescribeCdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainConfigsResponse>(DoRPCRequest("DescribeCdnDomainConfigs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnDomainConfigsResponse> DescribeCdnDomainConfigsWithOptionsAsync(DescribeCdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainConfigsResponse>(await DoRPCRequestAsync("DescribeCdnDomainConfigs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnDomainConfigsResponse DescribeCdnDomainConfigs(DescribeCdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeCdnDomainConfigsResponse> DescribeCdnDomainConfigsAsync(DescribeCdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeCdnDomainDetailResponse DescribeCdnDomainDetailWithOptions(DescribeCdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainDetailResponse>(DoRPCRequest("DescribeCdnDomainDetail", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnDomainDetailResponse> DescribeCdnDomainDetailWithOptionsAsync(DescribeCdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainDetailResponse>(await DoRPCRequestAsync("DescribeCdnDomainDetail", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnDomainDetailResponse DescribeCdnDomainDetail(DescribeCdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeCdnDomainDetailResponse> DescribeCdnDomainDetailAsync(DescribeCdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsWithOptions(DescribeCdnDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainLogsResponse>(DoRPCRequest("DescribeCdnDomainLogs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogsWithOptionsAsync(DescribeCdnDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainLogsResponse>(await DoRPCRequestAsync("DescribeCdnDomainLogs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainLogsWithOptions(request, runtime);
        }

        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogsAsync(DescribeCdnDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainLogsWithOptionsAsync(request, runtime);
        }

        public DescribeCdnDomainStagingConfigResponse DescribeCdnDomainStagingConfigWithOptions(DescribeCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainStagingConfigResponse>(DoRPCRequest("DescribeCdnDomainStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnDomainStagingConfigResponse> DescribeCdnDomainStagingConfigWithOptionsAsync(DescribeCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnDomainStagingConfigResponse>(await DoRPCRequestAsync("DescribeCdnDomainStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnDomainStagingConfigResponse DescribeCdnDomainStagingConfig(DescribeCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnDomainStagingConfigWithOptions(request, runtime);
        }

        public async Task<DescribeCdnDomainStagingConfigResponse> DescribeCdnDomainStagingConfigAsync(DescribeCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        public DescribeCdnHttpsDomainListResponse DescribeCdnHttpsDomainListWithOptions(DescribeCdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnHttpsDomainListResponse>(DoRPCRequest("DescribeCdnHttpsDomainList", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnHttpsDomainListResponse> DescribeCdnHttpsDomainListWithOptionsAsync(DescribeCdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnHttpsDomainListResponse>(await DoRPCRequestAsync("DescribeCdnHttpsDomainList", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnHttpsDomainListResponse DescribeCdnHttpsDomainList(DescribeCdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnHttpsDomainListWithOptions(request, runtime);
        }

        public async Task<DescribeCdnHttpsDomainListResponse> DescribeCdnHttpsDomainListAsync(DescribeCdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnHttpsDomainListWithOptionsAsync(request, runtime);
        }

        public DescribeCdnRegionAndIspResponse DescribeCdnRegionAndIspWithOptions(DescribeCdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnRegionAndIspResponse>(DoRPCRequest("DescribeCdnRegionAndIsp", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnRegionAndIspResponse> DescribeCdnRegionAndIspWithOptionsAsync(DescribeCdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnRegionAndIspResponse>(await DoRPCRequestAsync("DescribeCdnRegionAndIsp", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnRegionAndIspResponse DescribeCdnRegionAndIsp(DescribeCdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnRegionAndIspWithOptions(request, runtime);
        }

        public async Task<DescribeCdnRegionAndIspResponse> DescribeCdnRegionAndIspAsync(DescribeCdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnRegionAndIspWithOptionsAsync(request, runtime);
        }

        public DescribeCdnServiceResponse DescribeCdnServiceWithOptions(DescribeCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnServiceResponse>(DoRPCRequest("DescribeCdnService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnServiceResponse> DescribeCdnServiceWithOptionsAsync(DescribeCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnServiceResponse>(await DoRPCRequestAsync("DescribeCdnService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnServiceResponse DescribeCdnService(DescribeCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnServiceWithOptions(request, runtime);
        }

        public async Task<DescribeCdnServiceResponse> DescribeCdnServiceAsync(DescribeCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnServiceWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserBillHistoryResponse DescribeCdnUserBillHistoryWithOptions(DescribeCdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserBillHistoryResponse>(DoRPCRequest("DescribeCdnUserBillHistory", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserBillHistoryResponse> DescribeCdnUserBillHistoryWithOptionsAsync(DescribeCdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserBillHistoryResponse>(await DoRPCRequestAsync("DescribeCdnUserBillHistory", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserBillHistoryResponse DescribeCdnUserBillHistory(DescribeCdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserBillHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserBillHistoryResponse> DescribeCdnUserBillHistoryAsync(DescribeCdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserBillHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserBillPredictionResponse DescribeCdnUserBillPredictionWithOptions(DescribeCdnUserBillPredictionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserBillPredictionResponse>(DoRPCRequest("DescribeCdnUserBillPrediction", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserBillPredictionResponse> DescribeCdnUserBillPredictionWithOptionsAsync(DescribeCdnUserBillPredictionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserBillPredictionResponse>(await DoRPCRequestAsync("DescribeCdnUserBillPrediction", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserBillPredictionResponse DescribeCdnUserBillPrediction(DescribeCdnUserBillPredictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserBillPredictionWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserBillPredictionResponse> DescribeCdnUserBillPredictionAsync(DescribeCdnUserBillPredictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserBillPredictionWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserBillTypeResponse DescribeCdnUserBillTypeWithOptions(DescribeCdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserBillTypeResponse>(DoRPCRequest("DescribeCdnUserBillType", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserBillTypeResponse> DescribeCdnUserBillTypeWithOptionsAsync(DescribeCdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserBillTypeResponse>(await DoRPCRequestAsync("DescribeCdnUserBillType", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserBillTypeResponse DescribeCdnUserBillType(DescribeCdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserBillTypeWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserBillTypeResponse> DescribeCdnUserBillTypeAsync(DescribeCdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserBillTypeWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserConfigsResponse DescribeCdnUserConfigsWithOptions(DescribeCdnUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserConfigsResponse>(DoRPCRequest("DescribeCdnUserConfigs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserConfigsResponse> DescribeCdnUserConfigsWithOptionsAsync(DescribeCdnUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserConfigsResponse>(await DoRPCRequestAsync("DescribeCdnUserConfigs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserConfigsResponse DescribeCdnUserConfigs(DescribeCdnUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserConfigsResponse> DescribeCdnUserConfigsAsync(DescribeCdnUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserDomainsByFuncResponse DescribeCdnUserDomainsByFuncWithOptions(DescribeCdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserDomainsByFuncResponse>(DoRPCRequest("DescribeCdnUserDomainsByFunc", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserDomainsByFuncResponse> DescribeCdnUserDomainsByFuncWithOptionsAsync(DescribeCdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserDomainsByFuncResponse>(await DoRPCRequestAsync("DescribeCdnUserDomainsByFunc", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserDomainsByFuncResponse DescribeCdnUserDomainsByFunc(DescribeCdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserDomainsByFuncWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserDomainsByFuncResponse> DescribeCdnUserDomainsByFuncAsync(DescribeCdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserDomainsByFuncWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserQuotaResponse DescribeCdnUserQuotaWithOptions(DescribeCdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserQuotaResponse>(DoRPCRequest("DescribeCdnUserQuota", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserQuotaResponse> DescribeCdnUserQuotaWithOptionsAsync(DescribeCdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserQuotaResponse>(await DoRPCRequestAsync("DescribeCdnUserQuota", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserQuotaResponse DescribeCdnUserQuota(DescribeCdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserQuotaResponse> DescribeCdnUserQuotaAsync(DescribeCdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeCdnUserResourcePackageResponse DescribeCdnUserResourcePackageWithOptions(DescribeCdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserResourcePackageResponse>(DoRPCRequest("DescribeCdnUserResourcePackage", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnUserResourcePackageResponse> DescribeCdnUserResourcePackageWithOptionsAsync(DescribeCdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnUserResourcePackageResponse>(await DoRPCRequestAsync("DescribeCdnUserResourcePackage", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnUserResourcePackageResponse DescribeCdnUserResourcePackage(DescribeCdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnUserResourcePackageWithOptions(request, runtime);
        }

        public async Task<DescribeCdnUserResourcePackageResponse> DescribeCdnUserResourcePackageAsync(DescribeCdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnUserResourcePackageWithOptionsAsync(request, runtime);
        }

        public DescribeCdnWafDomainResponse DescribeCdnWafDomainWithOptions(DescribeCdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnWafDomainResponse>(DoRPCRequest("DescribeCdnWafDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCdnWafDomainResponse> DescribeCdnWafDomainWithOptionsAsync(DescribeCdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCdnWafDomainResponse>(await DoRPCRequestAsync("DescribeCdnWafDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCdnWafDomainResponse DescribeCdnWafDomain(DescribeCdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCdnWafDomainWithOptions(request, runtime);
        }

        public async Task<DescribeCdnWafDomainResponse> DescribeCdnWafDomainAsync(DescribeCdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCdnWafDomainWithOptionsAsync(request, runtime);
        }

        public DescribeCertificateInfoByIDResponse DescribeCertificateInfoByIDWithOptions(DescribeCertificateInfoByIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeCertificateInfoByIDResponse>(DoRPCRequest("DescribeCertificateInfoByID", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeCertificateInfoByIDResponse> DescribeCertificateInfoByIDWithOptionsAsync(DescribeCertificateInfoByIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeCertificateInfoByIDResponse>(await DoRPCRequestAsync("DescribeCertificateInfoByID", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeCertificateInfoByIDResponse DescribeCertificateInfoByID(DescribeCertificateInfoByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateInfoByIDWithOptions(request, runtime);
        }

        public async Task<DescribeCertificateInfoByIDResponse> DescribeCertificateInfoByIDAsync(DescribeCertificateInfoByIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateInfoByIDWithOptionsAsync(request, runtime);
        }

        public DescribeConfigOfVersionResponse DescribeConfigOfVersionWithOptions(DescribeConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConfigOfVersionResponse>(DoRPCRequest("DescribeConfigOfVersion", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConfigOfVersionResponse> DescribeConfigOfVersionWithOptionsAsync(DescribeConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConfigOfVersionResponse>(await DoRPCRequestAsync("DescribeConfigOfVersion", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConfigOfVersionResponse DescribeConfigOfVersion(DescribeConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConfigOfVersionWithOptions(request, runtime);
        }

        public async Task<DescribeConfigOfVersionResponse> DescribeConfigOfVersionAsync(DescribeConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConfigOfVersionWithOptionsAsync(request, runtime);
        }

        public DescribeCustomLogConfigResponse DescribeCustomLogConfigWithOptions(DescribeCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeCustomLogConfigResponse>(DoRPCRequest("DescribeCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomLogConfigResponse> DescribeCustomLogConfigWithOptionsAsync(DescribeCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeCustomLogConfigResponse>(await DoRPCRequestAsync("DescribeCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeCustomLogConfigResponse DescribeCustomLogConfig(DescribeCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomLogConfigWithOptions(request, runtime);
        }

        public async Task<DescribeCustomLogConfigResponse> DescribeCustomLogConfigAsync(DescribeCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomLogConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDomainAverageResponseTimeResponse DescribeDomainAverageResponseTimeWithOptions(DescribeDomainAverageResponseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAverageResponseTimeResponse>(DoRPCRequest("DescribeDomainAverageResponseTime", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainAverageResponseTimeResponse> DescribeDomainAverageResponseTimeWithOptionsAsync(DescribeDomainAverageResponseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAverageResponseTimeResponse>(await DoRPCRequestAsync("DescribeDomainAverageResponseTime", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainAverageResponseTimeResponse DescribeDomainAverageResponseTime(DescribeDomainAverageResponseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAverageResponseTimeWithOptions(request, runtime);
        }

        public async Task<DescribeDomainAverageResponseTimeResponse> DescribeDomainAverageResponseTimeAsync(DescribeDomainAverageResponseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAverageResponseTimeWithOptionsAsync(request, runtime);
        }

        public DescribeDomainBpsDataResponse DescribeDomainBpsDataWithOptions(DescribeDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBpsDataResponse>(DoRPCRequest("DescribeDomainBpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainBpsDataResponse> DescribeDomainBpsDataWithOptionsAsync(DescribeDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBpsDataResponse>(await DoRPCRequestAsync("DescribeDomainBpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainBpsDataResponse DescribeDomainBpsData(DescribeDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainBpsDataResponse> DescribeDomainBpsDataAsync(DescribeDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainBpsDataByLayerResponse DescribeDomainBpsDataByLayerWithOptions(DescribeDomainBpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByLayerResponse>(DoRPCRequest("DescribeDomainBpsDataByLayer", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainBpsDataByLayerResponse> DescribeDomainBpsDataByLayerWithOptionsAsync(DescribeDomainBpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByLayerResponse>(await DoRPCRequestAsync("DescribeDomainBpsDataByLayer", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainBpsDataByLayerResponse DescribeDomainBpsDataByLayer(DescribeDomainBpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBpsDataByLayerWithOptions(request, runtime);
        }

        public async Task<DescribeDomainBpsDataByLayerResponse> DescribeDomainBpsDataByLayerAsync(DescribeDomainBpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBpsDataByLayerWithOptionsAsync(request, runtime);
        }

        public DescribeDomainBpsDataByTimeStampResponse DescribeDomainBpsDataByTimeStampWithOptions(DescribeDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByTimeStampResponse>(DoRPCRequest("DescribeDomainBpsDataByTimeStamp", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainBpsDataByTimeStampResponse> DescribeDomainBpsDataByTimeStampWithOptionsAsync(DescribeDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainBpsDataByTimeStampResponse>(await DoRPCRequestAsync("DescribeDomainBpsDataByTimeStamp", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainBpsDataByTimeStampResponse DescribeDomainBpsDataByTimeStamp(DescribeDomainBpsDataByTimeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainBpsDataByTimeStampWithOptions(request, runtime);
        }

        public async Task<DescribeDomainBpsDataByTimeStampResponse> DescribeDomainBpsDataByTimeStampAsync(DescribeDomainBpsDataByTimeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainBpsDataByTimeStampWithOptionsAsync(request, runtime);
        }

        public DescribeDomainCcActivityLogResponse DescribeDomainCcActivityLogWithOptions(DescribeDomainCcActivityLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainCcActivityLogResponse>(DoRPCRequest("DescribeDomainCcActivityLog", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainCcActivityLogResponse> DescribeDomainCcActivityLogWithOptionsAsync(DescribeDomainCcActivityLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainCcActivityLogResponse>(await DoRPCRequestAsync("DescribeDomainCcActivityLog", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainCcActivityLogResponse DescribeDomainCcActivityLog(DescribeDomainCcActivityLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCcActivityLogWithOptions(request, runtime);
        }

        public async Task<DescribeDomainCcActivityLogResponse> DescribeDomainCcActivityLogAsync(DescribeDomainCcActivityLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCcActivityLogWithOptionsAsync(request, runtime);
        }

        public DescribeDomainCertificateInfoResponse DescribeDomainCertificateInfoWithOptions(DescribeDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainCertificateInfoResponse>(DoRPCRequest("DescribeDomainCertificateInfo", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainCertificateInfoResponse> DescribeDomainCertificateInfoWithOptionsAsync(DescribeDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainCertificateInfoResponse>(await DoRPCRequestAsync("DescribeDomainCertificateInfo", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainCertificateInfoResponse DescribeDomainCertificateInfo(DescribeDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDomainCertificateInfoResponse> DescribeDomainCertificateInfoAsync(DescribeDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDomainCustomLogConfigResponse DescribeDomainCustomLogConfigWithOptions(DescribeDomainCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainCustomLogConfigResponse>(DoRPCRequest("DescribeDomainCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainCustomLogConfigResponse> DescribeDomainCustomLogConfigWithOptionsAsync(DescribeDomainCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainCustomLogConfigResponse>(await DoRPCRequestAsync("DescribeDomainCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainCustomLogConfigResponse DescribeDomainCustomLogConfig(DescribeDomainCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCustomLogConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDomainCustomLogConfigResponse> DescribeDomainCustomLogConfigAsync(DescribeDomainCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCustomLogConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDomainDetailDataByLayerResponse DescribeDomainDetailDataByLayerWithOptions(DescribeDomainDetailDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainDetailDataByLayerResponse>(DoRPCRequest("DescribeDomainDetailDataByLayer", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainDetailDataByLayerResponse> DescribeDomainDetailDataByLayerWithOptionsAsync(DescribeDomainDetailDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainDetailDataByLayerResponse>(await DoRPCRequestAsync("DescribeDomainDetailDataByLayer", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainDetailDataByLayerResponse DescribeDomainDetailDataByLayer(DescribeDomainDetailDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDetailDataByLayerWithOptions(request, runtime);
        }

        public async Task<DescribeDomainDetailDataByLayerResponse> DescribeDomainDetailDataByLayerAsync(DescribeDomainDetailDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDetailDataByLayerWithOptionsAsync(request, runtime);
        }

        public DescribeDomainFileSizeProportionDataResponse DescribeDomainFileSizeProportionDataWithOptions(DescribeDomainFileSizeProportionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainFileSizeProportionDataResponse>(DoRPCRequest("DescribeDomainFileSizeProportionData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainFileSizeProportionDataResponse> DescribeDomainFileSizeProportionDataWithOptionsAsync(DescribeDomainFileSizeProportionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainFileSizeProportionDataResponse>(await DoRPCRequestAsync("DescribeDomainFileSizeProportionData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainFileSizeProportionDataResponse DescribeDomainFileSizeProportionData(DescribeDomainFileSizeProportionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainFileSizeProportionDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainFileSizeProportionDataResponse> DescribeDomainFileSizeProportionDataAsync(DescribeDomainFileSizeProportionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainFileSizeProportionDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainHitRateDataResponse DescribeDomainHitRateDataWithOptions(DescribeDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainHitRateDataResponse>(DoRPCRequest("DescribeDomainHitRateData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainHitRateDataResponse> DescribeDomainHitRateDataWithOptionsAsync(DescribeDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainHitRateDataResponse>(await DoRPCRequestAsync("DescribeDomainHitRateData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainHitRateDataResponse DescribeDomainHitRateData(DescribeDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainHitRateDataResponse> DescribeDomainHitRateDataAsync(DescribeDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainHttpCodeDataResponse DescribeDomainHttpCodeDataWithOptions(DescribeDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataResponse>(DoRPCRequest("DescribeDomainHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainHttpCodeDataResponse> DescribeDomainHttpCodeDataWithOptionsAsync(DescribeDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDomainHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainHttpCodeDataResponse DescribeDomainHttpCodeData(DescribeDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainHttpCodeDataResponse> DescribeDomainHttpCodeDataAsync(DescribeDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainHttpCodeDataByLayerResponse DescribeDomainHttpCodeDataByLayerWithOptions(DescribeDomainHttpCodeDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataByLayerResponse>(DoRPCRequest("DescribeDomainHttpCodeDataByLayer", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainHttpCodeDataByLayerResponse> DescribeDomainHttpCodeDataByLayerWithOptionsAsync(DescribeDomainHttpCodeDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainHttpCodeDataByLayerResponse>(await DoRPCRequestAsync("DescribeDomainHttpCodeDataByLayer", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainHttpCodeDataByLayerResponse DescribeDomainHttpCodeDataByLayer(DescribeDomainHttpCodeDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainHttpCodeDataByLayerWithOptions(request, runtime);
        }

        public async Task<DescribeDomainHttpCodeDataByLayerResponse> DescribeDomainHttpCodeDataByLayerAsync(DescribeDomainHttpCodeDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainHttpCodeDataByLayerWithOptionsAsync(request, runtime);
        }

        public DescribeDomainISPDataResponse DescribeDomainISPDataWithOptions(DescribeDomainISPDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainISPDataResponse>(DoRPCRequest("DescribeDomainISPData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainISPDataResponse> DescribeDomainISPDataWithOptionsAsync(DescribeDomainISPDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainISPDataResponse>(await DoRPCRequestAsync("DescribeDomainISPData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainISPDataResponse DescribeDomainISPData(DescribeDomainISPDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainISPDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainISPDataResponse> DescribeDomainISPDataAsync(DescribeDomainISPDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainISPDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainMax95BpsDataResponse DescribeDomainMax95BpsDataWithOptions(DescribeDomainMax95BpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainMax95BpsDataResponse>(DoRPCRequest("DescribeDomainMax95BpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainMax95BpsDataResponse> DescribeDomainMax95BpsDataWithOptionsAsync(DescribeDomainMax95BpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainMax95BpsDataResponse>(await DoRPCRequestAsync("DescribeDomainMax95BpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainMax95BpsDataResponse DescribeDomainMax95BpsData(DescribeDomainMax95BpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainMax95BpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainMax95BpsDataResponse> DescribeDomainMax95BpsDataAsync(DescribeDomainMax95BpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainMax95BpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainNamesOfVersionResponse DescribeDomainNamesOfVersionWithOptions(DescribeDomainNamesOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNamesOfVersionResponse>(DoRPCRequest("DescribeDomainNamesOfVersion", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainNamesOfVersionResponse> DescribeDomainNamesOfVersionWithOptionsAsync(DescribeDomainNamesOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNamesOfVersionResponse>(await DoRPCRequestAsync("DescribeDomainNamesOfVersion", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainNamesOfVersionResponse DescribeDomainNamesOfVersion(DescribeDomainNamesOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainNamesOfVersionWithOptions(request, runtime);
        }

        public async Task<DescribeDomainNamesOfVersionResponse> DescribeDomainNamesOfVersionAsync(DescribeDomainNamesOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainNamesOfVersionWithOptionsAsync(request, runtime);
        }

        public DescribeDomainPathDataResponse DescribeDomainPathDataWithOptions(DescribeDomainPathDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainPathDataResponse>(DoRPCRequest("DescribeDomainPathData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainPathDataResponse> DescribeDomainPathDataWithOptionsAsync(DescribeDomainPathDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainPathDataResponse>(await DoRPCRequestAsync("DescribeDomainPathData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainPathDataResponse DescribeDomainPathData(DescribeDomainPathDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainPathDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainPathDataResponse> DescribeDomainPathDataAsync(DescribeDomainPathDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainPathDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainPvDataResponse DescribeDomainPvDataWithOptions(DescribeDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainPvDataResponse>(DoRPCRequest("DescribeDomainPvData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainPvDataResponse> DescribeDomainPvDataWithOptionsAsync(DescribeDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainPvDataResponse>(await DoRPCRequestAsync("DescribeDomainPvData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainPvDataResponse DescribeDomainPvData(DescribeDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainPvDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainPvDataResponse> DescribeDomainPvDataAsync(DescribeDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainPvDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainQpsDataResponse DescribeDomainQpsDataWithOptions(DescribeDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsDataResponse>(DoRPCRequest("DescribeDomainQpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainQpsDataResponse> DescribeDomainQpsDataWithOptionsAsync(DescribeDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsDataResponse>(await DoRPCRequestAsync("DescribeDomainQpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainQpsDataResponse DescribeDomainQpsData(DescribeDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainQpsDataResponse> DescribeDomainQpsDataAsync(DescribeDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainQpsDataByLayerResponse DescribeDomainQpsDataByLayerWithOptions(DescribeDomainQpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsDataByLayerResponse>(DoRPCRequest("DescribeDomainQpsDataByLayer", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainQpsDataByLayerResponse> DescribeDomainQpsDataByLayerWithOptionsAsync(DescribeDomainQpsDataByLayerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainQpsDataByLayerResponse>(await DoRPCRequestAsync("DescribeDomainQpsDataByLayer", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainQpsDataByLayerResponse DescribeDomainQpsDataByLayer(DescribeDomainQpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsDataByLayerWithOptions(request, runtime);
        }

        public async Task<DescribeDomainQpsDataByLayerResponse> DescribeDomainQpsDataByLayerAsync(DescribeDomainQpsDataByLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsDataByLayerWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeBpsDataResponse DescribeDomainRealTimeBpsDataWithOptions(DescribeDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeBpsDataResponse>(DoRPCRequest("DescribeDomainRealTimeBpsData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeBpsDataResponse> DescribeDomainRealTimeBpsDataWithOptionsAsync(DescribeDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeBpsDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeBpsData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeBpsDataResponse DescribeDomainRealTimeBpsData(DescribeDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeBpsDataResponse> DescribeDomainRealTimeBpsDataAsync(DescribeDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeByteHitRateDataResponse DescribeDomainRealTimeByteHitRateDataWithOptions(DescribeDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeByteHitRateDataResponse>(DoRPCRequest("DescribeDomainRealTimeByteHitRateData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeByteHitRateDataResponse> DescribeDomainRealTimeByteHitRateDataWithOptionsAsync(DescribeDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeByteHitRateDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeByteHitRateData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeByteHitRateDataResponse DescribeDomainRealTimeByteHitRateData(DescribeDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeByteHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeByteHitRateDataResponse> DescribeDomainRealTimeByteHitRateDataAsync(DescribeDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeByteHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeDetailDataResponse DescribeDomainRealTimeDetailDataWithOptions(DescribeDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeDetailDataResponse>(DoRPCRequest("DescribeDomainRealTimeDetailData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeDetailDataResponse> DescribeDomainRealTimeDetailDataWithOptionsAsync(DescribeDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeDetailDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeDetailData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeDetailDataResponse DescribeDomainRealTimeDetailData(DescribeDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeDetailDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeDetailDataResponse> DescribeDomainRealTimeDetailDataAsync(DescribeDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeDetailDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeHttpCodeDataResponse DescribeDomainRealTimeHttpCodeDataWithOptions(DescribeDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeHttpCodeDataResponse>(DoRPCRequest("DescribeDomainRealTimeHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeHttpCodeDataResponse> DescribeDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeHttpCodeDataResponse DescribeDomainRealTimeHttpCodeData(DescribeDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeHttpCodeDataResponse> DescribeDomainRealTimeHttpCodeDataAsync(DescribeDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealtimeLogDeliveryResponse DescribeDomainRealtimeLogDeliveryWithOptions(DescribeDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealtimeLogDeliveryResponse>(DoRPCRequest("DescribeDomainRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealtimeLogDeliveryResponse> DescribeDomainRealtimeLogDeliveryWithOptionsAsync(DescribeDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("DescribeDomainRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainRealtimeLogDeliveryResponse DescribeDomainRealtimeLogDelivery(DescribeDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealtimeLogDeliveryResponse> DescribeDomainRealtimeLogDeliveryAsync(DescribeDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeQpsDataResponse DescribeDomainRealTimeQpsDataWithOptions(DescribeDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeQpsDataResponse>(DoRPCRequest("DescribeDomainRealTimeQpsData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeQpsDataResponse> DescribeDomainRealTimeQpsDataWithOptionsAsync(DescribeDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeQpsDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeQpsData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeQpsDataResponse DescribeDomainRealTimeQpsData(DescribeDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeQpsDataResponse> DescribeDomainRealTimeQpsDataAsync(DescribeDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeReqHitRateDataResponse DescribeDomainRealTimeReqHitRateDataWithOptions(DescribeDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeReqHitRateDataResponse>(DoRPCRequest("DescribeDomainRealTimeReqHitRateData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeReqHitRateDataResponse> DescribeDomainRealTimeReqHitRateDataWithOptionsAsync(DescribeDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDomainRealTimeReqHitRateDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeReqHitRateData", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeReqHitRateDataResponse DescribeDomainRealTimeReqHitRateData(DescribeDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeReqHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeReqHitRateDataResponse> DescribeDomainRealTimeReqHitRateDataAsync(DescribeDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeReqHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeSrcBpsDataResponse DescribeDomainRealTimeSrcBpsDataWithOptions(DescribeDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcBpsDataResponse>(DoRPCRequest("DescribeDomainRealTimeSrcBpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeSrcBpsDataResponse> DescribeDomainRealTimeSrcBpsDataWithOptionsAsync(DescribeDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcBpsDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeSrcBpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeSrcBpsDataResponse DescribeDomainRealTimeSrcBpsData(DescribeDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeSrcBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeSrcBpsDataResponse> DescribeDomainRealTimeSrcBpsDataAsync(DescribeDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeSrcBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeSrcHttpCodeDataResponse DescribeDomainRealTimeSrcHttpCodeDataWithOptions(DescribeDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcHttpCodeDataResponse>(DoRPCRequest("DescribeDomainRealTimeSrcHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeSrcHttpCodeDataResponse> DescribeDomainRealTimeSrcHttpCodeDataWithOptionsAsync(DescribeDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeSrcHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeSrcHttpCodeDataResponse DescribeDomainRealTimeSrcHttpCodeData(DescribeDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeSrcHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeSrcHttpCodeDataResponse> DescribeDomainRealTimeSrcHttpCodeDataAsync(DescribeDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeSrcHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeSrcTrafficDataResponse DescribeDomainRealTimeSrcTrafficDataWithOptions(DescribeDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcTrafficDataResponse>(DoRPCRequest("DescribeDomainRealTimeSrcTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeSrcTrafficDataResponse> DescribeDomainRealTimeSrcTrafficDataWithOptionsAsync(DescribeDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeSrcTrafficDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeSrcTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeSrcTrafficDataResponse DescribeDomainRealTimeSrcTrafficData(DescribeDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeSrcTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeSrcTrafficDataResponse> DescribeDomainRealTimeSrcTrafficDataAsync(DescribeDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRealTimeTrafficDataResponse DescribeDomainRealTimeTrafficDataWithOptions(DescribeDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeTrafficDataResponse>(DoRPCRequest("DescribeDomainRealTimeTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRealTimeTrafficDataResponse> DescribeDomainRealTimeTrafficDataWithOptionsAsync(DescribeDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRealTimeTrafficDataResponse>(await DoRPCRequestAsync("DescribeDomainRealTimeTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRealTimeTrafficDataResponse DescribeDomainRealTimeTrafficData(DescribeDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRealTimeTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRealTimeTrafficDataResponse> DescribeDomainRealTimeTrafficDataAsync(DescribeDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRealTimeTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRegionDataResponse DescribeDomainRegionDataWithOptions(DescribeDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRegionDataResponse>(DoRPCRequest("DescribeDomainRegionData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRegionDataResponse> DescribeDomainRegionDataWithOptionsAsync(DescribeDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRegionDataResponse>(await DoRPCRequestAsync("DescribeDomainRegionData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRegionDataResponse DescribeDomainRegionData(DescribeDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRegionDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRegionDataResponse> DescribeDomainRegionDataAsync(DescribeDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRegionDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainReqHitRateDataResponse DescribeDomainReqHitRateDataWithOptions(DescribeDomainReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainReqHitRateDataResponse>(DoRPCRequest("DescribeDomainReqHitRateData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainReqHitRateDataResponse> DescribeDomainReqHitRateDataWithOptionsAsync(DescribeDomainReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainReqHitRateDataResponse>(await DoRPCRequestAsync("DescribeDomainReqHitRateData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainReqHitRateDataResponse DescribeDomainReqHitRateData(DescribeDomainReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainReqHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainReqHitRateDataResponse> DescribeDomainReqHitRateDataAsync(DescribeDomainReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainReqHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainsBySourceResponse DescribeDomainsBySourceWithOptions(DescribeDomainsBySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsBySourceResponse>(DoRPCRequest("DescribeDomainsBySource", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsBySourceResponse> DescribeDomainsBySourceWithOptionsAsync(DescribeDomainsBySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsBySourceResponse>(await DoRPCRequestAsync("DescribeDomainsBySource", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainsBySourceResponse DescribeDomainsBySource(DescribeDomainsBySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsBySourceWithOptions(request, runtime);
        }

        public async Task<DescribeDomainsBySourceResponse> DescribeDomainsBySourceAsync(DescribeDomainsBySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsBySourceWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSrcBpsDataResponse DescribeDomainSrcBpsDataWithOptions(DescribeDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcBpsDataResponse>(DoRPCRequest("DescribeDomainSrcBpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSrcBpsDataResponse> DescribeDomainSrcBpsDataWithOptionsAsync(DescribeDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcBpsDataResponse>(await DoRPCRequestAsync("DescribeDomainSrcBpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainSrcBpsDataResponse DescribeDomainSrcBpsData(DescribeDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSrcBpsDataResponse> DescribeDomainSrcBpsDataAsync(DescribeDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSrcHttpCodeDataResponse DescribeDomainSrcHttpCodeDataWithOptions(DescribeDomainSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcHttpCodeDataResponse>(DoRPCRequest("DescribeDomainSrcHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSrcHttpCodeDataResponse> DescribeDomainSrcHttpCodeDataWithOptionsAsync(DescribeDomainSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDomainSrcHttpCodeData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainSrcHttpCodeDataResponse DescribeDomainSrcHttpCodeData(DescribeDomainSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSrcHttpCodeDataResponse> DescribeDomainSrcHttpCodeDataAsync(DescribeDomainSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSrcQpsDataResponse DescribeDomainSrcQpsDataWithOptions(DescribeDomainSrcQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcQpsDataResponse>(DoRPCRequest("DescribeDomainSrcQpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSrcQpsDataResponse> DescribeDomainSrcQpsDataWithOptionsAsync(DescribeDomainSrcQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcQpsDataResponse>(await DoRPCRequestAsync("DescribeDomainSrcQpsData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainSrcQpsDataResponse DescribeDomainSrcQpsData(DescribeDomainSrcQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSrcQpsDataResponse> DescribeDomainSrcQpsDataAsync(DescribeDomainSrcQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSrcTopUrlVisitResponse DescribeDomainSrcTopUrlVisitWithOptions(DescribeDomainSrcTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcTopUrlVisitResponse>(DoRPCRequest("DescribeDomainSrcTopUrlVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSrcTopUrlVisitResponse> DescribeDomainSrcTopUrlVisitWithOptionsAsync(DescribeDomainSrcTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcTopUrlVisitResponse>(await DoRPCRequestAsync("DescribeDomainSrcTopUrlVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainSrcTopUrlVisitResponse DescribeDomainSrcTopUrlVisit(DescribeDomainSrcTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcTopUrlVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSrcTopUrlVisitResponse> DescribeDomainSrcTopUrlVisitAsync(DescribeDomainSrcTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcTopUrlVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSrcTrafficDataResponse DescribeDomainSrcTrafficDataWithOptions(DescribeDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcTrafficDataResponse>(DoRPCRequest("DescribeDomainSrcTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSrcTrafficDataResponse> DescribeDomainSrcTrafficDataWithOptionsAsync(DescribeDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSrcTrafficDataResponse>(await DoRPCRequestAsync("DescribeDomainSrcTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainSrcTrafficDataResponse DescribeDomainSrcTrafficData(DescribeDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSrcTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSrcTrafficDataResponse> DescribeDomainSrcTrafficDataAsync(DescribeDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainsUsageByDayResponse DescribeDomainsUsageByDayWithOptions(DescribeDomainsUsageByDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsUsageByDayResponse>(DoRPCRequest("DescribeDomainsUsageByDay", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsUsageByDayResponse> DescribeDomainsUsageByDayWithOptionsAsync(DescribeDomainsUsageByDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsUsageByDayResponse>(await DoRPCRequestAsync("DescribeDomainsUsageByDay", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainsUsageByDayResponse DescribeDomainsUsageByDay(DescribeDomainsUsageByDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsUsageByDayWithOptions(request, runtime);
        }

        public async Task<DescribeDomainsUsageByDayResponse> DescribeDomainsUsageByDayAsync(DescribeDomainsUsageByDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsUsageByDayWithOptionsAsync(request, runtime);
        }

        public DescribeDomainTopClientIpVisitResponse DescribeDomainTopClientIpVisitWithOptions(DescribeDomainTopClientIpVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopClientIpVisitResponse>(DoRPCRequest("DescribeDomainTopClientIpVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainTopClientIpVisitResponse> DescribeDomainTopClientIpVisitWithOptionsAsync(DescribeDomainTopClientIpVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopClientIpVisitResponse>(await DoRPCRequestAsync("DescribeDomainTopClientIpVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainTopClientIpVisitResponse DescribeDomainTopClientIpVisit(DescribeDomainTopClientIpVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopClientIpVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDomainTopClientIpVisitResponse> DescribeDomainTopClientIpVisitAsync(DescribeDomainTopClientIpVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopClientIpVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDomainTopReferVisitResponse DescribeDomainTopReferVisitWithOptions(DescribeDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopReferVisitResponse>(DoRPCRequest("DescribeDomainTopReferVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainTopReferVisitResponse> DescribeDomainTopReferVisitWithOptionsAsync(DescribeDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopReferVisitResponse>(await DoRPCRequestAsync("DescribeDomainTopReferVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainTopReferVisitResponse DescribeDomainTopReferVisit(DescribeDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopReferVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDomainTopReferVisitResponse> DescribeDomainTopReferVisitAsync(DescribeDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopReferVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDomainTopUrlVisitResponse DescribeDomainTopUrlVisitWithOptions(DescribeDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopUrlVisitResponse>(DoRPCRequest("DescribeDomainTopUrlVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainTopUrlVisitResponse> DescribeDomainTopUrlVisitWithOptionsAsync(DescribeDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTopUrlVisitResponse>(await DoRPCRequestAsync("DescribeDomainTopUrlVisit", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainTopUrlVisitResponse DescribeDomainTopUrlVisit(DescribeDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTopUrlVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDomainTopUrlVisitResponse> DescribeDomainTopUrlVisitAsync(DescribeDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTopUrlVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDomainTrafficDataResponse DescribeDomainTrafficDataWithOptions(DescribeDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTrafficDataResponse>(DoRPCRequest("DescribeDomainTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainTrafficDataResponse> DescribeDomainTrafficDataWithOptionsAsync(DescribeDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainTrafficDataResponse>(await DoRPCRequestAsync("DescribeDomainTrafficData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainTrafficDataResponse DescribeDomainTrafficData(DescribeDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainTrafficDataResponse> DescribeDomainTrafficDataAsync(DescribeDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainUsageDataResponse DescribeDomainUsageDataWithOptions(DescribeDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainUsageDataResponse>(DoRPCRequest("DescribeDomainUsageData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainUsageDataResponse> DescribeDomainUsageDataWithOptionsAsync(DescribeDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainUsageDataResponse>(await DoRPCRequestAsync("DescribeDomainUsageData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainUsageDataResponse DescribeDomainUsageData(DescribeDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainUsageDataResponse> DescribeDomainUsageDataAsync(DescribeDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeDomainUvDataResponse DescribeDomainUvDataWithOptions(DescribeDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainUvDataResponse>(DoRPCRequest("DescribeDomainUvData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainUvDataResponse> DescribeDomainUvDataWithOptionsAsync(DescribeDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainUvDataResponse>(await DoRPCRequestAsync("DescribeDomainUvData", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainUvDataResponse DescribeDomainUvData(DescribeDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainUvDataResponse> DescribeDomainUvDataAsync(DescribeDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeFCTriggerResponse DescribeFCTriggerWithOptions(DescribeFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeFCTriggerResponse>(DoRPCRequest("DescribeFCTrigger", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeFCTriggerResponse> DescribeFCTriggerWithOptionsAsync(DescribeFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeFCTriggerResponse>(await DoRPCRequestAsync("DescribeFCTrigger", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeFCTriggerResponse DescribeFCTrigger(DescribeFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFCTriggerWithOptions(request, runtime);
        }

        public async Task<DescribeFCTriggerResponse> DescribeFCTriggerAsync(DescribeFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFCTriggerWithOptionsAsync(request, runtime);
        }

        public DescribeIllegalUrlExportTaskResponse DescribeIllegalUrlExportTaskWithOptions(DescribeIllegalUrlExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIllegalUrlExportTaskResponse>(DoRPCRequest("DescribeIllegalUrlExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIllegalUrlExportTaskResponse> DescribeIllegalUrlExportTaskWithOptionsAsync(DescribeIllegalUrlExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIllegalUrlExportTaskResponse>(await DoRPCRequestAsync("DescribeIllegalUrlExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIllegalUrlExportTaskResponse DescribeIllegalUrlExportTask(DescribeIllegalUrlExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIllegalUrlExportTaskWithOptions(request, runtime);
        }

        public async Task<DescribeIllegalUrlExportTaskResponse> DescribeIllegalUrlExportTaskAsync(DescribeIllegalUrlExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIllegalUrlExportTaskWithOptionsAsync(request, runtime);
        }

        public DescribeIpInfoResponse DescribeIpInfoWithOptions(DescribeIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpInfoResponse>(DoRPCRequest("DescribeIpInfo", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpInfoResponse> DescribeIpInfoWithOptionsAsync(DescribeIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpInfoResponse>(await DoRPCRequestAsync("DescribeIpInfo", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpInfoResponse DescribeIpInfo(DescribeIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpInfoWithOptions(request, runtime);
        }

        public async Task<DescribeIpInfoResponse> DescribeIpInfoAsync(DescribeIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpInfoWithOptionsAsync(request, runtime);
        }

        public DescribeL2VipsByDomainResponse DescribeL2VipsByDomainWithOptions(DescribeL2VipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeL2VipsByDomainResponse>(DoRPCRequest("DescribeL2VipsByDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeL2VipsByDomainResponse> DescribeL2VipsByDomainWithOptionsAsync(DescribeL2VipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeL2VipsByDomainResponse>(await DoRPCRequestAsync("DescribeL2VipsByDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeL2VipsByDomainResponse DescribeL2VipsByDomain(DescribeL2VipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeL2VipsByDomainWithOptions(request, runtime);
        }

        public async Task<DescribeL2VipsByDomainResponse> DescribeL2VipsByDomainAsync(DescribeL2VipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeL2VipsByDomainWithOptionsAsync(request, runtime);
        }

        public DescribeRangeDataByLocateAndIspServiceResponse DescribeRangeDataByLocateAndIspServiceWithOptions(DescribeRangeDataByLocateAndIspServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRangeDataByLocateAndIspServiceResponse>(DoRPCRequest("DescribeRangeDataByLocateAndIspService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRangeDataByLocateAndIspServiceResponse> DescribeRangeDataByLocateAndIspServiceWithOptionsAsync(DescribeRangeDataByLocateAndIspServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRangeDataByLocateAndIspServiceResponse>(await DoRPCRequestAsync("DescribeRangeDataByLocateAndIspService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRangeDataByLocateAndIspServiceResponse DescribeRangeDataByLocateAndIspService(DescribeRangeDataByLocateAndIspServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRangeDataByLocateAndIspServiceWithOptions(request, runtime);
        }

        public async Task<DescribeRangeDataByLocateAndIspServiceResponse> DescribeRangeDataByLocateAndIspServiceAsync(DescribeRangeDataByLocateAndIspServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRangeDataByLocateAndIspServiceWithOptionsAsync(request, runtime);
        }

        public DescribeRealtimeDeliveryAccResponse DescribeRealtimeDeliveryAccWithOptions(DescribeRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRealtimeDeliveryAccResponse>(DoRPCRequest("DescribeRealtimeDeliveryAcc", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRealtimeDeliveryAccResponse> DescribeRealtimeDeliveryAccWithOptionsAsync(DescribeRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRealtimeDeliveryAccResponse>(await DoRPCRequestAsync("DescribeRealtimeDeliveryAcc", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRealtimeDeliveryAccResponse DescribeRealtimeDeliveryAcc(DescribeRealtimeDeliveryAccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRealtimeDeliveryAccWithOptions(request, runtime);
        }

        public async Task<DescribeRealtimeDeliveryAccResponse> DescribeRealtimeDeliveryAccAsync(DescribeRealtimeDeliveryAccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRealtimeDeliveryAccWithOptionsAsync(request, runtime);
        }

        public DescribeRefreshQuotaResponse DescribeRefreshQuotaWithOptions(DescribeRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRefreshQuotaResponse>(DoRPCRequest("DescribeRefreshQuota", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRefreshQuotaResponse> DescribeRefreshQuotaWithOptionsAsync(DescribeRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRefreshQuotaResponse>(await DoRPCRequestAsync("DescribeRefreshQuota", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRefreshQuotaResponse DescribeRefreshQuota(DescribeRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRefreshQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeRefreshQuotaResponse> DescribeRefreshQuotaAsync(DescribeRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRefreshQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeRefreshTaskByIdResponse DescribeRefreshTaskByIdWithOptions(DescribeRefreshTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRefreshTaskByIdResponse>(DoRPCRequest("DescribeRefreshTaskById", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRefreshTaskByIdResponse> DescribeRefreshTaskByIdWithOptionsAsync(DescribeRefreshTaskByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRefreshTaskByIdResponse>(await DoRPCRequestAsync("DescribeRefreshTaskById", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRefreshTaskByIdResponse DescribeRefreshTaskById(DescribeRefreshTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRefreshTaskByIdWithOptions(request, runtime);
        }

        public async Task<DescribeRefreshTaskByIdResponse> DescribeRefreshTaskByIdAsync(DescribeRefreshTaskByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRefreshTaskByIdWithOptionsAsync(request, runtime);
        }

        public DescribeRefreshTasksResponse DescribeRefreshTasksWithOptions(DescribeRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRefreshTasksResponse>(DoRPCRequest("DescribeRefreshTasks", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRefreshTasksResponse> DescribeRefreshTasksWithOptionsAsync(DescribeRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRefreshTasksResponse>(await DoRPCRequestAsync("DescribeRefreshTasks", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRefreshTasksResponse DescribeRefreshTasks(DescribeRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRefreshTasksWithOptions(request, runtime);
        }

        public async Task<DescribeRefreshTasksResponse> DescribeRefreshTasksAsync(DescribeRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRefreshTasksWithOptionsAsync(request, runtime);
        }

        public DescribeStagingIpResponse DescribeStagingIpWithOptions(DescribeStagingIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStagingIpResponse>(DoRPCRequest("DescribeStagingIp", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStagingIpResponse> DescribeStagingIpWithOptionsAsync(DescribeStagingIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStagingIpResponse>(await DoRPCRequestAsync("DescribeStagingIp", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStagingIpResponse DescribeStagingIp(DescribeStagingIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStagingIpWithOptions(request, runtime);
        }

        public async Task<DescribeStagingIpResponse> DescribeStagingIpAsync(DescribeStagingIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStagingIpWithOptionsAsync(request, runtime);
        }

        public DescribeTagResourcesResponse DescribeTagResourcesWithOptions(DescribeTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagResourcesResponse>(DoRPCRequest("DescribeTagResources", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagResourcesResponse> DescribeTagResourcesWithOptionsAsync(DescribeTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagResourcesResponse>(await DoRPCRequestAsync("DescribeTagResources", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagResourcesResponse DescribeTagResources(DescribeTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeTagResourcesResponse> DescribeTagResourcesAsync(DescribeTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeTopDomainsByFlowResponse DescribeTopDomainsByFlowWithOptions(DescribeTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTopDomainsByFlowResponse>(DoRPCRequest("DescribeTopDomainsByFlow", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTopDomainsByFlowResponse> DescribeTopDomainsByFlowWithOptionsAsync(DescribeTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTopDomainsByFlowResponse>(await DoRPCRequestAsync("DescribeTopDomainsByFlow", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTopDomainsByFlowResponse DescribeTopDomainsByFlow(DescribeTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopDomainsByFlowWithOptions(request, runtime);
        }

        public async Task<DescribeTopDomainsByFlowResponse> DescribeTopDomainsByFlowAsync(DescribeTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        public DescribeUserCertificateExpireCountResponse DescribeUserCertificateExpireCountWithOptions(DescribeUserCertificateExpireCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCertificateExpireCountResponse>(DoRPCRequest("DescribeUserCertificateExpireCount", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserCertificateExpireCountResponse> DescribeUserCertificateExpireCountWithOptionsAsync(DescribeUserCertificateExpireCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCertificateExpireCountResponse>(await DoRPCRequestAsync("DescribeUserCertificateExpireCount", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserCertificateExpireCountResponse DescribeUserCertificateExpireCount(DescribeUserCertificateExpireCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserCertificateExpireCountWithOptions(request, runtime);
        }

        public async Task<DescribeUserCertificateExpireCountResponse> DescribeUserCertificateExpireCountAsync(DescribeUserCertificateExpireCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserCertificateExpireCountWithOptionsAsync(request, runtime);
        }

        public DescribeUserConfigsResponse DescribeUserConfigsWithOptions(DescribeUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserConfigsResponse>(DoRPCRequest("DescribeUserConfigs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserConfigsResponse> DescribeUserConfigsWithOptionsAsync(DescribeUserConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserConfigsResponse>(await DoRPCRequestAsync("DescribeUserConfigs", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserConfigsResponse DescribeUserConfigs(DescribeUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeUserConfigsResponse> DescribeUserConfigsAsync(DescribeUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeUserDomainsResponse DescribeUserDomainsWithOptions(DescribeUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDomainsResponse>(DoRPCRequest("DescribeUserDomains", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserDomainsResponse> DescribeUserDomainsWithOptionsAsync(DescribeUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDomainsResponse>(await DoRPCRequestAsync("DescribeUserDomains", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserDomainsResponse DescribeUserDomains(DescribeUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeUserDomainsResponse> DescribeUserDomainsAsync(DescribeUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeUserTagsResponse DescribeUserTagsWithOptions(DescribeUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserTagsResponse>(DoRPCRequest("DescribeUserTags", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserTagsResponse> DescribeUserTagsWithOptionsAsync(DescribeUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserTagsResponse>(await DoRPCRequestAsync("DescribeUserTags", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserTagsResponse DescribeUserTags(DescribeUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserTagsWithOptions(request, runtime);
        }

        public async Task<DescribeUserTagsResponse> DescribeUserTagsAsync(DescribeUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserTagsWithOptionsAsync(request, runtime);
        }

        public DescribeUserUsageDataExportTaskResponse DescribeUserUsageDataExportTaskWithOptions(DescribeUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserUsageDataExportTaskResponse>(DoRPCRequest("DescribeUserUsageDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserUsageDataExportTaskResponse> DescribeUserUsageDataExportTaskWithOptionsAsync(DescribeUserUsageDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserUsageDataExportTaskResponse>(await DoRPCRequestAsync("DescribeUserUsageDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserUsageDataExportTaskResponse DescribeUserUsageDataExportTask(DescribeUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserUsageDataExportTaskWithOptions(request, runtime);
        }

        public async Task<DescribeUserUsageDataExportTaskResponse> DescribeUserUsageDataExportTaskAsync(DescribeUserUsageDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserUsageDataExportTaskWithOptionsAsync(request, runtime);
        }

        public DescribeUserUsageDetailDataExportTaskResponse DescribeUserUsageDetailDataExportTaskWithOptions(DescribeUserUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserUsageDetailDataExportTaskResponse>(DoRPCRequest("DescribeUserUsageDetailDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserUsageDetailDataExportTaskResponse> DescribeUserUsageDetailDataExportTaskWithOptionsAsync(DescribeUserUsageDetailDataExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserUsageDetailDataExportTaskResponse>(await DoRPCRequestAsync("DescribeUserUsageDetailDataExportTask", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserUsageDetailDataExportTaskResponse DescribeUserUsageDetailDataExportTask(DescribeUserUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserUsageDetailDataExportTaskWithOptions(request, runtime);
        }

        public async Task<DescribeUserUsageDetailDataExportTaskResponse> DescribeUserUsageDetailDataExportTaskAsync(DescribeUserUsageDetailDataExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserUsageDetailDataExportTaskWithOptionsAsync(request, runtime);
        }

        public DescribeUserVipsByDomainResponse DescribeUserVipsByDomainWithOptions(DescribeUserVipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeUserVipsByDomainResponse>(DoRPCRequest("DescribeUserVipsByDomain", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserVipsByDomainResponse> DescribeUserVipsByDomainWithOptionsAsync(DescribeUserVipsByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeUserVipsByDomainResponse>(await DoRPCRequestAsync("DescribeUserVipsByDomain", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeUserVipsByDomainResponse DescribeUserVipsByDomain(DescribeUserVipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserVipsByDomainWithOptions(request, runtime);
        }

        public async Task<DescribeUserVipsByDomainResponse> DescribeUserVipsByDomainAsync(DescribeUserVipsByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserVipsByDomainWithOptionsAsync(request, runtime);
        }

        public DescribeVerifyContentResponse DescribeVerifyContentWithOptions(DescribeVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyContentResponse>(DoRPCRequest("DescribeVerifyContent", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifyContentResponse> DescribeVerifyContentWithOptionsAsync(DescribeVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyContentResponse>(await DoRPCRequestAsync("DescribeVerifyContent", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifyContentResponse DescribeVerifyContent(DescribeVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyContentWithOptions(request, runtime);
        }

        public async Task<DescribeVerifyContentResponse> DescribeVerifyContentAsync(DescribeVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyContentWithOptionsAsync(request, runtime);
        }

        public DisableRealtimeLogDeliveryResponse DisableRealtimeLogDeliveryWithOptions(DisableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DisableRealtimeLogDeliveryResponse>(DoRPCRequest("DisableRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DisableRealtimeLogDeliveryResponse> DisableRealtimeLogDeliveryWithOptionsAsync(DisableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DisableRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("DisableRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DisableRealtimeLogDeliveryResponse DisableRealtimeLogDelivery(DisableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DisableRealtimeLogDeliveryResponse> DisableRealtimeLogDeliveryAsync(DisableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public EnableRealtimeLogDeliveryResponse EnableRealtimeLogDeliveryWithOptions(EnableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EnableRealtimeLogDeliveryResponse>(DoRPCRequest("EnableRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EnableRealtimeLogDeliveryResponse> EnableRealtimeLogDeliveryWithOptionsAsync(EnableRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EnableRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("EnableRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EnableRealtimeLogDeliveryResponse EnableRealtimeLogDelivery(EnableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<EnableRealtimeLogDeliveryResponse> EnableRealtimeLogDeliveryAsync(EnableRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public ListDomainsByLogConfigIdResponse ListDomainsByLogConfigIdWithOptions(ListDomainsByLogConfigIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDomainsByLogConfigIdResponse>(DoRPCRequest("ListDomainsByLogConfigId", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDomainsByLogConfigIdResponse> ListDomainsByLogConfigIdWithOptionsAsync(ListDomainsByLogConfigIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDomainsByLogConfigIdResponse>(await DoRPCRequestAsync("ListDomainsByLogConfigId", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDomainsByLogConfigIdResponse ListDomainsByLogConfigId(ListDomainsByLogConfigIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDomainsByLogConfigIdWithOptions(request, runtime);
        }

        public async Task<ListDomainsByLogConfigIdResponse> ListDomainsByLogConfigIdAsync(ListDomainsByLogConfigIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDomainsByLogConfigIdWithOptionsAsync(request, runtime);
        }

        public ListFCTriggerResponse ListFCTriggerWithOptions(ListFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListFCTriggerResponse>(DoRPCRequest("ListFCTrigger", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListFCTriggerResponse> ListFCTriggerWithOptionsAsync(ListFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListFCTriggerResponse>(await DoRPCRequestAsync("ListFCTrigger", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListFCTriggerResponse ListFCTrigger(ListFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFCTriggerWithOptions(request, runtime);
        }

        public async Task<ListFCTriggerResponse> ListFCTriggerAsync(ListFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFCTriggerWithOptionsAsync(request, runtime);
        }

        public ListRealtimeLogDeliveryDomainsResponse ListRealtimeLogDeliveryDomainsWithOptions(ListRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryDomainsResponse>(DoRPCRequest("ListRealtimeLogDeliveryDomains", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListRealtimeLogDeliveryDomainsResponse> ListRealtimeLogDeliveryDomainsWithOptionsAsync(ListRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryDomainsResponse>(await DoRPCRequestAsync("ListRealtimeLogDeliveryDomains", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListRealtimeLogDeliveryDomainsResponse ListRealtimeLogDeliveryDomains(ListRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeLogDeliveryDomainsWithOptions(request, runtime);
        }

        public async Task<ListRealtimeLogDeliveryDomainsResponse> ListRealtimeLogDeliveryDomainsAsync(ListRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeLogDeliveryDomainsWithOptionsAsync(request, runtime);
        }

        public ListRealtimeLogDeliveryInfosResponse ListRealtimeLogDeliveryInfosWithOptions(ListRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryInfosResponse>(DoRPCRequest("ListRealtimeLogDeliveryInfos", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListRealtimeLogDeliveryInfosResponse> ListRealtimeLogDeliveryInfosWithOptionsAsync(ListRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRealtimeLogDeliveryInfosResponse>(await DoRPCRequestAsync("ListRealtimeLogDeliveryInfos", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListRealtimeLogDeliveryInfosResponse ListRealtimeLogDeliveryInfos(ListRealtimeLogDeliveryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRealtimeLogDeliveryInfosWithOptions(request, runtime);
        }

        public async Task<ListRealtimeLogDeliveryInfosResponse> ListRealtimeLogDeliveryInfosAsync(ListRealtimeLogDeliveryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRealtimeLogDeliveryInfosWithOptionsAsync(request, runtime);
        }

        public ListUserCustomLogConfigResponse ListUserCustomLogConfigWithOptions(ListUserCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListUserCustomLogConfigResponse>(DoRPCRequest("ListUserCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListUserCustomLogConfigResponse> ListUserCustomLogConfigWithOptionsAsync(ListUserCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListUserCustomLogConfigResponse>(await DoRPCRequestAsync("ListUserCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListUserCustomLogConfigResponse ListUserCustomLogConfig(ListUserCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserCustomLogConfigWithOptions(request, runtime);
        }

        public async Task<ListUserCustomLogConfigResponse> ListUserCustomLogConfigAsync(ListUserCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserCustomLogConfigWithOptionsAsync(request, runtime);
        }

        public ModifyCdnDomainResponse ModifyCdnDomainWithOptions(ModifyCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCdnDomainResponse>(DoRPCRequest("ModifyCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCdnDomainResponse> ModifyCdnDomainWithOptionsAsync(ModifyCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCdnDomainResponse>(await DoRPCRequestAsync("ModifyCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCdnDomainResponse ModifyCdnDomain(ModifyCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCdnDomainWithOptions(request, runtime);
        }

        public async Task<ModifyCdnDomainResponse> ModifyCdnDomainAsync(ModifyCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCdnDomainWithOptionsAsync(request, runtime);
        }

        public ModifyCdnDomainSchdmByPropertyResponse ModifyCdnDomainSchdmByPropertyWithOptions(ModifyCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCdnDomainSchdmByPropertyResponse>(DoRPCRequest("ModifyCdnDomainSchdmByProperty", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCdnDomainSchdmByPropertyResponse> ModifyCdnDomainSchdmByPropertyWithOptionsAsync(ModifyCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCdnDomainSchdmByPropertyResponse>(await DoRPCRequestAsync("ModifyCdnDomainSchdmByProperty", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCdnDomainSchdmByPropertyResponse ModifyCdnDomainSchdmByProperty(ModifyCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCdnDomainSchdmByPropertyWithOptions(request, runtime);
        }

        public async Task<ModifyCdnDomainSchdmByPropertyResponse> ModifyCdnDomainSchdmByPropertyAsync(ModifyCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCdnDomainSchdmByPropertyWithOptionsAsync(request, runtime);
        }

        public ModifyCdnServiceResponse ModifyCdnServiceWithOptions(ModifyCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCdnServiceResponse>(DoRPCRequest("ModifyCdnService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCdnServiceResponse> ModifyCdnServiceWithOptionsAsync(ModifyCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCdnServiceResponse>(await DoRPCRequestAsync("ModifyCdnService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCdnServiceResponse ModifyCdnService(ModifyCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCdnServiceWithOptions(request, runtime);
        }

        public async Task<ModifyCdnServiceResponse> ModifyCdnServiceAsync(ModifyCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCdnServiceWithOptionsAsync(request, runtime);
        }

        public ModifyDomainCustomLogConfigResponse ModifyDomainCustomLogConfigWithOptions(ModifyDomainCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyDomainCustomLogConfigResponse>(DoRPCRequest("ModifyDomainCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyDomainCustomLogConfigResponse> ModifyDomainCustomLogConfigWithOptionsAsync(ModifyDomainCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyDomainCustomLogConfigResponse>(await DoRPCRequestAsync("ModifyDomainCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyDomainCustomLogConfigResponse ModifyDomainCustomLogConfig(ModifyDomainCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainCustomLogConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDomainCustomLogConfigResponse> ModifyDomainCustomLogConfigAsync(ModifyDomainCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainCustomLogConfigWithOptionsAsync(request, runtime);
        }

        public ModifyRealtimeLogDeliveryResponse ModifyRealtimeLogDeliveryWithOptions(ModifyRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyRealtimeLogDeliveryResponse>(DoRPCRequest("ModifyRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyRealtimeLogDeliveryResponse> ModifyRealtimeLogDeliveryWithOptionsAsync(ModifyRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("ModifyRealtimeLogDelivery", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyRealtimeLogDeliveryResponse ModifyRealtimeLogDelivery(ModifyRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<ModifyRealtimeLogDeliveryResponse> ModifyRealtimeLogDeliveryAsync(ModifyRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public ModifyUserCustomLogConfigResponse ModifyUserCustomLogConfigWithOptions(ModifyUserCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyUserCustomLogConfigResponse>(DoRPCRequest("ModifyUserCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserCustomLogConfigResponse> ModifyUserCustomLogConfigWithOptionsAsync(ModifyUserCustomLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyUserCustomLogConfigResponse>(await DoRPCRequestAsync("ModifyUserCustomLogConfig", "2018-05-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyUserCustomLogConfigResponse ModifyUserCustomLogConfig(ModifyUserCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserCustomLogConfigWithOptions(request, runtime);
        }

        public async Task<ModifyUserCustomLogConfigResponse> ModifyUserCustomLogConfigAsync(ModifyUserCustomLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserCustomLogConfigWithOptionsAsync(request, runtime);
        }

        public OpenCdnServiceResponse OpenCdnServiceWithOptions(OpenCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenCdnServiceResponse>(DoRPCRequest("OpenCdnService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenCdnServiceResponse> OpenCdnServiceWithOptionsAsync(OpenCdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenCdnServiceResponse>(await DoRPCRequestAsync("OpenCdnService", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenCdnServiceResponse OpenCdnService(OpenCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCdnServiceWithOptions(request, runtime);
        }

        public async Task<OpenCdnServiceResponse> OpenCdnServiceAsync(OpenCdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCdnServiceWithOptionsAsync(request, runtime);
        }

        public PublishStagingConfigToProductionResponse PublishStagingConfigToProductionWithOptions(PublishStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishStagingConfigToProductionResponse>(DoRPCRequest("PublishStagingConfigToProduction", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishStagingConfigToProductionResponse> PublishStagingConfigToProductionWithOptionsAsync(PublishStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishStagingConfigToProductionResponse>(await DoRPCRequestAsync("PublishStagingConfigToProduction", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishStagingConfigToProductionResponse PublishStagingConfigToProduction(PublishStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishStagingConfigToProductionWithOptions(request, runtime);
        }

        public async Task<PublishStagingConfigToProductionResponse> PublishStagingConfigToProductionAsync(PublishStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishStagingConfigToProductionWithOptionsAsync(request, runtime);
        }

        public PushObjectCacheResponse PushObjectCacheWithOptions(PushObjectCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushObjectCacheResponse>(DoRPCRequest("PushObjectCache", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushObjectCacheResponse> PushObjectCacheWithOptionsAsync(PushObjectCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushObjectCacheResponse>(await DoRPCRequestAsync("PushObjectCache", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushObjectCacheResponse PushObjectCache(PushObjectCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushObjectCacheWithOptions(request, runtime);
        }

        public async Task<PushObjectCacheResponse> PushObjectCacheAsync(PushObjectCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushObjectCacheWithOptionsAsync(request, runtime);
        }

        public RefreshObjectCachesResponse RefreshObjectCachesWithOptions(RefreshObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshObjectCachesResponse>(DoRPCRequest("RefreshObjectCaches", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshObjectCachesResponse> RefreshObjectCachesWithOptionsAsync(RefreshObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshObjectCachesResponse>(await DoRPCRequestAsync("RefreshObjectCaches", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshObjectCachesResponse RefreshObjectCaches(RefreshObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshObjectCachesWithOptions(request, runtime);
        }

        public async Task<RefreshObjectCachesResponse> RefreshObjectCachesAsync(RefreshObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshObjectCachesWithOptionsAsync(request, runtime);
        }

        public RollbackStagingConfigResponse RollbackStagingConfigWithOptions(RollbackStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackStagingConfigResponse>(DoRPCRequest("RollbackStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackStagingConfigResponse> RollbackStagingConfigWithOptionsAsync(RollbackStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackStagingConfigResponse>(await DoRPCRequestAsync("RollbackStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackStagingConfigResponse RollbackStagingConfig(RollbackStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackStagingConfigWithOptions(request, runtime);
        }

        public async Task<RollbackStagingConfigResponse> RollbackStagingConfigAsync(RollbackStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackStagingConfigWithOptionsAsync(request, runtime);
        }

        public SetCcConfigResponse SetCcConfigWithOptions(SetCcConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCcConfigResponse>(DoRPCRequest("SetCcConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCcConfigResponse> SetCcConfigWithOptionsAsync(SetCcConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCcConfigResponse>(await DoRPCRequestAsync("SetCcConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCcConfigResponse SetCcConfig(SetCcConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCcConfigWithOptions(request, runtime);
        }

        public async Task<SetCcConfigResponse> SetCcConfigAsync(SetCcConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCcConfigWithOptionsAsync(request, runtime);
        }

        public SetCdnDomainCSRCertificateResponse SetCdnDomainCSRCertificateWithOptions(SetCdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCdnDomainCSRCertificateResponse>(DoRPCRequest("SetCdnDomainCSRCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCdnDomainCSRCertificateResponse> SetCdnDomainCSRCertificateWithOptionsAsync(SetCdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCdnDomainCSRCertificateResponse>(await DoRPCRequestAsync("SetCdnDomainCSRCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCdnDomainCSRCertificateResponse SetCdnDomainCSRCertificate(SetCdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCdnDomainCSRCertificateWithOptions(request, runtime);
        }

        public async Task<SetCdnDomainCSRCertificateResponse> SetCdnDomainCSRCertificateAsync(SetCdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCdnDomainCSRCertificateWithOptionsAsync(request, runtime);
        }

        public SetCdnDomainStagingConfigResponse SetCdnDomainStagingConfigWithOptions(SetCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCdnDomainStagingConfigResponse>(DoRPCRequest("SetCdnDomainStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCdnDomainStagingConfigResponse> SetCdnDomainStagingConfigWithOptionsAsync(SetCdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCdnDomainStagingConfigResponse>(await DoRPCRequestAsync("SetCdnDomainStagingConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCdnDomainStagingConfigResponse SetCdnDomainStagingConfig(SetCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCdnDomainStagingConfigWithOptions(request, runtime);
        }

        public async Task<SetCdnDomainStagingConfigResponse> SetCdnDomainStagingConfigAsync(SetCdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        public SetConfigOfVersionResponse SetConfigOfVersionWithOptions(SetConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetConfigOfVersionResponse>(DoRPCRequest("SetConfigOfVersion", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetConfigOfVersionResponse> SetConfigOfVersionWithOptionsAsync(SetConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetConfigOfVersionResponse>(await DoRPCRequestAsync("SetConfigOfVersion", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetConfigOfVersionResponse SetConfigOfVersion(SetConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetConfigOfVersionWithOptions(request, runtime);
        }

        public async Task<SetConfigOfVersionResponse> SetConfigOfVersionAsync(SetConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetConfigOfVersionWithOptionsAsync(request, runtime);
        }

        public SetDomainGreenManagerConfigResponse SetDomainGreenManagerConfigWithOptions(SetDomainGreenManagerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainGreenManagerConfigResponse>(DoRPCRequest("SetDomainGreenManagerConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainGreenManagerConfigResponse> SetDomainGreenManagerConfigWithOptionsAsync(SetDomainGreenManagerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainGreenManagerConfigResponse>(await DoRPCRequestAsync("SetDomainGreenManagerConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainGreenManagerConfigResponse SetDomainGreenManagerConfig(SetDomainGreenManagerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainGreenManagerConfigWithOptions(request, runtime);
        }

        public async Task<SetDomainGreenManagerConfigResponse> SetDomainGreenManagerConfigAsync(SetDomainGreenManagerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainGreenManagerConfigWithOptionsAsync(request, runtime);
        }

        public SetDomainServerCertificateResponse SetDomainServerCertificateWithOptions(SetDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainServerCertificateResponse>(DoRPCRequest("SetDomainServerCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainServerCertificateResponse> SetDomainServerCertificateWithOptionsAsync(SetDomainServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainServerCertificateResponse>(await DoRPCRequestAsync("SetDomainServerCertificate", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainServerCertificateResponse SetDomainServerCertificate(SetDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainServerCertificateWithOptions(request, runtime);
        }

        public async Task<SetDomainServerCertificateResponse> SetDomainServerCertificateAsync(SetDomainServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainServerCertificateWithOptionsAsync(request, runtime);
        }

        public SetErrorPageConfigResponse SetErrorPageConfigWithOptions(SetErrorPageConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetErrorPageConfigResponse>(DoRPCRequest("SetErrorPageConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetErrorPageConfigResponse> SetErrorPageConfigWithOptionsAsync(SetErrorPageConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetErrorPageConfigResponse>(await DoRPCRequestAsync("SetErrorPageConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetErrorPageConfigResponse SetErrorPageConfig(SetErrorPageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetErrorPageConfigWithOptions(request, runtime);
        }

        public async Task<SetErrorPageConfigResponse> SetErrorPageConfigAsync(SetErrorPageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetErrorPageConfigWithOptionsAsync(request, runtime);
        }

        public SetFileCacheExpiredConfigResponse SetFileCacheExpiredConfigWithOptions(SetFileCacheExpiredConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetFileCacheExpiredConfigResponse>(DoRPCRequest("SetFileCacheExpiredConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetFileCacheExpiredConfigResponse> SetFileCacheExpiredConfigWithOptionsAsync(SetFileCacheExpiredConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetFileCacheExpiredConfigResponse>(await DoRPCRequestAsync("SetFileCacheExpiredConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetFileCacheExpiredConfigResponse SetFileCacheExpiredConfig(SetFileCacheExpiredConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFileCacheExpiredConfigWithOptions(request, runtime);
        }

        public async Task<SetFileCacheExpiredConfigResponse> SetFileCacheExpiredConfigAsync(SetFileCacheExpiredConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFileCacheExpiredConfigWithOptionsAsync(request, runtime);
        }

        public SetForceRedirectConfigResponse SetForceRedirectConfigWithOptions(SetForceRedirectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetForceRedirectConfigResponse>(DoRPCRequest("SetForceRedirectConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetForceRedirectConfigResponse> SetForceRedirectConfigWithOptionsAsync(SetForceRedirectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetForceRedirectConfigResponse>(await DoRPCRequestAsync("SetForceRedirectConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetForceRedirectConfigResponse SetForceRedirectConfig(SetForceRedirectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetForceRedirectConfigWithOptions(request, runtime);
        }

        public async Task<SetForceRedirectConfigResponse> SetForceRedirectConfigAsync(SetForceRedirectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetForceRedirectConfigWithOptionsAsync(request, runtime);
        }

        public SetForwardSchemeConfigResponse SetForwardSchemeConfigWithOptions(SetForwardSchemeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetForwardSchemeConfigResponse>(DoRPCRequest("SetForwardSchemeConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetForwardSchemeConfigResponse> SetForwardSchemeConfigWithOptionsAsync(SetForwardSchemeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetForwardSchemeConfigResponse>(await DoRPCRequestAsync("SetForwardSchemeConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetForwardSchemeConfigResponse SetForwardSchemeConfig(SetForwardSchemeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetForwardSchemeConfigWithOptions(request, runtime);
        }

        public async Task<SetForwardSchemeConfigResponse> SetForwardSchemeConfigAsync(SetForwardSchemeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetForwardSchemeConfigWithOptionsAsync(request, runtime);
        }

        public SetHttpErrorPageConfigResponse SetHttpErrorPageConfigWithOptions(SetHttpErrorPageConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetHttpErrorPageConfigResponse>(DoRPCRequest("SetHttpErrorPageConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetHttpErrorPageConfigResponse> SetHttpErrorPageConfigWithOptionsAsync(SetHttpErrorPageConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetHttpErrorPageConfigResponse>(await DoRPCRequestAsync("SetHttpErrorPageConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetHttpErrorPageConfigResponse SetHttpErrorPageConfig(SetHttpErrorPageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetHttpErrorPageConfigWithOptions(request, runtime);
        }

        public async Task<SetHttpErrorPageConfigResponse> SetHttpErrorPageConfigAsync(SetHttpErrorPageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetHttpErrorPageConfigWithOptionsAsync(request, runtime);
        }

        public SetHttpHeaderConfigResponse SetHttpHeaderConfigWithOptions(SetHttpHeaderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetHttpHeaderConfigResponse>(DoRPCRequest("SetHttpHeaderConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetHttpHeaderConfigResponse> SetHttpHeaderConfigWithOptionsAsync(SetHttpHeaderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetHttpHeaderConfigResponse>(await DoRPCRequestAsync("SetHttpHeaderConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetHttpHeaderConfigResponse SetHttpHeaderConfig(SetHttpHeaderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetHttpHeaderConfigWithOptions(request, runtime);
        }

        public async Task<SetHttpHeaderConfigResponse> SetHttpHeaderConfigAsync(SetHttpHeaderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetHttpHeaderConfigWithOptionsAsync(request, runtime);
        }

        public SetHttpsOptionConfigResponse SetHttpsOptionConfigWithOptions(SetHttpsOptionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetHttpsOptionConfigResponse>(DoRPCRequest("SetHttpsOptionConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetHttpsOptionConfigResponse> SetHttpsOptionConfigWithOptionsAsync(SetHttpsOptionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetHttpsOptionConfigResponse>(await DoRPCRequestAsync("SetHttpsOptionConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetHttpsOptionConfigResponse SetHttpsOptionConfig(SetHttpsOptionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetHttpsOptionConfigWithOptions(request, runtime);
        }

        public async Task<SetHttpsOptionConfigResponse> SetHttpsOptionConfigAsync(SetHttpsOptionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetHttpsOptionConfigWithOptionsAsync(request, runtime);
        }

        public SetIgnoreQueryStringConfigResponse SetIgnoreQueryStringConfigWithOptions(SetIgnoreQueryStringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIgnoreQueryStringConfigResponse>(DoRPCRequest("SetIgnoreQueryStringConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetIgnoreQueryStringConfigResponse> SetIgnoreQueryStringConfigWithOptionsAsync(SetIgnoreQueryStringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIgnoreQueryStringConfigResponse>(await DoRPCRequestAsync("SetIgnoreQueryStringConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetIgnoreQueryStringConfigResponse SetIgnoreQueryStringConfig(SetIgnoreQueryStringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIgnoreQueryStringConfigWithOptions(request, runtime);
        }

        public async Task<SetIgnoreQueryStringConfigResponse> SetIgnoreQueryStringConfigAsync(SetIgnoreQueryStringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIgnoreQueryStringConfigWithOptionsAsync(request, runtime);
        }

        public SetIpAllowListConfigResponse SetIpAllowListConfigWithOptions(SetIpAllowListConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIpAllowListConfigResponse>(DoRPCRequest("SetIpAllowListConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetIpAllowListConfigResponse> SetIpAllowListConfigWithOptionsAsync(SetIpAllowListConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIpAllowListConfigResponse>(await DoRPCRequestAsync("SetIpAllowListConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetIpAllowListConfigResponse SetIpAllowListConfig(SetIpAllowListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIpAllowListConfigWithOptions(request, runtime);
        }

        public async Task<SetIpAllowListConfigResponse> SetIpAllowListConfigAsync(SetIpAllowListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIpAllowListConfigWithOptionsAsync(request, runtime);
        }

        public SetIpBlackListConfigResponse SetIpBlackListConfigWithOptions(SetIpBlackListConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIpBlackListConfigResponse>(DoRPCRequest("SetIpBlackListConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetIpBlackListConfigResponse> SetIpBlackListConfigWithOptionsAsync(SetIpBlackListConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIpBlackListConfigResponse>(await DoRPCRequestAsync("SetIpBlackListConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetIpBlackListConfigResponse SetIpBlackListConfig(SetIpBlackListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIpBlackListConfigWithOptions(request, runtime);
        }

        public async Task<SetIpBlackListConfigResponse> SetIpBlackListConfigAsync(SetIpBlackListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIpBlackListConfigWithOptionsAsync(request, runtime);
        }

        public SetOptimizeConfigResponse SetOptimizeConfigWithOptions(SetOptimizeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetOptimizeConfigResponse>(DoRPCRequest("SetOptimizeConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetOptimizeConfigResponse> SetOptimizeConfigWithOptionsAsync(SetOptimizeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetOptimizeConfigResponse>(await DoRPCRequestAsync("SetOptimizeConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetOptimizeConfigResponse SetOptimizeConfig(SetOptimizeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetOptimizeConfigWithOptions(request, runtime);
        }

        public async Task<SetOptimizeConfigResponse> SetOptimizeConfigAsync(SetOptimizeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetOptimizeConfigWithOptionsAsync(request, runtime);
        }

        public SetPageCompressConfigResponse SetPageCompressConfigWithOptions(SetPageCompressConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetPageCompressConfigResponse>(DoRPCRequest("SetPageCompressConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetPageCompressConfigResponse> SetPageCompressConfigWithOptionsAsync(SetPageCompressConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetPageCompressConfigResponse>(await DoRPCRequestAsync("SetPageCompressConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetPageCompressConfigResponse SetPageCompressConfig(SetPageCompressConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPageCompressConfigWithOptions(request, runtime);
        }

        public async Task<SetPageCompressConfigResponse> SetPageCompressConfigAsync(SetPageCompressConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPageCompressConfigWithOptionsAsync(request, runtime);
        }

        public SetRangeConfigResponse SetRangeConfigWithOptions(SetRangeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRangeConfigResponse>(DoRPCRequest("SetRangeConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetRangeConfigResponse> SetRangeConfigWithOptionsAsync(SetRangeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRangeConfigResponse>(await DoRPCRequestAsync("SetRangeConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetRangeConfigResponse SetRangeConfig(SetRangeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRangeConfigWithOptions(request, runtime);
        }

        public async Task<SetRangeConfigResponse> SetRangeConfigAsync(SetRangeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRangeConfigWithOptionsAsync(request, runtime);
        }

        public SetRefererConfigResponse SetRefererConfigWithOptions(SetRefererConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRefererConfigResponse>(DoRPCRequest("SetRefererConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetRefererConfigResponse> SetRefererConfigWithOptionsAsync(SetRefererConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRefererConfigResponse>(await DoRPCRequestAsync("SetRefererConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetRefererConfigResponse SetRefererConfig(SetRefererConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRefererConfigWithOptions(request, runtime);
        }

        public async Task<SetRefererConfigResponse> SetRefererConfigAsync(SetRefererConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRefererConfigWithOptionsAsync(request, runtime);
        }

        public SetRemoveQueryStringConfigResponse SetRemoveQueryStringConfigWithOptions(SetRemoveQueryStringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRemoveQueryStringConfigResponse>(DoRPCRequest("SetRemoveQueryStringConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetRemoveQueryStringConfigResponse> SetRemoveQueryStringConfigWithOptionsAsync(SetRemoveQueryStringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRemoveQueryStringConfigResponse>(await DoRPCRequestAsync("SetRemoveQueryStringConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetRemoveQueryStringConfigResponse SetRemoveQueryStringConfig(SetRemoveQueryStringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRemoveQueryStringConfigWithOptions(request, runtime);
        }

        public async Task<SetRemoveQueryStringConfigResponse> SetRemoveQueryStringConfigAsync(SetRemoveQueryStringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRemoveQueryStringConfigWithOptionsAsync(request, runtime);
        }

        public SetReqAuthConfigResponse SetReqAuthConfigWithOptions(SetReqAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetReqAuthConfigResponse>(DoRPCRequest("SetReqAuthConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetReqAuthConfigResponse> SetReqAuthConfigWithOptionsAsync(SetReqAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetReqAuthConfigResponse>(await DoRPCRequestAsync("SetReqAuthConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetReqAuthConfigResponse SetReqAuthConfig(SetReqAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetReqAuthConfigWithOptions(request, runtime);
        }

        public async Task<SetReqAuthConfigResponse> SetReqAuthConfigAsync(SetReqAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetReqAuthConfigWithOptionsAsync(request, runtime);
        }

        public SetReqHeaderConfigResponse SetReqHeaderConfigWithOptions(SetReqHeaderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetReqHeaderConfigResponse>(DoRPCRequest("SetReqHeaderConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetReqHeaderConfigResponse> SetReqHeaderConfigWithOptionsAsync(SetReqHeaderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetReqHeaderConfigResponse>(await DoRPCRequestAsync("SetReqHeaderConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetReqHeaderConfigResponse SetReqHeaderConfig(SetReqHeaderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetReqHeaderConfigWithOptions(request, runtime);
        }

        public async Task<SetReqHeaderConfigResponse> SetReqHeaderConfigAsync(SetReqHeaderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetReqHeaderConfigWithOptionsAsync(request, runtime);
        }

        public SetSourceHostConfigResponse SetSourceHostConfigWithOptions(SetSourceHostConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSourceHostConfigResponse>(DoRPCRequest("SetSourceHostConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetSourceHostConfigResponse> SetSourceHostConfigWithOptionsAsync(SetSourceHostConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSourceHostConfigResponse>(await DoRPCRequestAsync("SetSourceHostConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetSourceHostConfigResponse SetSourceHostConfig(SetSourceHostConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSourceHostConfigWithOptions(request, runtime);
        }

        public async Task<SetSourceHostConfigResponse> SetSourceHostConfigAsync(SetSourceHostConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSourceHostConfigWithOptionsAsync(request, runtime);
        }

        public SetWaitingRoomConfigResponse SetWaitingRoomConfigWithOptions(SetWaitingRoomConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetWaitingRoomConfigResponse>(DoRPCRequest("SetWaitingRoomConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetWaitingRoomConfigResponse> SetWaitingRoomConfigWithOptionsAsync(SetWaitingRoomConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetWaitingRoomConfigResponse>(await DoRPCRequestAsync("SetWaitingRoomConfig", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetWaitingRoomConfigResponse SetWaitingRoomConfig(SetWaitingRoomConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWaitingRoomConfigWithOptions(request, runtime);
        }

        public async Task<SetWaitingRoomConfigResponse> SetWaitingRoomConfigAsync(SetWaitingRoomConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWaitingRoomConfigWithOptionsAsync(request, runtime);
        }

        public StartCdnDomainResponse StartCdnDomainWithOptions(StartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCdnDomainResponse>(DoRPCRequest("StartCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartCdnDomainResponse> StartCdnDomainWithOptionsAsync(StartCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCdnDomainResponse>(await DoRPCRequestAsync("StartCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartCdnDomainResponse StartCdnDomain(StartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCdnDomainWithOptions(request, runtime);
        }

        public async Task<StartCdnDomainResponse> StartCdnDomainAsync(StartCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCdnDomainWithOptionsAsync(request, runtime);
        }

        public StopCdnDomainResponse StopCdnDomainWithOptions(StopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCdnDomainResponse>(DoRPCRequest("StopCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopCdnDomainResponse> StopCdnDomainWithOptionsAsync(StopCdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCdnDomainResponse>(await DoRPCRequestAsync("StopCdnDomain", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopCdnDomainResponse StopCdnDomain(StopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCdnDomainWithOptions(request, runtime);
        }

        public async Task<StopCdnDomainResponse> StopCdnDomainAsync(StopCdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCdnDomainWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateFCTriggerResponse UpdateFCTriggerWithOptions(UpdateFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFCTriggerResponse>(DoRPCRequest("UpdateFCTrigger", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFCTriggerResponse> UpdateFCTriggerWithOptionsAsync(UpdateFCTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFCTriggerResponse>(await DoRPCRequestAsync("UpdateFCTrigger", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFCTriggerResponse UpdateFCTrigger(UpdateFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFCTriggerWithOptions(request, runtime);
        }

        public async Task<UpdateFCTriggerResponse> UpdateFCTriggerAsync(UpdateFCTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFCTriggerWithOptionsAsync(request, runtime);
        }

        public VerifyDomainOwnerResponse VerifyDomainOwnerWithOptions(VerifyDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyDomainOwnerResponse>(DoRPCRequest("VerifyDomainOwner", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyDomainOwnerResponse> VerifyDomainOwnerWithOptionsAsync(VerifyDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyDomainOwnerResponse>(await DoRPCRequestAsync("VerifyDomainOwner", "2018-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyDomainOwnerResponse VerifyDomainOwner(VerifyDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyDomainOwnerWithOptions(request, runtime);
        }

        public async Task<VerifyDomainOwnerResponse> VerifyDomainOwnerAsync(VerifyDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
