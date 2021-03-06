// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OpenPlatform20191219.Models;

namespace AlibabaCloud.SDK.OpenPlatform20191219
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("openplatform", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public AuthorizeFileUploadResponse AuthorizeFileUploadWithOptions(AuthorizeFileUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AuthorizeFileUploadResponse>(DoRequest("AuthorizeFileUpload", "HTTPS", "GET", "2019-12-19", "AK", request.ToMap(), null, runtime));
        }

        public async Task<AuthorizeFileUploadResponse> AuthorizeFileUploadWithOptionsAsync(AuthorizeFileUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AuthorizeFileUploadResponse>(await DoRequestAsync("AuthorizeFileUpload", "HTTPS", "GET", "2019-12-19", "AK", request.ToMap(), null, runtime));
        }

        public AuthorizeFileUploadResponse AuthorizeFileUpload(AuthorizeFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeFileUploadWithOptions(request, runtime);
        }

        public async Task<AuthorizeFileUploadResponse> AuthorizeFileUploadAsync(AuthorizeFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeFileUploadWithOptionsAsync(request, runtime);
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

    }
}
