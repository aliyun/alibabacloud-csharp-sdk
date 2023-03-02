// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ltl20190510.Models;

namespace AlibabaCloud.SDK.Ltl20190510
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ltl.aliyuncs.com"},
                {"ap-northeast-2-pop", "ltl.aliyuncs.com"},
                {"ap-south-1", "ltl.aliyuncs.com"},
                {"ap-southeast-1", "ltl.aliyuncs.com"},
                {"ap-southeast-2", "ltl.aliyuncs.com"},
                {"ap-southeast-3", "ltl.aliyuncs.com"},
                {"ap-southeast-5", "ltl.aliyuncs.com"},
                {"cn-beijing", "ltl.aliyuncs.com"},
                {"cn-beijing-finance-1", "ltl.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ltl.aliyuncs.com"},
                {"cn-beijing-gov-1", "ltl.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ltl.aliyuncs.com"},
                {"cn-chengdu", "ltl.aliyuncs.com"},
                {"cn-edge-1", "ltl.aliyuncs.com"},
                {"cn-fujian", "ltl.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ltl.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ltl.aliyuncs.com"},
                {"cn-hangzhou-finance", "ltl.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ltl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ltl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ltl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ltl.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ltl.aliyuncs.com"},
                {"cn-hongkong", "ltl.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ltl.aliyuncs.com"},
                {"cn-huhehaote", "ltl.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "ltl.aliyuncs.com"},
                {"cn-north-2-gov-1", "ltl.aliyuncs.com"},
                {"cn-qingdao", "ltl.aliyuncs.com"},
                {"cn-qingdao-nebula", "ltl.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ltl.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ltl.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ltl.aliyuncs.com"},
                {"cn-shanghai-inner", "ltl.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ltl.aliyuncs.com"},
                {"cn-shenzhen", "ltl.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ltl.aliyuncs.com"},
                {"cn-shenzhen-inner", "ltl.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ltl.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ltl.aliyuncs.com"},
                {"cn-wuhan", "ltl.aliyuncs.com"},
                {"cn-wulanchabu", "ltl.aliyuncs.com"},
                {"cn-yushanfang", "ltl.aliyuncs.com"},
                {"cn-zhangbei", "ltl.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ltl.aliyuncs.com"},
                {"cn-zhangjiakou", "ltl.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ltl.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ltl.aliyuncs.com"},
                {"eu-central-1", "ltl.aliyuncs.com"},
                {"eu-west-1", "ltl.aliyuncs.com"},
                {"eu-west-1-oxs", "ltl.aliyuncs.com"},
                {"me-east-1", "ltl.aliyuncs.com"},
                {"rus-west-1-pop", "ltl.aliyuncs.com"},
                {"us-east-1", "ltl.aliyuncs.com"},
                {"us-west-1", "ltl.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ltl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ApplyDataModelConfigInfoResponse ApplyDataModelConfigInfoWithOptions(ApplyDataModelConfigInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                query["Configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataModelCode))
            {
                query["DataModelCode"] = request.DataModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyDataModelConfigInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyDataModelConfigInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyDataModelConfigInfoResponse> ApplyDataModelConfigInfoWithOptionsAsync(ApplyDataModelConfigInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                query["Configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataModelCode))
            {
                query["DataModelCode"] = request.DataModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyDataModelConfigInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyDataModelConfigInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyDataModelConfigInfoResponse ApplyDataModelConfigInfo(ApplyDataModelConfigInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyDataModelConfigInfoWithOptions(request, runtime);
        }

        public async Task<ApplyDataModelConfigInfoResponse> ApplyDataModelConfigInfoAsync(ApplyDataModelConfigInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyDataModelConfigInfoWithOptionsAsync(request, runtime);
        }

        public AttachDataResponse AttachDataWithOptions(AttachDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachData",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachDataResponse> AttachDataWithOptionsAsync(AttachDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachData",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachDataResponse AttachData(AttachDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDataWithOptions(request, runtime);
        }

        public async Task<AttachDataResponse> AttachDataAsync(AttachDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDataWithOptionsAsync(request, runtime);
        }

        public AttachDataWithSignatureResponse AttachDataWithSignatureWithOptions(AttachDataWithSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDataWithSignature",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDataWithSignatureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachDataWithSignatureResponse> AttachDataWithSignatureWithOptionsAsync(AttachDataWithSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDataWithSignature",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDataWithSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachDataWithSignatureResponse AttachDataWithSignature(AttachDataWithSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDataWithSignatureWithOptions(request, runtime);
        }

        public async Task<AttachDataWithSignatureResponse> AttachDataWithSignatureAsync(AttachDataWithSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDataWithSignatureWithOptionsAsync(request, runtime);
        }

        public AuthorizeDeviceResponse AuthorizeDeviceWithOptions(AuthorizeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthorizeDeviceResponse> AuthorizeDeviceWithOptionsAsync(AuthorizeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthorizeDeviceResponse AuthorizeDevice(AuthorizeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeDeviceWithOptions(request, runtime);
        }

        public async Task<AuthorizeDeviceResponse> AuthorizeDeviceAsync(AuthorizeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeDeviceWithOptionsAsync(request, runtime);
        }

        public AuthorizeDeviceGroupResponse AuthorizeDeviceGroupWithOptions(AuthorizeDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AuthorizeDeviceGroupResponse> AuthorizeDeviceGroupWithOptionsAsync(AuthorizeDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AuthorizeDeviceGroupResponse AuthorizeDeviceGroup(AuthorizeDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeDeviceGroupWithOptions(request, runtime);
        }

        public async Task<AuthorizeDeviceGroupResponse> AuthorizeDeviceGroupAsync(AuthorizeDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeDeviceGroupWithOptionsAsync(request, runtime);
        }

        public BatchUploadMPCoSPhaseDigestInfoResponse BatchUploadMPCoSPhaseDigestInfoWithOptions(BatchUploadMPCoSPhaseDigestInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseDigestInfoShrinkRequest request = new BatchUploadMPCoSPhaseDigestInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseDigestInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseDigestInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUploadMPCoSPhaseDigestInfoResponse> BatchUploadMPCoSPhaseDigestInfoWithOptionsAsync(BatchUploadMPCoSPhaseDigestInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseDigestInfoShrinkRequest request = new BatchUploadMPCoSPhaseDigestInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseDigestInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseDigestInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUploadMPCoSPhaseDigestInfoResponse BatchUploadMPCoSPhaseDigestInfo(BatchUploadMPCoSPhaseDigestInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUploadMPCoSPhaseDigestInfoWithOptions(request, runtime);
        }

        public async Task<BatchUploadMPCoSPhaseDigestInfoResponse> BatchUploadMPCoSPhaseDigestInfoAsync(BatchUploadMPCoSPhaseDigestInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUploadMPCoSPhaseDigestInfoWithOptionsAsync(request, runtime);
        }

        public BatchUploadMPCoSPhaseDigestInfoByDeviceResponse BatchUploadMPCoSPhaseDigestInfoByDeviceWithOptions(BatchUploadMPCoSPhaseDigestInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseDigestInfoByDeviceShrinkRequest request = new BatchUploadMPCoSPhaseDigestInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseDigestInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseDigestInfoByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUploadMPCoSPhaseDigestInfoByDeviceResponse> BatchUploadMPCoSPhaseDigestInfoByDeviceWithOptionsAsync(BatchUploadMPCoSPhaseDigestInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseDigestInfoByDeviceShrinkRequest request = new BatchUploadMPCoSPhaseDigestInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseDigestInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseDigestInfoByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUploadMPCoSPhaseDigestInfoByDeviceResponse BatchUploadMPCoSPhaseDigestInfoByDevice(BatchUploadMPCoSPhaseDigestInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUploadMPCoSPhaseDigestInfoByDeviceWithOptions(request, runtime);
        }

        public async Task<BatchUploadMPCoSPhaseDigestInfoByDeviceResponse> BatchUploadMPCoSPhaseDigestInfoByDeviceAsync(BatchUploadMPCoSPhaseDigestInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUploadMPCoSPhaseDigestInfoByDeviceWithOptionsAsync(request, runtime);
        }

        public BatchUploadMPCoSPhaseTextInfoResponse BatchUploadMPCoSPhaseTextInfoWithOptions(BatchUploadMPCoSPhaseTextInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseTextInfoShrinkRequest request = new BatchUploadMPCoSPhaseTextInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseTextInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseTextInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUploadMPCoSPhaseTextInfoResponse> BatchUploadMPCoSPhaseTextInfoWithOptionsAsync(BatchUploadMPCoSPhaseTextInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseTextInfoShrinkRequest request = new BatchUploadMPCoSPhaseTextInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseTextInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseTextInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUploadMPCoSPhaseTextInfoResponse BatchUploadMPCoSPhaseTextInfo(BatchUploadMPCoSPhaseTextInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUploadMPCoSPhaseTextInfoWithOptions(request, runtime);
        }

        public async Task<BatchUploadMPCoSPhaseTextInfoResponse> BatchUploadMPCoSPhaseTextInfoAsync(BatchUploadMPCoSPhaseTextInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUploadMPCoSPhaseTextInfoWithOptionsAsync(request, runtime);
        }

        public BatchUploadMPCoSPhaseTextInfoByDeviceResponse BatchUploadMPCoSPhaseTextInfoByDeviceWithOptions(BatchUploadMPCoSPhaseTextInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseTextInfoByDeviceShrinkRequest request = new BatchUploadMPCoSPhaseTextInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseTextInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseTextInfoByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUploadMPCoSPhaseTextInfoByDeviceResponse> BatchUploadMPCoSPhaseTextInfoByDeviceWithOptionsAsync(BatchUploadMPCoSPhaseTextInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadMPCoSPhaseTextInfoByDeviceShrinkRequest request = new BatchUploadMPCoSPhaseTextInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhaseDataList))
            {
                request.PhaseDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhaseDataList, "PhaseDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseDataListShrink))
            {
                query["PhaseDataList"] = request.PhaseDataListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadMPCoSPhaseTextInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadMPCoSPhaseTextInfoByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUploadMPCoSPhaseTextInfoByDeviceResponse BatchUploadMPCoSPhaseTextInfoByDevice(BatchUploadMPCoSPhaseTextInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUploadMPCoSPhaseTextInfoByDeviceWithOptions(request, runtime);
        }

        public async Task<BatchUploadMPCoSPhaseTextInfoByDeviceResponse> BatchUploadMPCoSPhaseTextInfoByDeviceAsync(BatchUploadMPCoSPhaseTextInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUploadMPCoSPhaseTextInfoByDeviceWithOptionsAsync(request, runtime);
        }

        public CreateMPCoSPhaseResponse CreateMPCoSPhaseWithOptions(CreateMPCoSPhaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMPCoSPhase",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMPCoSPhaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMPCoSPhaseResponse> CreateMPCoSPhaseWithOptionsAsync(CreateMPCoSPhaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMPCoSPhase",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMPCoSPhaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMPCoSPhaseResponse CreateMPCoSPhase(CreateMPCoSPhaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPCoSPhaseWithOptions(request, runtime);
        }

        public async Task<CreateMPCoSPhaseResponse> CreateMPCoSPhaseAsync(CreateMPCoSPhaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPCoSPhaseWithOptionsAsync(request, runtime);
        }

        public CreateMPCoSPhaseGroupResponse CreateMPCoSPhaseGroupWithOptions(CreateMPCoSPhaseGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMPCoSPhaseGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMPCoSPhaseGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMPCoSPhaseGroupResponse> CreateMPCoSPhaseGroupWithOptionsAsync(CreateMPCoSPhaseGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMPCoSPhaseGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMPCoSPhaseGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMPCoSPhaseGroupResponse CreateMPCoSPhaseGroup(CreateMPCoSPhaseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMPCoSPhaseGroupWithOptions(request, runtime);
        }

        public async Task<CreateMPCoSPhaseGroupResponse> CreateMPCoSPhaseGroupAsync(CreateMPCoSPhaseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMPCoSPhaseGroupWithOptionsAsync(request, runtime);
        }

        public CreateMemberResponse CreateMemberWithOptions(CreateMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberContact))
            {
                query["MemberContact"] = request.MemberContact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberPhone))
            {
                query["MemberPhone"] = request.MemberPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMemberResponse> CreateMemberWithOptionsAsync(CreateMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberContact))
            {
                query["MemberContact"] = request.MemberContact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberPhone))
            {
                query["MemberPhone"] = request.MemberPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMemberResponse CreateMember(CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMemberWithOptions(request, runtime);
        }

        public async Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMemberWithOptionsAsync(request, runtime);
        }

        public DescribeCapacityInfoResponse DescribeCapacityInfoWithOptions(DescribeCapacityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCapacityInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapacityInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCapacityInfoResponse> DescribeCapacityInfoWithOptionsAsync(DescribeCapacityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCapacityInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapacityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCapacityInfoResponse DescribeCapacityInfo(DescribeCapacityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapacityInfoWithOptions(request, runtime);
        }

        public async Task<DescribeCapacityInfoResponse> DescribeCapacityInfoAsync(DescribeCapacityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapacityInfoWithOptionsAsync(request, runtime);
        }

        public DescribeMPCoSAuthorizedInfoResponse DescribeMPCoSAuthorizedInfoWithOptions(DescribeMPCoSAuthorizedInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPCoSAuthorizedInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPCoSAuthorizedInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMPCoSAuthorizedInfoResponse> DescribeMPCoSAuthorizedInfoWithOptionsAsync(DescribeMPCoSAuthorizedInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPCoSAuthorizedInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPCoSAuthorizedInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMPCoSAuthorizedInfoResponse DescribeMPCoSAuthorizedInfo(DescribeMPCoSAuthorizedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPCoSAuthorizedInfoWithOptions(request, runtime);
        }

        public async Task<DescribeMPCoSAuthorizedInfoResponse> DescribeMPCoSAuthorizedInfoAsync(DescribeMPCoSAuthorizedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPCoSAuthorizedInfoWithOptionsAsync(request, runtime);
        }

        public DescribeMPCoSPhaseInfoResponse DescribeMPCoSPhaseInfoWithOptions(DescribeMPCoSPhaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPCoSPhaseInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPCoSPhaseInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMPCoSPhaseInfoResponse> DescribeMPCoSPhaseInfoWithOptionsAsync(DescribeMPCoSPhaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPCoSPhaseInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPCoSPhaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMPCoSPhaseInfoResponse DescribeMPCoSPhaseInfo(DescribeMPCoSPhaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPCoSPhaseInfoWithOptions(request, runtime);
        }

        public async Task<DescribeMPCoSPhaseInfoResponse> DescribeMPCoSPhaseInfoAsync(DescribeMPCoSPhaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPCoSPhaseInfoWithOptionsAsync(request, runtime);
        }

        public DescribeMPCoSResourceInfoResponse DescribeMPCoSResourceInfoWithOptions(DescribeMPCoSResourceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPCoSResourceInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPCoSResourceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMPCoSResourceInfoResponse> DescribeMPCoSResourceInfoWithOptionsAsync(DescribeMPCoSResourceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMPCoSResourceInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMPCoSResourceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMPCoSResourceInfoResponse DescribeMPCoSResourceInfo(DescribeMPCoSResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMPCoSResourceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeMPCoSResourceInfoResponse> DescribeMPCoSResourceInfoAsync(DescribeMPCoSResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMPCoSResourceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeMemberCapacityInfoResponse DescribeMemberCapacityInfoWithOptions(DescribeMemberCapacityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMemberCapacityInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberCapacityInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMemberCapacityInfoResponse> DescribeMemberCapacityInfoWithOptionsAsync(DescribeMemberCapacityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMemberCapacityInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberCapacityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMemberCapacityInfoResponse DescribeMemberCapacityInfo(DescribeMemberCapacityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMemberCapacityInfoWithOptions(request, runtime);
        }

        public async Task<DescribeMemberCapacityInfoResponse> DescribeMemberCapacityInfoAsync(DescribeMemberCapacityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMemberCapacityInfoWithOptionsAsync(request, runtime);
        }

        public DescribeResourceInfoResponse DescribeResourceInfoWithOptions(DescribeResourceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeResourceInfoResponse> DescribeResourceInfoWithOptionsAsync(DescribeResourceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeResourceInfoResponse DescribeResourceInfo(DescribeResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeResourceInfoResponse> DescribeResourceInfoAsync(DescribeResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceInfoWithOptionsAsync(request, runtime);
        }

        public GetBlockChainInfoResponse GetBlockChainInfoWithOptions(GetBlockChainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBlockChainInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlockChainInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBlockChainInfoResponse> GetBlockChainInfoWithOptionsAsync(GetBlockChainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBlockChainInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlockChainInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBlockChainInfoResponse GetBlockChainInfo(GetBlockChainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBlockChainInfoWithOptions(request, runtime);
        }

        public async Task<GetBlockChainInfoResponse> GetBlockChainInfoAsync(GetBlockChainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBlockChainInfoWithOptionsAsync(request, runtime);
        }

        public GetDataResponse GetDataWithOptions(GetDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetData",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataResponse> GetDataWithOptionsAsync(GetDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetData",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataResponse GetData(GetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataWithOptions(request, runtime);
        }

        public async Task<GetDataResponse> GetDataAsync(GetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataWithOptionsAsync(request, runtime);
        }

        public GetDataModelConfigInfoResponse GetDataModelConfigInfoWithOptions(GetDataModelConfigInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataModelCode))
            {
                query["DataModelCode"] = request.DataModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataModelConfigInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataModelConfigInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataModelConfigInfoResponse> GetDataModelConfigInfoWithOptionsAsync(GetDataModelConfigInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataModelCode))
            {
                query["DataModelCode"] = request.DataModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataModelConfigInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataModelConfigInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataModelConfigInfoResponse GetDataModelConfigInfo(GetDataModelConfigInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataModelConfigInfoWithOptions(request, runtime);
        }

        public async Task<GetDataModelConfigInfoResponse> GetDataModelConfigInfoAsync(GetDataModelConfigInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataModelConfigInfoWithOptionsAsync(request, runtime);
        }

        public GetHistoryDataCountResponse GetHistoryDataCountWithOptions(GetHistoryDataCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoryDataCount",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryDataCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHistoryDataCountResponse> GetHistoryDataCountWithOptionsAsync(GetHistoryDataCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoryDataCount",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryDataCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHistoryDataCountResponse GetHistoryDataCount(GetHistoryDataCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoryDataCountWithOptions(request, runtime);
        }

        public async Task<GetHistoryDataCountResponse> GetHistoryDataCountAsync(GetHistoryDataCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoryDataCountWithOptionsAsync(request, runtime);
        }

        public GetHistoryDataListResponse GetHistoryDataListWithOptions(GetHistoryDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoryDataList",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryDataListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHistoryDataListResponse> GetHistoryDataListWithOptionsAsync(GetHistoryDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoryDataList",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryDataListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHistoryDataListResponse GetHistoryDataList(GetHistoryDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoryDataListWithOptions(request, runtime);
        }

        public async Task<GetHistoryDataListResponse> GetHistoryDataListAsync(GetHistoryDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoryDataListWithOptionsAsync(request, runtime);
        }

        public ListDependentDataModelsResponse ListDependentDataModelsWithOptions(ListDependentDataModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDependentDataModels",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDependentDataModelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDependentDataModelsResponse> ListDependentDataModelsWithOptionsAsync(ListDependentDataModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDependentDataModels",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDependentDataModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDependentDataModelsResponse ListDependentDataModels(ListDependentDataModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDependentDataModelsWithOptions(request, runtime);
        }

        public async Task<ListDependentDataModelsResponse> ListDependentDataModelsAsync(ListDependentDataModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDependentDataModelsWithOptionsAsync(request, runtime);
        }

        public ListDeviceResponse ListDeviceWithOptions(ListDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeviceResponse> ListDeviceWithOptionsAsync(ListDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeviceResponse ListDevice(ListDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceWithOptions(request, runtime);
        }

        public async Task<ListDeviceResponse> ListDeviceAsync(ListDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceWithOptionsAsync(request, runtime);
        }

        public ListDeviceGroupResponse ListDeviceGroupWithOptions(ListDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeviceGroupResponse> ListDeviceGroupWithOptionsAsync(ListDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeviceGroupResponse ListDeviceGroup(ListDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceGroupWithOptions(request, runtime);
        }

        public async Task<ListDeviceGroupResponse> ListDeviceGroupAsync(ListDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceGroupWithOptionsAsync(request, runtime);
        }

        public ListMPCoSPhaseResponse ListMPCoSPhaseWithOptions(ListMPCoSPhaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMPCoSPhase",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMPCoSPhaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMPCoSPhaseResponse> ListMPCoSPhaseWithOptionsAsync(ListMPCoSPhaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMPCoSPhase",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMPCoSPhaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMPCoSPhaseResponse ListMPCoSPhase(ListMPCoSPhaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMPCoSPhaseWithOptions(request, runtime);
        }

        public async Task<ListMPCoSPhaseResponse> ListMPCoSPhaseAsync(ListMPCoSPhaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMPCoSPhaseWithOptionsAsync(request, runtime);
        }

        public ListMPCoSPhaseGroupResponse ListMPCoSPhaseGroupWithOptions(ListMPCoSPhaseGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMPCoSPhaseGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMPCoSPhaseGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMPCoSPhaseGroupResponse> ListMPCoSPhaseGroupWithOptionsAsync(ListMPCoSPhaseGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMPCoSPhaseGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMPCoSPhaseGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMPCoSPhaseGroupResponse ListMPCoSPhaseGroup(ListMPCoSPhaseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMPCoSPhaseGroupWithOptions(request, runtime);
        }

        public async Task<ListMPCoSPhaseGroupResponse> ListMPCoSPhaseGroupAsync(ListMPCoSPhaseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMPCoSPhaseGroupWithOptionsAsync(request, runtime);
        }

        public ListMPCoSPhaseHistoryResponse ListMPCoSPhaseHistoryWithOptions(ListMPCoSPhaseHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMPCoSPhaseHistory",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMPCoSPhaseHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMPCoSPhaseHistoryResponse> ListMPCoSPhaseHistoryWithOptionsAsync(ListMPCoSPhaseHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMPCoSPhaseHistory",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMPCoSPhaseHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMPCoSPhaseHistoryResponse ListMPCoSPhaseHistory(ListMPCoSPhaseHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMPCoSPhaseHistoryWithOptions(request, runtime);
        }

        public async Task<ListMPCoSPhaseHistoryResponse> ListMPCoSPhaseHistoryAsync(ListMPCoSPhaseHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMPCoSPhaseHistoryWithOptionsAsync(request, runtime);
        }

        public ListMemberResponse ListMemberWithOptions(ListMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMemberResponse> ListMemberWithOptionsAsync(ListMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMemberResponse ListMember(ListMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMemberWithOptions(request, runtime);
        }

        public async Task<ListMemberResponse> ListMemberAsync(ListMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMemberWithOptionsAsync(request, runtime);
        }

        public ListMultiPartyCollaborationChainResponse ListMultiPartyCollaborationChainWithOptions(ListMultiPartyCollaborationChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiPartyCollaborationChain",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMultiPartyCollaborationChainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMultiPartyCollaborationChainResponse> ListMultiPartyCollaborationChainWithOptionsAsync(ListMultiPartyCollaborationChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiPartyCollaborationChain",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMultiPartyCollaborationChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMultiPartyCollaborationChainResponse ListMultiPartyCollaborationChain(ListMultiPartyCollaborationChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMultiPartyCollaborationChainWithOptions(request, runtime);
        }

        public async Task<ListMultiPartyCollaborationChainResponse> ListMultiPartyCollaborationChainAsync(ListMultiPartyCollaborationChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMultiPartyCollaborationChainWithOptionsAsync(request, runtime);
        }

        public ListPSMemberDataTypeCodeResponse ListPSMemberDataTypeCodeWithOptions(ListPSMemberDataTypeCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPSMemberDataTypeCode",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPSMemberDataTypeCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPSMemberDataTypeCodeResponse> ListPSMemberDataTypeCodeWithOptionsAsync(ListPSMemberDataTypeCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPSMemberDataTypeCode",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPSMemberDataTypeCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPSMemberDataTypeCodeResponse ListPSMemberDataTypeCode(ListPSMemberDataTypeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPSMemberDataTypeCodeWithOptions(request, runtime);
        }

        public async Task<ListPSMemberDataTypeCodeResponse> ListPSMemberDataTypeCodeAsync(ListPSMemberDataTypeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPSMemberDataTypeCodeWithOptionsAsync(request, runtime);
        }

        public ListProofChainResponse ListProofChainWithOptions(ListProofChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProofChain",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProofChainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProofChainResponse> ListProofChainWithOptionsAsync(ListProofChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProofChain",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProofChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProofChainResponse ListProofChain(ListProofChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProofChainWithOptions(request, runtime);
        }

        public async Task<ListProofChainResponse> ListProofChainAsync(ListProofChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProofChainWithOptionsAsync(request, runtime);
        }

        public LockMemberResponse LockMemberWithOptions(LockMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LockMemberResponse> LockMemberWithOptionsAsync(LockMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LockMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LockMemberResponse LockMember(LockMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockMemberWithOptions(request, runtime);
        }

        public async Task<LockMemberResponse> LockMemberAsync(LockMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockMemberWithOptionsAsync(request, runtime);
        }

        public ModifyMPCoSPhaseResponse ModifyMPCoSPhaseWithOptions(ModifyMPCoSPhaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMPCoSPhase",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMPCoSPhaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMPCoSPhaseResponse> ModifyMPCoSPhaseWithOptionsAsync(ModifyMPCoSPhaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMPCoSPhase",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMPCoSPhaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMPCoSPhaseResponse ModifyMPCoSPhase(ModifyMPCoSPhaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPCoSPhaseWithOptions(request, runtime);
        }

        public async Task<ModifyMPCoSPhaseResponse> ModifyMPCoSPhaseAsync(ModifyMPCoSPhaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPCoSPhaseWithOptionsAsync(request, runtime);
        }

        public ModifyMPCoSPhaseGroupResponse ModifyMPCoSPhaseGroupWithOptions(ModifyMPCoSPhaseGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMPCoSPhaseGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMPCoSPhaseGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMPCoSPhaseGroupResponse> ModifyMPCoSPhaseGroupWithOptionsAsync(ModifyMPCoSPhaseGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMPCoSPhaseGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMPCoSPhaseGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMPCoSPhaseGroupResponse ModifyMPCoSPhaseGroup(ModifyMPCoSPhaseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMPCoSPhaseGroupWithOptions(request, runtime);
        }

        public async Task<ModifyMPCoSPhaseGroupResponse> ModifyMPCoSPhaseGroupAsync(ModifyMPCoSPhaseGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMPCoSPhaseGroupWithOptionsAsync(request, runtime);
        }

        public ModifyMemberResponse ModifyMemberWithOptions(ModifyMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberContact))
            {
                query["MemberContact"] = request.MemberContact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberPhone))
            {
                query["MemberPhone"] = request.MemberPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMemberResponse> ModifyMemberWithOptionsAsync(ModifyMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberContact))
            {
                query["MemberContact"] = request.MemberContact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberPhone))
            {
                query["MemberPhone"] = request.MemberPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMemberResponse ModifyMember(ModifyMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMemberWithOptions(request, runtime);
        }

        public async Task<ModifyMemberResponse> ModifyMemberAsync(ModifyMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMemberWithOptionsAsync(request, runtime);
        }

        public RegisterDeviceGroupResponse RegisterDeviceGroupWithOptions(RegisterDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeType))
            {
                query["AuthorizeType"] = request.AuthorizeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupName))
            {
                query["DeviceGroupName"] = request.DeviceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterDeviceGroupResponse> RegisterDeviceGroupWithOptionsAsync(RegisterDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeType))
            {
                query["AuthorizeType"] = request.AuthorizeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupName))
            {
                query["DeviceGroupName"] = request.DeviceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterDeviceGroupResponse RegisterDeviceGroup(RegisterDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceGroupWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceGroupResponse> RegisterDeviceGroupAsync(RegisterDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceGroupWithOptionsAsync(request, runtime);
        }

        public SetDataResponse SetDataWithOptions(SetDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetData",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDataResponse> SetDataWithOptionsAsync(SetDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetData",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDataResponse SetData(SetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataWithOptions(request, runtime);
        }

        public async Task<SetDataResponse> SetDataAsync(SetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataWithOptionsAsync(request, runtime);
        }

        public SetDataWithSignatureResponse SetDataWithSignatureWithOptions(SetDataWithSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataWithSignature",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataWithSignatureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDataWithSignatureResponse> SetDataWithSignatureWithOptionsAsync(SetDataWithSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDataWithSignature",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDataWithSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDataWithSignatureResponse SetDataWithSignature(SetDataWithSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataWithSignatureWithOptions(request, runtime);
        }

        public async Task<SetDataWithSignatureResponse> SetDataWithSignatureAsync(SetDataWithSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataWithSignatureWithOptionsAsync(request, runtime);
        }

        public UnAuthorizeDeviceResponse UnAuthorizeDeviceWithOptions(UnAuthorizeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAuthorizeDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAuthorizeDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnAuthorizeDeviceResponse> UnAuthorizeDeviceWithOptionsAsync(UnAuthorizeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAuthorizeDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAuthorizeDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnAuthorizeDeviceResponse UnAuthorizeDevice(UnAuthorizeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnAuthorizeDeviceWithOptions(request, runtime);
        }

        public async Task<UnAuthorizeDeviceResponse> UnAuthorizeDeviceAsync(UnAuthorizeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnAuthorizeDeviceWithOptionsAsync(request, runtime);
        }

        public UnAuthorizeDeviceGroupResponse UnAuthorizeDeviceGroupWithOptions(UnAuthorizeDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAuthorizeDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAuthorizeDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnAuthorizeDeviceGroupResponse> UnAuthorizeDeviceGroupWithOptionsAsync(UnAuthorizeDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnAuthorizeDeviceGroup",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnAuthorizeDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnAuthorizeDeviceGroupResponse UnAuthorizeDeviceGroup(UnAuthorizeDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnAuthorizeDeviceGroupWithOptions(request, runtime);
        }

        public async Task<UnAuthorizeDeviceGroupResponse> UnAuthorizeDeviceGroupAsync(UnAuthorizeDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnAuthorizeDeviceGroupWithOptionsAsync(request, runtime);
        }

        public UnLockMemberResponse UnLockMemberWithOptions(UnLockMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLockMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLockMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnLockMemberResponse> UnLockMemberWithOptionsAsync(UnLockMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLockMember",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLockMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnLockMemberResponse UnLockMember(UnLockMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnLockMemberWithOptions(request, runtime);
        }

        public async Task<UnLockMemberResponse> UnLockMemberAsync(UnLockMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnLockMemberWithOptionsAsync(request, runtime);
        }

        public UpdateMPCoSAuthorizedInfoResponse UpdateMPCoSAuthorizedInfoWithOptions(UpdateMPCoSAuthorizedInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMPCoSAuthorizedInfoShrinkRequest request = new UpdateMPCoSAuthorizedInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthorizedPhaseList))
            {
                request.AuthorizedPhaseListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthorizedPhaseList, "AuthorizedPhaseList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedPhaseListShrink))
            {
                query["AuthorizedPhaseList"] = request.AuthorizedPhaseListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMPCoSAuthorizedInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMPCoSAuthorizedInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMPCoSAuthorizedInfoResponse> UpdateMPCoSAuthorizedInfoWithOptionsAsync(UpdateMPCoSAuthorizedInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMPCoSAuthorizedInfoShrinkRequest request = new UpdateMPCoSAuthorizedInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthorizedPhaseList))
            {
                request.AuthorizedPhaseListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthorizedPhaseList, "AuthorizedPhaseList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedPhaseListShrink))
            {
                query["AuthorizedPhaseList"] = request.AuthorizedPhaseListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMPCoSAuthorizedInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMPCoSAuthorizedInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMPCoSAuthorizedInfoResponse UpdateMPCoSAuthorizedInfo(UpdateMPCoSAuthorizedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMPCoSAuthorizedInfoWithOptions(request, runtime);
        }

        public async Task<UpdateMPCoSAuthorizedInfoResponse> UpdateMPCoSAuthorizedInfoAsync(UpdateMPCoSAuthorizedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMPCoSAuthorizedInfoWithOptionsAsync(request, runtime);
        }

        public UploadMPCoSPhaseDigestInfoResponse UploadMPCoSPhaseDigestInfoWithOptions(UploadMPCoSPhaseDigestInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseDigestInfoShrinkRequest request = new UploadMPCoSPhaseDigestInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseDigestInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseDigestInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadMPCoSPhaseDigestInfoResponse> UploadMPCoSPhaseDigestInfoWithOptionsAsync(UploadMPCoSPhaseDigestInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseDigestInfoShrinkRequest request = new UploadMPCoSPhaseDigestInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseDigestInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseDigestInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadMPCoSPhaseDigestInfoResponse UploadMPCoSPhaseDigestInfo(UploadMPCoSPhaseDigestInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMPCoSPhaseDigestInfoWithOptions(request, runtime);
        }

        public async Task<UploadMPCoSPhaseDigestInfoResponse> UploadMPCoSPhaseDigestInfoAsync(UploadMPCoSPhaseDigestInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMPCoSPhaseDigestInfoWithOptionsAsync(request, runtime);
        }

        public UploadMPCoSPhaseDigestInfoByDeviceResponse UploadMPCoSPhaseDigestInfoByDeviceWithOptions(UploadMPCoSPhaseDigestInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseDigestInfoByDeviceShrinkRequest request = new UploadMPCoSPhaseDigestInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseDigestInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseDigestInfoByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadMPCoSPhaseDigestInfoByDeviceResponse> UploadMPCoSPhaseDigestInfoByDeviceWithOptionsAsync(UploadMPCoSPhaseDigestInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseDigestInfoByDeviceShrinkRequest request = new UploadMPCoSPhaseDigestInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseDigestInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseDigestInfoByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadMPCoSPhaseDigestInfoByDeviceResponse UploadMPCoSPhaseDigestInfoByDevice(UploadMPCoSPhaseDigestInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMPCoSPhaseDigestInfoByDeviceWithOptions(request, runtime);
        }

        public async Task<UploadMPCoSPhaseDigestInfoByDeviceResponse> UploadMPCoSPhaseDigestInfoByDeviceAsync(UploadMPCoSPhaseDigestInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMPCoSPhaseDigestInfoByDeviceWithOptionsAsync(request, runtime);
        }

        public UploadMPCoSPhaseTextInfoResponse UploadMPCoSPhaseTextInfoWithOptions(UploadMPCoSPhaseTextInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseTextInfoShrinkRequest request = new UploadMPCoSPhaseTextInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseTextInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseTextInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadMPCoSPhaseTextInfoResponse> UploadMPCoSPhaseTextInfoWithOptionsAsync(UploadMPCoSPhaseTextInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseTextInfoShrinkRequest request = new UploadMPCoSPhaseTextInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseTextInfo",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseTextInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadMPCoSPhaseTextInfoResponse UploadMPCoSPhaseTextInfo(UploadMPCoSPhaseTextInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMPCoSPhaseTextInfoWithOptions(request, runtime);
        }

        public async Task<UploadMPCoSPhaseTextInfoResponse> UploadMPCoSPhaseTextInfoAsync(UploadMPCoSPhaseTextInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMPCoSPhaseTextInfoWithOptionsAsync(request, runtime);
        }

        public UploadMPCoSPhaseTextInfoByDeviceResponse UploadMPCoSPhaseTextInfoByDeviceWithOptions(UploadMPCoSPhaseTextInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseTextInfoByDeviceShrinkRequest request = new UploadMPCoSPhaseTextInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseTextInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseTextInfoByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadMPCoSPhaseTextInfoByDeviceResponse> UploadMPCoSPhaseTextInfoByDeviceWithOptionsAsync(UploadMPCoSPhaseTextInfoByDeviceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadMPCoSPhaseTextInfoByDeviceShrinkRequest request = new UploadMPCoSPhaseTextInfoByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RelatedDataList))
            {
                request.RelatedDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RelatedDataList, "RelatedDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKey))
            {
                query["DataKey"] = request.DataKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSeq))
            {
                query["DataSeq"] = request.DataSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotSignature))
            {
                query["IotSignature"] = request.IotSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseData))
            {
                query["PhaseData"] = request.PhaseData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseGroupId))
            {
                query["PhaseGroupId"] = request.PhaseGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhaseId))
            {
                query["PhaseId"] = request.PhaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDataListShrink))
            {
                query["RelatedDataList"] = request.RelatedDataListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMPCoSPhaseTextInfoByDevice",
                Version = "2019-05-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMPCoSPhaseTextInfoByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadMPCoSPhaseTextInfoByDeviceResponse UploadMPCoSPhaseTextInfoByDevice(UploadMPCoSPhaseTextInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMPCoSPhaseTextInfoByDeviceWithOptions(request, runtime);
        }

        public async Task<UploadMPCoSPhaseTextInfoByDeviceResponse> UploadMPCoSPhaseTextInfoByDeviceAsync(UploadMPCoSPhaseTextInfoByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMPCoSPhaseTextInfoByDeviceWithOptionsAsync(request, runtime);
        }

    }
}
