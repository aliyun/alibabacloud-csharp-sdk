// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cbn20170912.Models;

namespace AlibabaCloud.SDK.Cbn20170912
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "cbn.aliyuncs.com"},
                {"cn-beijing", "cbn.aliyuncs.com"},
                {"cn-chengdu", "cbn.aliyuncs.com"},
                {"cn-zhangjiakou", "cbn.aliyuncs.com"},
                {"cn-huhehaote", "cbn.aliyuncs.com"},
                {"cn-hangzhou", "cbn.aliyuncs.com"},
                {"cn-shanghai", "cbn.aliyuncs.com"},
                {"cn-shenzhen", "cbn.aliyuncs.com"},
                {"cn-heyuan", "cbn.aliyuncs.com"},
                {"cn-wulanchabu", "cbn.aliyuncs.com"},
                {"cn-hongkong", "cbn.aliyuncs.com"},
                {"ap-southeast-1", "cbn.aliyuncs.com"},
                {"ap-southeast-2", "cbn.aliyuncs.com"},
                {"ap-southeast-3", "cbn.aliyuncs.com"},
                {"ap-southeast-5", "cbn.aliyuncs.com"},
                {"ap-northeast-1", "cbn.aliyuncs.com"},
                {"eu-west-1", "cbn.aliyuncs.com"},
                {"us-west-1", "cbn.aliyuncs.com"},
                {"us-east-1", "cbn.aliyuncs.com"},
                {"eu-central-1", "cbn.aliyuncs.com"},
                {"me-east-1", "cbn.aliyuncs.com"},
                {"ap-south-1", "cbn.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cbn.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cbn.aliyuncs.com"},
                {"cn-north-2-gov-1", "cbn.aliyuncs.com"},
                {"ap-northeast-2-pop", "cbn.aliyuncs.com"},
                {"cn-beijing-finance-1", "cbn.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cbn.aliyuncs.com"},
                {"cn-beijing-gov-1", "cbn.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cbn.aliyuncs.com"},
                {"cn-edge-1", "cbn.aliyuncs.com"},
                {"cn-fujian", "cbn.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cbn.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cbn.aliyuncs.com"},
                {"cn-hangzhou-finance", "cbn.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cbn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cbn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cbn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cbn.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cbn.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cbn.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "cbn.aliyuncs.com"},
                {"cn-qingdao-nebula", "cbn.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cbn.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cbn.aliyuncs.com"},
                {"cn-shanghai-inner", "cbn.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cbn.aliyuncs.com"},
                {"cn-shenzhen-inner", "cbn.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cbn.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cbn.aliyuncs.com"},
                {"cn-wuhan", "cbn.aliyuncs.com"},
                {"cn-yushanfang", "cbn.aliyuncs.com"},
                {"cn-zhangbei", "cbn.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cbn.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cbn.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cbn.aliyuncs.com"},
                {"eu-west-1-oxs", "cbn.aliyuncs.com"},
                {"rus-west-1-pop", "cbn-share.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cbn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActiveFlowLogResponse ActiveFlowLogWithOptions(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(DoRPCRequest("ActiveFlowLog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogWithOptionsAsync(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(await DoRPCRequestAsync("ActiveFlowLog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActiveFlowLogResponse ActiveFlowLog(ActiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveFlowLogWithOptions(request, runtime);
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogAsync(ActiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveFlowLogWithOptionsAsync(request, runtime);
        }

        public AssociateCenBandwidthPackageResponse AssociateCenBandwidthPackageWithOptions(AssociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateCenBandwidthPackageResponse>(DoRPCRequest("AssociateCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateCenBandwidthPackageResponse> AssociateCenBandwidthPackageWithOptionsAsync(AssociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateCenBandwidthPackageResponse>(await DoRPCRequestAsync("AssociateCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateCenBandwidthPackageResponse AssociateCenBandwidthPackage(AssociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<AssociateCenBandwidthPackageResponse> AssociateCenBandwidthPackageAsync(AssociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public AttachCenChildInstanceResponse AttachCenChildInstanceWithOptions(AttachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachCenChildInstanceResponse>(DoRPCRequest("AttachCenChildInstance", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachCenChildInstanceResponse> AttachCenChildInstanceWithOptionsAsync(AttachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachCenChildInstanceResponse>(await DoRPCRequestAsync("AttachCenChildInstance", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachCenChildInstanceResponse AttachCenChildInstance(AttachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachCenChildInstanceWithOptions(request, runtime);
        }

        public async Task<AttachCenChildInstanceResponse> AttachCenChildInstanceAsync(AttachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachCenChildInstanceWithOptionsAsync(request, runtime);
        }

        public CreateCenResponse CreateCenWithOptions(CreateCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenResponse>(DoRPCRequest("CreateCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCenResponse> CreateCenWithOptionsAsync(CreateCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenResponse>(await DoRPCRequestAsync("CreateCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCenResponse CreateCen(CreateCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenWithOptions(request, runtime);
        }

        public async Task<CreateCenResponse> CreateCenAsync(CreateCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenWithOptionsAsync(request, runtime);
        }

        public CreateCenBandwidthPackageResponse CreateCenBandwidthPackageWithOptions(CreateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenBandwidthPackageResponse>(DoRPCRequest("CreateCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCenBandwidthPackageResponse> CreateCenBandwidthPackageWithOptionsAsync(CreateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenBandwidthPackageResponse>(await DoRPCRequestAsync("CreateCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCenBandwidthPackageResponse CreateCenBandwidthPackage(CreateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<CreateCenBandwidthPackageResponse> CreateCenBandwidthPackageAsync(CreateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public CreateCenChildInstanceRouteEntryToCenResponse CreateCenChildInstanceRouteEntryToCenWithOptions(CreateCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenChildInstanceRouteEntryToCenResponse>(DoRPCRequest("CreateCenChildInstanceRouteEntryToCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCenChildInstanceRouteEntryToCenResponse> CreateCenChildInstanceRouteEntryToCenWithOptionsAsync(CreateCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenChildInstanceRouteEntryToCenResponse>(await DoRPCRequestAsync("CreateCenChildInstanceRouteEntryToCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCenChildInstanceRouteEntryToCenResponse CreateCenChildInstanceRouteEntryToCen(CreateCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenChildInstanceRouteEntryToCenWithOptions(request, runtime);
        }

        public async Task<CreateCenChildInstanceRouteEntryToCenResponse> CreateCenChildInstanceRouteEntryToCenAsync(CreateCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenChildInstanceRouteEntryToCenWithOptionsAsync(request, runtime);
        }

        public CreateCenRouteMapResponse CreateCenRouteMapWithOptions(CreateCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenRouteMapResponse>(DoRPCRequest("CreateCenRouteMap", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCenRouteMapResponse> CreateCenRouteMapWithOptionsAsync(CreateCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCenRouteMapResponse>(await DoRPCRequestAsync("CreateCenRouteMap", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCenRouteMapResponse CreateCenRouteMap(CreateCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenRouteMapWithOptions(request, runtime);
        }

        public async Task<CreateCenRouteMapResponse> CreateCenRouteMapAsync(CreateCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenRouteMapWithOptionsAsync(request, runtime);
        }

        public CreateFlowlogResponse CreateFlowlogWithOptions(CreateFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowlogResponse>(DoRPCRequest("CreateFlowlog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowlogResponse> CreateFlowlogWithOptionsAsync(CreateFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowlogResponse>(await DoRPCRequestAsync("CreateFlowlog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowlogResponse CreateFlowlog(CreateFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowlogWithOptions(request, runtime);
        }

        public async Task<CreateFlowlogResponse> CreateFlowlogAsync(CreateFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowlogWithOptionsAsync(request, runtime);
        }

        public DeactiveFlowLogResponse DeactiveFlowLogWithOptions(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(DoRPCRequest("DeactiveFlowLog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogWithOptionsAsync(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(await DoRPCRequestAsync("DeactiveFlowLog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactiveFlowLogResponse DeactiveFlowLog(DeactiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveFlowLogWithOptions(request, runtime);
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogAsync(DeactiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveFlowLogWithOptionsAsync(request, runtime);
        }

        public DeleteCenResponse DeleteCenWithOptions(DeleteCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenResponse>(DoRPCRequest("DeleteCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCenResponse> DeleteCenWithOptionsAsync(DeleteCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenResponse>(await DoRPCRequestAsync("DeleteCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCenResponse DeleteCen(DeleteCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenWithOptions(request, runtime);
        }

        public async Task<DeleteCenResponse> DeleteCenAsync(DeleteCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenWithOptionsAsync(request, runtime);
        }

        public DeleteCenBandwidthPackageResponse DeleteCenBandwidthPackageWithOptions(DeleteCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenBandwidthPackageResponse>(DoRPCRequest("DeleteCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCenBandwidthPackageResponse> DeleteCenBandwidthPackageWithOptionsAsync(DeleteCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenBandwidthPackageResponse>(await DoRPCRequestAsync("DeleteCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCenBandwidthPackageResponse DeleteCenBandwidthPackage(DeleteCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<DeleteCenBandwidthPackageResponse> DeleteCenBandwidthPackageAsync(DeleteCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public DeleteCenChildInstanceRouteEntryToCenResponse DeleteCenChildInstanceRouteEntryToCenWithOptions(DeleteCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenChildInstanceRouteEntryToCenResponse>(DoRPCRequest("DeleteCenChildInstanceRouteEntryToCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCenChildInstanceRouteEntryToCenResponse> DeleteCenChildInstanceRouteEntryToCenWithOptionsAsync(DeleteCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenChildInstanceRouteEntryToCenResponse>(await DoRPCRequestAsync("DeleteCenChildInstanceRouteEntryToCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCenChildInstanceRouteEntryToCenResponse DeleteCenChildInstanceRouteEntryToCen(DeleteCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenChildInstanceRouteEntryToCenWithOptions(request, runtime);
        }

        public async Task<DeleteCenChildInstanceRouteEntryToCenResponse> DeleteCenChildInstanceRouteEntryToCenAsync(DeleteCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenChildInstanceRouteEntryToCenWithOptionsAsync(request, runtime);
        }

        public DeleteCenRouteMapResponse DeleteCenRouteMapWithOptions(DeleteCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenRouteMapResponse>(DoRPCRequest("DeleteCenRouteMap", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCenRouteMapResponse> DeleteCenRouteMapWithOptionsAsync(DeleteCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCenRouteMapResponse>(await DoRPCRequestAsync("DeleteCenRouteMap", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCenRouteMapResponse DeleteCenRouteMap(DeleteCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenRouteMapWithOptions(request, runtime);
        }

        public async Task<DeleteCenRouteMapResponse> DeleteCenRouteMapAsync(DeleteCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenRouteMapWithOptionsAsync(request, runtime);
        }

        public DeleteFlowlogResponse DeleteFlowlogWithOptions(DeleteFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowlogResponse>(DoRPCRequest("DeleteFlowlog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowlogResponse> DeleteFlowlogWithOptionsAsync(DeleteFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowlogResponse>(await DoRPCRequestAsync("DeleteFlowlog", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowlogResponse DeleteFlowlog(DeleteFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowlogWithOptions(request, runtime);
        }

        public async Task<DeleteFlowlogResponse> DeleteFlowlogAsync(DeleteFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowlogWithOptionsAsync(request, runtime);
        }

        public DeleteRouteServiceInCenResponse DeleteRouteServiceInCenWithOptions(DeleteRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteServiceInCenResponse>(DoRPCRequest("DeleteRouteServiceInCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouteServiceInCenResponse> DeleteRouteServiceInCenWithOptionsAsync(DeleteRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteServiceInCenResponse>(await DoRPCRequestAsync("DeleteRouteServiceInCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouteServiceInCenResponse DeleteRouteServiceInCen(DeleteRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteServiceInCenWithOptions(request, runtime);
        }

        public async Task<DeleteRouteServiceInCenResponse> DeleteRouteServiceInCenAsync(DeleteRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteServiceInCenWithOptionsAsync(request, runtime);
        }

        public DescribeCenAttachedChildInstanceAttributeResponse DescribeCenAttachedChildInstanceAttributeWithOptions(DescribeCenAttachedChildInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstanceAttributeResponse>(DoRPCRequest("DescribeCenAttachedChildInstanceAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenAttachedChildInstanceAttributeResponse> DescribeCenAttachedChildInstanceAttributeWithOptionsAsync(DescribeCenAttachedChildInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeCenAttachedChildInstanceAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenAttachedChildInstanceAttributeResponse DescribeCenAttachedChildInstanceAttribute(DescribeCenAttachedChildInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenAttachedChildInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeCenAttachedChildInstanceAttributeResponse> DescribeCenAttachedChildInstanceAttributeAsync(DescribeCenAttachedChildInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenAttachedChildInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeCenAttachedChildInstancesResponse DescribeCenAttachedChildInstancesWithOptions(DescribeCenAttachedChildInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstancesResponse>(DoRPCRequest("DescribeCenAttachedChildInstances", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenAttachedChildInstancesResponse> DescribeCenAttachedChildInstancesWithOptionsAsync(DescribeCenAttachedChildInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstancesResponse>(await DoRPCRequestAsync("DescribeCenAttachedChildInstances", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenAttachedChildInstancesResponse DescribeCenAttachedChildInstances(DescribeCenAttachedChildInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenAttachedChildInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeCenAttachedChildInstancesResponse> DescribeCenAttachedChildInstancesAsync(DescribeCenAttachedChildInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenAttachedChildInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeCenBandwidthPackagesResponse DescribeCenBandwidthPackagesWithOptions(DescribeCenBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenBandwidthPackagesResponse>(DoRPCRequest("DescribeCenBandwidthPackages", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenBandwidthPackagesResponse> DescribeCenBandwidthPackagesWithOptionsAsync(DescribeCenBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenBandwidthPackagesResponse>(await DoRPCRequestAsync("DescribeCenBandwidthPackages", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenBandwidthPackagesResponse DescribeCenBandwidthPackages(DescribeCenBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenBandwidthPackagesWithOptions(request, runtime);
        }

        public async Task<DescribeCenBandwidthPackagesResponse> DescribeCenBandwidthPackagesAsync(DescribeCenBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenBandwidthPackagesWithOptionsAsync(request, runtime);
        }

        public DescribeCenChildInstanceRouteEntriesResponse DescribeCenChildInstanceRouteEntriesWithOptions(DescribeCenChildInstanceRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenChildInstanceRouteEntriesResponse>(DoRPCRequest("DescribeCenChildInstanceRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenChildInstanceRouteEntriesResponse> DescribeCenChildInstanceRouteEntriesWithOptionsAsync(DescribeCenChildInstanceRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenChildInstanceRouteEntriesResponse>(await DoRPCRequestAsync("DescribeCenChildInstanceRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenChildInstanceRouteEntriesResponse DescribeCenChildInstanceRouteEntries(DescribeCenChildInstanceRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenChildInstanceRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeCenChildInstanceRouteEntriesResponse> DescribeCenChildInstanceRouteEntriesAsync(DescribeCenChildInstanceRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenChildInstanceRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeCenGeographicSpanRemainingBandwidthResponse DescribeCenGeographicSpanRemainingBandwidthWithOptions(DescribeCenGeographicSpanRemainingBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenGeographicSpanRemainingBandwidthResponse>(DoRPCRequest("DescribeCenGeographicSpanRemainingBandwidth", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenGeographicSpanRemainingBandwidthResponse> DescribeCenGeographicSpanRemainingBandwidthWithOptionsAsync(DescribeCenGeographicSpanRemainingBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenGeographicSpanRemainingBandwidthResponse>(await DoRPCRequestAsync("DescribeCenGeographicSpanRemainingBandwidth", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenGeographicSpanRemainingBandwidthResponse DescribeCenGeographicSpanRemainingBandwidth(DescribeCenGeographicSpanRemainingBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenGeographicSpanRemainingBandwidthWithOptions(request, runtime);
        }

        public async Task<DescribeCenGeographicSpanRemainingBandwidthResponse> DescribeCenGeographicSpanRemainingBandwidthAsync(DescribeCenGeographicSpanRemainingBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenGeographicSpanRemainingBandwidthWithOptionsAsync(request, runtime);
        }

        public DescribeCenGeographicSpansResponse DescribeCenGeographicSpansWithOptions(DescribeCenGeographicSpansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenGeographicSpansResponse>(DoRPCRequest("DescribeCenGeographicSpans", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenGeographicSpansResponse> DescribeCenGeographicSpansWithOptionsAsync(DescribeCenGeographicSpansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenGeographicSpansResponse>(await DoRPCRequestAsync("DescribeCenGeographicSpans", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenGeographicSpansResponse DescribeCenGeographicSpans(DescribeCenGeographicSpansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenGeographicSpansWithOptions(request, runtime);
        }

        public async Task<DescribeCenGeographicSpansResponse> DescribeCenGeographicSpansAsync(DescribeCenGeographicSpansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenGeographicSpansWithOptionsAsync(request, runtime);
        }

        public DescribeCenInterRegionBandwidthLimitsResponse DescribeCenInterRegionBandwidthLimitsWithOptions(DescribeCenInterRegionBandwidthLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenInterRegionBandwidthLimitsResponse>(DoRPCRequest("DescribeCenInterRegionBandwidthLimits", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenInterRegionBandwidthLimitsResponse> DescribeCenInterRegionBandwidthLimitsWithOptionsAsync(DescribeCenInterRegionBandwidthLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenInterRegionBandwidthLimitsResponse>(await DoRPCRequestAsync("DescribeCenInterRegionBandwidthLimits", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenInterRegionBandwidthLimitsResponse DescribeCenInterRegionBandwidthLimits(DescribeCenInterRegionBandwidthLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenInterRegionBandwidthLimitsWithOptions(request, runtime);
        }

        public async Task<DescribeCenInterRegionBandwidthLimitsResponse> DescribeCenInterRegionBandwidthLimitsAsync(DescribeCenInterRegionBandwidthLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenInterRegionBandwidthLimitsWithOptionsAsync(request, runtime);
        }

        public DescribeCenPrivateZoneRoutesResponse DescribeCenPrivateZoneRoutesWithOptions(DescribeCenPrivateZoneRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenPrivateZoneRoutesResponse>(DoRPCRequest("DescribeCenPrivateZoneRoutes", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenPrivateZoneRoutesResponse> DescribeCenPrivateZoneRoutesWithOptionsAsync(DescribeCenPrivateZoneRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenPrivateZoneRoutesResponse>(await DoRPCRequestAsync("DescribeCenPrivateZoneRoutes", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenPrivateZoneRoutesResponse DescribeCenPrivateZoneRoutes(DescribeCenPrivateZoneRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenPrivateZoneRoutesWithOptions(request, runtime);
        }

        public async Task<DescribeCenPrivateZoneRoutesResponse> DescribeCenPrivateZoneRoutesAsync(DescribeCenPrivateZoneRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenPrivateZoneRoutesWithOptionsAsync(request, runtime);
        }

        public DescribeCenRegionDomainRouteEntriesResponse DescribeCenRegionDomainRouteEntriesWithOptions(DescribeCenRegionDomainRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenRegionDomainRouteEntriesResponse>(DoRPCRequest("DescribeCenRegionDomainRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenRegionDomainRouteEntriesResponse> DescribeCenRegionDomainRouteEntriesWithOptionsAsync(DescribeCenRegionDomainRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenRegionDomainRouteEntriesResponse>(await DoRPCRequestAsync("DescribeCenRegionDomainRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenRegionDomainRouteEntriesResponse DescribeCenRegionDomainRouteEntries(DescribeCenRegionDomainRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenRegionDomainRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeCenRegionDomainRouteEntriesResponse> DescribeCenRegionDomainRouteEntriesAsync(DescribeCenRegionDomainRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenRegionDomainRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeCenRouteMapsResponse DescribeCenRouteMapsWithOptions(DescribeCenRouteMapsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenRouteMapsResponse>(DoRPCRequest("DescribeCenRouteMaps", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenRouteMapsResponse> DescribeCenRouteMapsWithOptionsAsync(DescribeCenRouteMapsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenRouteMapsResponse>(await DoRPCRequestAsync("DescribeCenRouteMaps", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenRouteMapsResponse DescribeCenRouteMaps(DescribeCenRouteMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenRouteMapsWithOptions(request, runtime);
        }

        public async Task<DescribeCenRouteMapsResponse> DescribeCenRouteMapsAsync(DescribeCenRouteMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenRouteMapsWithOptionsAsync(request, runtime);
        }

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCensResponse>(DoRPCRequest("DescribeCens", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCensResponse> DescribeCensWithOptionsAsync(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCensResponse>(await DoRPCRequestAsync("DescribeCens", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCensResponse DescribeCens(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCensWithOptions(request, runtime);
        }

        public async Task<DescribeCensResponse> DescribeCensAsync(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCensWithOptionsAsync(request, runtime);
        }

        public DescribeCenVbrHealthCheckResponse DescribeCenVbrHealthCheckWithOptions(DescribeCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenVbrHealthCheckResponse>(DoRPCRequest("DescribeCenVbrHealthCheck", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCenVbrHealthCheckResponse> DescribeCenVbrHealthCheckWithOptionsAsync(DescribeCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCenVbrHealthCheckResponse>(await DoRPCRequestAsync("DescribeCenVbrHealthCheck", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCenVbrHealthCheckResponse DescribeCenVbrHealthCheck(DescribeCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenVbrHealthCheckWithOptions(request, runtime);
        }

        public async Task<DescribeCenVbrHealthCheckResponse> DescribeCenVbrHealthCheckAsync(DescribeCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenVbrHealthCheckWithOptionsAsync(request, runtime);
        }

        public DescribeChildInstanceRegionsResponse DescribeChildInstanceRegionsWithOptions(DescribeChildInstanceRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChildInstanceRegionsResponse>(DoRPCRequest("DescribeChildInstanceRegions", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeChildInstanceRegionsResponse> DescribeChildInstanceRegionsWithOptionsAsync(DescribeChildInstanceRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChildInstanceRegionsResponse>(await DoRPCRequestAsync("DescribeChildInstanceRegions", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeChildInstanceRegionsResponse DescribeChildInstanceRegions(DescribeChildInstanceRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChildInstanceRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeChildInstanceRegionsResponse> DescribeChildInstanceRegionsAsync(DescribeChildInstanceRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChildInstanceRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeFlowlogsResponse DescribeFlowlogsWithOptions(DescribeFlowlogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowlogsResponse>(DoRPCRequest("DescribeFlowlogs", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowlogsResponse> DescribeFlowlogsWithOptionsAsync(DescribeFlowlogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowlogsResponse>(await DoRPCRequestAsync("DescribeFlowlogs", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowlogsResponse DescribeFlowlogs(DescribeFlowlogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowlogsWithOptions(request, runtime);
        }

        public async Task<DescribeFlowlogsResponse> DescribeFlowlogsAsync(DescribeFlowlogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowlogsWithOptionsAsync(request, runtime);
        }

        public DescribeGeographicRegionMembershipResponse DescribeGeographicRegionMembershipWithOptions(DescribeGeographicRegionMembershipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeographicRegionMembershipResponse>(DoRPCRequest("DescribeGeographicRegionMembership", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGeographicRegionMembershipResponse> DescribeGeographicRegionMembershipWithOptionsAsync(DescribeGeographicRegionMembershipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeographicRegionMembershipResponse>(await DoRPCRequestAsync("DescribeGeographicRegionMembership", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGeographicRegionMembershipResponse DescribeGeographicRegionMembership(DescribeGeographicRegionMembershipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeographicRegionMembershipWithOptions(request, runtime);
        }

        public async Task<DescribeGeographicRegionMembershipResponse> DescribeGeographicRegionMembershipAsync(DescribeGeographicRegionMembershipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeographicRegionMembershipWithOptionsAsync(request, runtime);
        }

        public DescribeGrantRulesToCenResponse DescribeGrantRulesToCenWithOptions(DescribeGrantRulesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantRulesToCenResponse>(DoRPCRequest("DescribeGrantRulesToCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGrantRulesToCenResponse> DescribeGrantRulesToCenWithOptionsAsync(DescribeGrantRulesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantRulesToCenResponse>(await DoRPCRequestAsync("DescribeGrantRulesToCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGrantRulesToCenResponse DescribeGrantRulesToCen(DescribeGrantRulesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantRulesToCenWithOptions(request, runtime);
        }

        public async Task<DescribeGrantRulesToCenResponse> DescribeGrantRulesToCenAsync(DescribeGrantRulesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantRulesToCenWithOptionsAsync(request, runtime);
        }

        public DescribePublishedRouteEntriesResponse DescribePublishedRouteEntriesWithOptions(DescribePublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePublishedRouteEntriesResponse>(DoRPCRequest("DescribePublishedRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePublishedRouteEntriesResponse> DescribePublishedRouteEntriesWithOptionsAsync(DescribePublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePublishedRouteEntriesResponse>(await DoRPCRequestAsync("DescribePublishedRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePublishedRouteEntriesResponse DescribePublishedRouteEntries(DescribePublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePublishedRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribePublishedRouteEntriesResponse> DescribePublishedRouteEntriesAsync(DescribePublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePublishedRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeRouteConflictResponse DescribeRouteConflictWithOptions(DescribeRouteConflictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteConflictResponse>(DoRPCRequest("DescribeRouteConflict", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteConflictResponse> DescribeRouteConflictWithOptionsAsync(DescribeRouteConflictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteConflictResponse>(await DoRPCRequestAsync("DescribeRouteConflict", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteConflictResponse DescribeRouteConflict(DescribeRouteConflictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteConflictWithOptions(request, runtime);
        }

        public async Task<DescribeRouteConflictResponse> DescribeRouteConflictAsync(DescribeRouteConflictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteConflictWithOptionsAsync(request, runtime);
        }

        public DescribeRouteServicesInCenResponse DescribeRouteServicesInCenWithOptions(DescribeRouteServicesInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteServicesInCenResponse>(DoRPCRequest("DescribeRouteServicesInCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteServicesInCenResponse> DescribeRouteServicesInCenWithOptionsAsync(DescribeRouteServicesInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteServicesInCenResponse>(await DoRPCRequestAsync("DescribeRouteServicesInCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteServicesInCenResponse DescribeRouteServicesInCen(DescribeRouteServicesInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteServicesInCenWithOptions(request, runtime);
        }

        public async Task<DescribeRouteServicesInCenResponse> DescribeRouteServicesInCenAsync(DescribeRouteServicesInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteServicesInCenWithOptionsAsync(request, runtime);
        }

        public DetachCenChildInstanceResponse DetachCenChildInstanceWithOptions(DetachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachCenChildInstanceResponse>(DoRPCRequest("DetachCenChildInstance", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachCenChildInstanceResponse> DetachCenChildInstanceWithOptionsAsync(DetachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachCenChildInstanceResponse>(await DoRPCRequestAsync("DetachCenChildInstance", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachCenChildInstanceResponse DetachCenChildInstance(DetachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachCenChildInstanceWithOptions(request, runtime);
        }

        public async Task<DetachCenChildInstanceResponse> DetachCenChildInstanceAsync(DetachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachCenChildInstanceWithOptionsAsync(request, runtime);
        }

        public DisableCenVbrHealthCheckResponse DisableCenVbrHealthCheckWithOptions(DisableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableCenVbrHealthCheckResponse>(DoRPCRequest("DisableCenVbrHealthCheck", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableCenVbrHealthCheckResponse> DisableCenVbrHealthCheckWithOptionsAsync(DisableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableCenVbrHealthCheckResponse>(await DoRPCRequestAsync("DisableCenVbrHealthCheck", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableCenVbrHealthCheckResponse DisableCenVbrHealthCheck(DisableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableCenVbrHealthCheckWithOptions(request, runtime);
        }

        public async Task<DisableCenVbrHealthCheckResponse> DisableCenVbrHealthCheckAsync(DisableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableCenVbrHealthCheckWithOptionsAsync(request, runtime);
        }

        public EnableCenVbrHealthCheckResponse EnableCenVbrHealthCheckWithOptions(EnableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableCenVbrHealthCheckResponse>(DoRPCRequest("EnableCenVbrHealthCheck", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableCenVbrHealthCheckResponse> EnableCenVbrHealthCheckWithOptionsAsync(EnableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableCenVbrHealthCheckResponse>(await DoRPCRequestAsync("EnableCenVbrHealthCheck", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableCenVbrHealthCheckResponse EnableCenVbrHealthCheck(EnableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableCenVbrHealthCheckWithOptions(request, runtime);
        }

        public async Task<EnableCenVbrHealthCheckResponse> EnableCenVbrHealthCheckAsync(EnableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableCenVbrHealthCheckWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ModifyCenAttributeResponse ModifyCenAttributeWithOptions(ModifyCenAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenAttributeResponse>(DoRPCRequest("ModifyCenAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCenAttributeResponse> ModifyCenAttributeWithOptionsAsync(ModifyCenAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenAttributeResponse>(await DoRPCRequestAsync("ModifyCenAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCenAttributeResponse ModifyCenAttribute(ModifyCenAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyCenAttributeResponse> ModifyCenAttributeAsync(ModifyCenAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyCenBandwidthPackageAttributeResponse ModifyCenBandwidthPackageAttributeWithOptions(ModifyCenBandwidthPackageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageAttributeResponse>(DoRPCRequest("ModifyCenBandwidthPackageAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCenBandwidthPackageAttributeResponse> ModifyCenBandwidthPackageAttributeWithOptionsAsync(ModifyCenBandwidthPackageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageAttributeResponse>(await DoRPCRequestAsync("ModifyCenBandwidthPackageAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCenBandwidthPackageAttributeResponse ModifyCenBandwidthPackageAttribute(ModifyCenBandwidthPackageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenBandwidthPackageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyCenBandwidthPackageAttributeResponse> ModifyCenBandwidthPackageAttributeAsync(ModifyCenBandwidthPackageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenBandwidthPackageAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyCenBandwidthPackageSpecResponse ModifyCenBandwidthPackageSpecWithOptions(ModifyCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageSpecResponse>(DoRPCRequest("ModifyCenBandwidthPackageSpec", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCenBandwidthPackageSpecResponse> ModifyCenBandwidthPackageSpecWithOptionsAsync(ModifyCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageSpecResponse>(await DoRPCRequestAsync("ModifyCenBandwidthPackageSpec", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCenBandwidthPackageSpecResponse ModifyCenBandwidthPackageSpec(ModifyCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenBandwidthPackageSpecWithOptions(request, runtime);
        }

        public async Task<ModifyCenBandwidthPackageSpecResponse> ModifyCenBandwidthPackageSpecAsync(ModifyCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenBandwidthPackageSpecWithOptionsAsync(request, runtime);
        }

        public ModifyCenRouteMapResponse ModifyCenRouteMapWithOptions(ModifyCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenRouteMapResponse>(DoRPCRequest("ModifyCenRouteMap", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCenRouteMapResponse> ModifyCenRouteMapWithOptionsAsync(ModifyCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCenRouteMapResponse>(await DoRPCRequestAsync("ModifyCenRouteMap", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCenRouteMapResponse ModifyCenRouteMap(ModifyCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenRouteMapWithOptions(request, runtime);
        }

        public async Task<ModifyCenRouteMapResponse> ModifyCenRouteMapAsync(ModifyCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenRouteMapWithOptionsAsync(request, runtime);
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeWithOptions(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(DoRPCRequest("ModifyFlowLogAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeWithOptionsAsync(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(await DoRPCRequestAsync("ModifyFlowLogAttribute", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowLogAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeAsync(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowLogAttributeWithOptionsAsync(request, runtime);
        }

        public PublishRouteEntriesResponse PublishRouteEntriesWithOptions(PublishRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishRouteEntriesResponse>(DoRPCRequest("PublishRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishRouteEntriesResponse> PublishRouteEntriesWithOptionsAsync(PublishRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishRouteEntriesResponse>(await DoRPCRequestAsync("PublishRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishRouteEntriesResponse PublishRouteEntries(PublishRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishRouteEntriesWithOptions(request, runtime);
        }

        public async Task<PublishRouteEntriesResponse> PublishRouteEntriesAsync(PublishRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishRouteEntriesWithOptionsAsync(request, runtime);
        }

        public ResolveAndRouteServiceInCenResponse ResolveAndRouteServiceInCenWithOptions(ResolveAndRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResolveAndRouteServiceInCenResponse>(DoRPCRequest("ResolveAndRouteServiceInCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResolveAndRouteServiceInCenResponse> ResolveAndRouteServiceInCenWithOptionsAsync(ResolveAndRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResolveAndRouteServiceInCenResponse>(await DoRPCRequestAsync("ResolveAndRouteServiceInCen", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResolveAndRouteServiceInCenResponse ResolveAndRouteServiceInCen(ResolveAndRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResolveAndRouteServiceInCenWithOptions(request, runtime);
        }

        public async Task<ResolveAndRouteServiceInCenResponse> ResolveAndRouteServiceInCenAsync(ResolveAndRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResolveAndRouteServiceInCenWithOptionsAsync(request, runtime);
        }

        public RoutePrivateZoneInCenToVpcResponse RoutePrivateZoneInCenToVpcWithOptions(RoutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RoutePrivateZoneInCenToVpcResponse>(DoRPCRequest("RoutePrivateZoneInCenToVpc", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RoutePrivateZoneInCenToVpcResponse> RoutePrivateZoneInCenToVpcWithOptionsAsync(RoutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RoutePrivateZoneInCenToVpcResponse>(await DoRPCRequestAsync("RoutePrivateZoneInCenToVpc", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RoutePrivateZoneInCenToVpcResponse RoutePrivateZoneInCenToVpc(RoutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RoutePrivateZoneInCenToVpcWithOptions(request, runtime);
        }

        public async Task<RoutePrivateZoneInCenToVpcResponse> RoutePrivateZoneInCenToVpcAsync(RoutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RoutePrivateZoneInCenToVpcWithOptionsAsync(request, runtime);
        }

        public SetCenInterRegionBandwidthLimitResponse SetCenInterRegionBandwidthLimitWithOptions(SetCenInterRegionBandwidthLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCenInterRegionBandwidthLimitResponse>(DoRPCRequest("SetCenInterRegionBandwidthLimit", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCenInterRegionBandwidthLimitResponse> SetCenInterRegionBandwidthLimitWithOptionsAsync(SetCenInterRegionBandwidthLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCenInterRegionBandwidthLimitResponse>(await DoRPCRequestAsync("SetCenInterRegionBandwidthLimit", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCenInterRegionBandwidthLimitResponse SetCenInterRegionBandwidthLimit(SetCenInterRegionBandwidthLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCenInterRegionBandwidthLimitWithOptions(request, runtime);
        }

        public async Task<SetCenInterRegionBandwidthLimitResponse> SetCenInterRegionBandwidthLimitAsync(SetCenInterRegionBandwidthLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCenInterRegionBandwidthLimitWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TempUpgradeCenBandwidthPackageSpecResponse TempUpgradeCenBandwidthPackageSpecWithOptions(TempUpgradeCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TempUpgradeCenBandwidthPackageSpecResponse>(DoRPCRequest("TempUpgradeCenBandwidthPackageSpec", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TempUpgradeCenBandwidthPackageSpecResponse> TempUpgradeCenBandwidthPackageSpecWithOptionsAsync(TempUpgradeCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TempUpgradeCenBandwidthPackageSpecResponse>(await DoRPCRequestAsync("TempUpgradeCenBandwidthPackageSpec", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TempUpgradeCenBandwidthPackageSpecResponse TempUpgradeCenBandwidthPackageSpec(TempUpgradeCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TempUpgradeCenBandwidthPackageSpecWithOptions(request, runtime);
        }

        public async Task<TempUpgradeCenBandwidthPackageSpecResponse> TempUpgradeCenBandwidthPackageSpecAsync(TempUpgradeCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TempUpgradeCenBandwidthPackageSpecWithOptionsAsync(request, runtime);
        }

        public UnassociateCenBandwidthPackageResponse UnassociateCenBandwidthPackageWithOptions(UnassociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateCenBandwidthPackageResponse>(DoRPCRequest("UnassociateCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateCenBandwidthPackageResponse> UnassociateCenBandwidthPackageWithOptionsAsync(UnassociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateCenBandwidthPackageResponse>(await DoRPCRequestAsync("UnassociateCenBandwidthPackage", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateCenBandwidthPackageResponse UnassociateCenBandwidthPackage(UnassociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<UnassociateCenBandwidthPackageResponse> UnassociateCenBandwidthPackageAsync(UnassociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public UnroutePrivateZoneInCenToVpcResponse UnroutePrivateZoneInCenToVpcWithOptions(UnroutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnroutePrivateZoneInCenToVpcResponse>(DoRPCRequest("UnroutePrivateZoneInCenToVpc", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnroutePrivateZoneInCenToVpcResponse> UnroutePrivateZoneInCenToVpcWithOptionsAsync(UnroutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnroutePrivateZoneInCenToVpcResponse>(await DoRPCRequestAsync("UnroutePrivateZoneInCenToVpc", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnroutePrivateZoneInCenToVpcResponse UnroutePrivateZoneInCenToVpc(UnroutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnroutePrivateZoneInCenToVpcWithOptions(request, runtime);
        }

        public async Task<UnroutePrivateZoneInCenToVpcResponse> UnroutePrivateZoneInCenToVpcAsync(UnroutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnroutePrivateZoneInCenToVpcWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public WithdrawPublishedRouteEntriesResponse WithdrawPublishedRouteEntriesWithOptions(WithdrawPublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WithdrawPublishedRouteEntriesResponse>(DoRPCRequest("WithdrawPublishedRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<WithdrawPublishedRouteEntriesResponse> WithdrawPublishedRouteEntriesWithOptionsAsync(WithdrawPublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WithdrawPublishedRouteEntriesResponse>(await DoRPCRequestAsync("WithdrawPublishedRouteEntries", "2017-09-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public WithdrawPublishedRouteEntriesResponse WithdrawPublishedRouteEntries(WithdrawPublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawPublishedRouteEntriesWithOptions(request, runtime);
        }

        public async Task<WithdrawPublishedRouteEntriesResponse> WithdrawPublishedRouteEntriesAsync(WithdrawPublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawPublishedRouteEntriesWithOptionsAsync(request, runtime);
        }

    }
}
