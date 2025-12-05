// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CCC20200527.Models;

namespace AlibabaCloud.SDK.CCC20200527
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ccc.aliyuncs.com"},
                {"ap-south-1", "ccc.aliyuncs.com"},
                {"ap-southeast-1", "ccc.aliyuncs.com"},
                {"ap-southeast-2", "ccc.aliyuncs.com"},
                {"ap-southeast-3", "ccc.aliyuncs.com"},
                {"ap-southeast-5", "ccc.aliyuncs.com"},
                {"cn-beijing", "ccc.aliyuncs.com"},
                {"cn-chengdu", "ccc.aliyuncs.com"},
                {"cn-hongkong", "ccc.aliyuncs.com"},
                {"cn-huhehaote", "ccc.aliyuncs.com"},
                {"cn-qingdao", "ccc.aliyuncs.com"},
                {"cn-shenzhen", "ccc.aliyuncs.com"},
                {"cn-zhangjiakou", "ccc.aliyuncs.com"},
                {"eu-central-1", "ccc.aliyuncs.com"},
                {"eu-west-1", "ccc.aliyuncs.com"},
                {"me-east-1", "ccc.aliyuncs.com"},
                {"us-east-1", "ccc.aliyuncs.com"},
                {"us-west-1", "ccc.aliyuncs.com"},
                {"cn-hangzhou-finance", "ccc.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ccc.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ccc.aliyuncs.com"},
                {"cn-north-2-gov-1", "ccc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ccc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// CheckServiceLinkedRoleForDeletingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForDeletingResponse
        /// </returns>
        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeletingWithOptions(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionTaskId))
            {
                query["DeletionTaskId"] = request.DeletionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SPIRegionId))
            {
                query["SPIRegionId"] = request.SPIRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckServiceLinkedRoleForDeleting",
                Version = "2020-05-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CheckServiceLinkedRoleForDeletingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForDeletingResponse
        /// </returns>
        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingWithOptionsAsync(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionTaskId))
            {
                query["DeletionTaskId"] = request.DeletionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SPIRegionId))
            {
                query["SPIRegionId"] = request.SPIRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckServiceLinkedRoleForDeleting",
                Version = "2020-05-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CheckServiceLinkedRoleForDeletingRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForDeletingResponse
        /// </returns>
        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeleting(CheckServiceLinkedRoleForDeletingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceLinkedRoleForDeletingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckServiceLinkedRoleForDeletingRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForDeletingResponse
        /// </returns>
        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingAsync(CheckServiceLinkedRoleForDeletingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceLinkedRoleForDeletingWithOptionsAsync(request, runtime);
        }

    }
}
