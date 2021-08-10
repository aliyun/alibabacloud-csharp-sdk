// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Gpdb20190620.Models;

namespace AlibabaCloud.SDK.Gpdb20190620
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "gpdb.aliyuncs.com"},
                {"cn-hangzhou", "gpdb.aliyuncs.com"},
                {"cn-shanghai", "gpdb.aliyuncs.com"},
                {"cn-shenzhen", "gpdb.aliyuncs.com"},
                {"cn-hongkong", "gpdb.aliyuncs.com"},
                {"ap-southeast-1", "gpdb.aliyuncs.com"},
                {"us-west-1", "gpdb.aliyuncs.com"},
                {"us-east-1", "gpdb.aliyuncs.com"},
                {"cn-hangzhou-finance", "gpdb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "gpdb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "gpdb.aliyuncs.com"},
                {"cn-qingdao", "gpdb.aliyuncs.com"},
                {"cn-north-2-gov-1", "gpdb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("gpdb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeDBInstanceForDmsResponse DescribeDBInstanceForDmsWithOptions(DescribeDBInstanceForDmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceForDmsResponse>(DoRPCRequest("DescribeDBInstanceForDms", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceForDmsResponse> DescribeDBInstanceForDmsWithOptionsAsync(DescribeDBInstanceForDmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceForDmsResponse>(await DoRPCRequestAsync("DescribeDBInstanceForDms", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceForDmsResponse DescribeDBInstanceForDms(DescribeDBInstanceForDmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceForDmsWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceForDmsResponse> DescribeDBInstanceForDmsAsync(DescribeDBInstanceForDmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceForDmsWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstanceSecurityIpsResponse DescribeDBInstanceSecurityIpsWithOptions(DescribeDBInstanceSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceSecurityIpsResponse>(DoRPCRequest("DescribeDBInstanceSecurityIps", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstanceSecurityIpsResponse> DescribeDBInstanceSecurityIpsWithOptionsAsync(DescribeDBInstanceSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstanceSecurityIpsResponse>(await DoRPCRequestAsync("DescribeDBInstanceSecurityIps", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstanceSecurityIpsResponse DescribeDBInstanceSecurityIps(DescribeDBInstanceSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceSecurityIpsWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstanceSecurityIpsResponse> DescribeDBInstanceSecurityIpsAsync(DescribeDBInstanceSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceSecurityIpsWithOptionsAsync(request, runtime);
        }

        public DescribeDBInstancesForDmsResponse DescribeDBInstancesForDmsWithOptions(DescribeDBInstancesForDmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesForDmsResponse>(DoRPCRequest("DescribeDBInstancesForDms", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDBInstancesForDmsResponse> DescribeDBInstancesForDmsWithOptionsAsync(DescribeDBInstancesForDmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDBInstancesForDmsResponse>(await DoRPCRequestAsync("DescribeDBInstancesForDms", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDBInstancesForDmsResponse DescribeDBInstancesForDms(DescribeDBInstancesForDmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesForDmsWithOptions(request, runtime);
        }

        public async Task<DescribeDBInstancesForDmsResponse> DescribeDBInstancesForDmsAsync(DescribeDBInstancesForDmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesForDmsWithOptionsAsync(request, runtime);
        }

        public ModifyDBInstanceSecurityIpsResponse ModifyDBInstanceSecurityIpsWithOptions(ModifyDBInstanceSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSecurityIpsResponse>(DoRPCRequest("ModifyDBInstanceSecurityIps", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceSecurityIpsResponse> ModifyDBInstanceSecurityIpsWithOptionsAsync(ModifyDBInstanceSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSecurityIpsResponse>(await DoRPCRequestAsync("ModifyDBInstanceSecurityIps", "2019-06-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceSecurityIpsResponse ModifyDBInstanceSecurityIps(ModifyDBInstanceSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSecurityIpsWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceSecurityIpsResponse> ModifyDBInstanceSecurityIpsAsync(ModifyDBInstanceSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSecurityIpsWithOptionsAsync(request, runtime);
        }

    }
}
