// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hitsdb20170601.Models;

namespace AlibabaCloud.SDK.Hitsdb20170601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "hitsdb.aliyuncs.com"},
                {"cn-beijing", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou", "hitsdb.aliyuncs.com"},
                {"cn-shanghai", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen", "hitsdb.aliyuncs.com"},
                {"cn-hongkong", "hitsdb.aliyuncs.com"},
                {"ap-southeast-1", "hitsdb.aliyuncs.com"},
                {"us-west-1", "hitsdb.aliyuncs.com"},
                {"us-east-1", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "hitsdb.aliyuncs.com"},
                {"ap-northeast-2-pop", "hitsdb.aliyuncs.com"},
                {"cn-beijing-finance-1", "hitsdb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "hitsdb.aliyuncs.com"},
                {"cn-beijing-gov-1", "hitsdb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "hitsdb.aliyuncs.com"},
                {"cn-chengdu", "hitsdb.aliyuncs.com"},
                {"cn-edge-1", "hitsdb.aliyuncs.com"},
                {"cn-fujian", "hitsdb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-finance", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "hitsdb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "hitsdb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "hitsdb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "hitsdb.aliyuncs.com"},
                {"cn-qingdao-nebula", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-inner", "hitsdb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-inner", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "hitsdb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "hitsdb.aliyuncs.com"},
                {"cn-wuhan", "hitsdb.aliyuncs.com"},
                {"cn-wulanchabu", "hitsdb.aliyuncs.com"},
                {"cn-yushanfang", "hitsdb.aliyuncs.com"},
                {"cn-zhangbei", "hitsdb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "hitsdb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "hitsdb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "hitsdb.aliyuncs.com"},
                {"eu-west-1-oxs", "hitsdb.aliyuncs.com"},
                {"me-east-1", "hitsdb.aliyuncs.com"},
                {"rus-west-1-pop", "hitsdb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("hitsdb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateHiTSDBInstanceResponse CreateHiTSDBInstanceWithOptions(CreateHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHiTSDBInstanceResponse>(DoRPCRequest("CreateHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHiTSDBInstanceResponse> CreateHiTSDBInstanceWithOptionsAsync(CreateHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHiTSDBInstanceResponse>(await DoRPCRequestAsync("CreateHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHiTSDBInstanceResponse CreateHiTSDBInstance(CreateHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHiTSDBInstanceWithOptions(request, runtime);
        }

        public async Task<CreateHiTSDBInstanceResponse> CreateHiTSDBInstanceAsync(CreateHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHiTSDBInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteHiTSDBInstanceResponse DeleteHiTSDBInstanceWithOptions(DeleteHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHiTSDBInstanceResponse>(DoRPCRequest("DeleteHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHiTSDBInstanceResponse> DeleteHiTSDBInstanceWithOptionsAsync(DeleteHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHiTSDBInstanceResponse>(await DoRPCRequestAsync("DeleteHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHiTSDBInstanceResponse DeleteHiTSDBInstance(DeleteHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHiTSDBInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteHiTSDBInstanceResponse> DeleteHiTSDBInstanceAsync(DeleteHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHiTSDBInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeHiTSDBInstanceResponse DescribeHiTSDBInstanceWithOptions(DescribeHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiTSDBInstanceResponse>(DoRPCRequest("DescribeHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHiTSDBInstanceResponse> DescribeHiTSDBInstanceWithOptionsAsync(DescribeHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiTSDBInstanceResponse>(await DoRPCRequestAsync("DescribeHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHiTSDBInstanceResponse DescribeHiTSDBInstance(DescribeHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHiTSDBInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeHiTSDBInstanceResponse> DescribeHiTSDBInstanceAsync(DescribeHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHiTSDBInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeHiTSDBInstanceListResponse DescribeHiTSDBInstanceListWithOptions(DescribeHiTSDBInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiTSDBInstanceListResponse>(DoRPCRequest("DescribeHiTSDBInstanceList", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHiTSDBInstanceListResponse> DescribeHiTSDBInstanceListWithOptionsAsync(DescribeHiTSDBInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiTSDBInstanceListResponse>(await DoRPCRequestAsync("DescribeHiTSDBInstanceList", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHiTSDBInstanceListResponse DescribeHiTSDBInstanceList(DescribeHiTSDBInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHiTSDBInstanceListWithOptions(request, runtime);
        }

        public async Task<DescribeHiTSDBInstanceListResponse> DescribeHiTSDBInstanceListAsync(DescribeHiTSDBInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHiTSDBInstanceListWithOptionsAsync(request, runtime);
        }

        public DescribeHiTSDBInstanceSecurityIpListResponse DescribeHiTSDBInstanceSecurityIpListWithOptions(DescribeHiTSDBInstanceSecurityIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiTSDBInstanceSecurityIpListResponse>(DoRPCRequest("DescribeHiTSDBInstanceSecurityIpList", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHiTSDBInstanceSecurityIpListResponse> DescribeHiTSDBInstanceSecurityIpListWithOptionsAsync(DescribeHiTSDBInstanceSecurityIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHiTSDBInstanceSecurityIpListResponse>(await DoRPCRequestAsync("DescribeHiTSDBInstanceSecurityIpList", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHiTSDBInstanceSecurityIpListResponse DescribeHiTSDBInstanceSecurityIpList(DescribeHiTSDBInstanceSecurityIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHiTSDBInstanceSecurityIpListWithOptions(request, runtime);
        }

        public async Task<DescribeHiTSDBInstanceSecurityIpListResponse> DescribeHiTSDBInstanceSecurityIpListAsync(DescribeHiTSDBInstanceSecurityIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHiTSDBInstanceSecurityIpListWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public ModifyHiTSDBInstanceClassResponse ModifyHiTSDBInstanceClassWithOptions(ModifyHiTSDBInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHiTSDBInstanceClassResponse>(DoRPCRequest("ModifyHiTSDBInstanceClass", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHiTSDBInstanceClassResponse> ModifyHiTSDBInstanceClassWithOptionsAsync(ModifyHiTSDBInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHiTSDBInstanceClassResponse>(await DoRPCRequestAsync("ModifyHiTSDBInstanceClass", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHiTSDBInstanceClassResponse ModifyHiTSDBInstanceClass(ModifyHiTSDBInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHiTSDBInstanceClassWithOptions(request, runtime);
        }

        public async Task<ModifyHiTSDBInstanceClassResponse> ModifyHiTSDBInstanceClassAsync(ModifyHiTSDBInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHiTSDBInstanceClassWithOptionsAsync(request, runtime);
        }

        public ModifyHiTSDBInstanceSecurityIpListResponse ModifyHiTSDBInstanceSecurityIpListWithOptions(ModifyHiTSDBInstanceSecurityIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHiTSDBInstanceSecurityIpListResponse>(DoRPCRequest("ModifyHiTSDBInstanceSecurityIpList", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHiTSDBInstanceSecurityIpListResponse> ModifyHiTSDBInstanceSecurityIpListWithOptionsAsync(ModifyHiTSDBInstanceSecurityIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHiTSDBInstanceSecurityIpListResponse>(await DoRPCRequestAsync("ModifyHiTSDBInstanceSecurityIpList", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHiTSDBInstanceSecurityIpListResponse ModifyHiTSDBInstanceSecurityIpList(ModifyHiTSDBInstanceSecurityIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHiTSDBInstanceSecurityIpListWithOptions(request, runtime);
        }

        public async Task<ModifyHiTSDBInstanceSecurityIpListResponse> ModifyHiTSDBInstanceSecurityIpListAsync(ModifyHiTSDBInstanceSecurityIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHiTSDBInstanceSecurityIpListWithOptionsAsync(request, runtime);
        }

        public RenameHiTSDBInstanceAliasResponse RenameHiTSDBInstanceAliasWithOptions(RenameHiTSDBInstanceAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameHiTSDBInstanceAliasResponse>(DoRPCRequest("RenameHiTSDBInstanceAlias", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenameHiTSDBInstanceAliasResponse> RenameHiTSDBInstanceAliasWithOptionsAsync(RenameHiTSDBInstanceAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameHiTSDBInstanceAliasResponse>(await DoRPCRequestAsync("RenameHiTSDBInstanceAlias", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenameHiTSDBInstanceAliasResponse RenameHiTSDBInstanceAlias(RenameHiTSDBInstanceAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameHiTSDBInstanceAliasWithOptions(request, runtime);
        }

        public async Task<RenameHiTSDBInstanceAliasResponse> RenameHiTSDBInstanceAliasAsync(RenameHiTSDBInstanceAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameHiTSDBInstanceAliasWithOptionsAsync(request, runtime);
        }

        public RenewTSDBInstanceResponse RenewTSDBInstanceWithOptions(RenewTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewTSDBInstanceResponse>(DoRPCRequest("RenewTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewTSDBInstanceResponse> RenewTSDBInstanceWithOptionsAsync(RenewTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewTSDBInstanceResponse>(await DoRPCRequestAsync("RenewTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewTSDBInstanceResponse RenewTSDBInstance(RenewTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewTSDBInstanceWithOptions(request, runtime);
        }

        public async Task<RenewTSDBInstanceResponse> RenewTSDBInstanceAsync(RenewTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewTSDBInstanceWithOptionsAsync(request, runtime);
        }

        public RestartHiTSDBInstanceResponse RestartHiTSDBInstanceWithOptions(RestartHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartHiTSDBInstanceResponse>(DoRPCRequest("RestartHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartHiTSDBInstanceResponse> RestartHiTSDBInstanceWithOptionsAsync(RestartHiTSDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartHiTSDBInstanceResponse>(await DoRPCRequestAsync("RestartHiTSDBInstance", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartHiTSDBInstanceResponse RestartHiTSDBInstance(RestartHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartHiTSDBInstanceWithOptions(request, runtime);
        }

        public async Task<RestartHiTSDBInstanceResponse> RestartHiTSDBInstanceAsync(RestartHiTSDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartHiTSDBInstanceWithOptionsAsync(request, runtime);
        }

        public SwitchHiTSDBInstancePublicNetResponse SwitchHiTSDBInstancePublicNetWithOptions(SwitchHiTSDBInstancePublicNetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchHiTSDBInstancePublicNetResponse>(DoRPCRequest("SwitchHiTSDBInstancePublicNet", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchHiTSDBInstancePublicNetResponse> SwitchHiTSDBInstancePublicNetWithOptionsAsync(SwitchHiTSDBInstancePublicNetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchHiTSDBInstancePublicNetResponse>(await DoRPCRequestAsync("SwitchHiTSDBInstancePublicNet", "2017-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchHiTSDBInstancePublicNetResponse SwitchHiTSDBInstancePublicNet(SwitchHiTSDBInstancePublicNetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchHiTSDBInstancePublicNetWithOptions(request, runtime);
        }

        public async Task<SwitchHiTSDBInstancePublicNetResponse> SwitchHiTSDBInstancePublicNetAsync(SwitchHiTSDBInstancePublicNetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchHiTSDBInstancePublicNetWithOptionsAsync(request, runtime);
        }

    }
}
