// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eais20190624.Models;

namespace AlibabaCloud.SDK.Eais20190624
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "eais.aliyuncs.com"},
                {"ap-northeast-2-pop", "eais.aliyuncs.com"},
                {"ap-south-1", "eais.aliyuncs.com"},
                {"ap-southeast-1", "eais.aliyuncs.com"},
                {"ap-southeast-2", "eais.aliyuncs.com"},
                {"ap-southeast-3", "eais.aliyuncs.com"},
                {"ap-southeast-5", "eais.aliyuncs.com"},
                {"cn-beijing-finance-1", "eais.aliyuncs.com"},
                {"cn-beijing-finance-pop", "eais.aliyuncs.com"},
                {"cn-beijing-gov-1", "eais.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "eais.aliyuncs.com"},
                {"cn-edge-1", "eais.aliyuncs.com"},
                {"cn-fujian", "eais.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "eais.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "eais.aliyuncs.com"},
                {"cn-hangzhou-finance", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "eais.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "eais.aliyuncs.com"},
                {"cn-hangzhou-test-306", "eais.aliyuncs.com"},
                {"cn-hongkong", "eais.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "eais.aliyuncs.com"},
                {"cn-huhehaote", "eais.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "eais.aliyuncs.com"},
                {"cn-north-2-gov-1", "eais.aliyuncs.com"},
                {"cn-qingdao", "eais.aliyuncs.com"},
                {"cn-qingdao-nebula", "eais.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "eais.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "eais.aliyuncs.com"},
                {"cn-shanghai-finance-1", "eais.aliyuncs.com"},
                {"cn-shanghai-inner", "eais.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "eais.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "eais.aliyuncs.com"},
                {"cn-shenzhen-inner", "eais.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "eais.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "eais.aliyuncs.com"},
                {"cn-wuhan", "eais.aliyuncs.com"},
                {"cn-wulanchabu", "eais.aliyuncs.com"},
                {"cn-yushanfang", "eais.aliyuncs.com"},
                {"cn-zhangbei", "eais.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "eais.aliyuncs.com"},
                {"cn-zhangjiakou", "eais.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "eais.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "eais.aliyuncs.com"},
                {"eu-central-1", "eais.aliyuncs.com"},
                {"eu-west-1", "eais.aliyuncs.com"},
                {"eu-west-1-oxs", "eais.aliyuncs.com"},
                {"me-east-1", "eais.aliyuncs.com"},
                {"rus-west-1-pop", "eais.aliyuncs.com"},
                {"us-east-1", "eais.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("eais", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachEaiResponse AttachEaiWithOptions(AttachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceId))
            {
                query["ClientInstanceId"] = request.ClientInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachEaiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachEaiResponse> AttachEaiWithOptionsAsync(AttachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceId))
            {
                query["ClientInstanceId"] = request.ClientInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachEaiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachEaiResponse AttachEai(AttachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachEaiWithOptions(request, runtime);
        }

        public async Task<AttachEaiResponse> AttachEaiAsync(AttachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachEaiWithOptionsAsync(request, runtime);
        }

        public CreateEaiResponse CreateEaiWithOptions(CreateEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEaiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEaiResponse> CreateEaiWithOptionsAsync(CreateEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEaiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEaiResponse CreateEai(CreateEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEaiWithOptions(request, runtime);
        }

        public async Task<CreateEaiResponse> CreateEaiAsync(CreateEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEaiWithOptionsAsync(request, runtime);
        }

        public CreateEaiAllResponse CreateEaiAllWithOptions(CreateEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientImageId))
            {
                query["ClientImageId"] = request.ClientImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceName))
            {
                query["ClientInstanceName"] = request.ClientInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceType))
            {
                query["ClientInstanceType"] = request.ClientInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInternetMaxBandwidthIn))
            {
                query["ClientInternetMaxBandwidthIn"] = request.ClientInternetMaxBandwidthIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInternetMaxBandwidthOut))
            {
                query["ClientInternetMaxBandwidthOut"] = request.ClientInternetMaxBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientPassword))
            {
                query["ClientPassword"] = request.ClientPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecurityGroupId))
            {
                query["ClientSecurityGroupId"] = request.ClientSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystemDiskCategory))
            {
                query["ClientSystemDiskCategory"] = request.ClientSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystemDiskSize))
            {
                query["ClientSystemDiskSize"] = request.ClientSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVSwitchId))
            {
                query["ClientVSwitchId"] = request.ClientVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientZoneId))
            {
                query["ClientZoneId"] = request.ClientZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EaiInstanceType))
            {
                query["EaiInstanceType"] = request.EaiInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEaiAll",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEaiAllResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEaiAllResponse> CreateEaiAllWithOptionsAsync(CreateEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientImageId))
            {
                query["ClientImageId"] = request.ClientImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceName))
            {
                query["ClientInstanceName"] = request.ClientInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceType))
            {
                query["ClientInstanceType"] = request.ClientInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInternetMaxBandwidthIn))
            {
                query["ClientInternetMaxBandwidthIn"] = request.ClientInternetMaxBandwidthIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInternetMaxBandwidthOut))
            {
                query["ClientInternetMaxBandwidthOut"] = request.ClientInternetMaxBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientPassword))
            {
                query["ClientPassword"] = request.ClientPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecurityGroupId))
            {
                query["ClientSecurityGroupId"] = request.ClientSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystemDiskCategory))
            {
                query["ClientSystemDiskCategory"] = request.ClientSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSystemDiskSize))
            {
                query["ClientSystemDiskSize"] = request.ClientSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVSwitchId))
            {
                query["ClientVSwitchId"] = request.ClientVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientZoneId))
            {
                query["ClientZoneId"] = request.ClientZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EaiInstanceType))
            {
                query["EaiInstanceType"] = request.EaiInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEaiAll",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEaiAllResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEaiAllResponse CreateEaiAll(CreateEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEaiAllWithOptions(request, runtime);
        }

        public async Task<CreateEaiAllResponse> CreateEaiAllAsync(CreateEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEaiAllWithOptionsAsync(request, runtime);
        }

        public CreateEaiJupyterResponse CreateEaiJupyterWithOptions(CreateEaiJupyterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EaisType))
            {
                query["EaisType"] = request.EaisType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEaiJupyter",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEaiJupyterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEaiJupyterResponse> CreateEaiJupyterWithOptionsAsync(CreateEaiJupyterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EaisType))
            {
                query["EaisType"] = request.EaisType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEaiJupyter",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEaiJupyterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEaiJupyterResponse CreateEaiJupyter(CreateEaiJupyterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEaiJupyterWithOptions(request, runtime);
        }

        public async Task<CreateEaiJupyterResponse> CreateEaiJupyterAsync(CreateEaiJupyterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEaiJupyterWithOptionsAsync(request, runtime);
        }

        public DeleteEaiResponse DeleteEaiWithOptions(DeleteEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEaiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEaiResponse> DeleteEaiWithOptionsAsync(DeleteEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEaiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEaiResponse DeleteEai(DeleteEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEaiWithOptions(request, runtime);
        }

        public async Task<DeleteEaiResponse> DeleteEaiAsync(DeleteEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEaiWithOptionsAsync(request, runtime);
        }

        public DeleteEaiAllResponse DeleteEaiAllWithOptions(DeleteEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceId))
            {
                query["ClientInstanceId"] = request.ClientInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEaiAll",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEaiAllResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEaiAllResponse> DeleteEaiAllWithOptionsAsync(DeleteEaiAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInstanceId))
            {
                query["ClientInstanceId"] = request.ClientInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEaiAll",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEaiAllResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEaiAllResponse DeleteEaiAll(DeleteEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEaiAllWithOptions(request, runtime);
        }

        public async Task<DeleteEaiAllResponse> DeleteEaiAllAsync(DeleteEaiAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEaiAllWithOptionsAsync(request, runtime);
        }

        public DescribeEaisResponse DescribeEaisWithOptions(DescribeEaisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceIds))
            {
                query["ElasticAcceleratedInstanceIds"] = request.ElasticAcceleratedInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEais",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEaisResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEaisResponse> DescribeEaisWithOptionsAsync(DescribeEaisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceIds))
            {
                query["ElasticAcceleratedInstanceIds"] = request.ElasticAcceleratedInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEais",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEaisResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEaisResponse DescribeEais(DescribeEaisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEaisWithOptions(request, runtime);
        }

        public async Task<DescribeEaisResponse> DescribeEaisAsync(DescribeEaisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEaisWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DetachEaiResponse DetachEaiWithOptions(DetachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachEaiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachEaiResponse> DetachEaiWithOptionsAsync(DetachEaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticAcceleratedInstanceId))
            {
                query["ElasticAcceleratedInstanceId"] = request.ElasticAcceleratedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachEai",
                Version = "2019-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachEaiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachEaiResponse DetachEai(DetachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachEaiWithOptions(request, runtime);
        }

        public async Task<DetachEaiResponse> DetachEaiAsync(DetachEaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachEaiWithOptionsAsync(request, runtime);
        }

    }
}
