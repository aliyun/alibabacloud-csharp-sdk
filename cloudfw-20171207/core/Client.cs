// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudfw20171207.Models;

namespace AlibabaCloud.SDK.Cloudfw20171207
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "cloudfw.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou", "cloudfw.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudfw", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAddressBookResponse AddAddressBookWithOptions(AddAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAddressBookResponse>(DoRPCRequest("AddAddressBook", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAddressBookResponse> AddAddressBookWithOptionsAsync(AddAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAddressBookResponse>(await DoRPCRequestAsync("AddAddressBook", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAddressBookResponse AddAddressBook(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAddressBookWithOptions(request, runtime);
        }

        public async Task<AddAddressBookResponse> AddAddressBookAsync(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAddressBookWithOptionsAsync(request, runtime);
        }

        public AddControlPolicyResponse AddControlPolicyWithOptions(AddControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddControlPolicyResponse>(DoRPCRequest("AddControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddControlPolicyResponse> AddControlPolicyWithOptionsAsync(AddControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddControlPolicyResponse>(await DoRPCRequestAsync("AddControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddControlPolicyResponse AddControlPolicy(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddControlPolicyWithOptions(request, runtime);
        }

        public async Task<AddControlPolicyResponse> AddControlPolicyAsync(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddControlPolicyWithOptionsAsync(request, runtime);
        }

        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicyWithOptions(CreateVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcFirewallControlPolicyResponse>(DoRPCRequest("CreateVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyWithOptionsAsync(CreateVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcFirewallControlPolicyResponse>(await DoRPCRequestAsync("CreateVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicy(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyAsync(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteAddressBookResponse DeleteAddressBookWithOptions(DeleteAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAddressBookResponse>(DoRPCRequest("DeleteAddressBook", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAddressBookResponse> DeleteAddressBookWithOptionsAsync(DeleteAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAddressBookResponse>(await DoRPCRequestAsync("DeleteAddressBook", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAddressBookWithOptions(request, runtime);
        }

        public async Task<DeleteAddressBookResponse> DeleteAddressBookAsync(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAddressBookWithOptionsAsync(request, runtime);
        }

        public DeleteControlPolicyResponse DeleteControlPolicyWithOptions(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(DoRPCRequest("DeleteControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyWithOptionsAsync(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(await DoRPCRequestAsync("DeleteControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteControlPolicyResponse DeleteControlPolicy(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyAsync(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicyWithOptions(DeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcFirewallControlPolicyResponse>(DoRPCRequest("DeleteVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyWithOptionsAsync(DeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcFirewallControlPolicyResponse>(await DoRPCRequestAsync("DeleteVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicy(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyAsync(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsedWithOptions(DescribePolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolicyPriorUsedResponse>(DoRPCRequest("DescribePolicyPriorUsed", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedWithOptionsAsync(DescribePolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePolicyPriorUsedResponse>(await DoRPCRequestAsync("DescribePolicyPriorUsed", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsed(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyPriorUsedWithOptions(request, runtime);
        }

        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedAsync(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicyWithOptions(DescribeVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcFirewallControlPolicyResponse>(DoRPCRequest("DescribeVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyWithOptionsAsync(DescribeVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcFirewallControlPolicyResponse>(await DoRPCRequestAsync("DescribeVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicy(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyAsync(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsedWithOptions(DescribeVpcFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcFirewallPolicyPriorUsedResponse>(DoRPCRequest("DescribeVpcFirewallPolicyPriorUsed", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(DescribeVpcFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcFirewallPolicyPriorUsedResponse>(await DoRPCRequestAsync("DescribeVpcFirewallPolicyPriorUsed", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsed(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallPolicyPriorUsedWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedAsync(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        public ModifyAddressBookResponse ModifyAddressBookWithOptions(ModifyAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAddressBookResponse>(DoRPCRequest("ModifyAddressBook", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAddressBookResponse> ModifyAddressBookWithOptionsAsync(ModifyAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAddressBookResponse>(await DoRPCRequestAsync("ModifyAddressBook", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAddressBookResponse ModifyAddressBook(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAddressBookWithOptions(request, runtime);
        }

        public async Task<ModifyAddressBookResponse> ModifyAddressBookAsync(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAddressBookWithOptionsAsync(request, runtime);
        }

        public ModifyControlPolicyResponse ModifyControlPolicyWithOptions(ModifyControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyControlPolicyResponse>(DoRPCRequest("ModifyControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyWithOptionsAsync(ModifyControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyControlPolicyResponse>(await DoRPCRequestAsync("ModifyControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyControlPolicyResponse ModifyControlPolicy(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyAsync(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyControlPolicyPositionResponse ModifyControlPolicyPositionWithOptions(ModifyControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyControlPolicyPositionResponse>(DoRPCRequest("ModifyControlPolicyPosition", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionWithOptionsAsync(ModifyControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyControlPolicyPositionResponse>(await DoRPCRequestAsync("ModifyControlPolicyPosition", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyControlPolicyPositionResponse ModifyControlPolicyPosition(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyPositionWithOptions(request, runtime);
        }

        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionAsync(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfigWithOptions(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPolicyAdvancedConfigResponse>(DoRPCRequest("ModifyPolicyAdvancedConfig", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigWithOptionsAsync(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPolicyAdvancedConfigResponse>(await DoRPCRequestAsync("ModifyPolicyAdvancedConfig", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfig(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyAdvancedConfigWithOptions(request, runtime);
        }

        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigAsync(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicyWithOptions(ModifyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyResponse>(DoRPCRequest("ModifyVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyWithOptionsAsync(ModifyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyResponse>(await DoRPCRequestAsync("ModifyVpcFirewallControlPolicy", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicy(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyAsync(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPositionWithOptions(ModifyVpcFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyPositionResponse>(DoRPCRequest("ModifyVpcFirewallControlPolicyPosition", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(ModifyVpcFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyPositionResponse>(await DoRPCRequestAsync("ModifyVpcFirewallControlPolicyPosition", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPosition(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyPositionWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionAsync(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitchWithOptions(PutDisableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutDisableAllFwSwitchResponse>(DoRPCRequest("PutDisableAllFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchWithOptionsAsync(PutDisableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutDisableAllFwSwitchResponse>(await DoRPCRequestAsync("PutDisableAllFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitch(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableAllFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchAsync(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        public PutDisableFwSwitchResponse PutDisableFwSwitchWithOptions(PutDisableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutDisableFwSwitchResponse>(DoRPCRequest("PutDisableFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchWithOptionsAsync(PutDisableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutDisableFwSwitchResponse>(await DoRPCRequestAsync("PutDisableFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutDisableFwSwitchResponse PutDisableFwSwitch(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchAsync(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableFwSwitchWithOptionsAsync(request, runtime);
        }

        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitchWithOptions(PutEnableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEnableAllFwSwitchResponse>(DoRPCRequest("PutEnableAllFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchWithOptionsAsync(PutEnableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEnableAllFwSwitchResponse>(await DoRPCRequestAsync("PutEnableAllFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitch(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableAllFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchAsync(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        public PutEnableFwSwitchResponse PutEnableFwSwitchWithOptions(PutEnableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEnableFwSwitchResponse>(DoRPCRequest("PutEnableFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchWithOptionsAsync(PutEnableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEnableFwSwitchResponse>(await DoRPCRequestAsync("PutEnableFwSwitch", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutEnableFwSwitchResponse PutEnableFwSwitch(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchAsync(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableFwSwitchWithOptionsAsync(request, runtime);
        }

        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCountWithOptions(ResetVpcFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetVpcFirewallRuleHitCountResponse>(DoRPCRequest("ResetVpcFirewallRuleHitCount", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountWithOptionsAsync(ResetVpcFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetVpcFirewallRuleHitCountResponse>(await DoRPCRequestAsync("ResetVpcFirewallRuleHitCount", "2017-12-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCount(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetVpcFirewallRuleHitCountWithOptions(request, runtime);
        }

        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountAsync(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetVpcFirewallRuleHitCountWithOptionsAsync(request, runtime);
        }

    }
}
