// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecs_workbench20220220.Models;

namespace AlibabaCloud.SDK.Ecs_workbench20220220
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecs-workbench", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public LoginInstanceResponse LoginInstanceWithOptions(LoginInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLoginInfo))
            {
                query["InstanceLoginInfo"] = request.InstanceLoginInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerInfo))
            {
                query["PartnerInfo"] = request.PartnerInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccount))
            {
                query["UserAccount"] = request.UserAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginInstance",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LoginInstanceResponse> LoginInstanceWithOptionsAsync(LoginInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLoginInfo))
            {
                query["InstanceLoginInfo"] = request.InstanceLoginInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerInfo))
            {
                query["PartnerInfo"] = request.PartnerInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccount))
            {
                query["UserAccount"] = request.UserAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginInstance",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LoginInstanceResponse LoginInstance(LoginInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoginInstanceWithOptions(request, runtime);
        }

        public async Task<LoginInstanceResponse> LoginInstanceAsync(LoginInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoginInstanceWithOptionsAsync(request, runtime);
        }

    }
}
