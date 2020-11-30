// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddosbgp20171120.Models;

namespace AlibabaCloud.SDK.Ddosbgp20171120
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ddosbgp.aliyuncs.com"},
                {"cn-beijing", "ddosbgp.aliyuncs.com"},
                {"cn-zhangjiakou", "ddosbgp.aliyuncs.com"},
                {"cn-huhehaote", "ddosbgp.aliyuncs.com"},
                {"cn-hangzhou", "ddosbgp.aliyuncs.com"},
                {"cn-shanghai", "ddosbgp.aliyuncs.com"},
                {"cn-shenzhen", "ddosbgp.aliyuncs.com"},
                {"ap-northeast-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"cn-chengdu", "ddosbgp.aliyuncs.com"},
                {"eu-central-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "ddosbgp.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "ddosbgp.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ddosbgp.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ddosbgp.aliyuncs.com"},
                {"cn-north-2-gov-1", "ddosbgp.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddosbgp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public DescribeOnDemandInstanceResponse DescribeOnDemandInstanceWithOptions(DescribeOnDemandInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOnDemandInstanceResponse>(DoRequest("DescribeOnDemandInstance", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOnDemandInstanceResponse> DescribeOnDemandInstanceWithOptionsAsync(DescribeOnDemandInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOnDemandInstanceResponse>(await DoRequestAsync("DescribeOnDemandInstance", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeOnDemandInstanceResponse DescribeOnDemandInstance(DescribeOnDemandInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOnDemandInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeOnDemandInstanceResponse> DescribeOnDemandInstanceAsync(DescribeOnDemandInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOnDemandInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyOnDemaondDefenseStatusResponse ModifyOnDemaondDefenseStatusWithOptions(ModifyOnDemaondDefenseStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyOnDemaondDefenseStatusResponse>(DoRequest("ModifyOnDemaondDefenseStatus", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyOnDemaondDefenseStatusResponse> ModifyOnDemaondDefenseStatusWithOptionsAsync(ModifyOnDemaondDefenseStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyOnDemaondDefenseStatusResponse>(await DoRequestAsync("ModifyOnDemaondDefenseStatus", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public ModifyOnDemaondDefenseStatusResponse ModifyOnDemaondDefenseStatus(ModifyOnDemaondDefenseStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOnDemaondDefenseStatusWithOptions(request, runtime);
        }

        public async Task<ModifyOnDemaondDefenseStatusResponse> ModifyOnDemaondDefenseStatusAsync(ModifyOnDemaondDefenseStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOnDemaondDefenseStatusWithOptionsAsync(request, runtime);
        }

        public DescribeOpEntitiesResponse DescribeOpEntitiesWithOptions(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(DoRequest("DescribeOpEntities", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesWithOptionsAsync(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOpEntitiesResponse>(await DoRequestAsync("DescribeOpEntities", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeOpEntitiesResponse DescribeOpEntities(DescribeOpEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOpEntitiesWithOptions(request, runtime);
        }

        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesAsync(DescribeOpEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOpEntitiesWithOptionsAsync(request, runtime);
        }

        public DescribePackPaidTrafficResponse DescribePackPaidTrafficWithOptions(DescribePackPaidTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackPaidTrafficResponse>(DoRequest("DescribePackPaidTraffic", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePackPaidTrafficResponse> DescribePackPaidTrafficWithOptionsAsync(DescribePackPaidTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackPaidTrafficResponse>(await DoRequestAsync("DescribePackPaidTraffic", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribePackPaidTrafficResponse DescribePackPaidTraffic(DescribePackPaidTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackPaidTrafficWithOptions(request, runtime);
        }

        public async Task<DescribePackPaidTrafficResponse> DescribePackPaidTrafficAsync(DescribePackPaidTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackPaidTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackUsageResponse DescribeResourcePackUsageWithOptions(DescribeResourcePackUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackUsageResponse>(DoRequest("DescribeResourcePackUsage", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeResourcePackUsageResponse> DescribeResourcePackUsageWithOptionsAsync(DescribeResourcePackUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackUsageResponse>(await DoRequestAsync("DescribeResourcePackUsage", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeResourcePackUsageResponse DescribeResourcePackUsage(DescribeResourcePackUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackUsageWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackUsageResponse> DescribeResourcePackUsageAsync(DescribeResourcePackUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackUsageWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackStatisticsResponse DescribeResourcePackStatisticsWithOptions(DescribeResourcePackStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackStatisticsResponse>(DoRequest("DescribeResourcePackStatistics", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeResourcePackStatisticsResponse> DescribeResourcePackStatisticsWithOptionsAsync(DescribeResourcePackStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackStatisticsResponse>(await DoRequestAsync("DescribeResourcePackStatistics", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeResourcePackStatisticsResponse DescribeResourcePackStatistics(DescribeResourcePackStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackStatisticsResponse> DescribeResourcePackStatisticsAsync(DescribeResourcePackStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeResourcePackInstancesResponse DescribeResourcePackInstancesWithOptions(DescribeResourcePackInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackInstancesResponse>(DoRequest("DescribeResourcePackInstances", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeResourcePackInstancesResponse> DescribeResourcePackInstancesWithOptionsAsync(DescribeResourcePackInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeResourcePackInstancesResponse>(await DoRequestAsync("DescribeResourcePackInstances", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeResourcePackInstancesResponse DescribeResourcePackInstances(DescribeResourcePackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeResourcePackInstancesResponse> DescribeResourcePackInstancesAsync(DescribeResourcePackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackInstancesWithOptionsAsync(request, runtime);
        }

        public DeleteBlackholeResponse DeleteBlackholeWithOptions(DeleteBlackholeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBlackholeResponse>(DoRequest("DeleteBlackhole", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteBlackholeResponse> DeleteBlackholeWithOptionsAsync(DeleteBlackholeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBlackholeResponse>(await DoRequestAsync("DeleteBlackhole", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteBlackholeResponse DeleteBlackhole(DeleteBlackholeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBlackholeWithOptions(request, runtime);
        }

        public async Task<DeleteBlackholeResponse> DeleteBlackholeAsync(DeleteBlackholeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBlackholeWithOptionsAsync(request, runtime);
        }

        public CheckGrantResponse CheckGrantWithOptions(CheckGrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckGrantResponse>(DoRequest("CheckGrant", "HTTPS", "GET", "2017-11-20", "AK", request.ToMap(), null, runtime));
        }

        public async Task<CheckGrantResponse> CheckGrantWithOptionsAsync(CheckGrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckGrantResponse>(await DoRequestAsync("CheckGrant", "HTTPS", "GET", "2017-11-20", "AK", request.ToMap(), null, runtime));
        }

        public CheckGrantResponse CheckGrant(CheckGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckGrantWithOptions(request, runtime);
        }

        public async Task<CheckGrantResponse> CheckGrantAsync(CheckGrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckGrantWithOptionsAsync(request, runtime);
        }

        public DeleteProductResponse DeleteProductWithOptions(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductResponse>(DoRequest("DeleteProduct", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductResponse>(await DoRequestAsync("DeleteProduct", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductWithOptions(request, runtime);
        }

        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductWithOptionsAsync(request, runtime);
        }

        public AddProductResponse AddProductWithOptions(AddProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProductResponse>(DoRequest("AddProduct", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddProductResponse> AddProductWithOptionsAsync(AddProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProductResponse>(await DoRequestAsync("AddProduct", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public AddProductResponse AddProduct(AddProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProductWithOptions(request, runtime);
        }

        public async Task<AddProductResponse> AddProductAsync(AddProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProductWithOptionsAsync(request, runtime);
        }

        public AddIpResponse AddIpWithOptions(AddIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddIpResponse>(DoRequest("AddIp", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddIpResponse> AddIpWithOptionsAsync(AddIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddIpResponse>(await DoRequestAsync("AddIp", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public AddIpResponse AddIp(AddIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIpWithOptions(request, runtime);
        }

        public async Task<AddIpResponse> AddIpAsync(AddIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIpWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceListResponse DescribeInstanceListWithOptions(DescribeInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceListResponse>(DoRequest("DescribeInstanceList", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstanceListResponse> DescribeInstanceListWithOptionsAsync(DescribeInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstanceListResponse>(await DoRequestAsync("DescribeInstanceList", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstanceListResponse DescribeInstanceList(DescribeInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceListResponse> DescribeInstanceListAsync(DescribeInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeTopTrafficResponse DescribeTopTrafficWithOptions(DescribeTopTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTopTrafficResponse>(DoRequest("DescribeTopTraffic", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeTopTrafficResponse> DescribeTopTrafficWithOptionsAsync(DescribeTopTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTopTrafficResponse>(await DoRequestAsync("DescribeTopTraffic", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeTopTrafficResponse DescribeTopTraffic(DescribeTopTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeTopTrafficResponse> DescribeTopTrafficAsync(DescribeTopTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeDdosEventResponse DescribeDdosEventWithOptions(DescribeDdosEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDdosEventResponse>(DoRequest("DescribeDdosEvent", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDdosEventResponse> DescribeDdosEventWithOptionsAsync(DescribeDdosEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDdosEventResponse>(await DoRequestAsync("DescribeDdosEvent", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDdosEventResponse DescribeDdosEvent(DescribeDdosEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosEventWithOptions(request, runtime);
        }

        public async Task<DescribeDdosEventResponse> DescribeDdosEventAsync(DescribeDdosEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosEventWithOptionsAsync(request, runtime);
        }

        public DescribeTrafficResponse DescribeTrafficWithOptions(DescribeTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTrafficResponse>(DoRequest("DescribeTraffic", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeTrafficResponse> DescribeTrafficWithOptionsAsync(DescribeTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeTrafficResponse>(await DoRequestAsync("DescribeTraffic", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribeTrafficResponse DescribeTraffic(DescribeTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeTrafficResponse> DescribeTrafficAsync(DescribeTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrafficWithOptionsAsync(request, runtime);
        }

        public DeleteIpResponse DeleteIpWithOptions(DeleteIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteIpResponse>(DoRequest("DeleteIp", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteIpResponse> DeleteIpWithOptionsAsync(DeleteIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteIpResponse>(await DoRequestAsync("DeleteIp", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteIpResponse DeleteIp(DeleteIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpWithOptions(request, runtime);
        }

        public async Task<DeleteIpResponse> DeleteIpAsync(DeleteIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpWithOptionsAsync(request, runtime);
        }

        public DescribePackResponse DescribePackWithOptions(DescribePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackResponse>(DoRequest("DescribePack", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePackResponse> DescribePackWithOptionsAsync(DescribePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackResponse>(await DoRequestAsync("DescribePack", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribePackResponse DescribePack(DescribePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackWithOptions(request, runtime);
        }

        public async Task<DescribePackResponse> DescribePackAsync(DescribePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackWithOptionsAsync(request, runtime);
        }

        public DescribePackListResponse DescribePackListWithOptions(DescribePackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackListResponse>(DoRequest("DescribePackList", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribePackListResponse> DescribePackListWithOptionsAsync(DescribePackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribePackListResponse>(await DoRequestAsync("DescribePackList", "HTTPS", "POST", "2017-11-20", "AK", null, request.ToMap(), runtime));
        }

        public DescribePackListResponse DescribePackList(DescribePackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackListWithOptions(request, runtime);
        }

        public async Task<DescribePackListResponse> DescribePackListAsync(DescribePackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackListWithOptionsAsync(request, runtime);
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
