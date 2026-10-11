// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EPG20260715.Models;

namespace AlibabaCloud.SDK.EPG20260715
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("epg", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>向出口代理地址池添加IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddIpAddressesToEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddIpAddressesToEgressProxyIpPoolResponse
        /// </returns>
        public AddIpAddressesToEgressProxyIpPoolResponse AddIpAddressesToEgressProxyIpPoolWithOptions(AddIpAddressesToEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddIpAddressesToEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddIpAddressesToEgressProxyIpPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向出口代理地址池添加IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddIpAddressesToEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddIpAddressesToEgressProxyIpPoolResponse
        /// </returns>
        public async Task<AddIpAddressesToEgressProxyIpPoolResponse> AddIpAddressesToEgressProxyIpPoolWithOptionsAsync(AddIpAddressesToEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddIpAddressesToEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddIpAddressesToEgressProxyIpPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向出口代理地址池添加IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddIpAddressesToEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// AddIpAddressesToEgressProxyIpPoolResponse
        /// </returns>
        public AddIpAddressesToEgressProxyIpPoolResponse AddIpAddressesToEgressProxyIpPool(AddIpAddressesToEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIpAddressesToEgressProxyIpPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向出口代理地址池添加IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddIpAddressesToEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// AddIpAddressesToEgressProxyIpPoolResponse
        /// </returns>
        public async Task<AddIpAddressesToEgressProxyIpPoolResponse> AddIpAddressesToEgressProxyIpPoolAsync(AddIpAddressesToEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIpAddressesToEgressProxyIpPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches egress proxy rule groups to an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to attach egress proxy rule groups to an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation attaches one or more egress proxy rule groups to a specified egress proxy configuration and specifies the priority of each egress proxy rule group in the egress proxy configuration.</description></item>
        /// <item><description>The <b>AttachEgressProxyRuleGroupsToConfiguration</b> operation is asynchronous. After you send the request, the system returns a response, but the egress proxy rule groups are not yet attached. The attachment task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the attachment is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachEgressProxyRuleGroupsToConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachEgressProxyRuleGroupsToConfigurationResponse
        /// </returns>
        public AttachEgressProxyRuleGroupsToConfigurationResponse AttachEgressProxyRuleGroupsToConfigurationWithOptions(AttachEgressProxyRuleGroupsToConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroups))
            {
                bodyFlat["EgressProxyRuleGroups"] = request.EgressProxyRuleGroups;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachEgressProxyRuleGroupsToConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachEgressProxyRuleGroupsToConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches egress proxy rule groups to an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to attach egress proxy rule groups to an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation attaches one or more egress proxy rule groups to a specified egress proxy configuration and specifies the priority of each egress proxy rule group in the egress proxy configuration.</description></item>
        /// <item><description>The <b>AttachEgressProxyRuleGroupsToConfiguration</b> operation is asynchronous. After you send the request, the system returns a response, but the egress proxy rule groups are not yet attached. The attachment task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the attachment is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachEgressProxyRuleGroupsToConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachEgressProxyRuleGroupsToConfigurationResponse
        /// </returns>
        public async Task<AttachEgressProxyRuleGroupsToConfigurationResponse> AttachEgressProxyRuleGroupsToConfigurationWithOptionsAsync(AttachEgressProxyRuleGroupsToConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroups))
            {
                bodyFlat["EgressProxyRuleGroups"] = request.EgressProxyRuleGroups;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachEgressProxyRuleGroupsToConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachEgressProxyRuleGroupsToConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches egress proxy rule groups to an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to attach egress proxy rule groups to an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation attaches one or more egress proxy rule groups to a specified egress proxy configuration and specifies the priority of each egress proxy rule group in the egress proxy configuration.</description></item>
        /// <item><description>The <b>AttachEgressProxyRuleGroupsToConfiguration</b> operation is asynchronous. After you send the request, the system returns a response, but the egress proxy rule groups are not yet attached. The attachment task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the attachment is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachEgressProxyRuleGroupsToConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachEgressProxyRuleGroupsToConfigurationResponse
        /// </returns>
        public AttachEgressProxyRuleGroupsToConfigurationResponse AttachEgressProxyRuleGroupsToConfiguration(AttachEgressProxyRuleGroupsToConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachEgressProxyRuleGroupsToConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches egress proxy rule groups to an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to attach egress proxy rule groups to an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation attaches one or more egress proxy rule groups to a specified egress proxy configuration and specifies the priority of each egress proxy rule group in the egress proxy configuration.</description></item>
        /// <item><description>The <b>AttachEgressProxyRuleGroupsToConfiguration</b> operation is asynchronous. After you send the request, the system returns a response, but the egress proxy rule groups are not yet attached. The attachment task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the attachment is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachEgressProxyRuleGroupsToConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachEgressProxyRuleGroupsToConfigurationResponse
        /// </returns>
        public async Task<AttachEgressProxyRuleGroupsToConfigurationResponse> AttachEgressProxyRuleGroupsToConfigurationAsync(AttachEgressProxyRuleGroupsToConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachEgressProxyRuleGroupsToConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The <b>CreateEgressProxyConfiguration</b> operation is asynchronous. After you call this operation, the system returns the ID of the egress proxy configuration, but the configuration is not yet created. The creation task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Provisioning</b> state, the configuration is being created.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the configuration is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyConfigurationResponse
        /// </returns>
        public CreateEgressProxyConfigurationResponse CreateEgressProxyConfigurationWithOptions(CreateEgressProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRulePhaseActions))
            {
                bodyFlat["DefaultRulePhaseActions"] = request.DefaultRulePhaseActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationName))
            {
                body["EgressProxyConfigurationName"] = request.EgressProxyConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The <b>CreateEgressProxyConfiguration</b> operation is asynchronous. After you call this operation, the system returns the ID of the egress proxy configuration, but the configuration is not yet created. The creation task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Provisioning</b> state, the configuration is being created.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the configuration is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyConfigurationResponse
        /// </returns>
        public async Task<CreateEgressProxyConfigurationResponse> CreateEgressProxyConfigurationWithOptionsAsync(CreateEgressProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRulePhaseActions))
            {
                bodyFlat["DefaultRulePhaseActions"] = request.DefaultRulePhaseActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationName))
            {
                body["EgressProxyConfigurationName"] = request.EgressProxyConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The <b>CreateEgressProxyConfiguration</b> operation is asynchronous. After you call this operation, the system returns the ID of the egress proxy configuration, but the configuration is not yet created. The creation task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Provisioning</b> state, the configuration is being created.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the configuration is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyConfigurationResponse
        /// </returns>
        public CreateEgressProxyConfigurationResponse CreateEgressProxyConfiguration(CreateEgressProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEgressProxyConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The <b>CreateEgressProxyConfiguration</b> operation is asynchronous. After you call this operation, the system returns the ID of the egress proxy configuration, but the configuration is not yet created. The creation task is still running in the background. You can call GetEgressProxyConfigurationAttribute to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Provisioning</b> state, the configuration is being created.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the configuration is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyConfigurationResponse
        /// </returns>
        public async Task<CreateEgressProxyConfigurationResponse> CreateEgressProxyConfigurationAsync(CreateEgressProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEgressProxyConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <b>CreateEgressProxyGateway</b> operation is asynchronous. After you call this operation, the system returns an instance ID, but the egress proxy gateway instance is not yet created and the creation task is still running in the background. You can call GetEgressProxyGatewayAttribute to query the creation status of the egress proxy gateway instance:</para>
        /// <list type="bullet">
        /// <item><description>When the egress proxy gateway instance is in the <b>Provisioning</b> state, the instance is being created.</description></item>
        /// <item><description>When the egress proxy gateway instance is in the <b>Active</b> state, the instance is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyGatewayResponse
        /// </returns>
        public CreateEgressProxyGatewayResponse CreateEgressProxyGatewayWithOptions(CreateEgressProxyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayName))
            {
                body["EgressProxyGatewayName"] = request.EgressProxyGatewayName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProperties))
            {
                bodyFlat["ListenerProperties"] = request.ListenerProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsInterceptProperties))
            {
                bodyFlat["TlsInterceptProperties"] = request.TlsInterceptProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyGateway",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <b>CreateEgressProxyGateway</b> operation is asynchronous. After you call this operation, the system returns an instance ID, but the egress proxy gateway instance is not yet created and the creation task is still running in the background. You can call GetEgressProxyGatewayAttribute to query the creation status of the egress proxy gateway instance:</para>
        /// <list type="bullet">
        /// <item><description>When the egress proxy gateway instance is in the <b>Provisioning</b> state, the instance is being created.</description></item>
        /// <item><description>When the egress proxy gateway instance is in the <b>Active</b> state, the instance is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyGatewayResponse
        /// </returns>
        public async Task<CreateEgressProxyGatewayResponse> CreateEgressProxyGatewayWithOptionsAsync(CreateEgressProxyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayName))
            {
                body["EgressProxyGatewayName"] = request.EgressProxyGatewayName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProperties))
            {
                bodyFlat["ListenerProperties"] = request.ListenerProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsInterceptProperties))
            {
                bodyFlat["TlsInterceptProperties"] = request.TlsInterceptProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyGateway",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <b>CreateEgressProxyGateway</b> operation is asynchronous. After you call this operation, the system returns an instance ID, but the egress proxy gateway instance is not yet created and the creation task is still running in the background. You can call GetEgressProxyGatewayAttribute to query the creation status of the egress proxy gateway instance:</para>
        /// <list type="bullet">
        /// <item><description>When the egress proxy gateway instance is in the <b>Provisioning</b> state, the instance is being created.</description></item>
        /// <item><description>When the egress proxy gateway instance is in the <b>Active</b> state, the instance is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyGatewayResponse
        /// </returns>
        public CreateEgressProxyGatewayResponse CreateEgressProxyGateway(CreateEgressProxyGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEgressProxyGatewayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <b>CreateEgressProxyGateway</b> operation is asynchronous. After you call this operation, the system returns an instance ID, but the egress proxy gateway instance is not yet created and the creation task is still running in the background. You can call GetEgressProxyGatewayAttribute to query the creation status of the egress proxy gateway instance:</para>
        /// <list type="bullet">
        /// <item><description>When the egress proxy gateway instance is in the <b>Provisioning</b> state, the instance is being created.</description></item>
        /// <item><description>When the egress proxy gateway instance is in the <b>Active</b> state, the instance is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyGatewayResponse
        /// </returns>
        public async Task<CreateEgressProxyGatewayResponse> CreateEgressProxyGatewayAsync(CreateEgressProxyGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEgressProxyGatewayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建出口代理地址池</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyIpPoolResponse
        /// </returns>
        public CreateEgressProxyIpPoolResponse CreateEgressProxyIpPoolWithOptions(CreateEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                body["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolName))
            {
                body["EgressProxyIpPoolName"] = request.EgressProxyIpPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashFactor))
            {
                body["HashFactor"] = request.HashFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashHeaderName))
            {
                body["HashHeaderName"] = request.HashHeaderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyIpPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建出口代理地址池</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyIpPoolResponse
        /// </returns>
        public async Task<CreateEgressProxyIpPoolResponse> CreateEgressProxyIpPoolWithOptionsAsync(CreateEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                body["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolName))
            {
                body["EgressProxyIpPoolName"] = request.EgressProxyIpPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashFactor))
            {
                body["HashFactor"] = request.HashFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashHeaderName))
            {
                body["HashHeaderName"] = request.HashHeaderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyIpPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建出口代理地址池</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyIpPoolResponse
        /// </returns>
        public CreateEgressProxyIpPoolResponse CreateEgressProxyIpPool(CreateEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEgressProxyIpPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建出口代理地址池</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyIpPoolResponse
        /// </returns>
        public async Task<CreateEgressProxyIpPoolResponse> CreateEgressProxyIpPoolAsync(CreateEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEgressProxyIpPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress rule group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress rule group, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can create egress rules in batches by phase (PreDns, PreRequest, and PostResponse) when you create the rule group.</description></item>
        /// <item><description>Within the same phase of a rule group, rule priorities (Priority) must be unique. Valid values: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the ID of the egress rule group, but the rule group is not yet created. The creation task is still running in the background. You can call GetEgressProxyRuleGroupAttribute to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rule group is being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rule group is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRuleGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRuleGroupResponse
        /// </returns>
        public CreateEgressProxyRuleGroupResponse CreateEgressProxyRuleGroupWithOptions(CreateEgressProxyRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupName))
            {
                body["EgressProxyRuleGroupName"] = request.EgressProxyRuleGroupName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRules))
            {
                bodyFlat["EgressProxyRules"] = request.EgressProxyRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyRuleGroup",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyRuleGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress rule group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress rule group, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can create egress rules in batches by phase (PreDns, PreRequest, and PostResponse) when you create the rule group.</description></item>
        /// <item><description>Within the same phase of a rule group, rule priorities (Priority) must be unique. Valid values: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the ID of the egress rule group, but the rule group is not yet created. The creation task is still running in the background. You can call GetEgressProxyRuleGroupAttribute to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rule group is being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rule group is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRuleGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRuleGroupResponse
        /// </returns>
        public async Task<CreateEgressProxyRuleGroupResponse> CreateEgressProxyRuleGroupWithOptionsAsync(CreateEgressProxyRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupName))
            {
                body["EgressProxyRuleGroupName"] = request.EgressProxyRuleGroupName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRules))
            {
                bodyFlat["EgressProxyRules"] = request.EgressProxyRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyRuleGroup",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyRuleGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress rule group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress rule group, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can create egress rules in batches by phase (PreDns, PreRequest, and PostResponse) when you create the rule group.</description></item>
        /// <item><description>Within the same phase of a rule group, rule priorities (Priority) must be unique. Valid values: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the ID of the egress rule group, but the rule group is not yet created. The creation task is still running in the background. You can call GetEgressProxyRuleGroupAttribute to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rule group is being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rule group is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRuleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRuleGroupResponse
        /// </returns>
        public CreateEgressProxyRuleGroupResponse CreateEgressProxyRuleGroup(CreateEgressProxyRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEgressProxyRuleGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an egress rule group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create an egress rule group, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can create egress rules in batches by phase (PreDns, PreRequest, and PostResponse) when you create the rule group.</description></item>
        /// <item><description>Within the same phase of a rule group, rule priorities (Priority) must be unique. Valid values: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the ID of the egress rule group, but the rule group is not yet created. The creation task is still running in the background. You can call GetEgressProxyRuleGroupAttribute to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rule group is being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rule group is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRuleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRuleGroupResponse
        /// </returns>
        public async Task<CreateEgressProxyRuleGroupResponse> CreateEgressProxyRuleGroupAsync(CreateEgressProxyRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEgressProxyRuleGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create multiple egress proxy rules in a specified egress rule group, note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Egress rules are created in groups based on the effective phase (PreDns, PreRequest, or PostResponse).</description></item>
        /// <item><description>Within the same effective phase of an egress rule group, the priority of rules must be unique.</description></item>
        /// <item><description>Valid values for the priority: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the IDs of the created egress rules, but the rules are not yet created. The creation task is still running in the background. You can call the GetEgressProxyRuleGroupAttribute operation to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rules are being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRulesResponse
        /// </returns>
        public CreateEgressProxyRulesResponse CreateEgressProxyRulesWithOptions(CreateEgressProxyRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRules))
            {
                bodyFlat["EgressProxyRules"] = request.EgressProxyRules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyRules",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create multiple egress proxy rules in a specified egress rule group, note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Egress rules are created in groups based on the effective phase (PreDns, PreRequest, or PostResponse).</description></item>
        /// <item><description>Within the same effective phase of an egress rule group, the priority of rules must be unique.</description></item>
        /// <item><description>Valid values for the priority: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the IDs of the created egress rules, but the rules are not yet created. The creation task is still running in the background. You can call the GetEgressProxyRuleGroupAttribute operation to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rules are being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRulesResponse
        /// </returns>
        public async Task<CreateEgressProxyRulesResponse> CreateEgressProxyRulesWithOptionsAsync(CreateEgressProxyRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRules))
            {
                bodyFlat["EgressProxyRules"] = request.EgressProxyRules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEgressProxyRules",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEgressProxyRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create multiple egress proxy rules in a specified egress rule group, note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Egress rules are created in groups based on the effective phase (PreDns, PreRequest, or PostResponse).</description></item>
        /// <item><description>Within the same effective phase of an egress rule group, the priority of rules must be unique.</description></item>
        /// <item><description>Valid values for the priority: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the IDs of the created egress rules, but the rules are not yet created. The creation task is still running in the background. You can call the GetEgressProxyRuleGroupAttribute operation to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rules are being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRulesResponse
        /// </returns>
        public CreateEgressProxyRulesResponse CreateEgressProxyRules(CreateEgressProxyRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEgressProxyRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to create multiple egress proxy rules in a specified egress rule group, note the following items:</para>
        /// <list type="bullet">
        /// <item><description>Egress rules are created in groups based on the effective phase (PreDns, PreRequest, or PostResponse).</description></item>
        /// <item><description>Within the same effective phase of an egress rule group, the priority of rules must be unique.</description></item>
        /// <item><description>Valid values for the priority: 1 to 1000. A smaller value indicates a higher priority.</description></item>
        /// <item><description>This operation is asynchronous. After you call this operation, the system returns the IDs of the created egress rules, but the rules are not yet created. The creation task is still running in the background. You can call the GetEgressProxyRuleGroupAttribute operation to query the status of the egress rule group:<list type="bullet">
        /// <item><description>If the egress rule group is in the <b>Provisioning</b> state, the rules are being created.</description></item>
        /// <item><description>If the egress rule group is in the <b>Available</b> state, the rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEgressProxyRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEgressProxyRulesResponse
        /// </returns>
        public async Task<CreateEgressProxyRulesResponse> CreateEgressProxyRulesAsync(CreateEgressProxyRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEgressProxyRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyConfigurationResponse
        /// </returns>
        public DeleteEgressProxyConfigurationResponse DeleteEgressProxyConfigurationWithOptions(DeleteEgressProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyConfigurationResponse
        /// </returns>
        public async Task<DeleteEgressProxyConfigurationResponse> DeleteEgressProxyConfigurationWithOptionsAsync(DeleteEgressProxyConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyConfigurationResponse
        /// </returns>
        public DeleteEgressProxyConfigurationResponse DeleteEgressProxyConfiguration(DeleteEgressProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEgressProxyConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyConfigurationResponse
        /// </returns>
        public async Task<DeleteEgressProxyConfigurationResponse> DeleteEgressProxyConfigurationAsync(DeleteEgressProxyConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEgressProxyConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyGatewayId</c> is a required parameter that specifies the egress proxy gateway instance ID to delete.</description></item>
        /// <item><description><c>ClientToken</c> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyGatewayResponse
        /// </returns>
        public DeleteEgressProxyGatewayResponse DeleteEgressProxyGatewayWithOptions(DeleteEgressProxyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyGateway",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyGatewayId</c> is a required parameter that specifies the egress proxy gateway instance ID to delete.</description></item>
        /// <item><description><c>ClientToken</c> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyGatewayResponse
        /// </returns>
        public async Task<DeleteEgressProxyGatewayResponse> DeleteEgressProxyGatewayWithOptionsAsync(DeleteEgressProxyGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyGateway",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyGatewayId</c> is a required parameter that specifies the egress proxy gateway instance ID to delete.</description></item>
        /// <item><description><c>ClientToken</c> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyGatewayResponse
        /// </returns>
        public DeleteEgressProxyGatewayResponse DeleteEgressProxyGateway(DeleteEgressProxyGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEgressProxyGatewayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyGatewayId</c> is a required parameter that specifies the egress proxy gateway instance ID to delete.</description></item>
        /// <item><description><c>ClientToken</c> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyGatewayResponse
        /// </returns>
        public async Task<DeleteEgressProxyGatewayResponse> DeleteEgressProxyGatewayAsync(DeleteEgressProxyGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEgressProxyGatewayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy IP address pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>EgressProxyIpPoolId</b> is a required parameter that specifies the ID of the egress proxy IP address pool to delete.</description></item>
        /// <item><description><b>ClientToken</b> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// <item><description><b>DryRun</b> is an optional parameter. Default value: <c>false</c>. If you set this parameter to <c>true</c>, the system only prechecks the request and does not perform the delete operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyIpPoolResponse
        /// </returns>
        public DeleteEgressProxyIpPoolResponse DeleteEgressProxyIpPoolWithOptions(DeleteEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyIpPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy IP address pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>EgressProxyIpPoolId</b> is a required parameter that specifies the ID of the egress proxy IP address pool to delete.</description></item>
        /// <item><description><b>ClientToken</b> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// <item><description><b>DryRun</b> is an optional parameter. Default value: <c>false</c>. If you set this parameter to <c>true</c>, the system only prechecks the request and does not perform the delete operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyIpPoolResponse
        /// </returns>
        public async Task<DeleteEgressProxyIpPoolResponse> DeleteEgressProxyIpPoolWithOptionsAsync(DeleteEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyIpPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy IP address pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>EgressProxyIpPoolId</b> is a required parameter that specifies the ID of the egress proxy IP address pool to delete.</description></item>
        /// <item><description><b>ClientToken</b> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// <item><description><b>DryRun</b> is an optional parameter. Default value: <c>false</c>. If you set this parameter to <c>true</c>, the system only prechecks the request and does not perform the delete operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyIpPoolResponse
        /// </returns>
        public DeleteEgressProxyIpPoolResponse DeleteEgressProxyIpPool(DeleteEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEgressProxyIpPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy IP address pool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>EgressProxyIpPoolId</b> is a required parameter that specifies the ID of the egress proxy IP address pool to delete.</description></item>
        /// <item><description><b>ClientToken</b> is an optional parameter used to ensure the idempotence of the request.</description></item>
        /// <item><description><b>DryRun</b> is an optional parameter. Default value: <c>false</c>. If you set this parameter to <c>true</c>, the system only prechecks the request and does not perform the delete operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyIpPoolResponse
        /// </returns>
        public async Task<DeleteEgressProxyIpPoolResponse> DeleteEgressProxyIpPoolAsync(DeleteEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEgressProxyIpPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy rule group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRuleGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRuleGroupResponse
        /// </returns>
        public DeleteEgressProxyRuleGroupResponse DeleteEgressProxyRuleGroupWithOptions(DeleteEgressProxyRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyRuleGroup",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyRuleGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy rule group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRuleGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRuleGroupResponse
        /// </returns>
        public async Task<DeleteEgressProxyRuleGroupResponse> DeleteEgressProxyRuleGroupWithOptionsAsync(DeleteEgressProxyRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyRuleGroup",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyRuleGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy rule group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRuleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRuleGroupResponse
        /// </returns>
        public DeleteEgressProxyRuleGroupResponse DeleteEgressProxyRuleGroup(DeleteEgressProxyRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEgressProxyRuleGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an egress proxy rule group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRuleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRuleGroupResponse
        /// </returns>
        public async Task<DeleteEgressProxyRuleGroupResponse> DeleteEgressProxyRuleGroupAsync(DeleteEgressProxyRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEgressProxyRuleGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRulesResponse
        /// </returns>
        public DeleteEgressProxyRulesResponse DeleteEgressProxyRulesWithOptions(DeleteEgressProxyRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleIds))
            {
                bodyFlat["EgressProxyRuleIds"] = request.EgressProxyRuleIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyRules",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRulesResponse
        /// </returns>
        public async Task<DeleteEgressProxyRulesResponse> DeleteEgressProxyRulesWithOptionsAsync(DeleteEgressProxyRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleIds))
            {
                bodyFlat["EgressProxyRuleIds"] = request.EgressProxyRuleIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEgressProxyRules",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEgressProxyRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRulesResponse
        /// </returns>
        public DeleteEgressProxyRulesResponse DeleteEgressProxyRules(DeleteEgressProxyRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEgressProxyRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple egress proxy rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEgressProxyRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEgressProxyRulesResponse
        /// </returns>
        public async Task<DeleteEgressProxyRulesResponse> DeleteEgressProxyRulesAsync(DeleteEgressProxyRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEgressProxyRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2026-07-15",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2026-07-15",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates egress proxy rule groups from an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to disassociate egress proxy rule groups from an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation disassociates one or more egress proxy rule groups from a specified egress proxy configuration. After the disassociation, these egress proxy rule groups no longer take effect in the egress proxy configuration.</description></item>
        /// <item><description>The <b>DetachEgressProxyRuleGroupsFromConfiguration</b> operation is asynchronous. After you send a request, the system returns a response, but the egress proxy rule groups are not yet disassociated. The disassociation task is still running in the background. You can call the GetEgressProxyConfigurationAttribute operation to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the disassociation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachEgressProxyRuleGroupsFromConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachEgressProxyRuleGroupsFromConfigurationResponse
        /// </returns>
        public DetachEgressProxyRuleGroupsFromConfigurationResponse DetachEgressProxyRuleGroupsFromConfigurationWithOptions(DetachEgressProxyRuleGroupsFromConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupIds))
            {
                bodyFlat["EgressProxyRuleGroupIds"] = request.EgressProxyRuleGroupIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachEgressProxyRuleGroupsFromConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachEgressProxyRuleGroupsFromConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates egress proxy rule groups from an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to disassociate egress proxy rule groups from an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation disassociates one or more egress proxy rule groups from a specified egress proxy configuration. After the disassociation, these egress proxy rule groups no longer take effect in the egress proxy configuration.</description></item>
        /// <item><description>The <b>DetachEgressProxyRuleGroupsFromConfiguration</b> operation is asynchronous. After you send a request, the system returns a response, but the egress proxy rule groups are not yet disassociated. The disassociation task is still running in the background. You can call the GetEgressProxyConfigurationAttribute operation to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the disassociation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachEgressProxyRuleGroupsFromConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachEgressProxyRuleGroupsFromConfigurationResponse
        /// </returns>
        public async Task<DetachEgressProxyRuleGroupsFromConfigurationResponse> DetachEgressProxyRuleGroupsFromConfigurationWithOptionsAsync(DetachEgressProxyRuleGroupsFromConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupIds))
            {
                bodyFlat["EgressProxyRuleGroupIds"] = request.EgressProxyRuleGroupIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachEgressProxyRuleGroupsFromConfiguration",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachEgressProxyRuleGroupsFromConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates egress proxy rule groups from an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to disassociate egress proxy rule groups from an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation disassociates one or more egress proxy rule groups from a specified egress proxy configuration. After the disassociation, these egress proxy rule groups no longer take effect in the egress proxy configuration.</description></item>
        /// <item><description>The <b>DetachEgressProxyRuleGroupsFromConfiguration</b> operation is asynchronous. After you send a request, the system returns a response, but the egress proxy rule groups are not yet disassociated. The disassociation task is still running in the background. You can call the GetEgressProxyConfigurationAttribute operation to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the disassociation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachEgressProxyRuleGroupsFromConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachEgressProxyRuleGroupsFromConfigurationResponse
        /// </returns>
        public DetachEgressProxyRuleGroupsFromConfigurationResponse DetachEgressProxyRuleGroupsFromConfiguration(DetachEgressProxyRuleGroupsFromConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachEgressProxyRuleGroupsFromConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates egress proxy rule groups from an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to disassociate egress proxy rule groups from an egress proxy configuration, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation disassociates one or more egress proxy rule groups from a specified egress proxy configuration. After the disassociation, these egress proxy rule groups no longer take effect in the egress proxy configuration.</description></item>
        /// <item><description>The <b>DetachEgressProxyRuleGroupsFromConfiguration</b> operation is asynchronous. After you send a request, the system returns a response, but the egress proxy rule groups are not yet disassociated. The disassociation task is still running in the background. You can call the GetEgressProxyConfigurationAttribute operation to query the status of the egress proxy configuration:<list type="bullet">
        /// <item><description>If the egress proxy configuration is in the <b>Configuring</b> state, the configuration is being updated.</description></item>
        /// <item><description>If the egress proxy configuration is in the <b>Available</b> state, the disassociation is successful.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachEgressProxyRuleGroupsFromConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachEgressProxyRuleGroupsFromConfigurationResponse
        /// </returns>
        public async Task<DetachEgressProxyRuleGroupsFromConfigurationResponse> DetachEgressProxyRuleGroupsFromConfigurationAsync(DetachEgressProxyRuleGroupsFromConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachEgressProxyRuleGroupsFromConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyConfigurationAttribute</em>* is a synchronous API operation that returns the details of a specified egress proxy configuration in real time after the call. You can determine the current status of the egress proxy configuration based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the configuration is being created, and <b>Available</b> indicates that the configuration is created and available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyConfigurationAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyConfigurationAttributeResponse
        /// </returns>
        public GetEgressProxyConfigurationAttributeResponse GetEgressProxyConfigurationAttributeWithOptions(GetEgressProxyConfigurationAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyConfigurationAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyConfigurationAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyConfigurationAttribute</em>* is a synchronous API operation that returns the details of a specified egress proxy configuration in real time after the call. You can determine the current status of the egress proxy configuration based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the configuration is being created, and <b>Available</b> indicates that the configuration is created and available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyConfigurationAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyConfigurationAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyConfigurationAttributeResponse> GetEgressProxyConfigurationAttributeWithOptionsAsync(GetEgressProxyConfigurationAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyConfigurationAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyConfigurationAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyConfigurationAttribute</em>* is a synchronous API operation that returns the details of a specified egress proxy configuration in real time after the call. You can determine the current status of the egress proxy configuration based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the configuration is being created, and <b>Available</b> indicates that the configuration is created and available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyConfigurationAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyConfigurationAttributeResponse
        /// </returns>
        public GetEgressProxyConfigurationAttributeResponse GetEgressProxyConfigurationAttribute(GetEgressProxyConfigurationAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEgressProxyConfigurationAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyConfigurationAttribute</em>* is a synchronous API operation that returns the details of a specified egress proxy configuration in real time after the call. You can determine the current status of the egress proxy configuration based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the configuration is being created, and <b>Available</b> indicates that the configuration is created and available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyConfigurationAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyConfigurationAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyConfigurationAttributeResponse> GetEgressProxyConfigurationAttributeAsync(GetEgressProxyConfigurationAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEgressProxyConfigurationAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyGatewayAttribute</em>* is a synchronous operation that returns the current attribute information of the egress proxy gateway in real time after it is called.
        /// You can determine the current status of the egress proxy gateway based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the instance is being created, <b>Active</b> indicates that the instance is running, <b>Configuring</b> indicates that the instance is being reconfigured, and <b>Inactive</b> indicates that the instance is stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyGatewayAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyGatewayAttributeResponse
        /// </returns>
        public GetEgressProxyGatewayAttributeResponse GetEgressProxyGatewayAttributeWithOptions(GetEgressProxyGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyGatewayAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyGatewayAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyGatewayAttribute</em>* is a synchronous operation that returns the current attribute information of the egress proxy gateway in real time after it is called.
        /// You can determine the current status of the egress proxy gateway based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the instance is being created, <b>Active</b> indicates that the instance is running, <b>Configuring</b> indicates that the instance is being reconfigured, and <b>Inactive</b> indicates that the instance is stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyGatewayAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyGatewayAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyGatewayAttributeResponse> GetEgressProxyGatewayAttributeWithOptionsAsync(GetEgressProxyGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyGatewayAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyGatewayAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyGatewayAttribute</em>* is a synchronous operation that returns the current attribute information of the egress proxy gateway in real time after it is called.
        /// You can determine the current status of the egress proxy gateway based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the instance is being created, <b>Active</b> indicates that the instance is running, <b>Configuring</b> indicates that the instance is being reconfigured, and <b>Inactive</b> indicates that the instance is stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyGatewayAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyGatewayAttributeResponse
        /// </returns>
        public GetEgressProxyGatewayAttributeResponse GetEgressProxyGatewayAttribute(GetEgressProxyGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEgressProxyGatewayAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an egress proxy gateway instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetEgressProxyGatewayAttribute</em>* is a synchronous operation that returns the current attribute information of the egress proxy gateway in real time after it is called.
        /// You can determine the current status of the egress proxy gateway based on the returned <b>Status</b>. For example, <b>Provisioning</b> indicates that the instance is being created, <b>Active</b> indicates that the instance is running, <b>Configuring</b> indicates that the instance is being reconfigured, and <b>Inactive</b> indicates that the instance is stopped.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyGatewayAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyGatewayAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyGatewayAttributeResponse> GetEgressProxyGatewayAttributeAsync(GetEgressProxyGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEgressProxyGatewayAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池详细信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>EgressProxyIpPoolId</c>，可以获取到与该ID关联的出口代理IP池的所有相关信息，包括但不限于名称、描述、网络类型等。请确保提供的<c>EgressProxyIpPoolId</c>是有效的且属于您的账户。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyIpPoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyIpPoolAttributeResponse
        /// </returns>
        public GetEgressProxyIpPoolAttributeResponse GetEgressProxyIpPoolAttributeWithOptions(GetEgressProxyIpPoolAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyIpPoolAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyIpPoolAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池详细信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>EgressProxyIpPoolId</c>，可以获取到与该ID关联的出口代理IP池的所有相关信息，包括但不限于名称、描述、网络类型等。请确保提供的<c>EgressProxyIpPoolId</c>是有效的且属于您的账户。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyIpPoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyIpPoolAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyIpPoolAttributeResponse> GetEgressProxyIpPoolAttributeWithOptionsAsync(GetEgressProxyIpPoolAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyIpPoolAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyIpPoolAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池详细信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>EgressProxyIpPoolId</c>，可以获取到与该ID关联的出口代理IP池的所有相关信息，包括但不限于名称、描述、网络类型等。请确保提供的<c>EgressProxyIpPoolId</c>是有效的且属于您的账户。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyIpPoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyIpPoolAttributeResponse
        /// </returns>
        public GetEgressProxyIpPoolAttributeResponse GetEgressProxyIpPoolAttribute(GetEgressProxyIpPoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEgressProxyIpPoolAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池详细信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>EgressProxyIpPoolId</c>，可以获取到与该ID关联的出口代理IP池的所有相关信息，包括但不限于名称、描述、网络类型等。请确保提供的<c>EgressProxyIpPoolId</c>是有效的且属于您的账户。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEgressProxyIpPoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyIpPoolAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyIpPoolAttributeResponse> GetEgressProxyIpPoolAttributeAsync(GetEgressProxyIpPoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEgressProxyIpPoolAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public GetEgressProxyRuleGroupAttributeResponse GetEgressProxyRuleGroupAttributeWithOptions(GetEgressProxyRuleGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyRuleGroupAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyRuleGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyRuleGroupAttributeResponse> GetEgressProxyRuleGroupAttributeWithOptionsAsync(GetEgressProxyRuleGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEgressProxyRuleGroupAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEgressProxyRuleGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public GetEgressProxyRuleGroupAttributeResponse GetEgressProxyRuleGroupAttribute(GetEgressProxyRuleGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEgressProxyRuleGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public async Task<GetEgressProxyRuleGroupAttributeResponse> GetEgressProxyRuleGroupAttributeAsync(GetEgressProxyRuleGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEgressProxyRuleGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of egress proxy configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ListEgressProxyConfigurations</em>* is a synchronous API operation that returns a list of egress proxy configurations that meet the specified conditions in real time after the call. The returned results are paginated by using <b>MaxResults</b> and <b>NextToken</b>:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, all data has been returned.</description></item>
        /// <item><description>If <b>NextToken</b> has a value, you can use it as the <b>NextToken</b> for the next call to continue the query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyConfigurationsResponse
        /// </returns>
        public ListEgressProxyConfigurationsResponse ListEgressProxyConfigurationsWithOptions(ListEgressProxyConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationIds))
            {
                bodyFlat["EgressProxyConfigurationIds"] = request.EgressProxyConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationNames))
            {
                bodyFlat["EgressProxyConfigurationNames"] = request.EgressProxyConfigurationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyConfigurations",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of egress proxy configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ListEgressProxyConfigurations</em>* is a synchronous API operation that returns a list of egress proxy configurations that meet the specified conditions in real time after the call. The returned results are paginated by using <b>MaxResults</b> and <b>NextToken</b>:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, all data has been returned.</description></item>
        /// <item><description>If <b>NextToken</b> has a value, you can use it as the <b>NextToken</b> for the next call to continue the query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyConfigurationsResponse
        /// </returns>
        public async Task<ListEgressProxyConfigurationsResponse> ListEgressProxyConfigurationsWithOptionsAsync(ListEgressProxyConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationIds))
            {
                bodyFlat["EgressProxyConfigurationIds"] = request.EgressProxyConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationNames))
            {
                bodyFlat["EgressProxyConfigurationNames"] = request.EgressProxyConfigurationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyConfigurations",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of egress proxy configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ListEgressProxyConfigurations</em>* is a synchronous API operation that returns a list of egress proxy configurations that meet the specified conditions in real time after the call. The returned results are paginated by using <b>MaxResults</b> and <b>NextToken</b>:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, all data has been returned.</description></item>
        /// <item><description>If <b>NextToken</b> has a value, you can use it as the <b>NextToken</b> for the next call to continue the query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyConfigurationsResponse
        /// </returns>
        public ListEgressProxyConfigurationsResponse ListEgressProxyConfigurations(ListEgressProxyConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEgressProxyConfigurationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of egress proxy configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ListEgressProxyConfigurations</em>* is a synchronous API operation that returns a list of egress proxy configurations that meet the specified conditions in real time after the call. The returned results are paginated by using <b>MaxResults</b> and <b>NextToken</b>:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, all data has been returned.</description></item>
        /// <item><description>If <b>NextToken</b> has a value, you can use it as the <b>NextToken</b> for the next call to continue the query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyConfigurationsResponse
        /// </returns>
        public async Task<ListEgressProxyConfigurationsResponse> ListEgressProxyConfigurationsAsync(ListEgressProxyConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEgressProxyConfigurationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理网关列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于指定每页返回的最大结果数量，默认值为20，最大可设置为1000。</description></item>
        /// <item><description><c>NextToken</c> 参数用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的结果，默认值为0。</description></item>
        /// <item><description><c>VpcIds</c> 参数允许通过指定一个或多个VPC ID来过滤查询结果，一次最多支持20个ID。</description></item>
        /// <item><description><c>EgressProxyGatewayIds</c> 和 <c>EgressProxyGatewayNames</c> 分别允许通过实例ID和实例名称来过滤查询结果，每次请求中每个参数最多支持20个值。</description></item>
        /// <item><description><c>Status</c> 参数可用于根据实例状态（如Active, Inactive等）进行过滤。</description></item>
        /// <item><description><c>ResourceGroupId</c> 参数允许按资源组ID过滤查询结果。</description></item>
        /// <item><description><c>Tags</c> 参数支持基于标签键值对的过滤条件，可以用来更精确地定位特定资源。
        /// 请注意，所有数组类型的参数在实际使用时需要按照API的具体要求格式化输入数据。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyGatewaysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyGatewaysResponse
        /// </returns>
        public ListEgressProxyGatewaysResponse ListEgressProxyGatewaysWithOptions(ListEgressProxyGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationIds))
            {
                bodyFlat["EgressProxyConfigurationIds"] = request.EgressProxyConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayIds))
            {
                bodyFlat["EgressProxyGatewayIds"] = request.EgressProxyGatewayIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayNames))
            {
                bodyFlat["EgressProxyGatewayNames"] = request.EgressProxyGatewayNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIds))
            {
                bodyFlat["VpcIds"] = request.VpcIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyGateways",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyGatewaysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理网关列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于指定每页返回的最大结果数量，默认值为20，最大可设置为1000。</description></item>
        /// <item><description><c>NextToken</c> 参数用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的结果，默认值为0。</description></item>
        /// <item><description><c>VpcIds</c> 参数允许通过指定一个或多个VPC ID来过滤查询结果，一次最多支持20个ID。</description></item>
        /// <item><description><c>EgressProxyGatewayIds</c> 和 <c>EgressProxyGatewayNames</c> 分别允许通过实例ID和实例名称来过滤查询结果，每次请求中每个参数最多支持20个值。</description></item>
        /// <item><description><c>Status</c> 参数可用于根据实例状态（如Active, Inactive等）进行过滤。</description></item>
        /// <item><description><c>ResourceGroupId</c> 参数允许按资源组ID过滤查询结果。</description></item>
        /// <item><description><c>Tags</c> 参数支持基于标签键值对的过滤条件，可以用来更精确地定位特定资源。
        /// 请注意，所有数组类型的参数在实际使用时需要按照API的具体要求格式化输入数据。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyGatewaysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyGatewaysResponse
        /// </returns>
        public async Task<ListEgressProxyGatewaysResponse> ListEgressProxyGatewaysWithOptionsAsync(ListEgressProxyGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationIds))
            {
                bodyFlat["EgressProxyConfigurationIds"] = request.EgressProxyConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayIds))
            {
                bodyFlat["EgressProxyGatewayIds"] = request.EgressProxyGatewayIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayNames))
            {
                bodyFlat["EgressProxyGatewayNames"] = request.EgressProxyGatewayNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIds))
            {
                bodyFlat["VpcIds"] = request.VpcIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyGateways",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyGatewaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理网关列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于指定每页返回的最大结果数量，默认值为20，最大可设置为1000。</description></item>
        /// <item><description><c>NextToken</c> 参数用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的结果，默认值为0。</description></item>
        /// <item><description><c>VpcIds</c> 参数允许通过指定一个或多个VPC ID来过滤查询结果，一次最多支持20个ID。</description></item>
        /// <item><description><c>EgressProxyGatewayIds</c> 和 <c>EgressProxyGatewayNames</c> 分别允许通过实例ID和实例名称来过滤查询结果，每次请求中每个参数最多支持20个值。</description></item>
        /// <item><description><c>Status</c> 参数可用于根据实例状态（如Active, Inactive等）进行过滤。</description></item>
        /// <item><description><c>ResourceGroupId</c> 参数允许按资源组ID过滤查询结果。</description></item>
        /// <item><description><c>Tags</c> 参数支持基于标签键值对的过滤条件，可以用来更精确地定位特定资源。
        /// 请注意，所有数组类型的参数在实际使用时需要按照API的具体要求格式化输入数据。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyGatewaysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyGatewaysResponse
        /// </returns>
        public ListEgressProxyGatewaysResponse ListEgressProxyGateways(ListEgressProxyGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEgressProxyGatewaysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理网关列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于指定每页返回的最大结果数量，默认值为20，最大可设置为1000。</description></item>
        /// <item><description><c>NextToken</c> 参数用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的结果，默认值为0。</description></item>
        /// <item><description><c>VpcIds</c> 参数允许通过指定一个或多个VPC ID来过滤查询结果，一次最多支持20个ID。</description></item>
        /// <item><description><c>EgressProxyGatewayIds</c> 和 <c>EgressProxyGatewayNames</c> 分别允许通过实例ID和实例名称来过滤查询结果，每次请求中每个参数最多支持20个值。</description></item>
        /// <item><description><c>Status</c> 参数可用于根据实例状态（如Active, Inactive等）进行过滤。</description></item>
        /// <item><description><c>ResourceGroupId</c> 参数允许按资源组ID过滤查询结果。</description></item>
        /// <item><description><c>Tags</c> 参数支持基于标签键值对的过滤条件，可以用来更精确地定位特定资源。
        /// 请注意，所有数组类型的参数在实际使用时需要按照API的具体要求格式化输入数据。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyGatewaysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyGatewaysResponse
        /// </returns>
        public async Task<ListEgressProxyGatewaysResponse> ListEgressProxyGatewaysAsync(ListEgressProxyGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEgressProxyGatewaysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于控制每页返回的结果数量，默认为20，最大值为1000。</description></item>
        /// <item><description><c>NextToken</c> 用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的记录，默认值为0。</description></item>
        /// <item><description>可以通过 <c>EgressProxyGatewayIds</c>, <c>EgressProxyIpPoolIds</c>, <c>EgressProxyIpPoolNames</c> 等参数进行过滤查询。</description></item>
        /// <item><description><c>Status</c> 参数支持按状态过滤结果。</description></item>
        /// <item><description><c>Tags</c> 参数可用于更细粒度的资源筛选。</description></item>
        /// <item><description>返回结果中包含 <c>NextToken</c> 以便于继续请求后续页面的数据。</description></item>
        /// <item><description><c>CreateTime</c> 字段表示的是UTC时间格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyIpPoolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyIpPoolsResponse
        /// </returns>
        public ListEgressProxyIpPoolsResponse ListEgressProxyIpPoolsWithOptions(ListEgressProxyIpPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayIds))
            {
                bodyFlat["EgressProxyGatewayIds"] = request.EgressProxyGatewayIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolIds))
            {
                bodyFlat["EgressProxyIpPoolIds"] = request.EgressProxyIpPoolIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolNames))
            {
                bodyFlat["EgressProxyIpPoolNames"] = request.EgressProxyIpPoolNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyIpPools",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyIpPoolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于控制每页返回的结果数量，默认为20，最大值为1000。</description></item>
        /// <item><description><c>NextToken</c> 用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的记录，默认值为0。</description></item>
        /// <item><description>可以通过 <c>EgressProxyGatewayIds</c>, <c>EgressProxyIpPoolIds</c>, <c>EgressProxyIpPoolNames</c> 等参数进行过滤查询。</description></item>
        /// <item><description><c>Status</c> 参数支持按状态过滤结果。</description></item>
        /// <item><description><c>Tags</c> 参数可用于更细粒度的资源筛选。</description></item>
        /// <item><description>返回结果中包含 <c>NextToken</c> 以便于继续请求后续页面的数据。</description></item>
        /// <item><description><c>CreateTime</c> 字段表示的是UTC时间格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyIpPoolsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyIpPoolsResponse
        /// </returns>
        public async Task<ListEgressProxyIpPoolsResponse> ListEgressProxyIpPoolsWithOptionsAsync(ListEgressProxyIpPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayIds))
            {
                bodyFlat["EgressProxyGatewayIds"] = request.EgressProxyGatewayIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolIds))
            {
                bodyFlat["EgressProxyIpPoolIds"] = request.EgressProxyIpPoolIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolNames))
            {
                bodyFlat["EgressProxyIpPoolNames"] = request.EgressProxyIpPoolNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyIpPools",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyIpPoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于控制每页返回的结果数量，默认为20，最大值为1000。</description></item>
        /// <item><description><c>NextToken</c> 用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的记录，默认值为0。</description></item>
        /// <item><description>可以通过 <c>EgressProxyGatewayIds</c>, <c>EgressProxyIpPoolIds</c>, <c>EgressProxyIpPoolNames</c> 等参数进行过滤查询。</description></item>
        /// <item><description><c>Status</c> 参数支持按状态过滤结果。</description></item>
        /// <item><description><c>Tags</c> 参数可用于更细粒度的资源筛选。</description></item>
        /// <item><description>返回结果中包含 <c>NextToken</c> 以便于继续请求后续页面的数据。</description></item>
        /// <item><description><c>CreateTime</c> 字段表示的是UTC时间格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyIpPoolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyIpPoolsResponse
        /// </returns>
        public ListEgressProxyIpPoolsResponse ListEgressProxyIpPools(ListEgressProxyIpPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEgressProxyIpPoolsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理地址池列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>MaxResults</c> 参数用于控制每页返回的结果数量，默认为20，最大值为1000。</description></item>
        /// <item><description><c>NextToken</c> 用于分页查询时获取下一页的数据。</description></item>
        /// <item><description><c>Skip</c> 参数用于跳过指定数量的记录，默认值为0。</description></item>
        /// <item><description>可以通过 <c>EgressProxyGatewayIds</c>, <c>EgressProxyIpPoolIds</c>, <c>EgressProxyIpPoolNames</c> 等参数进行过滤查询。</description></item>
        /// <item><description><c>Status</c> 参数支持按状态过滤结果。</description></item>
        /// <item><description><c>Tags</c> 参数可用于更细粒度的资源筛选。</description></item>
        /// <item><description>返回结果中包含 <c>NextToken</c> 以便于继续请求后续页面的数据。</description></item>
        /// <item><description><c>CreateTime</c> 字段表示的是UTC时间格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEgressProxyIpPoolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyIpPoolsResponse
        /// </returns>
        public async Task<ListEgressProxyIpPoolsResponse> ListEgressProxyIpPoolsAsync(ListEgressProxyIpPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEgressProxyIpPoolsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEgressProxyRuleGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyRuleGroupsResponse
        /// </returns>
        public ListEgressProxyRuleGroupsResponse ListEgressProxyRuleGroupsWithOptions(ListEgressProxyRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupIds))
            {
                bodyFlat["EgressProxyRuleGroupIds"] = request.EgressProxyRuleGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupNames))
            {
                bodyFlat["EgressProxyRuleGroupNames"] = request.EgressProxyRuleGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyRuleGroups",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyRuleGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEgressProxyRuleGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyRuleGroupsResponse
        /// </returns>
        public async Task<ListEgressProxyRuleGroupsResponse> ListEgressProxyRuleGroupsWithOptionsAsync(ListEgressProxyRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupIds))
            {
                bodyFlat["EgressProxyRuleGroupIds"] = request.EgressProxyRuleGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupNames))
            {
                bodyFlat["EgressProxyRuleGroupNames"] = request.EgressProxyRuleGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEgressProxyRuleGroups",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEgressProxyRuleGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEgressProxyRuleGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyRuleGroupsResponse
        /// </returns>
        public ListEgressProxyRuleGroupsResponse ListEgressProxyRuleGroups(ListEgressProxyRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEgressProxyRuleGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询出口代理规则组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEgressProxyRuleGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEgressProxyRuleGroupsResponse
        /// </returns>
        public async Task<ListEgressProxyRuleGroupsResponse> ListEgressProxyRuleGroupsAsync(ListEgressProxyRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEgressProxyRuleGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags bound to the specified resources.</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                bodyFlat["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2026-07-15",
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
        /// <para>Queries the tags bound to the specified resources.</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                bodyFlat["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2026-07-15",
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
        /// <para>Queries the tags bound to the specified resources.</para>
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
        /// <para>Queries the tags bound to the specified resources.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a resource belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Shifts a resource to another resource group. After the shift, the resource belongs to the new resource group. For valid values of the ResourceType parameter, see the metric description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a resource belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Shifts a resource to another resource group. After the shift, the resource belongs to the new resource group. For valid values of the ResourceType parameter, see the metric description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a resource belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Shifts a resource to another resource group. After the shift, the resource belongs to the new resource group. For valid values of the ResourceType parameter, see the metric description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a resource belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Shifts a resource to another resource group. After the shift, the resource belongs to the new resource group. For valid values of the ResourceType parameter, see the metric description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从出口代理地址池移除IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveIpAddressesFromEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveIpAddressesFromEgressProxyIpPoolResponse
        /// </returns>
        public RemoveIpAddressesFromEgressProxyIpPoolResponse RemoveIpAddressesFromEgressProxyIpPoolWithOptions(RemoveIpAddressesFromEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveIpAddressesFromEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveIpAddressesFromEgressProxyIpPoolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从出口代理地址池移除IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveIpAddressesFromEgressProxyIpPoolRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveIpAddressesFromEgressProxyIpPoolResponse
        /// </returns>
        public async Task<RemoveIpAddressesFromEgressProxyIpPoolResponse> RemoveIpAddressesFromEgressProxyIpPoolWithOptionsAsync(RemoveIpAddressesFromEgressProxyIpPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                bodyFlat["ZoneMappings"] = request.ZoneMappings;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveIpAddressesFromEgressProxyIpPool",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveIpAddressesFromEgressProxyIpPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从出口代理地址池移除IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveIpAddressesFromEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveIpAddressesFromEgressProxyIpPoolResponse
        /// </returns>
        public RemoveIpAddressesFromEgressProxyIpPoolResponse RemoveIpAddressesFromEgressProxyIpPool(RemoveIpAddressesFromEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveIpAddressesFromEgressProxyIpPoolWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从出口代理地址池移除IP地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveIpAddressesFromEgressProxyIpPoolRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveIpAddressesFromEgressProxyIpPoolResponse
        /// </returns>
        public async Task<RemoveIpAddressesFromEgressProxyIpPoolResponse> RemoveIpAddressesFromEgressProxyIpPoolAsync(RemoveIpAddressesFromEgressProxyIpPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveIpAddressesFromEgressProxyIpPoolWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and attaches tags to a specified list of resources.</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                bodyFlat["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2026-07-15",
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
        /// <para>Creates and attaches tags to a specified list of resources.</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                bodyFlat["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2026-07-15",
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
        /// <para>Creates and attaches tags to a specified list of resources.</para>
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
        /// <para>Creates and attaches tags to a specified list of resources.</para>
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
        /// <para>Removes tags from the specified resources.</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                bodyFlat["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                bodyFlat["TagKey"] = request.TagKey;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2026-07-15",
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
        /// <para>Removes tags from the specified resources.</para>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                bodyFlat["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                bodyFlat["TagKey"] = request.TagKey;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2026-07-15",
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
        /// <para>Removes tags from the specified resources.</para>
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
        /// <para>Removes tags from the specified resources.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理配置属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyConfigurationAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyConfigurationAttributeResponse
        /// </returns>
        public UpdateEgressProxyConfigurationAttributeResponse UpdateEgressProxyConfigurationAttributeWithOptions(UpdateEgressProxyConfigurationAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRulePhaseActions))
            {
                bodyFlat["DefaultRulePhaseActions"] = request.DefaultRulePhaseActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationName))
            {
                body["EgressProxyConfigurationName"] = request.EgressProxyConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroups))
            {
                bodyFlat["EgressProxyRuleGroups"] = request.EgressProxyRuleGroups;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyConfigurationAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyConfigurationAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理配置属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyConfigurationAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyConfigurationAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyConfigurationAttributeResponse> UpdateEgressProxyConfigurationAttributeWithOptionsAsync(UpdateEgressProxyConfigurationAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRulePhaseActions))
            {
                bodyFlat["DefaultRulePhaseActions"] = request.DefaultRulePhaseActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationId))
            {
                body["EgressProxyConfigurationId"] = request.EgressProxyConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyConfigurationName))
            {
                body["EgressProxyConfigurationName"] = request.EgressProxyConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroups))
            {
                bodyFlat["EgressProxyRuleGroups"] = request.EgressProxyRuleGroups;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyConfigurationAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyConfigurationAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理配置属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyConfigurationAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyConfigurationAttributeResponse
        /// </returns>
        public UpdateEgressProxyConfigurationAttributeResponse UpdateEgressProxyConfigurationAttribute(UpdateEgressProxyConfigurationAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEgressProxyConfigurationAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理配置属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyConfigurationAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyConfigurationAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyConfigurationAttributeResponse> UpdateEgressProxyConfigurationAttributeAsync(UpdateEgressProxyConfigurationAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEgressProxyConfigurationAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改出口代理网关属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyGatewayAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyGatewayAttributeResponse
        /// </returns>
        public UpdateEgressProxyGatewayAttributeResponse UpdateEgressProxyGatewayAttributeWithOptions(UpdateEgressProxyGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddListenerProperties))
            {
                bodyFlat["AddListenerProperties"] = request.AddListenerProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultEgressProxyIpPoolId))
            {
                body["DefaultEgressProxyIpPoolId"] = request.DefaultEgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayName))
            {
                body["EgressProxyGatewayName"] = request.EgressProxyGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveListenerProperties))
            {
                bodyFlat["RemoveListenerProperties"] = request.RemoveListenerProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsInterceptProperties))
            {
                bodyFlat["TlsInterceptProperties"] = request.TlsInterceptProperties;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyGatewayAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyGatewayAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改出口代理网关属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyGatewayAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyGatewayAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyGatewayAttributeResponse> UpdateEgressProxyGatewayAttributeWithOptionsAsync(UpdateEgressProxyGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddListenerProperties))
            {
                bodyFlat["AddListenerProperties"] = request.AddListenerProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultEgressProxyIpPoolId))
            {
                body["DefaultEgressProxyIpPoolId"] = request.DefaultEgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayId))
            {
                body["EgressProxyGatewayId"] = request.EgressProxyGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyGatewayName))
            {
                body["EgressProxyGatewayName"] = request.EgressProxyGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveListenerProperties))
            {
                bodyFlat["RemoveListenerProperties"] = request.RemoveListenerProperties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsInterceptProperties))
            {
                bodyFlat["TlsInterceptProperties"] = request.TlsInterceptProperties;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyGatewayAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyGatewayAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改出口代理网关属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyGatewayAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyGatewayAttributeResponse
        /// </returns>
        public UpdateEgressProxyGatewayAttributeResponse UpdateEgressProxyGatewayAttribute(UpdateEgressProxyGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEgressProxyGatewayAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改出口代理网关属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyGatewayAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyGatewayAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyGatewayAttributeResponse> UpdateEgressProxyGatewayAttributeAsync(UpdateEgressProxyGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEgressProxyGatewayAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理地址池属性</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyIpPoolId</c> 是必填参数，用来指定要更新的出口地址池ID。</description></item>
        /// <item><description><c>DryRun</c> 参数可以设置为 <c>true</c> 来预检此次请求而不实际执行更改，默认值为 <c>false</c>。</description></item>
        /// <item><description><c>Scheduler</c> 和 <c>HashFactor</c> 参数用于定义出口IP的选择逻辑及相关的哈希因子，可根据具体需求进行设置。</description></item>
        /// <item><description>其他参数如 <c>EgressProxyIpPoolName</c>, <c>Description</c> 等均为可选项，提供给用户根据需要自定义出口地址池的名字和描述等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyIpPoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyIpPoolAttributeResponse
        /// </returns>
        public UpdateEgressProxyIpPoolAttributeResponse UpdateEgressProxyIpPoolAttributeWithOptions(UpdateEgressProxyIpPoolAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolName))
            {
                body["EgressProxyIpPoolName"] = request.EgressProxyIpPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashFactor))
            {
                body["HashFactor"] = request.HashFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashHeaderName))
            {
                body["HashHeaderName"] = request.HashHeaderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyIpPoolAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyIpPoolAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理地址池属性</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyIpPoolId</c> 是必填参数，用来指定要更新的出口地址池ID。</description></item>
        /// <item><description><c>DryRun</c> 参数可以设置为 <c>true</c> 来预检此次请求而不实际执行更改，默认值为 <c>false</c>。</description></item>
        /// <item><description><c>Scheduler</c> 和 <c>HashFactor</c> 参数用于定义出口IP的选择逻辑及相关的哈希因子，可根据具体需求进行设置。</description></item>
        /// <item><description>其他参数如 <c>EgressProxyIpPoolName</c>, <c>Description</c> 等均为可选项，提供给用户根据需要自定义出口地址池的名字和描述等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyIpPoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyIpPoolAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyIpPoolAttributeResponse> UpdateEgressProxyIpPoolAttributeWithOptionsAsync(UpdateEgressProxyIpPoolAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolName))
            {
                body["EgressProxyIpPoolName"] = request.EgressProxyIpPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashFactor))
            {
                body["HashFactor"] = request.HashFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HashHeaderName))
            {
                body["HashHeaderName"] = request.HashHeaderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyIpPoolAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyIpPoolAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理地址池属性</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyIpPoolId</c> 是必填参数，用来指定要更新的出口地址池ID。</description></item>
        /// <item><description><c>DryRun</c> 参数可以设置为 <c>true</c> 来预检此次请求而不实际执行更改，默认值为 <c>false</c>。</description></item>
        /// <item><description><c>Scheduler</c> 和 <c>HashFactor</c> 参数用于定义出口IP的选择逻辑及相关的哈希因子，可根据具体需求进行设置。</description></item>
        /// <item><description>其他参数如 <c>EgressProxyIpPoolName</c>, <c>Description</c> 等均为可选项，提供给用户根据需要自定义出口地址池的名字和描述等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyIpPoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyIpPoolAttributeResponse
        /// </returns>
        public UpdateEgressProxyIpPoolAttributeResponse UpdateEgressProxyIpPoolAttribute(UpdateEgressProxyIpPoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEgressProxyIpPoolAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理地址池属性</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>EgressProxyIpPoolId</c> 是必填参数，用来指定要更新的出口地址池ID。</description></item>
        /// <item><description><c>DryRun</c> 参数可以设置为 <c>true</c> 来预检此次请求而不实际执行更改，默认值为 <c>false</c>。</description></item>
        /// <item><description><c>Scheduler</c> 和 <c>HashFactor</c> 参数用于定义出口IP的选择逻辑及相关的哈希因子，可根据具体需求进行设置。</description></item>
        /// <item><description>其他参数如 <c>EgressProxyIpPoolName</c>, <c>Description</c> 等均为可选项，提供给用户根据需要自定义出口地址池的名字和描述等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyIpPoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyIpPoolAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyIpPoolAttributeResponse> UpdateEgressProxyIpPoolAttributeAsync(UpdateEgressProxyIpPoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEgressProxyIpPoolAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理规则组属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public UpdateEgressProxyRuleGroupAttributeResponse UpdateEgressProxyRuleGroupAttributeWithOptions(UpdateEgressProxyRuleGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupName))
            {
                body["EgressProxyRuleGroupName"] = request.EgressProxyRuleGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyRuleGroupAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyRuleGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理规则组属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyRuleGroupAttributeResponse> UpdateEgressProxyRuleGroupAttributeWithOptionsAsync(UpdateEgressProxyRuleGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyIpPoolId))
            {
                body["EgressProxyIpPoolId"] = request.EgressProxyIpPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupName))
            {
                body["EgressProxyRuleGroupName"] = request.EgressProxyRuleGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyRuleGroupAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyRuleGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理规则组属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public UpdateEgressProxyRuleGroupAttributeResponse UpdateEgressProxyRuleGroupAttribute(UpdateEgressProxyRuleGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEgressProxyRuleGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新出口代理规则组属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRuleGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRuleGroupAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyRuleGroupAttributeResponse> UpdateEgressProxyRuleGroupAttributeAsync(UpdateEgressProxyRuleGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEgressProxyRuleGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新出口代理规则属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRulesAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRulesAttributeResponse
        /// </returns>
        public UpdateEgressProxyRulesAttributeResponse UpdateEgressProxyRulesAttributeWithOptions(UpdateEgressProxyRulesAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRules))
            {
                bodyFlat["EgressProxyRules"] = request.EgressProxyRules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyRulesAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyRulesAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新出口代理规则属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRulesAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRulesAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyRulesAttributeResponse> UpdateEgressProxyRulesAttributeWithOptionsAsync(UpdateEgressProxyRulesAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRuleGroupId))
            {
                body["EgressProxyRuleGroupId"] = request.EgressProxyRuleGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressProxyRules))
            {
                bodyFlat["EgressProxyRules"] = request.EgressProxyRules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEgressProxyRulesAttribute",
                Version = "2026-07-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEgressProxyRulesAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新出口代理规则属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRulesAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRulesAttributeResponse
        /// </returns>
        public UpdateEgressProxyRulesAttributeResponse UpdateEgressProxyRulesAttribute(UpdateEgressProxyRulesAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEgressProxyRulesAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新出口代理规则属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEgressProxyRulesAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEgressProxyRulesAttributeResponse
        /// </returns>
        public async Task<UpdateEgressProxyRulesAttributeResponse> UpdateEgressProxyRulesAttributeAsync(UpdateEgressProxyRulesAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEgressProxyRulesAttributeWithOptionsAsync(request, runtime);
        }

    }
}
