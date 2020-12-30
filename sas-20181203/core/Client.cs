// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sas20181203.Models;

namespace AlibabaCloud.SDK.Sas20181203
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "tds.aliyuncs.com"},
                {"ap-southeast-3", "tds.ap-southeast-3.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "tds.cn-shanghai-et2-b01.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddVpcHoneyPotResponse AddVpcHoneyPotWithOptions(AddVpcHoneyPotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVpcHoneyPotResponse>(DoRPCRequest("AddVpcHoneyPot", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVpcHoneyPotResponse> AddVpcHoneyPotWithOptionsAsync(AddVpcHoneyPotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVpcHoneyPotResponse>(await DoRPCRequestAsync("AddVpcHoneyPot", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVpcHoneyPotResponse AddVpcHoneyPot(AddVpcHoneyPotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVpcHoneyPotWithOptions(request, runtime);
        }

        public async Task<AddVpcHoneyPotResponse> AddVpcHoneyPotAsync(AddVpcHoneyPotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVpcHoneyPotWithOptionsAsync(request, runtime);
        }

        public CreateAntiBruteForceRuleResponse CreateAntiBruteForceRuleWithOptions(CreateAntiBruteForceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntiBruteForceRuleResponse>(DoRPCRequest("CreateAntiBruteForceRule", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAntiBruteForceRuleResponse> CreateAntiBruteForceRuleWithOptionsAsync(CreateAntiBruteForceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntiBruteForceRuleResponse>(await DoRPCRequestAsync("CreateAntiBruteForceRule", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAntiBruteForceRuleResponse CreateAntiBruteForceRule(CreateAntiBruteForceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntiBruteForceRuleWithOptions(request, runtime);
        }

        public async Task<CreateAntiBruteForceRuleResponse> CreateAntiBruteForceRuleAsync(CreateAntiBruteForceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntiBruteForceRuleWithOptionsAsync(request, runtime);
        }

        public CreateOrUpdateAssetGroupResponse CreateOrUpdateAssetGroupWithOptions(CreateOrUpdateAssetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrUpdateAssetGroupResponse>(DoRPCRequest("CreateOrUpdateAssetGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOrUpdateAssetGroupResponse> CreateOrUpdateAssetGroupWithOptionsAsync(CreateOrUpdateAssetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrUpdateAssetGroupResponse>(await DoRPCRequestAsync("CreateOrUpdateAssetGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOrUpdateAssetGroupResponse CreateOrUpdateAssetGroup(CreateOrUpdateAssetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrUpdateAssetGroupWithOptions(request, runtime);
        }

        public async Task<CreateOrUpdateAssetGroupResponse> CreateOrUpdateAssetGroupAsync(CreateOrUpdateAssetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrUpdateAssetGroupWithOptionsAsync(request, runtime);
        }

        public CreateSasOrderResponse CreateSasOrderWithOptions(CreateSasOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSasOrderResponse>(DoRPCRequest("CreateSasOrder", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSasOrderResponse> CreateSasOrderWithOptionsAsync(CreateSasOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSasOrderResponse>(await DoRPCRequestAsync("CreateSasOrder", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSasOrderResponse CreateSasOrder(CreateSasOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSasOrderWithOptions(request, runtime);
        }

        public async Task<CreateSasOrderResponse> CreateSasOrderAsync(CreateSasOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSasOrderWithOptionsAsync(request, runtime);
        }

        public CreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTaskWithOptions(CreateSimilarSecurityEventsQueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSimilarSecurityEventsQueryTaskResponse>(DoRPCRequest("CreateSimilarSecurityEventsQueryTask", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSimilarSecurityEventsQueryTaskResponse> CreateSimilarSecurityEventsQueryTaskWithOptionsAsync(CreateSimilarSecurityEventsQueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSimilarSecurityEventsQueryTaskResponse>(await DoRPCRequestAsync("CreateSimilarSecurityEventsQueryTask", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTask(CreateSimilarSecurityEventsQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSimilarSecurityEventsQueryTaskWithOptions(request, runtime);
        }

        public async Task<CreateSimilarSecurityEventsQueryTaskResponse> CreateSimilarSecurityEventsQueryTaskAsync(CreateSimilarSecurityEventsQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSimilarSecurityEventsQueryTaskWithOptionsAsync(request, runtime);
        }

        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupResponse>(DoRPCRequest("DeleteGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await DoRPCRequestAsync("DeleteGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteLoginBaseConfigResponse DeleteLoginBaseConfigWithOptions(DeleteLoginBaseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLoginBaseConfigResponse>(DoRPCRequest("DeleteLoginBaseConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLoginBaseConfigResponse> DeleteLoginBaseConfigWithOptionsAsync(DeleteLoginBaseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLoginBaseConfigResponse>(await DoRPCRequestAsync("DeleteLoginBaseConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLoginBaseConfigResponse DeleteLoginBaseConfig(DeleteLoginBaseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoginBaseConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLoginBaseConfigResponse> DeleteLoginBaseConfigAsync(DeleteLoginBaseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoginBaseConfigWithOptionsAsync(request, runtime);
        }

        public DeleteTagWithUuidResponse DeleteTagWithUuidWithOptions(DeleteTagWithUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagWithUuidResponse>(DoRPCRequest("DeleteTagWithUuid", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTagWithUuidResponse> DeleteTagWithUuidWithOptionsAsync(DeleteTagWithUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagWithUuidResponse>(await DoRPCRequestAsync("DeleteTagWithUuid", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTagWithUuidResponse DeleteTagWithUuid(DeleteTagWithUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithUuidWithOptions(request, runtime);
        }

        public async Task<DeleteTagWithUuidResponse> DeleteTagWithUuidAsync(DeleteTagWithUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithUuidWithOptionsAsync(request, runtime);
        }

        public DeleteVpcHoneyPotResponse DeleteVpcHoneyPotWithOptions(DeleteVpcHoneyPotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcHoneyPotResponse>(DoRPCRequest("DeleteVpcHoneyPot", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpcHoneyPotResponse> DeleteVpcHoneyPotWithOptionsAsync(DeleteVpcHoneyPotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcHoneyPotResponse>(await DoRPCRequestAsync("DeleteVpcHoneyPot", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpcHoneyPotResponse DeleteVpcHoneyPot(DeleteVpcHoneyPotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcHoneyPotWithOptions(request, runtime);
        }

        public async Task<DeleteVpcHoneyPotResponse> DeleteVpcHoneyPotAsync(DeleteVpcHoneyPotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcHoneyPotWithOptionsAsync(request, runtime);
        }

        public DescribeAccesskeyLeakListResponse DescribeAccesskeyLeakListWithOptions(DescribeAccesskeyLeakListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccesskeyLeakListResponse>(DoRPCRequest("DescribeAccesskeyLeakList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccesskeyLeakListResponse> DescribeAccesskeyLeakListWithOptionsAsync(DescribeAccesskeyLeakListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccesskeyLeakListResponse>(await DoRPCRequestAsync("DescribeAccesskeyLeakList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccesskeyLeakListResponse DescribeAccesskeyLeakList(DescribeAccesskeyLeakListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccesskeyLeakListWithOptions(request, runtime);
        }

        public async Task<DescribeAccesskeyLeakListResponse> DescribeAccesskeyLeakListAsync(DescribeAccesskeyLeakListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccesskeyLeakListWithOptionsAsync(request, runtime);
        }

        public DescribeAffectedMaliciousFileImagesResponse DescribeAffectedMaliciousFileImagesWithOptions(DescribeAffectedMaliciousFileImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAffectedMaliciousFileImagesResponse>(DoRPCRequest("DescribeAffectedMaliciousFileImages", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAffectedMaliciousFileImagesResponse> DescribeAffectedMaliciousFileImagesWithOptionsAsync(DescribeAffectedMaliciousFileImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAffectedMaliciousFileImagesResponse>(await DoRPCRequestAsync("DescribeAffectedMaliciousFileImages", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAffectedMaliciousFileImagesResponse DescribeAffectedMaliciousFileImages(DescribeAffectedMaliciousFileImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAffectedMaliciousFileImagesWithOptions(request, runtime);
        }

        public async Task<DescribeAffectedMaliciousFileImagesResponse> DescribeAffectedMaliciousFileImagesAsync(DescribeAffectedMaliciousFileImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAffectedMaliciousFileImagesWithOptionsAsync(request, runtime);
        }

        public DescribeAlarmEventDetailResponse DescribeAlarmEventDetailWithOptions(DescribeAlarmEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmEventDetailResponse>(DoRPCRequest("DescribeAlarmEventDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlarmEventDetailResponse> DescribeAlarmEventDetailWithOptionsAsync(DescribeAlarmEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmEventDetailResponse>(await DoRPCRequestAsync("DescribeAlarmEventDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlarmEventDetailResponse DescribeAlarmEventDetail(DescribeAlarmEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlarmEventDetailWithOptions(request, runtime);
        }

        public async Task<DescribeAlarmEventDetailResponse> DescribeAlarmEventDetailAsync(DescribeAlarmEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlarmEventDetailWithOptionsAsync(request, runtime);
        }

        public DescribeAlarmEventListResponse DescribeAlarmEventListWithOptions(DescribeAlarmEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmEventListResponse>(DoRPCRequest("DescribeAlarmEventList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlarmEventListResponse> DescribeAlarmEventListWithOptionsAsync(DescribeAlarmEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlarmEventListResponse>(await DoRPCRequestAsync("DescribeAlarmEventList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlarmEventListResponse DescribeAlarmEventList(DescribeAlarmEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlarmEventListWithOptions(request, runtime);
        }

        public async Task<DescribeAlarmEventListResponse> DescribeAlarmEventListAsync(DescribeAlarmEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlarmEventListWithOptionsAsync(request, runtime);
        }

        public DescribeAllEntityResponse DescribeAllEntityWithOptions(DescribeAllEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllEntityResponse>(DoRPCRequest("DescribeAllEntity", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAllEntityResponse> DescribeAllEntityWithOptionsAsync(DescribeAllEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllEntityResponse>(await DoRPCRequestAsync("DescribeAllEntity", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAllEntityResponse DescribeAllEntity(DescribeAllEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllEntityWithOptions(request, runtime);
        }

        public async Task<DescribeAllEntityResponse> DescribeAllEntityAsync(DescribeAllEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllEntityWithOptionsAsync(request, runtime);
        }

        public DescribeAllGroupsResponse DescribeAllGroupsWithOptions(DescribeAllGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllGroupsResponse>(DoRPCRequest("DescribeAllGroups", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAllGroupsResponse> DescribeAllGroupsWithOptionsAsync(DescribeAllGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllGroupsResponse>(await DoRPCRequestAsync("DescribeAllGroups", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAllGroupsResponse DescribeAllGroups(DescribeAllGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeAllGroupsResponse> DescribeAllGroupsAsync(DescribeAllGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeAllRegionsStatisticsResponse DescribeAllRegionsStatisticsWithOptions(DescribeAllRegionsStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllRegionsStatisticsResponse>(DoRPCRequest("DescribeAllRegionsStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAllRegionsStatisticsResponse> DescribeAllRegionsStatisticsWithOptionsAsync(DescribeAllRegionsStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllRegionsStatisticsResponse>(await DoRPCRequestAsync("DescribeAllRegionsStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAllRegionsStatisticsResponse DescribeAllRegionsStatistics(DescribeAllRegionsStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllRegionsStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeAllRegionsStatisticsResponse> DescribeAllRegionsStatisticsAsync(DescribeAllRegionsStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllRegionsStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeAntiBruteForceRulesResponse DescribeAntiBruteForceRulesWithOptions(DescribeAntiBruteForceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntiBruteForceRulesResponse>(DoRPCRequest("DescribeAntiBruteForceRules", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntiBruteForceRulesResponse> DescribeAntiBruteForceRulesWithOptionsAsync(DescribeAntiBruteForceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntiBruteForceRulesResponse>(await DoRPCRequestAsync("DescribeAntiBruteForceRules", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntiBruteForceRulesResponse DescribeAntiBruteForceRules(DescribeAntiBruteForceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntiBruteForceRulesWithOptions(request, runtime);
        }

        public async Task<DescribeAntiBruteForceRulesResponse> DescribeAntiBruteForceRulesAsync(DescribeAntiBruteForceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntiBruteForceRulesWithOptionsAsync(request, runtime);
        }

        public DescribeAssetDetailByUuidResponse DescribeAssetDetailByUuidWithOptions(DescribeAssetDetailByUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAssetDetailByUuidResponse>(DoRPCRequest("DescribeAssetDetailByUuid", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAssetDetailByUuidResponse> DescribeAssetDetailByUuidWithOptionsAsync(DescribeAssetDetailByUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAssetDetailByUuidResponse>(await DoRPCRequestAsync("DescribeAssetDetailByUuid", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAssetDetailByUuidResponse DescribeAssetDetailByUuid(DescribeAssetDetailByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetDetailByUuidWithOptions(request, runtime);
        }

        public async Task<DescribeAssetDetailByUuidResponse> DescribeAssetDetailByUuidAsync(DescribeAssetDetailByUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetDetailByUuidWithOptionsAsync(request, runtime);
        }

        public DescribeAssetDetailByUuidsResponse DescribeAssetDetailByUuidsWithOptions(DescribeAssetDetailByUuidsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAssetDetailByUuidsResponse>(DoRPCRequest("DescribeAssetDetailByUuids", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAssetDetailByUuidsResponse> DescribeAssetDetailByUuidsWithOptionsAsync(DescribeAssetDetailByUuidsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAssetDetailByUuidsResponse>(await DoRPCRequestAsync("DescribeAssetDetailByUuids", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAssetDetailByUuidsResponse DescribeAssetDetailByUuids(DescribeAssetDetailByUuidsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetDetailByUuidsWithOptions(request, runtime);
        }

        public async Task<DescribeAssetDetailByUuidsResponse> DescribeAssetDetailByUuidsAsync(DescribeAssetDetailByUuidsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetDetailByUuidsWithOptionsAsync(request, runtime);
        }

        public DescribeAutoDelConfigResponse DescribeAutoDelConfigWithOptions(DescribeAutoDelConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoDelConfigResponse>(DoRPCRequest("DescribeAutoDelConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoDelConfigResponse> DescribeAutoDelConfigWithOptionsAsync(DescribeAutoDelConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoDelConfigResponse>(await DoRPCRequestAsync("DescribeAutoDelConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoDelConfigResponse DescribeAutoDelConfig(DescribeAutoDelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoDelConfigWithOptions(request, runtime);
        }

        public async Task<DescribeAutoDelConfigResponse> DescribeAutoDelConfigAsync(DescribeAutoDelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoDelConfigWithOptionsAsync(request, runtime);
        }

        public DescribeBruteForceSummaryResponse DescribeBruteForceSummaryWithOptions(DescribeBruteForceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBruteForceSummaryResponse>(DoRPCRequest("DescribeBruteForceSummary", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBruteForceSummaryResponse> DescribeBruteForceSummaryWithOptionsAsync(DescribeBruteForceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBruteForceSummaryResponse>(await DoRPCRequestAsync("DescribeBruteForceSummary", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBruteForceSummaryResponse DescribeBruteForceSummary(DescribeBruteForceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBruteForceSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeBruteForceSummaryResponse> DescribeBruteForceSummaryAsync(DescribeBruteForceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBruteForceSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeCheckEcsWarningsResponse DescribeCheckEcsWarningsWithOptions(DescribeCheckEcsWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckEcsWarningsResponse>(DoRPCRequest("DescribeCheckEcsWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCheckEcsWarningsResponse> DescribeCheckEcsWarningsWithOptionsAsync(DescribeCheckEcsWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckEcsWarningsResponse>(await DoRPCRequestAsync("DescribeCheckEcsWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCheckEcsWarningsResponse DescribeCheckEcsWarnings(DescribeCheckEcsWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCheckEcsWarningsWithOptions(request, runtime);
        }

        public async Task<DescribeCheckEcsWarningsResponse> DescribeCheckEcsWarningsAsync(DescribeCheckEcsWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCheckEcsWarningsWithOptionsAsync(request, runtime);
        }

        public DescribeCheckWarningDetailResponse DescribeCheckWarningDetailWithOptions(DescribeCheckWarningDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckWarningDetailResponse>(DoRPCRequest("DescribeCheckWarningDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCheckWarningDetailResponse> DescribeCheckWarningDetailWithOptionsAsync(DescribeCheckWarningDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckWarningDetailResponse>(await DoRPCRequestAsync("DescribeCheckWarningDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCheckWarningDetailResponse DescribeCheckWarningDetail(DescribeCheckWarningDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCheckWarningDetailWithOptions(request, runtime);
        }

        public async Task<DescribeCheckWarningDetailResponse> DescribeCheckWarningDetailAsync(DescribeCheckWarningDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCheckWarningDetailWithOptionsAsync(request, runtime);
        }

        public DescribeCheckWarningsResponse DescribeCheckWarningsWithOptions(DescribeCheckWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckWarningsResponse>(DoRPCRequest("DescribeCheckWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCheckWarningsResponse> DescribeCheckWarningsWithOptionsAsync(DescribeCheckWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckWarningsResponse>(await DoRPCRequestAsync("DescribeCheckWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCheckWarningsResponse DescribeCheckWarnings(DescribeCheckWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCheckWarningsWithOptions(request, runtime);
        }

        public async Task<DescribeCheckWarningsResponse> DescribeCheckWarningsAsync(DescribeCheckWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCheckWarningsWithOptionsAsync(request, runtime);
        }

        public DescribeCheckWarningSummaryResponse DescribeCheckWarningSummaryWithOptions(DescribeCheckWarningSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckWarningSummaryResponse>(DoRPCRequest("DescribeCheckWarningSummary", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCheckWarningSummaryResponse> DescribeCheckWarningSummaryWithOptionsAsync(DescribeCheckWarningSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckWarningSummaryResponse>(await DoRPCRequestAsync("DescribeCheckWarningSummary", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCheckWarningSummaryResponse DescribeCheckWarningSummary(DescribeCheckWarningSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCheckWarningSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeCheckWarningSummaryResponse> DescribeCheckWarningSummaryAsync(DescribeCheckWarningSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCheckWarningSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeCloudCenterInstancesResponse DescribeCloudCenterInstancesWithOptions(DescribeCloudCenterInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudCenterInstancesResponse>(DoRPCRequest("DescribeCloudCenterInstances", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCloudCenterInstancesResponse> DescribeCloudCenterInstancesWithOptionsAsync(DescribeCloudCenterInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudCenterInstancesResponse>(await DoRPCRequestAsync("DescribeCloudCenterInstances", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCloudCenterInstancesResponse DescribeCloudCenterInstances(DescribeCloudCenterInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudCenterInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeCloudCenterInstancesResponse> DescribeCloudCenterInstancesAsync(DescribeCloudCenterInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudCenterInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeCloudProductFieldStatisticsResponse DescribeCloudProductFieldStatisticsWithOptions(DescribeCloudProductFieldStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudProductFieldStatisticsResponse>(DoRPCRequest("DescribeCloudProductFieldStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCloudProductFieldStatisticsResponse> DescribeCloudProductFieldStatisticsWithOptionsAsync(DescribeCloudProductFieldStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudProductFieldStatisticsResponse>(await DoRPCRequestAsync("DescribeCloudProductFieldStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCloudProductFieldStatisticsResponse DescribeCloudProductFieldStatistics(DescribeCloudProductFieldStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudProductFieldStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeCloudProductFieldStatisticsResponse> DescribeCloudProductFieldStatisticsAsync(DescribeCloudProductFieldStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudProductFieldStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeConcernNecessityResponse DescribeConcernNecessityWithOptions(DescribeConcernNecessityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConcernNecessityResponse>(DoRPCRequest("DescribeConcernNecessity", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConcernNecessityResponse> DescribeConcernNecessityWithOptionsAsync(DescribeConcernNecessityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConcernNecessityResponse>(await DoRPCRequestAsync("DescribeConcernNecessity", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConcernNecessityResponse DescribeConcernNecessity(DescribeConcernNecessityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConcernNecessityWithOptions(request, runtime);
        }

        public async Task<DescribeConcernNecessityResponse> DescribeConcernNecessityAsync(DescribeConcernNecessityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConcernNecessityWithOptionsAsync(request, runtime);
        }

        public DescribeContainerStatisticsResponse DescribeContainerStatisticsWithOptions(DescribeContainerStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerStatisticsResponse>(DoRPCRequest("DescribeContainerStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerStatisticsResponse> DescribeContainerStatisticsWithOptionsAsync(DescribeContainerStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerStatisticsResponse>(await DoRPCRequestAsync("DescribeContainerStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerStatisticsResponse DescribeContainerStatistics(DescribeContainerStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeContainerStatisticsResponse> DescribeContainerStatisticsAsync(DescribeContainerStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeCriteriaResponse DescribeCriteriaWithOptions(DescribeCriteriaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCriteriaResponse>(DoRPCRequest("DescribeCriteria", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCriteriaResponse> DescribeCriteriaWithOptionsAsync(DescribeCriteriaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCriteriaResponse>(await DoRPCRequestAsync("DescribeCriteria", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCriteriaResponse DescribeCriteria(DescribeCriteriaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCriteriaWithOptions(request, runtime);
        }

        public async Task<DescribeCriteriaResponse> DescribeCriteriaAsync(DescribeCriteriaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCriteriaWithOptionsAsync(request, runtime);
        }

        public DescribeDialogMessagesResponse DescribeDialogMessagesWithOptions(DescribeDialogMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDialogMessagesResponse>(DoRPCRequest("DescribeDialogMessages", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDialogMessagesResponse> DescribeDialogMessagesWithOptionsAsync(DescribeDialogMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDialogMessagesResponse>(await DoRPCRequestAsync("DescribeDialogMessages", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDialogMessagesResponse DescribeDialogMessages(DescribeDialogMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDialogMessagesWithOptions(request, runtime);
        }

        public async Task<DescribeDialogMessagesResponse> DescribeDialogMessagesAsync(DescribeDialogMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDialogMessagesWithOptionsAsync(request, runtime);
        }

        public DescribeDingTalkResponse DescribeDingTalkWithOptions(DescribeDingTalkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDingTalkResponse>(DoRPCRequest("DescribeDingTalk", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDingTalkResponse> DescribeDingTalkWithOptionsAsync(DescribeDingTalkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDingTalkResponse>(await DoRPCRequestAsync("DescribeDingTalk", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDingTalkResponse DescribeDingTalk(DescribeDingTalkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDingTalkWithOptions(request, runtime);
        }

        public async Task<DescribeDingTalkResponse> DescribeDingTalkAsync(DescribeDingTalkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDingTalkWithOptionsAsync(request, runtime);
        }

        public DescribeDomainCountResponse DescribeDomainCountWithOptions(DescribeDomainCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainCountResponse>(DoRPCRequest("DescribeDomainCount", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainCountResponse> DescribeDomainCountWithOptionsAsync(DescribeDomainCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainCountResponse>(await DoRPCRequestAsync("DescribeDomainCount", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainCountResponse DescribeDomainCount(DescribeDomainCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainCountWithOptions(request, runtime);
        }

        public async Task<DescribeDomainCountResponse> DescribeDomainCountAsync(DescribeDomainCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainCountWithOptionsAsync(request, runtime);
        }

        public DescribeDomainDetailResponse DescribeDomainDetailWithOptions(DescribeDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainDetailResponse>(DoRPCRequest("DescribeDomainDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainDetailResponse> DescribeDomainDetailWithOptionsAsync(DescribeDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainDetailResponse>(await DoRPCRequestAsync("DescribeDomainDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainDetailResponse DescribeDomainDetail(DescribeDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDomainDetailResponse> DescribeDomainDetailAsync(DescribeDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDomainListResponse DescribeDomainListWithOptions(DescribeDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainListResponse>(DoRPCRequest("DescribeDomainList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainListResponse> DescribeDomainListWithOptionsAsync(DescribeDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainListResponse>(await DoRPCRequestAsync("DescribeDomainList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainListResponse DescribeDomainList(DescribeDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainListWithOptions(request, runtime);
        }

        public async Task<DescribeDomainListResponse> DescribeDomainListAsync(DescribeDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainListWithOptionsAsync(request, runtime);
        }

        public DescribeEmgVulGroupResponse DescribeEmgVulGroupWithOptions(DescribeEmgVulGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEmgVulGroupResponse>(DoRPCRequest("DescribeEmgVulGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEmgVulGroupResponse> DescribeEmgVulGroupWithOptionsAsync(DescribeEmgVulGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEmgVulGroupResponse>(await DoRPCRequestAsync("DescribeEmgVulGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEmgVulGroupResponse DescribeEmgVulGroup(DescribeEmgVulGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmgVulGroupWithOptions(request, runtime);
        }

        public async Task<DescribeEmgVulGroupResponse> DescribeEmgVulGroupAsync(DescribeEmgVulGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmgVulGroupWithOptionsAsync(request, runtime);
        }

        public DescribeExportInfoResponse DescribeExportInfoWithOptions(DescribeExportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExportInfoResponse>(DoRPCRequest("DescribeExportInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExportInfoResponse> DescribeExportInfoWithOptionsAsync(DescribeExportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExportInfoResponse>(await DoRPCRequestAsync("DescribeExportInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExportInfoResponse DescribeExportInfo(DescribeExportInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportInfoWithOptions(request, runtime);
        }

        public async Task<DescribeExportInfoResponse> DescribeExportInfoAsync(DescribeExportInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportInfoWithOptionsAsync(request, runtime);
        }

        public DescribeExposedInstanceCriteriaResponse DescribeExposedInstanceCriteriaWithOptions(DescribeExposedInstanceCriteriaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedInstanceCriteriaResponse>(DoRPCRequest("DescribeExposedInstanceCriteria", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExposedInstanceCriteriaResponse> DescribeExposedInstanceCriteriaWithOptionsAsync(DescribeExposedInstanceCriteriaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedInstanceCriteriaResponse>(await DoRPCRequestAsync("DescribeExposedInstanceCriteria", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExposedInstanceCriteriaResponse DescribeExposedInstanceCriteria(DescribeExposedInstanceCriteriaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExposedInstanceCriteriaWithOptions(request, runtime);
        }

        public async Task<DescribeExposedInstanceCriteriaResponse> DescribeExposedInstanceCriteriaAsync(DescribeExposedInstanceCriteriaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExposedInstanceCriteriaWithOptionsAsync(request, runtime);
        }

        public DescribeExposedInstanceDetailResponse DescribeExposedInstanceDetailWithOptions(DescribeExposedInstanceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedInstanceDetailResponse>(DoRPCRequest("DescribeExposedInstanceDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExposedInstanceDetailResponse> DescribeExposedInstanceDetailWithOptionsAsync(DescribeExposedInstanceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedInstanceDetailResponse>(await DoRPCRequestAsync("DescribeExposedInstanceDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExposedInstanceDetailResponse DescribeExposedInstanceDetail(DescribeExposedInstanceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExposedInstanceDetailWithOptions(request, runtime);
        }

        public async Task<DescribeExposedInstanceDetailResponse> DescribeExposedInstanceDetailAsync(DescribeExposedInstanceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExposedInstanceDetailWithOptionsAsync(request, runtime);
        }

        public DescribeExposedInstanceListResponse DescribeExposedInstanceListWithOptions(DescribeExposedInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedInstanceListResponse>(DoRPCRequest("DescribeExposedInstanceList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExposedInstanceListResponse> DescribeExposedInstanceListWithOptionsAsync(DescribeExposedInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedInstanceListResponse>(await DoRPCRequestAsync("DescribeExposedInstanceList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExposedInstanceListResponse DescribeExposedInstanceList(DescribeExposedInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExposedInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeExposedInstanceListResponse> DescribeExposedInstanceListAsync(DescribeExposedInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExposedInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeExposedStatisticsResponse DescribeExposedStatisticsWithOptions(DescribeExposedStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedStatisticsResponse>(DoRPCRequest("DescribeExposedStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExposedStatisticsResponse> DescribeExposedStatisticsWithOptionsAsync(DescribeExposedStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExposedStatisticsResponse>(await DoRPCRequestAsync("DescribeExposedStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExposedStatisticsResponse DescribeExposedStatistics(DescribeExposedStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExposedStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeExposedStatisticsResponse> DescribeExposedStatisticsAsync(DescribeExposedStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExposedStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeFieldStatisticsResponse DescribeFieldStatisticsWithOptions(DescribeFieldStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFieldStatisticsResponse>(DoRPCRequest("DescribeFieldStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFieldStatisticsResponse> DescribeFieldStatisticsWithOptionsAsync(DescribeFieldStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFieldStatisticsResponse>(await DoRPCRequestAsync("DescribeFieldStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFieldStatisticsResponse DescribeFieldStatistics(DescribeFieldStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFieldStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeFieldStatisticsResponse> DescribeFieldStatisticsAsync(DescribeFieldStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFieldStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeGraph4InvestigationOnlineResponse DescribeGraph4InvestigationOnlineWithOptions(DescribeGraph4InvestigationOnlineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGraph4InvestigationOnlineResponse>(DoRPCRequest("DescribeGraph4InvestigationOnline", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGraph4InvestigationOnlineResponse> DescribeGraph4InvestigationOnlineWithOptionsAsync(DescribeGraph4InvestigationOnlineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGraph4InvestigationOnlineResponse>(await DoRPCRequestAsync("DescribeGraph4InvestigationOnline", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGraph4InvestigationOnlineResponse DescribeGraph4InvestigationOnline(DescribeGraph4InvestigationOnlineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGraph4InvestigationOnlineWithOptions(request, runtime);
        }

        public async Task<DescribeGraph4InvestigationOnlineResponse> DescribeGraph4InvestigationOnlineAsync(DescribeGraph4InvestigationOnlineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGraph4InvestigationOnlineWithOptionsAsync(request, runtime);
        }

        public DescribeGroupedContainerInstancesResponse DescribeGroupedContainerInstancesWithOptions(DescribeGroupedContainerInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedContainerInstancesResponse>(DoRPCRequest("DescribeGroupedContainerInstances", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupedContainerInstancesResponse> DescribeGroupedContainerInstancesWithOptionsAsync(DescribeGroupedContainerInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedContainerInstancesResponse>(await DoRPCRequestAsync("DescribeGroupedContainerInstances", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupedContainerInstancesResponse DescribeGroupedContainerInstances(DescribeGroupedContainerInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupedContainerInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeGroupedContainerInstancesResponse> DescribeGroupedContainerInstancesAsync(DescribeGroupedContainerInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupedContainerInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeGroupedMaliciousFilesResponse DescribeGroupedMaliciousFilesWithOptions(DescribeGroupedMaliciousFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedMaliciousFilesResponse>(DoRPCRequest("DescribeGroupedMaliciousFiles", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupedMaliciousFilesResponse> DescribeGroupedMaliciousFilesWithOptionsAsync(DescribeGroupedMaliciousFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedMaliciousFilesResponse>(await DoRPCRequestAsync("DescribeGroupedMaliciousFiles", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupedMaliciousFilesResponse DescribeGroupedMaliciousFiles(DescribeGroupedMaliciousFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupedMaliciousFilesWithOptions(request, runtime);
        }

        public async Task<DescribeGroupedMaliciousFilesResponse> DescribeGroupedMaliciousFilesAsync(DescribeGroupedMaliciousFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupedMaliciousFilesWithOptionsAsync(request, runtime);
        }

        public DescribeGroupedTagsResponse DescribeGroupedTagsWithOptions(DescribeGroupedTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedTagsResponse>(DoRPCRequest("DescribeGroupedTags", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupedTagsResponse> DescribeGroupedTagsWithOptionsAsync(DescribeGroupedTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedTagsResponse>(await DoRPCRequestAsync("DescribeGroupedTags", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupedTagsResponse DescribeGroupedTags(DescribeGroupedTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupedTagsWithOptions(request, runtime);
        }

        public async Task<DescribeGroupedTagsResponse> DescribeGroupedTagsAsync(DescribeGroupedTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupedTagsWithOptionsAsync(request, runtime);
        }

        public DescribeGroupedVulResponse DescribeGroupedVulWithOptions(DescribeGroupedVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedVulResponse>(DoRPCRequest("DescribeGroupedVul", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupedVulResponse> DescribeGroupedVulWithOptionsAsync(DescribeGroupedVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupedVulResponse>(await DoRPCRequestAsync("DescribeGroupedVul", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupedVulResponse DescribeGroupedVul(DescribeGroupedVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupedVulWithOptions(request, runtime);
        }

        public async Task<DescribeGroupedVulResponse> DescribeGroupedVulAsync(DescribeGroupedVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupedVulWithOptionsAsync(request, runtime);
        }

        public DescribeHoneyPotAuthResponse DescribeHoneyPotAuthWithOptions(DescribeHoneyPotAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHoneyPotAuthResponse>(DoRPCRequest("DescribeHoneyPotAuth", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHoneyPotAuthResponse> DescribeHoneyPotAuthWithOptionsAsync(DescribeHoneyPotAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHoneyPotAuthResponse>(await DoRPCRequestAsync("DescribeHoneyPotAuth", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHoneyPotAuthResponse DescribeHoneyPotAuth(DescribeHoneyPotAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHoneyPotAuthWithOptions(request, runtime);
        }

        public async Task<DescribeHoneyPotAuthResponse> DescribeHoneyPotAuthAsync(DescribeHoneyPotAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHoneyPotAuthWithOptionsAsync(request, runtime);
        }

        public DescribeHoneyPotSuspStatisticsResponse DescribeHoneyPotSuspStatisticsWithOptions(DescribeHoneyPotSuspStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHoneyPotSuspStatisticsResponse>(DoRPCRequest("DescribeHoneyPotSuspStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHoneyPotSuspStatisticsResponse> DescribeHoneyPotSuspStatisticsWithOptionsAsync(DescribeHoneyPotSuspStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHoneyPotSuspStatisticsResponse>(await DoRPCRequestAsync("DescribeHoneyPotSuspStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHoneyPotSuspStatisticsResponse DescribeHoneyPotSuspStatistics(DescribeHoneyPotSuspStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHoneyPotSuspStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeHoneyPotSuspStatisticsResponse> DescribeHoneyPotSuspStatisticsAsync(DescribeHoneyPotSuspStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHoneyPotSuspStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeImageGroupedVulListResponse DescribeImageGroupedVulListWithOptions(DescribeImageGroupedVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageGroupedVulListResponse>(DoRPCRequest("DescribeImageGroupedVulList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageGroupedVulListResponse> DescribeImageGroupedVulListWithOptionsAsync(DescribeImageGroupedVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageGroupedVulListResponse>(await DoRPCRequestAsync("DescribeImageGroupedVulList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageGroupedVulListResponse DescribeImageGroupedVulList(DescribeImageGroupedVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageGroupedVulListWithOptions(request, runtime);
        }

        public async Task<DescribeImageGroupedVulListResponse> DescribeImageGroupedVulListAsync(DescribeImageGroupedVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageGroupedVulListWithOptionsAsync(request, runtime);
        }

        public DescribeImageStatisticsResponse DescribeImageStatisticsWithOptions(DescribeImageStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageStatisticsResponse>(DoRPCRequest("DescribeImageStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageStatisticsResponse> DescribeImageStatisticsWithOptionsAsync(DescribeImageStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageStatisticsResponse>(await DoRPCRequestAsync("DescribeImageStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageStatisticsResponse DescribeImageStatistics(DescribeImageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeImageStatisticsResponse> DescribeImageStatisticsAsync(DescribeImageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeImageVulListResponse DescribeImageVulListWithOptions(DescribeImageVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageVulListResponse>(DoRPCRequest("DescribeImageVulList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageVulListResponse> DescribeImageVulListWithOptionsAsync(DescribeImageVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageVulListResponse>(await DoRPCRequestAsync("DescribeImageVulList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageVulListResponse DescribeImageVulList(DescribeImageVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageVulListWithOptions(request, runtime);
        }

        public async Task<DescribeImageVulListResponse> DescribeImageVulListAsync(DescribeImageVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageVulListWithOptionsAsync(request, runtime);
        }

        public DescribeInstallCaptchaResponse DescribeInstallCaptchaWithOptions(DescribeInstallCaptchaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstallCaptchaResponse>(DoRPCRequest("DescribeInstallCaptcha", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstallCaptchaResponse> DescribeInstallCaptchaWithOptionsAsync(DescribeInstallCaptchaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstallCaptchaResponse>(await DoRPCRequestAsync("DescribeInstallCaptcha", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstallCaptchaResponse DescribeInstallCaptcha(DescribeInstallCaptchaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstallCaptchaWithOptions(request, runtime);
        }

        public async Task<DescribeInstallCaptchaResponse> DescribeInstallCaptchaAsync(DescribeInstallCaptchaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstallCaptchaWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAntiBruteForceRulesResponse DescribeInstanceAntiBruteForceRulesWithOptions(DescribeInstanceAntiBruteForceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAntiBruteForceRulesResponse>(DoRPCRequest("DescribeInstanceAntiBruteForceRules", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAntiBruteForceRulesResponse> DescribeInstanceAntiBruteForceRulesWithOptionsAsync(DescribeInstanceAntiBruteForceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAntiBruteForceRulesResponse>(await DoRPCRequestAsync("DescribeInstanceAntiBruteForceRules", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAntiBruteForceRulesResponse DescribeInstanceAntiBruteForceRules(DescribeInstanceAntiBruteForceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAntiBruteForceRulesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAntiBruteForceRulesResponse> DescribeInstanceAntiBruteForceRulesAsync(DescribeInstanceAntiBruteForceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAntiBruteForceRulesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceStatisticsResponse DescribeInstanceStatisticsWithOptions(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(DoRPCRequest("DescribeInstanceStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsWithOptionsAsync(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(await DoRPCRequestAsync("DescribeInstanceStatistics", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceStatisticsResponse DescribeInstanceStatistics(DescribeInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsAsync(DescribeInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeIpInfoResponse DescribeIpInfoWithOptions(DescribeIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpInfoResponse>(DoRPCRequest("DescribeIpInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpInfoResponse> DescribeIpInfoWithOptionsAsync(DescribeIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpInfoResponse>(await DoRPCRequestAsync("DescribeIpInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeModuleConfigResponse DescribeModuleConfigWithOptions(DescribeModuleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModuleConfigResponse>(DoRPCRequest("DescribeModuleConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeModuleConfigResponse> DescribeModuleConfigWithOptionsAsync(DescribeModuleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModuleConfigResponse>(await DoRPCRequestAsync("DescribeModuleConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeModuleConfigResponse DescribeModuleConfig(DescribeModuleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModuleConfigWithOptions(request, runtime);
        }

        public async Task<DescribeModuleConfigResponse> DescribeModuleConfigAsync(DescribeModuleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModuleConfigWithOptionsAsync(request, runtime);
        }

        public DescribeNoticeConfigResponse DescribeNoticeConfigWithOptions(DescribeNoticeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNoticeConfigResponse>(DoRPCRequest("DescribeNoticeConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNoticeConfigResponse> DescribeNoticeConfigWithOptionsAsync(DescribeNoticeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNoticeConfigResponse>(await DoRPCRequestAsync("DescribeNoticeConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNoticeConfigResponse DescribeNoticeConfig(DescribeNoticeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNoticeConfigWithOptions(request, runtime);
        }

        public async Task<DescribeNoticeConfigResponse> DescribeNoticeConfigAsync(DescribeNoticeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNoticeConfigWithOptionsAsync(request, runtime);
        }

        public DescribePropertyCountResponse DescribePropertyCountWithOptions(DescribePropertyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyCountResponse>(DoRPCRequest("DescribePropertyCount", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyCountResponse> DescribePropertyCountWithOptionsAsync(DescribePropertyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyCountResponse>(await DoRPCRequestAsync("DescribePropertyCount", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyCountResponse DescribePropertyCount(DescribePropertyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyCountWithOptions(request, runtime);
        }

        public async Task<DescribePropertyCountResponse> DescribePropertyCountAsync(DescribePropertyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyCountWithOptionsAsync(request, runtime);
        }

        public DescribePropertyCronDetailResponse DescribePropertyCronDetailWithOptions(DescribePropertyCronDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyCronDetailResponse>(DoRPCRequest("DescribePropertyCronDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyCronDetailResponse> DescribePropertyCronDetailWithOptionsAsync(DescribePropertyCronDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyCronDetailResponse>(await DoRPCRequestAsync("DescribePropertyCronDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyCronDetailResponse DescribePropertyCronDetail(DescribePropertyCronDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyCronDetailWithOptions(request, runtime);
        }

        public async Task<DescribePropertyCronDetailResponse> DescribePropertyCronDetailAsync(DescribePropertyCronDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyCronDetailWithOptionsAsync(request, runtime);
        }

        public DescribePropertyPortDetailResponse DescribePropertyPortDetailWithOptions(DescribePropertyPortDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyPortDetailResponse>(DoRPCRequest("DescribePropertyPortDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyPortDetailResponse> DescribePropertyPortDetailWithOptionsAsync(DescribePropertyPortDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyPortDetailResponse>(await DoRPCRequestAsync("DescribePropertyPortDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyPortDetailResponse DescribePropertyPortDetail(DescribePropertyPortDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyPortDetailWithOptions(request, runtime);
        }

        public async Task<DescribePropertyPortDetailResponse> DescribePropertyPortDetailAsync(DescribePropertyPortDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyPortDetailWithOptionsAsync(request, runtime);
        }

        public DescribePropertyPortItemResponse DescribePropertyPortItemWithOptions(DescribePropertyPortItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyPortItemResponse>(DoRPCRequest("DescribePropertyPortItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyPortItemResponse> DescribePropertyPortItemWithOptionsAsync(DescribePropertyPortItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyPortItemResponse>(await DoRPCRequestAsync("DescribePropertyPortItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyPortItemResponse DescribePropertyPortItem(DescribePropertyPortItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyPortItemWithOptions(request, runtime);
        }

        public async Task<DescribePropertyPortItemResponse> DescribePropertyPortItemAsync(DescribePropertyPortItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyPortItemWithOptionsAsync(request, runtime);
        }

        public DescribePropertyProcDetailResponse DescribePropertyProcDetailWithOptions(DescribePropertyProcDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyProcDetailResponse>(DoRPCRequest("DescribePropertyProcDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyProcDetailResponse> DescribePropertyProcDetailWithOptionsAsync(DescribePropertyProcDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyProcDetailResponse>(await DoRPCRequestAsync("DescribePropertyProcDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyProcDetailResponse DescribePropertyProcDetail(DescribePropertyProcDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyProcDetailWithOptions(request, runtime);
        }

        public async Task<DescribePropertyProcDetailResponse> DescribePropertyProcDetailAsync(DescribePropertyProcDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyProcDetailWithOptionsAsync(request, runtime);
        }

        public DescribePropertyProcItemResponse DescribePropertyProcItemWithOptions(DescribePropertyProcItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyProcItemResponse>(DoRPCRequest("DescribePropertyProcItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyProcItemResponse> DescribePropertyProcItemWithOptionsAsync(DescribePropertyProcItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyProcItemResponse>(await DoRPCRequestAsync("DescribePropertyProcItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyProcItemResponse DescribePropertyProcItem(DescribePropertyProcItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyProcItemWithOptions(request, runtime);
        }

        public async Task<DescribePropertyProcItemResponse> DescribePropertyProcItemAsync(DescribePropertyProcItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyProcItemWithOptionsAsync(request, runtime);
        }

        public DescribePropertyScaDetailResponse DescribePropertyScaDetailWithOptions(DescribePropertyScaDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyScaDetailResponse>(DoRPCRequest("DescribePropertyScaDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyScaDetailResponse> DescribePropertyScaDetailWithOptionsAsync(DescribePropertyScaDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyScaDetailResponse>(await DoRPCRequestAsync("DescribePropertyScaDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyScaDetailResponse DescribePropertyScaDetail(DescribePropertyScaDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyScaDetailWithOptions(request, runtime);
        }

        public async Task<DescribePropertyScaDetailResponse> DescribePropertyScaDetailAsync(DescribePropertyScaDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyScaDetailWithOptionsAsync(request, runtime);
        }

        public DescribePropertySoftwareDetailResponse DescribePropertySoftwareDetailWithOptions(DescribePropertySoftwareDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertySoftwareDetailResponse>(DoRPCRequest("DescribePropertySoftwareDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertySoftwareDetailResponse> DescribePropertySoftwareDetailWithOptionsAsync(DescribePropertySoftwareDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertySoftwareDetailResponse>(await DoRPCRequestAsync("DescribePropertySoftwareDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertySoftwareDetailResponse DescribePropertySoftwareDetail(DescribePropertySoftwareDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertySoftwareDetailWithOptions(request, runtime);
        }

        public async Task<DescribePropertySoftwareDetailResponse> DescribePropertySoftwareDetailAsync(DescribePropertySoftwareDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertySoftwareDetailWithOptionsAsync(request, runtime);
        }

        public DescribePropertySoftwareItemResponse DescribePropertySoftwareItemWithOptions(DescribePropertySoftwareItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertySoftwareItemResponse>(DoRPCRequest("DescribePropertySoftwareItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertySoftwareItemResponse> DescribePropertySoftwareItemWithOptionsAsync(DescribePropertySoftwareItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertySoftwareItemResponse>(await DoRPCRequestAsync("DescribePropertySoftwareItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertySoftwareItemResponse DescribePropertySoftwareItem(DescribePropertySoftwareItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertySoftwareItemWithOptions(request, runtime);
        }

        public async Task<DescribePropertySoftwareItemResponse> DescribePropertySoftwareItemAsync(DescribePropertySoftwareItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertySoftwareItemWithOptionsAsync(request, runtime);
        }

        public DescribePropertyUsageNewestResponse DescribePropertyUsageNewestWithOptions(DescribePropertyUsageNewestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyUsageNewestResponse>(DoRPCRequest("DescribePropertyUsageNewest", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyUsageNewestResponse> DescribePropertyUsageNewestWithOptionsAsync(DescribePropertyUsageNewestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyUsageNewestResponse>(await DoRPCRequestAsync("DescribePropertyUsageNewest", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyUsageNewestResponse DescribePropertyUsageNewest(DescribePropertyUsageNewestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyUsageNewestWithOptions(request, runtime);
        }

        public async Task<DescribePropertyUsageNewestResponse> DescribePropertyUsageNewestAsync(DescribePropertyUsageNewestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyUsageNewestWithOptionsAsync(request, runtime);
        }

        public DescribePropertyUserDetailResponse DescribePropertyUserDetailWithOptions(DescribePropertyUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyUserDetailResponse>(DoRPCRequest("DescribePropertyUserDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyUserDetailResponse> DescribePropertyUserDetailWithOptionsAsync(DescribePropertyUserDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyUserDetailResponse>(await DoRPCRequestAsync("DescribePropertyUserDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyUserDetailResponse DescribePropertyUserDetail(DescribePropertyUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyUserDetailWithOptions(request, runtime);
        }

        public async Task<DescribePropertyUserDetailResponse> DescribePropertyUserDetailAsync(DescribePropertyUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyUserDetailWithOptionsAsync(request, runtime);
        }

        public DescribePropertyUserItemResponse DescribePropertyUserItemWithOptions(DescribePropertyUserItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyUserItemResponse>(DoRPCRequest("DescribePropertyUserItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePropertyUserItemResponse> DescribePropertyUserItemWithOptionsAsync(DescribePropertyUserItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePropertyUserItemResponse>(await DoRPCRequestAsync("DescribePropertyUserItem", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePropertyUserItemResponse DescribePropertyUserItem(DescribePropertyUserItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePropertyUserItemWithOptions(request, runtime);
        }

        public async Task<DescribePropertyUserItemResponse> DescribePropertyUserItemAsync(DescribePropertyUserItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePropertyUserItemWithOptionsAsync(request, runtime);
        }

        public DescribeRiskCheckItemResultResponse DescribeRiskCheckItemResultWithOptions(DescribeRiskCheckItemResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskCheckItemResultResponse>(DoRPCRequest("DescribeRiskCheckItemResult", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRiskCheckItemResultResponse> DescribeRiskCheckItemResultWithOptionsAsync(DescribeRiskCheckItemResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskCheckItemResultResponse>(await DoRPCRequestAsync("DescribeRiskCheckItemResult", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRiskCheckItemResultResponse DescribeRiskCheckItemResult(DescribeRiskCheckItemResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskCheckItemResultWithOptions(request, runtime);
        }

        public async Task<DescribeRiskCheckItemResultResponse> DescribeRiskCheckItemResultAsync(DescribeRiskCheckItemResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskCheckItemResultWithOptionsAsync(request, runtime);
        }

        public DescribeRiskCheckResultResponse DescribeRiskCheckResultWithOptions(DescribeRiskCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskCheckResultResponse>(DoRPCRequest("DescribeRiskCheckResult", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRiskCheckResultResponse> DescribeRiskCheckResultWithOptionsAsync(DescribeRiskCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskCheckResultResponse>(await DoRPCRequestAsync("DescribeRiskCheckResult", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRiskCheckResultResponse DescribeRiskCheckResult(DescribeRiskCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribeRiskCheckResultResponse> DescribeRiskCheckResultAsync(DescribeRiskCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeRiskCheckSummaryResponse DescribeRiskCheckSummaryWithOptions(DescribeRiskCheckSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskCheckSummaryResponse>(DoRPCRequest("DescribeRiskCheckSummary", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRiskCheckSummaryResponse> DescribeRiskCheckSummaryWithOptionsAsync(DescribeRiskCheckSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskCheckSummaryResponse>(await DoRPCRequestAsync("DescribeRiskCheckSummary", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRiskCheckSummaryResponse DescribeRiskCheckSummary(DescribeRiskCheckSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskCheckSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeRiskCheckSummaryResponse> DescribeRiskCheckSummaryAsync(DescribeRiskCheckSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskCheckSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeRiskItemTypeResponse DescribeRiskItemTypeWithOptions(DescribeRiskItemTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskItemTypeResponse>(DoRPCRequest("DescribeRiskItemType", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRiskItemTypeResponse> DescribeRiskItemTypeWithOptionsAsync(DescribeRiskItemTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskItemTypeResponse>(await DoRPCRequestAsync("DescribeRiskItemType", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRiskItemTypeResponse DescribeRiskItemType(DescribeRiskItemTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskItemTypeWithOptions(request, runtime);
        }

        public async Task<DescribeRiskItemTypeResponse> DescribeRiskItemTypeAsync(DescribeRiskItemTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskItemTypeWithOptionsAsync(request, runtime);
        }

        public DescribeRiskListCheckResultResponse DescribeRiskListCheckResultWithOptions(DescribeRiskListCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskListCheckResultResponse>(DoRPCRequest("DescribeRiskListCheckResult", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRiskListCheckResultResponse> DescribeRiskListCheckResultWithOptionsAsync(DescribeRiskListCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskListCheckResultResponse>(await DoRPCRequestAsync("DescribeRiskListCheckResult", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRiskListCheckResultResponse DescribeRiskListCheckResult(DescribeRiskListCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskListCheckResultWithOptions(request, runtime);
        }

        public async Task<DescribeRiskListCheckResultResponse> DescribeRiskListCheckResultAsync(DescribeRiskListCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskListCheckResultWithOptionsAsync(request, runtime);
        }

        public DescribeSasAssetStatisticsColumnResponse DescribeSasAssetStatisticsColumnWithOptions(DescribeSasAssetStatisticsColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSasAssetStatisticsColumnResponse>(DoRPCRequest("DescribeSasAssetStatisticsColumn", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSasAssetStatisticsColumnResponse> DescribeSasAssetStatisticsColumnWithOptionsAsync(DescribeSasAssetStatisticsColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSasAssetStatisticsColumnResponse>(await DoRPCRequestAsync("DescribeSasAssetStatisticsColumn", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSasAssetStatisticsColumnResponse DescribeSasAssetStatisticsColumn(DescribeSasAssetStatisticsColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSasAssetStatisticsColumnWithOptions(request, runtime);
        }

        public async Task<DescribeSasAssetStatisticsColumnResponse> DescribeSasAssetStatisticsColumnAsync(DescribeSasAssetStatisticsColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSasAssetStatisticsColumnWithOptionsAsync(request, runtime);
        }

        public DescribeSearchConditionResponse DescribeSearchConditionWithOptions(DescribeSearchConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSearchConditionResponse>(DoRPCRequest("DescribeSearchCondition", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSearchConditionResponse> DescribeSearchConditionWithOptionsAsync(DescribeSearchConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSearchConditionResponse>(await DoRPCRequestAsync("DescribeSearchCondition", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSearchConditionResponse DescribeSearchCondition(DescribeSearchConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSearchConditionWithOptions(request, runtime);
        }

        public async Task<DescribeSearchConditionResponse> DescribeSearchConditionAsync(DescribeSearchConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSearchConditionWithOptionsAsync(request, runtime);
        }

        public DescribeSecureSuggestionResponse DescribeSecureSuggestionWithOptions(DescribeSecureSuggestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecureSuggestionResponse>(DoRPCRequest("DescribeSecureSuggestion", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecureSuggestionResponse> DescribeSecureSuggestionWithOptionsAsync(DescribeSecureSuggestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecureSuggestionResponse>(await DoRPCRequestAsync("DescribeSecureSuggestion", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecureSuggestionResponse DescribeSecureSuggestion(DescribeSecureSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecureSuggestionWithOptions(request, runtime);
        }

        public async Task<DescribeSecureSuggestionResponse> DescribeSecureSuggestionAsync(DescribeSecureSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecureSuggestionWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityCheckScheduleConfigResponse DescribeSecurityCheckScheduleConfigWithOptions(DescribeSecurityCheckScheduleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityCheckScheduleConfigResponse>(DoRPCRequest("DescribeSecurityCheckScheduleConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityCheckScheduleConfigResponse> DescribeSecurityCheckScheduleConfigWithOptionsAsync(DescribeSecurityCheckScheduleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityCheckScheduleConfigResponse>(await DoRPCRequestAsync("DescribeSecurityCheckScheduleConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityCheckScheduleConfigResponse DescribeSecurityCheckScheduleConfig(DescribeSecurityCheckScheduleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityCheckScheduleConfigWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityCheckScheduleConfigResponse> DescribeSecurityCheckScheduleConfigAsync(DescribeSecurityCheckScheduleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityCheckScheduleConfigWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperationsWithOptions(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(DoRPCRequest("DescribeSecurityEventOperations", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsWithOptionsAsync(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(await DoRPCRequestAsync("DescribeSecurityEventOperations", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperations(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsAsync(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationsWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityEventOperationStatusResponse DescribeSecurityEventOperationStatusWithOptions(DescribeSecurityEventOperationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationStatusResponse>(DoRPCRequest("DescribeSecurityEventOperationStatus", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityEventOperationStatusResponse> DescribeSecurityEventOperationStatusWithOptionsAsync(DescribeSecurityEventOperationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationStatusResponse>(await DoRPCRequestAsync("DescribeSecurityEventOperationStatus", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityEventOperationStatusResponse DescribeSecurityEventOperationStatus(DescribeSecurityEventOperationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityEventOperationStatusResponse> DescribeSecurityEventOperationStatusAsync(DescribeSecurityEventOperationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityStatInfoResponse DescribeSecurityStatInfoWithOptions(DescribeSecurityStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityStatInfoResponse>(DoRPCRequest("DescribeSecurityStatInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityStatInfoResponse> DescribeSecurityStatInfoWithOptionsAsync(DescribeSecurityStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityStatInfoResponse>(await DoRPCRequestAsync("DescribeSecurityStatInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityStatInfoResponse DescribeSecurityStatInfo(DescribeSecurityStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityStatInfoWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityStatInfoResponse> DescribeSecurityStatInfoAsync(DescribeSecurityStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityStatInfoWithOptionsAsync(request, runtime);
        }

        public DescribeSimilarEventScenariosResponse DescribeSimilarEventScenariosWithOptions(DescribeSimilarEventScenariosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSimilarEventScenariosResponse>(DoRPCRequest("DescribeSimilarEventScenarios", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSimilarEventScenariosResponse> DescribeSimilarEventScenariosWithOptionsAsync(DescribeSimilarEventScenariosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSimilarEventScenariosResponse>(await DoRPCRequestAsync("DescribeSimilarEventScenarios", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSimilarEventScenariosResponse DescribeSimilarEventScenarios(DescribeSimilarEventScenariosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSimilarEventScenariosWithOptions(request, runtime);
        }

        public async Task<DescribeSimilarEventScenariosResponse> DescribeSimilarEventScenariosAsync(DescribeSimilarEventScenariosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSimilarEventScenariosWithOptionsAsync(request, runtime);
        }

        public DescribeSimilarSecurityEventsResponse DescribeSimilarSecurityEventsWithOptions(DescribeSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSimilarSecurityEventsResponse>(DoRPCRequest("DescribeSimilarSecurityEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSimilarSecurityEventsResponse> DescribeSimilarSecurityEventsWithOptionsAsync(DescribeSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSimilarSecurityEventsResponse>(await DoRPCRequestAsync("DescribeSimilarSecurityEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSimilarSecurityEventsResponse DescribeSimilarSecurityEvents(DescribeSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSimilarSecurityEventsWithOptions(request, runtime);
        }

        public async Task<DescribeSimilarSecurityEventsResponse> DescribeSimilarSecurityEventsAsync(DescribeSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSimilarSecurityEventsWithOptionsAsync(request, runtime);
        }

        public DescribeStrategyExecDetailResponse DescribeStrategyExecDetailWithOptions(DescribeStrategyExecDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStrategyExecDetailResponse>(DoRPCRequest("DescribeStrategyExecDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStrategyExecDetailResponse> DescribeStrategyExecDetailWithOptionsAsync(DescribeStrategyExecDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStrategyExecDetailResponse>(await DoRPCRequestAsync("DescribeStrategyExecDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStrategyExecDetailResponse DescribeStrategyExecDetail(DescribeStrategyExecDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStrategyExecDetailWithOptions(request, runtime);
        }

        public async Task<DescribeStrategyExecDetailResponse> DescribeStrategyExecDetailAsync(DescribeStrategyExecDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStrategyExecDetailWithOptionsAsync(request, runtime);
        }

        public DescribeStratetyResponse DescribeStratetyWithOptions(DescribeStratetyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStratetyResponse>(DoRPCRequest("DescribeStratety", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStratetyResponse> DescribeStratetyWithOptionsAsync(DescribeStratetyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStratetyResponse>(await DoRPCRequestAsync("DescribeStratety", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStratetyResponse DescribeStratety(DescribeStratetyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStratetyWithOptions(request, runtime);
        }

        public async Task<DescribeStratetyResponse> DescribeStratetyAsync(DescribeStratetyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStratetyWithOptionsAsync(request, runtime);
        }

        public DescribeSummaryInfoResponse DescribeSummaryInfoWithOptions(DescribeSummaryInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSummaryInfoResponse>(DoRPCRequest("DescribeSummaryInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSummaryInfoResponse> DescribeSummaryInfoWithOptionsAsync(DescribeSummaryInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSummaryInfoResponse>(await DoRPCRequestAsync("DescribeSummaryInfo", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSummaryInfoResponse DescribeSummaryInfo(DescribeSummaryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSummaryInfoWithOptions(request, runtime);
        }

        public async Task<DescribeSummaryInfoResponse> DescribeSummaryInfoAsync(DescribeSummaryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSummaryInfoWithOptionsAsync(request, runtime);
        }

        public DescribeSuspEventDetailResponse DescribeSuspEventDetailWithOptions(DescribeSuspEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventDetailResponse>(DoRPCRequest("DescribeSuspEventDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSuspEventDetailResponse> DescribeSuspEventDetailWithOptionsAsync(DescribeSuspEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventDetailResponse>(await DoRPCRequestAsync("DescribeSuspEventDetail", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSuspEventDetailResponse DescribeSuspEventDetail(DescribeSuspEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventDetailWithOptions(request, runtime);
        }

        public async Task<DescribeSuspEventDetailResponse> DescribeSuspEventDetailAsync(DescribeSuspEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventDetailWithOptionsAsync(request, runtime);
        }

        public DescribeSuspEventQuaraFilesResponse DescribeSuspEventQuaraFilesWithOptions(DescribeSuspEventQuaraFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventQuaraFilesResponse>(DoRPCRequest("DescribeSuspEventQuaraFiles", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSuspEventQuaraFilesResponse> DescribeSuspEventQuaraFilesWithOptionsAsync(DescribeSuspEventQuaraFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventQuaraFilesResponse>(await DoRPCRequestAsync("DescribeSuspEventQuaraFiles", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSuspEventQuaraFilesResponse DescribeSuspEventQuaraFiles(DescribeSuspEventQuaraFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventQuaraFilesWithOptions(request, runtime);
        }

        public async Task<DescribeSuspEventQuaraFilesResponse> DescribeSuspEventQuaraFilesAsync(DescribeSuspEventQuaraFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventQuaraFilesWithOptionsAsync(request, runtime);
        }

        public DescribeSuspEventsResponse DescribeSuspEventsWithOptions(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(DoRPCRequest("DescribeSuspEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsWithOptionsAsync(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(await DoRPCRequestAsync("DescribeSuspEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSuspEventsResponse DescribeSuspEvents(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventsWithOptions(request, runtime);
        }

        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsAsync(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventsWithOptionsAsync(request, runtime);
        }

        public DescribeUserBaselineAuthorizationResponse DescribeUserBaselineAuthorizationWithOptions(DescribeUserBaselineAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserBaselineAuthorizationResponse>(DoRPCRequest("DescribeUserBaselineAuthorization", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserBaselineAuthorizationResponse> DescribeUserBaselineAuthorizationWithOptionsAsync(DescribeUserBaselineAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserBaselineAuthorizationResponse>(await DoRPCRequestAsync("DescribeUserBaselineAuthorization", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserBaselineAuthorizationResponse DescribeUserBaselineAuthorization(DescribeUserBaselineAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBaselineAuthorizationWithOptions(request, runtime);
        }

        public async Task<DescribeUserBaselineAuthorizationResponse> DescribeUserBaselineAuthorizationAsync(DescribeUserBaselineAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBaselineAuthorizationWithOptionsAsync(request, runtime);
        }

        public DescribeUserLayoutAuthorizationResponse DescribeUserLayoutAuthorizationWithOptions(DescribeUserLayoutAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserLayoutAuthorizationResponse>(DoRPCRequest("DescribeUserLayoutAuthorization", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserLayoutAuthorizationResponse> DescribeUserLayoutAuthorizationWithOptionsAsync(DescribeUserLayoutAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserLayoutAuthorizationResponse>(await DoRPCRequestAsync("DescribeUserLayoutAuthorization", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserLayoutAuthorizationResponse DescribeUserLayoutAuthorization(DescribeUserLayoutAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserLayoutAuthorizationWithOptions(request, runtime);
        }

        public async Task<DescribeUserLayoutAuthorizationResponse> DescribeUserLayoutAuthorizationAsync(DescribeUserLayoutAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserLayoutAuthorizationWithOptionsAsync(request, runtime);
        }

        public DescribeVersionConfigResponse DescribeVersionConfigWithOptions(DescribeVersionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVersionConfigResponse>(DoRPCRequest("DescribeVersionConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVersionConfigResponse> DescribeVersionConfigWithOptionsAsync(DescribeVersionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVersionConfigResponse>(await DoRPCRequestAsync("DescribeVersionConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVersionConfigResponse DescribeVersionConfig(DescribeVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVersionConfigWithOptions(request, runtime);
        }

        public async Task<DescribeVersionConfigResponse> DescribeVersionConfigAsync(DescribeVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVersionConfigWithOptionsAsync(request, runtime);
        }

        public DescribeVolDingdingMessageResponse DescribeVolDingdingMessageWithOptions(DescribeVolDingdingMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVolDingdingMessageResponse>(DoRPCRequest("DescribeVolDingdingMessage", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVolDingdingMessageResponse> DescribeVolDingdingMessageWithOptionsAsync(DescribeVolDingdingMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVolDingdingMessageResponse>(await DoRPCRequestAsync("DescribeVolDingdingMessage", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVolDingdingMessageResponse DescribeVolDingdingMessage(DescribeVolDingdingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVolDingdingMessageWithOptions(request, runtime);
        }

        public async Task<DescribeVolDingdingMessageResponse> DescribeVolDingdingMessageAsync(DescribeVolDingdingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVolDingdingMessageWithOptionsAsync(request, runtime);
        }

        public DescribeVpcHoneyPotCriteriaResponse DescribeVpcHoneyPotCriteriaWithOptions(DescribeVpcHoneyPotCriteriaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcHoneyPotCriteriaResponse>(DoRPCRequest("DescribeVpcHoneyPotCriteria", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcHoneyPotCriteriaResponse> DescribeVpcHoneyPotCriteriaWithOptionsAsync(DescribeVpcHoneyPotCriteriaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcHoneyPotCriteriaResponse>(await DoRPCRequestAsync("DescribeVpcHoneyPotCriteria", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcHoneyPotCriteriaResponse DescribeVpcHoneyPotCriteria(DescribeVpcHoneyPotCriteriaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcHoneyPotCriteriaWithOptions(request, runtime);
        }

        public async Task<DescribeVpcHoneyPotCriteriaResponse> DescribeVpcHoneyPotCriteriaAsync(DescribeVpcHoneyPotCriteriaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcHoneyPotCriteriaWithOptionsAsync(request, runtime);
        }

        public DescribeVpcHoneyPotListResponse DescribeVpcHoneyPotListWithOptions(DescribeVpcHoneyPotListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcHoneyPotListResponse>(DoRPCRequest("DescribeVpcHoneyPotList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcHoneyPotListResponse> DescribeVpcHoneyPotListWithOptionsAsync(DescribeVpcHoneyPotListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcHoneyPotListResponse>(await DoRPCRequestAsync("DescribeVpcHoneyPotList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcHoneyPotListResponse DescribeVpcHoneyPotList(DescribeVpcHoneyPotListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcHoneyPotListWithOptions(request, runtime);
        }

        public async Task<DescribeVpcHoneyPotListResponse> DescribeVpcHoneyPotListAsync(DescribeVpcHoneyPotListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcHoneyPotListWithOptionsAsync(request, runtime);
        }

        public DescribeVpcListResponse DescribeVpcListWithOptions(DescribeVpcListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcListResponse>(DoRPCRequest("DescribeVpcList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcListResponse> DescribeVpcListWithOptionsAsync(DescribeVpcListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcListResponse>(await DoRPCRequestAsync("DescribeVpcList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcListResponse DescribeVpcList(DescribeVpcListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcListWithOptions(request, runtime);
        }

        public async Task<DescribeVpcListResponse> DescribeVpcListAsync(DescribeVpcListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcListWithOptionsAsync(request, runtime);
        }

        public DescribeVulDetailsResponse DescribeVulDetailsWithOptions(DescribeVulDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulDetailsResponse>(DoRPCRequest("DescribeVulDetails", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulDetailsResponse> DescribeVulDetailsWithOptionsAsync(DescribeVulDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulDetailsResponse>(await DoRPCRequestAsync("DescribeVulDetails", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulDetailsResponse DescribeVulDetails(DescribeVulDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeVulDetailsResponse> DescribeVulDetailsAsync(DescribeVulDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeVulListResponse DescribeVulListWithOptions(DescribeVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulListResponse>(DoRPCRequest("DescribeVulList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulListResponse> DescribeVulListWithOptionsAsync(DescribeVulListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulListResponse>(await DoRPCRequestAsync("DescribeVulList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulListResponse DescribeVulList(DescribeVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulListWithOptions(request, runtime);
        }

        public async Task<DescribeVulListResponse> DescribeVulListAsync(DescribeVulListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulListWithOptionsAsync(request, runtime);
        }

        public DescribeVulWhitelistResponse DescribeVulWhitelistWithOptions(DescribeVulWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulWhitelistResponse>(DoRPCRequest("DescribeVulWhitelist", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulWhitelistResponse> DescribeVulWhitelistWithOptionsAsync(DescribeVulWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulWhitelistResponse>(await DoRPCRequestAsync("DescribeVulWhitelist", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulWhitelistResponse DescribeVulWhitelist(DescribeVulWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulWhitelistWithOptions(request, runtime);
        }

        public async Task<DescribeVulWhitelistResponse> DescribeVulWhitelistAsync(DescribeVulWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulWhitelistWithOptionsAsync(request, runtime);
        }

        public DescribeWarningMachinesResponse DescribeWarningMachinesWithOptions(DescribeWarningMachinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWarningMachinesResponse>(DoRPCRequest("DescribeWarningMachines", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWarningMachinesResponse> DescribeWarningMachinesWithOptionsAsync(DescribeWarningMachinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWarningMachinesResponse>(await DoRPCRequestAsync("DescribeWarningMachines", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWarningMachinesResponse DescribeWarningMachines(DescribeWarningMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWarningMachinesWithOptions(request, runtime);
        }

        public async Task<DescribeWarningMachinesResponse> DescribeWarningMachinesAsync(DescribeWarningMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWarningMachinesWithOptionsAsync(request, runtime);
        }

        public DescribeWebLockBindListResponse DescribeWebLockBindListWithOptions(DescribeWebLockBindListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebLockBindListResponse>(DoRPCRequest("DescribeWebLockBindList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebLockBindListResponse> DescribeWebLockBindListWithOptionsAsync(DescribeWebLockBindListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebLockBindListResponse>(await DoRPCRequestAsync("DescribeWebLockBindList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebLockBindListResponse DescribeWebLockBindList(DescribeWebLockBindListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebLockBindListWithOptions(request, runtime);
        }

        public async Task<DescribeWebLockBindListResponse> DescribeWebLockBindListAsync(DescribeWebLockBindListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebLockBindListWithOptionsAsync(request, runtime);
        }

        public DescribeWebLockConfigListResponse DescribeWebLockConfigListWithOptions(DescribeWebLockConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebLockConfigListResponse>(DoRPCRequest("DescribeWebLockConfigList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebLockConfigListResponse> DescribeWebLockConfigListWithOptionsAsync(DescribeWebLockConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebLockConfigListResponse>(await DoRPCRequestAsync("DescribeWebLockConfigList", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebLockConfigListResponse DescribeWebLockConfigList(DescribeWebLockConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebLockConfigListWithOptions(request, runtime);
        }

        public async Task<DescribeWebLockConfigListResponse> DescribeWebLockConfigListAsync(DescribeWebLockConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebLockConfigListWithOptionsAsync(request, runtime);
        }

        public ExportRecordResponse ExportRecordWithOptions(ExportRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportRecordResponse>(DoRPCRequest("ExportRecord", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportRecordResponse> ExportRecordWithOptionsAsync(ExportRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportRecordResponse>(await DoRPCRequestAsync("ExportRecord", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportRecordResponse ExportRecord(ExportRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportRecordWithOptions(request, runtime);
        }

        public async Task<ExportRecordResponse> ExportRecordAsync(ExportRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportRecordWithOptionsAsync(request, runtime);
        }

        public FixCheckWarningsResponse FixCheckWarningsWithOptions(FixCheckWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FixCheckWarningsResponse>(DoRPCRequest("FixCheckWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FixCheckWarningsResponse> FixCheckWarningsWithOptionsAsync(FixCheckWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FixCheckWarningsResponse>(await DoRPCRequestAsync("FixCheckWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FixCheckWarningsResponse FixCheckWarnings(FixCheckWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FixCheckWarningsWithOptions(request, runtime);
        }

        public async Task<FixCheckWarningsResponse> FixCheckWarningsAsync(FixCheckWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FixCheckWarningsWithOptionsAsync(request, runtime);
        }

        public GetIncIOCsResponse GetIncIOCsWithOptions(GetIncIOCsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIncIOCsResponse>(DoRPCRequest("GetIncIOCs", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIncIOCsResponse> GetIncIOCsWithOptionsAsync(GetIncIOCsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIncIOCsResponse>(await DoRPCRequestAsync("GetIncIOCs", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIncIOCsResponse GetIncIOCs(GetIncIOCsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIncIOCsWithOptions(request, runtime);
        }

        public async Task<GetIncIOCsResponse> GetIncIOCsAsync(GetIncIOCsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIncIOCsWithOptionsAsync(request, runtime);
        }

        public GetIOCsResponse GetIOCsWithOptions(GetIOCsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIOCsResponse>(DoRPCRequest("GetIOCs", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIOCsResponse> GetIOCsWithOptionsAsync(GetIOCsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIOCsResponse>(await DoRPCRequestAsync("GetIOCs", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIOCsResponse GetIOCs(GetIOCsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIOCsWithOptions(request, runtime);
        }

        public async Task<GetIOCsResponse> GetIOCsAsync(GetIOCsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIOCsWithOptionsAsync(request, runtime);
        }

        public HandleSecurityEventsResponse HandleSecurityEventsWithOptions(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(DoRPCRequest("HandleSecurityEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsWithOptionsAsync(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(await DoRPCRequestAsync("HandleSecurityEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HandleSecurityEventsResponse HandleSecurityEvents(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleSecurityEventsWithOptions(request, runtime);
        }

        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsAsync(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleSecurityEventsWithOptionsAsync(request, runtime);
        }

        public HandleSimilarSecurityEventsResponse HandleSimilarSecurityEventsWithOptions(HandleSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HandleSimilarSecurityEventsResponse>(DoRPCRequest("HandleSimilarSecurityEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HandleSimilarSecurityEventsResponse> HandleSimilarSecurityEventsWithOptionsAsync(HandleSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HandleSimilarSecurityEventsResponse>(await DoRPCRequestAsync("HandleSimilarSecurityEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HandleSimilarSecurityEventsResponse HandleSimilarSecurityEvents(HandleSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleSimilarSecurityEventsWithOptions(request, runtime);
        }

        public async Task<HandleSimilarSecurityEventsResponse> HandleSimilarSecurityEventsAsync(HandleSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleSimilarSecurityEventsWithOptionsAsync(request, runtime);
        }

        public IgnoreHcCheckWarningsResponse IgnoreHcCheckWarningsWithOptions(IgnoreHcCheckWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IgnoreHcCheckWarningsResponse>(DoRPCRequest("IgnoreHcCheckWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IgnoreHcCheckWarningsResponse> IgnoreHcCheckWarningsWithOptionsAsync(IgnoreHcCheckWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IgnoreHcCheckWarningsResponse>(await DoRPCRequestAsync("IgnoreHcCheckWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IgnoreHcCheckWarningsResponse IgnoreHcCheckWarnings(IgnoreHcCheckWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreHcCheckWarningsWithOptions(request, runtime);
        }

        public async Task<IgnoreHcCheckWarningsResponse> IgnoreHcCheckWarningsAsync(IgnoreHcCheckWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreHcCheckWarningsWithOptionsAsync(request, runtime);
        }

        public ModifyAntiBruteForceRuleResponse ModifyAntiBruteForceRuleWithOptions(ModifyAntiBruteForceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAntiBruteForceRuleResponse>(DoRPCRequest("ModifyAntiBruteForceRule", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAntiBruteForceRuleResponse> ModifyAntiBruteForceRuleWithOptionsAsync(ModifyAntiBruteForceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAntiBruteForceRuleResponse>(await DoRPCRequestAsync("ModifyAntiBruteForceRule", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAntiBruteForceRuleResponse ModifyAntiBruteForceRule(ModifyAntiBruteForceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAntiBruteForceRuleWithOptions(request, runtime);
        }

        public async Task<ModifyAntiBruteForceRuleResponse> ModifyAntiBruteForceRuleAsync(ModifyAntiBruteForceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAntiBruteForceRuleWithOptionsAsync(request, runtime);
        }

        public ModifyCreateVulWhitelistResponse ModifyCreateVulWhitelistWithOptions(ModifyCreateVulWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCreateVulWhitelistResponse>(DoRPCRequest("ModifyCreateVulWhitelist", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCreateVulWhitelistResponse> ModifyCreateVulWhitelistWithOptionsAsync(ModifyCreateVulWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCreateVulWhitelistResponse>(await DoRPCRequestAsync("ModifyCreateVulWhitelist", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCreateVulWhitelistResponse ModifyCreateVulWhitelist(ModifyCreateVulWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCreateVulWhitelistWithOptions(request, runtime);
        }

        public async Task<ModifyCreateVulWhitelistResponse> ModifyCreateVulWhitelistAsync(ModifyCreateVulWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCreateVulWhitelistWithOptionsAsync(request, runtime);
        }

        public ModifyEmgVulSubmitResponse ModifyEmgVulSubmitWithOptions(ModifyEmgVulSubmitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEmgVulSubmitResponse>(DoRPCRequest("ModifyEmgVulSubmit", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEmgVulSubmitResponse> ModifyEmgVulSubmitWithOptionsAsync(ModifyEmgVulSubmitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEmgVulSubmitResponse>(await DoRPCRequestAsync("ModifyEmgVulSubmit", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEmgVulSubmitResponse ModifyEmgVulSubmit(ModifyEmgVulSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEmgVulSubmitWithOptions(request, runtime);
        }

        public async Task<ModifyEmgVulSubmitResponse> ModifyEmgVulSubmitAsync(ModifyEmgVulSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEmgVulSubmitWithOptionsAsync(request, runtime);
        }

        public ModifyGroupPropertyResponse ModifyGroupPropertyWithOptions(ModifyGroupPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGroupPropertyResponse>(DoRPCRequest("ModifyGroupProperty", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGroupPropertyResponse> ModifyGroupPropertyWithOptionsAsync(ModifyGroupPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGroupPropertyResponse>(await DoRPCRequestAsync("ModifyGroupProperty", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGroupPropertyResponse ModifyGroupProperty(ModifyGroupPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGroupPropertyWithOptions(request, runtime);
        }

        public async Task<ModifyGroupPropertyResponse> ModifyGroupPropertyAsync(ModifyGroupPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGroupPropertyWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAntiBruteForceRuleResponse ModifyInstanceAntiBruteForceRuleWithOptions(ModifyInstanceAntiBruteForceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAntiBruteForceRuleResponse>(DoRPCRequest("ModifyInstanceAntiBruteForceRule", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAntiBruteForceRuleResponse> ModifyInstanceAntiBruteForceRuleWithOptionsAsync(ModifyInstanceAntiBruteForceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAntiBruteForceRuleResponse>(await DoRPCRequestAsync("ModifyInstanceAntiBruteForceRule", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAntiBruteForceRuleResponse ModifyInstanceAntiBruteForceRule(ModifyInstanceAntiBruteForceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAntiBruteForceRuleWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAntiBruteForceRuleResponse> ModifyInstanceAntiBruteForceRuleAsync(ModifyInstanceAntiBruteForceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAntiBruteForceRuleWithOptionsAsync(request, runtime);
        }

        public ModifyLoginBaseConfigResponse ModifyLoginBaseConfigWithOptions(ModifyLoginBaseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoginBaseConfigResponse>(DoRPCRequest("ModifyLoginBaseConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLoginBaseConfigResponse> ModifyLoginBaseConfigWithOptionsAsync(ModifyLoginBaseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoginBaseConfigResponse>(await DoRPCRequestAsync("ModifyLoginBaseConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLoginBaseConfigResponse ModifyLoginBaseConfig(ModifyLoginBaseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoginBaseConfigWithOptions(request, runtime);
        }

        public async Task<ModifyLoginBaseConfigResponse> ModifyLoginBaseConfigAsync(ModifyLoginBaseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoginBaseConfigWithOptionsAsync(request, runtime);
        }

        public ModifyLoginSwitchConfigResponse ModifyLoginSwitchConfigWithOptions(ModifyLoginSwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoginSwitchConfigResponse>(DoRPCRequest("ModifyLoginSwitchConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLoginSwitchConfigResponse> ModifyLoginSwitchConfigWithOptionsAsync(ModifyLoginSwitchConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoginSwitchConfigResponse>(await DoRPCRequestAsync("ModifyLoginSwitchConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLoginSwitchConfigResponse ModifyLoginSwitchConfig(ModifyLoginSwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoginSwitchConfigWithOptions(request, runtime);
        }

        public async Task<ModifyLoginSwitchConfigResponse> ModifyLoginSwitchConfigAsync(ModifyLoginSwitchConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoginSwitchConfigWithOptionsAsync(request, runtime);
        }

        public ModifyNoticeConfigResponse ModifyNoticeConfigWithOptions(ModifyNoticeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNoticeConfigResponse>(DoRPCRequest("ModifyNoticeConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNoticeConfigResponse> ModifyNoticeConfigWithOptionsAsync(ModifyNoticeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNoticeConfigResponse>(await DoRPCRequestAsync("ModifyNoticeConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNoticeConfigResponse ModifyNoticeConfig(ModifyNoticeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNoticeConfigWithOptions(request, runtime);
        }

        public async Task<ModifyNoticeConfigResponse> ModifyNoticeConfigAsync(ModifyNoticeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNoticeConfigWithOptionsAsync(request, runtime);
        }

        public ModifyOperateVulResponse ModifyOperateVulWithOptions(ModifyOperateVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOperateVulResponse>(DoRPCRequest("ModifyOperateVul", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyOperateVulResponse> ModifyOperateVulWithOptionsAsync(ModifyOperateVulRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOperateVulResponse>(await DoRPCRequestAsync("ModifyOperateVul", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyOperateVulResponse ModifyOperateVul(ModifyOperateVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOperateVulWithOptions(request, runtime);
        }

        public async Task<ModifyOperateVulResponse> ModifyOperateVulAsync(ModifyOperateVulRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOperateVulWithOptionsAsync(request, runtime);
        }

        public ModifyPushAllTaskResponse ModifyPushAllTaskWithOptions(ModifyPushAllTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPushAllTaskResponse>(DoRPCRequest("ModifyPushAllTask", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPushAllTaskResponse> ModifyPushAllTaskWithOptionsAsync(ModifyPushAllTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPushAllTaskResponse>(await DoRPCRequestAsync("ModifyPushAllTask", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPushAllTaskResponse ModifyPushAllTask(ModifyPushAllTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPushAllTaskWithOptions(request, runtime);
        }

        public async Task<ModifyPushAllTaskResponse> ModifyPushAllTaskAsync(ModifyPushAllTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPushAllTaskWithOptionsAsync(request, runtime);
        }

        public ModifyRiskCheckStatusResponse ModifyRiskCheckStatusWithOptions(ModifyRiskCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRiskCheckStatusResponse>(DoRPCRequest("ModifyRiskCheckStatus", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRiskCheckStatusResponse> ModifyRiskCheckStatusWithOptionsAsync(ModifyRiskCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRiskCheckStatusResponse>(await DoRPCRequestAsync("ModifyRiskCheckStatus", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRiskCheckStatusResponse ModifyRiskCheckStatus(ModifyRiskCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRiskCheckStatusWithOptions(request, runtime);
        }

        public async Task<ModifyRiskCheckStatusResponse> ModifyRiskCheckStatusAsync(ModifyRiskCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRiskCheckStatusWithOptionsAsync(request, runtime);
        }

        public ModifyRiskSingleResultStatusResponse ModifyRiskSingleResultStatusWithOptions(ModifyRiskSingleResultStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRiskSingleResultStatusResponse>(DoRPCRequest("ModifyRiskSingleResultStatus", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRiskSingleResultStatusResponse> ModifyRiskSingleResultStatusWithOptionsAsync(ModifyRiskSingleResultStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRiskSingleResultStatusResponse>(await DoRPCRequestAsync("ModifyRiskSingleResultStatus", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRiskSingleResultStatusResponse ModifyRiskSingleResultStatus(ModifyRiskSingleResultStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRiskSingleResultStatusWithOptions(request, runtime);
        }

        public async Task<ModifyRiskSingleResultStatusResponse> ModifyRiskSingleResultStatusAsync(ModifyRiskSingleResultStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRiskSingleResultStatusWithOptionsAsync(request, runtime);
        }

        public ModifySecurityCheckScheduleConfigResponse ModifySecurityCheckScheduleConfigWithOptions(ModifySecurityCheckScheduleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityCheckScheduleConfigResponse>(DoRPCRequest("ModifySecurityCheckScheduleConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityCheckScheduleConfigResponse> ModifySecurityCheckScheduleConfigWithOptionsAsync(ModifySecurityCheckScheduleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityCheckScheduleConfigResponse>(await DoRPCRequestAsync("ModifySecurityCheckScheduleConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityCheckScheduleConfigResponse ModifySecurityCheckScheduleConfig(ModifySecurityCheckScheduleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityCheckScheduleConfigWithOptions(request, runtime);
        }

        public async Task<ModifySecurityCheckScheduleConfigResponse> ModifySecurityCheckScheduleConfigAsync(ModifySecurityCheckScheduleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityCheckScheduleConfigWithOptionsAsync(request, runtime);
        }

        public ModifyStartVulScanResponse ModifyStartVulScanWithOptions(ModifyStartVulScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStartVulScanResponse>(DoRPCRequest("ModifyStartVulScan", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyStartVulScanResponse> ModifyStartVulScanWithOptionsAsync(ModifyStartVulScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStartVulScanResponse>(await DoRPCRequestAsync("ModifyStartVulScan", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyStartVulScanResponse ModifyStartVulScan(ModifyStartVulScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStartVulScanWithOptions(request, runtime);
        }

        public async Task<ModifyStartVulScanResponse> ModifyStartVulScanAsync(ModifyStartVulScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStartVulScanWithOptionsAsync(request, runtime);
        }

        public ModifyTagWithUuidResponse ModifyTagWithUuidWithOptions(ModifyTagWithUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTagWithUuidResponse>(DoRPCRequest("ModifyTagWithUuid", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTagWithUuidResponse> ModifyTagWithUuidWithOptionsAsync(ModifyTagWithUuidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTagWithUuidResponse>(await DoRPCRequestAsync("ModifyTagWithUuid", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTagWithUuidResponse ModifyTagWithUuid(ModifyTagWithUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTagWithUuidWithOptions(request, runtime);
        }

        public async Task<ModifyTagWithUuidResponse> ModifyTagWithUuidAsync(ModifyTagWithUuidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTagWithUuidWithOptionsAsync(request, runtime);
        }

        public ModifyVpcHoneyPotResponse ModifyVpcHoneyPotWithOptions(ModifyVpcHoneyPotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcHoneyPotResponse>(DoRPCRequest("ModifyVpcHoneyPot", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpcHoneyPotResponse> ModifyVpcHoneyPotWithOptionsAsync(ModifyVpcHoneyPotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcHoneyPotResponse>(await DoRPCRequestAsync("ModifyVpcHoneyPot", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpcHoneyPotResponse ModifyVpcHoneyPot(ModifyVpcHoneyPotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcHoneyPotWithOptions(request, runtime);
        }

        public async Task<ModifyVpcHoneyPotResponse> ModifyVpcHoneyPotAsync(ModifyVpcHoneyPotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcHoneyPotWithOptionsAsync(request, runtime);
        }

        public ModifyVulTargetConfigResponse ModifyVulTargetConfigWithOptions(ModifyVulTargetConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVulTargetConfigResponse>(DoRPCRequest("ModifyVulTargetConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVulTargetConfigResponse> ModifyVulTargetConfigWithOptionsAsync(ModifyVulTargetConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVulTargetConfigResponse>(await DoRPCRequestAsync("ModifyVulTargetConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVulTargetConfigResponse ModifyVulTargetConfig(ModifyVulTargetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVulTargetConfigWithOptions(request, runtime);
        }

        public async Task<ModifyVulTargetConfigResponse> ModifyVulTargetConfigAsync(ModifyVulTargetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVulTargetConfigWithOptionsAsync(request, runtime);
        }

        public ModifyWebLockCreateConfigResponse ModifyWebLockCreateConfigWithOptions(ModifyWebLockCreateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockCreateConfigResponse>(DoRPCRequest("ModifyWebLockCreateConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebLockCreateConfigResponse> ModifyWebLockCreateConfigWithOptionsAsync(ModifyWebLockCreateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockCreateConfigResponse>(await DoRPCRequestAsync("ModifyWebLockCreateConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebLockCreateConfigResponse ModifyWebLockCreateConfig(ModifyWebLockCreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebLockCreateConfigWithOptions(request, runtime);
        }

        public async Task<ModifyWebLockCreateConfigResponse> ModifyWebLockCreateConfigAsync(ModifyWebLockCreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebLockCreateConfigWithOptionsAsync(request, runtime);
        }

        public ModifyWebLockDeleteConfigResponse ModifyWebLockDeleteConfigWithOptions(ModifyWebLockDeleteConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockDeleteConfigResponse>(DoRPCRequest("ModifyWebLockDeleteConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebLockDeleteConfigResponse> ModifyWebLockDeleteConfigWithOptionsAsync(ModifyWebLockDeleteConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockDeleteConfigResponse>(await DoRPCRequestAsync("ModifyWebLockDeleteConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebLockDeleteConfigResponse ModifyWebLockDeleteConfig(ModifyWebLockDeleteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebLockDeleteConfigWithOptions(request, runtime);
        }

        public async Task<ModifyWebLockDeleteConfigResponse> ModifyWebLockDeleteConfigAsync(ModifyWebLockDeleteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebLockDeleteConfigWithOptionsAsync(request, runtime);
        }

        public ModifyWebLockStartResponse ModifyWebLockStartWithOptions(ModifyWebLockStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockStartResponse>(DoRPCRequest("ModifyWebLockStart", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebLockStartResponse> ModifyWebLockStartWithOptionsAsync(ModifyWebLockStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockStartResponse>(await DoRPCRequestAsync("ModifyWebLockStart", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebLockStartResponse ModifyWebLockStart(ModifyWebLockStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebLockStartWithOptions(request, runtime);
        }

        public async Task<ModifyWebLockStartResponse> ModifyWebLockStartAsync(ModifyWebLockStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebLockStartWithOptionsAsync(request, runtime);
        }

        public ModifyWebLockUnbindResponse ModifyWebLockUnbindWithOptions(ModifyWebLockUnbindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockUnbindResponse>(DoRPCRequest("ModifyWebLockUnbind", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebLockUnbindResponse> ModifyWebLockUnbindWithOptionsAsync(ModifyWebLockUnbindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockUnbindResponse>(await DoRPCRequestAsync("ModifyWebLockUnbind", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebLockUnbindResponse ModifyWebLockUnbind(ModifyWebLockUnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebLockUnbindWithOptions(request, runtime);
        }

        public async Task<ModifyWebLockUnbindResponse> ModifyWebLockUnbindAsync(ModifyWebLockUnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebLockUnbindWithOptionsAsync(request, runtime);
        }

        public ModifyWebLockUpdateConfigResponse ModifyWebLockUpdateConfigWithOptions(ModifyWebLockUpdateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockUpdateConfigResponse>(DoRPCRequest("ModifyWebLockUpdateConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebLockUpdateConfigResponse> ModifyWebLockUpdateConfigWithOptionsAsync(ModifyWebLockUpdateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebLockUpdateConfigResponse>(await DoRPCRequestAsync("ModifyWebLockUpdateConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebLockUpdateConfigResponse ModifyWebLockUpdateConfig(ModifyWebLockUpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebLockUpdateConfigWithOptions(request, runtime);
        }

        public async Task<ModifyWebLockUpdateConfigResponse> ModifyWebLockUpdateConfigAsync(ModifyWebLockUpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebLockUpdateConfigWithOptionsAsync(request, runtime);
        }

        public OperateSuspiciousTargetConfigResponse OperateSuspiciousTargetConfigWithOptions(OperateSuspiciousTargetConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateSuspiciousTargetConfigResponse>(DoRPCRequest("OperateSuspiciousTargetConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OperateSuspiciousTargetConfigResponse> OperateSuspiciousTargetConfigWithOptionsAsync(OperateSuspiciousTargetConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateSuspiciousTargetConfigResponse>(await DoRPCRequestAsync("OperateSuspiciousTargetConfig", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OperateSuspiciousTargetConfigResponse OperateSuspiciousTargetConfig(OperateSuspiciousTargetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateSuspiciousTargetConfigWithOptions(request, runtime);
        }

        public async Task<OperateSuspiciousTargetConfigResponse> OperateSuspiciousTargetConfigAsync(OperateSuspiciousTargetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateSuspiciousTargetConfigWithOptionsAsync(request, runtime);
        }

        public OperationSuspEventsResponse OperationSuspEventsWithOptions(OperationSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperationSuspEventsResponse>(DoRPCRequest("OperationSuspEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OperationSuspEventsResponse> OperationSuspEventsWithOptionsAsync(OperationSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperationSuspEventsResponse>(await DoRPCRequestAsync("OperationSuspEvents", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OperationSuspEventsResponse OperationSuspEvents(OperationSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperationSuspEventsWithOptions(request, runtime);
        }

        public async Task<OperationSuspEventsResponse> OperationSuspEventsAsync(OperationSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperationSuspEventsWithOptionsAsync(request, runtime);
        }

        public PauseClientResponse PauseClientWithOptions(PauseClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PauseClientResponse>(DoRPCRequest("PauseClient", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PauseClientResponse> PauseClientWithOptionsAsync(PauseClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PauseClientResponse>(await DoRPCRequestAsync("PauseClient", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PauseClientResponse PauseClient(PauseClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseClientWithOptions(request, runtime);
        }

        public async Task<PauseClientResponse> PauseClientAsync(PauseClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseClientWithOptionsAsync(request, runtime);
        }

        public RefreshContainerAssetsResponse RefreshContainerAssetsWithOptions(RefreshContainerAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshContainerAssetsResponse>(DoRPCRequest("RefreshContainerAssets", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshContainerAssetsResponse> RefreshContainerAssetsWithOptionsAsync(RefreshContainerAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshContainerAssetsResponse>(await DoRPCRequestAsync("RefreshContainerAssets", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshContainerAssetsResponse RefreshContainerAssets(RefreshContainerAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshContainerAssetsWithOptions(request, runtime);
        }

        public async Task<RefreshContainerAssetsResponse> RefreshContainerAssetsAsync(RefreshContainerAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshContainerAssetsWithOptionsAsync(request, runtime);
        }

        public RollbackSuspEventQuaraFileResponse RollbackSuspEventQuaraFileWithOptions(RollbackSuspEventQuaraFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackSuspEventQuaraFileResponse>(DoRPCRequest("RollbackSuspEventQuaraFile", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackSuspEventQuaraFileResponse> RollbackSuspEventQuaraFileWithOptionsAsync(RollbackSuspEventQuaraFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackSuspEventQuaraFileResponse>(await DoRPCRequestAsync("RollbackSuspEventQuaraFile", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackSuspEventQuaraFileResponse RollbackSuspEventQuaraFile(RollbackSuspEventQuaraFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackSuspEventQuaraFileWithOptions(request, runtime);
        }

        public async Task<RollbackSuspEventQuaraFileResponse> RollbackSuspEventQuaraFileAsync(RollbackSuspEventQuaraFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackSuspEventQuaraFileWithOptionsAsync(request, runtime);
        }

        public SasInstallCodeResponse SasInstallCodeWithOptions(SasInstallCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SasInstallCodeResponse>(DoRPCRequest("SasInstallCode", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SasInstallCodeResponse> SasInstallCodeWithOptionsAsync(SasInstallCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SasInstallCodeResponse>(await DoRPCRequestAsync("SasInstallCode", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SasInstallCodeResponse SasInstallCode(SasInstallCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SasInstallCodeWithOptions(request, runtime);
        }

        public async Task<SasInstallCodeResponse> SasInstallCodeAsync(SasInstallCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SasInstallCodeWithOptionsAsync(request, runtime);
        }

        public StartBaselineSecurityCheckResponse StartBaselineSecurityCheckWithOptions(StartBaselineSecurityCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBaselineSecurityCheckResponse>(DoRPCRequest("StartBaselineSecurityCheck", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartBaselineSecurityCheckResponse> StartBaselineSecurityCheckWithOptionsAsync(StartBaselineSecurityCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBaselineSecurityCheckResponse>(await DoRPCRequestAsync("StartBaselineSecurityCheck", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartBaselineSecurityCheckResponse StartBaselineSecurityCheck(StartBaselineSecurityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBaselineSecurityCheckWithOptions(request, runtime);
        }

        public async Task<StartBaselineSecurityCheckResponse> StartBaselineSecurityCheckAsync(StartBaselineSecurityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBaselineSecurityCheckWithOptionsAsync(request, runtime);
        }

        public StartImageVulScanResponse StartImageVulScanWithOptions(StartImageVulScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartImageVulScanResponse>(DoRPCRequest("StartImageVulScan", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartImageVulScanResponse> StartImageVulScanWithOptionsAsync(StartImageVulScanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartImageVulScanResponse>(await DoRPCRequestAsync("StartImageVulScan", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartImageVulScanResponse StartImageVulScan(StartImageVulScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartImageVulScanWithOptions(request, runtime);
        }

        public async Task<StartImageVulScanResponse> StartImageVulScanAsync(StartImageVulScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartImageVulScanWithOptionsAsync(request, runtime);
        }

        public ValidateHcWarningsResponse ValidateHcWarningsWithOptions(ValidateHcWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateHcWarningsResponse>(DoRPCRequest("ValidateHcWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ValidateHcWarningsResponse> ValidateHcWarningsWithOptionsAsync(ValidateHcWarningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateHcWarningsResponse>(await DoRPCRequestAsync("ValidateHcWarnings", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ValidateHcWarningsResponse ValidateHcWarnings(ValidateHcWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateHcWarningsWithOptions(request, runtime);
        }

        public async Task<ValidateHcWarningsResponse> ValidateHcWarningsAsync(ValidateHcWarningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateHcWarningsWithOptionsAsync(request, runtime);
        }

    }
}
