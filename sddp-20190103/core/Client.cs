// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sddp20190103.Models;

namespace AlibabaCloud.SDK.Sddp20190103
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hongkong", "sddp-api.cn-hongkong.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sddp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BatchDeleteDataLimitResponse BatchDeleteDataLimitWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<BatchDeleteDataLimitResponse>(DoRPCRequest("BatchDeleteDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteDataLimitResponse> BatchDeleteDataLimitWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<BatchDeleteDataLimitResponse>(await DoRPCRequestAsync("BatchDeleteDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteDataLimitResponse BatchDeleteDataLimit()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDataLimitWithOptions(runtime);
        }

        public async Task<BatchDeleteDataLimitResponse> BatchDeleteDataLimitAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDataLimitWithOptionsAsync(runtime);
        }

        public CreateConfigResponse CreateConfigWithOptions(CreateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConfigResponse>(DoRPCRequest("CreateConfig", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConfigResponse> CreateConfigWithOptionsAsync(CreateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConfigResponse>(await DoRPCRequestAsync("CreateConfig", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateConfigResponse CreateConfig(CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConfigWithOptions(request, runtime);
        }

        public async Task<CreateConfigResponse> CreateConfigAsync(CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConfigWithOptionsAsync(request, runtime);
        }

        public CreateDataLimitResponse CreateDataLimitWithOptions(CreateDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataLimitResponse>(DoRPCRequest("CreateDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataLimitResponse> CreateDataLimitWithOptionsAsync(CreateDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataLimitResponse>(await DoRPCRequestAsync("CreateDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataLimitResponse CreateDataLimit(CreateDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataLimitWithOptions(request, runtime);
        }

        public async Task<CreateDataLimitResponse> CreateDataLimitAsync(CreateDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataLimitWithOptionsAsync(request, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleResponse>(DoRPCRequest("CreateRule", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleResponse>(await DoRPCRequestAsync("CreateRule", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        public CreateScanTaskResponse CreateScanTaskWithOptions(CreateScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScanTaskResponse>(DoRPCRequest("CreateScanTask", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScanTaskResponse> CreateScanTaskWithOptionsAsync(CreateScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScanTaskResponse>(await DoRPCRequestAsync("CreateScanTask", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScanTaskResponse CreateScanTask(CreateScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScanTaskWithOptions(request, runtime);
        }

        public async Task<CreateScanTaskResponse> CreateScanTaskAsync(CreateScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScanTaskWithOptionsAsync(request, runtime);
        }

        public DeleteDataLimitResponse DeleteDataLimitWithOptions(DeleteDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataLimitResponse>(DoRPCRequest("DeleteDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataLimitResponse> DeleteDataLimitWithOptionsAsync(DeleteDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataLimitResponse>(await DoRPCRequestAsync("DeleteDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDataLimitResponse DeleteDataLimit(DeleteDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLimitWithOptions(request, runtime);
        }

        public async Task<DeleteDataLimitResponse> DeleteDataLimitAsync(DeleteDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLimitWithOptionsAsync(request, runtime);
        }

        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleResponse>(DoRPCRequest("DeleteRule", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await DoRPCRequestAsync("DeleteRule", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        public DescribeAccountDetailResponse DescribeAccountDetailWithOptions(DescribeAccountDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountDetailResponse>(DoRPCRequest("DescribeAccountDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountDetailResponse> DescribeAccountDetailWithOptionsAsync(DescribeAccountDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountDetailResponse>(await DoRPCRequestAsync("DescribeAccountDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountDetailResponse DescribeAccountDetail(DescribeAccountDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountDetailWithOptions(request, runtime);
        }

        public async Task<DescribeAccountDetailResponse> DescribeAccountDetailAsync(DescribeAccountDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountDetailWithOptionsAsync(request, runtime);
        }

        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(DoRPCRequest("DescribeAccounts", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await DoRPCRequestAsync("DescribeAccounts", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountsResponse DescribeAccounts(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeAccountsResponse> DescribeAccountsAsync(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeColumnsResponse DescribeColumnsWithOptions(DescribeColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeColumnsResponse>(DoRPCRequest("DescribeColumns", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeColumnsResponse> DescribeColumnsWithOptionsAsync(DescribeColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeColumnsResponse>(await DoRPCRequestAsync("DescribeColumns", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeColumnsResponse DescribeColumns(DescribeColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeColumnsWithOptions(request, runtime);
        }

        public async Task<DescribeColumnsResponse> DescribeColumnsAsync(DescribeColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeColumnsWithOptionsAsync(request, runtime);
        }

        public DescribeConfigsResponse DescribeConfigsWithOptions(DescribeConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConfigsResponse>(DoRPCRequest("DescribeConfigs", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConfigsResponse> DescribeConfigsWithOptionsAsync(DescribeConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConfigsResponse>(await DoRPCRequestAsync("DescribeConfigs", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConfigsResponse DescribeConfigs(DescribeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeConfigsResponse> DescribeConfigsAsync(DescribeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDataAssetsResponse DescribeDataAssetsWithOptions(DescribeDataAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataAssetsResponse>(DoRPCRequest("DescribeDataAssets", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataAssetsResponse> DescribeDataAssetsWithOptionsAsync(DescribeDataAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataAssetsResponse>(await DoRPCRequestAsync("DescribeDataAssets", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataAssetsResponse DescribeDataAssets(DescribeDataAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataAssetsWithOptions(request, runtime);
        }

        public async Task<DescribeDataAssetsResponse> DescribeDataAssetsAsync(DescribeDataAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataAssetsWithOptionsAsync(request, runtime);
        }

        public DescribeDataLimitDetailResponse DescribeDataLimitDetailWithOptions(DescribeDataLimitDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitDetailResponse>(DoRPCRequest("DescribeDataLimitDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataLimitDetailResponse> DescribeDataLimitDetailWithOptionsAsync(DescribeDataLimitDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitDetailResponse>(await DoRPCRequestAsync("DescribeDataLimitDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataLimitDetailResponse DescribeDataLimitDetail(DescribeDataLimitDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDataLimitDetailResponse> DescribeDataLimitDetailAsync(DescribeDataLimitDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDataLimitsResponse DescribeDataLimitsWithOptions(DescribeDataLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitsResponse>(DoRPCRequest("DescribeDataLimits", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataLimitsResponse> DescribeDataLimitsWithOptionsAsync(DescribeDataLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitsResponse>(await DoRPCRequestAsync("DescribeDataLimits", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataLimitsResponse DescribeDataLimits(DescribeDataLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitsWithOptions(request, runtime);
        }

        public async Task<DescribeDataLimitsResponse> DescribeDataLimitsAsync(DescribeDataLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitsWithOptionsAsync(request, runtime);
        }

        public DescribeDataLimitSetResponse DescribeDataLimitSetWithOptions(DescribeDataLimitSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitSetResponse>(DoRPCRequest("DescribeDataLimitSet", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataLimitSetResponse> DescribeDataLimitSetWithOptionsAsync(DescribeDataLimitSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitSetResponse>(await DoRPCRequestAsync("DescribeDataLimitSet", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataLimitSetResponse DescribeDataLimitSet(DescribeDataLimitSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitSetWithOptions(request, runtime);
        }

        public async Task<DescribeDataLimitSetResponse> DescribeDataLimitSetAsync(DescribeDataLimitSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitSetWithOptionsAsync(request, runtime);
        }

        public DescribeDataLimitsInstanceDimResponse DescribeDataLimitsInstanceDimWithOptions(DescribeDataLimitsInstanceDimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitsInstanceDimResponse>(DoRPCRequest("DescribeDataLimitsInstanceDim", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataLimitsInstanceDimResponse> DescribeDataLimitsInstanceDimWithOptionsAsync(DescribeDataLimitsInstanceDimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataLimitsInstanceDimResponse>(await DoRPCRequestAsync("DescribeDataLimitsInstanceDim", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataLimitsInstanceDimResponse DescribeDataLimitsInstanceDim(DescribeDataLimitsInstanceDimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitsInstanceDimWithOptions(request, runtime);
        }

        public async Task<DescribeDataLimitsInstanceDimResponse> DescribeDataLimitsInstanceDimAsync(DescribeDataLimitsInstanceDimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitsInstanceDimWithOptionsAsync(request, runtime);
        }

        public DescribeDataMaskingRunHistoryResponse DescribeDataMaskingRunHistoryWithOptions(DescribeDataMaskingRunHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataMaskingRunHistoryResponse>(DoRPCRequest("DescribeDataMaskingRunHistory", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataMaskingRunHistoryResponse> DescribeDataMaskingRunHistoryWithOptionsAsync(DescribeDataMaskingRunHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataMaskingRunHistoryResponse>(await DoRPCRequestAsync("DescribeDataMaskingRunHistory", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataMaskingRunHistoryResponse DescribeDataMaskingRunHistory(DescribeDataMaskingRunHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataMaskingRunHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeDataMaskingRunHistoryResponse> DescribeDataMaskingRunHistoryAsync(DescribeDataMaskingRunHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataMaskingRunHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeDataMaskingTasksResponse DescribeDataMaskingTasksWithOptions(DescribeDataMaskingTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataMaskingTasksResponse>(DoRPCRequest("DescribeDataMaskingTasks", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataMaskingTasksResponse> DescribeDataMaskingTasksWithOptionsAsync(DescribeDataMaskingTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataMaskingTasksResponse>(await DoRPCRequestAsync("DescribeDataMaskingTasks", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataMaskingTasksResponse DescribeDataMaskingTasks(DescribeDataMaskingTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataMaskingTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDataMaskingTasksResponse> DescribeDataMaskingTasksAsync(DescribeDataMaskingTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataMaskingTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDataTotalCountResponse DescribeDataTotalCountWithOptions(DescribeDataTotalCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataTotalCountResponse>(DoRPCRequest("DescribeDataTotalCount", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataTotalCountResponse> DescribeDataTotalCountWithOptionsAsync(DescribeDataTotalCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataTotalCountResponse>(await DoRPCRequestAsync("DescribeDataTotalCount", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataTotalCountResponse DescribeDataTotalCount(DescribeDataTotalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataTotalCountWithOptions(request, runtime);
        }

        public async Task<DescribeDataTotalCountResponse> DescribeDataTotalCountAsync(DescribeDataTotalCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataTotalCountWithOptionsAsync(request, runtime);
        }

        public DescribeEventDetailResponse DescribeEventDetailWithOptions(DescribeEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventDetailResponse>(DoRPCRequest("DescribeEventDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventDetailResponse> DescribeEventDetailWithOptionsAsync(DescribeEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventDetailResponse>(await DoRPCRequestAsync("DescribeEventDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventDetailResponse DescribeEventDetail(DescribeEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventDetailWithOptions(request, runtime);
        }

        public async Task<DescribeEventDetailResponse> DescribeEventDetailAsync(DescribeEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventDetailWithOptionsAsync(request, runtime);
        }

        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventsResponse>(DoRPCRequest("DescribeEvents", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await DoRPCRequestAsync("DescribeEvents", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsWithOptions(request, runtime);
        }

        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsWithOptionsAsync(request, runtime);
        }

        public DescribeEventTopResponse DescribeEventTopWithOptions(DescribeEventTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventTopResponse>(DoRPCRequest("DescribeEventTop", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventTopResponse> DescribeEventTopWithOptionsAsync(DescribeEventTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventTopResponse>(await DoRPCRequestAsync("DescribeEventTop", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventTopResponse DescribeEventTop(DescribeEventTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventTopWithOptions(request, runtime);
        }

        public async Task<DescribeEventTopResponse> DescribeEventTopAsync(DescribeEventTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventTopWithOptionsAsync(request, runtime);
        }

        public DescribeEventTypesResponse DescribeEventTypesWithOptions(DescribeEventTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventTypesResponse>(DoRPCRequest("DescribeEventTypes", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventTypesResponse> DescribeEventTypesWithOptionsAsync(DescribeEventTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventTypesResponse>(await DoRPCRequestAsync("DescribeEventTypes", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventTypesResponse DescribeEventTypes(DescribeEventTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventTypesWithOptions(request, runtime);
        }

        public async Task<DescribeEventTypesResponse> DescribeEventTypesAsync(DescribeEventTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventTypesWithOptionsAsync(request, runtime);
        }

        public DescribeEventTypesDetailResponse DescribeEventTypesDetailWithOptions(DescribeEventTypesDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventTypesDetailResponse>(DoRPCRequest("DescribeEventTypesDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEventTypesDetailResponse> DescribeEventTypesDetailWithOptionsAsync(DescribeEventTypesDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEventTypesDetailResponse>(await DoRPCRequestAsync("DescribeEventTypesDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEventTypesDetailResponse DescribeEventTypesDetail(DescribeEventTypesDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventTypesDetailWithOptions(request, runtime);
        }

        public async Task<DescribeEventTypesDetailResponse> DescribeEventTypesDetailAsync(DescribeEventTypesDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventTypesDetailWithOptionsAsync(request, runtime);
        }

        public DescribeInstancePortraitResponse DescribeInstancePortraitWithOptions(DescribeInstancePortraitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePortraitResponse>(DoRPCRequest("DescribeInstancePortrait", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancePortraitResponse> DescribeInstancePortraitWithOptionsAsync(DescribeInstancePortraitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePortraitResponse>(await DoRPCRequestAsync("DescribeInstancePortrait", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancePortraitResponse DescribeInstancePortrait(DescribeInstancePortraitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancePortraitWithOptions(request, runtime);
        }

        public async Task<DescribeInstancePortraitResponse> DescribeInstancePortraitAsync(DescribeInstancePortraitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancePortraitWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSourcesResponse DescribeInstanceSourcesWithOptions(DescribeInstanceSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSourcesResponse>(DoRPCRequest("DescribeInstanceSources", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSourcesResponse> DescribeInstanceSourcesWithOptionsAsync(DescribeInstanceSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSourcesResponse>(await DoRPCRequestAsync("DescribeInstanceSources", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSourcesResponse DescribeInstanceSources(DescribeInstanceSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSourcesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSourcesResponse> DescribeInstanceSourcesAsync(DescribeInstanceSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSourcesWithOptionsAsync(request, runtime);
        }

        public DescribeOssObjectDetailResponse DescribeOssObjectDetailWithOptions(DescribeOssObjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssObjectDetailResponse>(DoRPCRequest("DescribeOssObjectDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOssObjectDetailResponse> DescribeOssObjectDetailWithOptionsAsync(DescribeOssObjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssObjectDetailResponse>(await DoRPCRequestAsync("DescribeOssObjectDetail", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOssObjectDetailResponse DescribeOssObjectDetail(DescribeOssObjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssObjectDetailWithOptions(request, runtime);
        }

        public async Task<DescribeOssObjectDetailResponse> DescribeOssObjectDetailAsync(DescribeOssObjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssObjectDetailWithOptionsAsync(request, runtime);
        }

        public DescribeOssObjectsResponse DescribeOssObjectsWithOptions(DescribeOssObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssObjectsResponse>(DoRPCRequest("DescribeOssObjects", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOssObjectsResponse> DescribeOssObjectsWithOptionsAsync(DescribeOssObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssObjectsResponse>(await DoRPCRequestAsync("DescribeOssObjects", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOssObjectsResponse DescribeOssObjects(DescribeOssObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssObjectsWithOptions(request, runtime);
        }

        public async Task<DescribeOssObjectsResponse> DescribeOssObjectsAsync(DescribeOssObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssObjectsWithOptionsAsync(request, runtime);
        }

        public DescribePackagesResponse DescribePackagesWithOptions(DescribePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePackagesResponse>(DoRPCRequest("DescribePackages", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePackagesResponse> DescribePackagesWithOptionsAsync(DescribePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePackagesResponse>(await DoRPCRequestAsync("DescribePackages", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePackagesResponse DescribePackages(DescribePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackagesWithOptions(request, runtime);
        }

        public async Task<DescribePackagesResponse> DescribePackagesAsync(DescribePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackagesWithOptionsAsync(request, runtime);
        }

        public DescribeRiskLevelsResponse DescribeRiskLevelsWithOptions(DescribeRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskLevelsResponse>(DoRPCRequest("DescribeRiskLevels", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRiskLevelsResponse> DescribeRiskLevelsWithOptionsAsync(DescribeRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRiskLevelsResponse>(await DoRPCRequestAsync("DescribeRiskLevels", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRiskLevelsResponse DescribeRiskLevels(DescribeRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskLevelsWithOptions(request, runtime);
        }

        public async Task<DescribeRiskLevelsResponse> DescribeRiskLevelsAsync(DescribeRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskLevelsWithOptionsAsync(request, runtime);
        }

        public DescribeRuleCategoryResponse DescribeRuleCategoryWithOptions(DescribeRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRuleCategoryResponse>(DoRPCRequest("DescribeRuleCategory", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRuleCategoryResponse> DescribeRuleCategoryWithOptionsAsync(DescribeRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRuleCategoryResponse>(await DoRPCRequestAsync("DescribeRuleCategory", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRuleCategoryResponse DescribeRuleCategory(DescribeRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleCategoryWithOptions(request, runtime);
        }

        public async Task<DescribeRuleCategoryResponse> DescribeRuleCategoryAsync(DescribeRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleCategoryWithOptionsAsync(request, runtime);
        }

        public DescribeRulesResponse DescribeRulesWithOptions(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRulesResponse>(DoRPCRequest("DescribeRules", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRulesResponse> DescribeRulesWithOptionsAsync(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRulesResponse>(await DoRPCRequestAsync("DescribeRules", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRulesWithOptions(request, runtime);
        }

        public async Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRulesWithOptionsAsync(request, runtime);
        }

        public DescribeTablesResponse DescribeTablesWithOptions(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTablesResponse>(DoRPCRequest("DescribeTables", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTablesResponse> DescribeTablesWithOptionsAsync(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTablesResponse>(await DoRPCRequestAsync("DescribeTables", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTablesResponse DescribeTables(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTablesWithOptions(request, runtime);
        }

        public async Task<DescribeTablesResponse> DescribeTablesAsync(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTablesWithOptionsAsync(request, runtime);
        }

        public DescribeUserCountResponse DescribeUserCountWithOptions(DescribeUserCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCountResponse>(DoRPCRequest("DescribeUserCount", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserCountResponse> DescribeUserCountWithOptionsAsync(DescribeUserCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserCountResponse>(await DoRPCRequestAsync("DescribeUserCount", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserCountResponse DescribeUserCount(DescribeUserCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserCountWithOptions(request, runtime);
        }

        public async Task<DescribeUserCountResponse> DescribeUserCountAsync(DescribeUserCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserCountWithOptionsAsync(request, runtime);
        }

        public DescribeUserStatusResponse DescribeUserStatusWithOptions(DescribeUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserStatusResponse>(DoRPCRequest("DescribeUserStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserStatusResponse> DescribeUserStatusWithOptionsAsync(DescribeUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserStatusResponse>(await DoRPCRequestAsync("DescribeUserStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserStatusResponse DescribeUserStatus(DescribeUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserStatusResponse> DescribeUserStatusAsync(DescribeUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserStatusWithOptionsAsync(request, runtime);
        }

        public DisableUserConfigResponse DisableUserConfigWithOptions(DisableUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableUserConfigResponse>(DoRPCRequest("DisableUserConfig", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableUserConfigResponse> DisableUserConfigWithOptionsAsync(DisableUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableUserConfigResponse>(await DoRPCRequestAsync("DisableUserConfig", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableUserConfigResponse DisableUserConfig(DisableUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableUserConfigWithOptions(request, runtime);
        }

        public async Task<DisableUserConfigResponse> DisableUserConfigAsync(DisableUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableUserConfigWithOptionsAsync(request, runtime);
        }

        public ExecDatamaskResponse ExecDatamaskWithOptions(ExecDatamaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecDatamaskResponse>(DoRPCRequest("ExecDatamask", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecDatamaskResponse> ExecDatamaskWithOptionsAsync(ExecDatamaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecDatamaskResponse>(await DoRPCRequestAsync("ExecDatamask", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecDatamaskResponse ExecDatamask(ExecDatamaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecDatamaskWithOptions(request, runtime);
        }

        public async Task<ExecDatamaskResponse> ExecDatamaskAsync(ExecDatamaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecDatamaskWithOptionsAsync(request, runtime);
        }

        public ManualTriggerMaskingProcessResponse ManualTriggerMaskingProcessWithOptions(ManualTriggerMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ManualTriggerMaskingProcessResponse>(DoRPCRequest("ManualTriggerMaskingProcess", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ManualTriggerMaskingProcessResponse> ManualTriggerMaskingProcessWithOptionsAsync(ManualTriggerMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ManualTriggerMaskingProcessResponse>(await DoRPCRequestAsync("ManualTriggerMaskingProcess", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ManualTriggerMaskingProcessResponse ManualTriggerMaskingProcess(ManualTriggerMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManualTriggerMaskingProcessWithOptions(request, runtime);
        }

        public async Task<ManualTriggerMaskingProcessResponse> ManualTriggerMaskingProcessAsync(ManualTriggerMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManualTriggerMaskingProcessWithOptionsAsync(request, runtime);
        }

        public ModifyDataLimitResponse ModifyDataLimitWithOptions(ModifyDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataLimitResponse>(DoRPCRequest("ModifyDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDataLimitResponse> ModifyDataLimitWithOptionsAsync(ModifyDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataLimitResponse>(await DoRPCRequestAsync("ModifyDataLimit", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDataLimitResponse ModifyDataLimit(ModifyDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataLimitWithOptions(request, runtime);
        }

        public async Task<ModifyDataLimitResponse> ModifyDataLimitAsync(ModifyDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataLimitWithOptionsAsync(request, runtime);
        }

        public ModifyDefaultLevelResponse ModifyDefaultLevelWithOptions(ModifyDefaultLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDefaultLevelResponse>(DoRPCRequest("ModifyDefaultLevel", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDefaultLevelResponse> ModifyDefaultLevelWithOptionsAsync(ModifyDefaultLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDefaultLevelResponse>(await DoRPCRequestAsync("ModifyDefaultLevel", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDefaultLevelResponse ModifyDefaultLevel(ModifyDefaultLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefaultLevelWithOptions(request, runtime);
        }

        public async Task<ModifyDefaultLevelResponse> ModifyDefaultLevelAsync(ModifyDefaultLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefaultLevelWithOptionsAsync(request, runtime);
        }

        public ModifyEventStatusResponse ModifyEventStatusWithOptions(ModifyEventStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEventStatusResponse>(DoRPCRequest("ModifyEventStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEventStatusResponse> ModifyEventStatusWithOptionsAsync(ModifyEventStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEventStatusResponse>(await DoRPCRequestAsync("ModifyEventStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEventStatusResponse ModifyEventStatus(ModifyEventStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEventStatusWithOptions(request, runtime);
        }

        public async Task<ModifyEventStatusResponse> ModifyEventStatusAsync(ModifyEventStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEventStatusWithOptionsAsync(request, runtime);
        }

        public ModifyEventTypeStatusResponse ModifyEventTypeStatusWithOptions(ModifyEventTypeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEventTypeStatusResponse>(DoRPCRequest("ModifyEventTypeStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEventTypeStatusResponse> ModifyEventTypeStatusWithOptionsAsync(ModifyEventTypeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEventTypeStatusResponse>(await DoRPCRequestAsync("ModifyEventTypeStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEventTypeStatusResponse ModifyEventTypeStatus(ModifyEventTypeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEventTypeStatusWithOptions(request, runtime);
        }

        public async Task<ModifyEventTypeStatusResponse> ModifyEventTypeStatusAsync(ModifyEventTypeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEventTypeStatusWithOptionsAsync(request, runtime);
        }

        public ModifyRuleResponse ModifyRuleWithOptions(ModifyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRuleResponse>(DoRPCRequest("ModifyRule", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRuleResponse> ModifyRuleWithOptionsAsync(ModifyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRuleResponse>(await DoRPCRequestAsync("ModifyRule", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRuleResponse ModifyRule(ModifyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRuleWithOptions(request, runtime);
        }

        public async Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRuleWithOptionsAsync(request, runtime);
        }

        public ModifyRuleStatusResponse ModifyRuleStatusWithOptions(ModifyRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRuleStatusResponse>(DoRPCRequest("ModifyRuleStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRuleStatusResponse> ModifyRuleStatusWithOptionsAsync(ModifyRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRuleStatusResponse>(await DoRPCRequestAsync("ModifyRuleStatus", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRuleStatusResponse ModifyRuleStatus(ModifyRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRuleStatusWithOptions(request, runtime);
        }

        public async Task<ModifyRuleStatusResponse> ModifyRuleStatusAsync(ModifyRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRuleStatusWithOptionsAsync(request, runtime);
        }

        public StopMaskingProcessResponse StopMaskingProcessWithOptions(StopMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMaskingProcessResponse>(DoRPCRequest("StopMaskingProcess", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMaskingProcessResponse> StopMaskingProcessWithOptionsAsync(StopMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMaskingProcessResponse>(await DoRPCRequestAsync("StopMaskingProcess", "2019-01-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopMaskingProcessResponse StopMaskingProcess(StopMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMaskingProcessWithOptions(request, runtime);
        }

        public async Task<StopMaskingProcessResponse> StopMaskingProcessAsync(StopMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMaskingProcessWithOptionsAsync(request, runtime);
        }

    }
}
