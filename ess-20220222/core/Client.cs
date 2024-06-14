// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ess20220222.Models;

namespace AlibabaCloud.SDK.Ess20220222
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
         * @summary Manages scaling configurations of the Elastic Container Instance type. If you want to efficiently create or update a scaling configuration of the Elastic Container Instance type by using a configuration file, you can call the ApplyEciScalingConfiguration operation.
         *
         * @description You can manage scaling configurations of the Elastic Container Instance type by using a YAML configuration file based on the following logic:
         * If you specify the ID of a scaling configuration, you can update the scaling configuration by using the YAML configuration file. If you do not specify the ID of a scaling configuration, you can create a scaling configuration by using the YAML configuration file.
         *
         * @param request ApplyEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyEciScalingConfigurationResponse
         */
        public ApplyEciScalingConfigurationResponse ApplyEciScalingConfigurationWithOptions(ApplyEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
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
                Action = "ApplyEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyEciScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Manages scaling configurations of the Elastic Container Instance type. If you want to efficiently create or update a scaling configuration of the Elastic Container Instance type by using a configuration file, you can call the ApplyEciScalingConfiguration operation.
         *
         * @description You can manage scaling configurations of the Elastic Container Instance type by using a YAML configuration file based on the following logic:
         * If you specify the ID of a scaling configuration, you can update the scaling configuration by using the YAML configuration file. If you do not specify the ID of a scaling configuration, you can create a scaling configuration by using the YAML configuration file.
         *
         * @param request ApplyEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyEciScalingConfigurationResponse
         */
        public async Task<ApplyEciScalingConfigurationResponse> ApplyEciScalingConfigurationWithOptionsAsync(ApplyEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
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
                Action = "ApplyEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyEciScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Manages scaling configurations of the Elastic Container Instance type. If you want to efficiently create or update a scaling configuration of the Elastic Container Instance type by using a configuration file, you can call the ApplyEciScalingConfiguration operation.
         *
         * @description You can manage scaling configurations of the Elastic Container Instance type by using a YAML configuration file based on the following logic:
         * If you specify the ID of a scaling configuration, you can update the scaling configuration by using the YAML configuration file. If you do not specify the ID of a scaling configuration, you can create a scaling configuration by using the YAML configuration file.
         *
         * @param request ApplyEciScalingConfigurationRequest
         * @return ApplyEciScalingConfigurationResponse
         */
        public ApplyEciScalingConfigurationResponse ApplyEciScalingConfiguration(ApplyEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyEciScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Manages scaling configurations of the Elastic Container Instance type. If you want to efficiently create or update a scaling configuration of the Elastic Container Instance type by using a configuration file, you can call the ApplyEciScalingConfiguration operation.
         *
         * @description You can manage scaling configurations of the Elastic Container Instance type by using a YAML configuration file based on the following logic:
         * If you specify the ID of a scaling configuration, you can update the scaling configuration by using the YAML configuration file. If you do not specify the ID of a scaling configuration, you can create a scaling configuration by using the YAML configuration file.
         *
         * @param request ApplyEciScalingConfigurationRequest
         * @return ApplyEciScalingConfigurationResponse
         */
        public async Task<ApplyEciScalingConfigurationResponse> ApplyEciScalingConfigurationAsync(ApplyEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyEciScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 基于yaml配置进行弹性伸缩管理
         *
         * @description You can call the ApplyScalingGroup operation to create scaling groups of the Elastic Container Instance type with ease. The resources of the scaling groups are defined in Kubernetes Deployment YAML files. You can also call this operation to extend annotations for elastic container instances in Kubernetes Deployment YAML files. For more information, see "Supported annotations" in this topic.
         * Mapping between YAML files and scaling groups: You can map the triplet of namespace, kind, and name in a YAML file to a scaling group name. A YAML file and a scaling group have a one-to-one mapping relationship in a region. For example, if you use the Kubernetes Deployment YAML file whose name is NGINX in the default namespace to create a scaling group in a region, the unique name of the mapped scaling group is k8s_default_Deployment_nginx.
         * You can use a Kubernetes Deployment YAML file to manage a scaling group based on the following logic:
         * * If an existing scaling group has a mapping relationship with your Kubernetes Deployment YAML file, you can update the scaling group by using the YAML file.
         * * If no scaling group that has a mapping relationship with your Kubernetes Deployment YAML file exists, you can create a scaling group with ease by using the YAML file.
         * ### Precautions
         * 1. If you do not specify a virtual private cloud (VPC), vSwitch, security group, or annotation in your Kubernetes Deployment YAML file, the system creates a default VPC that has default vSwitches and uses the default security group ess-default-sg of Auto Scaling. By default, the security group rule allows traffic on Transmission Control Protocol (TCP)-based port 22 and port 3389 and enables Internet Control Message Protocol (ICMP) for IPv4 addresses. If you want to enable other ports or protocols, you can create custom security group rules.
         * 2. If you want to use a public image, you must enable the Internet access feature and configure the k8s.aliyun.com/eci-with-eip pod annotation to enable the elastic IP address (EIP) feature.
         * 3. After you call the ApplyScalingGroup operation to apply a Kubernetes Deployment YAML file, the scaling group immediately enters the Enabled state and the scaling configuration immediately enters the Active state. If the number of replicas that you specified in the YAML file is grater than 0, elastic container instances are automatically created.
         * ### Supported annotations
         * For more information about annotations, see [ECI Pod Annotation](https://help.aliyun.com/document_detail/186939.html).
         * |Annotation|Example|Description|
         * |---|---|---|
         * |k8s.aliyun.com/ess-scaling-group-min-size|1|The minimum size of the scaling group that you want to create. Default value: 0.|
         * |k8s.aliyun.com/ess-scaling-group-max-size|20|The maximum size of the scaling group that you want to create. Default value: maximum number of replicas or 30, whichever is greater.|
         * |k8s.aliyun.com/eci-ntp-server|100.100.*.*|The IP address of the Network Time Protocol (NTP) server.|
         * |k8s.aliyun.com/eci-use-specs|2-4Gi|The specifications of 2 vCPUs and 4 GB memory. For more information, see [Create pods by specifying multiple specifications](https://help.aliyun.com/document_detail/451267.html).|
         * |k8s.aliyun.com/eci-vswitch|vsw-bp1xpiowfm5vo8o3c\\*\\*\\*\\*|The ID of the vSwitch. You can specify multiple vSwitches to specify multiple zones.|
         * |k8s.aliyun.com/eci-security-group|sg-bp1dktddjsg5nktv\\*\\*\\*\\*|The ID of the security group. Before you configure this annotation, take note of the following requirements:<ul data-sourcepos="26:74-26:168"><li data-sourcepos="26:78-26:114">You can specify one or more security groups. You can specify up to five security groups for each scaling group.</li><li data-sourcepos="26:114-26:140">If you specify multiple security groups, the security groups must belong to the same VPC.</li><li data-sourcepos="26:140-26:163">If you specify multiple security groups, the security groups must be of the same type.</li></ul>|
         * |k8s.aliyun.com/eci-sls-enable|"false"|If you set the value to false, the log collection feature is disabled.
         * If you do not want to use Custom Resource Definition (CRD) for Simple Log Service to collect logs of specific pods, you can configure this annotation for the pods and set the value to false. This prevents resource wastes caused by Logtails created by the system.|
         * |k8s.aliyun.com/eci-spot-strategy|SpotAsPriceGo|The bidding policy for the preemptible instance. Valid values:<ul data-sourcepos="28:69-28:204"><li data-sourcepos="28:73-28:158">SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price If you set the value to SpotWithPriceLimit, you must configure the k8s.aliyun.com/eci-spot-price-limit annotation.</li><li data-sourcepos="28:158-28:199">SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is used as the bid price.</li></ul>|
         * |k8s.aliyun.com/eci-spot-price-limit|"0.5"|The maximum hourly price of the preemptible instance. This value can be accurate to up to three decimal places.
         * This annotation takes effect only when you set the k8s.aliyun.com/eci-spot-strategy annotation to SpotWithPriceLimit.|
         * |k8s.aliyun.com/eci-with-eip|"true"|If you set the value to true, an EIP is automatically created and bound to each elastic container instance.|
         * |k8s.aliyun.com/eci-data-cache-bucket|default|The bucket of the specified DataCache. If you want to use a DataCache to create a pod, you must configure this annotation.|
         * |k8s.aliyun.com/eci-data-cache-pl|PL1|The performance level (PL) of the cloud disk that you want to create by using the specified DataCache.
         * By default, enhanced SSDs (ESSDs) are created. Default value: PL1.|
         * |k8s.aliyun.com/eci-data-cache-provisionedIops|"40000"|The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-data-cache-burstingEnabled|"true"|Specifies whether the Burst feature is enabled for the ESSD AutoPL disk. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-custom-tags|"env:test,name:alice"|The tags that you want to add to each elastic container instance. You can add up to three tags for each elastic container instance. Separate a tag key and a tag value with a colon (:). Separate multiple tags with commas (,).|
         *
         * @param request ApplyScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyScalingGroupResponse
         */
        public ApplyScalingGroupResponse ApplyScalingGroupWithOptions(ApplyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
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
                Action = "ApplyScalingGroup",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyScalingGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 基于yaml配置进行弹性伸缩管理
         *
         * @description You can call the ApplyScalingGroup operation to create scaling groups of the Elastic Container Instance type with ease. The resources of the scaling groups are defined in Kubernetes Deployment YAML files. You can also call this operation to extend annotations for elastic container instances in Kubernetes Deployment YAML files. For more information, see "Supported annotations" in this topic.
         * Mapping between YAML files and scaling groups: You can map the triplet of namespace, kind, and name in a YAML file to a scaling group name. A YAML file and a scaling group have a one-to-one mapping relationship in a region. For example, if you use the Kubernetes Deployment YAML file whose name is NGINX in the default namespace to create a scaling group in a region, the unique name of the mapped scaling group is k8s_default_Deployment_nginx.
         * You can use a Kubernetes Deployment YAML file to manage a scaling group based on the following logic:
         * * If an existing scaling group has a mapping relationship with your Kubernetes Deployment YAML file, you can update the scaling group by using the YAML file.
         * * If no scaling group that has a mapping relationship with your Kubernetes Deployment YAML file exists, you can create a scaling group with ease by using the YAML file.
         * ### Precautions
         * 1. If you do not specify a virtual private cloud (VPC), vSwitch, security group, or annotation in your Kubernetes Deployment YAML file, the system creates a default VPC that has default vSwitches and uses the default security group ess-default-sg of Auto Scaling. By default, the security group rule allows traffic on Transmission Control Protocol (TCP)-based port 22 and port 3389 and enables Internet Control Message Protocol (ICMP) for IPv4 addresses. If you want to enable other ports or protocols, you can create custom security group rules.
         * 2. If you want to use a public image, you must enable the Internet access feature and configure the k8s.aliyun.com/eci-with-eip pod annotation to enable the elastic IP address (EIP) feature.
         * 3. After you call the ApplyScalingGroup operation to apply a Kubernetes Deployment YAML file, the scaling group immediately enters the Enabled state and the scaling configuration immediately enters the Active state. If the number of replicas that you specified in the YAML file is grater than 0, elastic container instances are automatically created.
         * ### Supported annotations
         * For more information about annotations, see [ECI Pod Annotation](https://help.aliyun.com/document_detail/186939.html).
         * |Annotation|Example|Description|
         * |---|---|---|
         * |k8s.aliyun.com/ess-scaling-group-min-size|1|The minimum size of the scaling group that you want to create. Default value: 0.|
         * |k8s.aliyun.com/ess-scaling-group-max-size|20|The maximum size of the scaling group that you want to create. Default value: maximum number of replicas or 30, whichever is greater.|
         * |k8s.aliyun.com/eci-ntp-server|100.100.*.*|The IP address of the Network Time Protocol (NTP) server.|
         * |k8s.aliyun.com/eci-use-specs|2-4Gi|The specifications of 2 vCPUs and 4 GB memory. For more information, see [Create pods by specifying multiple specifications](https://help.aliyun.com/document_detail/451267.html).|
         * |k8s.aliyun.com/eci-vswitch|vsw-bp1xpiowfm5vo8o3c\\*\\*\\*\\*|The ID of the vSwitch. You can specify multiple vSwitches to specify multiple zones.|
         * |k8s.aliyun.com/eci-security-group|sg-bp1dktddjsg5nktv\\*\\*\\*\\*|The ID of the security group. Before you configure this annotation, take note of the following requirements:<ul data-sourcepos="26:74-26:168"><li data-sourcepos="26:78-26:114">You can specify one or more security groups. You can specify up to five security groups for each scaling group.</li><li data-sourcepos="26:114-26:140">If you specify multiple security groups, the security groups must belong to the same VPC.</li><li data-sourcepos="26:140-26:163">If you specify multiple security groups, the security groups must be of the same type.</li></ul>|
         * |k8s.aliyun.com/eci-sls-enable|"false"|If you set the value to false, the log collection feature is disabled.
         * If you do not want to use Custom Resource Definition (CRD) for Simple Log Service to collect logs of specific pods, you can configure this annotation for the pods and set the value to false. This prevents resource wastes caused by Logtails created by the system.|
         * |k8s.aliyun.com/eci-spot-strategy|SpotAsPriceGo|The bidding policy for the preemptible instance. Valid values:<ul data-sourcepos="28:69-28:204"><li data-sourcepos="28:73-28:158">SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price If you set the value to SpotWithPriceLimit, you must configure the k8s.aliyun.com/eci-spot-price-limit annotation.</li><li data-sourcepos="28:158-28:199">SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is used as the bid price.</li></ul>|
         * |k8s.aliyun.com/eci-spot-price-limit|"0.5"|The maximum hourly price of the preemptible instance. This value can be accurate to up to three decimal places.
         * This annotation takes effect only when you set the k8s.aliyun.com/eci-spot-strategy annotation to SpotWithPriceLimit.|
         * |k8s.aliyun.com/eci-with-eip|"true"|If you set the value to true, an EIP is automatically created and bound to each elastic container instance.|
         * |k8s.aliyun.com/eci-data-cache-bucket|default|The bucket of the specified DataCache. If you want to use a DataCache to create a pod, you must configure this annotation.|
         * |k8s.aliyun.com/eci-data-cache-pl|PL1|The performance level (PL) of the cloud disk that you want to create by using the specified DataCache.
         * By default, enhanced SSDs (ESSDs) are created. Default value: PL1.|
         * |k8s.aliyun.com/eci-data-cache-provisionedIops|"40000"|The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-data-cache-burstingEnabled|"true"|Specifies whether the Burst feature is enabled for the ESSD AutoPL disk. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-custom-tags|"env:test,name:alice"|The tags that you want to add to each elastic container instance. You can add up to three tags for each elastic container instance. Separate a tag key and a tag value with a colon (:). Separate multiple tags with commas (,).|
         *
         * @param request ApplyScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyScalingGroupResponse
         */
        public async Task<ApplyScalingGroupResponse> ApplyScalingGroupWithOptionsAsync(ApplyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
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
                Action = "ApplyScalingGroup",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyScalingGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 基于yaml配置进行弹性伸缩管理
         *
         * @description You can call the ApplyScalingGroup operation to create scaling groups of the Elastic Container Instance type with ease. The resources of the scaling groups are defined in Kubernetes Deployment YAML files. You can also call this operation to extend annotations for elastic container instances in Kubernetes Deployment YAML files. For more information, see "Supported annotations" in this topic.
         * Mapping between YAML files and scaling groups: You can map the triplet of namespace, kind, and name in a YAML file to a scaling group name. A YAML file and a scaling group have a one-to-one mapping relationship in a region. For example, if you use the Kubernetes Deployment YAML file whose name is NGINX in the default namespace to create a scaling group in a region, the unique name of the mapped scaling group is k8s_default_Deployment_nginx.
         * You can use a Kubernetes Deployment YAML file to manage a scaling group based on the following logic:
         * * If an existing scaling group has a mapping relationship with your Kubernetes Deployment YAML file, you can update the scaling group by using the YAML file.
         * * If no scaling group that has a mapping relationship with your Kubernetes Deployment YAML file exists, you can create a scaling group with ease by using the YAML file.
         * ### Precautions
         * 1. If you do not specify a virtual private cloud (VPC), vSwitch, security group, or annotation in your Kubernetes Deployment YAML file, the system creates a default VPC that has default vSwitches and uses the default security group ess-default-sg of Auto Scaling. By default, the security group rule allows traffic on Transmission Control Protocol (TCP)-based port 22 and port 3389 and enables Internet Control Message Protocol (ICMP) for IPv4 addresses. If you want to enable other ports or protocols, you can create custom security group rules.
         * 2. If you want to use a public image, you must enable the Internet access feature and configure the k8s.aliyun.com/eci-with-eip pod annotation to enable the elastic IP address (EIP) feature.
         * 3. After you call the ApplyScalingGroup operation to apply a Kubernetes Deployment YAML file, the scaling group immediately enters the Enabled state and the scaling configuration immediately enters the Active state. If the number of replicas that you specified in the YAML file is grater than 0, elastic container instances are automatically created.
         * ### Supported annotations
         * For more information about annotations, see [ECI Pod Annotation](https://help.aliyun.com/document_detail/186939.html).
         * |Annotation|Example|Description|
         * |---|---|---|
         * |k8s.aliyun.com/ess-scaling-group-min-size|1|The minimum size of the scaling group that you want to create. Default value: 0.|
         * |k8s.aliyun.com/ess-scaling-group-max-size|20|The maximum size of the scaling group that you want to create. Default value: maximum number of replicas or 30, whichever is greater.|
         * |k8s.aliyun.com/eci-ntp-server|100.100.*.*|The IP address of the Network Time Protocol (NTP) server.|
         * |k8s.aliyun.com/eci-use-specs|2-4Gi|The specifications of 2 vCPUs and 4 GB memory. For more information, see [Create pods by specifying multiple specifications](https://help.aliyun.com/document_detail/451267.html).|
         * |k8s.aliyun.com/eci-vswitch|vsw-bp1xpiowfm5vo8o3c\\*\\*\\*\\*|The ID of the vSwitch. You can specify multiple vSwitches to specify multiple zones.|
         * |k8s.aliyun.com/eci-security-group|sg-bp1dktddjsg5nktv\\*\\*\\*\\*|The ID of the security group. Before you configure this annotation, take note of the following requirements:<ul data-sourcepos="26:74-26:168"><li data-sourcepos="26:78-26:114">You can specify one or more security groups. You can specify up to five security groups for each scaling group.</li><li data-sourcepos="26:114-26:140">If you specify multiple security groups, the security groups must belong to the same VPC.</li><li data-sourcepos="26:140-26:163">If you specify multiple security groups, the security groups must be of the same type.</li></ul>|
         * |k8s.aliyun.com/eci-sls-enable|"false"|If you set the value to false, the log collection feature is disabled.
         * If you do not want to use Custom Resource Definition (CRD) for Simple Log Service to collect logs of specific pods, you can configure this annotation for the pods and set the value to false. This prevents resource wastes caused by Logtails created by the system.|
         * |k8s.aliyun.com/eci-spot-strategy|SpotAsPriceGo|The bidding policy for the preemptible instance. Valid values:<ul data-sourcepos="28:69-28:204"><li data-sourcepos="28:73-28:158">SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price If you set the value to SpotWithPriceLimit, you must configure the k8s.aliyun.com/eci-spot-price-limit annotation.</li><li data-sourcepos="28:158-28:199">SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is used as the bid price.</li></ul>|
         * |k8s.aliyun.com/eci-spot-price-limit|"0.5"|The maximum hourly price of the preemptible instance. This value can be accurate to up to three decimal places.
         * This annotation takes effect only when you set the k8s.aliyun.com/eci-spot-strategy annotation to SpotWithPriceLimit.|
         * |k8s.aliyun.com/eci-with-eip|"true"|If you set the value to true, an EIP is automatically created and bound to each elastic container instance.|
         * |k8s.aliyun.com/eci-data-cache-bucket|default|The bucket of the specified DataCache. If you want to use a DataCache to create a pod, you must configure this annotation.|
         * |k8s.aliyun.com/eci-data-cache-pl|PL1|The performance level (PL) of the cloud disk that you want to create by using the specified DataCache.
         * By default, enhanced SSDs (ESSDs) are created. Default value: PL1.|
         * |k8s.aliyun.com/eci-data-cache-provisionedIops|"40000"|The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-data-cache-burstingEnabled|"true"|Specifies whether the Burst feature is enabled for the ESSD AutoPL disk. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-custom-tags|"env:test,name:alice"|The tags that you want to add to each elastic container instance. You can add up to three tags for each elastic container instance. Separate a tag key and a tag value with a colon (:). Separate multiple tags with commas (,).|
         *
         * @param request ApplyScalingGroupRequest
         * @return ApplyScalingGroupResponse
         */
        public ApplyScalingGroupResponse ApplyScalingGroup(ApplyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyScalingGroupWithOptions(request, runtime);
        }

        /**
         * @summary 基于yaml配置进行弹性伸缩管理
         *
         * @description You can call the ApplyScalingGroup operation to create scaling groups of the Elastic Container Instance type with ease. The resources of the scaling groups are defined in Kubernetes Deployment YAML files. You can also call this operation to extend annotations for elastic container instances in Kubernetes Deployment YAML files. For more information, see "Supported annotations" in this topic.
         * Mapping between YAML files and scaling groups: You can map the triplet of namespace, kind, and name in a YAML file to a scaling group name. A YAML file and a scaling group have a one-to-one mapping relationship in a region. For example, if you use the Kubernetes Deployment YAML file whose name is NGINX in the default namespace to create a scaling group in a region, the unique name of the mapped scaling group is k8s_default_Deployment_nginx.
         * You can use a Kubernetes Deployment YAML file to manage a scaling group based on the following logic:
         * * If an existing scaling group has a mapping relationship with your Kubernetes Deployment YAML file, you can update the scaling group by using the YAML file.
         * * If no scaling group that has a mapping relationship with your Kubernetes Deployment YAML file exists, you can create a scaling group with ease by using the YAML file.
         * ### Precautions
         * 1. If you do not specify a virtual private cloud (VPC), vSwitch, security group, or annotation in your Kubernetes Deployment YAML file, the system creates a default VPC that has default vSwitches and uses the default security group ess-default-sg of Auto Scaling. By default, the security group rule allows traffic on Transmission Control Protocol (TCP)-based port 22 and port 3389 and enables Internet Control Message Protocol (ICMP) for IPv4 addresses. If you want to enable other ports or protocols, you can create custom security group rules.
         * 2. If you want to use a public image, you must enable the Internet access feature and configure the k8s.aliyun.com/eci-with-eip pod annotation to enable the elastic IP address (EIP) feature.
         * 3. After you call the ApplyScalingGroup operation to apply a Kubernetes Deployment YAML file, the scaling group immediately enters the Enabled state and the scaling configuration immediately enters the Active state. If the number of replicas that you specified in the YAML file is grater than 0, elastic container instances are automatically created.
         * ### Supported annotations
         * For more information about annotations, see [ECI Pod Annotation](https://help.aliyun.com/document_detail/186939.html).
         * |Annotation|Example|Description|
         * |---|---|---|
         * |k8s.aliyun.com/ess-scaling-group-min-size|1|The minimum size of the scaling group that you want to create. Default value: 0.|
         * |k8s.aliyun.com/ess-scaling-group-max-size|20|The maximum size of the scaling group that you want to create. Default value: maximum number of replicas or 30, whichever is greater.|
         * |k8s.aliyun.com/eci-ntp-server|100.100.*.*|The IP address of the Network Time Protocol (NTP) server.|
         * |k8s.aliyun.com/eci-use-specs|2-4Gi|The specifications of 2 vCPUs and 4 GB memory. For more information, see [Create pods by specifying multiple specifications](https://help.aliyun.com/document_detail/451267.html).|
         * |k8s.aliyun.com/eci-vswitch|vsw-bp1xpiowfm5vo8o3c\\*\\*\\*\\*|The ID of the vSwitch. You can specify multiple vSwitches to specify multiple zones.|
         * |k8s.aliyun.com/eci-security-group|sg-bp1dktddjsg5nktv\\*\\*\\*\\*|The ID of the security group. Before you configure this annotation, take note of the following requirements:<ul data-sourcepos="26:74-26:168"><li data-sourcepos="26:78-26:114">You can specify one or more security groups. You can specify up to five security groups for each scaling group.</li><li data-sourcepos="26:114-26:140">If you specify multiple security groups, the security groups must belong to the same VPC.</li><li data-sourcepos="26:140-26:163">If you specify multiple security groups, the security groups must be of the same type.</li></ul>|
         * |k8s.aliyun.com/eci-sls-enable|"false"|If you set the value to false, the log collection feature is disabled.
         * If you do not want to use Custom Resource Definition (CRD) for Simple Log Service to collect logs of specific pods, you can configure this annotation for the pods and set the value to false. This prevents resource wastes caused by Logtails created by the system.|
         * |k8s.aliyun.com/eci-spot-strategy|SpotAsPriceGo|The bidding policy for the preemptible instance. Valid values:<ul data-sourcepos="28:69-28:204"><li data-sourcepos="28:73-28:158">SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price If you set the value to SpotWithPriceLimit, you must configure the k8s.aliyun.com/eci-spot-price-limit annotation.</li><li data-sourcepos="28:158-28:199">SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is used as the bid price.</li></ul>|
         * |k8s.aliyun.com/eci-spot-price-limit|"0.5"|The maximum hourly price of the preemptible instance. This value can be accurate to up to three decimal places.
         * This annotation takes effect only when you set the k8s.aliyun.com/eci-spot-strategy annotation to SpotWithPriceLimit.|
         * |k8s.aliyun.com/eci-with-eip|"true"|If you set the value to true, an EIP is automatically created and bound to each elastic container instance.|
         * |k8s.aliyun.com/eci-data-cache-bucket|default|The bucket of the specified DataCache. If you want to use a DataCache to create a pod, you must configure this annotation.|
         * |k8s.aliyun.com/eci-data-cache-pl|PL1|The performance level (PL) of the cloud disk that you want to create by using the specified DataCache.
         * By default, enhanced SSDs (ESSDs) are created. Default value: PL1.|
         * |k8s.aliyun.com/eci-data-cache-provisionedIops|"40000"|The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-data-cache-burstingEnabled|"true"|Specifies whether the Burst feature is enabled for the ESSD AutoPL disk. For more information, see [ESSD AutoPL](https://help.aliyun.com/document_detail/368372.html).
         * If you configure this annotation, the cloud disk that is created by using the specified DataCache is of the ESSD AutoPL type.|
         * |k8s.aliyun.com/eci-custom-tags|"env:test,name:alice"|The tags that you want to add to each elastic container instance. You can add up to three tags for each elastic container instance. Separate a tag key and a tag value with a colon (:). Separate multiple tags with commas (,).|
         *
         * @param request ApplyScalingGroupRequest
         * @return ApplyScalingGroupResponse
         */
        public async Task<ApplyScalingGroupResponse> ApplyScalingGroupAsync(ApplyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches Application Load Balancer (ALB) server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachAlbServerGroups operation. By attaching ALB server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @description Before you call the operation to attach an ALB server group to your scaling group, make sure that the following requirements are met:
         * *   The scaling group and the ALB server group share the same virtual private cloud (VPC).
         * *   The ALB server group is in the Available state.
         *
         * @param request AttachAlbServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachAlbServerGroupsResponse
         */
        public AttachAlbServerGroupsResponse AttachAlbServerGroupsWithOptions(AttachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbServerGroups))
            {
                query["AlbServerGroups"] = request.AlbServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
                Action = "AttachAlbServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachAlbServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches Application Load Balancer (ALB) server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachAlbServerGroups operation. By attaching ALB server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @description Before you call the operation to attach an ALB server group to your scaling group, make sure that the following requirements are met:
         * *   The scaling group and the ALB server group share the same virtual private cloud (VPC).
         * *   The ALB server group is in the Available state.
         *
         * @param request AttachAlbServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachAlbServerGroupsResponse
         */
        public async Task<AttachAlbServerGroupsResponse> AttachAlbServerGroupsWithOptionsAsync(AttachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbServerGroups))
            {
                query["AlbServerGroups"] = request.AlbServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
                Action = "AttachAlbServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachAlbServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches Application Load Balancer (ALB) server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachAlbServerGroups operation. By attaching ALB server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @description Before you call the operation to attach an ALB server group to your scaling group, make sure that the following requirements are met:
         * *   The scaling group and the ALB server group share the same virtual private cloud (VPC).
         * *   The ALB server group is in the Available state.
         *
         * @param request AttachAlbServerGroupsRequest
         * @return AttachAlbServerGroupsResponse
         */
        public AttachAlbServerGroupsResponse AttachAlbServerGroups(AttachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachAlbServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Attaches Application Load Balancer (ALB) server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachAlbServerGroups operation. By attaching ALB server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @description Before you call the operation to attach an ALB server group to your scaling group, make sure that the following requirements are met:
         * *   The scaling group and the ALB server group share the same virtual private cloud (VPC).
         * *   The ALB server group is in the Available state.
         *
         * @param request AttachAlbServerGroupsRequest
         * @return AttachAlbServerGroupsResponse
         */
        public async Task<AttachAlbServerGroupsResponse> AttachAlbServerGroupsAsync(AttachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachAlbServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Associates one or more ApsaraDB RDS instances with a scaling group.
         *
         * @description Before you associate an ApsaraDB RDS instance with a scaling group, make sure that the ApsaraDB RDS instance meets the following requirements:
         * *   The ApsaraDB RDS instance and the scaling group must belong to the same Alibaba Cloud account.
         * *   The ApsaraDB RDS instance must be unlocked. For more information about the lock policy, see [ApsaraDB RDS usage notes](https://help.aliyun.com/document_detail/41872.html).
         * *   The ApsaraDB RDS instance must be in the Running state.
         * After an ApsaraDB RDS instance is associated with the scaling group, the default IP address whitelist of the ApsaraDB RDS instance can contain no more than 1,000 IP addresses. For more information, see [Set the whitelist](https://help.aliyun.com/document_detail/43185.html).
         *
         * @param request AttachDBInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachDBInstancesResponse
         */
        public AttachDBInstancesResponse AttachDBInstancesWithOptions(AttachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachMode))
            {
                query["AttachMode"] = request.AttachMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDBInstances",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDBInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Associates one or more ApsaraDB RDS instances with a scaling group.
         *
         * @description Before you associate an ApsaraDB RDS instance with a scaling group, make sure that the ApsaraDB RDS instance meets the following requirements:
         * *   The ApsaraDB RDS instance and the scaling group must belong to the same Alibaba Cloud account.
         * *   The ApsaraDB RDS instance must be unlocked. For more information about the lock policy, see [ApsaraDB RDS usage notes](https://help.aliyun.com/document_detail/41872.html).
         * *   The ApsaraDB RDS instance must be in the Running state.
         * After an ApsaraDB RDS instance is associated with the scaling group, the default IP address whitelist of the ApsaraDB RDS instance can contain no more than 1,000 IP addresses. For more information, see [Set the whitelist](https://help.aliyun.com/document_detail/43185.html).
         *
         * @param request AttachDBInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachDBInstancesResponse
         */
        public async Task<AttachDBInstancesResponse> AttachDBInstancesWithOptionsAsync(AttachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachMode))
            {
                query["AttachMode"] = request.AttachMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDBInstances",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDBInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Associates one or more ApsaraDB RDS instances with a scaling group.
         *
         * @description Before you associate an ApsaraDB RDS instance with a scaling group, make sure that the ApsaraDB RDS instance meets the following requirements:
         * *   The ApsaraDB RDS instance and the scaling group must belong to the same Alibaba Cloud account.
         * *   The ApsaraDB RDS instance must be unlocked. For more information about the lock policy, see [ApsaraDB RDS usage notes](https://help.aliyun.com/document_detail/41872.html).
         * *   The ApsaraDB RDS instance must be in the Running state.
         * After an ApsaraDB RDS instance is associated with the scaling group, the default IP address whitelist of the ApsaraDB RDS instance can contain no more than 1,000 IP addresses. For more information, see [Set the whitelist](https://help.aliyun.com/document_detail/43185.html).
         *
         * @param request AttachDBInstancesRequest
         * @return AttachDBInstancesResponse
         */
        public AttachDBInstancesResponse AttachDBInstances(AttachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDBInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Associates one or more ApsaraDB RDS instances with a scaling group.
         *
         * @description Before you associate an ApsaraDB RDS instance with a scaling group, make sure that the ApsaraDB RDS instance meets the following requirements:
         * *   The ApsaraDB RDS instance and the scaling group must belong to the same Alibaba Cloud account.
         * *   The ApsaraDB RDS instance must be unlocked. For more information about the lock policy, see [ApsaraDB RDS usage notes](https://help.aliyun.com/document_detail/41872.html).
         * *   The ApsaraDB RDS instance must be in the Running state.
         * After an ApsaraDB RDS instance is associated with the scaling group, the default IP address whitelist of the ApsaraDB RDS instance can contain no more than 1,000 IP addresses. For more information, see [Set the whitelist](https://help.aliyun.com/document_detail/43185.html).
         *
         * @param request AttachDBInstancesRequest
         * @return AttachDBInstancesResponse
         */
        public async Task<AttachDBInstancesResponse> AttachDBInstancesAsync(AttachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDBInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds instances to a scaling group. You can call the AttachInstances operation to add independent Elastic Compute Service (ECS) instances, elastic container instances, or non-Alibaba Cloud instances to your scaling group to provide services. You can also call this operation to change the state of ECS instances in your scaling group from Economical Mode to In Service.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * The ECS instances or the elastic container instances that you want to add to a scaling group must meet the following requirements:
         * *   The instances reside in the same region as the scaling group.
         * *   The instances must be in the Running state.
         * *   The instances are not added to other scaling groups.
         * *   The instances use the subscription or pay-as-you-go billing method, or are preemptible instances.
         * *   If the VswitchID parameter is specified for a scaling group, the instances that are in the classic network or those that are not in the same virtual private cloud (VPC) as the specified vSwitch cannot be added to the scaling group.
         * *   If the VswitchID parameter is not specified for a scaling group, the instances that are in VPCs cannot be added to the scaling group.
         * If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the sum of the number of instances that you want to add and the number of existing instances in the scaling group is greater than the value of the MaxSize parameter, the call fails.
         * Instances that are manually added by calling the AttachInstances operation are not associated with the active scaling configuration of the scaling group.
         *
         * @param request AttachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesResponse
         */
        public AttachInstancesResponse AttachInstancesWithOptions(AttachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entrusted))
            {
                query["Entrusted"] = request.Entrusted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHook))
            {
                query["LifecycleHook"] = request.LifecycleHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeights))
            {
                query["LoadBalancerWeights"] = request.LoadBalancerWeights;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "AttachInstances",
                Version = "2022-02-22",
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
         * @summary Adds instances to a scaling group. You can call the AttachInstances operation to add independent Elastic Compute Service (ECS) instances, elastic container instances, or non-Alibaba Cloud instances to your scaling group to provide services. You can also call this operation to change the state of ECS instances in your scaling group from Economical Mode to In Service.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * The ECS instances or the elastic container instances that you want to add to a scaling group must meet the following requirements:
         * *   The instances reside in the same region as the scaling group.
         * *   The instances must be in the Running state.
         * *   The instances are not added to other scaling groups.
         * *   The instances use the subscription or pay-as-you-go billing method, or are preemptible instances.
         * *   If the VswitchID parameter is specified for a scaling group, the instances that are in the classic network or those that are not in the same virtual private cloud (VPC) as the specified vSwitch cannot be added to the scaling group.
         * *   If the VswitchID parameter is not specified for a scaling group, the instances that are in VPCs cannot be added to the scaling group.
         * If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the sum of the number of instances that you want to add and the number of existing instances in the scaling group is greater than the value of the MaxSize parameter, the call fails.
         * Instances that are manually added by calling the AttachInstances operation are not associated with the active scaling configuration of the scaling group.
         *
         * @param request AttachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesResponse
         */
        public async Task<AttachInstancesResponse> AttachInstancesWithOptionsAsync(AttachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entrusted))
            {
                query["Entrusted"] = request.Entrusted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHook))
            {
                query["LifecycleHook"] = request.LifecycleHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeights))
            {
                query["LoadBalancerWeights"] = request.LoadBalancerWeights;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "AttachInstances",
                Version = "2022-02-22",
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
         * @summary Adds instances to a scaling group. You can call the AttachInstances operation to add independent Elastic Compute Service (ECS) instances, elastic container instances, or non-Alibaba Cloud instances to your scaling group to provide services. You can also call this operation to change the state of ECS instances in your scaling group from Economical Mode to In Service.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * The ECS instances or the elastic container instances that you want to add to a scaling group must meet the following requirements:
         * *   The instances reside in the same region as the scaling group.
         * *   The instances must be in the Running state.
         * *   The instances are not added to other scaling groups.
         * *   The instances use the subscription or pay-as-you-go billing method, or are preemptible instances.
         * *   If the VswitchID parameter is specified for a scaling group, the instances that are in the classic network or those that are not in the same virtual private cloud (VPC) as the specified vSwitch cannot be added to the scaling group.
         * *   If the VswitchID parameter is not specified for a scaling group, the instances that are in VPCs cannot be added to the scaling group.
         * If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the sum of the number of instances that you want to add and the number of existing instances in the scaling group is greater than the value of the MaxSize parameter, the call fails.
         * Instances that are manually added by calling the AttachInstances operation are not associated with the active scaling configuration of the scaling group.
         *
         * @param request AttachInstancesRequest
         * @return AttachInstancesResponse
         */
        public AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Adds instances to a scaling group. You can call the AttachInstances operation to add independent Elastic Compute Service (ECS) instances, elastic container instances, or non-Alibaba Cloud instances to your scaling group to provide services. You can also call this operation to change the state of ECS instances in your scaling group from Economical Mode to In Service.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * The ECS instances or the elastic container instances that you want to add to a scaling group must meet the following requirements:
         * *   The instances reside in the same region as the scaling group.
         * *   The instances must be in the Running state.
         * *   The instances are not added to other scaling groups.
         * *   The instances use the subscription or pay-as-you-go billing method, or are preemptible instances.
         * *   If the VswitchID parameter is specified for a scaling group, the instances that are in the classic network or those that are not in the same virtual private cloud (VPC) as the specified vSwitch cannot be added to the scaling group.
         * *   If the VswitchID parameter is not specified for a scaling group, the instances that are in VPCs cannot be added to the scaling group.
         * If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the sum of the number of instances that you want to add and the number of existing instances in the scaling group is greater than the value of the MaxSize parameter, the call fails.
         * Instances that are manually added by calling the AttachInstances operation are not associated with the active scaling configuration of the scaling group.
         *
         * @param request AttachInstancesRequest
         * @return AttachInstancesResponse
         */
        public async Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches load balancers to a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups. Load balancers help distribute the access traffic to the instances in scaling groups, which effectively improves the service performance of the scaling groups. You can call the AttachLoadBalancers operation to attach one or more load balancers to your scaling group.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The load balancer and the scaling group belong to the same Alibaba Cloud account and region.
         * *   The load balancer is in the `Running` state.
         * *   At least one listener is configured for the load balancer, and the health check feature is enabled for the load balancer.
         * *   If the network type of the load balancer and the scaling group is virtual private cloud (VPC), they use the same VPC.
         * *   If the network type of the scaling group is VPC, and that of the load balancer is classic network and a backend server of the load balancer uses a VPC, the scaling group and the backend server use the same VPC.
         * *   The attachment of load balancers ensures that the cumulative number of load balancers attached to the scaling group stays within the predefined maximum limit. For information about the load balancer quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         *
         * @param request AttachLoadBalancersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachLoadBalancersResponse
         */
        public AttachLoadBalancersResponse AttachLoadBalancersWithOptions(AttachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerConfigs))
            {
                query["LoadBalancerConfigs"] = request.LoadBalancerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancers))
            {
                query["LoadBalancers"] = request.LoadBalancers;
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
                Action = "AttachLoadBalancers",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLoadBalancersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches load balancers to a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups. Load balancers help distribute the access traffic to the instances in scaling groups, which effectively improves the service performance of the scaling groups. You can call the AttachLoadBalancers operation to attach one or more load balancers to your scaling group.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The load balancer and the scaling group belong to the same Alibaba Cloud account and region.
         * *   The load balancer is in the `Running` state.
         * *   At least one listener is configured for the load balancer, and the health check feature is enabled for the load balancer.
         * *   If the network type of the load balancer and the scaling group is virtual private cloud (VPC), they use the same VPC.
         * *   If the network type of the scaling group is VPC, and that of the load balancer is classic network and a backend server of the load balancer uses a VPC, the scaling group and the backend server use the same VPC.
         * *   The attachment of load balancers ensures that the cumulative number of load balancers attached to the scaling group stays within the predefined maximum limit. For information about the load balancer quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         *
         * @param request AttachLoadBalancersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachLoadBalancersResponse
         */
        public async Task<AttachLoadBalancersResponse> AttachLoadBalancersWithOptionsAsync(AttachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerConfigs))
            {
                query["LoadBalancerConfigs"] = request.LoadBalancerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancers))
            {
                query["LoadBalancers"] = request.LoadBalancers;
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
                Action = "AttachLoadBalancers",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLoadBalancersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches load balancers to a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups. Load balancers help distribute the access traffic to the instances in scaling groups, which effectively improves the service performance of the scaling groups. You can call the AttachLoadBalancers operation to attach one or more load balancers to your scaling group.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The load balancer and the scaling group belong to the same Alibaba Cloud account and region.
         * *   The load balancer is in the `Running` state.
         * *   At least one listener is configured for the load balancer, and the health check feature is enabled for the load balancer.
         * *   If the network type of the load balancer and the scaling group is virtual private cloud (VPC), they use the same VPC.
         * *   If the network type of the scaling group is VPC, and that of the load balancer is classic network and a backend server of the load balancer uses a VPC, the scaling group and the backend server use the same VPC.
         * *   The attachment of load balancers ensures that the cumulative number of load balancers attached to the scaling group stays within the predefined maximum limit. For information about the load balancer quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         *
         * @param request AttachLoadBalancersRequest
         * @return AttachLoadBalancersResponse
         */
        public AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachLoadBalancersWithOptions(request, runtime);
        }

        /**
         * @summary Attaches load balancers to a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups. Load balancers help distribute the access traffic to the instances in scaling groups, which effectively improves the service performance of the scaling groups. You can call the AttachLoadBalancers operation to attach one or more load balancers to your scaling group.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The load balancer and the scaling group belong to the same Alibaba Cloud account and region.
         * *   The load balancer is in the `Running` state.
         * *   At least one listener is configured for the load balancer, and the health check feature is enabled for the load balancer.
         * *   If the network type of the load balancer and the scaling group is virtual private cloud (VPC), they use the same VPC.
         * *   If the network type of the scaling group is VPC, and that of the load balancer is classic network and a backend server of the load balancer uses a VPC, the scaling group and the backend server use the same VPC.
         * *   The attachment of load balancers ensures that the cumulative number of load balancers attached to the scaling group stays within the predefined maximum limit. For information about the load balancer quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         *
         * @param request AttachLoadBalancersRequest
         * @return AttachLoadBalancersResponse
         */
        public async Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachLoadBalancersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachServerGroups operation. By attaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request AttachServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachServerGroupsResponse
         */
        public AttachServerGroupsResponse AttachServerGroupsWithOptions(AttachServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroups))
            {
                query["ServerGroups"] = request.ServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachServerGroups operation. By attaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request AttachServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachServerGroupsResponse
         */
        public async Task<AttachServerGroupsResponse> AttachServerGroupsWithOptionsAsync(AttachServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroups))
            {
                query["ServerGroups"] = request.ServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachServerGroups operation. By attaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request AttachServerGroupsRequest
         * @return AttachServerGroupsResponse
         */
        public AttachServerGroupsResponse AttachServerGroups(AttachServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Attaches server groups to a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the AttachServerGroups operation. By attaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups to your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request AttachServerGroupsRequest
         * @return AttachServerGroupsResponse
         */
        public async Task<AttachServerGroupsResponse> AttachServerGroupsAsync(AttachServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches vServer groups to a scaling group. After a Classic Load Balancer (CLB) instance is attached to your scaling group, the instances in the scaling group are automatically added as backend servers of the CLB instance. These servers then handle requests forwarded by the CLB instance, streamlining the processing of incoming traffic. To direct varying access requests to separate backend servers or to distribute requests based on domain names or URLs, you can call the AttachVServerGroups operation. This operation enables the addition of multiple vServer groups, allowing for efficient management of various backend server configurations tailored to your routing preferences.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The CLB instance and the scaling group belong to the same Alibaba Cloud account.
         *     *   The CLB instance and the scaling group reside in the same region.
         *     *   The CLB instance is in the Running state.
         *     *   The CLB instance is configured with at least one listener. The health check feature is enabled for the CLB instance.
         *     *   If the network type of both the CLB instance and the scaling group is virtual private cloud (VPC), they use the same VPC.
         *     *   If the network type of the scaling group is VPC and the network type of the CLB instance is classic network, any backend server of the CLB instance within a VPC setup shares the same VPC as the scaling group.
         *     *   The vServer groups that you want to attach to the scaling group belong to the CLB instance.
         *     *   The operation to attach vServer groups does not result in the total number of vServer groups exceeding the predefined quota limit. For information about the vServer group quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         * *   When you call this operation to attach vServer groups, you must specify the following parameters:
         *     *   LoadBalancerId: the ID of the CLB instance
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         *     **
         *     **Note** If you attempt to attach the same vServer group to a scaling group multiple times over the identical port, the system regards each attempt as a separate vServer group attachment to the scaling group. In your request, if you include the same vServer group ID coupled with the same port number multiple times, only the first configuration of the vServer group and port number pairing is considered valid. Subsequent vServer group and port number parings are disregarded.
         *
         * @param request AttachVServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachVServerGroupsResponse
         */
        public AttachVServerGroupsResponse AttachVServerGroupsWithOptions(AttachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroups))
            {
                query["VServerGroups"] = request.VServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches vServer groups to a scaling group. After a Classic Load Balancer (CLB) instance is attached to your scaling group, the instances in the scaling group are automatically added as backend servers of the CLB instance. These servers then handle requests forwarded by the CLB instance, streamlining the processing of incoming traffic. To direct varying access requests to separate backend servers or to distribute requests based on domain names or URLs, you can call the AttachVServerGroups operation. This operation enables the addition of multiple vServer groups, allowing for efficient management of various backend server configurations tailored to your routing preferences.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The CLB instance and the scaling group belong to the same Alibaba Cloud account.
         *     *   The CLB instance and the scaling group reside in the same region.
         *     *   The CLB instance is in the Running state.
         *     *   The CLB instance is configured with at least one listener. The health check feature is enabled for the CLB instance.
         *     *   If the network type of both the CLB instance and the scaling group is virtual private cloud (VPC), they use the same VPC.
         *     *   If the network type of the scaling group is VPC and the network type of the CLB instance is classic network, any backend server of the CLB instance within a VPC setup shares the same VPC as the scaling group.
         *     *   The vServer groups that you want to attach to the scaling group belong to the CLB instance.
         *     *   The operation to attach vServer groups does not result in the total number of vServer groups exceeding the predefined quota limit. For information about the vServer group quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         * *   When you call this operation to attach vServer groups, you must specify the following parameters:
         *     *   LoadBalancerId: the ID of the CLB instance
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         *     **
         *     **Note** If you attempt to attach the same vServer group to a scaling group multiple times over the identical port, the system regards each attempt as a separate vServer group attachment to the scaling group. In your request, if you include the same vServer group ID coupled with the same port number multiple times, only the first configuration of the vServer group and port number pairing is considered valid. Subsequent vServer group and port number parings are disregarded.
         *
         * @param request AttachVServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachVServerGroupsResponse
         */
        public async Task<AttachVServerGroupsResponse> AttachVServerGroupsWithOptionsAsync(AttachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAttach))
            {
                query["ForceAttach"] = request.ForceAttach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroups))
            {
                query["VServerGroups"] = request.VServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches vServer groups to a scaling group. After a Classic Load Balancer (CLB) instance is attached to your scaling group, the instances in the scaling group are automatically added as backend servers of the CLB instance. These servers then handle requests forwarded by the CLB instance, streamlining the processing of incoming traffic. To direct varying access requests to separate backend servers or to distribute requests based on domain names or URLs, you can call the AttachVServerGroups operation. This operation enables the addition of multiple vServer groups, allowing for efficient management of various backend server configurations tailored to your routing preferences.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The CLB instance and the scaling group belong to the same Alibaba Cloud account.
         *     *   The CLB instance and the scaling group reside in the same region.
         *     *   The CLB instance is in the Running state.
         *     *   The CLB instance is configured with at least one listener. The health check feature is enabled for the CLB instance.
         *     *   If the network type of both the CLB instance and the scaling group is virtual private cloud (VPC), they use the same VPC.
         *     *   If the network type of the scaling group is VPC and the network type of the CLB instance is classic network, any backend server of the CLB instance within a VPC setup shares the same VPC as the scaling group.
         *     *   The vServer groups that you want to attach to the scaling group belong to the CLB instance.
         *     *   The operation to attach vServer groups does not result in the total number of vServer groups exceeding the predefined quota limit. For information about the vServer group quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         * *   When you call this operation to attach vServer groups, you must specify the following parameters:
         *     *   LoadBalancerId: the ID of the CLB instance
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         *     **
         *     **Note** If you attempt to attach the same vServer group to a scaling group multiple times over the identical port, the system regards each attempt as a separate vServer group attachment to the scaling group. In your request, if you include the same vServer group ID coupled with the same port number multiple times, only the first configuration of the vServer group and port number pairing is considered valid. Subsequent vServer group and port number parings are disregarded.
         *
         * @param request AttachVServerGroupsRequest
         * @return AttachVServerGroupsResponse
         */
        public AttachVServerGroupsResponse AttachVServerGroups(AttachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachVServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Attaches vServer groups to a scaling group. After a Classic Load Balancer (CLB) instance is attached to your scaling group, the instances in the scaling group are automatically added as backend servers of the CLB instance. These servers then handle requests forwarded by the CLB instance, streamlining the processing of incoming traffic. To direct varying access requests to separate backend servers or to distribute requests based on domain names or URLs, you can call the AttachVServerGroups operation. This operation enables the addition of multiple vServer groups, allowing for efficient management of various backend server configurations tailored to your routing preferences.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The CLB instance and the scaling group belong to the same Alibaba Cloud account.
         *     *   The CLB instance and the scaling group reside in the same region.
         *     *   The CLB instance is in the Running state.
         *     *   The CLB instance is configured with at least one listener. The health check feature is enabled for the CLB instance.
         *     *   If the network type of both the CLB instance and the scaling group is virtual private cloud (VPC), they use the same VPC.
         *     *   If the network type of the scaling group is VPC and the network type of the CLB instance is classic network, any backend server of the CLB instance within a VPC setup shares the same VPC as the scaling group.
         *     *   The vServer groups that you want to attach to the scaling group belong to the CLB instance.
         *     *   The operation to attach vServer groups does not result in the total number of vServer groups exceeding the predefined quota limit. For information about the vServer group quota, see [Limits](https://help.aliyun.com/document_detail/25863.html).
         * *   When you call this operation to attach vServer groups, you must specify the following parameters:
         *     *   LoadBalancerId: the ID of the CLB instance
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         *     **
         *     **Note** If you attempt to attach the same vServer group to a scaling group multiple times over the identical port, the system regards each attempt as a separate vServer group attachment to the scaling group. In your request, if you include the same vServer group ID coupled with the same port number multiple times, only the first configuration of the vServer group and port number pairing is considered valid. Subsequent vServer group and port number parings are disregarded.
         *
         * @param request AttachVServerGroupsRequest
         * @return AttachVServerGroupsResponse
         */
        public async Task<AttachVServerGroupsResponse> AttachVServerGroupsAsync(AttachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachVServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes a resource group. Resource groups are a means to categorize and manage cloud resources, such as scaling groups, based on specific objectives, permissions, or ownership. In large, multifaceted organizations that manage numerous projects and users, this feature adopts a tiered management approach, simplifying management tasks and improving the effectiveness and oversight of resource allocation. You can call the ChangeResourceGroup operation to move your scaling groups from one resource group to another resource group, which facilitates streamlined monitoring and management within the context of the new group. This operation eliminates the need for repetitive and time-consuming cross-service resource queries, thereby enhancing operational efficiency.
         *
         * @description *   A resource is an entity of cloud services that you create on Alibaba Cloud. For example, a scaling group is a resource.
         * *   A resource group serves as a powerful organizational tool within your Alibaba Cloud account, enabling you to manage and monitor multiple resources collectively. It effectively addresses complexities surrounding resource categorization and permission control under a single Alibaba Cloud account, thereby enhancing management efficiency and control. For more information, see [What is resource management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes a resource group. Resource groups are a means to categorize and manage cloud resources, such as scaling groups, based on specific objectives, permissions, or ownership. In large, multifaceted organizations that manage numerous projects and users, this feature adopts a tiered management approach, simplifying management tasks and improving the effectiveness and oversight of resource allocation. You can call the ChangeResourceGroup operation to move your scaling groups from one resource group to another resource group, which facilitates streamlined monitoring and management within the context of the new group. This operation eliminates the need for repetitive and time-consuming cross-service resource queries, thereby enhancing operational efficiency.
         *
         * @description *   A resource is an entity of cloud services that you create on Alibaba Cloud. For example, a scaling group is a resource.
         * *   A resource group serves as a powerful organizational tool within your Alibaba Cloud account, enabling you to manage and monitor multiple resources collectively. It effectively addresses complexities surrounding resource categorization and permission control under a single Alibaba Cloud account, thereby enhancing management efficiency and control. For more information, see [What is resource management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes a resource group. Resource groups are a means to categorize and manage cloud resources, such as scaling groups, based on specific objectives, permissions, or ownership. In large, multifaceted organizations that manage numerous projects and users, this feature adopts a tiered management approach, simplifying management tasks and improving the effectiveness and oversight of resource allocation. You can call the ChangeResourceGroup operation to move your scaling groups from one resource group to another resource group, which facilitates streamlined monitoring and management within the context of the new group. This operation eliminates the need for repetitive and time-consuming cross-service resource queries, thereby enhancing operational efficiency.
         *
         * @description *   A resource is an entity of cloud services that you create on Alibaba Cloud. For example, a scaling group is a resource.
         * *   A resource group serves as a powerful organizational tool within your Alibaba Cloud account, enabling you to manage and monitor multiple resources collectively. It effectively addresses complexities surrounding resource categorization and permission control under a single Alibaba Cloud account, thereby enhancing management efficiency and control. For more information, see [What is resource management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Changes a resource group. Resource groups are a means to categorize and manage cloud resources, such as scaling groups, based on specific objectives, permissions, or ownership. In large, multifaceted organizations that manage numerous projects and users, this feature adopts a tiered management approach, simplifying management tasks and improving the effectiveness and oversight of resource allocation. You can call the ChangeResourceGroup operation to move your scaling groups from one resource group to another resource group, which facilitates streamlined monitoring and management within the context of the new group. This operation eliminates the need for repetitive and time-consuming cross-service resource queries, thereby enhancing operational efficiency.
         *
         * @description *   A resource is an entity of cloud services that you create on Alibaba Cloud. For example, a scaling group is a resource.
         * *   A resource group serves as a powerful organizational tool within your Alibaba Cloud account, enabling you to manage and monitor multiple resources collectively. It effectively addresses complexities surrounding resource categorization and permission control under a single Alibaba Cloud account, thereby enhancing management efficiency and control. For more information, see [What is resource management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Ends the timeout period of a lifecycle hook ahead of schedule. If you have created a lifecycle hook for your scaling group, you can call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of schedule based on your business requirements.
         *
         * @description When you manually cut short the timeout period of a lifecycle hook, Auto Scaling proceeds with one of the following actions based on the predefined settings: responding to the scaling request, aborting the scaling request, and initiating a rollback process.
         *
         * @param request CompleteLifecycleActionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompleteLifecycleActionResponse
         */
        public CompleteLifecycleActionResponse CompleteLifecycleActionWithOptions(CompleteLifecycleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionResult))
            {
                query["LifecycleActionResult"] = request.LifecycleActionResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionToken))
            {
                query["LifecycleActionToken"] = request.LifecycleActionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["LifecycleHookId"] = request.LifecycleHookId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteLifecycleAction",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteLifecycleActionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Ends the timeout period of a lifecycle hook ahead of schedule. If you have created a lifecycle hook for your scaling group, you can call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of schedule based on your business requirements.
         *
         * @description When you manually cut short the timeout period of a lifecycle hook, Auto Scaling proceeds with one of the following actions based on the predefined settings: responding to the scaling request, aborting the scaling request, and initiating a rollback process.
         *
         * @param request CompleteLifecycleActionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompleteLifecycleActionResponse
         */
        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleActionWithOptionsAsync(CompleteLifecycleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionResult))
            {
                query["LifecycleActionResult"] = request.LifecycleActionResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionToken))
            {
                query["LifecycleActionToken"] = request.LifecycleActionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["LifecycleHookId"] = request.LifecycleHookId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteLifecycleAction",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteLifecycleActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Ends the timeout period of a lifecycle hook ahead of schedule. If you have created a lifecycle hook for your scaling group, you can call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of schedule based on your business requirements.
         *
         * @description When you manually cut short the timeout period of a lifecycle hook, Auto Scaling proceeds with one of the following actions based on the predefined settings: responding to the scaling request, aborting the scaling request, and initiating a rollback process.
         *
         * @param request CompleteLifecycleActionRequest
         * @return CompleteLifecycleActionResponse
         */
        public CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteLifecycleActionWithOptions(request, runtime);
        }

        /**
         * @summary Ends the timeout period of a lifecycle hook ahead of schedule. If you have created a lifecycle hook for your scaling group, you can call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of schedule based on your business requirements.
         *
         * @description When you manually cut short the timeout period of a lifecycle hook, Auto Scaling proceeds with one of the following actions based on the predefined settings: responding to the scaling request, aborting the scaling request, and initiating a rollback process.
         *
         * @param request CompleteLifecycleActionRequest
         * @return CompleteLifecycleActionResponse
         */
        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteLifecycleActionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates event-triggered tasks. If your business encounters unexpected traffic surges or has no specific patterns, you can call the CreateAlarm operation to create an event-triggered task and associate a CloudMonitor metric with the task. This allows you to dynamically adjust the number of Elastic Compute Service (ECS) instances or elastic container instances in your scaling group and keep updated on the real-time metric data, which facilitates cloud resource management and maintenance.
         *
         * @description *   If you set MetricType to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Event-triggered tasks of the custom monitoring type](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify MetricName, Dimensions.DimensionKey, and Dimensions.DimensionValue to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify user_id and scaling_group for an event-triggered task to aggregate monitoring data of all ECS instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you create an event-triggered task of the custom monitoring type, you can specify only custom metrics in the task.
         *     *   If you create an event-triggered task of the system monitoring type, you can specify the system metrics described in [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html) in the task.
         * >  user_id and scaling_group are automatically populated. You need to only specify device and state. For more information, see `Dimensions.DimensionKey` and `Dimensions.DimensionValue` in the "Request parameters" section of this topic.
         *
         * @param request CreateAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlarmResponse
         */
        public CreateAlarmResponse CreateAlarmWithOptions(CreateAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmActions))
            {
                query["AlarmActions"] = request.AlarmActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparisonOperator))
            {
                query["ComparisonOperator"] = request.ComparisonOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effective))
            {
                query["Effective"] = request.Effective;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expressions))
            {
                query["Expressions"] = request.Expressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressionsLogicOperator))
            {
                query["ExpressionsLogicOperator"] = request.ExpressionsLogicOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statistics))
            {
                query["Statistics"] = request.Statistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates event-triggered tasks. If your business encounters unexpected traffic surges or has no specific patterns, you can call the CreateAlarm operation to create an event-triggered task and associate a CloudMonitor metric with the task. This allows you to dynamically adjust the number of Elastic Compute Service (ECS) instances or elastic container instances in your scaling group and keep updated on the real-time metric data, which facilitates cloud resource management and maintenance.
         *
         * @description *   If you set MetricType to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Event-triggered tasks of the custom monitoring type](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify MetricName, Dimensions.DimensionKey, and Dimensions.DimensionValue to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify user_id and scaling_group for an event-triggered task to aggregate monitoring data of all ECS instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you create an event-triggered task of the custom monitoring type, you can specify only custom metrics in the task.
         *     *   If you create an event-triggered task of the system monitoring type, you can specify the system metrics described in [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html) in the task.
         * >  user_id and scaling_group are automatically populated. You need to only specify device and state. For more information, see `Dimensions.DimensionKey` and `Dimensions.DimensionValue` in the "Request parameters" section of this topic.
         *
         * @param request CreateAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlarmResponse
         */
        public async Task<CreateAlarmResponse> CreateAlarmWithOptionsAsync(CreateAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmActions))
            {
                query["AlarmActions"] = request.AlarmActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparisonOperator))
            {
                query["ComparisonOperator"] = request.ComparisonOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effective))
            {
                query["Effective"] = request.Effective;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expressions))
            {
                query["Expressions"] = request.Expressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressionsLogicOperator))
            {
                query["ExpressionsLogicOperator"] = request.ExpressionsLogicOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statistics))
            {
                query["Statistics"] = request.Statistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates event-triggered tasks. If your business encounters unexpected traffic surges or has no specific patterns, you can call the CreateAlarm operation to create an event-triggered task and associate a CloudMonitor metric with the task. This allows you to dynamically adjust the number of Elastic Compute Service (ECS) instances or elastic container instances in your scaling group and keep updated on the real-time metric data, which facilitates cloud resource management and maintenance.
         *
         * @description *   If you set MetricType to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Event-triggered tasks of the custom monitoring type](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify MetricName, Dimensions.DimensionKey, and Dimensions.DimensionValue to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify user_id and scaling_group for an event-triggered task to aggregate monitoring data of all ECS instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you create an event-triggered task of the custom monitoring type, you can specify only custom metrics in the task.
         *     *   If you create an event-triggered task of the system monitoring type, you can specify the system metrics described in [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html) in the task.
         * >  user_id and scaling_group are automatically populated. You need to only specify device and state. For more information, see `Dimensions.DimensionKey` and `Dimensions.DimensionValue` in the "Request parameters" section of this topic.
         *
         * @param request CreateAlarmRequest
         * @return CreateAlarmResponse
         */
        public CreateAlarmResponse CreateAlarm(CreateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Creates event-triggered tasks. If your business encounters unexpected traffic surges or has no specific patterns, you can call the CreateAlarm operation to create an event-triggered task and associate a CloudMonitor metric with the task. This allows you to dynamically adjust the number of Elastic Compute Service (ECS) instances or elastic container instances in your scaling group and keep updated on the real-time metric data, which facilitates cloud resource management and maintenance.
         *
         * @description *   If you set MetricType to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Event-triggered tasks of the custom monitoring type](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify MetricName, Dimensions.DimensionKey, and Dimensions.DimensionValue to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify user_id and scaling_group for an event-triggered task to aggregate monitoring data of all ECS instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you create an event-triggered task of the custom monitoring type, you can specify only custom metrics in the task.
         *     *   If you create an event-triggered task of the system monitoring type, you can specify the system metrics described in [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html) in the task.
         * >  user_id and scaling_group are automatically populated. You need to only specify device and state. For more information, see `Dimensions.DimensionKey` and `Dimensions.DimensionValue` in the "Request parameters" section of this topic.
         *
         * @param request CreateAlarmRequest
         * @return CreateAlarmResponse
         */
        public async Task<CreateAlarmResponse> CreateAlarmAsync(CreateAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a scaling configuration of the Elastic Container Instance type. Auto Scaling uses the scaling configuration as a template to create elastic container instances to meet your business requirements during scale-outs.
         *
         * @description A scaling configuration is a template that is used to create elastic container instances during scale-out activities.
         * You can specify the Cpu and Memory parameters to determine the range of instance types. If you specify the parameters, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Auto Scaling preferentially creates elastic container instances of the instance type that is provided at the lowest price. This scaling mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         *
         * @param request CreateEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEciScalingConfigurationResponse
         */
        public CreateEciScalingConfigurationResponse CreateEciScalingConfigurationWithOptions(CreateEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfos))
            {
                query["AcrRegistryInfos"] = request.AcrRegistryInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveDeadlineSeconds))
            {
                query["ActiveDeadlineSeconds"] = request.ActiveDeadlineSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateEip))
            {
                query["AutoCreateEip"] = request.AutoCreateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Containers))
            {
                query["Containers"] = request.Containers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostOptimization))
            {
                query["CostOptimization"] = request.CostOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsCore))
            {
                query["CpuOptionsCore"] = request.CpuOptionsCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsThreadsPerCore))
            {
                query["CpuOptionsThreadsPerCore"] = request.CpuOptionsThreadsPerCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBucket))
            {
                query["DataCacheBucket"] = request.DataCacheBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBurstingEnabled))
            {
                query["DataCacheBurstingEnabled"] = request.DataCacheBurstingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCachePL))
            {
                query["DataCachePL"] = request.DataCachePL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheProvisionedIops))
            {
                query["DataCacheProvisionedIops"] = request.DataCacheProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigNameServers))
            {
                query["DnsConfigNameServers"] = request.DnsConfigNameServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigOptions))
            {
                query["DnsConfigOptions"] = request.DnsConfigOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigSearchs))
            {
                query["DnsConfigSearchs"] = request.DnsConfigSearchs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsPolicy))
            {
                query["DnsPolicy"] = request.DnsPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressBandwidth))
            {
                query["EgressBandwidth"] = request.EgressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSls))
            {
                query["EnableSls"] = request.EnableSls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliases))
            {
                query["HostAliases"] = request.HostAliases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredentials))
            {
                query["ImageRegistryCredentials"] = request.ImageRegistryCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSnapshotId))
            {
                query["ImageSnapshotId"] = request.ImageSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressBandwidth))
            {
                query["IngressBandwidth"] = request.IngressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainers))
            {
                query["InitContainers"] = request.InitContainers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceFamilyLevel))
            {
                query["InstanceFamilyLevel"] = request.InstanceFamilyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NtpServers))
            {
                query["NtpServers"] = request.NtpServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityContextSysctls))
            {
                query["SecurityContextSysctls"] = request.SecurityContextSysctls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volumes))
            {
                query["Volumes"] = request.Volumes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEciScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a scaling configuration of the Elastic Container Instance type. Auto Scaling uses the scaling configuration as a template to create elastic container instances to meet your business requirements during scale-outs.
         *
         * @description A scaling configuration is a template that is used to create elastic container instances during scale-out activities.
         * You can specify the Cpu and Memory parameters to determine the range of instance types. If you specify the parameters, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Auto Scaling preferentially creates elastic container instances of the instance type that is provided at the lowest price. This scaling mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         *
         * @param request CreateEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEciScalingConfigurationResponse
         */
        public async Task<CreateEciScalingConfigurationResponse> CreateEciScalingConfigurationWithOptionsAsync(CreateEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfos))
            {
                query["AcrRegistryInfos"] = request.AcrRegistryInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveDeadlineSeconds))
            {
                query["ActiveDeadlineSeconds"] = request.ActiveDeadlineSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateEip))
            {
                query["AutoCreateEip"] = request.AutoCreateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Containers))
            {
                query["Containers"] = request.Containers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostOptimization))
            {
                query["CostOptimization"] = request.CostOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsCore))
            {
                query["CpuOptionsCore"] = request.CpuOptionsCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsThreadsPerCore))
            {
                query["CpuOptionsThreadsPerCore"] = request.CpuOptionsThreadsPerCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBucket))
            {
                query["DataCacheBucket"] = request.DataCacheBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBurstingEnabled))
            {
                query["DataCacheBurstingEnabled"] = request.DataCacheBurstingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCachePL))
            {
                query["DataCachePL"] = request.DataCachePL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheProvisionedIops))
            {
                query["DataCacheProvisionedIops"] = request.DataCacheProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigNameServers))
            {
                query["DnsConfigNameServers"] = request.DnsConfigNameServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigOptions))
            {
                query["DnsConfigOptions"] = request.DnsConfigOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigSearchs))
            {
                query["DnsConfigSearchs"] = request.DnsConfigSearchs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsPolicy))
            {
                query["DnsPolicy"] = request.DnsPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressBandwidth))
            {
                query["EgressBandwidth"] = request.EgressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSls))
            {
                query["EnableSls"] = request.EnableSls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliases))
            {
                query["HostAliases"] = request.HostAliases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredentials))
            {
                query["ImageRegistryCredentials"] = request.ImageRegistryCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSnapshotId))
            {
                query["ImageSnapshotId"] = request.ImageSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressBandwidth))
            {
                query["IngressBandwidth"] = request.IngressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainers))
            {
                query["InitContainers"] = request.InitContainers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceFamilyLevel))
            {
                query["InstanceFamilyLevel"] = request.InstanceFamilyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NtpServers))
            {
                query["NtpServers"] = request.NtpServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityContextSysctls))
            {
                query["SecurityContextSysctls"] = request.SecurityContextSysctls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volumes))
            {
                query["Volumes"] = request.Volumes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEciScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a scaling configuration of the Elastic Container Instance type. Auto Scaling uses the scaling configuration as a template to create elastic container instances to meet your business requirements during scale-outs.
         *
         * @description A scaling configuration is a template that is used to create elastic container instances during scale-out activities.
         * You can specify the Cpu and Memory parameters to determine the range of instance types. If you specify the parameters, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Auto Scaling preferentially creates elastic container instances of the instance type that is provided at the lowest price. This scaling mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         *
         * @param request CreateEciScalingConfigurationRequest
         * @return CreateEciScalingConfigurationResponse
         */
        public CreateEciScalingConfigurationResponse CreateEciScalingConfiguration(CreateEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEciScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Creates a scaling configuration of the Elastic Container Instance type. Auto Scaling uses the scaling configuration as a template to create elastic container instances to meet your business requirements during scale-outs.
         *
         * @description A scaling configuration is a template that is used to create elastic container instances during scale-out activities.
         * You can specify the Cpu and Memory parameters to determine the range of instance types. If you specify the parameters, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Auto Scaling preferentially creates elastic container instances of the instance type that is provided at the lowest price. This scaling mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         *
         * @param request CreateEciScalingConfigurationRequest
         * @return CreateEciScalingConfigurationResponse
         */
        public async Task<CreateEciScalingConfigurationResponse> CreateEciScalingConfigurationAsync(CreateEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEciScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates one or more lifecycle hooks.
         *
         * @description You can create up to six lifecycle hooks for each scaling group. After a lifecycle hook is created for a scaling group, Elastic Compute Service (ECS) instances in the scaling group waits to be added to or removed from the scaling group during scaling activities. You can use the HeartbeatTimeout parameter to specify the timeout period of the lifecycle hook. During the timeout period of a lifecycle hook, you can perform custom operations such as initialize ECS instance configurations and download ECS instance data on the ECS instances for which the lifecycle hook is applied.
         * During a scale-out activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be added to the associated whitelist that manages access to the ApsaraDB RDS instance. The ECS instances also wait to be added to the backend server group of the associated Classic Load Balancer (CLB) instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are added to the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also added to the backend server group of the associated CLB instance. During a scale-in activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances also wait to be removed from the backend server group of the associated CLB instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also removed from the backend server group of the associated CLB instance.
         * You can configure a notification method for a lifecycle hook. When the lifecycle hook is triggered, a notification can be sent to the specified Message Service (MNS) topic or queue, or an operation can be performed based on the specified Operation Orchestration Service (OOS) template. If you want to configure an OOS template, you must create a Resource Access Management (RAM) role for OOS. For more information, see [Grant RAM permissions to OOS](https://help.aliyun.com/document_detail/120810.html).
         * > If your scaling group has existing ECS instances and you configured an OOS template that is used to add the private IP addresses of ECS instances to or remove the private IP addresses of ECS instances from the whitelists that manage access to cloud databases that are not ApsaraDB RDS databases, you must manually add the private IP addresses of the ECS instances to or remove the private IP addresses of the ECS instances from the whitelists that manage access to the cloud databases.
         *
         * @param request CreateLifecycleHookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLifecycleHookResponse
         */
        public CreateLifecycleHookResponse CreateLifecycleHookWithOptions(CreateLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultResult))
            {
                query["DefaultResult"] = request.DefaultResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeartbeatTimeout))
            {
                query["HeartbeatTimeout"] = request.HeartbeatTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleTransition))
            {
                query["LifecycleTransition"] = request.LifecycleTransition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationMetadata))
            {
                query["NotificationMetadata"] = request.NotificationMetadata;
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
                Action = "CreateLifecycleHook",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLifecycleHookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates one or more lifecycle hooks.
         *
         * @description You can create up to six lifecycle hooks for each scaling group. After a lifecycle hook is created for a scaling group, Elastic Compute Service (ECS) instances in the scaling group waits to be added to or removed from the scaling group during scaling activities. You can use the HeartbeatTimeout parameter to specify the timeout period of the lifecycle hook. During the timeout period of a lifecycle hook, you can perform custom operations such as initialize ECS instance configurations and download ECS instance data on the ECS instances for which the lifecycle hook is applied.
         * During a scale-out activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be added to the associated whitelist that manages access to the ApsaraDB RDS instance. The ECS instances also wait to be added to the backend server group of the associated Classic Load Balancer (CLB) instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are added to the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also added to the backend server group of the associated CLB instance. During a scale-in activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances also wait to be removed from the backend server group of the associated CLB instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also removed from the backend server group of the associated CLB instance.
         * You can configure a notification method for a lifecycle hook. When the lifecycle hook is triggered, a notification can be sent to the specified Message Service (MNS) topic or queue, or an operation can be performed based on the specified Operation Orchestration Service (OOS) template. If you want to configure an OOS template, you must create a Resource Access Management (RAM) role for OOS. For more information, see [Grant RAM permissions to OOS](https://help.aliyun.com/document_detail/120810.html).
         * > If your scaling group has existing ECS instances and you configured an OOS template that is used to add the private IP addresses of ECS instances to or remove the private IP addresses of ECS instances from the whitelists that manage access to cloud databases that are not ApsaraDB RDS databases, you must manually add the private IP addresses of the ECS instances to or remove the private IP addresses of the ECS instances from the whitelists that manage access to the cloud databases.
         *
         * @param request CreateLifecycleHookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLifecycleHookResponse
         */
        public async Task<CreateLifecycleHookResponse> CreateLifecycleHookWithOptionsAsync(CreateLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultResult))
            {
                query["DefaultResult"] = request.DefaultResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeartbeatTimeout))
            {
                query["HeartbeatTimeout"] = request.HeartbeatTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleTransition))
            {
                query["LifecycleTransition"] = request.LifecycleTransition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationMetadata))
            {
                query["NotificationMetadata"] = request.NotificationMetadata;
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
                Action = "CreateLifecycleHook",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLifecycleHookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates one or more lifecycle hooks.
         *
         * @description You can create up to six lifecycle hooks for each scaling group. After a lifecycle hook is created for a scaling group, Elastic Compute Service (ECS) instances in the scaling group waits to be added to or removed from the scaling group during scaling activities. You can use the HeartbeatTimeout parameter to specify the timeout period of the lifecycle hook. During the timeout period of a lifecycle hook, you can perform custom operations such as initialize ECS instance configurations and download ECS instance data on the ECS instances for which the lifecycle hook is applied.
         * During a scale-out activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be added to the associated whitelist that manages access to the ApsaraDB RDS instance. The ECS instances also wait to be added to the backend server group of the associated Classic Load Balancer (CLB) instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are added to the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also added to the backend server group of the associated CLB instance. During a scale-in activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances also wait to be removed from the backend server group of the associated CLB instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also removed from the backend server group of the associated CLB instance.
         * You can configure a notification method for a lifecycle hook. When the lifecycle hook is triggered, a notification can be sent to the specified Message Service (MNS) topic or queue, or an operation can be performed based on the specified Operation Orchestration Service (OOS) template. If you want to configure an OOS template, you must create a Resource Access Management (RAM) role for OOS. For more information, see [Grant RAM permissions to OOS](https://help.aliyun.com/document_detail/120810.html).
         * > If your scaling group has existing ECS instances and you configured an OOS template that is used to add the private IP addresses of ECS instances to or remove the private IP addresses of ECS instances from the whitelists that manage access to cloud databases that are not ApsaraDB RDS databases, you must manually add the private IP addresses of the ECS instances to or remove the private IP addresses of the ECS instances from the whitelists that manage access to the cloud databases.
         *
         * @param request CreateLifecycleHookRequest
         * @return CreateLifecycleHookResponse
         */
        public CreateLifecycleHookResponse CreateLifecycleHook(CreateLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLifecycleHookWithOptions(request, runtime);
        }

        /**
         * @summary Creates one or more lifecycle hooks.
         *
         * @description You can create up to six lifecycle hooks for each scaling group. After a lifecycle hook is created for a scaling group, Elastic Compute Service (ECS) instances in the scaling group waits to be added to or removed from the scaling group during scaling activities. You can use the HeartbeatTimeout parameter to specify the timeout period of the lifecycle hook. During the timeout period of a lifecycle hook, you can perform custom operations such as initialize ECS instance configurations and download ECS instance data on the ECS instances for which the lifecycle hook is applied.
         * During a scale-out activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be added to the associated whitelist that manages access to the ApsaraDB RDS instance. The ECS instances also wait to be added to the backend server group of the associated Classic Load Balancer (CLB) instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are added to the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also added to the backend server group of the associated CLB instance. During a scale-in activity and the timeout period of a lifecycle hook, the private IP addresses of ECS instances wait to be removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances also wait to be removed from the backend server group of the associated CLB instance. After the lifecycle hook times out, the private IP addresses of the ECS instances are removed from the whitelist that manages access to the associated ApsaraDB RDS instance. The ECS instances are also removed from the backend server group of the associated CLB instance.
         * You can configure a notification method for a lifecycle hook. When the lifecycle hook is triggered, a notification can be sent to the specified Message Service (MNS) topic or queue, or an operation can be performed based on the specified Operation Orchestration Service (OOS) template. If you want to configure an OOS template, you must create a Resource Access Management (RAM) role for OOS. For more information, see [Grant RAM permissions to OOS](https://help.aliyun.com/document_detail/120810.html).
         * > If your scaling group has existing ECS instances and you configured an OOS template that is used to add the private IP addresses of ECS instances to or remove the private IP addresses of ECS instances from the whitelists that manage access to cloud databases that are not ApsaraDB RDS databases, you must manually add the private IP addresses of the ECS instances to or remove the private IP addresses of the ECS instances from the whitelists that manage access to the cloud databases.
         *
         * @param request CreateLifecycleHookRequest
         * @return CreateLifecycleHookResponse
         */
        public async Task<CreateLifecycleHookResponse> CreateLifecycleHookAsync(CreateLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLifecycleHookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a notification rule. You can call the CreateNotificationConfiguration operation to create a notification rule to stay informed about scaling events or resource changes. This helps you learn about the dynamic status of your scaling group in real time and further automates the management of scaling events.
         *
         * @description ## Description
         * You can configure CloudMonitor system events, Message Service (MNS) queues, or MNS topics to receive notifications. When a specified type of scaling activity or resource change occurs in a scaling group, Auto Scaling sends notifications by using CloudMonitor or MNS.
         *
         * @param request CreateNotificationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNotificationConfigurationResponse
         */
        public CreateNotificationConfigurationResponse CreateNotificationConfigurationWithOptions(CreateNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationTypes))
            {
                query["NotificationTypes"] = request.NotificationTypes;
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
                Action = "CreateNotificationConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNotificationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a notification rule. You can call the CreateNotificationConfiguration operation to create a notification rule to stay informed about scaling events or resource changes. This helps you learn about the dynamic status of your scaling group in real time and further automates the management of scaling events.
         *
         * @description ## Description
         * You can configure CloudMonitor system events, Message Service (MNS) queues, or MNS topics to receive notifications. When a specified type of scaling activity or resource change occurs in a scaling group, Auto Scaling sends notifications by using CloudMonitor or MNS.
         *
         * @param request CreateNotificationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNotificationConfigurationResponse
         */
        public async Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationWithOptionsAsync(CreateNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationTypes))
            {
                query["NotificationTypes"] = request.NotificationTypes;
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
                Action = "CreateNotificationConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNotificationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a notification rule. You can call the CreateNotificationConfiguration operation to create a notification rule to stay informed about scaling events or resource changes. This helps you learn about the dynamic status of your scaling group in real time and further automates the management of scaling events.
         *
         * @description ## Description
         * You can configure CloudMonitor system events, Message Service (MNS) queues, or MNS topics to receive notifications. When a specified type of scaling activity or resource change occurs in a scaling group, Auto Scaling sends notifications by using CloudMonitor or MNS.
         *
         * @param request CreateNotificationConfigurationRequest
         * @return CreateNotificationConfigurationResponse
         */
        public CreateNotificationConfigurationResponse CreateNotificationConfiguration(CreateNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNotificationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Creates a notification rule. You can call the CreateNotificationConfiguration operation to create a notification rule to stay informed about scaling events or resource changes. This helps you learn about the dynamic status of your scaling group in real time and further automates the management of scaling events.
         *
         * @description ## Description
         * You can configure CloudMonitor system events, Message Service (MNS) queues, or MNS topics to receive notifications. When a specified type of scaling activity or resource change occurs in a scaling group, Auto Scaling sends notifications by using CloudMonitor or MNS.
         *
         * @param request CreateNotificationConfigurationRequest
         * @return CreateNotificationConfigurationResponse
         */
        public async Task<CreateNotificationConfigurationResponse> CreateNotificationConfigurationAsync(CreateNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNotificationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a scaling configuration.
         *
         * @description Auto Scaling automatically creates Elastic Compute Service (ECS) instances based on the specified scaling configuration. ECS instances can be created in the following modes:
         * *   InstancePatternInfos: intelligent configuration mode. In this mode, you need to only specify the number of vCPUs, memory size, instance family, and maximum price. Auto Scaling selects the instance type that has the lowest price based on the configurations to create ECS instances. This mode is available only for scaling groups that reside in virtual private clouds (VPCs). This mode reduces scale-out failures caused by insufficient inventory of instance types.
         * *   InstanceType: In this mode, you must specify one instance type.
         * *   InstanceTypes: In this mode, you can specify more than one instance type.
         * *   InstanceTypeOverrides: In this mode, you can specify multiple instance types and weights for the instance types.
         * *   Cpu and Memory: In this mode, you must specify the number of vCPUs and the memory size. Auto Scaling determines the range of available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling creates ECS instances by using the lowest-priced instance type. This mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         * > You cannot specify InstanceType, InstanceTypes, InstanceTypeOverrides, and Cpu and Memory at the same time. You can specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfo at the same time. If you specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfos at the same time, Auto Scaling preferentially uses the instance types that are specified by InstanceType or InstanceTypes for scale-outs. If the instance types that are specified by InstanceType or InstanceTypes do not have sufficient inventory, Auto Scaling uses the instance types that are specified by InstancePatternInfos for scale-outs.
         *
         * @param tmpReq CreateScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingConfigurationResponse
         */
        public CreateScalingConfigurationResponse CreateScalingConfigurationWithOptions(CreateScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScalingConfigurationShrinkRequest request = new CreateScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                query["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditSpecification))
            {
                query["CreditSpecification"] = request.CreditSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPriorities))
            {
                query["CustomPriorities"] = request.CustomPriorities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisks))
            {
                query["DataDisks"] = request.DataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostClusterId))
            {
                query["DedicatedHostClusterId"] = request.DedicatedHostClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostId))
            {
                query["DedicatedHostId"] = request.DedicatedHostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSetId))
            {
                query["DeploymentSetId"] = request.DeploymentSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpcClusterId))
            {
                query["HpcClusterId"] = request.HpcClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFamily))
            {
                query["ImageFamily"] = request.ImageFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancePatternInfos))
            {
                query["InstancePatternInfos"] = request.InstancePatternInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypeOverrides))
            {
                query["InstanceTypeOverrides"] = request.InstanceTypeOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaces))
            {
                query["NetworkInterfaces"] = request.NetworkInterfaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInherit))
            {
                query["PasswordInherit"] = request.PasswordInherit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulerOptionsShrink))
            {
                query["SchedulerOptions"] = request.SchedulerOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEnhancementStrategy))
            {
                query["SecurityEnhancementStrategy"] = request.SecurityEnhancementStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInterruptionBehavior))
            {
                query["SpotInterruptionBehavior"] = request.SpotInterruptionBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimits))
            {
                query["SpotPriceLimits"] = request.SpotPriceLimits;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetId))
            {
                query["StorageSetId"] = request.StorageSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetPartitionNumber))
            {
                query["StorageSetPartitionNumber"] = request.StorageSetPartitionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskCategories))
            {
                query["SystemDiskCategories"] = request.SystemDiskCategories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenancy))
            {
                query["Tenancy"] = request.Tenancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageOptions))
            {
                query["ImageOptions"] = request.ImageOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivatePoolOptions))
            {
                query["PrivatePoolOptions"] = request.PrivatePoolOptions;
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
                Version = "2022-02-22",
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
         * @summary Creates a scaling configuration.
         *
         * @description Auto Scaling automatically creates Elastic Compute Service (ECS) instances based on the specified scaling configuration. ECS instances can be created in the following modes:
         * *   InstancePatternInfos: intelligent configuration mode. In this mode, you need to only specify the number of vCPUs, memory size, instance family, and maximum price. Auto Scaling selects the instance type that has the lowest price based on the configurations to create ECS instances. This mode is available only for scaling groups that reside in virtual private clouds (VPCs). This mode reduces scale-out failures caused by insufficient inventory of instance types.
         * *   InstanceType: In this mode, you must specify one instance type.
         * *   InstanceTypes: In this mode, you can specify more than one instance type.
         * *   InstanceTypeOverrides: In this mode, you can specify multiple instance types and weights for the instance types.
         * *   Cpu and Memory: In this mode, you must specify the number of vCPUs and the memory size. Auto Scaling determines the range of available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling creates ECS instances by using the lowest-priced instance type. This mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         * > You cannot specify InstanceType, InstanceTypes, InstanceTypeOverrides, and Cpu and Memory at the same time. You can specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfo at the same time. If you specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfos at the same time, Auto Scaling preferentially uses the instance types that are specified by InstanceType or InstanceTypes for scale-outs. If the instance types that are specified by InstanceType or InstanceTypes do not have sufficient inventory, Auto Scaling uses the instance types that are specified by InstancePatternInfos for scale-outs.
         *
         * @param tmpReq CreateScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingConfigurationResponse
         */
        public async Task<CreateScalingConfigurationResponse> CreateScalingConfigurationWithOptionsAsync(CreateScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScalingConfigurationShrinkRequest request = new CreateScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                query["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditSpecification))
            {
                query["CreditSpecification"] = request.CreditSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPriorities))
            {
                query["CustomPriorities"] = request.CustomPriorities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisks))
            {
                query["DataDisks"] = request.DataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostClusterId))
            {
                query["DedicatedHostClusterId"] = request.DedicatedHostClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostId))
            {
                query["DedicatedHostId"] = request.DedicatedHostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSetId))
            {
                query["DeploymentSetId"] = request.DeploymentSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpcClusterId))
            {
                query["HpcClusterId"] = request.HpcClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFamily))
            {
                query["ImageFamily"] = request.ImageFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancePatternInfos))
            {
                query["InstancePatternInfos"] = request.InstancePatternInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypeOverrides))
            {
                query["InstanceTypeOverrides"] = request.InstanceTypeOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaces))
            {
                query["NetworkInterfaces"] = request.NetworkInterfaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInherit))
            {
                query["PasswordInherit"] = request.PasswordInherit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulerOptionsShrink))
            {
                query["SchedulerOptions"] = request.SchedulerOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEnhancementStrategy))
            {
                query["SecurityEnhancementStrategy"] = request.SecurityEnhancementStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInterruptionBehavior))
            {
                query["SpotInterruptionBehavior"] = request.SpotInterruptionBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimits))
            {
                query["SpotPriceLimits"] = request.SpotPriceLimits;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetId))
            {
                query["StorageSetId"] = request.StorageSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetPartitionNumber))
            {
                query["StorageSetPartitionNumber"] = request.StorageSetPartitionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskCategories))
            {
                query["SystemDiskCategories"] = request.SystemDiskCategories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenancy))
            {
                query["Tenancy"] = request.Tenancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageOptions))
            {
                query["ImageOptions"] = request.ImageOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivatePoolOptions))
            {
                query["PrivatePoolOptions"] = request.PrivatePoolOptions;
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
                Version = "2022-02-22",
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
         * @summary Creates a scaling configuration.
         *
         * @description Auto Scaling automatically creates Elastic Compute Service (ECS) instances based on the specified scaling configuration. ECS instances can be created in the following modes:
         * *   InstancePatternInfos: intelligent configuration mode. In this mode, you need to only specify the number of vCPUs, memory size, instance family, and maximum price. Auto Scaling selects the instance type that has the lowest price based on the configurations to create ECS instances. This mode is available only for scaling groups that reside in virtual private clouds (VPCs). This mode reduces scale-out failures caused by insufficient inventory of instance types.
         * *   InstanceType: In this mode, you must specify one instance type.
         * *   InstanceTypes: In this mode, you can specify more than one instance type.
         * *   InstanceTypeOverrides: In this mode, you can specify multiple instance types and weights for the instance types.
         * *   Cpu and Memory: In this mode, you must specify the number of vCPUs and the memory size. Auto Scaling determines the range of available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling creates ECS instances by using the lowest-priced instance type. This mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         * > You cannot specify InstanceType, InstanceTypes, InstanceTypeOverrides, and Cpu and Memory at the same time. You can specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfo at the same time. If you specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfos at the same time, Auto Scaling preferentially uses the instance types that are specified by InstanceType or InstanceTypes for scale-outs. If the instance types that are specified by InstanceType or InstanceTypes do not have sufficient inventory, Auto Scaling uses the instance types that are specified by InstancePatternInfos for scale-outs.
         *
         * @param request CreateScalingConfigurationRequest
         * @return CreateScalingConfigurationResponse
         */
        public CreateScalingConfigurationResponse CreateScalingConfiguration(CreateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Creates a scaling configuration.
         *
         * @description Auto Scaling automatically creates Elastic Compute Service (ECS) instances based on the specified scaling configuration. ECS instances can be created in the following modes:
         * *   InstancePatternInfos: intelligent configuration mode. In this mode, you need to only specify the number of vCPUs, memory size, instance family, and maximum price. Auto Scaling selects the instance type that has the lowest price based on the configurations to create ECS instances. This mode is available only for scaling groups that reside in virtual private clouds (VPCs). This mode reduces scale-out failures caused by insufficient inventory of instance types.
         * *   InstanceType: In this mode, you must specify one instance type.
         * *   InstanceTypes: In this mode, you can specify more than one instance type.
         * *   InstanceTypeOverrides: In this mode, you can specify multiple instance types and weights for the instance types.
         * *   Cpu and Memory: In this mode, you must specify the number of vCPUs and the memory size. Auto Scaling determines the range of available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling creates ECS instances by using the lowest-priced instance type. This mode is available only if Scaling Policy is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
         * > You cannot specify InstanceType, InstanceTypes, InstanceTypeOverrides, and Cpu and Memory at the same time. You can specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfo at the same time. If you specify InstanceType and InstancePatternInfos or specify InstanceTypes and InstancePatternInfos at the same time, Auto Scaling preferentially uses the instance types that are specified by InstanceType or InstanceTypes for scale-outs. If the instance types that are specified by InstanceType or InstanceTypes do not have sufficient inventory, Auto Scaling uses the instance types that are specified by InstancePatternInfos for scale-outs.
         *
         * @param request CreateScalingConfigurationRequest
         * @return CreateScalingConfigurationResponse
         */
        public async Task<CreateScalingConfigurationResponse> CreateScalingConfigurationAsync(CreateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a scaling group.
         *
         * @description A scaling group is a group of Elastic Compute Service (ECS) instances that can be used in similar business scenarios.
         * You can create only a limited number of scaling groups in a region. Go to Quota Center to check the quota of the scaling groups.
         * A scaling group does not immediately take effect after you create the scaling group. You must call the EnableScalingGroup operation to enable the scaling group. After you enable the scaling group, Auto Scaling can execute scaling rules to trigger scaling activities in the scaling group.
         * The Classic Load Balancer (CLB) instances and ApsaraDB RDS instances that you want to associate with a scaling group must reside in the same region as the scaling group. CLB instances are formerly known as Server Load Balancer (SLB) instances. For more information, see the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) topic.
         * If you associate a CLB instance when you create a scaling group, Auto Scaling automatically adds ECS instances in the scaling group to the backend server group of the associated CLB instance. You can specify a server group to which ECS instances can be added. You can add ECS instances to the following types of server groups:
         * *   Default server group: a group of ECS instances that are used to receive requests. If you do not specify a vServer group or a primary/secondary server group for a listener, requests are forwarded to the ECS instances in the default server group.
         * *   vServer group: If you want to forward requests to backend servers that are not in the default server group or configure domain name-based or URL-based forwarding rules, you can use vServer groups.
         * > If you specify the default server group and multiple vServer groups at the same time, ECS instances are added to all specified server groups.
         * The default weight of an ECS instance that is added as a backend server of a CLB instance is 50. The CLB instance that you want to associate with your scaling group must meet the following requirements:
         * *   The CLB instance must be in the Active state. You can call the DescribeLoadBalancers operation to query the state of the CLB instance.
         * *   The health check feature must be enabled on all listener ports that are configured for the CLB instance. Otherwise, the scaling group fails to be created.
         * If you associate an Application Load Balancer (ALB) server group with a scaling group, Auto Scaling automatically adds ECS instances that are in the scaling group to the ALB server group to process requests distributed by the ALB instance to which the ALB server group belongs. You can specify multiple ALB server groups. The server groups must reside in the same virtual private cloud (VPC) as the scaling group. For more information, see the "AttachAlbServerGroups" topic.
         * If you associate an ApsaraDB RDS instance with a scaling group, Auto Scaling automatically adds the private IP addresses of the ECS instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance. The ApsaraDB RDS instance that you want to associate with your scaling group must meet the following requirements:
         * *   The ApsaraDB RDS instance must be in the Running state. You can call the DescribeDBInstances operation to query the state of the ApsaraDB RDS instance.
         * *   The number of IP addresses in the IP address whitelist of the ApsaraDB RDS instance cannot exceed the upper limit. For more information, see the "Configure whitelists" topic.
         * If you set the MultiAZPolicy parameter of the scaling group to COST_OPTIMIZED, take note of the following items:
         * *   You can use the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, and SpotInstancePools parameters to specify the instance allocation method based on the cost optimization policy. This instance allocation method is prioritized during scaling.
         * *   If you do not specify the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, or SpotInstancePools parameter, the instance types that are provided at the lowest price are used to create instances based on the cost optimization policy.
         * If you set the `Tags.Propagate` parameter of the scaling group to true, the following rules apply:
         * *   Tags that you add to the scaling group cannot be propagated to existing instances in the scaling group. Tags that you add to the scaling group are propagated to only new instances.
         * *   If you specify instance tags in the scaling configuration that is used to create instances and propagate the tags that you add to the scaling group to the instances, all tags exist at the same time.
         * *   If the tag key that you specify in a scaling configuration and the tag key that you add to the scaling group of the scaling configuration are the same, the tag value that you specify in the scaling configuration is preferentially used.
         *
         * @param request CreateScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingGroupResponse
         */
        public CreateScalingGroupResponse CreateScalingGroupWithOptions(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbServerGroups))
            {
                query["AlbServerGroups"] = request.AlbServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationStrategy))
            {
                query["AllocationStrategy"] = request.AllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AzBalance))
            {
                query["AzBalance"] = request.AzBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompensateWithOnDemand))
            {
                query["CompensateWithOnDemand"] = request.CompensateWithOnDemand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPolicyARN))
            {
                query["CustomPolicyARN"] = request.CustomPolicyARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceIds))
            {
                query["DBInstanceIds"] = request.DBInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeletionProtection))
            {
                query["GroupDeletionProtection"] = request.GroupDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTypes))
            {
                query["HealthCheckTypes"] = request.HealthCheckTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateId))
            {
                query["LaunchTemplateId"] = request.LaunchTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateOverrides))
            {
                query["LaunchTemplateOverrides"] = request.LaunchTemplateOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateVersion))
            {
                query["LaunchTemplateVersion"] = request.LaunchTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHooks))
            {
                query["LifecycleHooks"] = request.LifecycleHooks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerConfigs))
            {
                query["LoadBalancerConfigs"] = request.LoadBalancerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInstanceLifetime))
            {
                query["MaxInstanceLifetime"] = request.MaxInstanceLifetime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAZPolicy))
            {
                query["MultiAZPolicy"] = request.MultiAZPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandBaseCapacity))
            {
                query["OnDemandBaseCapacity"] = request.OnDemandBaseCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandPercentageAboveBaseCapacity))
            {
                query["OnDemandPercentageAboveBaseCapacity"] = request.OnDemandPercentageAboveBaseCapacity;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicies))
            {
                query["RemovalPolicies"] = request.RemovalPolicies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroups))
            {
                query["ServerGroups"] = request.ServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotAllocationStrategy))
            {
                query["SpotAllocationStrategy"] = request.SpotAllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstancePools))
            {
                query["SpotInstancePools"] = request.SpotInstancePools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstanceRemedy))
            {
                query["SpotInstanceRemedy"] = request.SpotInstanceRemedy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncAlarmRuleToCms))
            {
                query["SyncAlarmRuleToCms"] = request.SyncAlarmRuleToCms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroups))
            {
                query["VServerGroups"] = request.VServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingGroup",
                Version = "2022-02-22",
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
         * @summary Creates a scaling group.
         *
         * @description A scaling group is a group of Elastic Compute Service (ECS) instances that can be used in similar business scenarios.
         * You can create only a limited number of scaling groups in a region. Go to Quota Center to check the quota of the scaling groups.
         * A scaling group does not immediately take effect after you create the scaling group. You must call the EnableScalingGroup operation to enable the scaling group. After you enable the scaling group, Auto Scaling can execute scaling rules to trigger scaling activities in the scaling group.
         * The Classic Load Balancer (CLB) instances and ApsaraDB RDS instances that you want to associate with a scaling group must reside in the same region as the scaling group. CLB instances are formerly known as Server Load Balancer (SLB) instances. For more information, see the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) topic.
         * If you associate a CLB instance when you create a scaling group, Auto Scaling automatically adds ECS instances in the scaling group to the backend server group of the associated CLB instance. You can specify a server group to which ECS instances can be added. You can add ECS instances to the following types of server groups:
         * *   Default server group: a group of ECS instances that are used to receive requests. If you do not specify a vServer group or a primary/secondary server group for a listener, requests are forwarded to the ECS instances in the default server group.
         * *   vServer group: If you want to forward requests to backend servers that are not in the default server group or configure domain name-based or URL-based forwarding rules, you can use vServer groups.
         * > If you specify the default server group and multiple vServer groups at the same time, ECS instances are added to all specified server groups.
         * The default weight of an ECS instance that is added as a backend server of a CLB instance is 50. The CLB instance that you want to associate with your scaling group must meet the following requirements:
         * *   The CLB instance must be in the Active state. You can call the DescribeLoadBalancers operation to query the state of the CLB instance.
         * *   The health check feature must be enabled on all listener ports that are configured for the CLB instance. Otherwise, the scaling group fails to be created.
         * If you associate an Application Load Balancer (ALB) server group with a scaling group, Auto Scaling automatically adds ECS instances that are in the scaling group to the ALB server group to process requests distributed by the ALB instance to which the ALB server group belongs. You can specify multiple ALB server groups. The server groups must reside in the same virtual private cloud (VPC) as the scaling group. For more information, see the "AttachAlbServerGroups" topic.
         * If you associate an ApsaraDB RDS instance with a scaling group, Auto Scaling automatically adds the private IP addresses of the ECS instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance. The ApsaraDB RDS instance that you want to associate with your scaling group must meet the following requirements:
         * *   The ApsaraDB RDS instance must be in the Running state. You can call the DescribeDBInstances operation to query the state of the ApsaraDB RDS instance.
         * *   The number of IP addresses in the IP address whitelist of the ApsaraDB RDS instance cannot exceed the upper limit. For more information, see the "Configure whitelists" topic.
         * If you set the MultiAZPolicy parameter of the scaling group to COST_OPTIMIZED, take note of the following items:
         * *   You can use the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, and SpotInstancePools parameters to specify the instance allocation method based on the cost optimization policy. This instance allocation method is prioritized during scaling.
         * *   If you do not specify the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, or SpotInstancePools parameter, the instance types that are provided at the lowest price are used to create instances based on the cost optimization policy.
         * If you set the `Tags.Propagate` parameter of the scaling group to true, the following rules apply:
         * *   Tags that you add to the scaling group cannot be propagated to existing instances in the scaling group. Tags that you add to the scaling group are propagated to only new instances.
         * *   If you specify instance tags in the scaling configuration that is used to create instances and propagate the tags that you add to the scaling group to the instances, all tags exist at the same time.
         * *   If the tag key that you specify in a scaling configuration and the tag key that you add to the scaling group of the scaling configuration are the same, the tag value that you specify in the scaling configuration is preferentially used.
         *
         * @param request CreateScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingGroupResponse
         */
        public async Task<CreateScalingGroupResponse> CreateScalingGroupWithOptionsAsync(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbServerGroups))
            {
                query["AlbServerGroups"] = request.AlbServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationStrategy))
            {
                query["AllocationStrategy"] = request.AllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AzBalance))
            {
                query["AzBalance"] = request.AzBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompensateWithOnDemand))
            {
                query["CompensateWithOnDemand"] = request.CompensateWithOnDemand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPolicyARN))
            {
                query["CustomPolicyARN"] = request.CustomPolicyARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceIds))
            {
                query["DBInstanceIds"] = request.DBInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeletionProtection))
            {
                query["GroupDeletionProtection"] = request.GroupDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTypes))
            {
                query["HealthCheckTypes"] = request.HealthCheckTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateId))
            {
                query["LaunchTemplateId"] = request.LaunchTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateOverrides))
            {
                query["LaunchTemplateOverrides"] = request.LaunchTemplateOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateVersion))
            {
                query["LaunchTemplateVersion"] = request.LaunchTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHooks))
            {
                query["LifecycleHooks"] = request.LifecycleHooks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerConfigs))
            {
                query["LoadBalancerConfigs"] = request.LoadBalancerConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInstanceLifetime))
            {
                query["MaxInstanceLifetime"] = request.MaxInstanceLifetime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAZPolicy))
            {
                query["MultiAZPolicy"] = request.MultiAZPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandBaseCapacity))
            {
                query["OnDemandBaseCapacity"] = request.OnDemandBaseCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandPercentageAboveBaseCapacity))
            {
                query["OnDemandPercentageAboveBaseCapacity"] = request.OnDemandPercentageAboveBaseCapacity;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicies))
            {
                query["RemovalPolicies"] = request.RemovalPolicies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroups))
            {
                query["ServerGroups"] = request.ServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotAllocationStrategy))
            {
                query["SpotAllocationStrategy"] = request.SpotAllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstancePools))
            {
                query["SpotInstancePools"] = request.SpotInstancePools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstanceRemedy))
            {
                query["SpotInstanceRemedy"] = request.SpotInstanceRemedy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncAlarmRuleToCms))
            {
                query["SyncAlarmRuleToCms"] = request.SyncAlarmRuleToCms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroups))
            {
                query["VServerGroups"] = request.VServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingGroup",
                Version = "2022-02-22",
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
         * @summary Creates a scaling group.
         *
         * @description A scaling group is a group of Elastic Compute Service (ECS) instances that can be used in similar business scenarios.
         * You can create only a limited number of scaling groups in a region. Go to Quota Center to check the quota of the scaling groups.
         * A scaling group does not immediately take effect after you create the scaling group. You must call the EnableScalingGroup operation to enable the scaling group. After you enable the scaling group, Auto Scaling can execute scaling rules to trigger scaling activities in the scaling group.
         * The Classic Load Balancer (CLB) instances and ApsaraDB RDS instances that you want to associate with a scaling group must reside in the same region as the scaling group. CLB instances are formerly known as Server Load Balancer (SLB) instances. For more information, see the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) topic.
         * If you associate a CLB instance when you create a scaling group, Auto Scaling automatically adds ECS instances in the scaling group to the backend server group of the associated CLB instance. You can specify a server group to which ECS instances can be added. You can add ECS instances to the following types of server groups:
         * *   Default server group: a group of ECS instances that are used to receive requests. If you do not specify a vServer group or a primary/secondary server group for a listener, requests are forwarded to the ECS instances in the default server group.
         * *   vServer group: If you want to forward requests to backend servers that are not in the default server group or configure domain name-based or URL-based forwarding rules, you can use vServer groups.
         * > If you specify the default server group and multiple vServer groups at the same time, ECS instances are added to all specified server groups.
         * The default weight of an ECS instance that is added as a backend server of a CLB instance is 50. The CLB instance that you want to associate with your scaling group must meet the following requirements:
         * *   The CLB instance must be in the Active state. You can call the DescribeLoadBalancers operation to query the state of the CLB instance.
         * *   The health check feature must be enabled on all listener ports that are configured for the CLB instance. Otherwise, the scaling group fails to be created.
         * If you associate an Application Load Balancer (ALB) server group with a scaling group, Auto Scaling automatically adds ECS instances that are in the scaling group to the ALB server group to process requests distributed by the ALB instance to which the ALB server group belongs. You can specify multiple ALB server groups. The server groups must reside in the same virtual private cloud (VPC) as the scaling group. For more information, see the "AttachAlbServerGroups" topic.
         * If you associate an ApsaraDB RDS instance with a scaling group, Auto Scaling automatically adds the private IP addresses of the ECS instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance. The ApsaraDB RDS instance that you want to associate with your scaling group must meet the following requirements:
         * *   The ApsaraDB RDS instance must be in the Running state. You can call the DescribeDBInstances operation to query the state of the ApsaraDB RDS instance.
         * *   The number of IP addresses in the IP address whitelist of the ApsaraDB RDS instance cannot exceed the upper limit. For more information, see the "Configure whitelists" topic.
         * If you set the MultiAZPolicy parameter of the scaling group to COST_OPTIMIZED, take note of the following items:
         * *   You can use the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, and SpotInstancePools parameters to specify the instance allocation method based on the cost optimization policy. This instance allocation method is prioritized during scaling.
         * *   If you do not specify the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, or SpotInstancePools parameter, the instance types that are provided at the lowest price are used to create instances based on the cost optimization policy.
         * If you set the `Tags.Propagate` parameter of the scaling group to true, the following rules apply:
         * *   Tags that you add to the scaling group cannot be propagated to existing instances in the scaling group. Tags that you add to the scaling group are propagated to only new instances.
         * *   If you specify instance tags in the scaling configuration that is used to create instances and propagate the tags that you add to the scaling group to the instances, all tags exist at the same time.
         * *   If the tag key that you specify in a scaling configuration and the tag key that you add to the scaling group of the scaling configuration are the same, the tag value that you specify in the scaling configuration is preferentially used.
         *
         * @param request CreateScalingGroupRequest
         * @return CreateScalingGroupResponse
         */
        public CreateScalingGroupResponse CreateScalingGroup(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a scaling group.
         *
         * @description A scaling group is a group of Elastic Compute Service (ECS) instances that can be used in similar business scenarios.
         * You can create only a limited number of scaling groups in a region. Go to Quota Center to check the quota of the scaling groups.
         * A scaling group does not immediately take effect after you create the scaling group. You must call the EnableScalingGroup operation to enable the scaling group. After you enable the scaling group, Auto Scaling can execute scaling rules to trigger scaling activities in the scaling group.
         * The Classic Load Balancer (CLB) instances and ApsaraDB RDS instances that you want to associate with a scaling group must reside in the same region as the scaling group. CLB instances are formerly known as Server Load Balancer (SLB) instances. For more information, see the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) topic.
         * If you associate a CLB instance when you create a scaling group, Auto Scaling automatically adds ECS instances in the scaling group to the backend server group of the associated CLB instance. You can specify a server group to which ECS instances can be added. You can add ECS instances to the following types of server groups:
         * *   Default server group: a group of ECS instances that are used to receive requests. If you do not specify a vServer group or a primary/secondary server group for a listener, requests are forwarded to the ECS instances in the default server group.
         * *   vServer group: If you want to forward requests to backend servers that are not in the default server group or configure domain name-based or URL-based forwarding rules, you can use vServer groups.
         * > If you specify the default server group and multiple vServer groups at the same time, ECS instances are added to all specified server groups.
         * The default weight of an ECS instance that is added as a backend server of a CLB instance is 50. The CLB instance that you want to associate with your scaling group must meet the following requirements:
         * *   The CLB instance must be in the Active state. You can call the DescribeLoadBalancers operation to query the state of the CLB instance.
         * *   The health check feature must be enabled on all listener ports that are configured for the CLB instance. Otherwise, the scaling group fails to be created.
         * If you associate an Application Load Balancer (ALB) server group with a scaling group, Auto Scaling automatically adds ECS instances that are in the scaling group to the ALB server group to process requests distributed by the ALB instance to which the ALB server group belongs. You can specify multiple ALB server groups. The server groups must reside in the same virtual private cloud (VPC) as the scaling group. For more information, see the "AttachAlbServerGroups" topic.
         * If you associate an ApsaraDB RDS instance with a scaling group, Auto Scaling automatically adds the private IP addresses of the ECS instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance. The ApsaraDB RDS instance that you want to associate with your scaling group must meet the following requirements:
         * *   The ApsaraDB RDS instance must be in the Running state. You can call the DescribeDBInstances operation to query the state of the ApsaraDB RDS instance.
         * *   The number of IP addresses in the IP address whitelist of the ApsaraDB RDS instance cannot exceed the upper limit. For more information, see the "Configure whitelists" topic.
         * If you set the MultiAZPolicy parameter of the scaling group to COST_OPTIMIZED, take note of the following items:
         * *   You can use the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, and SpotInstancePools parameters to specify the instance allocation method based on the cost optimization policy. This instance allocation method is prioritized during scaling.
         * *   If you do not specify the OnDemandBaseCapacity, OnDemandPercentageAboveBaseCapacity, or SpotInstancePools parameter, the instance types that are provided at the lowest price are used to create instances based on the cost optimization policy.
         * If you set the `Tags.Propagate` parameter of the scaling group to true, the following rules apply:
         * *   Tags that you add to the scaling group cannot be propagated to existing instances in the scaling group. Tags that you add to the scaling group are propagated to only new instances.
         * *   If you specify instance tags in the scaling configuration that is used to create instances and propagate the tags that you add to the scaling group to the instances, all tags exist at the same time.
         * *   If the tag key that you specify in a scaling configuration and the tag key that you add to the scaling group of the scaling configuration are the same, the tag value that you specify in the scaling configuration is preferentially used.
         *
         * @param request CreateScalingGroupRequest
         * @return CreateScalingGroupResponse
         */
        public async Task<CreateScalingGroupResponse> CreateScalingGroupAsync(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a scaling rule.
         *
         * @description ## Description
         * A scaling rule defines a specific scaling activity, such as adding or removing N instances. If the number of Elastic Compute Service (ECS) instances in a scaling group is less than the minimum number allowed or greater than the maximum number allowed after a scaling rule is executed, Auto Scaling adjusts the number of ECS instances that you want to add or remove. This way, the number of ECS instances can be maintained within the valid range after the scaling rule is executed. The number of ECS instances that is specified in the scaling rule remains unchanged. Example:
         * *   If your scaling group contains two ECS instances and allows up to three ECS instances, only one ECS instance is added to your scaling group after you execute a scale-out rule in which three ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * *   If your scaling group contains three ECS instances and requires at least two ECS instances, only one ECS instance is removed from your scaling group after you execute a scale-in rule in which five ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * Before you call this operation, take note of the following items:
         * *   If you set the AdjustmentType parameter to TotalCapacity, the number of ECS instances in the scaling group is adjusted to the specified value. The value of the AdjustmentValue parameter must be greater than or equal to 0.
         * *   If you set the AdjustmentType parameter to QuantityChangeInCapacity or PercentChangeInCapacity, a positive value of AdjustmentValue specifies the number of ECS instances that are added to the scaling group, and a negative value of AdjustmentValue specifies the number of ECS instances that are removed from the scaling group.
         * *   If you set the AdjustmentType parameter to PercentChangeInCapacity, Auto Scaling uses the following formula to calculate a value, and then rounds the value to the nearest integer to obtain the number of ECS instances that need to be scaled: Value of TotalCapacity × Value of AdjustmentValue/100.
         * *   If the cooldown time is specified in a scaling rule, the specified time applies to the scaling group after the rule is executed. Otherwise, the value of the DefaultCooldown parameter of the scaling group applies to the scaling group.
         * *   You can create only a limited number of scaling rules for a scaling group. For more information, see the "Limits" topic.
         * *   The unique identifier (ScalingRuleAri) of a scaling rule can be used by the following operations:
         *     *   ExecuteScalingRule: You can call this operation to manually execute a specific scaling rule by setting the ScalingRuleAri parameter to the unique identifier of the scaling rule.
         *     *   CreateScheduledTask: You can call this operation to create a scheduled task for a specific scaling rule by setting the ScheduledAction parameter to the unique identifier of the scaling rule.
         *
         * @param request CreateScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmDimensions))
            {
                query["AlarmDimensions"] = request.AlarmDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableScaleIn))
            {
                query["DisableScaleIn"] = request.DisableScaleIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstimatedInstanceWarmup))
            {
                query["EstimatedInstanceWarmup"] = request.EstimatedInstanceWarmup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialMaxSize))
            {
                query["InitialMaxSize"] = request.InitialMaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAdjustmentMagnitude))
            {
                query["MinAdjustmentMagnitude"] = request.MinAdjustmentMagnitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveScalingMode))
            {
                query["PredictiveScalingMode"] = request.PredictiveScalingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveTaskBufferTime))
            {
                query["PredictiveTaskBufferTime"] = request.PredictiveTaskBufferTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBehavior))
            {
                query["PredictiveValueBehavior"] = request.PredictiveValueBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBuffer))
            {
                query["PredictiveValueBuffer"] = request.PredictiveValueBuffer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleInEvaluationCount))
            {
                query["ScaleInEvaluationCount"] = request.ScaleInEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleOutEvaluationCount))
            {
                query["ScaleOutEvaluationCount"] = request.ScaleOutEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepAdjustments))
            {
                query["StepAdjustments"] = request.StepAdjustments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2022-02-22",
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
         * @summary Creates a scaling rule.
         *
         * @description ## Description
         * A scaling rule defines a specific scaling activity, such as adding or removing N instances. If the number of Elastic Compute Service (ECS) instances in a scaling group is less than the minimum number allowed or greater than the maximum number allowed after a scaling rule is executed, Auto Scaling adjusts the number of ECS instances that you want to add or remove. This way, the number of ECS instances can be maintained within the valid range after the scaling rule is executed. The number of ECS instances that is specified in the scaling rule remains unchanged. Example:
         * *   If your scaling group contains two ECS instances and allows up to three ECS instances, only one ECS instance is added to your scaling group after you execute a scale-out rule in which three ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * *   If your scaling group contains three ECS instances and requires at least two ECS instances, only one ECS instance is removed from your scaling group after you execute a scale-in rule in which five ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * Before you call this operation, take note of the following items:
         * *   If you set the AdjustmentType parameter to TotalCapacity, the number of ECS instances in the scaling group is adjusted to the specified value. The value of the AdjustmentValue parameter must be greater than or equal to 0.
         * *   If you set the AdjustmentType parameter to QuantityChangeInCapacity or PercentChangeInCapacity, a positive value of AdjustmentValue specifies the number of ECS instances that are added to the scaling group, and a negative value of AdjustmentValue specifies the number of ECS instances that are removed from the scaling group.
         * *   If you set the AdjustmentType parameter to PercentChangeInCapacity, Auto Scaling uses the following formula to calculate a value, and then rounds the value to the nearest integer to obtain the number of ECS instances that need to be scaled: Value of TotalCapacity × Value of AdjustmentValue/100.
         * *   If the cooldown time is specified in a scaling rule, the specified time applies to the scaling group after the rule is executed. Otherwise, the value of the DefaultCooldown parameter of the scaling group applies to the scaling group.
         * *   You can create only a limited number of scaling rules for a scaling group. For more information, see the "Limits" topic.
         * *   The unique identifier (ScalingRuleAri) of a scaling rule can be used by the following operations:
         *     *   ExecuteScalingRule: You can call this operation to manually execute a specific scaling rule by setting the ScalingRuleAri parameter to the unique identifier of the scaling rule.
         *     *   CreateScheduledTask: You can call this operation to create a scheduled task for a specific scaling rule by setting the ScheduledAction parameter to the unique identifier of the scaling rule.
         *
         * @param request CreateScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScalingRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmDimensions))
            {
                query["AlarmDimensions"] = request.AlarmDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableScaleIn))
            {
                query["DisableScaleIn"] = request.DisableScaleIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstimatedInstanceWarmup))
            {
                query["EstimatedInstanceWarmup"] = request.EstimatedInstanceWarmup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialMaxSize))
            {
                query["InitialMaxSize"] = request.InitialMaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAdjustmentMagnitude))
            {
                query["MinAdjustmentMagnitude"] = request.MinAdjustmentMagnitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveScalingMode))
            {
                query["PredictiveScalingMode"] = request.PredictiveScalingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveTaskBufferTime))
            {
                query["PredictiveTaskBufferTime"] = request.PredictiveTaskBufferTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBehavior))
            {
                query["PredictiveValueBehavior"] = request.PredictiveValueBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBuffer))
            {
                query["PredictiveValueBuffer"] = request.PredictiveValueBuffer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleInEvaluationCount))
            {
                query["ScaleInEvaluationCount"] = request.ScaleInEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleOutEvaluationCount))
            {
                query["ScaleOutEvaluationCount"] = request.ScaleOutEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepAdjustments))
            {
                query["StepAdjustments"] = request.StepAdjustments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScalingRule",
                Version = "2022-02-22",
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
         * @summary Creates a scaling rule.
         *
         * @description ## Description
         * A scaling rule defines a specific scaling activity, such as adding or removing N instances. If the number of Elastic Compute Service (ECS) instances in a scaling group is less than the minimum number allowed or greater than the maximum number allowed after a scaling rule is executed, Auto Scaling adjusts the number of ECS instances that you want to add or remove. This way, the number of ECS instances can be maintained within the valid range after the scaling rule is executed. The number of ECS instances that is specified in the scaling rule remains unchanged. Example:
         * *   If your scaling group contains two ECS instances and allows up to three ECS instances, only one ECS instance is added to your scaling group after you execute a scale-out rule in which three ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * *   If your scaling group contains three ECS instances and requires at least two ECS instances, only one ECS instance is removed from your scaling group after you execute a scale-in rule in which five ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * Before you call this operation, take note of the following items:
         * *   If you set the AdjustmentType parameter to TotalCapacity, the number of ECS instances in the scaling group is adjusted to the specified value. The value of the AdjustmentValue parameter must be greater than or equal to 0.
         * *   If you set the AdjustmentType parameter to QuantityChangeInCapacity or PercentChangeInCapacity, a positive value of AdjustmentValue specifies the number of ECS instances that are added to the scaling group, and a negative value of AdjustmentValue specifies the number of ECS instances that are removed from the scaling group.
         * *   If you set the AdjustmentType parameter to PercentChangeInCapacity, Auto Scaling uses the following formula to calculate a value, and then rounds the value to the nearest integer to obtain the number of ECS instances that need to be scaled: Value of TotalCapacity × Value of AdjustmentValue/100.
         * *   If the cooldown time is specified in a scaling rule, the specified time applies to the scaling group after the rule is executed. Otherwise, the value of the DefaultCooldown parameter of the scaling group applies to the scaling group.
         * *   You can create only a limited number of scaling rules for a scaling group. For more information, see the "Limits" topic.
         * *   The unique identifier (ScalingRuleAri) of a scaling rule can be used by the following operations:
         *     *   ExecuteScalingRule: You can call this operation to manually execute a specific scaling rule by setting the ScalingRuleAri parameter to the unique identifier of the scaling rule.
         *     *   CreateScheduledTask: You can call this operation to create a scheduled task for a specific scaling rule by setting the ScheduledAction parameter to the unique identifier of the scaling rule.
         *
         * @param request CreateScalingRuleRequest
         * @return CreateScalingRuleResponse
         */
        public CreateScalingRuleResponse CreateScalingRule(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a scaling rule.
         *
         * @description ## Description
         * A scaling rule defines a specific scaling activity, such as adding or removing N instances. If the number of Elastic Compute Service (ECS) instances in a scaling group is less than the minimum number allowed or greater than the maximum number allowed after a scaling rule is executed, Auto Scaling adjusts the number of ECS instances that you want to add or remove. This way, the number of ECS instances can be maintained within the valid range after the scaling rule is executed. The number of ECS instances that is specified in the scaling rule remains unchanged. Example:
         * *   If your scaling group contains two ECS instances and allows up to three ECS instances, only one ECS instance is added to your scaling group after you execute a scale-out rule in which three ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * *   If your scaling group contains three ECS instances and requires at least two ECS instances, only one ECS instance is removed from your scaling group after you execute a scale-in rule in which five ECS instances are specified. The number of ECS instances that is specified in the scaling rule remains unchanged.
         * Before you call this operation, take note of the following items:
         * *   If you set the AdjustmentType parameter to TotalCapacity, the number of ECS instances in the scaling group is adjusted to the specified value. The value of the AdjustmentValue parameter must be greater than or equal to 0.
         * *   If you set the AdjustmentType parameter to QuantityChangeInCapacity or PercentChangeInCapacity, a positive value of AdjustmentValue specifies the number of ECS instances that are added to the scaling group, and a negative value of AdjustmentValue specifies the number of ECS instances that are removed from the scaling group.
         * *   If you set the AdjustmentType parameter to PercentChangeInCapacity, Auto Scaling uses the following formula to calculate a value, and then rounds the value to the nearest integer to obtain the number of ECS instances that need to be scaled: Value of TotalCapacity × Value of AdjustmentValue/100.
         * *   If the cooldown time is specified in a scaling rule, the specified time applies to the scaling group after the rule is executed. Otherwise, the value of the DefaultCooldown parameter of the scaling group applies to the scaling group.
         * *   You can create only a limited number of scaling rules for a scaling group. For more information, see the "Limits" topic.
         * *   The unique identifier (ScalingRuleAri) of a scaling rule can be used by the following operations:
         *     *   ExecuteScalingRule: You can call this operation to manually execute a specific scaling rule by setting the ScalingRuleAri parameter to the unique identifier of the scaling rule.
         *     *   CreateScheduledTask: You can call this operation to create a scheduled task for a specific scaling rule by setting the ScheduledAction parameter to the unique identifier of the scaling rule.
         *
         * @param request CreateScalingRuleRequest
         * @return CreateScalingRuleResponse
         */
        public async Task<CreateScalingRuleResponse> CreateScalingRuleAsync(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a scheduled task. A scheduled task is a type of scaling task that enables automatic execution of a specific scaling rule at a specified point in time. You can call the CreateScheduledTask operation to create a scheduled task to implement automatic scaling of computing resources. This ensures your business continuity and minimizes resource costs.
         *
         * @description *   If a scheduled task fails to trigger a scaling activity due to an ongoing scaling activity in a scaling group or because the scaling group is disabled, the scheduled task is automatically retried during the period that is specified by the LaunchExpirationTime parameter. If the scheduled task still fails to trigger a scaling activity after the period ends, the task is automatically skipped.
         * *   If multiple tasks are scheduled at similar points in time to trigger scaling activities in the same scaling group, the earliest task triggers the scaling activity first. Other tasks trigger scaling activities within their launch expiration time. Only one scaling activity can be triggered in a scaling group at a time.`` If the previous scaling activity is complete and another scheduled task attempts to trigger a scaling activity, Auto Scaling executes the scaling rule that is specified in the scheduled task and then triggers a scaling activity.``
         * *   A scheduled task supports the following scaling methods:
         *     *   `ScheduledAction`: Specify an existing scaling rule that you want Auto Scaling to execute when the scheduled task is triggered.
         *     *   `ScalingGroupId`: Specify the minimum number, maximum number, or expected number of instances for the scaling group for which you created the scheduled task.
         * > You cannot specify the `ScheduledAction` and ScalingGroupId parameters at the same time.
         *
         * @param request CreateScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledTaskResponse
         */
        public CreateScheduledTaskResponse CreateScheduledTaskWithOptions(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                query["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                query["MinValue"] = request.MinValue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
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
                Version = "2022-02-22",
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
         * @summary Creates a scheduled task. A scheduled task is a type of scaling task that enables automatic execution of a specific scaling rule at a specified point in time. You can call the CreateScheduledTask operation to create a scheduled task to implement automatic scaling of computing resources. This ensures your business continuity and minimizes resource costs.
         *
         * @description *   If a scheduled task fails to trigger a scaling activity due to an ongoing scaling activity in a scaling group or because the scaling group is disabled, the scheduled task is automatically retried during the period that is specified by the LaunchExpirationTime parameter. If the scheduled task still fails to trigger a scaling activity after the period ends, the task is automatically skipped.
         * *   If multiple tasks are scheduled at similar points in time to trigger scaling activities in the same scaling group, the earliest task triggers the scaling activity first. Other tasks trigger scaling activities within their launch expiration time. Only one scaling activity can be triggered in a scaling group at a time.`` If the previous scaling activity is complete and another scheduled task attempts to trigger a scaling activity, Auto Scaling executes the scaling rule that is specified in the scheduled task and then triggers a scaling activity.``
         * *   A scheduled task supports the following scaling methods:
         *     *   `ScheduledAction`: Specify an existing scaling rule that you want Auto Scaling to execute when the scheduled task is triggered.
         *     *   `ScalingGroupId`: Specify the minimum number, maximum number, or expected number of instances for the scaling group for which you created the scheduled task.
         * > You cannot specify the `ScheduledAction` and ScalingGroupId parameters at the same time.
         *
         * @param request CreateScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledTaskResponse
         */
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                query["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                query["MinValue"] = request.MinValue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
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
                Version = "2022-02-22",
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
         * @summary Creates a scheduled task. A scheduled task is a type of scaling task that enables automatic execution of a specific scaling rule at a specified point in time. You can call the CreateScheduledTask operation to create a scheduled task to implement automatic scaling of computing resources. This ensures your business continuity and minimizes resource costs.
         *
         * @description *   If a scheduled task fails to trigger a scaling activity due to an ongoing scaling activity in a scaling group or because the scaling group is disabled, the scheduled task is automatically retried during the period that is specified by the LaunchExpirationTime parameter. If the scheduled task still fails to trigger a scaling activity after the period ends, the task is automatically skipped.
         * *   If multiple tasks are scheduled at similar points in time to trigger scaling activities in the same scaling group, the earliest task triggers the scaling activity first. Other tasks trigger scaling activities within their launch expiration time. Only one scaling activity can be triggered in a scaling group at a time.`` If the previous scaling activity is complete and another scheduled task attempts to trigger a scaling activity, Auto Scaling executes the scaling rule that is specified in the scheduled task and then triggers a scaling activity.``
         * *   A scheduled task supports the following scaling methods:
         *     *   `ScheduledAction`: Specify an existing scaling rule that you want Auto Scaling to execute when the scheduled task is triggered.
         *     *   `ScalingGroupId`: Specify the minimum number, maximum number, or expected number of instances for the scaling group for which you created the scheduled task.
         * > You cannot specify the `ScheduledAction` and ScalingGroupId parameters at the same time.
         *
         * @param request CreateScheduledTaskRequest
         * @return CreateScheduledTaskResponse
         */
        public CreateScheduledTaskResponse CreateScheduledTask(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledTaskWithOptions(request, runtime);
        }

        /**
         * @summary Creates a scheduled task. A scheduled task is a type of scaling task that enables automatic execution of a specific scaling rule at a specified point in time. You can call the CreateScheduledTask operation to create a scheduled task to implement automatic scaling of computing resources. This ensures your business continuity and minimizes resource costs.
         *
         * @description *   If a scheduled task fails to trigger a scaling activity due to an ongoing scaling activity in a scaling group or because the scaling group is disabled, the scheduled task is automatically retried during the period that is specified by the LaunchExpirationTime parameter. If the scheduled task still fails to trigger a scaling activity after the period ends, the task is automatically skipped.
         * *   If multiple tasks are scheduled at similar points in time to trigger scaling activities in the same scaling group, the earliest task triggers the scaling activity first. Other tasks trigger scaling activities within their launch expiration time. Only one scaling activity can be triggered in a scaling group at a time.`` If the previous scaling activity is complete and another scheduled task attempts to trigger a scaling activity, Auto Scaling executes the scaling rule that is specified in the scheduled task and then triggers a scaling activity.``
         * *   A scheduled task supports the following scaling methods:
         *     *   `ScheduledAction`: Specify an existing scaling rule that you want Auto Scaling to execute when the scheduled task is triggered.
         *     *   `ScalingGroupId`: Specify the minimum number, maximum number, or expected number of instances for the scaling group for which you created the scheduled task.
         * > You cannot specify the `ScheduledAction` and ScalingGroupId parameters at the same time.
         *
         * @param request CreateScheduledTaskRequest
         * @return CreateScheduledTaskResponse
         */
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskAsync(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deactivates a scaling configuration.
         *
         * @description *   You can call this operation to deactivate a scaling configuration only in a disabled scaling group.
         *
         * @param request DeactivateScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeactivateScalingConfigurationResponse
         */
        public DeactivateScalingConfigurationResponse DeactivateScalingConfigurationWithOptions(DeactivateScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeactivateScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactivateScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deactivates a scaling configuration.
         *
         * @description *   You can call this operation to deactivate a scaling configuration only in a disabled scaling group.
         *
         * @param request DeactivateScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeactivateScalingConfigurationResponse
         */
        public async Task<DeactivateScalingConfigurationResponse> DeactivateScalingConfigurationWithOptionsAsync(DeactivateScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeactivateScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactivateScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deactivates a scaling configuration.
         *
         * @description *   You can call this operation to deactivate a scaling configuration only in a disabled scaling group.
         *
         * @param request DeactivateScalingConfigurationRequest
         * @return DeactivateScalingConfigurationResponse
         */
        public DeactivateScalingConfigurationResponse DeactivateScalingConfiguration(DeactivateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactivateScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Deactivates a scaling configuration.
         *
         * @description *   You can call this operation to deactivate a scaling configuration only in a disabled scaling group.
         *
         * @param request DeactivateScalingConfigurationRequest
         * @return DeactivateScalingConfigurationResponse
         */
        public async Task<DeactivateScalingConfigurationResponse> DeactivateScalingConfigurationAsync(DeactivateScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactivateScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you no longer need an event-triggered task, you can call the DeleteAlarm operation to delete it.
         *
         * @param request DeleteAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlarmResponse
         */
        public DeleteAlarmResponse DeleteAlarmWithOptions(DeleteAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you no longer need an event-triggered task, you can call the DeleteAlarm operation to delete it.
         *
         * @param request DeleteAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlarmResponse
         */
        public async Task<DeleteAlarmResponse> DeleteAlarmWithOptionsAsync(DeleteAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you no longer need an event-triggered task, you can call the DeleteAlarm operation to delete it.
         *
         * @param request DeleteAlarmRequest
         * @return DeleteAlarmResponse
         */
        public DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you no longer need an event-triggered task, you can call the DeleteAlarm operation to delete it.
         *
         * @param request DeleteAlarmRequest
         * @return DeleteAlarmResponse
         */
        public async Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a scaling configuration of the Elastic Container Instance type. If the scaling configuration of a scaling group is in the Inactive state and the scaling group contains no elastic container instances created from the scaling configuration, you can call the DeleteEciScalingConfiguration operation to delete the scaling configuration to free up the scaling configuration quota.
         *
         * @description You cannot call this operation to delete a scaling configuration in the following scenarios:
         * *   The scaling configuration is in the Active state.
         * *   The scaling group contains elastic container instances created from the scaling configuration.
         *
         * @param request DeleteEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEciScalingConfigurationResponse
         */
        public DeleteEciScalingConfigurationResponse DeleteEciScalingConfigurationWithOptions(DeleteEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "DeleteEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEciScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a scaling configuration of the Elastic Container Instance type. If the scaling configuration of a scaling group is in the Inactive state and the scaling group contains no elastic container instances created from the scaling configuration, you can call the DeleteEciScalingConfiguration operation to delete the scaling configuration to free up the scaling configuration quota.
         *
         * @description You cannot call this operation to delete a scaling configuration in the following scenarios:
         * *   The scaling configuration is in the Active state.
         * *   The scaling group contains elastic container instances created from the scaling configuration.
         *
         * @param request DeleteEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEciScalingConfigurationResponse
         */
        public async Task<DeleteEciScalingConfigurationResponse> DeleteEciScalingConfigurationWithOptionsAsync(DeleteEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "DeleteEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEciScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a scaling configuration of the Elastic Container Instance type. If the scaling configuration of a scaling group is in the Inactive state and the scaling group contains no elastic container instances created from the scaling configuration, you can call the DeleteEciScalingConfiguration operation to delete the scaling configuration to free up the scaling configuration quota.
         *
         * @description You cannot call this operation to delete a scaling configuration in the following scenarios:
         * *   The scaling configuration is in the Active state.
         * *   The scaling group contains elastic container instances created from the scaling configuration.
         *
         * @param request DeleteEciScalingConfigurationRequest
         * @return DeleteEciScalingConfigurationResponse
         */
        public DeleteEciScalingConfigurationResponse DeleteEciScalingConfiguration(DeleteEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEciScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a scaling configuration of the Elastic Container Instance type. If the scaling configuration of a scaling group is in the Inactive state and the scaling group contains no elastic container instances created from the scaling configuration, you can call the DeleteEciScalingConfiguration operation to delete the scaling configuration to free up the scaling configuration quota.
         *
         * @description You cannot call this operation to delete a scaling configuration in the following scenarios:
         * *   The scaling configuration is in the Active state.
         * *   The scaling group contains elastic container instances created from the scaling configuration.
         *
         * @param request DeleteEciScalingConfigurationRequest
         * @return DeleteEciScalingConfigurationResponse
         */
        public async Task<DeleteEciScalingConfigurationResponse> DeleteEciScalingConfigurationAsync(DeleteEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEciScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a lifecycle hook.
         *
         * @description If you delete a lifecycle hook that is in effect in a scaling group, instances exit the Pending state in advance. You can use one of the following methods to specify the lifecycle hooks that you want to delete:
         * *   Specify the scaling group ID of the lifecycle hook that you want to delete by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. In this case, the ScalingGroupId parameter and the LifecycleHookName parameter are ignored.
         *
         * @param request DeleteLifecycleHookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLifecycleHookResponse
         */
        public DeleteLifecycleHookResponse DeleteLifecycleHookWithOptions(DeleteLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["LifecycleHookId"] = request.LifecycleHookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
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
                Action = "DeleteLifecycleHook",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLifecycleHookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a lifecycle hook.
         *
         * @description If you delete a lifecycle hook that is in effect in a scaling group, instances exit the Pending state in advance. You can use one of the following methods to specify the lifecycle hooks that you want to delete:
         * *   Specify the scaling group ID of the lifecycle hook that you want to delete by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. In this case, the ScalingGroupId parameter and the LifecycleHookName parameter are ignored.
         *
         * @param request DeleteLifecycleHookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLifecycleHookResponse
         */
        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHookWithOptionsAsync(DeleteLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["LifecycleHookId"] = request.LifecycleHookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
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
                Action = "DeleteLifecycleHook",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLifecycleHookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a lifecycle hook.
         *
         * @description If you delete a lifecycle hook that is in effect in a scaling group, instances exit the Pending state in advance. You can use one of the following methods to specify the lifecycle hooks that you want to delete:
         * *   Specify the scaling group ID of the lifecycle hook that you want to delete by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. In this case, the ScalingGroupId parameter and the LifecycleHookName parameter are ignored.
         *
         * @param request DeleteLifecycleHookRequest
         * @return DeleteLifecycleHookResponse
         */
        public DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLifecycleHookWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a lifecycle hook.
         *
         * @description If you delete a lifecycle hook that is in effect in a scaling group, instances exit the Pending state in advance. You can use one of the following methods to specify the lifecycle hooks that you want to delete:
         * *   Specify the scaling group ID of the lifecycle hook that you want to delete by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. In this case, the ScalingGroupId parameter and the LifecycleHookName parameter are ignored.
         *
         * @param request DeleteLifecycleHookRequest
         * @return DeleteLifecycleHookResponse
         */
        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLifecycleHookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes event notification rules. The event notification feature facilitates efficient issue identification and event management by automatically forwarding notifications from Auto Scaling to designated endpoints such as CloudMonitor or Message Service (MNS) topics and queues. If you no longer require an event notification rule, you can call the DeleteNotificationConfiguration operation to delete it.
         *
         * @param request DeleteNotificationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNotificationConfigurationResponse
         */
        public DeleteNotificationConfigurationResponse DeleteNotificationConfigurationWithOptions(DeleteNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
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
                Action = "DeleteNotificationConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNotificationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes event notification rules. The event notification feature facilitates efficient issue identification and event management by automatically forwarding notifications from Auto Scaling to designated endpoints such as CloudMonitor or Message Service (MNS) topics and queues. If you no longer require an event notification rule, you can call the DeleteNotificationConfiguration operation to delete it.
         *
         * @param request DeleteNotificationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNotificationConfigurationResponse
         */
        public async Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationWithOptionsAsync(DeleteNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
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
                Action = "DeleteNotificationConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNotificationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes event notification rules. The event notification feature facilitates efficient issue identification and event management by automatically forwarding notifications from Auto Scaling to designated endpoints such as CloudMonitor or Message Service (MNS) topics and queues. If you no longer require an event notification rule, you can call the DeleteNotificationConfiguration operation to delete it.
         *
         * @param request DeleteNotificationConfigurationRequest
         * @return DeleteNotificationConfigurationResponse
         */
        public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNotificationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Deletes event notification rules. The event notification feature facilitates efficient issue identification and event management by automatically forwarding notifications from Auto Scaling to designated endpoints such as CloudMonitor or Message Service (MNS) topics and queues. If you no longer require an event notification rule, you can call the DeleteNotificationConfiguration operation to delete it.
         *
         * @param request DeleteNotificationConfigurationRequest
         * @return DeleteNotificationConfigurationResponse
         */
        public async Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNotificationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a scaling configuration that is used to create Elastic Compute Service (ECS) instances.
         *
         * @description You cannot delete a scaling configuration in one of the following scenarios:
         * *   The scaling configuration in your scaling group is in the Active state.
         * *   The scaling group contains ECS instances that were created based on the scaling configuration.
         *
         * @param request DeleteScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingConfigurationResponse
         */
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
                Version = "2022-02-22",
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
         * @summary Deletes a scaling configuration that is used to create Elastic Compute Service (ECS) instances.
         *
         * @description You cannot delete a scaling configuration in one of the following scenarios:
         * *   The scaling configuration in your scaling group is in the Active state.
         * *   The scaling group contains ECS instances that were created based on the scaling configuration.
         *
         * @param request DeleteScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingConfigurationResponse
         */
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
                Version = "2022-02-22",
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
         * @summary Deletes a scaling configuration that is used to create Elastic Compute Service (ECS) instances.
         *
         * @description You cannot delete a scaling configuration in one of the following scenarios:
         * *   The scaling configuration in your scaling group is in the Active state.
         * *   The scaling group contains ECS instances that were created based on the scaling configuration.
         *
         * @param request DeleteScalingConfigurationRequest
         * @return DeleteScalingConfigurationResponse
         */
        public DeleteScalingConfigurationResponse DeleteScalingConfiguration(DeleteScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a scaling configuration that is used to create Elastic Compute Service (ECS) instances.
         *
         * @description You cannot delete a scaling configuration in one of the following scenarios:
         * *   The scaling configuration in your scaling group is in the Active state.
         * *   The scaling group contains ECS instances that were created based on the scaling configuration.
         *
         * @param request DeleteScalingConfigurationRequest
         * @return DeleteScalingConfigurationResponse
         */
        public async Task<DeleteScalingConfigurationResponse> DeleteScalingConfigurationAsync(DeleteScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can create scaling groups to manage your computing power with ease. The computing power refers to the instances that provide the computing capability. If you no longer require a scaling group, you can call the DeleteScalingGroup operation to delete it to free up the scaling group quota.
         *
         * @description Before you call the DeleteScalingGroup operation, take note of the following items:
         * *   If you delete a scaling group, the scaling configurations, scaling rules, scaling activities, and scaling requests related to the scaling group are also deleted.
         * *   If you delete a scaling group, the scheduled tasks and event-triggered tasks of the scaling group are not deleted. The Server Load Balancer (SLB) instances and ApsaraDB RDS instances that are attached to the scaling group are also not deleted.
         * *   If the scaling group that you want to delete contains ECS instances or elastic container instances that are in the In Service state, Auto Scaling stops the instances and then removes all manually added instances from the scaling group or releases all automatically created instances in the scaling group before the scaling group is deleted.
         *     **
         *     **Note** Before you delete a scaling group, make sure that the Deletion Protection feature is disabled. If you have enabled the Deletion Protection feature for a scaling group, disable the feature on the Modify Scaling Group page before you delete the scaling group.
         * *   If you do not disable the Deletion Protection feature for a scaling group, you cannot delete the scaling group by using the Auto Scaling console or calling this operation. The Deletion Protection feature is an effective measure to safeguard scaling groups against unintended deletion.
         * *   Prior to deleting a scaling group, make sure that your ECS instances within the scaling group are safeguarded against unintended release. Even if you have already enabled the Release Protection feature for the ECS instances, you must manually put these ECS instances into the Protected state. Doing so guarantees that the ECS instances will not be forcibly released during the deletion process of the scaling group, providing an extra layer of security.
         *     **
         *     **Note** Before you delete a scaling group, we recommend that you enable the Deletion Protection feature for ECS instances that you want to retain. This action guarantees that the ECS instances are not forcibly released after you delete the scaling group. For more information, see [SetInstancesProtection](https://help.aliyun.com/document_detail/459342.html).
         *
         * @param request DeleteScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingGroupResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingGroup",
                Version = "2022-02-22",
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
         * @summary Deletes a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can create scaling groups to manage your computing power with ease. The computing power refers to the instances that provide the computing capability. If you no longer require a scaling group, you can call the DeleteScalingGroup operation to delete it to free up the scaling group quota.
         *
         * @description Before you call the DeleteScalingGroup operation, take note of the following items:
         * *   If you delete a scaling group, the scaling configurations, scaling rules, scaling activities, and scaling requests related to the scaling group are also deleted.
         * *   If you delete a scaling group, the scheduled tasks and event-triggered tasks of the scaling group are not deleted. The Server Load Balancer (SLB) instances and ApsaraDB RDS instances that are attached to the scaling group are also not deleted.
         * *   If the scaling group that you want to delete contains ECS instances or elastic container instances that are in the In Service state, Auto Scaling stops the instances and then removes all manually added instances from the scaling group or releases all automatically created instances in the scaling group before the scaling group is deleted.
         *     **
         *     **Note** Before you delete a scaling group, make sure that the Deletion Protection feature is disabled. If you have enabled the Deletion Protection feature for a scaling group, disable the feature on the Modify Scaling Group page before you delete the scaling group.
         * *   If you do not disable the Deletion Protection feature for a scaling group, you cannot delete the scaling group by using the Auto Scaling console or calling this operation. The Deletion Protection feature is an effective measure to safeguard scaling groups against unintended deletion.
         * *   Prior to deleting a scaling group, make sure that your ECS instances within the scaling group are safeguarded against unintended release. Even if you have already enabled the Release Protection feature for the ECS instances, you must manually put these ECS instances into the Protected state. Doing so guarantees that the ECS instances will not be forcibly released during the deletion process of the scaling group, providing an extra layer of security.
         *     **
         *     **Note** Before you delete a scaling group, we recommend that you enable the Deletion Protection feature for ECS instances that you want to retain. This action guarantees that the ECS instances are not forcibly released after you delete the scaling group. For more information, see [SetInstancesProtection](https://help.aliyun.com/document_detail/459342.html).
         *
         * @param request DeleteScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingGroupResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScalingGroup",
                Version = "2022-02-22",
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
         * @summary Deletes a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can create scaling groups to manage your computing power with ease. The computing power refers to the instances that provide the computing capability. If you no longer require a scaling group, you can call the DeleteScalingGroup operation to delete it to free up the scaling group quota.
         *
         * @description Before you call the DeleteScalingGroup operation, take note of the following items:
         * *   If you delete a scaling group, the scaling configurations, scaling rules, scaling activities, and scaling requests related to the scaling group are also deleted.
         * *   If you delete a scaling group, the scheduled tasks and event-triggered tasks of the scaling group are not deleted. The Server Load Balancer (SLB) instances and ApsaraDB RDS instances that are attached to the scaling group are also not deleted.
         * *   If the scaling group that you want to delete contains ECS instances or elastic container instances that are in the In Service state, Auto Scaling stops the instances and then removes all manually added instances from the scaling group or releases all automatically created instances in the scaling group before the scaling group is deleted.
         *     **
         *     **Note** Before you delete a scaling group, make sure that the Deletion Protection feature is disabled. If you have enabled the Deletion Protection feature for a scaling group, disable the feature on the Modify Scaling Group page before you delete the scaling group.
         * *   If you do not disable the Deletion Protection feature for a scaling group, you cannot delete the scaling group by using the Auto Scaling console or calling this operation. The Deletion Protection feature is an effective measure to safeguard scaling groups against unintended deletion.
         * *   Prior to deleting a scaling group, make sure that your ECS instances within the scaling group are safeguarded against unintended release. Even if you have already enabled the Release Protection feature for the ECS instances, you must manually put these ECS instances into the Protected state. Doing so guarantees that the ECS instances will not be forcibly released during the deletion process of the scaling group, providing an extra layer of security.
         *     **
         *     **Note** Before you delete a scaling group, we recommend that you enable the Deletion Protection feature for ECS instances that you want to retain. This action guarantees that the ECS instances are not forcibly released after you delete the scaling group. For more information, see [SetInstancesProtection](https://help.aliyun.com/document_detail/459342.html).
         *
         * @param request DeleteScalingGroupRequest
         * @return DeleteScalingGroupResponse
         */
        public DeleteScalingGroupResponse DeleteScalingGroup(DeleteScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can create scaling groups to manage your computing power with ease. The computing power refers to the instances that provide the computing capability. If you no longer require a scaling group, you can call the DeleteScalingGroup operation to delete it to free up the scaling group quota.
         *
         * @description Before you call the DeleteScalingGroup operation, take note of the following items:
         * *   If you delete a scaling group, the scaling configurations, scaling rules, scaling activities, and scaling requests related to the scaling group are also deleted.
         * *   If you delete a scaling group, the scheduled tasks and event-triggered tasks of the scaling group are not deleted. The Server Load Balancer (SLB) instances and ApsaraDB RDS instances that are attached to the scaling group are also not deleted.
         * *   If the scaling group that you want to delete contains ECS instances or elastic container instances that are in the In Service state, Auto Scaling stops the instances and then removes all manually added instances from the scaling group or releases all automatically created instances in the scaling group before the scaling group is deleted.
         *     **
         *     **Note** Before you delete a scaling group, make sure that the Deletion Protection feature is disabled. If you have enabled the Deletion Protection feature for a scaling group, disable the feature on the Modify Scaling Group page before you delete the scaling group.
         * *   If you do not disable the Deletion Protection feature for a scaling group, you cannot delete the scaling group by using the Auto Scaling console or calling this operation. The Deletion Protection feature is an effective measure to safeguard scaling groups against unintended deletion.
         * *   Prior to deleting a scaling group, make sure that your ECS instances within the scaling group are safeguarded against unintended release. Even if you have already enabled the Release Protection feature for the ECS instances, you must manually put these ECS instances into the Protected state. Doing so guarantees that the ECS instances will not be forcibly released during the deletion process of the scaling group, providing an extra layer of security.
         *     **
         *     **Note** Before you delete a scaling group, we recommend that you enable the Deletion Protection feature for ECS instances that you want to retain. This action guarantees that the ECS instances are not forcibly released after you delete the scaling group. For more information, see [SetInstancesProtection](https://help.aliyun.com/document_detail/459342.html).
         *
         * @param request DeleteScalingGroupRequest
         * @return DeleteScalingGroupResponse
         */
        public async Task<DeleteScalingGroupResponse> DeleteScalingGroupAsync(DeleteScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a scaling rule.
         *
         * @param request DeleteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Version = "2022-02-22",
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
         * @summary Deletes a scaling rule.
         *
         * @param request DeleteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScalingRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Version = "2022-02-22",
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
         * @summary Deletes a scaling rule.
         *
         * @param request DeleteScalingRuleRequest
         * @return DeleteScalingRuleResponse
         */
        public DeleteScalingRuleResponse DeleteScalingRule(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a scaling rule.
         *
         * @param request DeleteScalingRuleRequest
         * @return DeleteScalingRuleResponse
         */
        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleAsync(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes scheduled tasks. For workloads with predictable patterns, you can create scheduled tasks to align with your business requirements and optimize resource utilization for cost savings. These tasks automatically ensure that sufficient computing resources are provisioned in anticipation of peak hours and efficiently release unused resources during off-peak hours, thereby streamlining operational efficiency and reducing expenses. If you no longer require a scheduled task, you can call the DeleteScheduledTask operation to delete it.
         *
         * @param request DeleteScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledTaskResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Version = "2022-02-22",
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
         * @summary Deletes scheduled tasks. For workloads with predictable patterns, you can create scheduled tasks to align with your business requirements and optimize resource utilization for cost savings. These tasks automatically ensure that sufficient computing resources are provisioned in anticipation of peak hours and efficiently release unused resources during off-peak hours, thereby streamlining operational efficiency and reducing expenses. If you no longer require a scheduled task, you can call the DeleteScheduledTask operation to delete it.
         *
         * @param request DeleteScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledTaskResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Version = "2022-02-22",
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
         * @summary Deletes scheduled tasks. For workloads with predictable patterns, you can create scheduled tasks to align with your business requirements and optimize resource utilization for cost savings. These tasks automatically ensure that sufficient computing resources are provisioned in anticipation of peak hours and efficiently release unused resources during off-peak hours, thereby streamlining operational efficiency and reducing expenses. If you no longer require a scheduled task, you can call the DeleteScheduledTask operation to delete it.
         *
         * @param request DeleteScheduledTaskRequest
         * @return DeleteScheduledTaskResponse
         */
        public DeleteScheduledTaskResponse DeleteScheduledTask(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledTaskWithOptions(request, runtime);
        }

        /**
         * @summary Deletes scheduled tasks. For workloads with predictable patterns, you can create scheduled tasks to align with your business requirements and optimize resource utilization for cost savings. These tasks automatically ensure that sufficient computing resources are provisioned in anticipation of peak hours and efficiently release unused resources during off-peak hours, thereby streamlining operational efficiency and reducing expenses. If you no longer require a scheduled task, you can call the DeleteScheduledTask operation to delete it.
         *
         * @param request DeleteScheduledTaskRequest
         * @return DeleteScheduledTaskResponse
         */
        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskAsync(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries event-triggered tasks. You can call the DescribeAlarms operation to learn about the configurations of event-triggered tasks and keep updated on monitoring data changes. This helps you troubleshoot system resource issues at the earliest opportunity and ensures system stability and reliability.
         *
         * @param request DescribeAlarmsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAlarmsResponse
         */
        public DescribeAlarmsResponse DescribeAlarmsWithOptions(DescribeAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlarms",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlarmsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries event-triggered tasks. You can call the DescribeAlarms operation to learn about the configurations of event-triggered tasks and keep updated on monitoring data changes. This helps you troubleshoot system resource issues at the earliest opportunity and ensures system stability and reliability.
         *
         * @param request DescribeAlarmsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAlarmsResponse
         */
        public async Task<DescribeAlarmsResponse> DescribeAlarmsWithOptionsAsync(DescribeAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlarms",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlarmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries event-triggered tasks. You can call the DescribeAlarms operation to learn about the configurations of event-triggered tasks and keep updated on monitoring data changes. This helps you troubleshoot system resource issues at the earliest opportunity and ensures system stability and reliability.
         *
         * @param request DescribeAlarmsRequest
         * @return DescribeAlarmsResponse
         */
        public DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlarmsWithOptions(request, runtime);
        }

        /**
         * @summary Queries event-triggered tasks. You can call the DescribeAlarms operation to learn about the configurations of event-triggered tasks and keep updated on monitoring data changes. This helps you troubleshoot system resource issues at the earliest opportunity and ensures system stability and reliability.
         *
         * @param request DescribeAlarmsRequest
         * @return DescribeAlarmsResponse
         */
        public async Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlarmsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAlertConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAlertConfigurationResponse
         */
        public DescribeAlertConfigurationResponse DescribeAlertConfigurationWithOptions(DescribeAlertConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeAlertConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAlertConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAlertConfigurationResponse
         */
        public async Task<DescribeAlertConfigurationResponse> DescribeAlertConfigurationWithOptionsAsync(DescribeAlertConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeAlertConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAlertConfigurationRequest
         * @return DescribeAlertConfigurationResponse
         */
        public DescribeAlertConfigurationResponse DescribeAlertConfiguration(DescribeAlertConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertConfigurationWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAlertConfigurationRequest
         * @return DescribeAlertConfigurationResponse
         */
        public async Task<DescribeAlertConfigurationResponse> DescribeAlertConfigurationAsync(DescribeAlertConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeEciScalingConfigurationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEciScalingConfigurationDetailResponse
         */
        public DescribeEciScalingConfigurationDetailResponse DescribeEciScalingConfigurationDetailWithOptions(DescribeEciScalingConfigurationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                query["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
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
                Action = "DescribeEciScalingConfigurationDetail",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEciScalingConfigurationDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeEciScalingConfigurationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEciScalingConfigurationDetailResponse
         */
        public async Task<DescribeEciScalingConfigurationDetailResponse> DescribeEciScalingConfigurationDetailWithOptionsAsync(DescribeEciScalingConfigurationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                query["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
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
                Action = "DescribeEciScalingConfigurationDetail",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEciScalingConfigurationDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeEciScalingConfigurationDetailRequest
         * @return DescribeEciScalingConfigurationDetailResponse
         */
        public DescribeEciScalingConfigurationDetailResponse DescribeEciScalingConfigurationDetail(DescribeEciScalingConfigurationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEciScalingConfigurationDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeEciScalingConfigurationDetailRequest
         * @return DescribeEciScalingConfigurationDetailResponse
         */
        public async Task<DescribeEciScalingConfigurationDetailResponse> DescribeEciScalingConfigurationDetailAsync(DescribeEciScalingConfigurationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEciScalingConfigurationDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances.
         *
         * @param request DescribeEciScalingConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEciScalingConfigurationsResponse
         */
        public DescribeEciScalingConfigurationsResponse DescribeEciScalingConfigurationsWithOptions(DescribeEciScalingConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationIds))
            {
                query["ScalingConfigurationIds"] = request.ScalingConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationNames))
            {
                query["ScalingConfigurationNames"] = request.ScalingConfigurationNames;
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
                Action = "DescribeEciScalingConfigurations",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEciScalingConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances.
         *
         * @param request DescribeEciScalingConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEciScalingConfigurationsResponse
         */
        public async Task<DescribeEciScalingConfigurationsResponse> DescribeEciScalingConfigurationsWithOptionsAsync(DescribeEciScalingConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationIds))
            {
                query["ScalingConfigurationIds"] = request.ScalingConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationNames))
            {
                query["ScalingConfigurationNames"] = request.ScalingConfigurationNames;
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
                Action = "DescribeEciScalingConfigurations",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEciScalingConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances.
         *
         * @param request DescribeEciScalingConfigurationsRequest
         * @return DescribeEciScalingConfigurationsResponse
         */
        public DescribeEciScalingConfigurationsResponse DescribeEciScalingConfigurations(DescribeEciScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEciScalingConfigurationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries scaling configurations of the Elastic Container Instance type to learn the scaling configuration details. This allows you to select an appropriate template when you create elastic container instances.
         *
         * @param request DescribeEciScalingConfigurationsRequest
         * @return DescribeEciScalingConfigurationsResponse
         */
        public async Task<DescribeEciScalingConfigurationsResponse> DescribeEciScalingConfigurationsAsync(DescribeEciScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEciScalingConfigurationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries lifecycle actions.
         *
         * @description If a scaling activity is executed and a lifecycle hook is created for the scaling activity, the lifecycle hook triggers a lifecycle action. A lifecycle action can be in one of the following states:
         * *   If a lifecycle action is in the Pending state, Elastic Compute Service (ECS) instances are waiting to be added to a scaling group or waiting to be removed from a scaling group.
         * *   If a lifecycle action is in the Timeout state, the lifecycle hook that triggers the lifecycle action expires and ECS instances are added to or removed from a scaling group.
         * *   If a lifecycle action is in the Completed state, you manually end the lifecycle hook that triggers the lifecycle action ahead of schedule.
         * If you do not specify the action to perform, such as execute a specific OOS template, after a lifecycle hook ends, you can call this operation to obtain the token of the lifecycle action that corresponds to the lifecycle hook. Then, you can specify a custom action to perform after the lifecycle hook ends.
         *
         * @param request DescribeLifecycleActionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLifecycleActionsResponse
         */
        public DescribeLifecycleActionsResponse DescribeLifecycleActionsWithOptions(DescribeLifecycleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionStatus))
            {
                query["LifecycleActionStatus"] = request.LifecycleActionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "DescribeLifecycleActions",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecycleActionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries lifecycle actions.
         *
         * @description If a scaling activity is executed and a lifecycle hook is created for the scaling activity, the lifecycle hook triggers a lifecycle action. A lifecycle action can be in one of the following states:
         * *   If a lifecycle action is in the Pending state, Elastic Compute Service (ECS) instances are waiting to be added to a scaling group or waiting to be removed from a scaling group.
         * *   If a lifecycle action is in the Timeout state, the lifecycle hook that triggers the lifecycle action expires and ECS instances are added to or removed from a scaling group.
         * *   If a lifecycle action is in the Completed state, you manually end the lifecycle hook that triggers the lifecycle action ahead of schedule.
         * If you do not specify the action to perform, such as execute a specific OOS template, after a lifecycle hook ends, you can call this operation to obtain the token of the lifecycle action that corresponds to the lifecycle hook. Then, you can specify a custom action to perform after the lifecycle hook ends.
         *
         * @param request DescribeLifecycleActionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLifecycleActionsResponse
         */
        public async Task<DescribeLifecycleActionsResponse> DescribeLifecycleActionsWithOptionsAsync(DescribeLifecycleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionStatus))
            {
                query["LifecycleActionStatus"] = request.LifecycleActionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "DescribeLifecycleActions",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecycleActionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries lifecycle actions.
         *
         * @description If a scaling activity is executed and a lifecycle hook is created for the scaling activity, the lifecycle hook triggers a lifecycle action. A lifecycle action can be in one of the following states:
         * *   If a lifecycle action is in the Pending state, Elastic Compute Service (ECS) instances are waiting to be added to a scaling group or waiting to be removed from a scaling group.
         * *   If a lifecycle action is in the Timeout state, the lifecycle hook that triggers the lifecycle action expires and ECS instances are added to or removed from a scaling group.
         * *   If a lifecycle action is in the Completed state, you manually end the lifecycle hook that triggers the lifecycle action ahead of schedule.
         * If you do not specify the action to perform, such as execute a specific OOS template, after a lifecycle hook ends, you can call this operation to obtain the token of the lifecycle action that corresponds to the lifecycle hook. Then, you can specify a custom action to perform after the lifecycle hook ends.
         *
         * @param request DescribeLifecycleActionsRequest
         * @return DescribeLifecycleActionsResponse
         */
        public DescribeLifecycleActionsResponse DescribeLifecycleActions(DescribeLifecycleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecycleActionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries lifecycle actions.
         *
         * @description If a scaling activity is executed and a lifecycle hook is created for the scaling activity, the lifecycle hook triggers a lifecycle action. A lifecycle action can be in one of the following states:
         * *   If a lifecycle action is in the Pending state, Elastic Compute Service (ECS) instances are waiting to be added to a scaling group or waiting to be removed from a scaling group.
         * *   If a lifecycle action is in the Timeout state, the lifecycle hook that triggers the lifecycle action expires and ECS instances are added to or removed from a scaling group.
         * *   If a lifecycle action is in the Completed state, you manually end the lifecycle hook that triggers the lifecycle action ahead of schedule.
         * If you do not specify the action to perform, such as execute a specific OOS template, after a lifecycle hook ends, you can call this operation to obtain the token of the lifecycle action that corresponds to the lifecycle hook. Then, you can specify a custom action to perform after the lifecycle hook ends.
         *
         * @param request DescribeLifecycleActionsRequest
         * @return DescribeLifecycleActionsResponse
         */
        public async Task<DescribeLifecycleActionsResponse> DescribeLifecycleActionsAsync(DescribeLifecycleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecycleActionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries lifecycle hooks.
         *
         * @description You can use one of the following methods to query lifecycle hooks:
         * *   Specify a list of lifecycle hook IDs by using the LifecycleHookIds parameter. In this case, you do not need to specify the ScalingGroupId and LifecycleHookName parameters.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter at the same time.
         *
         * @param request DescribeLifecycleHooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLifecycleHooksResponse
         */
        public DescribeLifecycleHooksResponse DescribeLifecycleHooksWithOptions(DescribeLifecycleHooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookIds))
            {
                query["LifecycleHookIds"] = request.LifecycleHookIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
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
                Action = "DescribeLifecycleHooks",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecycleHooksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries lifecycle hooks.
         *
         * @description You can use one of the following methods to query lifecycle hooks:
         * *   Specify a list of lifecycle hook IDs by using the LifecycleHookIds parameter. In this case, you do not need to specify the ScalingGroupId and LifecycleHookName parameters.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter at the same time.
         *
         * @param request DescribeLifecycleHooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLifecycleHooksResponse
         */
        public async Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksWithOptionsAsync(DescribeLifecycleHooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookIds))
            {
                query["LifecycleHookIds"] = request.LifecycleHookIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
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
                Action = "DescribeLifecycleHooks",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLifecycleHooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries lifecycle hooks.
         *
         * @description You can use one of the following methods to query lifecycle hooks:
         * *   Specify a list of lifecycle hook IDs by using the LifecycleHookIds parameter. In this case, you do not need to specify the ScalingGroupId and LifecycleHookName parameters.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter at the same time.
         *
         * @param request DescribeLifecycleHooksRequest
         * @return DescribeLifecycleHooksResponse
         */
        public DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLifecycleHooksWithOptions(request, runtime);
        }

        /**
         * @summary Queries lifecycle hooks.
         *
         * @description You can use one of the following methods to query lifecycle hooks:
         * *   Specify a list of lifecycle hook IDs by using the LifecycleHookIds parameter. In this case, you do not need to specify the ScalingGroupId and LifecycleHookName parameters.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter at the same time.
         *
         * @param request DescribeLifecycleHooksRequest
         * @return DescribeLifecycleHooksResponse
         */
        public async Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLifecycleHooksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries resource quotas. You can call the DescribeLimitation operation to query the upper limits on resources such as scheduled tasks that can be created in a scaling group, load balancers that can be attached to a scaling group, instances that can be contained in a scaling group, and scaling configurations that can be created in a scaling group.
         *
         * @param request DescribeLimitationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLimitationResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLimitation",
                Version = "2022-02-22",
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
         * @summary Queries resource quotas. You can call the DescribeLimitation operation to query the upper limits on resources such as scheduled tasks that can be created in a scaling group, load balancers that can be attached to a scaling group, instances that can be contained in a scaling group, and scaling configurations that can be created in a scaling group.
         *
         * @param request DescribeLimitationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLimitationResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLimitation",
                Version = "2022-02-22",
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
         * @summary Queries resource quotas. You can call the DescribeLimitation operation to query the upper limits on resources such as scheduled tasks that can be created in a scaling group, load balancers that can be attached to a scaling group, instances that can be contained in a scaling group, and scaling configurations that can be created in a scaling group.
         *
         * @param request DescribeLimitationRequest
         * @return DescribeLimitationResponse
         */
        public DescribeLimitationResponse DescribeLimitation(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLimitationWithOptions(request, runtime);
        }

        /**
         * @summary Queries resource quotas. You can call the DescribeLimitation operation to query the upper limits on resources such as scheduled tasks that can be created in a scaling group, load balancers that can be attached to a scaling group, instances that can be contained in a scaling group, and scaling configurations that can be created in a scaling group.
         *
         * @param request DescribeLimitationRequest
         * @return DescribeLimitationResponse
         */
        public async Task<DescribeLimitationResponse> DescribeLimitationAsync(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLimitationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries event notifications.
         *
         * @param request DescribeNotificationConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNotificationConfigurationsResponse
         */
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurationsWithOptions(DescribeNotificationConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeNotificationConfigurations",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNotificationConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries event notifications.
         *
         * @param request DescribeNotificationConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNotificationConfigurationsResponse
         */
        public async Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsWithOptionsAsync(DescribeNotificationConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeNotificationConfigurations",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNotificationConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries event notifications.
         *
         * @param request DescribeNotificationConfigurationsRequest
         * @return DescribeNotificationConfigurationsResponse
         */
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNotificationConfigurationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries event notifications.
         *
         * @param request DescribeNotificationConfigurationsRequest
         * @return DescribeNotificationConfigurationsResponse
         */
        public async Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNotificationConfigurationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries notification types.
         *
         * @param request DescribeNotificationTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNotificationTypesResponse
         */
        public DescribeNotificationTypesResponse DescribeNotificationTypesWithOptions(DescribeNotificationTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeNotificationTypes",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNotificationTypesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries notification types.
         *
         * @param request DescribeNotificationTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNotificationTypesResponse
         */
        public async Task<DescribeNotificationTypesResponse> DescribeNotificationTypesWithOptionsAsync(DescribeNotificationTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeNotificationTypes",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNotificationTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries notification types.
         *
         * @param request DescribeNotificationTypesRequest
         * @return DescribeNotificationTypesResponse
         */
        public DescribeNotificationTypesResponse DescribeNotificationTypes(DescribeNotificationTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNotificationTypesWithOptions(request, runtime);
        }

        /**
         * @summary Queries notification types.
         *
         * @param request DescribeNotificationTypesRequest
         * @return DescribeNotificationTypesResponse
         */
        public async Task<DescribeNotificationTypesResponse> DescribeNotificationTypesAsync(DescribeNotificationTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNotificationTypesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Filters instance types that meet your business requirements. If you create a scaling configuration by opting for the Specify Instance Type approach, you can call the DescribePatternTypes operation. This operation is designed to sift through and identify instance types that fulfill your specific business needs. It does so by examining the number of vCPUs, memory size, instance family level, and maximum budgeted expense that you specify within the scaling configuration settings.
         *
         * @param request DescribePatternTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePatternTypesResponse
         */
        public DescribePatternTypesResponse DescribePatternTypesWithOptions(DescribePatternTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePatternTypes",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePatternTypesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Filters instance types that meet your business requirements. If you create a scaling configuration by opting for the Specify Instance Type approach, you can call the DescribePatternTypes operation. This operation is designed to sift through and identify instance types that fulfill your specific business needs. It does so by examining the number of vCPUs, memory size, instance family level, and maximum budgeted expense that you specify within the scaling configuration settings.
         *
         * @param request DescribePatternTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePatternTypesResponse
         */
        public async Task<DescribePatternTypesResponse> DescribePatternTypesWithOptionsAsync(DescribePatternTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePatternTypes",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePatternTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Filters instance types that meet your business requirements. If you create a scaling configuration by opting for the Specify Instance Type approach, you can call the DescribePatternTypes operation. This operation is designed to sift through and identify instance types that fulfill your specific business needs. It does so by examining the number of vCPUs, memory size, instance family level, and maximum budgeted expense that you specify within the scaling configuration settings.
         *
         * @param request DescribePatternTypesRequest
         * @return DescribePatternTypesResponse
         */
        public DescribePatternTypesResponse DescribePatternTypes(DescribePatternTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePatternTypesWithOptions(request, runtime);
        }

        /**
         * @summary Filters instance types that meet your business requirements. If you create a scaling configuration by opting for the Specify Instance Type approach, you can call the DescribePatternTypes operation. This operation is designed to sift through and identify instance types that fulfill your specific business needs. It does so by examining the number of vCPUs, memory size, instance family level, and maximum budgeted expense that you specify within the scaling configuration settings.
         *
         * @param request DescribePatternTypesRequest
         * @return DescribePatternTypesResponse
         */
        public async Task<DescribePatternTypesResponse> DescribePatternTypesAsync(DescribePatternTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePatternTypesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries regions. Before you activate Auto Scaling, you can call the DescribeRegions operation to query the regions where Auto Scaling is officially launched. This preliminary step facilitates the strategic selection of both the optimal region and availability zones for activating Auto Scaling, thereby guaranteeing the finest access speeds and operational efficiency within your chosen geographical area.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-02-22",
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
         * @summary Queries regions. Before you activate Auto Scaling, you can call the DescribeRegions operation to query the regions where Auto Scaling is officially launched. This preliminary step facilitates the strategic selection of both the optimal region and availability zones for activating Auto Scaling, thereby guaranteeing the finest access speeds and operational efficiency within your chosen geographical area.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-02-22",
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
         * @summary Queries regions. Before you activate Auto Scaling, you can call the DescribeRegions operation to query the regions where Auto Scaling is officially launched. This preliminary step facilitates the strategic selection of both the optimal region and availability zones for activating Auto Scaling, thereby guaranteeing the finest access speeds and operational efficiency within your chosen geographical area.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries regions. Before you activate Auto Scaling, you can call the DescribeRegions operation to query the regions where Auto Scaling is officially launched. This preliminary step facilitates the strategic selection of both the optimal region and availability zones for activating Auto Scaling, thereby guaranteeing the finest access speeds and operational efficiency within your chosen geographical area.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scaling activities.
         *
         * @description You can specify a scaling group ID to query all scaling activities in the scaling group.
         * You can filter query results based on the status of scaling activities.
         * You can query scaling activities that are executed in the previous 30 days.
         *
         * @param request DescribeScalingActivitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivitiesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityIds))
            {
                query["ScalingActivityIds"] = request.ScalingActivityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCode))
            {
                query["StatusCode"] = request.StatusCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivities",
                Version = "2022-02-22",
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
         * @summary Queries scaling activities.
         *
         * @description You can specify a scaling group ID to query all scaling activities in the scaling group.
         * You can filter query results based on the status of scaling activities.
         * You can query scaling activities that are executed in the previous 30 days.
         *
         * @param request DescribeScalingActivitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivitiesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityIds))
            {
                query["ScalingActivityIds"] = request.ScalingActivityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCode))
            {
                query["StatusCode"] = request.StatusCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingActivities",
                Version = "2022-02-22",
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
         * @summary Queries scaling activities.
         *
         * @description You can specify a scaling group ID to query all scaling activities in the scaling group.
         * You can filter query results based on the status of scaling activities.
         * You can query scaling activities that are executed in the previous 30 days.
         *
         * @param request DescribeScalingActivitiesRequest
         * @return DescribeScalingActivitiesResponse
         */
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivitiesWithOptions(request, runtime);
        }

        /**
         * @summary Queries scaling activities.
         *
         * @description You can specify a scaling group ID to query all scaling activities in the scaling group.
         * You can filter query results based on the status of scaling activities.
         * You can query scaling activities that are executed in the previous 30 days.
         *
         * @param request DescribeScalingActivitiesRequest
         * @return DescribeScalingActivitiesResponse
         */
        public async Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivitiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a scaling activity.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivityDetailResponse
         */
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
                Version = "2022-02-22",
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
         * @summary Queries the details about a scaling activity.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingActivityDetailResponse
         */
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
                Version = "2022-02-22",
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
         * @summary Queries the details about a scaling activity.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @return DescribeScalingActivityDetailResponse
         */
        public DescribeScalingActivityDetailResponse DescribeScalingActivityDetail(DescribeScalingActivityDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivityDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a scaling activity.
         *
         * @param request DescribeScalingActivityDetailRequest
         * @return DescribeScalingActivityDetailResponse
         */
        public async Task<DescribeScalingActivityDetailResponse> DescribeScalingActivityDetailAsync(DescribeScalingActivityDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivityDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scaling configurations.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingConfigurationsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationIds))
            {
                query["ScalingConfigurationIds"] = request.ScalingConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationNames))
            {
                query["ScalingConfigurationNames"] = request.ScalingConfigurationNames;
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
                Action = "DescribeScalingConfigurations",
                Version = "2022-02-22",
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
         * @summary Queries scaling configurations.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingConfigurationsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationIds))
            {
                query["ScalingConfigurationIds"] = request.ScalingConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationNames))
            {
                query["ScalingConfigurationNames"] = request.ScalingConfigurationNames;
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
                Action = "DescribeScalingConfigurations",
                Version = "2022-02-22",
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
         * @summary Queries scaling configurations.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @return DescribeScalingConfigurationsResponse
         */
        public DescribeScalingConfigurationsResponse DescribeScalingConfigurations(DescribeScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingConfigurationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries scaling configurations.
         *
         * @param request DescribeScalingConfigurationsRequest
         * @return DescribeScalingConfigurationsResponse
         */
        public async Task<DescribeScalingConfigurationsResponse> DescribeScalingConfigurationsAsync(DescribeScalingConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingConfigurationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a scaling group. You can call the DescribeScalingGroupDetail operation to query the basic information, instances, and scaling configurations of a scaling group. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeScalingGroupDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingGroupDetailResponse
         */
        public DescribeScalingGroupDetailResponse DescribeScalingGroupDetailWithOptions(DescribeScalingGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                query["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeScalingGroupDetail",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a scaling group. You can call the DescribeScalingGroupDetail operation to query the basic information, instances, and scaling configurations of a scaling group. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeScalingGroupDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingGroupDetailResponse
         */
        public async Task<DescribeScalingGroupDetailResponse> DescribeScalingGroupDetailWithOptionsAsync(DescribeScalingGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                query["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeScalingGroupDetail",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScalingGroupDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a scaling group. You can call the DescribeScalingGroupDetail operation to query the basic information, instances, and scaling configurations of a scaling group. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeScalingGroupDetailRequest
         * @return DescribeScalingGroupDetailResponse
         */
        public DescribeScalingGroupDetailResponse DescribeScalingGroupDetail(DescribeScalingGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries a scaling group. You can call the DescribeScalingGroupDetail operation to query the basic information, instances, and scaling configurations of a scaling group. If you set OutputFormat to yaml, the output is a Kubernetes Deployment file in the YAML format.
         *
         * @param request DescribeScalingGroupDetailRequest
         * @return DescribeScalingGroupDetailResponse
         */
        public async Task<DescribeScalingGroupDetailResponse> DescribeScalingGroupDetailAsync(DescribeScalingGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scaling groups. If you want to query the basic information, instances, and scaling configurations of a scaling group, you can call the DescribeScalingGroups operation.
         *
         * @param request DescribeScalingGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingGroupsResponse
         */
        public DescribeScalingGroupsResponse DescribeScalingGroupsWithOptions(DescribeScalingGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupIds))
            {
                query["ScalingGroupIds"] = request.ScalingGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupNames))
            {
                query["ScalingGroupNames"] = request.ScalingGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroups",
                Version = "2022-02-22",
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
         * @summary Queries scaling groups. If you want to query the basic information, instances, and scaling configurations of a scaling group, you can call the DescribeScalingGroups operation.
         *
         * @param request DescribeScalingGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingGroupsResponse
         */
        public async Task<DescribeScalingGroupsResponse> DescribeScalingGroupsWithOptionsAsync(DescribeScalingGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupIds))
            {
                query["ScalingGroupIds"] = request.ScalingGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupNames))
            {
                query["ScalingGroupNames"] = request.ScalingGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingGroups",
                Version = "2022-02-22",
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
         * @summary Queries scaling groups. If you want to query the basic information, instances, and scaling configurations of a scaling group, you can call the DescribeScalingGroups operation.
         *
         * @param request DescribeScalingGroupsRequest
         * @return DescribeScalingGroupsResponse
         */
        public DescribeScalingGroupsResponse DescribeScalingGroups(DescribeScalingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries scaling groups. If you want to query the basic information, instances, and scaling configurations of a scaling group, you can call the DescribeScalingGroups operation.
         *
         * @param request DescribeScalingGroupsRequest
         * @return DescribeScalingGroupsResponse
         */
        public async Task<DescribeScalingGroupsResponse> DescribeScalingGroupsAsync(DescribeScalingGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Elastic Compute Service (ECS) instances in a scaling group
         *
         * @param request DescribeScalingInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingInstancesResponse
         */
        public DescribeScalingInstancesResponse DescribeScalingInstancesWithOptions(DescribeScalingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationType))
            {
                query["CreationType"] = request.CreationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationTypes))
            {
                query["CreationTypes"] = request.CreationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["HealthStatus"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleState))
            {
                query["LifecycleState"] = request.LifecycleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleStates))
            {
                query["LifecycleStates"] = request.LifecycleStates;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
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
                Action = "DescribeScalingInstances",
                Version = "2022-02-22",
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
         * @summary Queries the Elastic Compute Service (ECS) instances in a scaling group
         *
         * @param request DescribeScalingInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingInstancesResponse
         */
        public async Task<DescribeScalingInstancesResponse> DescribeScalingInstancesWithOptionsAsync(DescribeScalingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationType))
            {
                query["CreationType"] = request.CreationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationTypes))
            {
                query["CreationTypes"] = request.CreationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["HealthStatus"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleState))
            {
                query["LifecycleState"] = request.LifecycleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleStates))
            {
                query["LifecycleStates"] = request.LifecycleStates;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
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
                Action = "DescribeScalingInstances",
                Version = "2022-02-22",
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
         * @summary Queries the Elastic Compute Service (ECS) instances in a scaling group
         *
         * @param request DescribeScalingInstancesRequest
         * @return DescribeScalingInstancesResponse
         */
        public DescribeScalingInstancesResponse DescribeScalingInstances(DescribeScalingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Elastic Compute Service (ECS) instances in a scaling group
         *
         * @param request DescribeScalingInstancesRequest
         * @return DescribeScalingInstancesResponse
         */
        public async Task<DescribeScalingInstancesResponse> DescribeScalingInstancesAsync(DescribeScalingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all scaling rules in a scaling group.
         *
         * @description You can specify a scaling group ID to query all scaling rules in the scaling group. You can also specify the scaling rule ID, name, unique identifier, and type in the request parameters as filter conditions.
         *
         * @param request DescribeScalingRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingRulesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleAris))
            {
                query["ScalingRuleAris"] = request.ScalingRuleAris;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleIds))
            {
                query["ScalingRuleIds"] = request.ScalingRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleNames))
            {
                query["ScalingRuleNames"] = request.ScalingRuleNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAlarmRules))
            {
                query["ShowAlarmRules"] = request.ShowAlarmRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingRules",
                Version = "2022-02-22",
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
         * @summary Queries all scaling rules in a scaling group.
         *
         * @description You can specify a scaling group ID to query all scaling rules in the scaling group. You can also specify the scaling rule ID, name, unique identifier, and type in the request parameters as filter conditions.
         *
         * @param request DescribeScalingRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScalingRulesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleAris))
            {
                query["ScalingRuleAris"] = request.ScalingRuleAris;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleIds))
            {
                query["ScalingRuleIds"] = request.ScalingRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleNames))
            {
                query["ScalingRuleNames"] = request.ScalingRuleNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAlarmRules))
            {
                query["ShowAlarmRules"] = request.ShowAlarmRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScalingRules",
                Version = "2022-02-22",
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
         * @summary Queries all scaling rules in a scaling group.
         *
         * @description You can specify a scaling group ID to query all scaling rules in the scaling group. You can also specify the scaling rule ID, name, unique identifier, and type in the request parameters as filter conditions.
         *
         * @param request DescribeScalingRulesRequest
         * @return DescribeScalingRulesResponse
         */
        public DescribeScalingRulesResponse DescribeScalingRules(DescribeScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingRulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries all scaling rules in a scaling group.
         *
         * @description You can specify a scaling group ID to query all scaling rules in the scaling group. You can also specify the scaling rule ID, name, unique identifier, and type in the request parameters as filter conditions.
         *
         * @param request DescribeScalingRulesRequest
         * @return DescribeScalingRulesResponse
         */
        public async Task<DescribeScalingRulesResponse> DescribeScalingRulesAsync(DescribeScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scheduled tasks.
         *
         * @description You can query scheduled tasks by scaling rule, task ID, or task name.
         *
         * @param request DescribeScheduledTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScheduledTasksResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledActions))
            {
                query["ScheduledActions"] = request.ScheduledActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskIds))
            {
                query["ScheduledTaskIds"] = request.ScheduledTaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskNames))
            {
                query["ScheduledTaskNames"] = request.ScheduledTaskNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScheduledTasks",
                Version = "2022-02-22",
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
         * @summary Queries scheduled tasks.
         *
         * @description You can query scheduled tasks by scaling rule, task ID, or task name.
         *
         * @param request DescribeScheduledTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeScheduledTasksResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledActions))
            {
                query["ScheduledActions"] = request.ScheduledActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskIds))
            {
                query["ScheduledTaskIds"] = request.ScheduledTaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledTaskNames))
            {
                query["ScheduledTaskNames"] = request.ScheduledTaskNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScheduledTasks",
                Version = "2022-02-22",
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
         * @summary Queries scheduled tasks.
         *
         * @description You can query scheduled tasks by scaling rule, task ID, or task name.
         *
         * @param request DescribeScheduledTasksRequest
         * @return DescribeScheduledTasksResponse
         */
        public DescribeScheduledTasksResponse DescribeScheduledTasks(DescribeScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduledTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries scheduled tasks.
         *
         * @description You can query scheduled tasks by scaling rule, task ID, or task name.
         *
         * @param request DescribeScheduledTasksRequest
         * @return DescribeScheduledTasksResponse
         */
        public async Task<DescribeScheduledTasksResponse> DescribeScheduledTasksAsync(DescribeScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduledTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disassociates one or more Application Load Balancer (ALB) server groups from a scaling group.
         *
         * @param request DetachAlbServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachAlbServerGroupsResponse
         */
        public DetachAlbServerGroupsResponse DetachAlbServerGroupsWithOptions(DetachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbServerGroups))
            {
                query["AlbServerGroups"] = request.AlbServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
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
                Action = "DetachAlbServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAlbServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disassociates one or more Application Load Balancer (ALB) server groups from a scaling group.
         *
         * @param request DetachAlbServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachAlbServerGroupsResponse
         */
        public async Task<DetachAlbServerGroupsResponse> DetachAlbServerGroupsWithOptionsAsync(DetachAlbServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbServerGroups))
            {
                query["AlbServerGroups"] = request.AlbServerGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
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
                Action = "DetachAlbServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAlbServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disassociates one or more Application Load Balancer (ALB) server groups from a scaling group.
         *
         * @param request DetachAlbServerGroupsRequest
         * @return DetachAlbServerGroupsResponse
         */
        public DetachAlbServerGroupsResponse DetachAlbServerGroups(DetachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAlbServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Disassociates one or more Application Load Balancer (ALB) server groups from a scaling group.
         *
         * @param request DetachAlbServerGroupsRequest
         * @return DetachAlbServerGroupsResponse
         */
        public async Task<DetachAlbServerGroupsResponse> DetachAlbServerGroupsAsync(DetachAlbServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAlbServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disassociates one or more ApsaraDB RDS instances from a scaling group.
         *
         * @param request DetachDBInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachDBInstancesResponse
         */
        public DetachDBInstancesResponse DetachDBInstancesWithOptions(DetachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveSecurityGroup))
            {
                query["RemoveSecurityGroup"] = request.RemoveSecurityGroup;
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
                Action = "DetachDBInstances",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachDBInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disassociates one or more ApsaraDB RDS instances from a scaling group.
         *
         * @param request DetachDBInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachDBInstancesResponse
         */
        public async Task<DetachDBInstancesResponse> DetachDBInstancesWithOptionsAsync(DetachDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveSecurityGroup))
            {
                query["RemoveSecurityGroup"] = request.RemoveSecurityGroup;
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
                Action = "DetachDBInstances",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachDBInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disassociates one or more ApsaraDB RDS instances from a scaling group.
         *
         * @param request DetachDBInstancesRequest
         * @return DetachDBInstancesResponse
         */
        public DetachDBInstancesResponse DetachDBInstances(DetachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDBInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Disassociates one or more ApsaraDB RDS instances from a scaling group.
         *
         * @param request DetachDBInstancesRequest
         * @return DetachDBInstancesResponse
         */
        public async Task<DetachDBInstancesResponse> DetachDBInstancesAsync(DetachDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDBInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description After ECS instances or elastic container instances are removed from a scaling group, you can call the AttachInstances operation to add the ECS instances or elastic container instances that are removed from the scaling group to other scaling groups.
         * After you remove an ECS instance or elastic container instance by calling the DetachInstances operation, the instance is not stopped or released.
         * Before you call this operation, make sure that the following conditions are met:
         * *   The specified scaling group is enabled.
         * *   No scaling activities in the specified scaling group are in progress.
         * > If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates only that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         * The number of ECS instances or elastic container instances in a scaling group after you remove a specific number of instances from the scaling group must be equal to or greater than the value of the MinSize parameter. Otherwise, an error is reported when you call the DetachInstances operation.
         *
         * @param request DetachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachInstancesResponse
         */
        public DetachInstancesResponse DetachInstancesWithOptions(DetachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecreaseDesiredCapacity))
            {
                query["DecreaseDesiredCapacity"] = request.DecreaseDesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetachOption))
            {
                query["DetachOption"] = request.DetachOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreInvalidInstance))
            {
                query["IgnoreInvalidInstance"] = request.IgnoreInvalidInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHook))
            {
                query["LifecycleHook"] = request.LifecycleHook;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachInstances",
                Version = "2022-02-22",
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
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description After ECS instances or elastic container instances are removed from a scaling group, you can call the AttachInstances operation to add the ECS instances or elastic container instances that are removed from the scaling group to other scaling groups.
         * After you remove an ECS instance or elastic container instance by calling the DetachInstances operation, the instance is not stopped or released.
         * Before you call this operation, make sure that the following conditions are met:
         * *   The specified scaling group is enabled.
         * *   No scaling activities in the specified scaling group are in progress.
         * > If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates only that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         * The number of ECS instances or elastic container instances in a scaling group after you remove a specific number of instances from the scaling group must be equal to or greater than the value of the MinSize parameter. Otherwise, an error is reported when you call the DetachInstances operation.
         *
         * @param request DetachInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachInstancesResponse
         */
        public async Task<DetachInstancesResponse> DetachInstancesWithOptionsAsync(DetachInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecreaseDesiredCapacity))
            {
                query["DecreaseDesiredCapacity"] = request.DecreaseDesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetachOption))
            {
                query["DetachOption"] = request.DetachOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreInvalidInstance))
            {
                query["IgnoreInvalidInstance"] = request.IgnoreInvalidInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHook))
            {
                query["LifecycleHook"] = request.LifecycleHook;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachInstances",
                Version = "2022-02-22",
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
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description After ECS instances or elastic container instances are removed from a scaling group, you can call the AttachInstances operation to add the ECS instances or elastic container instances that are removed from the scaling group to other scaling groups.
         * After you remove an ECS instance or elastic container instance by calling the DetachInstances operation, the instance is not stopped or released.
         * Before you call this operation, make sure that the following conditions are met:
         * *   The specified scaling group is enabled.
         * *   No scaling activities in the specified scaling group are in progress.
         * > If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates only that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         * The number of ECS instances or elastic container instances in a scaling group after you remove a specific number of instances from the scaling group must be equal to or greater than the value of the MinSize parameter. Otherwise, an error is reported when you call the DetachInstances operation.
         *
         * @param request DetachInstancesRequest
         * @return DetachInstancesResponse
         */
        public DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description After ECS instances or elastic container instances are removed from a scaling group, you can call the AttachInstances operation to add the ECS instances or elastic container instances that are removed from the scaling group to other scaling groups.
         * After you remove an ECS instance or elastic container instance by calling the DetachInstances operation, the instance is not stopped or released.
         * Before you call this operation, make sure that the following conditions are met:
         * *   The specified scaling group is enabled.
         * *   No scaling activities in the specified scaling group are in progress.
         * > If no scaling activities in the specified scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates only that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         * The number of ECS instances or elastic container instances in a scaling group after you remove a specific number of instances from the scaling group must be equal to or greater than the value of the MinSize parameter. Otherwise, an error is reported when you call the DetachInstances operation.
         *
         * @param request DetachInstancesRequest
         * @return DetachInstancesResponse
         */
        public async Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Detaches one or more Classic Load Balancer (CLB) instances from a scaling group.
         *
         * @param request DetachLoadBalancersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachLoadBalancersResponse
         */
        public DetachLoadBalancersResponse DetachLoadBalancersWithOptions(DetachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancers))
            {
                query["LoadBalancers"] = request.LoadBalancers;
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
                Action = "DetachLoadBalancers",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLoadBalancersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detaches one or more Classic Load Balancer (CLB) instances from a scaling group.
         *
         * @param request DetachLoadBalancersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachLoadBalancersResponse
         */
        public async Task<DetachLoadBalancersResponse> DetachLoadBalancersWithOptionsAsync(DetachLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancers))
            {
                query["LoadBalancers"] = request.LoadBalancers;
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
                Action = "DetachLoadBalancers",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLoadBalancersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detaches one or more Classic Load Balancer (CLB) instances from a scaling group.
         *
         * @param request DetachLoadBalancersRequest
         * @return DetachLoadBalancersResponse
         */
        public DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachLoadBalancersWithOptions(request, runtime);
        }

        /**
         * @summary Detaches one or more Classic Load Balancer (CLB) instances from a scaling group.
         *
         * @param request DetachLoadBalancersRequest
         * @return DetachLoadBalancersResponse
         */
        public async Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachLoadBalancersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Detach server groups from a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the DetachServerGroups operation. By detaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups from your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request DetachServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachServerGroupsResponse
         */
        public DetachServerGroupsResponse DetachServerGroupsWithOptions(DetachServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroups))
            {
                query["ServerGroups"] = request.ServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detach server groups from a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the DetachServerGroups operation. By detaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups from your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request DetachServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachServerGroupsResponse
         */
        public async Task<DetachServerGroupsResponse> DetachServerGroupsWithOptionsAsync(DetachServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroups))
            {
                query["ServerGroups"] = request.ServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detach server groups from a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the DetachServerGroups operation. By detaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups from your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request DetachServerGroupsRequest
         * @return DetachServerGroupsResponse
         */
        public DetachServerGroupsResponse DetachServerGroups(DetachServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Detach server groups from a scaling group. To seamlessly adjust the number of instances in response to changes in your business workload or to maintain the uninterrupted accessibility of your application, you can call the DetachServerGroups operation. By detaching Application Load Balancer (ALB) or Network Load Balancer (NLB) server groups from your scaling group, this operation enables Auto Scaling to automatically tailor your computing capacity to your business needs. Furthermore, it optimizes traffic routing by dynamically allocating incoming requests based on current workload patterns, which significantly improves the stability and performance of your application.
         *
         * @param request DetachServerGroupsRequest
         * @return DetachServerGroupsResponse
         */
        public async Task<DetachServerGroupsResponse> DetachServerGroupsAsync(DetachServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Detaches vServer groups from a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups to improve service performance. If the load balancer currently attached to your scaling group is no longer needed to distribute the access traffic to the instances in your scaling group, you can call the DetachVServerGroups operation to detach one or more vServer groups of this load balancer from the scaling group.
         *
         * @description *   When you call the DetachVServerGroups operation, you must use the following parameters to specify the vServer groups that you want to detach from your scaling group:
         *     *   LoadBalancerId: the ID of the load balancer
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         * *   When the vServer group specified by the request parameters matches that attached to your scaling group, this operation yields a favorable result. Otherwise, the request is ignored and no error is reported.
         * *   Before you call this operation, you must make sure that the load balancer has ceased routing the access traffic to the instances in the scaling group. Failure to do so may lead to service requests being dropped or lost during the detachment process.
         *
         * @param request DetachVServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachVServerGroupsResponse
         */
        public DetachVServerGroupsResponse DetachVServerGroupsWithOptions(DetachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroups))
            {
                query["VServerGroups"] = request.VServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detaches vServer groups from a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups to improve service performance. If the load balancer currently attached to your scaling group is no longer needed to distribute the access traffic to the instances in your scaling group, you can call the DetachVServerGroups operation to detach one or more vServer groups of this load balancer from the scaling group.
         *
         * @description *   When you call the DetachVServerGroups operation, you must use the following parameters to specify the vServer groups that you want to detach from your scaling group:
         *     *   LoadBalancerId: the ID of the load balancer
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         * *   When the vServer group specified by the request parameters matches that attached to your scaling group, this operation yields a favorable result. Otherwise, the request is ignored and no error is reported.
         * *   Before you call this operation, you must make sure that the load balancer has ceased routing the access traffic to the instances in the scaling group. Failure to do so may lead to service requests being dropped or lost during the detachment process.
         *
         * @param request DetachVServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachVServerGroupsResponse
         */
        public async Task<DetachVServerGroupsResponse> DetachVServerGroupsWithOptionsAsync(DetachVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDetach))
            {
                query["ForceDetach"] = request.ForceDetach;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroups))
            {
                query["VServerGroups"] = request.VServerGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVServerGroups",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detaches vServer groups from a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups to improve service performance. If the load balancer currently attached to your scaling group is no longer needed to distribute the access traffic to the instances in your scaling group, you can call the DetachVServerGroups operation to detach one or more vServer groups of this load balancer from the scaling group.
         *
         * @description *   When you call the DetachVServerGroups operation, you must use the following parameters to specify the vServer groups that you want to detach from your scaling group:
         *     *   LoadBalancerId: the ID of the load balancer
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         * *   When the vServer group specified by the request parameters matches that attached to your scaling group, this operation yields a favorable result. Otherwise, the request is ignored and no error is reported.
         * *   Before you call this operation, you must make sure that the load balancer has ceased routing the access traffic to the instances in the scaling group. Failure to do so may lead to service requests being dropped or lost during the detachment process.
         *
         * @param request DetachVServerGroupsRequest
         * @return DetachVServerGroupsResponse
         */
        public DetachVServerGroupsResponse DetachVServerGroups(DetachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachVServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Detaches vServer groups from a scaling group. Auto Scaling supports the attachment of load balancers to scaling groups to improve service performance. If the load balancer currently attached to your scaling group is no longer needed to distribute the access traffic to the instances in your scaling group, you can call the DetachVServerGroups operation to detach one or more vServer groups of this load balancer from the scaling group.
         *
         * @description *   When you call the DetachVServerGroups operation, you must use the following parameters to specify the vServer groups that you want to detach from your scaling group:
         *     *   LoadBalancerId: the ID of the load balancer
         *     *   VServerGroupId: the ID of the vServer group
         *     *   Port: the port number of the vServer group
         * *   When the vServer group specified by the request parameters matches that attached to your scaling group, this operation yields a favorable result. Otherwise, the request is ignored and no error is reported.
         * *   Before you call this operation, you must make sure that the load balancer has ceased routing the access traffic to the instances in the scaling group. Failure to do so may lead to service requests being dropped or lost during the detachment process.
         *
         * @param request DetachVServerGroupsRequest
         * @return DetachVServerGroupsResponse
         */
        public async Task<DetachVServerGroupsResponse> DetachVServerGroupsAsync(DetachVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachVServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you currently do not need an event-triggered task, you can call the DisableAlarm operation to disable it.
         *
         * @description Before you disable an event-triggered task, make sure that the task is in the `Normal`, `Alert`, or `Insufficient Data` state.
         *
         * @param request DisableAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAlarmResponse
         */
        public DisableAlarmResponse DisableAlarmWithOptions(DisableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you currently do not need an event-triggered task, you can call the DisableAlarm operation to disable it.
         *
         * @description Before you disable an event-triggered task, make sure that the task is in the `Normal`, `Alert`, or `Insufficient Data` state.
         *
         * @param request DisableAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAlarmResponse
         */
        public async Task<DisableAlarmResponse> DisableAlarmWithOptionsAsync(DisableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you currently do not need an event-triggered task, you can call the DisableAlarm operation to disable it.
         *
         * @description Before you disable an event-triggered task, make sure that the task is in the `Normal`, `Alert`, or `Insufficient Data` state.
         *
         * @param request DisableAlarmRequest
         * @return DisableAlarmResponse
         */
        public DisableAlarmResponse DisableAlarm(DisableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Disables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you currently do not need an event-triggered task, you can call the DisableAlarm operation to disable it.
         *
         * @description Before you disable an event-triggered task, make sure that the task is in the `Normal`, `Alert`, or `Insufficient Data` state.
         *
         * @param request DisableAlarmRequest
         * @return DisableAlarmResponse
         */
        public async Task<DisableAlarmResponse> DisableAlarmAsync(DisableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a scaling group. If you temporarily do not require a scaling group that is in the Enabled state, you can call the DisableScalingGroup operation to disable it.
         *
         * @description Before you call this operation to disable a scaling group, take note of the following items:
         * *   If scaling activities are being executed in the specified scaling group when you call this operation, these activities will continue until they are complete. However, scaling activities that are triggered after this operation is called will be rejected.
         * *   This operation can be called only when the scaling group is in the Active state.
         *
         * @param request DisableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableScalingGroupResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2022-02-22",
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
         * @summary Disables a scaling group. If you temporarily do not require a scaling group that is in the Enabled state, you can call the DisableScalingGroup operation to disable it.
         *
         * @description Before you call this operation to disable a scaling group, take note of the following items:
         * *   If scaling activities are being executed in the specified scaling group when you call this operation, these activities will continue until they are complete. However, scaling activities that are triggered after this operation is called will be rejected.
         * *   This operation can be called only when the scaling group is in the Active state.
         *
         * @param request DisableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableScalingGroupResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2022-02-22",
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
         * @summary Disables a scaling group. If you temporarily do not require a scaling group that is in the Enabled state, you can call the DisableScalingGroup operation to disable it.
         *
         * @description Before you call this operation to disable a scaling group, take note of the following items:
         * *   If scaling activities are being executed in the specified scaling group when you call this operation, these activities will continue until they are complete. However, scaling activities that are triggered after this operation is called will be rejected.
         * *   This operation can be called only when the scaling group is in the Active state.
         *
         * @param request DisableScalingGroupRequest
         * @return DisableScalingGroupResponse
         */
        public DisableScalingGroupResponse DisableScalingGroup(DisableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableScalingGroupWithOptions(request, runtime);
        }

        /**
         * @summary Disables a scaling group. If you temporarily do not require a scaling group that is in the Enabled state, you can call the DisableScalingGroup operation to disable it.
         *
         * @description Before you call this operation to disable a scaling group, take note of the following items:
         * *   If scaling activities are being executed in the specified scaling group when you call this operation, these activities will continue until they are complete. However, scaling activities that are triggered after this operation is called will be rejected.
         * *   This operation can be called only when the scaling group is in the Active state.
         *
         * @param request DisableScalingGroupRequest
         * @return DisableScalingGroupResponse
         */
        public async Task<DisableScalingGroupResponse> DisableScalingGroupAsync(DisableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you want to reuse an event-triggered task that is in the Disabled state, you can call the EnableAlarm operation to enable it.
         *
         * @param request EnableAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAlarmResponse
         */
        public EnableAlarmResponse EnableAlarmWithOptions(EnableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you want to reuse an event-triggered task that is in the Disabled state, you can call the EnableAlarm operation to enable it.
         *
         * @param request EnableAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAlarmResponse
         */
        public async Task<EnableAlarmResponse> EnableAlarmWithOptionsAsync(EnableAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you want to reuse an event-triggered task that is in the Disabled state, you can call the EnableAlarm operation to enable it.
         *
         * @param request EnableAlarmRequest
         * @return EnableAlarmResponse
         */
        public EnableAlarmResponse EnableAlarm(EnableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Enables an event-triggered task. If your business pattern is unpredictable or prone to unforeseen traffic spikes, you can create event-triggered tasks by associating CloudMonitor metrics to effectively monitor fluctuations in your business workload. Upon detecting that the criteria for alerts, as specified in event-triggered tasks, are fulfilled, Auto Scaling promptly issues alerts and executes the scaling rules predefined within those tasks. This process occurs within the predefined effective time windows of the tasks, thereby facilitating the automatic increase or decrease of Elastic Compute Service (ECS) instances or elastic container instances within your scaling groups. Ultimately, this mechanism ensures the dynamic optimization of resources based on real-time workload demands. If you want to reuse an event-triggered task that is in the Disabled state, you can call the EnableAlarm operation to enable it.
         *
         * @param request EnableAlarmRequest
         * @return EnableAlarmResponse
         */
        public async Task<EnableAlarmResponse> EnableAlarmAsync(EnableAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a scaling group. If a scaling group is in the Disabled state and contains an instance configuration source such as a launch template or a scaling configuration, you can call the EnableScalingGroup operation to enable the scaling group. This operation permits Auto Scaling to dynamically adjust the computing power (also known as the number of instances) in the scaling group based on your business requirements.
         *
         * @description *   You can call this operation to enable a scaling group only if the scaling group is in the Inactive state and contains an instance configuration source such as a launch temple or a scaling configuration. The instance configuration source can also be the Elastic Compute Service (ECS) instance that you specified when you created the scaling group. If the preceding requirements are not met, the operation will fail.
         *     **
         *     **Note** A scaling group can have only one active instance configuration source at a time. When you call this operation to enable a scaling group, you can specify a scaling configuration or a launch template for the scaling group. If the scaling group already have an instance configuration source defined prior to your calling, the scaling configuration or launch template specified within your request will supersede the existing scaling configuration or launch template.
         * *   If you specify InstanceId.N to add to the scaling group within your request, Auto Scaling will check whether the addition of InstanceId.N will cause the total number of ECS instances in the scaling group to fall outside the boundaries specified by MinSize and MaxSize after you call this operation.
         *     *   If the call results in the total number of ECS instances dropping below the value of MinSize, Auto Scaling proactively creates pay-as-you-go ECS instances to ensure that the total number reaches the minimum threshold. For example, if you set MinSize to 5 when you created a scaling group and include InstanceId.N within your request to add two ECS instances when you attempt to enable the scaling group, Auto Scaling creates three more ECS instances in the scaling group after the two ECS instances are added.
         *     *   If the call results in the total number of ECS instances exceeding the value of MaxSize, the operation fails.
         *
         * @param request EnableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableScalingGroupResponse
         */
        public EnableScalingGroupResponse EnableScalingGroupWithOptions(EnableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateId))
            {
                query["LaunchTemplateId"] = request.LaunchTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateOverrides))
            {
                query["LaunchTemplateOverrides"] = request.LaunchTemplateOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateVersion))
            {
                query["LaunchTemplateVersion"] = request.LaunchTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeights))
            {
                query["LoadBalancerWeights"] = request.LoadBalancerWeights;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "EnableScalingGroup",
                Version = "2022-02-22",
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
         * @summary Enables a scaling group. If a scaling group is in the Disabled state and contains an instance configuration source such as a launch template or a scaling configuration, you can call the EnableScalingGroup operation to enable the scaling group. This operation permits Auto Scaling to dynamically adjust the computing power (also known as the number of instances) in the scaling group based on your business requirements.
         *
         * @description *   You can call this operation to enable a scaling group only if the scaling group is in the Inactive state and contains an instance configuration source such as a launch temple or a scaling configuration. The instance configuration source can also be the Elastic Compute Service (ECS) instance that you specified when you created the scaling group. If the preceding requirements are not met, the operation will fail.
         *     **
         *     **Note** A scaling group can have only one active instance configuration source at a time. When you call this operation to enable a scaling group, you can specify a scaling configuration or a launch template for the scaling group. If the scaling group already have an instance configuration source defined prior to your calling, the scaling configuration or launch template specified within your request will supersede the existing scaling configuration or launch template.
         * *   If you specify InstanceId.N to add to the scaling group within your request, Auto Scaling will check whether the addition of InstanceId.N will cause the total number of ECS instances in the scaling group to fall outside the boundaries specified by MinSize and MaxSize after you call this operation.
         *     *   If the call results in the total number of ECS instances dropping below the value of MinSize, Auto Scaling proactively creates pay-as-you-go ECS instances to ensure that the total number reaches the minimum threshold. For example, if you set MinSize to 5 when you created a scaling group and include InstanceId.N within your request to add two ECS instances when you attempt to enable the scaling group, Auto Scaling creates three more ECS instances in the scaling group after the two ECS instances are added.
         *     *   If the call results in the total number of ECS instances exceeding the value of MaxSize, the operation fails.
         *
         * @param request EnableScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableScalingGroupResponse
         */
        public async Task<EnableScalingGroupResponse> EnableScalingGroupWithOptionsAsync(EnableScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateId))
            {
                query["LaunchTemplateId"] = request.LaunchTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateOverrides))
            {
                query["LaunchTemplateOverrides"] = request.LaunchTemplateOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateVersion))
            {
                query["LaunchTemplateVersion"] = request.LaunchTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeights))
            {
                query["LoadBalancerWeights"] = request.LoadBalancerWeights;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "EnableScalingGroup",
                Version = "2022-02-22",
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
         * @summary Enables a scaling group. If a scaling group is in the Disabled state and contains an instance configuration source such as a launch template or a scaling configuration, you can call the EnableScalingGroup operation to enable the scaling group. This operation permits Auto Scaling to dynamically adjust the computing power (also known as the number of instances) in the scaling group based on your business requirements.
         *
         * @description *   You can call this operation to enable a scaling group only if the scaling group is in the Inactive state and contains an instance configuration source such as a launch temple or a scaling configuration. The instance configuration source can also be the Elastic Compute Service (ECS) instance that you specified when you created the scaling group. If the preceding requirements are not met, the operation will fail.
         *     **
         *     **Note** A scaling group can have only one active instance configuration source at a time. When you call this operation to enable a scaling group, you can specify a scaling configuration or a launch template for the scaling group. If the scaling group already have an instance configuration source defined prior to your calling, the scaling configuration or launch template specified within your request will supersede the existing scaling configuration or launch template.
         * *   If you specify InstanceId.N to add to the scaling group within your request, Auto Scaling will check whether the addition of InstanceId.N will cause the total number of ECS instances in the scaling group to fall outside the boundaries specified by MinSize and MaxSize after you call this operation.
         *     *   If the call results in the total number of ECS instances dropping below the value of MinSize, Auto Scaling proactively creates pay-as-you-go ECS instances to ensure that the total number reaches the minimum threshold. For example, if you set MinSize to 5 when you created a scaling group and include InstanceId.N within your request to add two ECS instances when you attempt to enable the scaling group, Auto Scaling creates three more ECS instances in the scaling group after the two ECS instances are added.
         *     *   If the call results in the total number of ECS instances exceeding the value of MaxSize, the operation fails.
         *
         * @param request EnableScalingGroupRequest
         * @return EnableScalingGroupResponse
         */
        public EnableScalingGroupResponse EnableScalingGroup(EnableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableScalingGroupWithOptions(request, runtime);
        }

        /**
         * @summary Enables a scaling group. If a scaling group is in the Disabled state and contains an instance configuration source such as a launch template or a scaling configuration, you can call the EnableScalingGroup operation to enable the scaling group. This operation permits Auto Scaling to dynamically adjust the computing power (also known as the number of instances) in the scaling group based on your business requirements.
         *
         * @description *   You can call this operation to enable a scaling group only if the scaling group is in the Inactive state and contains an instance configuration source such as a launch temple or a scaling configuration. The instance configuration source can also be the Elastic Compute Service (ECS) instance that you specified when you created the scaling group. If the preceding requirements are not met, the operation will fail.
         *     **
         *     **Note** A scaling group can have only one active instance configuration source at a time. When you call this operation to enable a scaling group, you can specify a scaling configuration or a launch template for the scaling group. If the scaling group already have an instance configuration source defined prior to your calling, the scaling configuration or launch template specified within your request will supersede the existing scaling configuration or launch template.
         * *   If you specify InstanceId.N to add to the scaling group within your request, Auto Scaling will check whether the addition of InstanceId.N will cause the total number of ECS instances in the scaling group to fall outside the boundaries specified by MinSize and MaxSize after you call this operation.
         *     *   If the call results in the total number of ECS instances dropping below the value of MinSize, Auto Scaling proactively creates pay-as-you-go ECS instances to ensure that the total number reaches the minimum threshold. For example, if you set MinSize to 5 when you created a scaling group and include InstanceId.N within your request to add two ECS instances when you attempt to enable the scaling group, Auto Scaling creates three more ECS instances in the scaling group after the two ECS instances are added.
         *     *   If the call results in the total number of ECS instances exceeding the value of MaxSize, the operation fails.
         *
         * @param request EnableScalingGroupRequest
         * @return EnableScalingGroupResponse
         */
        public async Task<EnableScalingGroupResponse> EnableScalingGroupAsync(EnableScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Puts an Elastic Compute Service (ECS) instance into the Standby state.
         *
         * @description ## Description
         * *   If you call the operation to put an ECS instance in a scaling group that is associated with a Classic Load Balancer (CLB) instance into the Standby state, the weight of the ECS instance as a backend server of the CLB instance is set to 0.
         * *   You can remove an instance that is in the Standby state from a scaling group, and then release the instance.
         * *   ECS instances that are in the Standby state are not removed from the scaling group during scale-in activities triggered by event-triggered tasks.
         * *   If Auto Scaling considers an ECS instance that is in the Standby state unhealthy, for example, the ECS instance is being stopped or being restarted, Auto Scaling does not update the health status of the ECS instance or trigger scale-in activities to remove the ECS instance from the scaling group. Auto Scaling updates the health status of the ECS instance only when the ECS instance is no longer in the Standby state.
         *
         * @param request EnterStandbyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnterStandbyResponse
         */
        public EnterStandbyResponse EnterStandbyWithOptions(EnterStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "EnterStandby",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterStandbyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Puts an Elastic Compute Service (ECS) instance into the Standby state.
         *
         * @description ## Description
         * *   If you call the operation to put an ECS instance in a scaling group that is associated with a Classic Load Balancer (CLB) instance into the Standby state, the weight of the ECS instance as a backend server of the CLB instance is set to 0.
         * *   You can remove an instance that is in the Standby state from a scaling group, and then release the instance.
         * *   ECS instances that are in the Standby state are not removed from the scaling group during scale-in activities triggered by event-triggered tasks.
         * *   If Auto Scaling considers an ECS instance that is in the Standby state unhealthy, for example, the ECS instance is being stopped or being restarted, Auto Scaling does not update the health status of the ECS instance or trigger scale-in activities to remove the ECS instance from the scaling group. Auto Scaling updates the health status of the ECS instance only when the ECS instance is no longer in the Standby state.
         *
         * @param request EnterStandbyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnterStandbyResponse
         */
        public async Task<EnterStandbyResponse> EnterStandbyWithOptionsAsync(EnterStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "EnterStandby",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterStandbyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Puts an Elastic Compute Service (ECS) instance into the Standby state.
         *
         * @description ## Description
         * *   If you call the operation to put an ECS instance in a scaling group that is associated with a Classic Load Balancer (CLB) instance into the Standby state, the weight of the ECS instance as a backend server of the CLB instance is set to 0.
         * *   You can remove an instance that is in the Standby state from a scaling group, and then release the instance.
         * *   ECS instances that are in the Standby state are not removed from the scaling group during scale-in activities triggered by event-triggered tasks.
         * *   If Auto Scaling considers an ECS instance that is in the Standby state unhealthy, for example, the ECS instance is being stopped or being restarted, Auto Scaling does not update the health status of the ECS instance or trigger scale-in activities to remove the ECS instance from the scaling group. Auto Scaling updates the health status of the ECS instance only when the ECS instance is no longer in the Standby state.
         *
         * @param request EnterStandbyRequest
         * @return EnterStandbyResponse
         */
        public EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterStandbyWithOptions(request, runtime);
        }

        /**
         * @summary Puts an Elastic Compute Service (ECS) instance into the Standby state.
         *
         * @description ## Description
         * *   If you call the operation to put an ECS instance in a scaling group that is associated with a Classic Load Balancer (CLB) instance into the Standby state, the weight of the ECS instance as a backend server of the CLB instance is set to 0.
         * *   You can remove an instance that is in the Standby state from a scaling group, and then release the instance.
         * *   ECS instances that are in the Standby state are not removed from the scaling group during scale-in activities triggered by event-triggered tasks.
         * *   If Auto Scaling considers an ECS instance that is in the Standby state unhealthy, for example, the ECS instance is being stopped or being restarted, Auto Scaling does not update the health status of the ECS instance or trigger scale-in activities to remove the ECS instance from the scaling group. Auto Scaling updates the health status of the ECS instance only when the ECS instance is no longer in the Standby state.
         *
         * @param request EnterStandbyRequest
         * @return EnterStandbyResponse
         */
        public async Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterStandbyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Executes a scaling rule.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the addition of a specified number of Elastic Compute Service (ECS) instances to a scaling group causes the total number of ECS instances in the scaling group to exceed the maximum number of instances allowed, Auto Scaling adds only a specific number of ECS instances to ensure that the total number of instances is equal to the maximum number of instances.
         * If the removal of a specified number of ECS instances from a scaling group causes the total number of ECS instances in the scaling group to drop below the minimum number of instances allowed, Auto Scaling removes only a specific number of ECS instances to ensure that the total number of instances is equal to the minimum number of instances.
         * You can specify only a limited number of ECS instances in each adjustment. For more information, see the description of the AdjustmentValue parameter in the CreateScalingRule topic.
         *
         * @param request ExecuteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteScalingRuleResponse
         */
        public ExecuteScalingRuleResponse ExecuteScalingRuleWithOptions(ExecuteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BreachThreshold))
            {
                query["BreachThreshold"] = request.BreachThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricValue))
            {
                query["MetricValue"] = request.MetricValue;
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
                Version = "2022-02-22",
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
         * @summary Executes a scaling rule.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the addition of a specified number of Elastic Compute Service (ECS) instances to a scaling group causes the total number of ECS instances in the scaling group to exceed the maximum number of instances allowed, Auto Scaling adds only a specific number of ECS instances to ensure that the total number of instances is equal to the maximum number of instances.
         * If the removal of a specified number of ECS instances from a scaling group causes the total number of ECS instances in the scaling group to drop below the minimum number of instances allowed, Auto Scaling removes only a specific number of ECS instances to ensure that the total number of instances is equal to the minimum number of instances.
         * You can specify only a limited number of ECS instances in each adjustment. For more information, see the description of the AdjustmentValue parameter in the CreateScalingRule topic.
         *
         * @param request ExecuteScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteScalingRuleResponse
         */
        public async Task<ExecuteScalingRuleResponse> ExecuteScalingRuleWithOptionsAsync(ExecuteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BreachThreshold))
            {
                query["BreachThreshold"] = request.BreachThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricValue))
            {
                query["MetricValue"] = request.MetricValue;
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
                Version = "2022-02-22",
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
         * @summary Executes a scaling rule.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the addition of a specified number of Elastic Compute Service (ECS) instances to a scaling group causes the total number of ECS instances in the scaling group to exceed the maximum number of instances allowed, Auto Scaling adds only a specific number of ECS instances to ensure that the total number of instances is equal to the maximum number of instances.
         * If the removal of a specified number of ECS instances from a scaling group causes the total number of ECS instances in the scaling group to drop below the minimum number of instances allowed, Auto Scaling removes only a specific number of ECS instances to ensure that the total number of instances is equal to the minimum number of instances.
         * You can specify only a limited number of ECS instances in each adjustment. For more information, see the description of the AdjustmentValue parameter in the CreateScalingRule topic.
         *
         * @param request ExecuteScalingRuleRequest
         * @return ExecuteScalingRuleResponse
         */
        public ExecuteScalingRuleResponse ExecuteScalingRule(ExecuteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary Executes a scaling rule.
         *
         * @description Before you call this operation, take note of the following items:
         * *   The scaling group is in the Active state.
         * *   No scaling activities in the scaling group are in progress.
         * If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities even before the cooldown time expires.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity by using the value of the ScalingActivityId parameter in the response.
         * If the addition of a specified number of Elastic Compute Service (ECS) instances to a scaling group causes the total number of ECS instances in the scaling group to exceed the maximum number of instances allowed, Auto Scaling adds only a specific number of ECS instances to ensure that the total number of instances is equal to the maximum number of instances.
         * If the removal of a specified number of ECS instances from a scaling group causes the total number of ECS instances in the scaling group to drop below the minimum number of instances allowed, Auto Scaling removes only a specific number of ECS instances to ensure that the total number of instances is equal to the minimum number of instances.
         * You can specify only a limited number of ECS instances in each adjustment. For more information, see the description of the AdjustmentValue parameter in the CreateScalingRule topic.
         *
         * @param request ExecuteScalingRuleRequest
         * @return ExecuteScalingRuleResponse
         */
        public async Task<ExecuteScalingRuleResponse> ExecuteScalingRuleAsync(ExecuteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moves an Elastic Compute Service (ECS) instance out of the Standby state.
         *
         * @description ## Description
         * If your scaling group is associated with a Classic Load Balancer (CLB) instance and you move an ECS instance in your scaling group out of the Standby state, the weight of the ECS instance is reset to the value that is specified in the scaling configuration of your scaling group.
         *
         * @param request ExitStandbyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExitStandbyResponse
         */
        public ExitStandbyResponse ExitStandbyWithOptions(ExitStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "ExitStandby",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExitStandbyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Moves an Elastic Compute Service (ECS) instance out of the Standby state.
         *
         * @description ## Description
         * If your scaling group is associated with a Classic Load Balancer (CLB) instance and you move an ECS instance in your scaling group out of the Standby state, the weight of the ECS instance is reset to the value that is specified in the scaling configuration of your scaling group.
         *
         * @param request ExitStandbyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExitStandbyResponse
         */
        public async Task<ExitStandbyResponse> ExitStandbyWithOptionsAsync(ExitStandbyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "ExitStandby",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExitStandbyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Moves an Elastic Compute Service (ECS) instance out of the Standby state.
         *
         * @description ## Description
         * If your scaling group is associated with a Classic Load Balancer (CLB) instance and you move an ECS instance in your scaling group out of the Standby state, the weight of the ECS instance is reset to the value that is specified in the scaling configuration of your scaling group.
         *
         * @param request ExitStandbyRequest
         * @return ExitStandbyResponse
         */
        public ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExitStandbyWithOptions(request, runtime);
        }

        /**
         * @summary Moves an Elastic Compute Service (ECS) instance out of the Standby state.
         *
         * @description ## Description
         * If your scaling group is associated with a Classic Load Balancer (CLB) instance and you move an ECS instance in your scaling group out of the Standby state, the weight of the ECS instance is reset to the value that is specified in the scaling configuration of your scaling group.
         *
         * @param request ExitStandbyRequest
         * @return ExitStandbyResponse
         */
        public async Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExitStandbyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tag keys added to Auto Scaling resources. Querying tag keys facilitates easier classification, identification, and monitoring of your Auto Scaling resources, thereby enhancing the flexibility and convenience of your resource management processes.
         *
         * @param request ListTagKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the tag keys added to Auto Scaling resources. Querying tag keys facilitates easier classification, identification, and monitoring of your Auto Scaling resources, thereby enhancing the flexibility and convenience of your resource management processes.
         *
         * @param request ListTagKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the tag keys added to Auto Scaling resources. Querying tag keys facilitates easier classification, identification, and monitoring of your Auto Scaling resources, thereby enhancing the flexibility and convenience of your resource management processes.
         *
         * @param request ListTagKeysRequest
         * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tag keys added to Auto Scaling resources. Querying tag keys facilitates easier classification, identification, and monitoring of your Auto Scaling resources, thereby enhancing the flexibility and convenience of your resource management processes.
         *
         * @param request ListTagKeysRequest
         * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tags. You can call the ListTagResources operation to query tags that are added to Auto Scaling resources, thereby clarifying resource utilization and facilitating efficient management. This operation aids in the automation of resource categorization and permission management processes.
         *
         * @description *   Specify at least one of the following request parameters: `ResourceIds` and `Tags`. `Tags.Key` and `Tags.Value` are used to specify the query objects.
         * *   If you provide both `ResourceIds` and `Tags` in your request, the response will exclusively include Auto Scaling resources that satisfy the criteria set by these parameters, ensuring targeted and precise information retrieval.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries tags. You can call the ListTagResources operation to query tags that are added to Auto Scaling resources, thereby clarifying resource utilization and facilitating efficient management. This operation aids in the automation of resource categorization and permission management processes.
         *
         * @description *   Specify at least one of the following request parameters: `ResourceIds` and `Tags`. `Tags.Key` and `Tags.Value` are used to specify the query objects.
         * *   If you provide both `ResourceIds` and `Tags` in your request, the response will exclusively include Auto Scaling resources that satisfy the criteria set by these parameters, ensuring targeted and precise information retrieval.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries tags. You can call the ListTagResources operation to query tags that are added to Auto Scaling resources, thereby clarifying resource utilization and facilitating efficient management. This operation aids in the automation of resource categorization and permission management processes.
         *
         * @description *   Specify at least one of the following request parameters: `ResourceIds` and `Tags`. `Tags.Key` and `Tags.Value` are used to specify the query objects.
         * *   If you provide both `ResourceIds` and `Tags` in your request, the response will exclusively include Auto Scaling resources that satisfy the criteria set by these parameters, ensuring targeted and precise information retrieval.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries tags. You can call the ListTagResources operation to query tags that are added to Auto Scaling resources, thereby clarifying resource utilization and facilitating efficient management. This operation aids in the automation of resource categorization and permission management processes.
         *
         * @description *   Specify at least one of the following request parameters: `ResourceIds` and `Tags`. `Tags.Key` and `Tags.Value` are used to specify the query objects.
         * *   If you provide both `ResourceIds` and `Tags` in your request, the response will exclusively include Auto Scaling resources that satisfy the criteria set by these parameters, ensuring targeted and precise information retrieval.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tag keys associated with Auto Scaling resources to facilitate a deeper comprehension of those resources. By doing so, you can categorize and manage your Auto Scaling resources more efficiently.
         *
         * @param request ListTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the tag keys associated with Auto Scaling resources to facilitate a deeper comprehension of those resources. By doing so, you can categorize and manage your Auto Scaling resources more efficiently.
         *
         * @param request ListTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the tag keys associated with Auto Scaling resources to facilitate a deeper comprehension of those resources. By doing so, you can categorize and manage your Auto Scaling resources more efficiently.
         *
         * @param request ListTagValuesRequest
         * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tag keys associated with Auto Scaling resources to facilitate a deeper comprehension of those resources. By doing so, you can categorize and manage your Auto Scaling resources more efficiently.
         *
         * @param request ListTagValuesRequest
         * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies an event-triggered task.
         *
         * @description *   If you set the MetricType parameter to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Custom monitoring event-triggered tasks](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify the MetricName, DimensionKey, and DimensionValue parameters to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify the user_id and scaling_group dimensions for an event-triggered task to aggregate monitoring data of all Elastic Compute Service (ECS) instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you set the MetricType parameter to custom, the valid values are your custom metrics.
         *     *   For information about the metrics that are supported if you set the MetricType parameter to system, see[ Event-triggered task for system monitoring](https://help.aliyun.com/document_detail/74854.html).
         * > The user_id and scaling_group dimensions are automatically populated. You need to only specify the device and state dimensions. For more information, see the `DimensionKey` and `DimensionValue` parameters in the "Request parameters" section of this topic.
         *
         * @param request ModifyAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAlarmResponse
         */
        public ModifyAlarmResponse ModifyAlarmWithOptions(ModifyAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmActions))
            {
                query["AlarmActions"] = request.AlarmActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparisonOperator))
            {
                query["ComparisonOperator"] = request.ComparisonOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effective))
            {
                query["Effective"] = request.Effective;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expressions))
            {
                query["Expressions"] = request.Expressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressionsLogicOperator))
            {
                query["ExpressionsLogicOperator"] = request.ExpressionsLogicOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statistics))
            {
                query["Statistics"] = request.Statistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAlarmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies an event-triggered task.
         *
         * @description *   If you set the MetricType parameter to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Custom monitoring event-triggered tasks](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify the MetricName, DimensionKey, and DimensionValue parameters to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify the user_id and scaling_group dimensions for an event-triggered task to aggregate monitoring data of all Elastic Compute Service (ECS) instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you set the MetricType parameter to custom, the valid values are your custom metrics.
         *     *   For information about the metrics that are supported if you set the MetricType parameter to system, see[ Event-triggered task for system monitoring](https://help.aliyun.com/document_detail/74854.html).
         * > The user_id and scaling_group dimensions are automatically populated. You need to only specify the device and state dimensions. For more information, see the `DimensionKey` and `DimensionValue` parameters in the "Request parameters" section of this topic.
         *
         * @param request ModifyAlarmRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAlarmResponse
         */
        public async Task<ModifyAlarmResponse> ModifyAlarmWithOptionsAsync(ModifyAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmActions))
            {
                query["AlarmActions"] = request.AlarmActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTaskId))
            {
                query["AlarmTaskId"] = request.AlarmTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparisonOperator))
            {
                query["ComparisonOperator"] = request.ComparisonOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effective))
            {
                query["Effective"] = request.Effective;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expressions))
            {
                query["Expressions"] = request.Expressions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpressionsLogicOperator))
            {
                query["ExpressionsLogicOperator"] = request.ExpressionsLogicOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statistics))
            {
                query["Statistics"] = request.Statistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAlarm",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAlarmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies an event-triggered task.
         *
         * @description *   If you set the MetricType parameter to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Custom monitoring event-triggered tasks](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify the MetricName, DimensionKey, and DimensionValue parameters to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify the user_id and scaling_group dimensions for an event-triggered task to aggregate monitoring data of all Elastic Compute Service (ECS) instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you set the MetricType parameter to custom, the valid values are your custom metrics.
         *     *   For information about the metrics that are supported if you set the MetricType parameter to system, see[ Event-triggered task for system monitoring](https://help.aliyun.com/document_detail/74854.html).
         * > The user_id and scaling_group dimensions are automatically populated. You need to only specify the device and state dimensions. For more information, see the `DimensionKey` and `DimensionValue` parameters in the "Request parameters" section of this topic.
         *
         * @param request ModifyAlarmRequest
         * @return ModifyAlarmResponse
         */
        public ModifyAlarmResponse ModifyAlarm(ModifyAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAlarmWithOptions(request, runtime);
        }

        /**
         * @summary Modifies an event-triggered task.
         *
         * @description *   If you set the MetricType parameter to custom, you must report your custom metrics to CloudMonitor before you can create event-triggered tasks by using the custom metrics. For more information, see [Custom monitoring event-triggered tasks](https://help.aliyun.com/document_detail/74861.html).
         * *   When you create an event-triggered task, you must specify the MetricName, DimensionKey, and DimensionValue parameters to determine the range of statistics that you want to aggregate for the metrics of the scaling group. For example, you can specify the user_id and scaling_group dimensions for an event-triggered task to aggregate monitoring data of all Elastic Compute Service (ECS) instances or elastic container instances in a scaling group within an Alibaba Cloud account.
         *     *   If you set the MetricType parameter to custom, the valid values are your custom metrics.
         *     *   For information about the metrics that are supported if you set the MetricType parameter to system, see[ Event-triggered task for system monitoring](https://help.aliyun.com/document_detail/74854.html).
         * > The user_id and scaling_group dimensions are automatically populated. You need to only specify the device and state dimensions. For more information, see the `DimensionKey` and `DimensionValue` parameters in the "Request parameters" section of this topic.
         *
         * @param request ModifyAlarmRequest
         * @return ModifyAlarmResponse
         */
        public async Task<ModifyAlarmResponse> ModifyAlarmAsync(ModifyAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAlarmWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyAlertConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAlertConfigurationResponse
         */
        public ModifyAlertConfigurationResponse ModifyAlertConfigurationWithOptions(ModifyAlertConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleStatuses))
            {
                query["ScaleStatuses"] = request.ScaleStatuses;
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
                Action = "ModifyAlertConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAlertConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyAlertConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAlertConfigurationResponse
         */
        public async Task<ModifyAlertConfigurationResponse> ModifyAlertConfigurationWithOptionsAsync(ModifyAlertConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleStatuses))
            {
                query["ScaleStatuses"] = request.ScaleStatuses;
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
                Action = "ModifyAlertConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAlertConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyAlertConfigurationRequest
         * @return ModifyAlertConfigurationResponse
         */
        public ModifyAlertConfigurationResponse ModifyAlertConfiguration(ModifyAlertConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAlertConfigurationWithOptions(request, runtime);
        }

        /**
         * @param request ModifyAlertConfigurationRequest
         * @return ModifyAlertConfigurationResponse
         */
        public async Task<ModifyAlertConfigurationResponse> ModifyAlertConfigurationAsync(ModifyAlertConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAlertConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a scaling configuration for a scaling group that contains elastic container instances.
         *
         * @description If you want to change the name of a scaling configuration in a scaling group, make sure that the new name is unique within the scaling group.
         *
         * @param request ModifyEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyEciScalingConfigurationResponse
         */
        public ModifyEciScalingConfigurationResponse ModifyEciScalingConfigurationWithOptions(ModifyEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfos))
            {
                query["AcrRegistryInfos"] = request.AcrRegistryInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveDeadlineSeconds))
            {
                query["ActiveDeadlineSeconds"] = request.ActiveDeadlineSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateEip))
            {
                query["AutoCreateEip"] = request.AutoCreateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Containers))
            {
                query["Containers"] = request.Containers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainersUpdateType))
            {
                query["ContainersUpdateType"] = request.ContainersUpdateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostOptimization))
            {
                query["CostOptimization"] = request.CostOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsCore))
            {
                query["CpuOptionsCore"] = request.CpuOptionsCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsThreadsPerCore))
            {
                query["CpuOptionsThreadsPerCore"] = request.CpuOptionsThreadsPerCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBucket))
            {
                query["DataCacheBucket"] = request.DataCacheBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBurstingEnabled))
            {
                query["DataCacheBurstingEnabled"] = request.DataCacheBurstingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCachePL))
            {
                query["DataCachePL"] = request.DataCachePL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheProvisionedIops))
            {
                query["DataCacheProvisionedIops"] = request.DataCacheProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigNameServers))
            {
                query["DnsConfigNameServers"] = request.DnsConfigNameServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigOptions))
            {
                query["DnsConfigOptions"] = request.DnsConfigOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigSearchs))
            {
                query["DnsConfigSearchs"] = request.DnsConfigSearchs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsPolicy))
            {
                query["DnsPolicy"] = request.DnsPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressBandwidth))
            {
                query["EgressBandwidth"] = request.EgressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSls))
            {
                query["EnableSls"] = request.EnableSls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliases))
            {
                query["HostAliases"] = request.HostAliases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredentials))
            {
                query["ImageRegistryCredentials"] = request.ImageRegistryCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSnapshotId))
            {
                query["ImageSnapshotId"] = request.ImageSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressBandwidth))
            {
                query["IngressBandwidth"] = request.IngressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainers))
            {
                query["InitContainers"] = request.InitContainers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceFamilyLevel))
            {
                query["InstanceFamilyLevel"] = request.InstanceFamilyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NtpServers))
            {
                query["NtpServers"] = request.NtpServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityContextSysCtls))
            {
                query["SecurityContextSysCtls"] = request.SecurityContextSysCtls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volumes))
            {
                query["Volumes"] = request.Volumes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEciScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a scaling configuration for a scaling group that contains elastic container instances.
         *
         * @description If you want to change the name of a scaling configuration in a scaling group, make sure that the new name is unique within the scaling group.
         *
         * @param request ModifyEciScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyEciScalingConfigurationResponse
         */
        public async Task<ModifyEciScalingConfigurationResponse> ModifyEciScalingConfigurationWithOptionsAsync(ModifyEciScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfos))
            {
                query["AcrRegistryInfos"] = request.AcrRegistryInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveDeadlineSeconds))
            {
                query["ActiveDeadlineSeconds"] = request.ActiveDeadlineSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateEip))
            {
                query["AutoCreateEip"] = request.AutoCreateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Containers))
            {
                query["Containers"] = request.Containers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainersUpdateType))
            {
                query["ContainersUpdateType"] = request.ContainersUpdateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostOptimization))
            {
                query["CostOptimization"] = request.CostOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsCore))
            {
                query["CpuOptionsCore"] = request.CpuOptionsCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsThreadsPerCore))
            {
                query["CpuOptionsThreadsPerCore"] = request.CpuOptionsThreadsPerCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBucket))
            {
                query["DataCacheBucket"] = request.DataCacheBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBurstingEnabled))
            {
                query["DataCacheBurstingEnabled"] = request.DataCacheBurstingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCachePL))
            {
                query["DataCachePL"] = request.DataCachePL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheProvisionedIops))
            {
                query["DataCacheProvisionedIops"] = request.DataCacheProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigNameServers))
            {
                query["DnsConfigNameServers"] = request.DnsConfigNameServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigOptions))
            {
                query["DnsConfigOptions"] = request.DnsConfigOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfigSearchs))
            {
                query["DnsConfigSearchs"] = request.DnsConfigSearchs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsPolicy))
            {
                query["DnsPolicy"] = request.DnsPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressBandwidth))
            {
                query["EgressBandwidth"] = request.EgressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSls))
            {
                query["EnableSls"] = request.EnableSls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliases))
            {
                query["HostAliases"] = request.HostAliases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredentials))
            {
                query["ImageRegistryCredentials"] = request.ImageRegistryCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSnapshotId))
            {
                query["ImageSnapshotId"] = request.ImageSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressBandwidth))
            {
                query["IngressBandwidth"] = request.IngressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainers))
            {
                query["InitContainers"] = request.InitContainers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceFamilyLevel))
            {
                query["InstanceFamilyLevel"] = request.InstanceFamilyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NtpServers))
            {
                query["NtpServers"] = request.NtpServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityContextSysCtls))
            {
                query["SecurityContextSysCtls"] = request.SecurityContextSysCtls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volumes))
            {
                query["Volumes"] = request.Volumes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEciScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEciScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a scaling configuration for a scaling group that contains elastic container instances.
         *
         * @description If you want to change the name of a scaling configuration in a scaling group, make sure that the new name is unique within the scaling group.
         *
         * @param request ModifyEciScalingConfigurationRequest
         * @return ModifyEciScalingConfigurationResponse
         */
        public ModifyEciScalingConfigurationResponse ModifyEciScalingConfiguration(ModifyEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEciScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a scaling configuration for a scaling group that contains elastic container instances.
         *
         * @description If you want to change the name of a scaling configuration in a scaling group, make sure that the new name is unique within the scaling group.
         *
         * @param request ModifyEciScalingConfigurationRequest
         * @return ModifyEciScalingConfigurationResponse
         */
        public async Task<ModifyEciScalingConfigurationResponse> ModifyEciScalingConfigurationAsync(ModifyEciScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEciScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the attributes of an Elastic Compute Service (ECS) instance in a scaling group. You can call the ModifyInstanceAttribute operation to modify the lifecycle management attribute of a manually added ECS instance in a scaling group.
         *
         * @param request ModifyInstanceAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceAttributeResponse
         */
        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entrusted))
            {
                query["Entrusted"] = request.Entrusted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ModifyInstanceAttribute",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the attributes of an Elastic Compute Service (ECS) instance in a scaling group. You can call the ModifyInstanceAttribute operation to modify the lifecycle management attribute of a manually added ECS instance in a scaling group.
         *
         * @param request ModifyInstanceAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceAttributeResponse
         */
        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entrusted))
            {
                query["Entrusted"] = request.Entrusted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ModifyInstanceAttribute",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the attributes of an Elastic Compute Service (ECS) instance in a scaling group. You can call the ModifyInstanceAttribute operation to modify the lifecycle management attribute of a manually added ECS instance in a scaling group.
         *
         * @param request ModifyInstanceAttributeRequest
         * @return ModifyInstanceAttributeResponse
         */
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the attributes of an Elastic Compute Service (ECS) instance in a scaling group. You can call the ModifyInstanceAttribute operation to modify the lifecycle management attribute of a manually added ECS instance in a scaling group.
         *
         * @param request ModifyInstanceAttributeRequest
         * @return ModifyInstanceAttributeResponse
         */
        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a lifecycle hook.
         *
         * @description You can use one of the following methods to specify the lifecycle hook that you want to modify:
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. When you use this method, the ScalingGroupId and LifecycleHookName parameters are ignored.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         *
         * @param request ModifyLifecycleHookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLifecycleHookResponse
         */
        public ModifyLifecycleHookResponse ModifyLifecycleHookWithOptions(ModifyLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultResult))
            {
                query["DefaultResult"] = request.DefaultResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeartbeatTimeout))
            {
                query["HeartbeatTimeout"] = request.HeartbeatTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["LifecycleHookId"] = request.LifecycleHookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookStatus))
            {
                query["LifecycleHookStatus"] = request.LifecycleHookStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleTransition))
            {
                query["LifecycleTransition"] = request.LifecycleTransition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationMetadata))
            {
                query["NotificationMetadata"] = request.NotificationMetadata;
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
                Action = "ModifyLifecycleHook",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLifecycleHookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a lifecycle hook.
         *
         * @description You can use one of the following methods to specify the lifecycle hook that you want to modify:
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. When you use this method, the ScalingGroupId and LifecycleHookName parameters are ignored.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         *
         * @param request ModifyLifecycleHookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLifecycleHookResponse
         */
        public async Task<ModifyLifecycleHookResponse> ModifyLifecycleHookWithOptionsAsync(ModifyLifecycleHookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultResult))
            {
                query["DefaultResult"] = request.DefaultResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeartbeatTimeout))
            {
                query["HeartbeatTimeout"] = request.HeartbeatTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["LifecycleHookId"] = request.LifecycleHookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookName))
            {
                query["LifecycleHookName"] = request.LifecycleHookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookStatus))
            {
                query["LifecycleHookStatus"] = request.LifecycleHookStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleTransition))
            {
                query["LifecycleTransition"] = request.LifecycleTransition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationMetadata))
            {
                query["NotificationMetadata"] = request.NotificationMetadata;
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
                Action = "ModifyLifecycleHook",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLifecycleHookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a lifecycle hook.
         *
         * @description You can use one of the following methods to specify the lifecycle hook that you want to modify:
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. When you use this method, the ScalingGroupId and LifecycleHookName parameters are ignored.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         *
         * @param request ModifyLifecycleHookRequest
         * @return ModifyLifecycleHookResponse
         */
        public ModifyLifecycleHookResponse ModifyLifecycleHook(ModifyLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLifecycleHookWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a lifecycle hook.
         *
         * @description You can use one of the following methods to specify the lifecycle hook that you want to modify:
         * *   Specify the lifecycle hook ID by using the LifecycleHookId parameter. When you use this method, the ScalingGroupId and LifecycleHookName parameters are ignored.
         * *   Specify the scaling group ID by using the ScalingGroupId parameter and the lifecycle hook name by using the LifecycleHookName parameter.
         *
         * @param request ModifyLifecycleHookRequest
         * @return ModifyLifecycleHookResponse
         */
        public async Task<ModifyLifecycleHookResponse> ModifyLifecycleHookAsync(ModifyLifecycleHookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLifecycleHookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a notification.
         *
         * @param request ModifyNotificationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNotificationConfigurationResponse
         */
        public ModifyNotificationConfigurationResponse ModifyNotificationConfigurationWithOptions(ModifyNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationTypes))
            {
                query["NotificationTypes"] = request.NotificationTypes;
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
                Action = "ModifyNotificationConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNotificationConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a notification.
         *
         * @param request ModifyNotificationConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNotificationConfigurationResponse
         */
        public async Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfigurationWithOptionsAsync(ModifyNotificationConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationArn))
            {
                query["NotificationArn"] = request.NotificationArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationTypes))
            {
                query["NotificationTypes"] = request.NotificationTypes;
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
                Action = "ModifyNotificationConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNotificationConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a notification.
         *
         * @param request ModifyNotificationConfigurationRequest
         * @return ModifyNotificationConfigurationResponse
         */
        public ModifyNotificationConfigurationResponse ModifyNotificationConfiguration(ModifyNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNotificationConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a notification.
         *
         * @param request ModifyNotificationConfigurationRequest
         * @return ModifyNotificationConfigurationResponse
         */
        public async Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfigurationAsync(ModifyNotificationConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNotificationConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a scaling configuration.
         *
         * @description You can change the name of a scaling configuration in a scaling group. The name must be unique within the scaling group.
         *
         * @param tmpReq ModifyScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingConfigurationResponse
         */
        public ModifyScalingConfigurationResponse ModifyScalingConfigurationWithOptions(ModifyScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyScalingConfigurationShrinkRequest request = new ModifyScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                query["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditSpecification))
            {
                query["CreditSpecification"] = request.CreditSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPriorities))
            {
                query["CustomPriorities"] = request.CustomPriorities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisks))
            {
                query["DataDisks"] = request.DataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostClusterId))
            {
                query["DedicatedHostClusterId"] = request.DedicatedHostClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostId))
            {
                query["DedicatedHostId"] = request.DedicatedHostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSetId))
            {
                query["DeploymentSetId"] = request.DeploymentSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpcClusterId))
            {
                query["HpcClusterId"] = request.HpcClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFamily))
            {
                query["ImageFamily"] = request.ImageFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancePatternInfos))
            {
                query["InstancePatternInfos"] = request.InstancePatternInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypeOverrides))
            {
                query["InstanceTypeOverrides"] = request.InstanceTypeOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetMaxBandwidthOut))
            {
                query["InternetMaxBandwidthOut"] = request.InternetMaxBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoOptimized))
            {
                query["IoOptimized"] = request.IoOptimized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaces))
            {
                query["NetworkInterfaces"] = request.NetworkInterfaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInherit))
            {
                query["PasswordInherit"] = request.PasswordInherit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulerOptionsShrink))
            {
                query["SchedulerOptions"] = request.SchedulerOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInterruptionBehavior))
            {
                query["SpotInterruptionBehavior"] = request.SpotInterruptionBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimits))
            {
                query["SpotPriceLimits"] = request.SpotPriceLimits;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetId))
            {
                query["StorageSetId"] = request.StorageSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetPartitionNumber))
            {
                query["StorageSetPartitionNumber"] = request.StorageSetPartitionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskCategories))
            {
                query["SystemDiskCategories"] = request.SystemDiskCategories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenancy))
            {
                query["Tenancy"] = request.Tenancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageOptions))
            {
                query["ImageOptions"] = request.ImageOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivatePoolOptions))
            {
                query["PrivatePoolOptions"] = request.PrivatePoolOptions;
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
                Action = "ModifyScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a scaling configuration.
         *
         * @description You can change the name of a scaling configuration in a scaling group. The name must be unique within the scaling group.
         *
         * @param tmpReq ModifyScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingConfigurationResponse
         */
        public async Task<ModifyScalingConfigurationResponse> ModifyScalingConfigurationWithOptionsAsync(ModifyScalingConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyScalingConfigurationShrinkRequest request = new ModifyScalingConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerOptions))
            {
                request.SchedulerOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerOptions, "SchedulerOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                query["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditSpecification))
            {
                query["CreditSpecification"] = request.CreditSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPriorities))
            {
                query["CustomPriorities"] = request.CustomPriorities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisks))
            {
                query["DataDisks"] = request.DataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostClusterId))
            {
                query["DedicatedHostClusterId"] = request.DedicatedHostClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedHostId))
            {
                query["DedicatedHostId"] = request.DedicatedHostId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSetId))
            {
                query["DeploymentSetId"] = request.DeploymentSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpcClusterId))
            {
                query["HpcClusterId"] = request.HpcClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFamily))
            {
                query["ImageFamily"] = request.ImageFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDescription))
            {
                query["InstanceDescription"] = request.InstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancePatternInfos))
            {
                query["InstancePatternInfos"] = request.InstancePatternInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypeOverrides))
            {
                query["InstanceTypeOverrides"] = request.InstanceTypeOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypes))
            {
                query["InstanceTypes"] = request.InstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetMaxBandwidthOut))
            {
                query["InternetMaxBandwidthOut"] = request.InternetMaxBandwidthOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoOptimized))
            {
                query["IoOptimized"] = request.IoOptimized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerWeight))
            {
                query["LoadBalancerWeight"] = request.LoadBalancerWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaces))
            {
                query["NetworkInterfaces"] = request.NetworkInterfaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInherit))
            {
                query["PasswordInherit"] = request.PasswordInherit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationId))
            {
                query["ScalingConfigurationId"] = request.ScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingConfigurationName))
            {
                query["ScalingConfigurationName"] = request.ScalingConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulerOptionsShrink))
            {
                query["SchedulerOptions"] = request.SchedulerOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInterruptionBehavior))
            {
                query["SpotInterruptionBehavior"] = request.SpotInterruptionBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimits))
            {
                query["SpotPriceLimits"] = request.SpotPriceLimits;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetId))
            {
                query["StorageSetId"] = request.StorageSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetPartitionNumber))
            {
                query["StorageSetPartitionNumber"] = request.StorageSetPartitionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskCategories))
            {
                query["SystemDiskCategories"] = request.SystemDiskCategories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenancy))
            {
                query["Tenancy"] = request.Tenancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageOptions))
            {
                query["ImageOptions"] = request.ImageOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivatePoolOptions))
            {
                query["PrivatePoolOptions"] = request.PrivatePoolOptions;
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
                Action = "ModifyScalingConfiguration",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a scaling configuration.
         *
         * @description You can change the name of a scaling configuration in a scaling group. The name must be unique within the scaling group.
         *
         * @param request ModifyScalingConfigurationRequest
         * @return ModifyScalingConfigurationResponse
         */
        public ModifyScalingConfigurationResponse ModifyScalingConfiguration(ModifyScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a scaling configuration.
         *
         * @description You can change the name of a scaling configuration in a scaling group. The name must be unique within the scaling group.
         *
         * @param request ModifyScalingConfigurationRequest
         * @return ModifyScalingConfigurationResponse
         */
        public async Task<ModifyScalingConfigurationResponse> ModifyScalingConfigurationAsync(ModifyScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can modify scaling groups to adjust your computing power with ease. The computing power refers to the instances that provide the computing capability. When your scaling group cannot meet your business requirements, you can call the ModifyScalingGroup operation to modify scaling group attributes such as the maximum, minimum, and expected numbers of instances. This prevents repeated creation and configuration of scaling groups, which saves you a lot of time and resource costs.
         *
         * @description *   You cannot modify the following parameters by calling this operation:
         *     *   RegionId
         *     *   LoadBalancerId
         *     **
         *     **Note** If you want to modify the load balancer settings of your scaling group, you can call the AttachLoadBalancers operation or the DetachLoadBalancers operation.
         *     *   DBInstanceId
         *     **
         *     **Note** If you want to modify the ApsaraDB RDS instance settings of your scaling group, you can call the AttachDBInstances operation or the DetachDBInstances operation.
         * *   You can call this operation to modify a scaling group only when the scaling group is in the `Active` or `Inactive` state.
         * *   Enabling a new scaling configuration in the scaling group will not impact existing Elastic Compute Service (ECS) instances or elastic container instances that were provisioned based on the previous scaling configuration. These instances will continue to run as expected.
         * *   If the modification of the MaxSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new maximum limit, Auto Scaling proactively removes the surplus instances to restore the total number to match the new maximum limit.
         * *   If the modification of the MinSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new minimum threshold, Auto Scaling proactively adds more instances to the scaling group to ensure that the total number aligns with the new minimum threshold.
         * *   If the modification of the DesiredCapacity setting leads to the total number of ECS instances or elastic container instances in the scaling group not matching the new desired capacity, Auto Scaling proactively adjusts the total number of instances to ensure that the total number aligns with the new desired capacity.
         *
         * @param request ModifyScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingGroupResponse
         */
        public ModifyScalingGroupResponse ModifyScalingGroupWithOptions(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationStrategy))
            {
                query["AllocationStrategy"] = request.AllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AzBalance))
            {
                query["AzBalance"] = request.AzBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompensateWithOnDemand))
            {
                query["CompensateWithOnDemand"] = request.CompensateWithOnDemand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPolicyARN))
            {
                query["CustomPolicyARN"] = request.CustomPolicyARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableDesiredCapacity))
            {
                query["DisableDesiredCapacity"] = request.DisableDesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeletionProtection))
            {
                query["GroupDeletionProtection"] = request.GroupDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTypes))
            {
                query["HealthCheckTypes"] = request.HealthCheckTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateId))
            {
                query["LaunchTemplateId"] = request.LaunchTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateOverrides))
            {
                query["LaunchTemplateOverrides"] = request.LaunchTemplateOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateVersion))
            {
                query["LaunchTemplateVersion"] = request.LaunchTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInstanceLifetime))
            {
                query["MaxInstanceLifetime"] = request.MaxInstanceLifetime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAZPolicy))
            {
                query["MultiAZPolicy"] = request.MultiAZPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandBaseCapacity))
            {
                query["OnDemandBaseCapacity"] = request.OnDemandBaseCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandPercentageAboveBaseCapacity))
            {
                query["OnDemandPercentageAboveBaseCapacity"] = request.OnDemandPercentageAboveBaseCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicies))
            {
                query["RemovalPolicies"] = request.RemovalPolicies;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotAllocationStrategy))
            {
                query["SpotAllocationStrategy"] = request.SpotAllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstancePools))
            {
                query["SpotInstancePools"] = request.SpotInstancePools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstanceRemedy))
            {
                query["SpotInstanceRemedy"] = request.SpotInstanceRemedy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingGroup",
                Version = "2022-02-22",
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
         * @summary Modifies a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can modify scaling groups to adjust your computing power with ease. The computing power refers to the instances that provide the computing capability. When your scaling group cannot meet your business requirements, you can call the ModifyScalingGroup operation to modify scaling group attributes such as the maximum, minimum, and expected numbers of instances. This prevents repeated creation and configuration of scaling groups, which saves you a lot of time and resource costs.
         *
         * @description *   You cannot modify the following parameters by calling this operation:
         *     *   RegionId
         *     *   LoadBalancerId
         *     **
         *     **Note** If you want to modify the load balancer settings of your scaling group, you can call the AttachLoadBalancers operation or the DetachLoadBalancers operation.
         *     *   DBInstanceId
         *     **
         *     **Note** If you want to modify the ApsaraDB RDS instance settings of your scaling group, you can call the AttachDBInstances operation or the DetachDBInstances operation.
         * *   You can call this operation to modify a scaling group only when the scaling group is in the `Active` or `Inactive` state.
         * *   Enabling a new scaling configuration in the scaling group will not impact existing Elastic Compute Service (ECS) instances or elastic container instances that were provisioned based on the previous scaling configuration. These instances will continue to run as expected.
         * *   If the modification of the MaxSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new maximum limit, Auto Scaling proactively removes the surplus instances to restore the total number to match the new maximum limit.
         * *   If the modification of the MinSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new minimum threshold, Auto Scaling proactively adds more instances to the scaling group to ensure that the total number aligns with the new minimum threshold.
         * *   If the modification of the DesiredCapacity setting leads to the total number of ECS instances or elastic container instances in the scaling group not matching the new desired capacity, Auto Scaling proactively adjusts the total number of instances to ensure that the total number aligns with the new desired capacity.
         *
         * @param request ModifyScalingGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingGroupResponse
         */
        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupWithOptionsAsync(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveScalingConfigurationId))
            {
                query["ActiveScalingConfigurationId"] = request.ActiveScalingConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocationStrategy))
            {
                query["AllocationStrategy"] = request.AllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AzBalance))
            {
                query["AzBalance"] = request.AzBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompensateWithOnDemand))
            {
                query["CompensateWithOnDemand"] = request.CompensateWithOnDemand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPolicyARN))
            {
                query["CustomPolicyARN"] = request.CustomPolicyARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCooldown))
            {
                query["DefaultCooldown"] = request.DefaultCooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableDesiredCapacity))
            {
                query["DisableDesiredCapacity"] = request.DisableDesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeletionProtection))
            {
                query["GroupDeletionProtection"] = request.GroupDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTypes))
            {
                query["HealthCheckTypes"] = request.HealthCheckTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateId))
            {
                query["LaunchTemplateId"] = request.LaunchTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateOverrides))
            {
                query["LaunchTemplateOverrides"] = request.LaunchTemplateOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTemplateVersion))
            {
                query["LaunchTemplateVersion"] = request.LaunchTemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInstanceLifetime))
            {
                query["MaxInstanceLifetime"] = request.MaxInstanceLifetime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSize))
            {
                query["MaxSize"] = request.MaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSize))
            {
                query["MinSize"] = request.MinSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAZPolicy))
            {
                query["MultiAZPolicy"] = request.MultiAZPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandBaseCapacity))
            {
                query["OnDemandBaseCapacity"] = request.OnDemandBaseCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnDemandPercentageAboveBaseCapacity))
            {
                query["OnDemandPercentageAboveBaseCapacity"] = request.OnDemandPercentageAboveBaseCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovalPolicies))
            {
                query["RemovalPolicies"] = request.RemovalPolicies;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupName))
            {
                query["ScalingGroupName"] = request.ScalingGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingPolicy))
            {
                query["ScalingPolicy"] = request.ScalingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotAllocationStrategy))
            {
                query["SpotAllocationStrategy"] = request.SpotAllocationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstancePools))
            {
                query["SpotInstancePools"] = request.SpotInstancePools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotInstanceRemedy))
            {
                query["SpotInstanceRemedy"] = request.SpotInstanceRemedy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingGroup",
                Version = "2022-02-22",
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
         * @summary Modifies a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can modify scaling groups to adjust your computing power with ease. The computing power refers to the instances that provide the computing capability. When your scaling group cannot meet your business requirements, you can call the ModifyScalingGroup operation to modify scaling group attributes such as the maximum, minimum, and expected numbers of instances. This prevents repeated creation and configuration of scaling groups, which saves you a lot of time and resource costs.
         *
         * @description *   You cannot modify the following parameters by calling this operation:
         *     *   RegionId
         *     *   LoadBalancerId
         *     **
         *     **Note** If you want to modify the load balancer settings of your scaling group, you can call the AttachLoadBalancers operation or the DetachLoadBalancers operation.
         *     *   DBInstanceId
         *     **
         *     **Note** If you want to modify the ApsaraDB RDS instance settings of your scaling group, you can call the AttachDBInstances operation or the DetachDBInstances operation.
         * *   You can call this operation to modify a scaling group only when the scaling group is in the `Active` or `Inactive` state.
         * *   Enabling a new scaling configuration in the scaling group will not impact existing Elastic Compute Service (ECS) instances or elastic container instances that were provisioned based on the previous scaling configuration. These instances will continue to run as expected.
         * *   If the modification of the MaxSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new maximum limit, Auto Scaling proactively removes the surplus instances to restore the total number to match the new maximum limit.
         * *   If the modification of the MinSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new minimum threshold, Auto Scaling proactively adds more instances to the scaling group to ensure that the total number aligns with the new minimum threshold.
         * *   If the modification of the DesiredCapacity setting leads to the total number of ECS instances or elastic container instances in the scaling group not matching the new desired capacity, Auto Scaling proactively adjusts the total number of instances to ensure that the total number aligns with the new desired capacity.
         *
         * @param request ModifyScalingGroupRequest
         * @return ModifyScalingGroupResponse
         */
        public ModifyScalingGroupResponse ModifyScalingGroup(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a scaling group. If you want to enable policy-based automatic addition or removal of instances of a specific type to meet evolving business requirements, you can modify scaling groups to adjust your computing power with ease. The computing power refers to the instances that provide the computing capability. When your scaling group cannot meet your business requirements, you can call the ModifyScalingGroup operation to modify scaling group attributes such as the maximum, minimum, and expected numbers of instances. This prevents repeated creation and configuration of scaling groups, which saves you a lot of time and resource costs.
         *
         * @description *   You cannot modify the following parameters by calling this operation:
         *     *   RegionId
         *     *   LoadBalancerId
         *     **
         *     **Note** If you want to modify the load balancer settings of your scaling group, you can call the AttachLoadBalancers operation or the DetachLoadBalancers operation.
         *     *   DBInstanceId
         *     **
         *     **Note** If you want to modify the ApsaraDB RDS instance settings of your scaling group, you can call the AttachDBInstances operation or the DetachDBInstances operation.
         * *   You can call this operation to modify a scaling group only when the scaling group is in the `Active` or `Inactive` state.
         * *   Enabling a new scaling configuration in the scaling group will not impact existing Elastic Compute Service (ECS) instances or elastic container instances that were provisioned based on the previous scaling configuration. These instances will continue to run as expected.
         * *   If the modification of the MaxSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new maximum limit, Auto Scaling proactively removes the surplus instances to restore the total number to match the new maximum limit.
         * *   If the modification of the MinSize setting leads to the total number of ECS instances or elastic container instances in the scaling group exceeding the new minimum threshold, Auto Scaling proactively adds more instances to the scaling group to ensure that the total number aligns with the new minimum threshold.
         * *   If the modification of the DesiredCapacity setting leads to the total number of ECS instances or elastic container instances in the scaling group not matching the new desired capacity, Auto Scaling proactively adjusts the total number of instances to ensure that the total number aligns with the new desired capacity.
         *
         * @param request ModifyScalingGroupRequest
         * @return ModifyScalingGroupResponse
         */
        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupAsync(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a scaling rule.
         *
         * @param request ModifyScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmDimensions))
            {
                query["AlarmDimensions"] = request.AlarmDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableScaleIn))
            {
                query["DisableScaleIn"] = request.DisableScaleIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstimatedInstanceWarmup))
            {
                query["EstimatedInstanceWarmup"] = request.EstimatedInstanceWarmup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialMaxSize))
            {
                query["InitialMaxSize"] = request.InitialMaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAdjustmentMagnitude))
            {
                query["MinAdjustmentMagnitude"] = request.MinAdjustmentMagnitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveScalingMode))
            {
                query["PredictiveScalingMode"] = request.PredictiveScalingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveTaskBufferTime))
            {
                query["PredictiveTaskBufferTime"] = request.PredictiveTaskBufferTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBehavior))
            {
                query["PredictiveValueBehavior"] = request.PredictiveValueBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBuffer))
            {
                query["PredictiveValueBuffer"] = request.PredictiveValueBuffer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleInEvaluationCount))
            {
                query["ScaleInEvaluationCount"] = request.ScaleInEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleOutEvaluationCount))
            {
                query["ScaleOutEvaluationCount"] = request.ScaleOutEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepAdjustments))
            {
                query["StepAdjustments"] = request.StepAdjustments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2022-02-22",
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
         * @summary Modifies a scaling rule.
         *
         * @param request ModifyScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScalingRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmDimensions))
            {
                query["AlarmDimensions"] = request.AlarmDimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cooldown))
            {
                query["Cooldown"] = request.Cooldown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableScaleIn))
            {
                query["DisableScaleIn"] = request.DisableScaleIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstimatedInstanceWarmup))
            {
                query["EstimatedInstanceWarmup"] = request.EstimatedInstanceWarmup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialMaxSize))
            {
                query["InitialMaxSize"] = request.InitialMaxSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAdjustmentMagnitude))
            {
                query["MinAdjustmentMagnitude"] = request.MinAdjustmentMagnitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveScalingMode))
            {
                query["PredictiveScalingMode"] = request.PredictiveScalingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveTaskBufferTime))
            {
                query["PredictiveTaskBufferTime"] = request.PredictiveTaskBufferTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBehavior))
            {
                query["PredictiveValueBehavior"] = request.PredictiveValueBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictiveValueBuffer))
            {
                query["PredictiveValueBuffer"] = request.PredictiveValueBuffer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleInEvaluationCount))
            {
                query["ScaleInEvaluationCount"] = request.ScaleInEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleOutEvaluationCount))
            {
                query["ScaleOutEvaluationCount"] = request.ScaleOutEvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleId))
            {
                query["ScalingRuleId"] = request.ScalingRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepAdjustments))
            {
                query["StepAdjustments"] = request.StepAdjustments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScalingRule",
                Version = "2022-02-22",
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
         * @summary Modifies a scaling rule.
         *
         * @param request ModifyScalingRuleRequest
         * @return ModifyScalingRuleResponse
         */
        public ModifyScalingRuleResponse ModifyScalingRule(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a scaling rule.
         *
         * @param request ModifyScalingRuleRequest
         * @return ModifyScalingRuleResponse
         */
        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleAsync(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a scheduled task.
         *
         * @description You can use the following parameters to specify the scaling method of a scheduled task:
         * *   If you use the `ScheduledAction` parameter, you must select an existing scaling rule for the scheduled task.
         * *   If you use the `ScalingGroupId` parameter, you must specify the minimum number, maximum number, or expected number of instances in the scheduled task.
         * > You cannot specify the `ScheduledAction` and `ScalingGroupId` parameters at the same time.
         *
         * @param request ModifyScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScheduledTaskResponse
         */
        public ModifyScheduledTaskResponse ModifyScheduledTaskWithOptions(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                query["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                query["MinValue"] = request.MinValue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
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
                Version = "2022-02-22",
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
         * @summary Modifies a scheduled task.
         *
         * @description You can use the following parameters to specify the scaling method of a scheduled task:
         * *   If you use the `ScheduledAction` parameter, you must select an existing scaling rule for the scheduled task.
         * *   If you use the `ScalingGroupId` parameter, you must specify the minimum number, maximum number, or expected number of instances in the scheduled task.
         * > You cannot specify the `ScheduledAction` and `ScalingGroupId` parameters at the same time.
         *
         * @param request ModifyScheduledTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScheduledTaskResponse
         */
        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskWithOptionsAsync(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesiredCapacity))
            {
                query["DesiredCapacity"] = request.DesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchExpirationTime))
            {
                query["LaunchExpirationTime"] = request.LaunchExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchTime))
            {
                query["LaunchTime"] = request.LaunchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                query["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                query["MinValue"] = request.MinValue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroupId))
            {
                query["ScalingGroupId"] = request.ScalingGroupId;
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
                Version = "2022-02-22",
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
         * @summary Modifies a scheduled task.
         *
         * @description You can use the following parameters to specify the scaling method of a scheduled task:
         * *   If you use the `ScheduledAction` parameter, you must select an existing scaling rule for the scheduled task.
         * *   If you use the `ScalingGroupId` parameter, you must specify the minimum number, maximum number, or expected number of instances in the scheduled task.
         * > You cannot specify the `ScheduledAction` and `ScalingGroupId` parameters at the same time.
         *
         * @param request ModifyScheduledTaskRequest
         * @return ModifyScheduledTaskResponse
         */
        public ModifyScheduledTaskResponse ModifyScheduledTask(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduledTaskWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a scheduled task.
         *
         * @description You can use the following parameters to specify the scaling method of a scheduled task:
         * *   If you use the `ScheduledAction` parameter, you must select an existing scaling rule for the scheduled task.
         * *   If you use the `ScalingGroupId` parameter, you must specify the minimum number, maximum number, or expected number of instances in the scheduled task.
         * > You cannot specify the `ScheduledAction` and `ScalingGroupId` parameters at the same time.
         *
         * @param request ModifyScheduledTaskRequest
         * @return ModifyScheduledTaskResponse
         */
        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskAsync(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduledTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Rebalances the distribution of Elastic Compute Service (ECS) instances across zones. If ECS instances are unevenly distributed across multiple zones, you can call the RebalanceInstances operation to rebalance the distribution of the ECS instances across the zones.
         *
         * @description ## [](#)Usage notes
         * Auto Scaling creates new ECS instances to replace the existing ECS instances to fulfill the rebalancing purpose. Auto Scaling starts the new ECS instances before stopping the existing ECS instances. The rebalancing operation does not affect the performance or service availability of your application.
         * *   This operation is supported by only multi-zone scaling groups whose `MultiAZPolicy` is set to `BALANCE`.
         * *   A rebalancing operation is required only when the distribution of the instances of a multi-zone scaling group is significantly unbalanced. In a rebalancing activity, Auto Scaling replaces up to 20 ECS instances to rectify the unbalanced distribution.
         * *   During the execution of a rebalancing operation, if the number of instances in the scaling group approaches or hits the value of MaxSize but the rebalancing operation needs to continue, Auto Scaling allows the total number of ECS instances to momentarily exceed the value of MaxSize by 10%. This temporary surplus condition persists for a duration until equilibrium in the distribution of ECS instances is achieved. Typically, it takes 1 to 6 minutes.
         *     **
         *     **Note** If the 10% increment of the maximum number of instances in a scaling group yield a non-integer value, the decimal portion is always rounded up to ensure an additional instance is accounted for. For example, you have a scaling group that holds a maximum of 15 ECS instances. During a rebalancing operation, Auto Scaling would permit the total number of instances to momentarily surpass this limit by 2, instead of the calculated 10% (which is 1.5).
         *
         * @param request RebalanceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebalanceInstancesResponse
         */
        public RebalanceInstancesResponse RebalanceInstancesWithOptions(RebalanceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebalanceInstances",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebalanceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Rebalances the distribution of Elastic Compute Service (ECS) instances across zones. If ECS instances are unevenly distributed across multiple zones, you can call the RebalanceInstances operation to rebalance the distribution of the ECS instances across the zones.
         *
         * @description ## [](#)Usage notes
         * Auto Scaling creates new ECS instances to replace the existing ECS instances to fulfill the rebalancing purpose. Auto Scaling starts the new ECS instances before stopping the existing ECS instances. The rebalancing operation does not affect the performance or service availability of your application.
         * *   This operation is supported by only multi-zone scaling groups whose `MultiAZPolicy` is set to `BALANCE`.
         * *   A rebalancing operation is required only when the distribution of the instances of a multi-zone scaling group is significantly unbalanced. In a rebalancing activity, Auto Scaling replaces up to 20 ECS instances to rectify the unbalanced distribution.
         * *   During the execution of a rebalancing operation, if the number of instances in the scaling group approaches or hits the value of MaxSize but the rebalancing operation needs to continue, Auto Scaling allows the total number of ECS instances to momentarily exceed the value of MaxSize by 10%. This temporary surplus condition persists for a duration until equilibrium in the distribution of ECS instances is achieved. Typically, it takes 1 to 6 minutes.
         *     **
         *     **Note** If the 10% increment of the maximum number of instances in a scaling group yield a non-integer value, the decimal portion is always rounded up to ensure an additional instance is accounted for. For example, you have a scaling group that holds a maximum of 15 ECS instances. During a rebalancing operation, Auto Scaling would permit the total number of instances to momentarily surpass this limit by 2, instead of the calculated 10% (which is 1.5).
         *
         * @param request RebalanceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebalanceInstancesResponse
         */
        public async Task<RebalanceInstancesResponse> RebalanceInstancesWithOptionsAsync(RebalanceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebalanceInstances",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebalanceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Rebalances the distribution of Elastic Compute Service (ECS) instances across zones. If ECS instances are unevenly distributed across multiple zones, you can call the RebalanceInstances operation to rebalance the distribution of the ECS instances across the zones.
         *
         * @description ## [](#)Usage notes
         * Auto Scaling creates new ECS instances to replace the existing ECS instances to fulfill the rebalancing purpose. Auto Scaling starts the new ECS instances before stopping the existing ECS instances. The rebalancing operation does not affect the performance or service availability of your application.
         * *   This operation is supported by only multi-zone scaling groups whose `MultiAZPolicy` is set to `BALANCE`.
         * *   A rebalancing operation is required only when the distribution of the instances of a multi-zone scaling group is significantly unbalanced. In a rebalancing activity, Auto Scaling replaces up to 20 ECS instances to rectify the unbalanced distribution.
         * *   During the execution of a rebalancing operation, if the number of instances in the scaling group approaches or hits the value of MaxSize but the rebalancing operation needs to continue, Auto Scaling allows the total number of ECS instances to momentarily exceed the value of MaxSize by 10%. This temporary surplus condition persists for a duration until equilibrium in the distribution of ECS instances is achieved. Typically, it takes 1 to 6 minutes.
         *     **
         *     **Note** If the 10% increment of the maximum number of instances in a scaling group yield a non-integer value, the decimal portion is always rounded up to ensure an additional instance is accounted for. For example, you have a scaling group that holds a maximum of 15 ECS instances. During a rebalancing operation, Auto Scaling would permit the total number of instances to momentarily surpass this limit by 2, instead of the calculated 10% (which is 1.5).
         *
         * @param request RebalanceInstancesRequest
         * @return RebalanceInstancesResponse
         */
        public RebalanceInstancesResponse RebalanceInstances(RebalanceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebalanceInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Rebalances the distribution of Elastic Compute Service (ECS) instances across zones. If ECS instances are unevenly distributed across multiple zones, you can call the RebalanceInstances operation to rebalance the distribution of the ECS instances across the zones.
         *
         * @description ## [](#)Usage notes
         * Auto Scaling creates new ECS instances to replace the existing ECS instances to fulfill the rebalancing purpose. Auto Scaling starts the new ECS instances before stopping the existing ECS instances. The rebalancing operation does not affect the performance or service availability of your application.
         * *   This operation is supported by only multi-zone scaling groups whose `MultiAZPolicy` is set to `BALANCE`.
         * *   A rebalancing operation is required only when the distribution of the instances of a multi-zone scaling group is significantly unbalanced. In a rebalancing activity, Auto Scaling replaces up to 20 ECS instances to rectify the unbalanced distribution.
         * *   During the execution of a rebalancing operation, if the number of instances in the scaling group approaches or hits the value of MaxSize but the rebalancing operation needs to continue, Auto Scaling allows the total number of ECS instances to momentarily exceed the value of MaxSize by 10%. This temporary surplus condition persists for a duration until equilibrium in the distribution of ECS instances is achieved. Typically, it takes 1 to 6 minutes.
         *     **
         *     **Note** If the 10% increment of the maximum number of instances in a scaling group yield a non-integer value, the decimal portion is always rounded up to ensure an additional instance is accounted for. For example, you have a scaling group that holds a maximum of 15 ECS instances. During a rebalancing operation, Auto Scaling would permit the total number of instances to momentarily surpass this limit by 2, instead of the calculated 10% (which is 1.5).
         *
         * @param request RebalanceInstancesRequest
         * @return RebalanceInstancesResponse
         */
        public async Task<RebalanceInstancesResponse> RebalanceInstancesAsync(RebalanceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebalanceInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Prolongs a lifecycle hook for Elastic Compute Service (ECS) instances.
         *
         * @description You can call this operation to prolong the length of a lifecycle hook up to 20 times. Take note that the total length of a lifecycle hook cannot exceed 6 hours.
         *
         * @param request RecordLifecycleActionHeartbeatRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecordLifecycleActionHeartbeatResponse
         */
        public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeatWithOptions(RecordLifecycleActionHeartbeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeartbeatTimeout))
            {
                query["heartbeatTimeout"] = request.HeartbeatTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionToken))
            {
                query["lifecycleActionToken"] = request.LifecycleActionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["lifecycleHookId"] = request.LifecycleHookId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordLifecycleActionHeartbeat",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordLifecycleActionHeartbeatResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Prolongs a lifecycle hook for Elastic Compute Service (ECS) instances.
         *
         * @description You can call this operation to prolong the length of a lifecycle hook up to 20 times. Take note that the total length of a lifecycle hook cannot exceed 6 hours.
         *
         * @param request RecordLifecycleActionHeartbeatRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecordLifecycleActionHeartbeatResponse
         */
        public async Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatWithOptionsAsync(RecordLifecycleActionHeartbeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeartbeatTimeout))
            {
                query["heartbeatTimeout"] = request.HeartbeatTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleActionToken))
            {
                query["lifecycleActionToken"] = request.LifecycleActionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookId))
            {
                query["lifecycleHookId"] = request.LifecycleHookId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordLifecycleActionHeartbeat",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordLifecycleActionHeartbeatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Prolongs a lifecycle hook for Elastic Compute Service (ECS) instances.
         *
         * @description You can call this operation to prolong the length of a lifecycle hook up to 20 times. Take note that the total length of a lifecycle hook cannot exceed 6 hours.
         *
         * @param request RecordLifecycleActionHeartbeatRequest
         * @return RecordLifecycleActionHeartbeatResponse
         */
        public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordLifecycleActionHeartbeatWithOptions(request, runtime);
        }

        /**
         * @summary Prolongs a lifecycle hook for Elastic Compute Service (ECS) instances.
         *
         * @description You can call this operation to prolong the length of a lifecycle hook up to 20 times. Take note that the total length of a lifecycle hook cannot exceed 6 hours.
         *
         * @param request RecordLifecycleActionHeartbeatRequest
         * @return RecordLifecycleActionHeartbeatResponse
         */
        public async Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordLifecycleActionHeartbeatWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The scaling group is in the Active state.
         *     *   No scaling activity is in progress within the scaling group.
         * > If no scaling activity is in progress within the scaling group, you can call the operation even within the cooldown period.
         * *   If an ECS instance is automatically created by Auto Scaling, or if an ECS instance is manually added to a scaling group and managed by the scaling group, the ECS instance is stopped in economical mode or is released after the instance is removed from the scaling group.
         * *   If an ECS instance is manually added to a scaling group and is not managed by the scaling group, the ECS instance is not stopped or released after the instance is removed from the scaling group.
         * *   If the difference between the number of existing ECS instances specified by the TotalCapacity parameter and the number of ECS instances that you call this operation to remove is less than the value of the MinSize parameter, the call fails.
         * A successful call only means that Auto Scaling accepts the request. The scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         *
         * @param request RemoveInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveInstancesResponse
         */
        public RemoveInstancesResponse RemoveInstancesWithOptions(RemoveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecreaseDesiredCapacity))
            {
                query["DecreaseDesiredCapacity"] = request.DecreaseDesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreInvalidInstance))
            {
                query["IgnoreInvalidInstance"] = request.IgnoreInvalidInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovePolicy))
            {
                query["RemovePolicy"] = request.RemovePolicy;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstances",
                Version = "2022-02-22",
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
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The scaling group is in the Active state.
         *     *   No scaling activity is in progress within the scaling group.
         * > If no scaling activity is in progress within the scaling group, you can call the operation even within the cooldown period.
         * *   If an ECS instance is automatically created by Auto Scaling, or if an ECS instance is manually added to a scaling group and managed by the scaling group, the ECS instance is stopped in economical mode or is released after the instance is removed from the scaling group.
         * *   If an ECS instance is manually added to a scaling group and is not managed by the scaling group, the ECS instance is not stopped or released after the instance is removed from the scaling group.
         * *   If the difference between the number of existing ECS instances specified by the TotalCapacity parameter and the number of ECS instances that you call this operation to remove is less than the value of the MinSize parameter, the call fails.
         * A successful call only means that Auto Scaling accepts the request. The scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         *
         * @param request RemoveInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveInstancesResponse
         */
        public async Task<RemoveInstancesResponse> RemoveInstancesWithOptionsAsync(RemoveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecreaseDesiredCapacity))
            {
                query["DecreaseDesiredCapacity"] = request.DecreaseDesiredCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreInvalidInstance))
            {
                query["IgnoreInvalidInstance"] = request.IgnoreInvalidInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovePolicy))
            {
                query["RemovePolicy"] = request.RemovePolicy;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstances",
                Version = "2022-02-22",
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
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The scaling group is in the Active state.
         *     *   No scaling activity is in progress within the scaling group.
         * > If no scaling activity is in progress within the scaling group, you can call the operation even within the cooldown period.
         * *   If an ECS instance is automatically created by Auto Scaling, or if an ECS instance is manually added to a scaling group and managed by the scaling group, the ECS instance is stopped in economical mode or is released after the instance is removed from the scaling group.
         * *   If an ECS instance is manually added to a scaling group and is not managed by the scaling group, the ECS instance is not stopped or released after the instance is removed from the scaling group.
         * *   If the difference between the number of existing ECS instances specified by the TotalCapacity parameter and the number of ECS instances that you call this operation to remove is less than the value of the MinSize parameter, the call fails.
         * A successful call only means that Auto Scaling accepts the request. The scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         *
         * @param request RemoveInstancesRequest
         * @return RemoveInstancesResponse
         */
        public RemoveInstancesResponse RemoveInstances(RemoveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Removes one or more Elastic Compute Service (ECS) instances or elastic container instances from a scaling group.
         *
         * @description *   Before you call this operation, make sure that the following requirements are met:
         *     *   The scaling group is in the Active state.
         *     *   No scaling activity is in progress within the scaling group.
         * > If no scaling activity is in progress within the scaling group, you can call the operation even within the cooldown period.
         * *   If an ECS instance is automatically created by Auto Scaling, or if an ECS instance is manually added to a scaling group and managed by the scaling group, the ECS instance is stopped in economical mode or is released after the instance is removed from the scaling group.
         * *   If an ECS instance is manually added to a scaling group and is not managed by the scaling group, the ECS instance is not stopped or released after the instance is removed from the scaling group.
         * *   If the difference between the number of existing ECS instances specified by the TotalCapacity parameter and the number of ECS instances that you call this operation to remove is less than the value of the MinSize parameter, the call fails.
         * A successful call only means that Auto Scaling accepts the request. The scaling activity may still fail. You can obtain the status of a scaling activity based on the value of the ScalingActivityId parameter in the response.
         *
         * @param request RemoveInstancesRequest
         * @return RemoveInstancesResponse
         */
        public async Task<RemoveInstancesResponse> RemoveInstancesAsync(RemoveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resumes suspended processes in a scaling group.
         *
         * @param request ResumeProcessesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeProcessesResponse
         */
        public ResumeProcessesResponse ResumeProcessesWithOptions(ResumeProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processes))
            {
                query["Processes"] = request.Processes;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeProcesses",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeProcessesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Resumes suspended processes in a scaling group.
         *
         * @param request ResumeProcessesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeProcessesResponse
         */
        public async Task<ResumeProcessesResponse> ResumeProcessesWithOptionsAsync(ResumeProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processes))
            {
                query["Processes"] = request.Processes;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeProcesses",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeProcessesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Resumes suspended processes in a scaling group.
         *
         * @param request ResumeProcessesRequest
         * @return ResumeProcessesResponse
         */
        public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeProcessesWithOptions(request, runtime);
        }

        /**
         * @summary Resumes suspended processes in a scaling group.
         *
         * @param request ResumeProcessesRequest
         * @return ResumeProcessesResponse
         */
        public async Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeProcessesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Scales instances. The ScaleWithAdjustment operation differs from the ExecuteScalingRule operation in that ScaleWithAdjust can directly scale instances without requiring you to create a scaling rule in advance.
         *
         * @description *   Before you call this operation, take note of the following items:
         *     *   The scaling group is in the Active state.
         *     *   The scaling group has no ongoing scaling activities.
         * *   If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities before the cooldown period of the scaling group expires.
         * *   If the addition of a specific number of Elastic Compute Service (ECS) instances to the scaling group causes the total number of ECS instances in the scaling group to exceed the maximum allowed number, Auto Scaling adds ECS instances to the scaling group until the total number of instances is equal to the maximum allowed number.
         * *   If the removal of a specific number of ECS instances from the scaling group causes the total number of ECS instances in the scaling group to be less than the minimum allowed number, Auto Scaling removes ECS instances from the scaling group until the total number of instances is equal to the minimum allowed number.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of `ScalingActivityId` in the response.
         *
         * @param tmpReq ScaleWithAdjustmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleWithAdjustmentResponse
         */
        public ScaleWithAdjustmentResponse ScaleWithAdjustmentWithOptions(ScaleWithAdjustmentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScaleWithAdjustmentShrinkRequest request = new ScaleWithAdjustmentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LifecycleHookContext))
            {
                request.LifecycleHookContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LifecycleHookContext, "LifecycleHookContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Overrides))
            {
                request.OverridesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Overrides, "Overrides", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityMetadata))
            {
                query["ActivityMetadata"] = request.ActivityMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentType))
            {
                query["AdjustmentType"] = request.AdjustmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentValue))
            {
                query["AdjustmentValue"] = request.AdjustmentValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookContextShrink))
            {
                query["LifecycleHookContext"] = request.LifecycleHookContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAdjustmentMagnitude))
            {
                query["MinAdjustmentMagnitude"] = request.MinAdjustmentMagnitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverridesShrink))
            {
                query["Overrides"] = request.OverridesShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncActivity))
            {
                query["SyncActivity"] = request.SyncActivity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleWithAdjustment",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleWithAdjustmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Scales instances. The ScaleWithAdjustment operation differs from the ExecuteScalingRule operation in that ScaleWithAdjust can directly scale instances without requiring you to create a scaling rule in advance.
         *
         * @description *   Before you call this operation, take note of the following items:
         *     *   The scaling group is in the Active state.
         *     *   The scaling group has no ongoing scaling activities.
         * *   If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities before the cooldown period of the scaling group expires.
         * *   If the addition of a specific number of Elastic Compute Service (ECS) instances to the scaling group causes the total number of ECS instances in the scaling group to exceed the maximum allowed number, Auto Scaling adds ECS instances to the scaling group until the total number of instances is equal to the maximum allowed number.
         * *   If the removal of a specific number of ECS instances from the scaling group causes the total number of ECS instances in the scaling group to be less than the minimum allowed number, Auto Scaling removes ECS instances from the scaling group until the total number of instances is equal to the minimum allowed number.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of `ScalingActivityId` in the response.
         *
         * @param tmpReq ScaleWithAdjustmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleWithAdjustmentResponse
         */
        public async Task<ScaleWithAdjustmentResponse> ScaleWithAdjustmentWithOptionsAsync(ScaleWithAdjustmentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScaleWithAdjustmentShrinkRequest request = new ScaleWithAdjustmentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LifecycleHookContext))
            {
                request.LifecycleHookContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LifecycleHookContext, "LifecycleHookContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Overrides))
            {
                request.OverridesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Overrides, "Overrides", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityMetadata))
            {
                query["ActivityMetadata"] = request.ActivityMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentType))
            {
                query["AdjustmentType"] = request.AdjustmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustmentValue))
            {
                query["AdjustmentValue"] = request.AdjustmentValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifecycleHookContextShrink))
            {
                query["LifecycleHookContext"] = request.LifecycleHookContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAdjustmentMagnitude))
            {
                query["MinAdjustmentMagnitude"] = request.MinAdjustmentMagnitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverridesShrink))
            {
                query["Overrides"] = request.OverridesShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncActivity))
            {
                query["SyncActivity"] = request.SyncActivity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleWithAdjustment",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleWithAdjustmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Scales instances. The ScaleWithAdjustment operation differs from the ExecuteScalingRule operation in that ScaleWithAdjust can directly scale instances without requiring you to create a scaling rule in advance.
         *
         * @description *   Before you call this operation, take note of the following items:
         *     *   The scaling group is in the Active state.
         *     *   The scaling group has no ongoing scaling activities.
         * *   If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities before the cooldown period of the scaling group expires.
         * *   If the addition of a specific number of Elastic Compute Service (ECS) instances to the scaling group causes the total number of ECS instances in the scaling group to exceed the maximum allowed number, Auto Scaling adds ECS instances to the scaling group until the total number of instances is equal to the maximum allowed number.
         * *   If the removal of a specific number of ECS instances from the scaling group causes the total number of ECS instances in the scaling group to be less than the minimum allowed number, Auto Scaling removes ECS instances from the scaling group until the total number of instances is equal to the minimum allowed number.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of `ScalingActivityId` in the response.
         *
         * @param request ScaleWithAdjustmentRequest
         * @return ScaleWithAdjustmentResponse
         */
        public ScaleWithAdjustmentResponse ScaleWithAdjustment(ScaleWithAdjustmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScaleWithAdjustmentWithOptions(request, runtime);
        }

        /**
         * @summary Scales instances. The ScaleWithAdjustment operation differs from the ExecuteScalingRule operation in that ScaleWithAdjust can directly scale instances without requiring you to create a scaling rule in advance.
         *
         * @description *   Before you call this operation, take note of the following items:
         *     *   The scaling group is in the Active state.
         *     *   The scaling group has no ongoing scaling activities.
         * *   If no scaling activities in the scaling group are in progress, the operation can trigger scaling activities before the cooldown period of the scaling group expires.
         * *   If the addition of a specific number of Elastic Compute Service (ECS) instances to the scaling group causes the total number of ECS instances in the scaling group to exceed the maximum allowed number, Auto Scaling adds ECS instances to the scaling group until the total number of instances is equal to the maximum allowed number.
         * *   If the removal of a specific number of ECS instances from the scaling group causes the total number of ECS instances in the scaling group to be less than the minimum allowed number, Auto Scaling removes ECS instances from the scaling group until the total number of instances is equal to the minimum allowed number.
         * A successful call indicates that Auto Scaling accepts the request. However, the scaling activity may still fail. You can obtain the status of a scaling activity based on the value of `ScalingActivityId` in the response.
         *
         * @param request ScaleWithAdjustmentRequest
         * @return ScaleWithAdjustmentResponse
         */
        public async Task<ScaleWithAdjustmentResponse> ScaleWithAdjustmentAsync(ScaleWithAdjustmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScaleWithAdjustmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets deletion protection for a scaling group. If you enable deletion protection for a scaling group, you cannot delete the scaling group. If you disable deletion protection for a scaling group, you can directly delete the scaling group. You can call the SetGroupDeletionProtection operation to enable or disable deletion protection.
         *
         * @param request SetGroupDeletionProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetGroupDeletionProtectionResponse
         */
        public SetGroupDeletionProtectionResponse SetGroupDeletionProtectionWithOptions(SetGroupDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeletionProtection))
            {
                query["GroupDeletionProtection"] = request.GroupDeletionProtection;
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
                Action = "SetGroupDeletionProtection",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGroupDeletionProtectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets deletion protection for a scaling group. If you enable deletion protection for a scaling group, you cannot delete the scaling group. If you disable deletion protection for a scaling group, you can directly delete the scaling group. You can call the SetGroupDeletionProtection operation to enable or disable deletion protection.
         *
         * @param request SetGroupDeletionProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetGroupDeletionProtectionResponse
         */
        public async Task<SetGroupDeletionProtectionResponse> SetGroupDeletionProtectionWithOptionsAsync(SetGroupDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeletionProtection))
            {
                query["GroupDeletionProtection"] = request.GroupDeletionProtection;
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
                Action = "SetGroupDeletionProtection",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGroupDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets deletion protection for a scaling group. If you enable deletion protection for a scaling group, you cannot delete the scaling group. If you disable deletion protection for a scaling group, you can directly delete the scaling group. You can call the SetGroupDeletionProtection operation to enable or disable deletion protection.
         *
         * @param request SetGroupDeletionProtectionRequest
         * @return SetGroupDeletionProtectionResponse
         */
        public SetGroupDeletionProtectionResponse SetGroupDeletionProtection(SetGroupDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGroupDeletionProtectionWithOptions(request, runtime);
        }

        /**
         * @summary Sets deletion protection for a scaling group. If you enable deletion protection for a scaling group, you cannot delete the scaling group. If you disable deletion protection for a scaling group, you can directly delete the scaling group. You can call the SetGroupDeletionProtection operation to enable or disable deletion protection.
         *
         * @param request SetGroupDeletionProtectionRequest
         * @return SetGroupDeletionProtectionResponse
         */
        public async Task<SetGroupDeletionProtectionResponse> SetGroupDeletionProtectionAsync(SetGroupDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGroupDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets instance health. At times, the automatic health check system might not sufficiently determine the precise health status of your Elastic Compute Service (ECS) instances or elastic container instances. To overcome this, you can call the SetInstanceHealth operation to swiftly pinpoint problematic instances and resolve issues. This operation is designed to more precisely align with real-world business requirements and tackle O\\&M hurdles efficiently.
         *
         * @description Auto Scaling detects and removes unhealthy ECS instances or elastic container instances from the corresponding scaling groups. If you want to retain a specific instance in the corresponding scaling group, you can put the instance into the Standby or Protected state. For more information, see [EnterStandby](~~EnterStandby~~) and [SetInstancesProtection](~~SetInstancesProtection~~).
         *
         * @param request SetInstanceHealthRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetInstanceHealthResponse
         */
        public SetInstanceHealthResponse SetInstanceHealthWithOptions(SetInstanceHealthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["HealthStatus"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "SetInstanceHealth",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInstanceHealthResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets instance health. At times, the automatic health check system might not sufficiently determine the precise health status of your Elastic Compute Service (ECS) instances or elastic container instances. To overcome this, you can call the SetInstanceHealth operation to swiftly pinpoint problematic instances and resolve issues. This operation is designed to more precisely align with real-world business requirements and tackle O\\&M hurdles efficiently.
         *
         * @description Auto Scaling detects and removes unhealthy ECS instances or elastic container instances from the corresponding scaling groups. If you want to retain a specific instance in the corresponding scaling group, you can put the instance into the Standby or Protected state. For more information, see [EnterStandby](~~EnterStandby~~) and [SetInstancesProtection](~~SetInstancesProtection~~).
         *
         * @param request SetInstanceHealthRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetInstanceHealthResponse
         */
        public async Task<SetInstanceHealthResponse> SetInstanceHealthWithOptionsAsync(SetInstanceHealthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["HealthStatus"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "SetInstanceHealth",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInstanceHealthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets instance health. At times, the automatic health check system might not sufficiently determine the precise health status of your Elastic Compute Service (ECS) instances or elastic container instances. To overcome this, you can call the SetInstanceHealth operation to swiftly pinpoint problematic instances and resolve issues. This operation is designed to more precisely align with real-world business requirements and tackle O\\&M hurdles efficiently.
         *
         * @description Auto Scaling detects and removes unhealthy ECS instances or elastic container instances from the corresponding scaling groups. If you want to retain a specific instance in the corresponding scaling group, you can put the instance into the Standby or Protected state. For more information, see [EnterStandby](~~EnterStandby~~) and [SetInstancesProtection](~~SetInstancesProtection~~).
         *
         * @param request SetInstanceHealthRequest
         * @return SetInstanceHealthResponse
         */
        public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceHealthWithOptions(request, runtime);
        }

        /**
         * @summary Sets instance health. At times, the automatic health check system might not sufficiently determine the precise health status of your Elastic Compute Service (ECS) instances or elastic container instances. To overcome this, you can call the SetInstanceHealth operation to swiftly pinpoint problematic instances and resolve issues. This operation is designed to more precisely align with real-world business requirements and tackle O\\&M hurdles efficiently.
         *
         * @description Auto Scaling detects and removes unhealthy ECS instances or elastic container instances from the corresponding scaling groups. If you want to retain a specific instance in the corresponding scaling group, you can put the instance into the Standby or Protected state. For more information, see [EnterStandby](~~EnterStandby~~) and [SetInstancesProtection](~~SetInstancesProtection~~).
         *
         * @param request SetInstanceHealthRequest
         * @return SetInstanceHealthResponse
         */
        public async Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceHealthWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Puts Elastic Compute Service (ECS) instances into the Protected state. When ECS instances are put into the Protected state, they become immune to manual deletion attempts by using the Auto Scaling console or API operations. This operation serves as a robust safeguard, efficiently preventing any inadvertent instance release that could lead to irreversible consequences.
         *
         * @description Once ECS instances enter the Protected state, they become subject to the following restrictions:
         * *   ECS instances will persist in the Protected state, unless you deliberately remove them from this state.
         * *   Even in scenarios where automatic scale-in actions are initiated due to fluctuations in the number of ECS instances or the execution of event-triggered tasks, Auto Scaling does not remove ECS instances that are in the Protected state from their respective scaling groups. Only after being manually removed from their respective scaling groups can ECS instances that are in the Protected state be released. For more information, see [Remove an ECS instance](https://help.aliyun.com/document_detail/25955.html).
         * *   ECS instances in the Protected state maintain their existing health status even when they undergo stopping or restarting processes.
         *
         * @param request SetInstancesProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetInstancesProtectionResponse
         */
        public SetInstancesProtectionResponse SetInstancesProtectionWithOptions(SetInstancesProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectedFromScaleIn))
            {
                query["ProtectedFromScaleIn"] = request.ProtectedFromScaleIn;
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
                Action = "SetInstancesProtection",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInstancesProtectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Puts Elastic Compute Service (ECS) instances into the Protected state. When ECS instances are put into the Protected state, they become immune to manual deletion attempts by using the Auto Scaling console or API operations. This operation serves as a robust safeguard, efficiently preventing any inadvertent instance release that could lead to irreversible consequences.
         *
         * @description Once ECS instances enter the Protected state, they become subject to the following restrictions:
         * *   ECS instances will persist in the Protected state, unless you deliberately remove them from this state.
         * *   Even in scenarios where automatic scale-in actions are initiated due to fluctuations in the number of ECS instances or the execution of event-triggered tasks, Auto Scaling does not remove ECS instances that are in the Protected state from their respective scaling groups. Only after being manually removed from their respective scaling groups can ECS instances that are in the Protected state be released. For more information, see [Remove an ECS instance](https://help.aliyun.com/document_detail/25955.html).
         * *   ECS instances in the Protected state maintain their existing health status even when they undergo stopping or restarting processes.
         *
         * @param request SetInstancesProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetInstancesProtectionResponse
         */
        public async Task<SetInstancesProtectionResponse> SetInstancesProtectionWithOptionsAsync(SetInstancesProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectedFromScaleIn))
            {
                query["ProtectedFromScaleIn"] = request.ProtectedFromScaleIn;
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
                Action = "SetInstancesProtection",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInstancesProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Puts Elastic Compute Service (ECS) instances into the Protected state. When ECS instances are put into the Protected state, they become immune to manual deletion attempts by using the Auto Scaling console or API operations. This operation serves as a robust safeguard, efficiently preventing any inadvertent instance release that could lead to irreversible consequences.
         *
         * @description Once ECS instances enter the Protected state, they become subject to the following restrictions:
         * *   ECS instances will persist in the Protected state, unless you deliberately remove them from this state.
         * *   Even in scenarios where automatic scale-in actions are initiated due to fluctuations in the number of ECS instances or the execution of event-triggered tasks, Auto Scaling does not remove ECS instances that are in the Protected state from their respective scaling groups. Only after being manually removed from their respective scaling groups can ECS instances that are in the Protected state be released. For more information, see [Remove an ECS instance](https://help.aliyun.com/document_detail/25955.html).
         * *   ECS instances in the Protected state maintain their existing health status even when they undergo stopping or restarting processes.
         *
         * @param request SetInstancesProtectionRequest
         * @return SetInstancesProtectionResponse
         */
        public SetInstancesProtectionResponse SetInstancesProtection(SetInstancesProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstancesProtectionWithOptions(request, runtime);
        }

        /**
         * @summary Puts Elastic Compute Service (ECS) instances into the Protected state. When ECS instances are put into the Protected state, they become immune to manual deletion attempts by using the Auto Scaling console or API operations. This operation serves as a robust safeguard, efficiently preventing any inadvertent instance release that could lead to irreversible consequences.
         *
         * @description Once ECS instances enter the Protected state, they become subject to the following restrictions:
         * *   ECS instances will persist in the Protected state, unless you deliberately remove them from this state.
         * *   Even in scenarios where automatic scale-in actions are initiated due to fluctuations in the number of ECS instances or the execution of event-triggered tasks, Auto Scaling does not remove ECS instances that are in the Protected state from their respective scaling groups. Only after being manually removed from their respective scaling groups can ECS instances that are in the Protected state be released. For more information, see [Remove an ECS instance](https://help.aliyun.com/document_detail/25955.html).
         * *   ECS instances in the Protected state maintain their existing health status even when they undergo stopping or restarting processes.
         *
         * @param request SetInstancesProtectionRequest
         * @return SetInstancesProtectionResponse
         */
        public async Task<SetInstancesProtectionResponse> SetInstancesProtectionAsync(SetInstancesProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstancesProtectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Suspends scaling processes. This operation empowers you to selectively pause distinct scaling processes within a particular scaling group, enabling you to carry out alternative tasks and achieve more granular management over your scaling operations.
         *
         * @param request SuspendProcessesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendProcessesResponse
         */
        public SuspendProcessesResponse SuspendProcessesWithOptions(SuspendProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processes))
            {
                query["Processes"] = request.Processes;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendProcesses",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendProcessesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Suspends scaling processes. This operation empowers you to selectively pause distinct scaling processes within a particular scaling group, enabling you to carry out alternative tasks and achieve more granular management over your scaling operations.
         *
         * @param request SuspendProcessesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendProcessesResponse
         */
        public async Task<SuspendProcessesResponse> SuspendProcessesWithOptionsAsync(SuspendProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processes))
            {
                query["Processes"] = request.Processes;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendProcesses",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendProcessesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Suspends scaling processes. This operation empowers you to selectively pause distinct scaling processes within a particular scaling group, enabling you to carry out alternative tasks and achieve more granular management over your scaling operations.
         *
         * @param request SuspendProcessesRequest
         * @return SuspendProcessesResponse
         */
        public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendProcessesWithOptions(request, runtime);
        }

        /**
         * @summary Suspends scaling processes. This operation empowers you to selectively pause distinct scaling processes within a particular scaling group, enabling you to carry out alternative tasks and achieve more granular management over your scaling operations.
         *
         * @param request SuspendProcessesRequest
         * @return SuspendProcessesResponse
         */
        public async Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendProcessesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates and attaches tags. You can call the TagResources operation to uniformly create and attach tags to your Auto Scaling resources, streamlining resource management. This capability empowers you to categorize resources based on tags, thereby enhancing the overall efficiency of resource allocation and utilization.
         *
         * @description *   You can attach up to 20 tags to a scaling group.
         *     **
         *     **Note** Before you attach tags to a specific Auto Scaling resource, Alibaba Cloud automatically verifies the current number of tags attached to that resource. In the event the proposed addition would exceed the maximum allowed number of tags, an error message will be promptly returned after you call this operation.
         * *   If you set `Tags.Propagate` to `true`, any tags attached to your scaling group will be automatically propagated to new instances that are subsequently created in the scaling group, without affecting existing instances.
         * *   If both the scaling configuration and the scaling group have tags attached, and tag propagation from the scaling group is enabled, the tags of newly created instances comply with the following rules:
         *     *   Instances set to join the scaling group will inherit the following tags: tags attached to the scaling configuration that initiates the instance creation and tags attached to the scaling group that are allowed to propagate to these instances upon instance creation.
         *     *   If the tag keys of the scaling configuration and those attached to the scaling group and propagated to the instances are identical, the tags attached to the scaling group and propagated to the instances will be overwritten by the tags of the scaling configuration.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates and attaches tags. You can call the TagResources operation to uniformly create and attach tags to your Auto Scaling resources, streamlining resource management. This capability empowers you to categorize resources based on tags, thereby enhancing the overall efficiency of resource allocation and utilization.
         *
         * @description *   You can attach up to 20 tags to a scaling group.
         *     **
         *     **Note** Before you attach tags to a specific Auto Scaling resource, Alibaba Cloud automatically verifies the current number of tags attached to that resource. In the event the proposed addition would exceed the maximum allowed number of tags, an error message will be promptly returned after you call this operation.
         * *   If you set `Tags.Propagate` to `true`, any tags attached to your scaling group will be automatically propagated to new instances that are subsequently created in the scaling group, without affecting existing instances.
         * *   If both the scaling configuration and the scaling group have tags attached, and tag propagation from the scaling group is enabled, the tags of newly created instances comply with the following rules:
         *     *   Instances set to join the scaling group will inherit the following tags: tags attached to the scaling configuration that initiates the instance creation and tags attached to the scaling group that are allowed to propagate to these instances upon instance creation.
         *     *   If the tag keys of the scaling configuration and those attached to the scaling group and propagated to the instances are identical, the tags attached to the scaling group and propagated to the instances will be overwritten by the tags of the scaling configuration.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates and attaches tags. You can call the TagResources operation to uniformly create and attach tags to your Auto Scaling resources, streamlining resource management. This capability empowers you to categorize resources based on tags, thereby enhancing the overall efficiency of resource allocation and utilization.
         *
         * @description *   You can attach up to 20 tags to a scaling group.
         *     **
         *     **Note** Before you attach tags to a specific Auto Scaling resource, Alibaba Cloud automatically verifies the current number of tags attached to that resource. In the event the proposed addition would exceed the maximum allowed number of tags, an error message will be promptly returned after you call this operation.
         * *   If you set `Tags.Propagate` to `true`, any tags attached to your scaling group will be automatically propagated to new instances that are subsequently created in the scaling group, without affecting existing instances.
         * *   If both the scaling configuration and the scaling group have tags attached, and tag propagation from the scaling group is enabled, the tags of newly created instances comply with the following rules:
         *     *   Instances set to join the scaling group will inherit the following tags: tags attached to the scaling configuration that initiates the instance creation and tags attached to the scaling group that are allowed to propagate to these instances upon instance creation.
         *     *   If the tag keys of the scaling configuration and those attached to the scaling group and propagated to the instances are identical, the tags attached to the scaling group and propagated to the instances will be overwritten by the tags of the scaling configuration.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Creates and attaches tags. You can call the TagResources operation to uniformly create and attach tags to your Auto Scaling resources, streamlining resource management. This capability empowers you to categorize resources based on tags, thereby enhancing the overall efficiency of resource allocation and utilization.
         *
         * @description *   You can attach up to 20 tags to a scaling group.
         *     **
         *     **Note** Before you attach tags to a specific Auto Scaling resource, Alibaba Cloud automatically verifies the current number of tags attached to that resource. In the event the proposed addition would exceed the maximum allowed number of tags, an error message will be promptly returned after you call this operation.
         * *   If you set `Tags.Propagate` to `true`, any tags attached to your scaling group will be automatically propagated to new instances that are subsequently created in the scaling group, without affecting existing instances.
         * *   If both the scaling configuration and the scaling group have tags attached, and tag propagation from the scaling group is enabled, the tags of newly created instances comply with the following rules:
         *     *   Instances set to join the scaling group will inherit the following tags: tags attached to the scaling configuration that initiates the instance creation and tags attached to the scaling group that are allowed to propagate to these instances upon instance creation.
         *     *   If the tag keys of the scaling configuration and those attached to the scaling group and propagated to the instances are identical, the tags attached to the scaling group and propagated to the instances will be overwritten by the tags of the scaling configuration.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from Auto Scaling resources simultaneously. This operation streamlines resource management activities, enhances system efficiency, and mitigates potential security vulnerabilities. Once a tag is removed from a particular resource, and if it is not re-added to any other resource, the system will automatically delete the unused tag.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes tags from Auto Scaling resources simultaneously. This operation streamlines resource management activities, enhances system efficiency, and mitigates potential security vulnerabilities. Once a tag is removed from a particular resource, and if it is not re-added to any other resource, the system will automatically delete the unused tag.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes tags from Auto Scaling resources simultaneously. This operation streamlines resource management activities, enhances system efficiency, and mitigates potential security vulnerabilities. Once a tag is removed from a particular resource, and if it is not re-added to any other resource, the system will automatically delete the unused tag.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Removes tags from Auto Scaling resources simultaneously. This operation streamlines resource management activities, enhances system efficiency, and mitigates potential security vulnerabilities. Once a tag is removed from a particular resource, and if it is not re-added to any other resource, the system will automatically delete the unused tag.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether Auto Scaling is authorized to access Elastic Compute Service (ECS) and Elastic Container Instance resources.
         *
         * @param request VerifyAuthenticationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyAuthenticationResponse
         */
        public VerifyAuthenticationResponse VerifyAuthenticationWithOptions(VerifyAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyCheck))
            {
                query["OnlyCheck"] = request.OnlyCheck;
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
                Version = "2022-02-22",
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
         * @summary Checks whether Auto Scaling is authorized to access Elastic Compute Service (ECS) and Elastic Container Instance resources.
         *
         * @param request VerifyAuthenticationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyAuthenticationResponse
         */
        public async Task<VerifyAuthenticationResponse> VerifyAuthenticationWithOptionsAsync(VerifyAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyCheck))
            {
                query["OnlyCheck"] = request.OnlyCheck;
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
                Version = "2022-02-22",
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
         * @summary Checks whether Auto Scaling is authorized to access Elastic Compute Service (ECS) and Elastic Container Instance resources.
         *
         * @param request VerifyAuthenticationRequest
         * @return VerifyAuthenticationResponse
         */
        public VerifyAuthenticationResponse VerifyAuthentication(VerifyAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyAuthenticationWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether Auto Scaling is authorized to access Elastic Compute Service (ECS) and Elastic Container Instance resources.
         *
         * @param request VerifyAuthenticationRequest
         * @return VerifyAuthenticationResponse
         */
        public async Task<VerifyAuthenticationResponse> VerifyAuthenticationAsync(VerifyAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyAuthenticationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Verifies whether Auto Scaling is activated. This operation guarantees that in response to shifts in business workloads or variations in incoming traffic, the system will automatically adjust resource provisioning. This auto-scaling capability enhances the overall system performance, ensuring high availability and improved flexibility to accommodate dynamic demands.
         *
         * @param request VerifyUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyUserResponse
         */
        public VerifyUserResponse VerifyUserWithOptions(VerifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "VerifyUser",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Verifies whether Auto Scaling is activated. This operation guarantees that in response to shifts in business workloads or variations in incoming traffic, the system will automatically adjust resource provisioning. This auto-scaling capability enhances the overall system performance, ensuring high availability and improved flexibility to accommodate dynamic demands.
         *
         * @param request VerifyUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyUserResponse
         */
        public async Task<VerifyUserResponse> VerifyUserWithOptionsAsync(VerifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "VerifyUser",
                Version = "2022-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Verifies whether Auto Scaling is activated. This operation guarantees that in response to shifts in business workloads or variations in incoming traffic, the system will automatically adjust resource provisioning. This auto-scaling capability enhances the overall system performance, ensuring high availability and improved flexibility to accommodate dynamic demands.
         *
         * @param request VerifyUserRequest
         * @return VerifyUserResponse
         */
        public VerifyUserResponse VerifyUser(VerifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyUserWithOptions(request, runtime);
        }

        /**
         * @summary Verifies whether Auto Scaling is activated. This operation guarantees that in response to shifts in business workloads or variations in incoming traffic, the system will automatically adjust resource provisioning. This auto-scaling capability enhances the overall system performance, ensuring high availability and improved flexibility to accommodate dynamic demands.
         *
         * @param request VerifyUserRequest
         * @return VerifyUserResponse
         */
        public async Task<VerifyUserResponse> VerifyUserAsync(VerifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyUserWithOptionsAsync(request, runtime);
        }

    }
}
