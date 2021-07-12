// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vs20181212.Models;

namespace AlibabaCloud.SDK.Vs20181212
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddDeviceResponse AddDeviceWithOptions(AddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDeviceResponse>(DoRPCRequest("AddDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDeviceResponse> AddDeviceWithOptionsAsync(AddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDeviceResponse>(await DoRPCRequestAsync("AddDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDeviceResponse AddDevice(AddDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDeviceWithOptions(request, runtime);
        }

        public async Task<AddDeviceResponse> AddDeviceAsync(AddDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDeviceWithOptionsAsync(request, runtime);
        }

        public AddVsPullStreamInfoConfigResponse AddVsPullStreamInfoConfigWithOptions(AddVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVsPullStreamInfoConfigResponse>(DoRPCRequest("AddVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVsPullStreamInfoConfigResponse> AddVsPullStreamInfoConfigWithOptionsAsync(AddVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVsPullStreamInfoConfigResponse>(await DoRPCRequestAsync("AddVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVsPullStreamInfoConfigResponse AddVsPullStreamInfoConfig(AddVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVsPullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<AddVsPullStreamInfoConfigResponse> AddVsPullStreamInfoConfigAsync(AddVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVsPullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public BatchBindDirectoriesResponse BatchBindDirectoriesWithOptions(BatchBindDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindDirectoriesResponse>(DoRPCRequest("BatchBindDirectories", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchBindDirectoriesResponse> BatchBindDirectoriesWithOptionsAsync(BatchBindDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindDirectoriesResponse>(await DoRPCRequestAsync("BatchBindDirectories", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchBindDirectoriesResponse BatchBindDirectories(BatchBindDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindDirectoriesWithOptions(request, runtime);
        }

        public async Task<BatchBindDirectoriesResponse> BatchBindDirectoriesAsync(BatchBindDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindDirectoriesWithOptionsAsync(request, runtime);
        }

        public BatchBindParentPlatformDevicesResponse BatchBindParentPlatformDevicesWithOptions(BatchBindParentPlatformDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindParentPlatformDevicesResponse>(DoRPCRequest("BatchBindParentPlatformDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchBindParentPlatformDevicesResponse> BatchBindParentPlatformDevicesWithOptionsAsync(BatchBindParentPlatformDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindParentPlatformDevicesResponse>(await DoRPCRequestAsync("BatchBindParentPlatformDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchBindParentPlatformDevicesResponse BatchBindParentPlatformDevices(BatchBindParentPlatformDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindParentPlatformDevicesWithOptions(request, runtime);
        }

        public async Task<BatchBindParentPlatformDevicesResponse> BatchBindParentPlatformDevicesAsync(BatchBindParentPlatformDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindParentPlatformDevicesWithOptionsAsync(request, runtime);
        }

        public BatchBindPurchasedDevicesResponse BatchBindPurchasedDevicesWithOptions(BatchBindPurchasedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindPurchasedDevicesResponse>(DoRPCRequest("BatchBindPurchasedDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchBindPurchasedDevicesResponse> BatchBindPurchasedDevicesWithOptionsAsync(BatchBindPurchasedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindPurchasedDevicesResponse>(await DoRPCRequestAsync("BatchBindPurchasedDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchBindPurchasedDevicesResponse BatchBindPurchasedDevices(BatchBindPurchasedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindPurchasedDevicesWithOptions(request, runtime);
        }

        public async Task<BatchBindPurchasedDevicesResponse> BatchBindPurchasedDevicesAsync(BatchBindPurchasedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindPurchasedDevicesWithOptionsAsync(request, runtime);
        }

        public BatchBindTemplateResponse BatchBindTemplateWithOptions(BatchBindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindTemplateResponse>(DoRPCRequest("BatchBindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchBindTemplateResponse> BatchBindTemplateWithOptionsAsync(BatchBindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindTemplateResponse>(await DoRPCRequestAsync("BatchBindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchBindTemplateResponse BatchBindTemplate(BatchBindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindTemplateWithOptions(request, runtime);
        }

        public async Task<BatchBindTemplateResponse> BatchBindTemplateAsync(BatchBindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindTemplateWithOptionsAsync(request, runtime);
        }

        public BatchBindTemplatesResponse BatchBindTemplatesWithOptions(BatchBindTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindTemplatesResponse>(DoRPCRequest("BatchBindTemplates", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchBindTemplatesResponse> BatchBindTemplatesWithOptionsAsync(BatchBindTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchBindTemplatesResponse>(await DoRPCRequestAsync("BatchBindTemplates", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchBindTemplatesResponse BatchBindTemplates(BatchBindTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindTemplatesWithOptions(request, runtime);
        }

        public async Task<BatchBindTemplatesResponse> BatchBindTemplatesAsync(BatchBindTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindTemplatesWithOptionsAsync(request, runtime);
        }

        public BatchDeleteDevicesResponse BatchDeleteDevicesWithOptions(BatchDeleteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteDevicesResponse>(DoRPCRequest("BatchDeleteDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteDevicesResponse> BatchDeleteDevicesWithOptionsAsync(BatchDeleteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteDevicesResponse>(await DoRPCRequestAsync("BatchDeleteDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteDevicesResponse BatchDeleteDevices(BatchDeleteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDevicesWithOptions(request, runtime);
        }

        public async Task<BatchDeleteDevicesResponse> BatchDeleteDevicesAsync(BatchDeleteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDevicesWithOptionsAsync(request, runtime);
        }

        public BatchDeleteVsDomainConfigsResponse BatchDeleteVsDomainConfigsWithOptions(BatchDeleteVsDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteVsDomainConfigsResponse>(DoRPCRequest("BatchDeleteVsDomainConfigs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteVsDomainConfigsResponse> BatchDeleteVsDomainConfigsWithOptionsAsync(BatchDeleteVsDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteVsDomainConfigsResponse>(await DoRPCRequestAsync("BatchDeleteVsDomainConfigs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteVsDomainConfigsResponse BatchDeleteVsDomainConfigs(BatchDeleteVsDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteVsDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteVsDomainConfigsResponse> BatchDeleteVsDomainConfigsAsync(BatchDeleteVsDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteVsDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchForbidVsStreamResponse BatchForbidVsStreamWithOptions(BatchForbidVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchForbidVsStreamResponse>(DoRPCRequest("BatchForbidVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchForbidVsStreamResponse> BatchForbidVsStreamWithOptionsAsync(BatchForbidVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchForbidVsStreamResponse>(await DoRPCRequestAsync("BatchForbidVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchForbidVsStreamResponse BatchForbidVsStream(BatchForbidVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchForbidVsStreamWithOptions(request, runtime);
        }

        public async Task<BatchForbidVsStreamResponse> BatchForbidVsStreamAsync(BatchForbidVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchForbidVsStreamWithOptionsAsync(request, runtime);
        }

        public BatchResumeVsStreamResponse BatchResumeVsStreamWithOptions(BatchResumeVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchResumeVsStreamResponse>(DoRPCRequest("BatchResumeVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchResumeVsStreamResponse> BatchResumeVsStreamWithOptionsAsync(BatchResumeVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchResumeVsStreamResponse>(await DoRPCRequestAsync("BatchResumeVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchResumeVsStreamResponse BatchResumeVsStream(BatchResumeVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchResumeVsStreamWithOptions(request, runtime);
        }

        public async Task<BatchResumeVsStreamResponse> BatchResumeVsStreamAsync(BatchResumeVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchResumeVsStreamWithOptionsAsync(request, runtime);
        }

        public BatchSetVsDomainConfigsResponse BatchSetVsDomainConfigsWithOptions(BatchSetVsDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetVsDomainConfigsResponse>(DoRPCRequest("BatchSetVsDomainConfigs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetVsDomainConfigsResponse> BatchSetVsDomainConfigsWithOptionsAsync(BatchSetVsDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetVsDomainConfigsResponse>(await DoRPCRequestAsync("BatchSetVsDomainConfigs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetVsDomainConfigsResponse BatchSetVsDomainConfigs(BatchSetVsDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetVsDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetVsDomainConfigsResponse> BatchSetVsDomainConfigsAsync(BatchSetVsDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetVsDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchStartDevicesResponse BatchStartDevicesWithOptions(BatchStartDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartDevicesResponse>(DoRPCRequest("BatchStartDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStartDevicesResponse> BatchStartDevicesWithOptionsAsync(BatchStartDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartDevicesResponse>(await DoRPCRequestAsync("BatchStartDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStartDevicesResponse BatchStartDevices(BatchStartDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartDevicesWithOptions(request, runtime);
        }

        public async Task<BatchStartDevicesResponse> BatchStartDevicesAsync(BatchStartDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartDevicesWithOptionsAsync(request, runtime);
        }

        public BatchStartStreamsResponse BatchStartStreamsWithOptions(BatchStartStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartStreamsResponse>(DoRPCRequest("BatchStartStreams", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStartStreamsResponse> BatchStartStreamsWithOptionsAsync(BatchStartStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartStreamsResponse>(await DoRPCRequestAsync("BatchStartStreams", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStartStreamsResponse BatchStartStreams(BatchStartStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartStreamsWithOptions(request, runtime);
        }

        public async Task<BatchStartStreamsResponse> BatchStartStreamsAsync(BatchStartStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartStreamsWithOptionsAsync(request, runtime);
        }

        public BatchStopDevicesResponse BatchStopDevicesWithOptions(BatchStopDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopDevicesResponse>(DoRPCRequest("BatchStopDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStopDevicesResponse> BatchStopDevicesWithOptionsAsync(BatchStopDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopDevicesResponse>(await DoRPCRequestAsync("BatchStopDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStopDevicesResponse BatchStopDevices(BatchStopDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopDevicesWithOptions(request, runtime);
        }

        public async Task<BatchStopDevicesResponse> BatchStopDevicesAsync(BatchStopDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopDevicesWithOptionsAsync(request, runtime);
        }

        public BatchStopStreamsResponse BatchStopStreamsWithOptions(BatchStopStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopStreamsResponse>(DoRPCRequest("BatchStopStreams", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStopStreamsResponse> BatchStopStreamsWithOptionsAsync(BatchStopStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopStreamsResponse>(await DoRPCRequestAsync("BatchStopStreams", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStopStreamsResponse BatchStopStreams(BatchStopStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopStreamsWithOptions(request, runtime);
        }

        public async Task<BatchStopStreamsResponse> BatchStopStreamsAsync(BatchStopStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopStreamsWithOptionsAsync(request, runtime);
        }

        public BatchUnbindDirectoriesResponse BatchUnbindDirectoriesWithOptions(BatchUnbindDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindDirectoriesResponse>(DoRPCRequest("BatchUnbindDirectories", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUnbindDirectoriesResponse> BatchUnbindDirectoriesWithOptionsAsync(BatchUnbindDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindDirectoriesResponse>(await DoRPCRequestAsync("BatchUnbindDirectories", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUnbindDirectoriesResponse BatchUnbindDirectories(BatchUnbindDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindDirectoriesWithOptions(request, runtime);
        }

        public async Task<BatchUnbindDirectoriesResponse> BatchUnbindDirectoriesAsync(BatchUnbindDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindDirectoriesWithOptionsAsync(request, runtime);
        }

        public BatchUnbindParentPlatformDevicesResponse BatchUnbindParentPlatformDevicesWithOptions(BatchUnbindParentPlatformDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindParentPlatformDevicesResponse>(DoRPCRequest("BatchUnbindParentPlatformDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUnbindParentPlatformDevicesResponse> BatchUnbindParentPlatformDevicesWithOptionsAsync(BatchUnbindParentPlatformDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindParentPlatformDevicesResponse>(await DoRPCRequestAsync("BatchUnbindParentPlatformDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUnbindParentPlatformDevicesResponse BatchUnbindParentPlatformDevices(BatchUnbindParentPlatformDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindParentPlatformDevicesWithOptions(request, runtime);
        }

        public async Task<BatchUnbindParentPlatformDevicesResponse> BatchUnbindParentPlatformDevicesAsync(BatchUnbindParentPlatformDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindParentPlatformDevicesWithOptionsAsync(request, runtime);
        }

        public BatchUnbindPurchasedDevicesResponse BatchUnbindPurchasedDevicesWithOptions(BatchUnbindPurchasedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindPurchasedDevicesResponse>(DoRPCRequest("BatchUnbindPurchasedDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUnbindPurchasedDevicesResponse> BatchUnbindPurchasedDevicesWithOptionsAsync(BatchUnbindPurchasedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindPurchasedDevicesResponse>(await DoRPCRequestAsync("BatchUnbindPurchasedDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUnbindPurchasedDevicesResponse BatchUnbindPurchasedDevices(BatchUnbindPurchasedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindPurchasedDevicesWithOptions(request, runtime);
        }

        public async Task<BatchUnbindPurchasedDevicesResponse> BatchUnbindPurchasedDevicesAsync(BatchUnbindPurchasedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindPurchasedDevicesWithOptionsAsync(request, runtime);
        }

        public BatchUnbindTemplateResponse BatchUnbindTemplateWithOptions(BatchUnbindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindTemplateResponse>(DoRPCRequest("BatchUnbindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUnbindTemplateResponse> BatchUnbindTemplateWithOptionsAsync(BatchUnbindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindTemplateResponse>(await DoRPCRequestAsync("BatchUnbindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUnbindTemplateResponse BatchUnbindTemplate(BatchUnbindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindTemplateWithOptions(request, runtime);
        }

        public async Task<BatchUnbindTemplateResponse> BatchUnbindTemplateAsync(BatchUnbindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindTemplateWithOptionsAsync(request, runtime);
        }

        public BatchUnbindTemplatesResponse BatchUnbindTemplatesWithOptions(BatchUnbindTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindTemplatesResponse>(DoRPCRequest("BatchUnbindTemplates", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUnbindTemplatesResponse> BatchUnbindTemplatesWithOptionsAsync(BatchUnbindTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUnbindTemplatesResponse>(await DoRPCRequestAsync("BatchUnbindTemplates", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUnbindTemplatesResponse BatchUnbindTemplates(BatchUnbindTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindTemplatesWithOptions(request, runtime);
        }

        public async Task<BatchUnbindTemplatesResponse> BatchUnbindTemplatesAsync(BatchUnbindTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindTemplatesWithOptionsAsync(request, runtime);
        }

        public BindDirectoryResponse BindDirectoryWithOptions(BindDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindDirectoryResponse>(DoRPCRequest("BindDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindDirectoryResponse> BindDirectoryWithOptionsAsync(BindDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindDirectoryResponse>(await DoRPCRequestAsync("BindDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindDirectoryResponse BindDirectory(BindDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindDirectoryWithOptions(request, runtime);
        }

        public async Task<BindDirectoryResponse> BindDirectoryAsync(BindDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindDirectoryWithOptionsAsync(request, runtime);
        }

        public BindParentPlatformDeviceResponse BindParentPlatformDeviceWithOptions(BindParentPlatformDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindParentPlatformDeviceResponse>(DoRPCRequest("BindParentPlatformDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindParentPlatformDeviceResponse> BindParentPlatformDeviceWithOptionsAsync(BindParentPlatformDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindParentPlatformDeviceResponse>(await DoRPCRequestAsync("BindParentPlatformDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindParentPlatformDeviceResponse BindParentPlatformDevice(BindParentPlatformDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindParentPlatformDeviceWithOptions(request, runtime);
        }

        public async Task<BindParentPlatformDeviceResponse> BindParentPlatformDeviceAsync(BindParentPlatformDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindParentPlatformDeviceWithOptionsAsync(request, runtime);
        }

        public BindPurchasedDeviceResponse BindPurchasedDeviceWithOptions(BindPurchasedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPurchasedDeviceResponse>(DoRPCRequest("BindPurchasedDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindPurchasedDeviceResponse> BindPurchasedDeviceWithOptionsAsync(BindPurchasedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPurchasedDeviceResponse>(await DoRPCRequestAsync("BindPurchasedDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindPurchasedDeviceResponse BindPurchasedDevice(BindPurchasedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPurchasedDeviceWithOptions(request, runtime);
        }

        public async Task<BindPurchasedDeviceResponse> BindPurchasedDeviceAsync(BindPurchasedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPurchasedDeviceWithOptionsAsync(request, runtime);
        }

        public BindTemplateResponse BindTemplateWithOptions(BindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindTemplateResponse>(DoRPCRequest("BindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindTemplateResponse> BindTemplateWithOptionsAsync(BindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindTemplateResponse>(await DoRPCRequestAsync("BindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindTemplateResponse BindTemplate(BindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindTemplateWithOptions(request, runtime);
        }

        public async Task<BindTemplateResponse> BindTemplateAsync(BindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindTemplateWithOptionsAsync(request, runtime);
        }

        public ContinuousAdjustResponse ContinuousAdjustWithOptions(ContinuousAdjustRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinuousAdjustResponse>(DoRPCRequest("ContinuousAdjust", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ContinuousAdjustResponse> ContinuousAdjustWithOptionsAsync(ContinuousAdjustRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinuousAdjustResponse>(await DoRPCRequestAsync("ContinuousAdjust", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ContinuousAdjustResponse ContinuousAdjust(ContinuousAdjustRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinuousAdjustWithOptions(request, runtime);
        }

        public async Task<ContinuousAdjustResponse> ContinuousAdjustAsync(ContinuousAdjustRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinuousAdjustWithOptionsAsync(request, runtime);
        }

        public ContinuousMoveResponse ContinuousMoveWithOptions(ContinuousMoveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinuousMoveResponse>(DoRPCRequest("ContinuousMove", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ContinuousMoveResponse> ContinuousMoveWithOptionsAsync(ContinuousMoveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinuousMoveResponse>(await DoRPCRequestAsync("ContinuousMove", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ContinuousMoveResponse ContinuousMove(ContinuousMoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinuousMoveWithOptions(request, runtime);
        }

        public async Task<ContinuousMoveResponse> ContinuousMoveAsync(ContinuousMoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinuousMoveWithOptionsAsync(request, runtime);
        }

        public CreateDeviceResponse CreateDeviceWithOptions(CreateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceResponse>(DoRPCRequest("CreateDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceResponse> CreateDeviceWithOptionsAsync(CreateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceResponse>(await DoRPCRequestAsync("CreateDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeviceResponse CreateDevice(CreateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceWithOptions(request, runtime);
        }

        public async Task<CreateDeviceResponse> CreateDeviceAsync(CreateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceWithOptionsAsync(request, runtime);
        }

        public CreateDeviceAlarmResponse CreateDeviceAlarmWithOptions(CreateDeviceAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceAlarmResponse>(DoRPCRequest("CreateDeviceAlarm", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceAlarmResponse> CreateDeviceAlarmWithOptionsAsync(CreateDeviceAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceAlarmResponse>(await DoRPCRequestAsync("CreateDeviceAlarm", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeviceAlarmResponse CreateDeviceAlarm(CreateDeviceAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceAlarmWithOptions(request, runtime);
        }

        public async Task<CreateDeviceAlarmResponse> CreateDeviceAlarmAsync(CreateDeviceAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceAlarmWithOptionsAsync(request, runtime);
        }

        public CreateDeviceSnapshotResponse CreateDeviceSnapshotWithOptions(CreateDeviceSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceSnapshotResponse>(DoRPCRequest("CreateDeviceSnapshot", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeviceSnapshotResponse> CreateDeviceSnapshotWithOptionsAsync(CreateDeviceSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeviceSnapshotResponse>(await DoRPCRequestAsync("CreateDeviceSnapshot", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeviceSnapshotResponse CreateDeviceSnapshot(CreateDeviceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceSnapshotWithOptions(request, runtime);
        }

        public async Task<CreateDeviceSnapshotResponse> CreateDeviceSnapshotAsync(CreateDeviceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceSnapshotWithOptionsAsync(request, runtime);
        }

        public CreateDirectoryResponse CreateDirectoryWithOptions(CreateDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDirectoryResponse>(DoRPCRequest("CreateDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDirectoryResponse> CreateDirectoryWithOptionsAsync(CreateDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDirectoryResponse>(await DoRPCRequestAsync("CreateDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDirectoryWithOptions(request, runtime);
        }

        public async Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDirectoryWithOptionsAsync(request, runtime);
        }

        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupResponse>(DoRPCRequest("CreateGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupResponse>(await DoRPCRequestAsync("CreateGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupWithOptions(request, runtime);
        }

        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupWithOptionsAsync(request, runtime);
        }

        public CreateParentPlatformResponse CreateParentPlatformWithOptions(CreateParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParentPlatformResponse>(DoRPCRequest("CreateParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateParentPlatformResponse> CreateParentPlatformWithOptionsAsync(CreateParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParentPlatformResponse>(await DoRPCRequestAsync("CreateParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateParentPlatformResponse CreateParentPlatform(CreateParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParentPlatformWithOptions(request, runtime);
        }

        public async Task<CreateParentPlatformResponse> CreateParentPlatformAsync(CreateParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParentPlatformWithOptionsAsync(request, runtime);
        }

        public CreateStreamSnapshotResponse CreateStreamSnapshotWithOptions(CreateStreamSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStreamSnapshotResponse>(DoRPCRequest("CreateStreamSnapshot", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateStreamSnapshotResponse> CreateStreamSnapshotWithOptionsAsync(CreateStreamSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStreamSnapshotResponse>(await DoRPCRequestAsync("CreateStreamSnapshot", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateStreamSnapshotResponse CreateStreamSnapshot(CreateStreamSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStreamSnapshotWithOptions(request, runtime);
        }

        public async Task<CreateStreamSnapshotResponse> CreateStreamSnapshotAsync(CreateStreamSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStreamSnapshotWithOptionsAsync(request, runtime);
        }

        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(DoRPCRequest("CreateTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await DoRPCRequestAsync("CreateTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteBucketResponse DeleteBucketWithOptions(DeleteBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBucketResponse>(DoRPCRequest("DeleteBucket", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBucketResponse> DeleteBucketWithOptionsAsync(DeleteBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBucketResponse>(await DoRPCRequestAsync("DeleteBucket", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBucketWithOptions(request, runtime);
        }

        public async Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBucketWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceResponse DeleteDeviceWithOptions(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceResponse>(DoRPCRequest("DeleteDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceWithOptionsAsync(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeviceResponse>(await DoRPCRequestAsync("DeleteDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteDirectoryResponse DeleteDirectoryWithOptions(DeleteDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDirectoryResponse>(DoRPCRequest("DeleteDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDirectoryResponse> DeleteDirectoryWithOptionsAsync(DeleteDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDirectoryResponse>(await DoRPCRequestAsync("DeleteDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDirectoryWithOptions(request, runtime);
        }

        public async Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDirectoryWithOptionsAsync(request, runtime);
        }

        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupResponse>(DoRPCRequest("DeleteGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await DoRPCRequestAsync("DeleteGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupWithOptions(request, runtime);
        }

        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupWithOptionsAsync(request, runtime);
        }

        public DeleteParentPlatformResponse DeleteParentPlatformWithOptions(DeleteParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParentPlatformResponse>(DoRPCRequest("DeleteParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteParentPlatformResponse> DeleteParentPlatformWithOptionsAsync(DeleteParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParentPlatformResponse>(await DoRPCRequestAsync("DeleteParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteParentPlatformResponse DeleteParentPlatform(DeleteParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParentPlatformWithOptions(request, runtime);
        }

        public async Task<DeleteParentPlatformResponse> DeleteParentPlatformAsync(DeleteParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParentPlatformWithOptionsAsync(request, runtime);
        }

        public DeletePresetResponse DeletePresetWithOptions(DeletePresetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePresetResponse>(DoRPCRequest("DeletePreset", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePresetResponse> DeletePresetWithOptionsAsync(DeletePresetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePresetResponse>(await DoRPCRequestAsync("DeletePreset", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePresetResponse DeletePreset(DeletePresetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePresetWithOptions(request, runtime);
        }

        public async Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePresetWithOptionsAsync(request, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(DoRPCRequest("DeleteTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await DoRPCRequestAsync("DeleteTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteVsPullStreamInfoConfigResponse DeleteVsPullStreamInfoConfigWithOptions(DeleteVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVsPullStreamInfoConfigResponse>(DoRPCRequest("DeleteVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVsPullStreamInfoConfigResponse> DeleteVsPullStreamInfoConfigWithOptionsAsync(DeleteVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVsPullStreamInfoConfigResponse>(await DoRPCRequestAsync("DeleteVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVsPullStreamInfoConfigResponse DeleteVsPullStreamInfoConfig(DeleteVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVsPullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<DeleteVsPullStreamInfoConfigResponse> DeleteVsPullStreamInfoConfigAsync(DeleteVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVsPullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public DeleteVsStreamsNotifyUrlConfigResponse DeleteVsStreamsNotifyUrlConfigWithOptions(DeleteVsStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVsStreamsNotifyUrlConfigResponse>(DoRPCRequest("DeleteVsStreamsNotifyUrlConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVsStreamsNotifyUrlConfigResponse> DeleteVsStreamsNotifyUrlConfigWithOptionsAsync(DeleteVsStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVsStreamsNotifyUrlConfigResponse>(await DoRPCRequestAsync("DeleteVsStreamsNotifyUrlConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVsStreamsNotifyUrlConfigResponse DeleteVsStreamsNotifyUrlConfig(DeleteVsStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVsStreamsNotifyUrlConfigWithOptions(request, runtime);
        }

        public async Task<DeleteVsStreamsNotifyUrlConfigResponse> DeleteVsStreamsNotifyUrlConfigAsync(DeleteVsStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVsStreamsNotifyUrlConfigWithOptionsAsync(request, runtime);
        }

        public DescribeAccountStatResponse DescribeAccountStatWithOptions(DescribeAccountStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountStatResponse>(DoRPCRequest("DescribeAccountStat", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountStatResponse> DescribeAccountStatWithOptionsAsync(DescribeAccountStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountStatResponse>(await DoRPCRequestAsync("DescribeAccountStat", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountStatResponse DescribeAccountStat(DescribeAccountStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountStatWithOptions(request, runtime);
        }

        public async Task<DescribeAccountStatResponse> DescribeAccountStatAsync(DescribeAccountStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountStatWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceResponse DescribeDeviceWithOptions(DescribeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceResponse>(DoRPCRequest("DescribeDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceResponse> DescribeDeviceWithOptionsAsync(DescribeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceResponse>(await DoRPCRequestAsync("DescribeDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceChannelsResponse DescribeDeviceChannelsWithOptions(DescribeDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceChannelsResponse>(DoRPCRequest("DescribeDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceChannelsResponse> DescribeDeviceChannelsWithOptionsAsync(DescribeDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceChannelsResponse>(await DoRPCRequestAsync("DescribeDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceChannelsResponse DescribeDeviceChannels(DescribeDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceChannelsWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceChannelsResponse> DescribeDeviceChannelsAsync(DescribeDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceChannelsWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceGatewayResponse DescribeDeviceGatewayWithOptions(DescribeDeviceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceGatewayResponse>(DoRPCRequest("DescribeDeviceGateway", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceGatewayResponse> DescribeDeviceGatewayWithOptionsAsync(DescribeDeviceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceGatewayResponse>(await DoRPCRequestAsync("DescribeDeviceGateway", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceGatewayResponse DescribeDeviceGateway(DescribeDeviceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceGatewayWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceGatewayResponse> DescribeDeviceGatewayAsync(DescribeDeviceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeDevicesResponse DescribeDevicesWithOptions(DescribeDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDevicesResponse>(DoRPCRequest("DescribeDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDevicesResponse> DescribeDevicesWithOptionsAsync(DescribeDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDevicesResponse>(await DoRPCRequestAsync("DescribeDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDevicesResponse DescribeDevices(DescribeDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDevicesWithOptions(request, runtime);
        }

        public async Task<DescribeDevicesResponse> DescribeDevicesAsync(DescribeDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDevicesWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceURLResponse DescribeDeviceURLWithOptions(DescribeDeviceURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceURLResponse>(DoRPCRequest("DescribeDeviceURL", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceURLResponse> DescribeDeviceURLWithOptionsAsync(DescribeDeviceURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceURLResponse>(await DoRPCRequestAsync("DescribeDeviceURL", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceURLResponse DescribeDeviceURL(DescribeDeviceURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceURLWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceURLResponse> DescribeDeviceURLAsync(DescribeDeviceURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceURLWithOptionsAsync(request, runtime);
        }

        public DescribeDirectoriesResponse DescribeDirectoriesWithOptions(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDirectoriesResponse>(DoRPCRequest("DescribeDirectories", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesWithOptionsAsync(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDirectoriesResponse>(await DoRPCRequestAsync("DescribeDirectories", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirectoriesWithOptions(request, runtime);
        }

        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirectoriesWithOptionsAsync(request, runtime);
        }

        public DescribeDirectoryResponse DescribeDirectoryWithOptions(DescribeDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDirectoryResponse>(DoRPCRequest("DescribeDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDirectoryResponse> DescribeDirectoryWithOptionsAsync(DescribeDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDirectoryResponse>(await DoRPCRequestAsync("DescribeDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDirectoryResponse DescribeDirectory(DescribeDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirectoryWithOptions(request, runtime);
        }

        public async Task<DescribeDirectoryResponse> DescribeDirectoryAsync(DescribeDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirectoryWithOptionsAsync(request, runtime);
        }

        public DescribeGroupResponse DescribeGroupWithOptions(DescribeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupResponse>(DoRPCRequest("DescribeGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupResponse> DescribeGroupWithOptionsAsync(DescribeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupResponse>(await DoRPCRequestAsync("DescribeGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupWithOptions(request, runtime);
        }

        public async Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupWithOptionsAsync(request, runtime);
        }

        public DescribeGroupsResponse DescribeGroupsWithOptions(DescribeGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupsResponse>(DoRPCRequest("DescribeGroups", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupsResponse> DescribeGroupsWithOptionsAsync(DescribeGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupsResponse>(await DoRPCRequestAsync("DescribeGroups", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupsResponse DescribeGroups(DescribeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeGroupsResponse> DescribeGroupsAsync(DescribeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeParentPlatformResponse DescribeParentPlatformWithOptions(DescribeParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParentPlatformResponse>(DoRPCRequest("DescribeParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParentPlatformResponse> DescribeParentPlatformWithOptionsAsync(DescribeParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParentPlatformResponse>(await DoRPCRequestAsync("DescribeParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParentPlatformResponse DescribeParentPlatform(DescribeParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParentPlatformWithOptions(request, runtime);
        }

        public async Task<DescribeParentPlatformResponse> DescribeParentPlatformAsync(DescribeParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParentPlatformWithOptionsAsync(request, runtime);
        }

        public DescribeParentPlatformDevicesResponse DescribeParentPlatformDevicesWithOptions(DescribeParentPlatformDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParentPlatformDevicesResponse>(DoRPCRequest("DescribeParentPlatformDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParentPlatformDevicesResponse> DescribeParentPlatformDevicesWithOptionsAsync(DescribeParentPlatformDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParentPlatformDevicesResponse>(await DoRPCRequestAsync("DescribeParentPlatformDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParentPlatformDevicesResponse DescribeParentPlatformDevices(DescribeParentPlatformDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParentPlatformDevicesWithOptions(request, runtime);
        }

        public async Task<DescribeParentPlatformDevicesResponse> DescribeParentPlatformDevicesAsync(DescribeParentPlatformDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParentPlatformDevicesWithOptionsAsync(request, runtime);
        }

        public DescribeParentPlatformsResponse DescribeParentPlatformsWithOptions(DescribeParentPlatformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParentPlatformsResponse>(DoRPCRequest("DescribeParentPlatforms", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeParentPlatformsResponse> DescribeParentPlatformsWithOptionsAsync(DescribeParentPlatformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeParentPlatformsResponse>(await DoRPCRequestAsync("DescribeParentPlatforms", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeParentPlatformsResponse DescribeParentPlatforms(DescribeParentPlatformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParentPlatformsWithOptions(request, runtime);
        }

        public async Task<DescribeParentPlatformsResponse> DescribeParentPlatformsAsync(DescribeParentPlatformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParentPlatformsWithOptionsAsync(request, runtime);
        }

        public DescribePresetsResponse DescribePresetsWithOptions(DescribePresetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePresetsResponse>(DoRPCRequest("DescribePresets", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePresetsResponse> DescribePresetsWithOptionsAsync(DescribePresetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePresetsResponse>(await DoRPCRequestAsync("DescribePresets", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePresetsResponse DescribePresets(DescribePresetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePresetsWithOptions(request, runtime);
        }

        public async Task<DescribePresetsResponse> DescribePresetsAsync(DescribePresetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePresetsWithOptionsAsync(request, runtime);
        }

        public DescribePurchasedDeviceResponse DescribePurchasedDeviceWithOptions(DescribePurchasedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedDeviceResponse>(DoRPCRequest("DescribePurchasedDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePurchasedDeviceResponse> DescribePurchasedDeviceWithOptionsAsync(DescribePurchasedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedDeviceResponse>(await DoRPCRequestAsync("DescribePurchasedDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePurchasedDeviceResponse DescribePurchasedDevice(DescribePurchasedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePurchasedDeviceWithOptions(request, runtime);
        }

        public async Task<DescribePurchasedDeviceResponse> DescribePurchasedDeviceAsync(DescribePurchasedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePurchasedDeviceWithOptionsAsync(request, runtime);
        }

        public DescribePurchasedDevicesResponse DescribePurchasedDevicesWithOptions(DescribePurchasedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedDevicesResponse>(DoRPCRequest("DescribePurchasedDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePurchasedDevicesResponse> DescribePurchasedDevicesWithOptionsAsync(DescribePurchasedDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedDevicesResponse>(await DoRPCRequestAsync("DescribePurchasedDevices", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePurchasedDevicesResponse DescribePurchasedDevices(DescribePurchasedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePurchasedDevicesWithOptions(request, runtime);
        }

        public async Task<DescribePurchasedDevicesResponse> DescribePurchasedDevicesAsync(DescribePurchasedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePurchasedDevicesWithOptionsAsync(request, runtime);
        }

        public DescribeRecordsResponse DescribeRecordsWithOptions(DescribeRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordsResponse>(DoRPCRequest("DescribeRecords", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordsResponse> DescribeRecordsWithOptionsAsync(DescribeRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordsResponse>(await DoRPCRequestAsync("DescribeRecords", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordsResponse DescribeRecords(DescribeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeRecordsResponse> DescribeRecordsAsync(DescribeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeStreamResponse DescribeStreamWithOptions(DescribeStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamResponse>(DoRPCRequest("DescribeStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamResponse> DescribeStreamWithOptionsAsync(DescribeStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamResponse>(await DoRPCRequestAsync("DescribeStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamWithOptions(request, runtime);
        }

        public async Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamWithOptionsAsync(request, runtime);
        }

        public DescribeStreamsResponse DescribeStreamsWithOptions(DescribeStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamsResponse>(DoRPCRequest("DescribeStreams", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamsResponse> DescribeStreamsWithOptionsAsync(DescribeStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamsResponse>(await DoRPCRequestAsync("DescribeStreams", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamsResponse DescribeStreams(DescribeStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamsWithOptions(request, runtime);
        }

        public async Task<DescribeStreamsResponse> DescribeStreamsAsync(DescribeStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamsWithOptionsAsync(request, runtime);
        }

        public DescribeStreamURLResponse DescribeStreamURLWithOptions(DescribeStreamURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamURLResponse>(DoRPCRequest("DescribeStreamURL", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamURLResponse> DescribeStreamURLWithOptionsAsync(DescribeStreamURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamURLResponse>(await DoRPCRequestAsync("DescribeStreamURL", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamURLResponse DescribeStreamURL(DescribeStreamURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamURLWithOptions(request, runtime);
        }

        public async Task<DescribeStreamURLResponse> DescribeStreamURLAsync(DescribeStreamURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamURLWithOptionsAsync(request, runtime);
        }

        public DescribeStreamVodListResponse DescribeStreamVodListWithOptions(DescribeStreamVodListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamVodListResponse>(DoRPCRequest("DescribeStreamVodList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamVodListResponse> DescribeStreamVodListWithOptionsAsync(DescribeStreamVodListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamVodListResponse>(await DoRPCRequestAsync("DescribeStreamVodList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamVodListResponse DescribeStreamVodList(DescribeStreamVodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamVodListWithOptions(request, runtime);
        }

        public async Task<DescribeStreamVodListResponse> DescribeStreamVodListAsync(DescribeStreamVodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamVodListWithOptionsAsync(request, runtime);
        }

        public DescribeTemplateResponse DescribeTemplateWithOptions(DescribeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTemplateResponse>(DoRPCRequest("DescribeTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTemplateResponse> DescribeTemplateWithOptionsAsync(DescribeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTemplateResponse>(await DoRPCRequestAsync("DescribeTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTemplateResponse DescribeTemplate(DescribeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplateWithOptions(request, runtime);
        }

        public async Task<DescribeTemplateResponse> DescribeTemplateAsync(DescribeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeTemplatesResponse DescribeTemplatesWithOptions(DescribeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTemplatesResponse>(DoRPCRequest("DescribeTemplates", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesWithOptionsAsync(DescribeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTemplatesResponse>(await DoRPCRequestAsync("DescribeTemplates", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTemplatesResponse DescribeTemplates(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesAsync(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeVodStreamURLResponse DescribeVodStreamURLWithOptions(DescribeVodStreamURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVodStreamURLResponse>(DoRPCRequest("DescribeVodStreamURL", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVodStreamURLResponse> DescribeVodStreamURLWithOptionsAsync(DescribeVodStreamURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVodStreamURLResponse>(await DoRPCRequestAsync("DescribeVodStreamURL", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVodStreamURLResponse DescribeVodStreamURL(DescribeVodStreamURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodStreamURLWithOptions(request, runtime);
        }

        public async Task<DescribeVodStreamURLResponse> DescribeVodStreamURLAsync(DescribeVodStreamURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodStreamURLWithOptionsAsync(request, runtime);
        }

        public DescribeVsCertificateDetailResponse DescribeVsCertificateDetailWithOptions(DescribeVsCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsCertificateDetailResponse>(DoRPCRequest("DescribeVsCertificateDetail", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsCertificateDetailResponse> DescribeVsCertificateDetailWithOptionsAsync(DescribeVsCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsCertificateDetailResponse>(await DoRPCRequestAsync("DescribeVsCertificateDetail", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsCertificateDetailResponse DescribeVsCertificateDetail(DescribeVsCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeVsCertificateDetailResponse> DescribeVsCertificateDetailAsync(DescribeVsCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeVsCertificateListResponse DescribeVsCertificateListWithOptions(DescribeVsCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsCertificateListResponse>(DoRPCRequest("DescribeVsCertificateList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsCertificateListResponse> DescribeVsCertificateListWithOptionsAsync(DescribeVsCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsCertificateListResponse>(await DoRPCRequestAsync("DescribeVsCertificateList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsCertificateListResponse DescribeVsCertificateList(DescribeVsCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeVsCertificateListResponse> DescribeVsCertificateListAsync(DescribeVsCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainBpsDataResponse DescribeVsDomainBpsDataWithOptions(DescribeVsDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainBpsDataResponse>(DoRPCRequest("DescribeVsDomainBpsData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainBpsDataResponse> DescribeVsDomainBpsDataWithOptionsAsync(DescribeVsDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainBpsDataResponse>(await DoRPCRequestAsync("DescribeVsDomainBpsData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainBpsDataResponse DescribeVsDomainBpsData(DescribeVsDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainBpsDataResponse> DescribeVsDomainBpsDataAsync(DescribeVsDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainCertificateInfoResponse DescribeVsDomainCertificateInfoWithOptions(DescribeVsDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainCertificateInfoResponse>(DoRPCRequest("DescribeVsDomainCertificateInfo", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainCertificateInfoResponse> DescribeVsDomainCertificateInfoWithOptionsAsync(DescribeVsDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainCertificateInfoResponse>(await DoRPCRequestAsync("DescribeVsDomainCertificateInfo", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainCertificateInfoResponse DescribeVsDomainCertificateInfo(DescribeVsDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainCertificateInfoResponse> DescribeVsDomainCertificateInfoAsync(DescribeVsDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainConfigsResponse DescribeVsDomainConfigsWithOptions(DescribeVsDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainConfigsResponse>(DoRPCRequest("DescribeVsDomainConfigs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainConfigsResponse> DescribeVsDomainConfigsWithOptionsAsync(DescribeVsDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainConfigsResponse>(await DoRPCRequestAsync("DescribeVsDomainConfigs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainConfigsResponse DescribeVsDomainConfigs(DescribeVsDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainConfigsResponse> DescribeVsDomainConfigsAsync(DescribeVsDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainDetailResponse DescribeVsDomainDetailWithOptions(DescribeVsDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainDetailResponse>(DoRPCRequest("DescribeVsDomainDetail", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainDetailResponse> DescribeVsDomainDetailWithOptionsAsync(DescribeVsDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainDetailResponse>(await DoRPCRequestAsync("DescribeVsDomainDetail", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainDetailResponse DescribeVsDomainDetail(DescribeVsDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainDetailResponse> DescribeVsDomainDetailAsync(DescribeVsDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainPvDataResponse DescribeVsDomainPvDataWithOptions(DescribeVsDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainPvDataResponse>(DoRPCRequest("DescribeVsDomainPvData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainPvDataResponse> DescribeVsDomainPvDataWithOptionsAsync(DescribeVsDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainPvDataResponse>(await DoRPCRequestAsync("DescribeVsDomainPvData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainPvDataResponse DescribeVsDomainPvData(DescribeVsDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainPvDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainPvDataResponse> DescribeVsDomainPvDataAsync(DescribeVsDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainPvDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainPvUvDataResponse DescribeVsDomainPvUvDataWithOptions(DescribeVsDomainPvUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainPvUvDataResponse>(DoRPCRequest("DescribeVsDomainPvUvData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainPvUvDataResponse> DescribeVsDomainPvUvDataWithOptionsAsync(DescribeVsDomainPvUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainPvUvDataResponse>(await DoRPCRequestAsync("DescribeVsDomainPvUvData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainPvUvDataResponse DescribeVsDomainPvUvData(DescribeVsDomainPvUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainPvUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainPvUvDataResponse> DescribeVsDomainPvUvDataAsync(DescribeVsDomainPvUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainPvUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainRecordDataResponse DescribeVsDomainRecordDataWithOptions(DescribeVsDomainRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainRecordDataResponse>(DoRPCRequest("DescribeVsDomainRecordData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainRecordDataResponse> DescribeVsDomainRecordDataWithOptionsAsync(DescribeVsDomainRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainRecordDataResponse>(await DoRPCRequestAsync("DescribeVsDomainRecordData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainRecordDataResponse DescribeVsDomainRecordData(DescribeVsDomainRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainRecordDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainRecordDataResponse> DescribeVsDomainRecordDataAsync(DescribeVsDomainRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainRecordDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainRegionDataResponse DescribeVsDomainRegionDataWithOptions(DescribeVsDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainRegionDataResponse>(DoRPCRequest("DescribeVsDomainRegionData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainRegionDataResponse> DescribeVsDomainRegionDataWithOptionsAsync(DescribeVsDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainRegionDataResponse>(await DoRPCRequestAsync("DescribeVsDomainRegionData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainRegionDataResponse DescribeVsDomainRegionData(DescribeVsDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainRegionDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainRegionDataResponse> DescribeVsDomainRegionDataAsync(DescribeVsDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainRegionDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainReqBpsDataResponse DescribeVsDomainReqBpsDataWithOptions(DescribeVsDomainReqBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainReqBpsDataResponse>(DoRPCRequest("DescribeVsDomainReqBpsData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainReqBpsDataResponse> DescribeVsDomainReqBpsDataWithOptionsAsync(DescribeVsDomainReqBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainReqBpsDataResponse>(await DoRPCRequestAsync("DescribeVsDomainReqBpsData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainReqBpsDataResponse DescribeVsDomainReqBpsData(DescribeVsDomainReqBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainReqBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainReqBpsDataResponse> DescribeVsDomainReqBpsDataAsync(DescribeVsDomainReqBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainReqBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainReqTrafficDataResponse DescribeVsDomainReqTrafficDataWithOptions(DescribeVsDomainReqTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainReqTrafficDataResponse>(DoRPCRequest("DescribeVsDomainReqTrafficData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainReqTrafficDataResponse> DescribeVsDomainReqTrafficDataWithOptionsAsync(DescribeVsDomainReqTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainReqTrafficDataResponse>(await DoRPCRequestAsync("DescribeVsDomainReqTrafficData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainReqTrafficDataResponse DescribeVsDomainReqTrafficData(DescribeVsDomainReqTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainReqTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainReqTrafficDataResponse> DescribeVsDomainReqTrafficDataAsync(DescribeVsDomainReqTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainReqTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainSnapshotDataResponse DescribeVsDomainSnapshotDataWithOptions(DescribeVsDomainSnapshotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainSnapshotDataResponse>(DoRPCRequest("DescribeVsDomainSnapshotData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainSnapshotDataResponse> DescribeVsDomainSnapshotDataWithOptionsAsync(DescribeVsDomainSnapshotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainSnapshotDataResponse>(await DoRPCRequestAsync("DescribeVsDomainSnapshotData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainSnapshotDataResponse DescribeVsDomainSnapshotData(DescribeVsDomainSnapshotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainSnapshotDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainSnapshotDataResponse> DescribeVsDomainSnapshotDataAsync(DescribeVsDomainSnapshotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainSnapshotDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainTrafficDataResponse DescribeVsDomainTrafficDataWithOptions(DescribeVsDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainTrafficDataResponse>(DoRPCRequest("DescribeVsDomainTrafficData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainTrafficDataResponse> DescribeVsDomainTrafficDataWithOptionsAsync(DescribeVsDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainTrafficDataResponse>(await DoRPCRequestAsync("DescribeVsDomainTrafficData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainTrafficDataResponse DescribeVsDomainTrafficData(DescribeVsDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainTrafficDataResponse> DescribeVsDomainTrafficDataAsync(DescribeVsDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsDomainUvDataResponse DescribeVsDomainUvDataWithOptions(DescribeVsDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainUvDataResponse>(DoRPCRequest("DescribeVsDomainUvData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsDomainUvDataResponse> DescribeVsDomainUvDataWithOptionsAsync(DescribeVsDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsDomainUvDataResponse>(await DoRPCRequestAsync("DescribeVsDomainUvData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsDomainUvDataResponse DescribeVsDomainUvData(DescribeVsDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsDomainUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsDomainUvDataResponse> DescribeVsDomainUvDataAsync(DescribeVsDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsDomainUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsPullStreamInfoConfigResponse DescribeVsPullStreamInfoConfigWithOptions(DescribeVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsPullStreamInfoConfigResponse>(DoRPCRequest("DescribeVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsPullStreamInfoConfigResponse> DescribeVsPullStreamInfoConfigWithOptionsAsync(DescribeVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsPullStreamInfoConfigResponse>(await DoRPCRequestAsync("DescribeVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsPullStreamInfoConfigResponse DescribeVsPullStreamInfoConfig(DescribeVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsPullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<DescribeVsPullStreamInfoConfigResponse> DescribeVsPullStreamInfoConfigAsync(DescribeVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsPullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public DescribeVsStorageUsageDataResponse DescribeVsStorageUsageDataWithOptions(DescribeVsStorageUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStorageUsageDataResponse>(DoRPCRequest("DescribeVsStorageUsageData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsStorageUsageDataResponse> DescribeVsStorageUsageDataWithOptionsAsync(DescribeVsStorageUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStorageUsageDataResponse>(await DoRPCRequestAsync("DescribeVsStorageUsageData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsStorageUsageDataResponse DescribeVsStorageUsageData(DescribeVsStorageUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsStorageUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsStorageUsageDataResponse> DescribeVsStorageUsageDataAsync(DescribeVsStorageUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsStorageUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsStreamsNotifyUrlConfigResponse DescribeVsStreamsNotifyUrlConfigWithOptions(DescribeVsStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStreamsNotifyUrlConfigResponse>(DoRPCRequest("DescribeVsStreamsNotifyUrlConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsStreamsNotifyUrlConfigResponse> DescribeVsStreamsNotifyUrlConfigWithOptionsAsync(DescribeVsStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStreamsNotifyUrlConfigResponse>(await DoRPCRequestAsync("DescribeVsStreamsNotifyUrlConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsStreamsNotifyUrlConfigResponse DescribeVsStreamsNotifyUrlConfig(DescribeVsStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsStreamsNotifyUrlConfigWithOptions(request, runtime);
        }

        public async Task<DescribeVsStreamsNotifyUrlConfigResponse> DescribeVsStreamsNotifyUrlConfigAsync(DescribeVsStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsStreamsNotifyUrlConfigWithOptionsAsync(request, runtime);
        }

        public DescribeVsStreamsOnlineListResponse DescribeVsStreamsOnlineListWithOptions(DescribeVsStreamsOnlineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStreamsOnlineListResponse>(DoRPCRequest("DescribeVsStreamsOnlineList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsStreamsOnlineListResponse> DescribeVsStreamsOnlineListWithOptionsAsync(DescribeVsStreamsOnlineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStreamsOnlineListResponse>(await DoRPCRequestAsync("DescribeVsStreamsOnlineList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsStreamsOnlineListResponse DescribeVsStreamsOnlineList(DescribeVsStreamsOnlineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsStreamsOnlineListWithOptions(request, runtime);
        }

        public async Task<DescribeVsStreamsOnlineListResponse> DescribeVsStreamsOnlineListAsync(DescribeVsStreamsOnlineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsStreamsOnlineListWithOptionsAsync(request, runtime);
        }

        public DescribeVsStreamsPublishListResponse DescribeVsStreamsPublishListWithOptions(DescribeVsStreamsPublishListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStreamsPublishListResponse>(DoRPCRequest("DescribeVsStreamsPublishList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsStreamsPublishListResponse> DescribeVsStreamsPublishListWithOptionsAsync(DescribeVsStreamsPublishListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsStreamsPublishListResponse>(await DoRPCRequestAsync("DescribeVsStreamsPublishList", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsStreamsPublishListResponse DescribeVsStreamsPublishList(DescribeVsStreamsPublishListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsStreamsPublishListWithOptions(request, runtime);
        }

        public async Task<DescribeVsStreamsPublishListResponse> DescribeVsStreamsPublishListAsync(DescribeVsStreamsPublishListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsStreamsPublishListWithOptionsAsync(request, runtime);
        }

        public DescribeVsTopDomainsByFlowResponse DescribeVsTopDomainsByFlowWithOptions(DescribeVsTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsTopDomainsByFlowResponse>(DoRPCRequest("DescribeVsTopDomainsByFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsTopDomainsByFlowResponse> DescribeVsTopDomainsByFlowWithOptionsAsync(DescribeVsTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsTopDomainsByFlowResponse>(await DoRPCRequestAsync("DescribeVsTopDomainsByFlow", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsTopDomainsByFlowResponse DescribeVsTopDomainsByFlow(DescribeVsTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsTopDomainsByFlowWithOptions(request, runtime);
        }

        public async Task<DescribeVsTopDomainsByFlowResponse> DescribeVsTopDomainsByFlowAsync(DescribeVsTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        public DescribeVsUpPeakPublishStreamDataResponse DescribeVsUpPeakPublishStreamDataWithOptions(DescribeVsUpPeakPublishStreamDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsUpPeakPublishStreamDataResponse>(DoRPCRequest("DescribeVsUpPeakPublishStreamData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsUpPeakPublishStreamDataResponse> DescribeVsUpPeakPublishStreamDataWithOptionsAsync(DescribeVsUpPeakPublishStreamDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsUpPeakPublishStreamDataResponse>(await DoRPCRequestAsync("DescribeVsUpPeakPublishStreamData", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsUpPeakPublishStreamDataResponse DescribeVsUpPeakPublishStreamData(DescribeVsUpPeakPublishStreamDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsUpPeakPublishStreamDataWithOptions(request, runtime);
        }

        public async Task<DescribeVsUpPeakPublishStreamDataResponse> DescribeVsUpPeakPublishStreamDataAsync(DescribeVsUpPeakPublishStreamDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsUpPeakPublishStreamDataWithOptionsAsync(request, runtime);
        }

        public DescribeVsUserResourcePackageResponse DescribeVsUserResourcePackageWithOptions(DescribeVsUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsUserResourcePackageResponse>(DoRPCRequest("DescribeVsUserResourcePackage", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVsUserResourcePackageResponse> DescribeVsUserResourcePackageWithOptionsAsync(DescribeVsUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVsUserResourcePackageResponse>(await DoRPCRequestAsync("DescribeVsUserResourcePackage", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVsUserResourcePackageResponse DescribeVsUserResourcePackage(DescribeVsUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVsUserResourcePackageWithOptions(request, runtime);
        }

        public async Task<DescribeVsUserResourcePackageResponse> DescribeVsUserResourcePackageAsync(DescribeVsUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVsUserResourcePackageWithOptionsAsync(request, runtime);
        }

        public ForbidVsStreamResponse ForbidVsStreamWithOptions(ForbidVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ForbidVsStreamResponse>(DoRPCRequest("ForbidVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ForbidVsStreamResponse> ForbidVsStreamWithOptionsAsync(ForbidVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ForbidVsStreamResponse>(await DoRPCRequestAsync("ForbidVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ForbidVsStreamResponse ForbidVsStream(ForbidVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForbidVsStreamWithOptions(request, runtime);
        }

        public async Task<ForbidVsStreamResponse> ForbidVsStreamAsync(ForbidVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForbidVsStreamWithOptionsAsync(request, runtime);
        }

        public GetBucketInfoResponse GetBucketInfoWithOptions(GetBucketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBucketInfoResponse>(DoRPCRequest("GetBucketInfo", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBucketInfoResponse> GetBucketInfoWithOptionsAsync(GetBucketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBucketInfoResponse>(await DoRPCRequestAsync("GetBucketInfo", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBucketInfoResponse GetBucketInfo(GetBucketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBucketInfoWithOptions(request, runtime);
        }

        public async Task<GetBucketInfoResponse> GetBucketInfoAsync(GetBucketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBucketInfoWithOptionsAsync(request, runtime);
        }

        public GotoPresetResponse GotoPresetWithOptions(GotoPresetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GotoPresetResponse>(DoRPCRequest("GotoPreset", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GotoPresetResponse> GotoPresetWithOptionsAsync(GotoPresetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GotoPresetResponse>(await DoRPCRequestAsync("GotoPreset", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GotoPresetResponse GotoPreset(GotoPresetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GotoPresetWithOptions(request, runtime);
        }

        public async Task<GotoPresetResponse> GotoPresetAsync(GotoPresetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GotoPresetWithOptionsAsync(request, runtime);
        }

        public ListBucketsResponse ListBucketsWithOptions(ListBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBucketsResponse>(DoRPCRequest("ListBuckets", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBucketsResponse> ListBucketsWithOptionsAsync(ListBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBucketsResponse>(await DoRPCRequestAsync("ListBuckets", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBucketsWithOptions(request, runtime);
        }

        public async Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBucketsWithOptionsAsync(request, runtime);
        }

        public ListDeviceChannelsResponse ListDeviceChannelsWithOptions(ListDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceChannelsResponse>(DoRPCRequest("ListDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceChannelsResponse> ListDeviceChannelsWithOptionsAsync(ListDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceChannelsResponse>(await DoRPCRequestAsync("ListDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeviceChannelsResponse ListDeviceChannels(ListDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceChannelsWithOptions(request, runtime);
        }

        public async Task<ListDeviceChannelsResponse> ListDeviceChannelsAsync(ListDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceChannelsWithOptionsAsync(request, runtime);
        }

        public ListDeviceRecordsResponse ListDeviceRecordsWithOptions(ListDeviceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceRecordsResponse>(DoRPCRequest("ListDeviceRecords", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceRecordsResponse> ListDeviceRecordsWithOptionsAsync(ListDeviceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceRecordsResponse>(await DoRPCRequestAsync("ListDeviceRecords", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeviceRecordsResponse ListDeviceRecords(ListDeviceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceRecordsWithOptions(request, runtime);
        }

        public async Task<ListDeviceRecordsResponse> ListDeviceRecordsAsync(ListDeviceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceRecordsWithOptionsAsync(request, runtime);
        }

        public ListObjectsResponse ListObjectsWithOptions(ListObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListObjectsResponse>(DoRPCRequest("ListObjects", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListObjectsResponse> ListObjectsWithOptionsAsync(ListObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListObjectsResponse>(await DoRPCRequestAsync("ListObjects", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListObjectsWithOptions(request, runtime);
        }

        public async Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListObjectsWithOptionsAsync(request, runtime);
        }

        public ModifyDeviceResponse ModifyDeviceWithOptions(ModifyDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceResponse>(DoRPCRequest("ModifyDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeviceResponse> ModifyDeviceWithOptionsAsync(ModifyDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceResponse>(await DoRPCRequestAsync("ModifyDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeviceResponse ModifyDevice(ModifyDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceWithOptions(request, runtime);
        }

        public async Task<ModifyDeviceResponse> ModifyDeviceAsync(ModifyDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceWithOptionsAsync(request, runtime);
        }

        public ModifyDeviceAlarmResponse ModifyDeviceAlarmWithOptions(ModifyDeviceAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceAlarmResponse>(DoRPCRequest("ModifyDeviceAlarm", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeviceAlarmResponse> ModifyDeviceAlarmWithOptionsAsync(ModifyDeviceAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceAlarmResponse>(await DoRPCRequestAsync("ModifyDeviceAlarm", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeviceAlarmResponse ModifyDeviceAlarm(ModifyDeviceAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceAlarmWithOptions(request, runtime);
        }

        public async Task<ModifyDeviceAlarmResponse> ModifyDeviceAlarmAsync(ModifyDeviceAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceAlarmWithOptionsAsync(request, runtime);
        }

        public ModifyDeviceCaptureResponse ModifyDeviceCaptureWithOptions(ModifyDeviceCaptureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceCaptureResponse>(DoRPCRequest("ModifyDeviceCapture", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeviceCaptureResponse> ModifyDeviceCaptureWithOptionsAsync(ModifyDeviceCaptureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceCaptureResponse>(await DoRPCRequestAsync("ModifyDeviceCapture", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeviceCaptureResponse ModifyDeviceCapture(ModifyDeviceCaptureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceCaptureWithOptions(request, runtime);
        }

        public async Task<ModifyDeviceCaptureResponse> ModifyDeviceCaptureAsync(ModifyDeviceCaptureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceCaptureWithOptionsAsync(request, runtime);
        }

        public ModifyDeviceChannelsResponse ModifyDeviceChannelsWithOptions(ModifyDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceChannelsResponse>(DoRPCRequest("ModifyDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeviceChannelsResponse> ModifyDeviceChannelsWithOptionsAsync(ModifyDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceChannelsResponse>(await DoRPCRequestAsync("ModifyDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeviceChannelsResponse ModifyDeviceChannels(ModifyDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceChannelsWithOptions(request, runtime);
        }

        public async Task<ModifyDeviceChannelsResponse> ModifyDeviceChannelsAsync(ModifyDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceChannelsWithOptionsAsync(request, runtime);
        }

        public ModifyDirectoryResponse ModifyDirectoryWithOptions(ModifyDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDirectoryResponse>(DoRPCRequest("ModifyDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDirectoryResponse> ModifyDirectoryWithOptionsAsync(ModifyDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDirectoryResponse>(await DoRPCRequestAsync("ModifyDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDirectoryResponse ModifyDirectory(ModifyDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDirectoryWithOptions(request, runtime);
        }

        public async Task<ModifyDirectoryResponse> ModifyDirectoryAsync(ModifyDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDirectoryWithOptionsAsync(request, runtime);
        }

        public ModifyGroupResponse ModifyGroupWithOptions(ModifyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGroupResponse>(DoRPCRequest("ModifyGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGroupResponse> ModifyGroupWithOptionsAsync(ModifyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGroupResponse>(await DoRPCRequestAsync("ModifyGroup", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGroupResponse ModifyGroup(ModifyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGroupWithOptions(request, runtime);
        }

        public async Task<ModifyGroupResponse> ModifyGroupAsync(ModifyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGroupWithOptionsAsync(request, runtime);
        }

        public ModifyParentPlatformResponse ModifyParentPlatformWithOptions(ModifyParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParentPlatformResponse>(DoRPCRequest("ModifyParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyParentPlatformResponse> ModifyParentPlatformWithOptionsAsync(ModifyParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyParentPlatformResponse>(await DoRPCRequestAsync("ModifyParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyParentPlatformResponse ModifyParentPlatform(ModifyParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyParentPlatformWithOptions(request, runtime);
        }

        public async Task<ModifyParentPlatformResponse> ModifyParentPlatformAsync(ModifyParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyParentPlatformWithOptionsAsync(request, runtime);
        }

        public ModifyTemplateResponse ModifyTemplateWithOptions(ModifyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTemplateResponse>(DoRPCRequest("ModifyTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTemplateResponse> ModifyTemplateWithOptionsAsync(ModifyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTemplateResponse>(await DoRPCRequestAsync("ModifyTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public OpenVsServiceResponse OpenVsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenVsServiceResponse>(DoRPCRequest("OpenVsService", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenVsServiceResponse> OpenVsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenVsServiceResponse>(await DoRPCRequestAsync("OpenVsService", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenVsServiceResponse OpenVsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenVsServiceWithOptions(runtime);
        }

        public async Task<OpenVsServiceResponse> OpenVsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenVsServiceWithOptionsAsync(runtime);
        }

        public PrepareUploadResponse PrepareUploadWithOptions(PrepareUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PrepareUploadResponse>(DoRPCRequest("PrepareUpload", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PrepareUploadResponse> PrepareUploadWithOptionsAsync(PrepareUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PrepareUploadResponse>(await DoRPCRequestAsync("PrepareUpload", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PrepareUploadResponse PrepareUpload(PrepareUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrepareUploadWithOptions(request, runtime);
        }

        public async Task<PrepareUploadResponse> PrepareUploadAsync(PrepareUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrepareUploadWithOptionsAsync(request, runtime);
        }

        public PutBucketResponse PutBucketWithOptions(PutBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutBucketResponse>(DoRPCRequest("PutBucket", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutBucketResponse> PutBucketWithOptionsAsync(PutBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutBucketResponse>(await DoRPCRequestAsync("PutBucket", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutBucketResponse PutBucket(PutBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutBucketWithOptions(request, runtime);
        }

        public async Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutBucketWithOptionsAsync(request, runtime);
        }

        public ResumeVsStreamResponse ResumeVsStreamWithOptions(ResumeVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeVsStreamResponse>(DoRPCRequest("ResumeVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeVsStreamResponse> ResumeVsStreamWithOptionsAsync(ResumeVsStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeVsStreamResponse>(await DoRPCRequestAsync("ResumeVsStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeVsStreamResponse ResumeVsStream(ResumeVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeVsStreamWithOptions(request, runtime);
        }

        public async Task<ResumeVsStreamResponse> ResumeVsStreamAsync(ResumeVsStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeVsStreamWithOptionsAsync(request, runtime);
        }

        public SetPresetResponse SetPresetWithOptions(SetPresetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetPresetResponse>(DoRPCRequest("SetPreset", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetPresetResponse> SetPresetWithOptionsAsync(SetPresetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetPresetResponse>(await DoRPCRequestAsync("SetPreset", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetPresetResponse SetPreset(SetPresetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPresetWithOptions(request, runtime);
        }

        public async Task<SetPresetResponse> SetPresetAsync(SetPresetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPresetWithOptionsAsync(request, runtime);
        }

        public SetVsDomainCertificateResponse SetVsDomainCertificateWithOptions(SetVsDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVsDomainCertificateResponse>(DoRPCRequest("SetVsDomainCertificate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetVsDomainCertificateResponse> SetVsDomainCertificateWithOptionsAsync(SetVsDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVsDomainCertificateResponse>(await DoRPCRequestAsync("SetVsDomainCertificate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetVsDomainCertificateResponse SetVsDomainCertificate(SetVsDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVsDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetVsDomainCertificateResponse> SetVsDomainCertificateAsync(SetVsDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVsDomainCertificateWithOptionsAsync(request, runtime);
        }

        public SetVsStreamsNotifyUrlConfigResponse SetVsStreamsNotifyUrlConfigWithOptions(SetVsStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVsStreamsNotifyUrlConfigResponse>(DoRPCRequest("SetVsStreamsNotifyUrlConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetVsStreamsNotifyUrlConfigResponse> SetVsStreamsNotifyUrlConfigWithOptionsAsync(SetVsStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVsStreamsNotifyUrlConfigResponse>(await DoRPCRequestAsync("SetVsStreamsNotifyUrlConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetVsStreamsNotifyUrlConfigResponse SetVsStreamsNotifyUrlConfig(SetVsStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVsStreamsNotifyUrlConfigWithOptions(request, runtime);
        }

        public async Task<SetVsStreamsNotifyUrlConfigResponse> SetVsStreamsNotifyUrlConfigAsync(SetVsStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVsStreamsNotifyUrlConfigWithOptionsAsync(request, runtime);
        }

        public StartDeviceResponse StartDeviceWithOptions(StartDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDeviceResponse>(DoRPCRequest("StartDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDeviceResponse> StartDeviceWithOptionsAsync(StartDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDeviceResponse>(await DoRPCRequestAsync("StartDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDeviceResponse StartDevice(StartDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDeviceWithOptions(request, runtime);
        }

        public async Task<StartDeviceResponse> StartDeviceAsync(StartDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDeviceWithOptionsAsync(request, runtime);
        }

        public StartParentPlatformResponse StartParentPlatformWithOptions(StartParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartParentPlatformResponse>(DoRPCRequest("StartParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartParentPlatformResponse> StartParentPlatformWithOptionsAsync(StartParentPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartParentPlatformResponse>(await DoRPCRequestAsync("StartParentPlatform", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartParentPlatformResponse StartParentPlatform(StartParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartParentPlatformWithOptions(request, runtime);
        }

        public async Task<StartParentPlatformResponse> StartParentPlatformAsync(StartParentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartParentPlatformWithOptionsAsync(request, runtime);
        }

        public StartRecordStreamResponse StartRecordStreamWithOptions(StartRecordStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRecordStreamResponse>(DoRPCRequest("StartRecordStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRecordStreamResponse> StartRecordStreamWithOptionsAsync(StartRecordStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRecordStreamResponse>(await DoRPCRequestAsync("StartRecordStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRecordStreamResponse StartRecordStream(StartRecordStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordStreamWithOptions(request, runtime);
        }

        public async Task<StartRecordStreamResponse> StartRecordStreamAsync(StartRecordStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordStreamWithOptionsAsync(request, runtime);
        }

        public StartStreamResponse StartStreamWithOptions(StartStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartStreamResponse>(DoRPCRequest("StartStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartStreamResponse> StartStreamWithOptionsAsync(StartStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartStreamResponse>(await DoRPCRequestAsync("StartStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartStreamResponse StartStream(StartStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartStreamWithOptions(request, runtime);
        }

        public async Task<StartStreamResponse> StartStreamAsync(StartStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartStreamWithOptionsAsync(request, runtime);
        }

        public StartTransferStreamResponse StartTransferStreamWithOptions(StartTransferStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTransferStreamResponse>(DoRPCRequest("StartTransferStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartTransferStreamResponse> StartTransferStreamWithOptionsAsync(StartTransferStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartTransferStreamResponse>(await DoRPCRequestAsync("StartTransferStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartTransferStreamResponse StartTransferStream(StartTransferStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTransferStreamWithOptions(request, runtime);
        }

        public async Task<StartTransferStreamResponse> StartTransferStreamAsync(StartTransferStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTransferStreamWithOptionsAsync(request, runtime);
        }

        public StopAdjustResponse StopAdjustWithOptions(StopAdjustRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopAdjustResponse>(DoRPCRequest("StopAdjust", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopAdjustResponse> StopAdjustWithOptionsAsync(StopAdjustRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopAdjustResponse>(await DoRPCRequestAsync("StopAdjust", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopAdjustResponse StopAdjust(StopAdjustRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAdjustWithOptions(request, runtime);
        }

        public async Task<StopAdjustResponse> StopAdjustAsync(StopAdjustRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAdjustWithOptionsAsync(request, runtime);
        }

        public StopDeviceResponse StopDeviceWithOptions(StopDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDeviceResponse>(DoRPCRequest("StopDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDeviceResponse> StopDeviceWithOptionsAsync(StopDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDeviceResponse>(await DoRPCRequestAsync("StopDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDeviceResponse StopDevice(StopDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDeviceWithOptions(request, runtime);
        }

        public async Task<StopDeviceResponse> StopDeviceAsync(StopDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDeviceWithOptionsAsync(request, runtime);
        }

        public StopMoveResponse StopMoveWithOptions(StopMoveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMoveResponse>(DoRPCRequest("StopMove", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMoveResponse> StopMoveWithOptionsAsync(StopMoveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMoveResponse>(await DoRPCRequestAsync("StopMove", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopMoveResponse StopMove(StopMoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMoveWithOptions(request, runtime);
        }

        public async Task<StopMoveResponse> StopMoveAsync(StopMoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMoveWithOptionsAsync(request, runtime);
        }

        public StopRecordStreamResponse StopRecordStreamWithOptions(StopRecordStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRecordStreamResponse>(DoRPCRequest("StopRecordStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopRecordStreamResponse> StopRecordStreamWithOptionsAsync(StopRecordStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRecordStreamResponse>(await DoRPCRequestAsync("StopRecordStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopRecordStreamResponse StopRecordStream(StopRecordStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordStreamWithOptions(request, runtime);
        }

        public async Task<StopRecordStreamResponse> StopRecordStreamAsync(StopRecordStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordStreamWithOptionsAsync(request, runtime);
        }

        public StopStreamResponse StopStreamWithOptions(StopStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopStreamResponse>(DoRPCRequest("StopStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopStreamResponse> StopStreamWithOptionsAsync(StopStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopStreamResponse>(await DoRPCRequestAsync("StopStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopStreamResponse StopStream(StopStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStreamWithOptions(request, runtime);
        }

        public async Task<StopStreamResponse> StopStreamAsync(StopStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStreamWithOptionsAsync(request, runtime);
        }

        public StopTransferStreamResponse StopTransferStreamWithOptions(StopTransferStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTransferStreamResponse>(DoRPCRequest("StopTransferStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopTransferStreamResponse> StopTransferStreamWithOptionsAsync(StopTransferStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTransferStreamResponse>(await DoRPCRequestAsync("StopTransferStream", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopTransferStreamResponse StopTransferStream(StopTransferStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopTransferStreamWithOptions(request, runtime);
        }

        public async Task<StopTransferStreamResponse> StopTransferStreamAsync(StopTransferStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopTransferStreamWithOptionsAsync(request, runtime);
        }

        public SyncCatalogsResponse SyncCatalogsWithOptions(SyncCatalogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncCatalogsResponse>(DoRPCRequest("SyncCatalogs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncCatalogsResponse> SyncCatalogsWithOptionsAsync(SyncCatalogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncCatalogsResponse>(await DoRPCRequestAsync("SyncCatalogs", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncCatalogsResponse SyncCatalogs(SyncCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncCatalogsWithOptions(request, runtime);
        }

        public async Task<SyncCatalogsResponse> SyncCatalogsAsync(SyncCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncCatalogsWithOptionsAsync(request, runtime);
        }

        public SyncDeviceChannelsResponse SyncDeviceChannelsWithOptions(SyncDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDeviceChannelsResponse>(DoRPCRequest("SyncDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SyncDeviceChannelsResponse> SyncDeviceChannelsWithOptionsAsync(SyncDeviceChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SyncDeviceChannelsResponse>(await DoRPCRequestAsync("SyncDeviceChannels", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SyncDeviceChannelsResponse SyncDeviceChannels(SyncDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncDeviceChannelsWithOptions(request, runtime);
        }

        public async Task<SyncDeviceChannelsResponse> SyncDeviceChannelsAsync(SyncDeviceChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncDeviceChannelsWithOptionsAsync(request, runtime);
        }

        public UnbindDirectoryResponse UnbindDirectoryWithOptions(UnbindDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindDirectoryResponse>(DoRPCRequest("UnbindDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindDirectoryResponse> UnbindDirectoryWithOptionsAsync(UnbindDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindDirectoryResponse>(await DoRPCRequestAsync("UnbindDirectory", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindDirectoryResponse UnbindDirectory(UnbindDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDirectoryWithOptions(request, runtime);
        }

        public async Task<UnbindDirectoryResponse> UnbindDirectoryAsync(UnbindDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDirectoryWithOptionsAsync(request, runtime);
        }

        public UnbindParentPlatformDeviceResponse UnbindParentPlatformDeviceWithOptions(UnbindParentPlatformDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindParentPlatformDeviceResponse>(DoRPCRequest("UnbindParentPlatformDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindParentPlatformDeviceResponse> UnbindParentPlatformDeviceWithOptionsAsync(UnbindParentPlatformDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindParentPlatformDeviceResponse>(await DoRPCRequestAsync("UnbindParentPlatformDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindParentPlatformDeviceResponse UnbindParentPlatformDevice(UnbindParentPlatformDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindParentPlatformDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindParentPlatformDeviceResponse> UnbindParentPlatformDeviceAsync(UnbindParentPlatformDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindParentPlatformDeviceWithOptionsAsync(request, runtime);
        }

        public UnbindPurchasedDeviceResponse UnbindPurchasedDeviceWithOptions(UnbindPurchasedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPurchasedDeviceResponse>(DoRPCRequest("UnbindPurchasedDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindPurchasedDeviceResponse> UnbindPurchasedDeviceWithOptionsAsync(UnbindPurchasedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPurchasedDeviceResponse>(await DoRPCRequestAsync("UnbindPurchasedDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindPurchasedDeviceResponse UnbindPurchasedDevice(UnbindPurchasedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPurchasedDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindPurchasedDeviceResponse> UnbindPurchasedDeviceAsync(UnbindPurchasedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPurchasedDeviceWithOptionsAsync(request, runtime);
        }

        public UnbindTemplateResponse UnbindTemplateWithOptions(UnbindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindTemplateResponse>(DoRPCRequest("UnbindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindTemplateResponse> UnbindTemplateWithOptionsAsync(UnbindTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindTemplateResponse>(await DoRPCRequestAsync("UnbindTemplate", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindTemplateResponse UnbindTemplate(UnbindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindTemplateWithOptions(request, runtime);
        }

        public async Task<UnbindTemplateResponse> UnbindTemplateAsync(UnbindTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindTemplateWithOptionsAsync(request, runtime);
        }

        public UnlockDeviceResponse UnlockDeviceWithOptions(UnlockDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockDeviceResponse>(DoRPCRequest("UnlockDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnlockDeviceResponse> UnlockDeviceWithOptionsAsync(UnlockDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockDeviceResponse>(await DoRPCRequestAsync("UnlockDevice", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnlockDeviceResponse UnlockDevice(UnlockDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockDeviceWithOptions(request, runtime);
        }

        public async Task<UnlockDeviceResponse> UnlockDeviceAsync(UnlockDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockDeviceWithOptionsAsync(request, runtime);
        }

        public UpdateBucketInfoResponse UpdateBucketInfoWithOptions(UpdateBucketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBucketInfoResponse>(DoRPCRequest("UpdateBucketInfo", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateBucketInfoResponse> UpdateBucketInfoWithOptionsAsync(UpdateBucketInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBucketInfoResponse>(await DoRPCRequestAsync("UpdateBucketInfo", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateBucketInfoResponse UpdateBucketInfo(UpdateBucketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBucketInfoWithOptions(request, runtime);
        }

        public async Task<UpdateBucketInfoResponse> UpdateBucketInfoAsync(UpdateBucketInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBucketInfoWithOptionsAsync(request, runtime);
        }

        public UpdateVsPullStreamInfoConfigResponse UpdateVsPullStreamInfoConfigWithOptions(UpdateVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVsPullStreamInfoConfigResponse>(DoRPCRequest("UpdateVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateVsPullStreamInfoConfigResponse> UpdateVsPullStreamInfoConfigWithOptionsAsync(UpdateVsPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVsPullStreamInfoConfigResponse>(await DoRPCRequestAsync("UpdateVsPullStreamInfoConfig", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateVsPullStreamInfoConfigResponse UpdateVsPullStreamInfoConfig(UpdateVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVsPullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<UpdateVsPullStreamInfoConfigResponse> UpdateVsPullStreamInfoConfigAsync(UpdateVsPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVsPullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public UploadDeviceRecordResponse UploadDeviceRecordWithOptions(UploadDeviceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadDeviceRecordResponse>(DoRPCRequest("UploadDeviceRecord", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadDeviceRecordResponse> UploadDeviceRecordWithOptionsAsync(UploadDeviceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadDeviceRecordResponse>(await DoRPCRequestAsync("UploadDeviceRecord", "2018-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadDeviceRecordResponse UploadDeviceRecord(UploadDeviceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDeviceRecordWithOptions(request, runtime);
        }

        public async Task<UploadDeviceRecordResponse> UploadDeviceRecordAsync(UploadDeviceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDeviceRecordWithOptionsAsync(request, runtime);
        }

    }
}
