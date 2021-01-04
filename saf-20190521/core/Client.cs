// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Saf20190521.Models;

namespace AlibabaCloud.SDK.Saf20190521
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "saf.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("saf", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ExecuteExtendServiceResponse ExecuteExtendServiceWithOptions(ExecuteExtendServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteExtendServiceResponse>(DoRPCRequest("ExecuteExtendService", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteExtendServiceResponse> ExecuteExtendServiceWithOptionsAsync(ExecuteExtendServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteExtendServiceResponse>(await DoRPCRequestAsync("ExecuteExtendService", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteExtendServiceResponse ExecuteExtendService(ExecuteExtendServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteExtendServiceWithOptions(request, runtime);
        }

        public async Task<ExecuteExtendServiceResponse> ExecuteExtendServiceAsync(ExecuteExtendServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteExtendServiceWithOptionsAsync(request, runtime);
        }

        public ExecuteRequestResponse ExecuteRequestWithOptions(ExecuteRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteRequestResponse>(DoRPCRequest("ExecuteRequest", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteRequestResponse> ExecuteRequestWithOptionsAsync(ExecuteRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteRequestResponse>(await DoRPCRequestAsync("ExecuteRequest", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteRequestResponse ExecuteRequest(ExecuteRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteRequestWithOptions(request, runtime);
        }

        public async Task<ExecuteRequestResponse> ExecuteRequestAsync(ExecuteRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteRequestWithOptionsAsync(request, runtime);
        }

        public ExecuteRequestMLResponse ExecuteRequestMLWithOptions(ExecuteRequestMLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteRequestMLResponse>(DoRPCRequest("ExecuteRequestML", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteRequestMLResponse> ExecuteRequestMLWithOptionsAsync(ExecuteRequestMLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteRequestMLResponse>(await DoRPCRequestAsync("ExecuteRequestML", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteRequestMLResponse ExecuteRequestML(ExecuteRequestMLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteRequestMLWithOptions(request, runtime);
        }

        public async Task<ExecuteRequestMLResponse> ExecuteRequestMLAsync(ExecuteRequestMLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteRequestMLWithOptionsAsync(request, runtime);
        }

        public ExecuteRequestSGResponse ExecuteRequestSGWithOptions(ExecuteRequestSGRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteRequestSGResponse>(DoRPCRequest("ExecuteRequestSG", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteRequestSGResponse> ExecuteRequestSGWithOptionsAsync(ExecuteRequestSGRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteRequestSGResponse>(await DoRPCRequestAsync("ExecuteRequestSG", "2019-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteRequestSGResponse ExecuteRequestSG(ExecuteRequestSGRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteRequestSGWithOptions(request, runtime);
        }

        public async Task<ExecuteRequestSGResponse> ExecuteRequestSGAsync(ExecuteRequestSGRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteRequestSGWithOptionsAsync(request, runtime);
        }

    }
}
