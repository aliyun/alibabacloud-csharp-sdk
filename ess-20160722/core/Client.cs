// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ess20160722.Models;

namespace AlibabaCloud.SDK.Ess20160722
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ess.aliyuncs.com"},
                {"cn-beijing", "ess.aliyuncs.com"},
                {"cn-hangzhou", "ess.aliyuncs.com"},
                {"cn-shanghai", "ess.aliyuncs.com"},
                {"cn-shenzhen", "ess.aliyuncs.com"},
                {"cn-hongkong", "ess.aliyuncs.com"},
                {"ap-southeast-1", "ess.aliyuncs.com"},
                {"us-east-1", "ess.aliyuncs.com"},
                {"us-west-1", "ess.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ess.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ess.aliyuncs.com"},
                {"cn-north-2-gov-1", "ess.aliyuncs.com"},
                {"ap-northeast-2-pop", "ess.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ess.aliyuncs.com"},
                {"cn-beijing-gov-1", "ess.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ess.aliyuncs.com"},
                {"cn-edge-1", "ess.aliyuncs.com"},
                {"cn-fujian", "ess.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ess.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ess.aliyuncs.com"},
                {"cn-hangzhou-finance", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ess.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ess.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ess.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ess.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "ess.aliyuncs.com"},
                {"cn-qingdao-nebula", "ess.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ess.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ess.aliyuncs.com"},
                {"cn-shanghai-inner", "ess.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ess.aliyuncs.com"},
                {"cn-shenzhen-inner", "ess.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ess.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ess.aliyuncs.com"},
                {"cn-wuhan", "ess.aliyuncs.com"},
                {"cn-yushanfang", "ess.aliyuncs.com"},
                {"cn-zhangbei", "ess.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ess.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ess.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ess.aliyuncs.com"},
                {"eu-west-1-oxs", "ess.aliyuncs.com"},
                {"rus-west-1-pop", "ess.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ess", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @deprecated OpenAPI AttachInstances is deprecated, please use Ess::2014-08-28::AttachInstances,Ess::2022-02-22::AttachInstances instead.
         *
         * @param request AttachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesResponse
         */
        // Deprecated
        public AttachInstancesResponse AttachInstancesWithOptions(AttachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI AttachInstances is deprecated, please use Ess::2014-08-28::AttachInstances,Ess::2022-02-22::AttachInstances instead.
         *
         * @param request AttachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesResponse
         */
        // Deprecated
        public async Task<AttachInstancesResponse> AttachInstancesWithOptionsAsync(AttachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI AttachInstances is deprecated, please use Ess::2014-08-28::AttachInstances,Ess::2022-02-22::AttachInstances instead.
         *
         * @param request AttachInstancesRequest
         * @return AttachInstancesResponse
         */
        // Deprecated
        public AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachInstancesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI AttachInstances is deprecated, please use Ess::2014-08-28::AttachInstances,Ess::2022-02-22::AttachInstances instead.
         *
         * @param request AttachInstancesRequest
         * @return AttachInstancesResponse
         */
        // Deprecated
        public async Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScalingConfiguration is deprecated, please use Ess::2022-02-22::CreateScalingConfiguration,Ess::2014-08-28::CreateScalingConfiguration instead.
         *
         * @param request CreateScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingConfigurationResponse
         */
        // Deprecated
        public CreateScalingConfigurationResponse CreateScalingConfigurationWithOptions(CreateScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetMaxBandwidthIn))
            {
                query["InternetMaxBandwidthIn"] = request.InternetMaxBandwidthIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetMaxBandwidthOut))
            {
                query["InternetMaxBandwidthOut"] = request.InternetMaxBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoOptimized))
            {
                query["IoOptimized"] = request.IoOptimized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisk))
            {
                query["DataDisk"] = request.DataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDisk))
            {
                query["SystemDisk"] = request.SystemDisk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingConfiguration",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScalingConfiguration is deprecated, please use Ess::2022-02-22::CreateScalingConfiguration,Ess::2014-08-28::CreateScalingConfiguration instead.
         *
         * @param request CreateScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingConfigurationResponse
         */
        // Deprecated
        public async Task<CreateScalingConfigurationResponse> CreateScalingConfigurationWithOptionsAsync(CreateScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetMaxBandwidthIn))
            {
                query["InternetMaxBandwidthIn"] = request.InternetMaxBandwidthIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetMaxBandwidthOut))
            {
                query["InternetMaxBandwidthOut"] = request.InternetMaxBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoOptimized))
            {
                query["IoOptimized"] = request.IoOptimized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisk))
            {
                query["DataDisk"] = request.DataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDisk))
            {
                query["SystemDisk"] = request.SystemDisk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingConfiguration",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScalingConfiguration is deprecated, please use Ess::2022-02-22::CreateScalingConfiguration,Ess::2014-08-28::CreateScalingConfiguration instead.
         *
         * @param request CreateScalingConfigurationRequest
         * @return CreateScalingConfigurationResponse
         */
        // Deprecated
        public CreateScalingConfigurationResponse CreateScalingConfiguration(CreateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScalingConfiguration is deprecated, please use Ess::2022-02-22::CreateScalingConfiguration,Ess::2014-08-28::CreateScalingConfiguration instead.
         *
         * @param request CreateScalingConfigurationRequest
         * @return CreateScalingConfigurationResponse
         */
        // Deprecated
        public async Task<CreateScalingConfigurationResponse> CreateScalingConfigurationAsync(CreateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScalingGroup is deprecated, please use Ess::2022-02-22::CreateScalingGroup,Ess::2014-08-28::CreateScalingGroup instead.
         *
         * @param request CreateScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingGroupResponse
         */
        // Deprecated
        public CreateScalingGroupResponse CreateScalingGroupWithOptions(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceIds))
            {
                query["DBInstanceIds"] = request.DBInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicy))
            {
                query["RemovalPolicy"] = request.RemovalPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScalingGroup is deprecated, please use Ess::2022-02-22::CreateScalingGroup,Ess::2014-08-28::CreateScalingGroup instead.
         *
         * @param request CreateScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingGroupResponse
         */
        // Deprecated
        public async Task<CreateScalingGroupResponse> CreateScalingGroupWithOptionsAsync(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceIds))
            {
                query["DBInstanceIds"] = request.DBInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicy))
            {
                query["RemovalPolicy"] = request.RemovalPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScalingGroup is deprecated, please use Ess::2022-02-22::CreateScalingGroup,Ess::2014-08-28::CreateScalingGroup instead.
         *
         * @param request CreateScalingGroupRequest
         * @return CreateScalingGroupResponse
         */
        // Deprecated
        public CreateScalingGroupResponse CreateScalingGroup(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingGroupWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScalingGroup is deprecated, please use Ess::2022-02-22::CreateScalingGroup,Ess::2014-08-28::CreateScalingGroup instead.
         *
         * @param request CreateScalingGroupRequest
         * @return CreateScalingGroupResponse
         */
        // Deprecated
        public async Task<CreateScalingGroupResponse> CreateScalingGroupAsync(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScalingRule is deprecated, please use Ess::2022-02-22::CreateScalingRule,Ess::2014-08-28::CreateScalingRule instead.
         *
         * @param request CreateScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingRuleResponse
         */
        // Deprecated
        public CreateScalingRuleResponse CreateScalingRuleWithOptions(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentType))
            {
                query["AdjustmentType"] = request.AdjustmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentValue))
            {
                query["AdjustmentValue"] = request.AdjustmentValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScalingRule is deprecated, please use Ess::2022-02-22::CreateScalingRule,Ess::2014-08-28::CreateScalingRule instead.
         *
         * @param request CreateScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingRuleResponse
         */
        // Deprecated
        public async Task<CreateScalingRuleResponse> CreateScalingRuleWithOptionsAsync(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentType))
            {
                query["AdjustmentType"] = request.AdjustmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentValue))
            {
                query["AdjustmentValue"] = request.AdjustmentValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScalingRule is deprecated, please use Ess::2022-02-22::CreateScalingRule,Ess::2014-08-28::CreateScalingRule instead.
         *
         * @param request CreateScalingRuleRequest
         * @return CreateScalingRuleResponse
         */
        // Deprecated
        public CreateScalingRuleResponse CreateScalingRule(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScalingRule is deprecated, please use Ess::2022-02-22::CreateScalingRule,Ess::2014-08-28::CreateScalingRule instead.
         *
         * @param request CreateScalingRuleRequest
         * @return CreateScalingRuleResponse
         */
        // Deprecated
        public async Task<CreateScalingRuleResponse> CreateScalingRuleAsync(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScheduledTask is deprecated, please use Ess::2022-02-22::CreateScheduledTask,Ess::2014-08-28::CreateScheduledTask instead.
         *
         * @param request CreateScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledTaskResponse
         */
        // Deprecated
        public CreateScheduledTaskResponse CreateScheduledTaskWithOptions(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceEndTime))
            {
                query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceType))
            {
                query["RecurrenceType"] = request.RecurrenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValue))
            {
                query["RecurrenceValue"] = request.RecurrenceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledAction))
            {
                query["ScheduledAction"] = request.ScheduledAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskName))
            {
                query["ScheduledTaskName"] = request.ScheduledTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEnabled))
            {
                query["TaskEnabled"] = request.TaskEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScheduledTask is deprecated, please use Ess::2022-02-22::CreateScheduledTask,Ess::2014-08-28::CreateScheduledTask instead.
         *
         * @param request CreateScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledTaskResponse
         */
        // Deprecated
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceEndTime))
            {
                query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceType))
            {
                query["RecurrenceType"] = request.RecurrenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValue))
            {
                query["RecurrenceValue"] = request.RecurrenceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledAction))
            {
                query["ScheduledAction"] = request.ScheduledAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskName))
            {
                query["ScheduledTaskName"] = request.ScheduledTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEnabled))
            {
                query["TaskEnabled"] = request.TaskEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CreateScheduledTask is deprecated, please use Ess::2022-02-22::CreateScheduledTask,Ess::2014-08-28::CreateScheduledTask instead.
         *
         * @param request CreateScheduledTaskRequest
         * @return CreateScheduledTaskResponse
         */
        // Deprecated
        public CreateScheduledTaskResponse CreateScheduledTask(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledTaskWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateScheduledTask is deprecated, please use Ess::2022-02-22::CreateScheduledTask,Ess::2014-08-28::CreateScheduledTask instead.
         *
         * @param request CreateScheduledTaskRequest
         * @return CreateScheduledTaskResponse
         */
        // Deprecated
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskAsync(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScalingConfiguration is deprecated, please use Ess::2022-02-22::DeleteScalingConfiguration,Ess::2014-08-28::DeleteScalingConfiguration instead.
         *
         * @param request DeleteScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingConfigurationResponse
         */
        // Deprecated
        public DeleteScalingConfigurationResponse DeleteScalingConfigurationWithOptions(DeleteScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingConfiguration",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScalingConfiguration is deprecated, please use Ess::2022-02-22::DeleteScalingConfiguration,Ess::2014-08-28::DeleteScalingConfiguration instead.
         *
         * @param request DeleteScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingConfigurationResponse
         */
        // Deprecated
        public async Task<DeleteScalingConfigurationResponse> DeleteScalingConfigurationWithOptionsAsync(DeleteScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingConfiguration",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScalingConfiguration is deprecated, please use Ess::2022-02-22::DeleteScalingConfiguration,Ess::2014-08-28::DeleteScalingConfiguration instead.
         *
         * @param request DeleteScalingConfigurationRequest
         * @return DeleteScalingConfigurationResponse
         */
        // Deprecated
        public DeleteScalingConfigurationResponse DeleteScalingConfiguration(DeleteScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScalingConfiguration is deprecated, please use Ess::2022-02-22::DeleteScalingConfiguration,Ess::2014-08-28::DeleteScalingConfiguration instead.
         *
         * @param request DeleteScalingConfigurationRequest
         * @return DeleteScalingConfigurationResponse
         */
        // Deprecated
        public async Task<DeleteScalingConfigurationResponse> DeleteScalingConfigurationAsync(DeleteScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScalingGroup is deprecated, please use Ess::2022-02-22::DeleteScalingGroup,Ess::2014-08-28::DeleteScalingGroup instead.
         *
         * @param request DeleteScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingGroupResponse
         */
        // Deprecated
        public DeleteScalingGroupResponse DeleteScalingGroupWithOptions(DeleteScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelete))
            {
                query["ForceDelete"] = request.ForceDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScalingGroup is deprecated, please use Ess::2022-02-22::DeleteScalingGroup,Ess::2014-08-28::DeleteScalingGroup instead.
         *
         * @param request DeleteScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingGroupResponse
         */
        // Deprecated
        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupWithOptionsAsync(DeleteScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelete))
            {
                query["ForceDelete"] = request.ForceDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScalingGroup is deprecated, please use Ess::2022-02-22::DeleteScalingGroup,Ess::2014-08-28::DeleteScalingGroup instead.
         *
         * @param request DeleteScalingGroupRequest
         * @return DeleteScalingGroupResponse
         */
        // Deprecated
        public DeleteScalingGroupResponse DeleteScalingGroup(DeleteScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingGroupWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScalingGroup is deprecated, please use Ess::2022-02-22::DeleteScalingGroup,Ess::2014-08-28::DeleteScalingGroup instead.
         *
         * @param request DeleteScalingGroupRequest
         * @return DeleteScalingGroupResponse
         */
        // Deprecated
        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupAsync(DeleteScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScalingRule is deprecated, please use Ess::2022-02-22::DeleteScalingRule,Ess::2014-08-28::DeleteScalingRule instead.
         *
         * @param request DeleteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingRuleResponse
         */
        // Deprecated
        public DeleteScalingRuleResponse DeleteScalingRuleWithOptions(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScalingRule is deprecated, please use Ess::2022-02-22::DeleteScalingRule,Ess::2014-08-28::DeleteScalingRule instead.
         *
         * @param request DeleteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingRuleResponse
         */
        // Deprecated
        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleWithOptionsAsync(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScalingRule is deprecated, please use Ess::2022-02-22::DeleteScalingRule,Ess::2014-08-28::DeleteScalingRule instead.
         *
         * @param request DeleteScalingRuleRequest
         * @return DeleteScalingRuleResponse
         */
        // Deprecated
        public DeleteScalingRuleResponse DeleteScalingRule(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScalingRule is deprecated, please use Ess::2022-02-22::DeleteScalingRule,Ess::2014-08-28::DeleteScalingRule instead.
         *
         * @param request DeleteScalingRuleRequest
         * @return DeleteScalingRuleResponse
         */
        // Deprecated
        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleAsync(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScheduledTask is deprecated, please use Ess::2022-02-22::DeleteScheduledTask,Ess::2014-08-28::DeleteScheduledTask instead.
         *
         * @param request DeleteScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledTaskResponse
         */
        // Deprecated
        public DeleteScheduledTaskResponse DeleteScheduledTaskWithOptions(DeleteScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskId))
            {
                query["ScheduledTaskId"] = request.ScheduledTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledTask",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScheduledTask is deprecated, please use Ess::2022-02-22::DeleteScheduledTask,Ess::2014-08-28::DeleteScheduledTask instead.
         *
         * @param request DeleteScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledTaskResponse
         */
        // Deprecated
        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskWithOptionsAsync(DeleteScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskId))
            {
                query["ScheduledTaskId"] = request.ScheduledTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledTask",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScheduledTask is deprecated, please use Ess::2022-02-22::DeleteScheduledTask,Ess::2014-08-28::DeleteScheduledTask instead.
         *
         * @param request DeleteScheduledTaskRequest
         * @return DeleteScheduledTaskResponse
         */
        // Deprecated
        public DeleteScheduledTaskResponse DeleteScheduledTask(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledTaskWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScheduledTask is deprecated, please use Ess::2022-02-22::DeleteScheduledTask,Ess::2014-08-28::DeleteScheduledTask instead.
         *
         * @param request DeleteScheduledTaskRequest
         * @return DeleteScheduledTaskResponse
         */
        // Deprecated
        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskAsync(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeAccountAttributes is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeAccountAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountAttributesResponse
         */
        // Deprecated
        public DescribeAccountAttributesResponse DescribeAccountAttributesWithOptions(DescribeAccountAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountAttributes",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeAccountAttributes is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeAccountAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountAttributesResponse
         */
        // Deprecated
        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributesWithOptionsAsync(DescribeAccountAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountAttributes",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeAccountAttributes is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeAccountAttributesRequest
         * @return DescribeAccountAttributesResponse
         */
        // Deprecated
        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountAttributesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeAccountAttributes is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeAccountAttributesRequest
         * @return DescribeAccountAttributesResponse
         */
        // Deprecated
        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeCapacityHistory is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeCapacityHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCapacityHistoryResponse
         */
        // Deprecated
        public DescribeCapacityHistoryResponse DescribeCapacityHistoryWithOptions(DescribeCapacityHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
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
                Action = "DescribeCapacityHistory",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapacityHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeCapacityHistory is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeCapacityHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCapacityHistoryResponse
         */
        // Deprecated
        public async Task<DescribeCapacityHistoryResponse> DescribeCapacityHistoryWithOptionsAsync(DescribeCapacityHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
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
                Action = "DescribeCapacityHistory",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapacityHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeCapacityHistory is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeCapacityHistoryRequest
         * @return DescribeCapacityHistoryResponse
         */
        // Deprecated
        public DescribeCapacityHistoryResponse DescribeCapacityHistory(DescribeCapacityHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapacityHistoryWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeCapacityHistory is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeCapacityHistoryRequest
         * @return DescribeCapacityHistoryResponse
         */
        // Deprecated
        public async Task<DescribeCapacityHistoryResponse> DescribeCapacityHistoryAsync(DescribeCapacityHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapacityHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeLimitation is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeLimitationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLimitationResponse
         */
        // Deprecated
        public DescribeLimitationResponse DescribeLimitationWithOptions(DescribeLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLimitation",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLimitationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeLimitation is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeLimitationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLimitationResponse
         */
        // Deprecated
        public async Task<DescribeLimitationResponse> DescribeLimitationWithOptionsAsync(DescribeLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLimitation",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLimitationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeLimitation is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeLimitationRequest
         * @return DescribeLimitationResponse
         */
        // Deprecated
        public DescribeLimitationResponse DescribeLimitation(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLimitationWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeLimitation is deprecated, please use Ess::2022-02-22::DescribeLimitation,Ess::2014-08-28::DescribeLimitation instead.
         *
         * @param request DescribeLimitationRequest
         * @return DescribeLimitationResponse
         */
        // Deprecated
        public async Task<DescribeLimitationResponse> DescribeLimitationAsync(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLimitationWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeRegions is deprecated, please use Ess::2022-02-22::DescribeRegions,Ess::2014-08-28::DescribeRegions instead.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        // Deprecated
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2016-07-22",
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

        /**
         * @deprecated OpenAPI DescribeRegions is deprecated, please use Ess::2022-02-22::DescribeRegions,Ess::2014-08-28::DescribeRegions instead.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        // Deprecated
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2016-07-22",
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

        /**
         * @deprecated OpenAPI DescribeRegions is deprecated, please use Ess::2022-02-22::DescribeRegions,Ess::2014-08-28::DescribeRegions instead.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        // Deprecated
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeRegions is deprecated, please use Ess::2022-02-22::DescribeRegions,Ess::2014-08-28::DescribeRegions instead.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        // Deprecated
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivities is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeScalingActivitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivitiesResponse
         */
        // Deprecated
        public DescribeScalingActivitiesResponse DescribeScalingActivitiesWithOptions(DescribeScalingActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCode))
            {
                query["StatusCode"] = request.StatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivities",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingActivitiesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivities is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeScalingActivitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivitiesResponse
         */
        // Deprecated
        public async Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesWithOptionsAsync(DescribeScalingActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCode))
            {
                query["StatusCode"] = request.StatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivities",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingActivitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivities is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeScalingActivitiesRequest
         * @return DescribeScalingActivitiesResponse
         */
        // Deprecated
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivitiesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivities is deprecated, please use Ess::2022-02-22::DescribeScalingActivities,Ess::2014-08-28::DescribeScalingActivities instead.
         *
         * @param request DescribeScalingActivitiesRequest
         * @return DescribeScalingActivitiesResponse
         */
        // Deprecated
        public async Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivitiesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivityDetail is deprecated, please use Ess::2022-02-22::DescribeScalingActivityDetail,Ess::2014-08-28::DescribeScalingActivityDetail instead.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivityDetailResponse
         */
        // Deprecated
        public DescribeScalingActivityDetailResponse DescribeScalingActivityDetailWithOptions(DescribeScalingActivityDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivityDetail",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingActivityDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivityDetail is deprecated, please use Ess::2022-02-22::DescribeScalingActivityDetail,Ess::2014-08-28::DescribeScalingActivityDetail instead.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivityDetailResponse
         */
        // Deprecated
        public async Task<DescribeScalingActivityDetailResponse> DescribeScalingActivityDetailWithOptionsAsync(DescribeScalingActivityDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivityDetail",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingActivityDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivityDetail is deprecated, please use Ess::2022-02-22::DescribeScalingActivityDetail,Ess::2014-08-28::DescribeScalingActivityDetail instead.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @return DescribeScalingActivityDetailResponse
         */
        // Deprecated
        public DescribeScalingActivityDetailResponse DescribeScalingActivityDetail(DescribeScalingActivityDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivityDetailWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingActivityDetail is deprecated, please use Ess::2022-02-22::DescribeScalingActivityDetail,Ess::2014-08-28::DescribeScalingActivityDetail instead.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @return DescribeScalingActivityDetailResponse
         */
        // Deprecated
        public async Task<DescribeScalingActivityDetailResponse> DescribeScalingActivityDetailAsync(DescribeScalingActivityDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivityDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingConfigurations is deprecated, please use Ess::2022-02-22::DescribeScalingConfigurations,Ess::2014-08-28::DescribeScalingConfigurations instead.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingConfigurationsResponse
         */
        // Deprecated
        public DescribeScalingConfigurationsResponse DescribeScalingConfigurationsWithOptions(DescribeScalingConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingConfigurations",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingConfigurations is deprecated, please use Ess::2022-02-22::DescribeScalingConfigurations,Ess::2014-08-28::DescribeScalingConfigurations instead.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingConfigurationsResponse
         */
        // Deprecated
        public async Task<DescribeScalingConfigurationsResponse> DescribeScalingConfigurationsWithOptionsAsync(DescribeScalingConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingConfigurations",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingConfigurations is deprecated, please use Ess::2022-02-22::DescribeScalingConfigurations,Ess::2014-08-28::DescribeScalingConfigurations instead.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @return DescribeScalingConfigurationsResponse
         */
        // Deprecated
        public DescribeScalingConfigurationsResponse DescribeScalingConfigurations(DescribeScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingConfigurationsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingConfigurations is deprecated, please use Ess::2022-02-22::DescribeScalingConfigurations,Ess::2014-08-28::DescribeScalingConfigurations instead.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @return DescribeScalingConfigurationsResponse
         */
        // Deprecated
        public async Task<DescribeScalingConfigurationsResponse> DescribeScalingConfigurationsAsync(DescribeScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingConfigurationsWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingGroups is deprecated, please use Ess::2022-02-22::DescribeScalingGroups,Ess::2014-08-28::DescribeScalingGroups instead.
         *
         * @param request DescribeScalingGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingGroupsResponse
         */
        // Deprecated
        public DescribeScalingGroupsResponse DescribeScalingGroupsWithOptions(DescribeScalingGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroups",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingGroups is deprecated, please use Ess::2022-02-22::DescribeScalingGroups,Ess::2014-08-28::DescribeScalingGroups instead.
         *
         * @param request DescribeScalingGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingGroupsResponse
         */
        // Deprecated
        public async Task<DescribeScalingGroupsResponse> DescribeScalingGroupsWithOptionsAsync(DescribeScalingGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroups",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingGroups is deprecated, please use Ess::2022-02-22::DescribeScalingGroups,Ess::2014-08-28::DescribeScalingGroups instead.
         *
         * @param request DescribeScalingGroupsRequest
         * @return DescribeScalingGroupsResponse
         */
        // Deprecated
        public DescribeScalingGroupsResponse DescribeScalingGroups(DescribeScalingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingGroups is deprecated, please use Ess::2022-02-22::DescribeScalingGroups,Ess::2014-08-28::DescribeScalingGroups instead.
         *
         * @param request DescribeScalingGroupsRequest
         * @return DescribeScalingGroupsResponse
         */
        // Deprecated
        public async Task<DescribeScalingGroupsResponse> DescribeScalingGroupsAsync(DescribeScalingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingInstances is deprecated, please use Ess::2022-02-22::DescribeScalingInstances,Ess::2014-08-28::DescribeScalingInstances instead.
         *
         * @param request DescribeScalingInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingInstancesResponse
         */
        // Deprecated
        public DescribeScalingInstancesResponse DescribeScalingInstancesWithOptions(DescribeScalingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationType))
            {
                query["CreationType"] = request.CreationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["HealthStatus"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleState))
            {
                query["LifecycleState"] = request.LifecycleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingInstances is deprecated, please use Ess::2022-02-22::DescribeScalingInstances,Ess::2014-08-28::DescribeScalingInstances instead.
         *
         * @param request DescribeScalingInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingInstancesResponse
         */
        // Deprecated
        public async Task<DescribeScalingInstancesResponse> DescribeScalingInstancesWithOptionsAsync(DescribeScalingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationType))
            {
                query["CreationType"] = request.CreationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["HealthStatus"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleState))
            {
                query["LifecycleState"] = request.LifecycleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingInstances is deprecated, please use Ess::2022-02-22::DescribeScalingInstances,Ess::2014-08-28::DescribeScalingInstances instead.
         *
         * @param request DescribeScalingInstancesRequest
         * @return DescribeScalingInstancesResponse
         */
        // Deprecated
        public DescribeScalingInstancesResponse DescribeScalingInstances(DescribeScalingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingInstancesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingInstances is deprecated, please use Ess::2022-02-22::DescribeScalingInstances,Ess::2014-08-28::DescribeScalingInstances instead.
         *
         * @param request DescribeScalingInstancesRequest
         * @return DescribeScalingInstancesResponse
         */
        // Deprecated
        public async Task<DescribeScalingInstancesResponse> DescribeScalingInstancesAsync(DescribeScalingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingRules is deprecated, please use Ess::2022-02-22::DescribeScalingRules,Ess::2014-08-28::DescribeScalingRules instead.
         *
         * @param request DescribeScalingRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingRulesResponse
         */
        // Deprecated
        public DescribeScalingRulesResponse DescribeScalingRulesWithOptions(DescribeScalingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleAri))
            {
                query["ScalingRuleAri"] = request.ScalingRuleAri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingRules",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingRules is deprecated, please use Ess::2022-02-22::DescribeScalingRules,Ess::2014-08-28::DescribeScalingRules instead.
         *
         * @param request DescribeScalingRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingRulesResponse
         */
        // Deprecated
        public async Task<DescribeScalingRulesResponse> DescribeScalingRulesWithOptionsAsync(DescribeScalingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleAri))
            {
                query["ScalingRuleAri"] = request.ScalingRuleAri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingRules",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScalingRules is deprecated, please use Ess::2022-02-22::DescribeScalingRules,Ess::2014-08-28::DescribeScalingRules instead.
         *
         * @param request DescribeScalingRulesRequest
         * @return DescribeScalingRulesResponse
         */
        // Deprecated
        public DescribeScalingRulesResponse DescribeScalingRules(DescribeScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingRulesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScalingRules is deprecated, please use Ess::2022-02-22::DescribeScalingRules,Ess::2014-08-28::DescribeScalingRules instead.
         *
         * @param request DescribeScalingRulesRequest
         * @return DescribeScalingRulesResponse
         */
        // Deprecated
        public async Task<DescribeScalingRulesResponse> DescribeScalingRulesAsync(DescribeScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScheduledTasks is deprecated, please use Ess::2022-02-22::DescribeScheduledTasks,Ess::2014-08-28::DescribeScheduledTasks instead.
         *
         * @param request DescribeScheduledTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScheduledTasksResponse
         */
        // Deprecated
        public DescribeScheduledTasksResponse DescribeScheduledTasksWithOptions(DescribeScheduledTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledAction))
            {
                query["ScheduledAction"] = request.ScheduledAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskId))
            {
                query["ScheduledTaskId"] = request.ScheduledTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskName))
            {
                query["ScheduledTaskName"] = request.ScheduledTaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScheduledTasks",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScheduledTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScheduledTasks is deprecated, please use Ess::2022-02-22::DescribeScheduledTasks,Ess::2014-08-28::DescribeScheduledTasks instead.
         *
         * @param request DescribeScheduledTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScheduledTasksResponse
         */
        // Deprecated
        public async Task<DescribeScheduledTasksResponse> DescribeScheduledTasksWithOptionsAsync(DescribeScheduledTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledAction))
            {
                query["ScheduledAction"] = request.ScheduledAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskId))
            {
                query["ScheduledTaskId"] = request.ScheduledTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskName))
            {
                query["ScheduledTaskName"] = request.ScheduledTaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScheduledTasks",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScheduledTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeScheduledTasks is deprecated, please use Ess::2022-02-22::DescribeScheduledTasks,Ess::2014-08-28::DescribeScheduledTasks instead.
         *
         * @param request DescribeScheduledTasksRequest
         * @return DescribeScheduledTasksResponse
         */
        // Deprecated
        public DescribeScheduledTasksResponse DescribeScheduledTasks(DescribeScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduledTasksWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeScheduledTasks is deprecated, please use Ess::2022-02-22::DescribeScheduledTasks,Ess::2014-08-28::DescribeScheduledTasks instead.
         *
         * @param request DescribeScheduledTasksRequest
         * @return DescribeScheduledTasksResponse
         */
        // Deprecated
        public async Task<DescribeScheduledTasksResponse> DescribeScheduledTasksAsync(DescribeScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduledTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DetachInstances is deprecated, please use Ess::2022-02-22::DetachInstances,Ess::2014-08-28::DetachInstances instead.
         *
         * @param request DetachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachInstancesResponse
         */
        // Deprecated
        public DetachInstancesResponse DetachInstancesWithOptions(DetachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DetachInstances is deprecated, please use Ess::2022-02-22::DetachInstances,Ess::2014-08-28::DetachInstances instead.
         *
         * @param request DetachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachInstancesResponse
         */
        // Deprecated
        public async Task<DetachInstancesResponse> DetachInstancesWithOptionsAsync(DetachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DetachInstances is deprecated, please use Ess::2022-02-22::DetachInstances,Ess::2014-08-28::DetachInstances instead.
         *
         * @param request DetachInstancesRequest
         * @return DetachInstancesResponse
         */
        // Deprecated
        public DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachInstancesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DetachInstances is deprecated, please use Ess::2022-02-22::DetachInstances,Ess::2014-08-28::DetachInstances instead.
         *
         * @param request DetachInstancesRequest
         * @return DetachInstancesResponse
         */
        // Deprecated
        public async Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DisableScalingGroup is deprecated, please use Ess::2022-02-22::DisableScalingGroup,Ess::2014-08-28::DisableScalingGroup instead.
         *
         * @param request DisableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableScalingGroupResponse
         */
        // Deprecated
        public DisableScalingGroupResponse DisableScalingGroupWithOptions(DisableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableScalingGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DisableScalingGroup is deprecated, please use Ess::2022-02-22::DisableScalingGroup,Ess::2014-08-28::DisableScalingGroup instead.
         *
         * @param request DisableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableScalingGroupResponse
         */
        // Deprecated
        public async Task<DisableScalingGroupResponse> DisableScalingGroupWithOptionsAsync(DisableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableScalingGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DisableScalingGroup is deprecated, please use Ess::2022-02-22::DisableScalingGroup,Ess::2014-08-28::DisableScalingGroup instead.
         *
         * @param request DisableScalingGroupRequest
         * @return DisableScalingGroupResponse
         */
        // Deprecated
        public DisableScalingGroupResponse DisableScalingGroup(DisableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableScalingGroupWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DisableScalingGroup is deprecated, please use Ess::2022-02-22::DisableScalingGroup,Ess::2014-08-28::DisableScalingGroup instead.
         *
         * @param request DisableScalingGroupRequest
         * @return DisableScalingGroupResponse
         */
        // Deprecated
        public async Task<DisableScalingGroupResponse> DisableScalingGroupAsync(DisableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI EnableScalingGroup is deprecated, please use Ess::2014-08-28::EnableScalingGroup,Ess::2022-02-22::EnableScalingGroup instead.
         *
         * @param request EnableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableScalingGroupResponse
         */
        // Deprecated
        public EnableScalingGroupResponse EnableScalingGroupWithOptions(EnableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableScalingGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI EnableScalingGroup is deprecated, please use Ess::2014-08-28::EnableScalingGroup,Ess::2022-02-22::EnableScalingGroup instead.
         *
         * @param request EnableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableScalingGroupResponse
         */
        // Deprecated
        public async Task<EnableScalingGroupResponse> EnableScalingGroupWithOptionsAsync(EnableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableScalingGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI EnableScalingGroup is deprecated, please use Ess::2014-08-28::EnableScalingGroup,Ess::2022-02-22::EnableScalingGroup instead.
         *
         * @param request EnableScalingGroupRequest
         * @return EnableScalingGroupResponse
         */
        // Deprecated
        public EnableScalingGroupResponse EnableScalingGroup(EnableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableScalingGroupWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI EnableScalingGroup is deprecated, please use Ess::2014-08-28::EnableScalingGroup,Ess::2022-02-22::EnableScalingGroup instead.
         *
         * @param request EnableScalingGroupRequest
         * @return EnableScalingGroupResponse
         */
        // Deprecated
        public async Task<EnableScalingGroupResponse> EnableScalingGroupAsync(EnableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI ExecuteScalingRule is deprecated, please use Ess::2014-08-28::ExecuteScalingRule,Ess::2022-02-22::ExecuteScalingRule instead.
         *
         * @param request ExecuteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteScalingRuleResponse
         */
        // Deprecated
        public ExecuteScalingRuleResponse ExecuteScalingRuleWithOptions(ExecuteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleAri))
            {
                query["ScalingRuleAri"] = request.ScalingRuleAri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ExecuteScalingRule is deprecated, please use Ess::2014-08-28::ExecuteScalingRule,Ess::2022-02-22::ExecuteScalingRule instead.
         *
         * @param request ExecuteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteScalingRuleResponse
         */
        // Deprecated
        public async Task<ExecuteScalingRuleResponse> ExecuteScalingRuleWithOptionsAsync(ExecuteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleAri))
            {
                query["ScalingRuleAri"] = request.ScalingRuleAri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ExecuteScalingRule is deprecated, please use Ess::2014-08-28::ExecuteScalingRule,Ess::2022-02-22::ExecuteScalingRule instead.
         *
         * @param request ExecuteScalingRuleRequest
         * @return ExecuteScalingRuleResponse
         */
        // Deprecated
        public ExecuteScalingRuleResponse ExecuteScalingRule(ExecuteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteScalingRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI ExecuteScalingRule is deprecated, please use Ess::2014-08-28::ExecuteScalingRule,Ess::2022-02-22::ExecuteScalingRule instead.
         *
         * @param request ExecuteScalingRuleRequest
         * @return ExecuteScalingRuleResponse
         */
        // Deprecated
        public async Task<ExecuteScalingRuleResponse> ExecuteScalingRuleAsync(ExecuteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI ModifyScalingGroup is deprecated, please use Ess::2014-08-28::ModifyScalingGroup,Ess::2022-02-22::ModifyScalingGroup instead.
         *
         * @param request ModifyScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingGroupResponse
         */
        // Deprecated
        public ModifyScalingGroupResponse ModifyScalingGroupWithOptions(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicy))
            {
                query["RemovalPolicy"] = request.RemovalPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ModifyScalingGroup is deprecated, please use Ess::2014-08-28::ModifyScalingGroup,Ess::2022-02-22::ModifyScalingGroup instead.
         *
         * @param request ModifyScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingGroupResponse
         */
        // Deprecated
        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupWithOptionsAsync(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicy))
            {
                query["RemovalPolicy"] = request.RemovalPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingGroup",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ModifyScalingGroup is deprecated, please use Ess::2014-08-28::ModifyScalingGroup,Ess::2022-02-22::ModifyScalingGroup instead.
         *
         * @param request ModifyScalingGroupRequest
         * @return ModifyScalingGroupResponse
         */
        // Deprecated
        public ModifyScalingGroupResponse ModifyScalingGroup(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingGroupWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI ModifyScalingGroup is deprecated, please use Ess::2014-08-28::ModifyScalingGroup,Ess::2022-02-22::ModifyScalingGroup instead.
         *
         * @param request ModifyScalingGroupRequest
         * @return ModifyScalingGroupResponse
         */
        // Deprecated
        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupAsync(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI ModifyScalingRule is deprecated, please use Ess::2014-08-28::ModifyScalingRule,Ess::2022-02-22::ModifyScalingRule instead.
         *
         * @param request ModifyScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingRuleResponse
         */
        // Deprecated
        public ModifyScalingRuleResponse ModifyScalingRuleWithOptions(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentType))
            {
                query["AdjustmentType"] = request.AdjustmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentValue))
            {
                query["AdjustmentValue"] = request.AdjustmentValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ModifyScalingRule is deprecated, please use Ess::2014-08-28::ModifyScalingRule,Ess::2022-02-22::ModifyScalingRule instead.
         *
         * @param request ModifyScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingRuleResponse
         */
        // Deprecated
        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentType))
            {
                query["AdjustmentType"] = request.AdjustmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentValue))
            {
                query["AdjustmentValue"] = request.AdjustmentValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ModifyScalingRule is deprecated, please use Ess::2014-08-28::ModifyScalingRule,Ess::2022-02-22::ModifyScalingRule instead.
         *
         * @param request ModifyScalingRuleRequest
         * @return ModifyScalingRuleResponse
         */
        // Deprecated
        public ModifyScalingRuleResponse ModifyScalingRule(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI ModifyScalingRule is deprecated, please use Ess::2014-08-28::ModifyScalingRule,Ess::2022-02-22::ModifyScalingRule instead.
         *
         * @param request ModifyScalingRuleRequest
         * @return ModifyScalingRuleResponse
         */
        // Deprecated
        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleAsync(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI ModifyScheduledTask is deprecated, please use Ess::2014-08-28::ModifyScheduledTask,Ess::2022-02-22::ModifyScheduledTask instead.
         *
         * @param request ModifyScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScheduledTaskResponse
         */
        // Deprecated
        public ModifyScheduledTaskResponse ModifyScheduledTaskWithOptions(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceEndTime))
            {
                query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceType))
            {
                query["RecurrenceType"] = request.RecurrenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValue))
            {
                query["RecurrenceValue"] = request.RecurrenceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledAction))
            {
                query["ScheduledAction"] = request.ScheduledAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskId))
            {
                query["ScheduledTaskId"] = request.ScheduledTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskName))
            {
                query["ScheduledTaskName"] = request.ScheduledTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEnabled))
            {
                query["TaskEnabled"] = request.TaskEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledTask",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ModifyScheduledTask is deprecated, please use Ess::2014-08-28::ModifyScheduledTask,Ess::2022-02-22::ModifyScheduledTask instead.
         *
         * @param request ModifyScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScheduledTaskResponse
         */
        // Deprecated
        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskWithOptionsAsync(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceEndTime))
            {
                query["RecurrenceEndTime"] = request.RecurrenceEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceType))
            {
                query["RecurrenceType"] = request.RecurrenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecurrenceValue))
            {
                query["RecurrenceValue"] = request.RecurrenceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledAction))
            {
                query["ScheduledAction"] = request.ScheduledAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskId))
            {
                query["ScheduledTaskId"] = request.ScheduledTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskName))
            {
                query["ScheduledTaskName"] = request.ScheduledTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEnabled))
            {
                query["TaskEnabled"] = request.TaskEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledTask",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ModifyScheduledTask is deprecated, please use Ess::2014-08-28::ModifyScheduledTask,Ess::2022-02-22::ModifyScheduledTask instead.
         *
         * @param request ModifyScheduledTaskRequest
         * @return ModifyScheduledTaskResponse
         */
        // Deprecated
        public ModifyScheduledTaskResponse ModifyScheduledTask(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduledTaskWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI ModifyScheduledTask is deprecated, please use Ess::2014-08-28::ModifyScheduledTask,Ess::2022-02-22::ModifyScheduledTask instead.
         *
         * @param request ModifyScheduledTaskRequest
         * @return ModifyScheduledTaskResponse
         */
        // Deprecated
        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskAsync(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduledTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveInstances is deprecated, please use Ess::2014-08-28::RemoveInstances,Ess::2022-02-22::RemoveInstances instead.
         *
         * @param request RemoveInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveInstancesResponse
         */
        // Deprecated
        public RemoveInstancesResponse RemoveInstancesWithOptions(RemoveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveInstances is deprecated, please use Ess::2014-08-28::RemoveInstances,Ess::2022-02-22::RemoveInstances instead.
         *
         * @param request RemoveInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveInstancesResponse
         */
        // Deprecated
        public async Task<RemoveInstancesResponse> RemoveInstancesWithOptionsAsync(RemoveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstances",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveInstances is deprecated, please use Ess::2014-08-28::RemoveInstances,Ess::2022-02-22::RemoveInstances instead.
         *
         * @param request RemoveInstancesRequest
         * @return RemoveInstancesResponse
         */
        // Deprecated
        public RemoveInstancesResponse RemoveInstances(RemoveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveInstancesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveInstances is deprecated, please use Ess::2014-08-28::RemoveInstances,Ess::2022-02-22::RemoveInstances instead.
         *
         * @param request RemoveInstancesRequest
         * @return RemoveInstancesResponse
         */
        // Deprecated
        public async Task<RemoveInstancesResponse> RemoveInstancesAsync(RemoveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI VerifyAuthentication is deprecated, please use Ess::2014-08-28::VerifyAuthentication instead.
         *
         * @param request VerifyAuthenticationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyAuthenticationResponse
         */
        // Deprecated
        public VerifyAuthenticationResponse VerifyAuthenticationWithOptions(VerifyAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyAuthentication",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyAuthenticationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI VerifyAuthentication is deprecated, please use Ess::2014-08-28::VerifyAuthentication instead.
         *
         * @param request VerifyAuthenticationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyAuthenticationResponse
         */
        // Deprecated
        public async Task<VerifyAuthenticationResponse> VerifyAuthenticationWithOptionsAsync(VerifyAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyAuthentication",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyAuthenticationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI VerifyAuthentication is deprecated, please use Ess::2014-08-28::VerifyAuthentication instead.
         *
         * @param request VerifyAuthenticationRequest
         * @return VerifyAuthenticationResponse
         */
        // Deprecated
        public VerifyAuthenticationResponse VerifyAuthentication(VerifyAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyAuthenticationWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI VerifyAuthentication is deprecated, please use Ess::2014-08-28::VerifyAuthentication instead.
         *
         * @param request VerifyAuthenticationRequest
         * @return VerifyAuthenticationResponse
         */
        // Deprecated
        public async Task<VerifyAuthenticationResponse> VerifyAuthenticationAsync(VerifyAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyAuthenticationWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI VerifyUser is deprecated, please use Ess::2014-08-28::VerifyUser instead.
         *
         * @param request VerifyUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyUserResponse
         */
        // Deprecated
        public VerifyUserResponse VerifyUserWithOptions(VerifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyUser",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "none",
            };
            return TeaModel.ToObject<VerifyUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI VerifyUser is deprecated, please use Ess::2014-08-28::VerifyUser instead.
         *
         * @param request VerifyUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyUserResponse
         */
        // Deprecated
        public async Task<VerifyUserResponse> VerifyUserWithOptionsAsync(VerifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyUser",
                Version = "2016-07-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "none",
            };
            return TeaModel.ToObject<VerifyUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI VerifyUser is deprecated, please use Ess::2014-08-28::VerifyUser instead.
         *
         * @param request VerifyUserRequest
         * @return VerifyUserResponse
         */
        // Deprecated
        public VerifyUserResponse VerifyUser(VerifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyUserWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI VerifyUser is deprecated, please use Ess::2014-08-28::VerifyUser instead.
         *
         * @param request VerifyUserRequest
         * @return VerifyUserResponse
         */
        // Deprecated
        public async Task<VerifyUserResponse> VerifyUserAsync(VerifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyUserWithOptionsAsync(request, runtime);
        }

    }
}
