// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Foasconsole20211028.Models;

namespace AlibabaCloud.SDK.Foasconsole20211028
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("foasconsole", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ConvertInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public ConvertInstanceResponse ConvertInstanceWithOptions(ConvertInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConvertInstanceShrinkRequest request = new ConvertInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ConvertInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public async Task<ConvertInstanceResponse> ConvertInstanceWithOptionsAsync(ConvertInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConvertInstanceShrinkRequest request = new ConvertInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public ConvertInstanceResponse ConvertInstance(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public async Task<ConvertInstanceResponse> ConvertInstanceAsync(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorType))
            {
                body["MonitorType"] = request.MonitorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorType))
            {
                body["MonitorType"] = request.MonitorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建命名空间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNamespaceShrinkRequest request = new CreateNamespaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建命名空间</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNamespaceShrinkRequest request = new CreateNamespaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建命名空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建命名空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放按量付费的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放按量付费的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放按量付费的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放按量付费的实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>instance列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeInstancesShrinkRequest request = new DescribeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>instance列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeInstancesShrinkRequest request = new DescribeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>instance列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>instance列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>namespace列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public DescribeNamespacesResponse DescribeNamespacesWithOptions(DescribeNamespacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeNamespacesShrinkRequest request = new DescribeNamespacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>namespace列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespacesWithOptionsAsync(DescribeNamespacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeNamespacesShrinkRequest request = new DescribeNamespacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>namespace列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public DescribeNamespacesResponse DescribeNamespaces(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNamespacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>namespace列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespacesAsync(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNamespacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的region列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public DescribeSupportedRegionsResponse DescribeSupportedRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedRegions",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的region列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public async Task<DescribeSupportedRegionsResponse> DescribeSupportedRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedRegions",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的region列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public DescribeSupportedRegionsResponse DescribeSupportedRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupportedRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的region列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public async Task<DescribeSupportedRegionsResponse> DescribeSupportedRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupportedRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的zoneId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public DescribeSupportedZonesResponse DescribeSupportedZonesWithOptions(DescribeSupportedZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedZones",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的zoneId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public async Task<DescribeSupportedZonesResponse> DescribeSupportedZonesWithOptionsAsync(DescribeSupportedZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedZones",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的zoneId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public DescribeSupportedZonesResponse DescribeSupportedZones(DescribeSupportedZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupportedZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的zoneId列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public async Task<DescribeSupportedZonesResponse> DescribeSupportedZonesAsync(DescribeSupportedZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupportedZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举flinkasi标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-10-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举flinkasi标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-10-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举flinkasi标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举flinkasi标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扩容/缩容</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public ModifyPrepayInstanceSpecResponse ModifyPrepayInstanceSpecWithOptions(ModifyPrepayInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayInstanceSpecShrinkRequest request = new ModifyPrepayInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayInstanceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扩容/缩容</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayInstanceSpecResponse> ModifyPrepayInstanceSpecWithOptionsAsync(ModifyPrepayInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayInstanceSpecShrinkRequest request = new ModifyPrepayInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayInstanceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扩容/缩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public ModifyPrepayInstanceSpecResponse ModifyPrepayInstanceSpec(ModifyPrepayInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrepayInstanceSpecWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>扩容/缩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayInstanceSpecResponse> ModifyPrepayInstanceSpecAsync(ModifyPrepayInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrepayInstanceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改namespace资源分配</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public ModifyPrepayNamespaceSpecResponse ModifyPrepayNamespaceSpecWithOptions(ModifyPrepayNamespaceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayNamespaceSpecShrinkRequest request = new ModifyPrepayNamespaceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayNamespaceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayNamespaceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改namespace资源分配</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayNamespaceSpecResponse> ModifyPrepayNamespaceSpecWithOptionsAsync(ModifyPrepayNamespaceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayNamespaceSpecShrinkRequest request = new ModifyPrepayNamespaceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayNamespaceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayNamespaceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改namespace资源分配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public ModifyPrepayNamespaceSpecResponse ModifyPrepayNamespaceSpec(ModifyPrepayNamespaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrepayNamespaceSpecWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改namespace资源分配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayNamespaceSpecResponse> ModifyPrepayNamespaceSpecAsync(ModifyPrepayNamespaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrepayNamespaceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月询价</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public QueryConvertInstancePriceResponse QueryConvertInstancePriceWithOptions(QueryConvertInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConvertInstancePriceShrinkRequest request = new QueryConvertInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConvertInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConvertInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月询价</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public async Task<QueryConvertInstancePriceResponse> QueryConvertInstancePriceWithOptionsAsync(QueryConvertInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConvertInstancePriceShrinkRequest request = new QueryConvertInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConvertInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConvertInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public QueryConvertInstancePriceResponse QueryConvertInstancePrice(QueryConvertInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConvertInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按量付费转包年包月询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public async Task<QueryConvertInstancePriceResponse> QueryConvertInstancePriceAsync(QueryConvertInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConvertInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建实例的价格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public QueryCreateInstancePriceResponse QueryCreateInstancePriceWithOptions(QueryCreateInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCreateInstancePriceShrinkRequest request = new QueryCreateInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCreateInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建实例的价格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public async Task<QueryCreateInstancePriceResponse> QueryCreateInstancePriceWithOptionsAsync(QueryCreateInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCreateInstancePriceShrinkRequest request = new QueryCreateInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCreateInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建实例的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public QueryCreateInstancePriceResponse QueryCreateInstancePrice(QueryCreateInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCreateInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取创建实例的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public async Task<QueryCreateInstancePriceResponse> QueryCreateInstancePriceAsync(QueryCreateInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCreateInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例修改资源规格的价格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public QueryModifyInstancePriceResponse QueryModifyInstancePriceWithOptions(QueryModifyInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryModifyInstancePriceShrinkRequest request = new QueryModifyInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例修改资源规格的价格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public async Task<QueryModifyInstancePriceResponse> QueryModifyInstancePriceWithOptionsAsync(QueryModifyInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryModifyInstancePriceShrinkRequest request = new QueryModifyInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例修改资源规格的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public QueryModifyInstancePriceResponse QueryModifyInstancePrice(QueryModifyInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryModifyInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例修改资源规格的价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public async Task<QueryModifyInstancePriceResponse> QueryModifyInstancePriceAsync(QueryModifyInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryModifyInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public QueryRenewInstancePriceResponse QueryRenewInstancePriceWithOptions(QueryRenewInstancePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRenewInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRenewInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public async Task<QueryRenewInstancePriceResponse> QueryRenewInstancePriceWithOptionsAsync(QueryRenewInstancePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRenewInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRenewInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public QueryRenewInstancePriceResponse QueryRenewInstancePrice(QueryRenewInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRenewInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询付费类型为包年包月的实例续费价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public async Task<QueryRenewInstancePriceResponse> QueryRenewInstancePriceAsync(QueryRenewInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRenewInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-10-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-10-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>flinkasi去标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-10-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>flinkasi去标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-10-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>flinkasi去标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>flinkasi去标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
