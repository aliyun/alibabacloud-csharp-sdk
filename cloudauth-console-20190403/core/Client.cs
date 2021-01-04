// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth_console20190403.Models;

namespace AlibabaCloud.SDK.Cloudauth_console20190403
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth-console", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public RetrieveFaceResponse RetrieveFaceWithOptions(RetrieveFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetrieveFaceResponse>(DoRPCRequest("RetrieveFace", "2019-04-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RetrieveFaceResponse> RetrieveFaceWithOptionsAsync(RetrieveFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetrieveFaceResponse>(await DoRPCRequestAsync("RetrieveFace", "2019-04-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RetrieveFaceResponse RetrieveFace(RetrieveFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrieveFaceWithOptions(request, runtime);
        }

        public async Task<RetrieveFaceResponse> RetrieveFaceAsync(RetrieveFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrieveFaceWithOptionsAsync(request, runtime);
        }

        public UploadIdentifyRecordResponse UploadIdentifyRecordWithOptions(UploadIdentifyRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadIdentifyRecordResponse>(DoRPCRequest("UploadIdentifyRecord", "2019-04-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadIdentifyRecordResponse> UploadIdentifyRecordWithOptionsAsync(UploadIdentifyRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadIdentifyRecordResponse>(await DoRPCRequestAsync("UploadIdentifyRecord", "2019-04-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadIdentifyRecordResponse UploadIdentifyRecord(UploadIdentifyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadIdentifyRecordWithOptions(request, runtime);
        }

        public async Task<UploadIdentifyRecordResponse> UploadIdentifyRecordAsync(UploadIdentifyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadIdentifyRecordWithOptionsAsync(request, runtime);
        }

    }
}
