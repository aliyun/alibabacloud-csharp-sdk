// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Privatelink20200415.Models;

namespace AlibabaCloud.SDK.Privatelink20200415
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("privatelink", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds an account ID to the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add an account ID to the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddUserToVpcEndpointService</b> operation to add the ID of an Alibaba Cloud account to the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToVpcEndpointServiceResponse
        /// </returns>
        public AddUserToVpcEndpointServiceResponse AddUserToVpcEndpointServiceWithOptions(AddUserToVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserARN))
            {
                query["UserARN"] = request.UserARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToVpcEndpointServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an account ID to the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add an account ID to the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddUserToVpcEndpointService</b> operation to add the ID of an Alibaba Cloud account to the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToVpcEndpointServiceResponse
        /// </returns>
        public async Task<AddUserToVpcEndpointServiceResponse> AddUserToVpcEndpointServiceWithOptionsAsync(AddUserToVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserARN))
            {
                query["UserARN"] = request.UserARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToVpcEndpointServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an account ID to the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add an account ID to the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddUserToVpcEndpointService</b> operation to add the ID of an Alibaba Cloud account to the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToVpcEndpointServiceResponse
        /// </returns>
        public AddUserToVpcEndpointServiceResponse AddUserToVpcEndpointService(AddUserToVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToVpcEndpointServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an account ID to the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add an account ID to the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddUserToVpcEndpointService</b> operation to add the ID of an Alibaba Cloud account to the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToVpcEndpointServiceResponse
        /// </returns>
        public async Task<AddUserToVpcEndpointServiceResponse> AddUserToVpcEndpointServiceAsync(AddUserToVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToVpcEndpointServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a zone to an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AddZoneToVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the state of the zone.
        ///     *   If the zone is in the <b>Creating</b> state, the zone is being added.
        ///     *   If the zone is in the Wait state, the zone is added.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddZoneToVpcEndpoint</b> operation to add a zone to an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddZoneToVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddZoneToVpcEndpointResponse
        /// </returns>
        public AddZoneToVpcEndpointResponse AddZoneToVpcEndpointWithOptions(AddZoneToVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Address))
            {
                query["Ipv6Address"] = request.Ipv6Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddZoneToVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddZoneToVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a zone to an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AddZoneToVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the state of the zone.
        ///     *   If the zone is in the <b>Creating</b> state, the zone is being added.
        ///     *   If the zone is in the Wait state, the zone is added.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddZoneToVpcEndpoint</b> operation to add a zone to an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddZoneToVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddZoneToVpcEndpointResponse
        /// </returns>
        public async Task<AddZoneToVpcEndpointResponse> AddZoneToVpcEndpointWithOptionsAsync(AddZoneToVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Address))
            {
                query["Ipv6Address"] = request.Ipv6Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddZoneToVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddZoneToVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a zone to an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AddZoneToVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the state of the zone.
        ///     *   If the zone is in the <b>Creating</b> state, the zone is being added.
        ///     *   If the zone is in the Wait state, the zone is added.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddZoneToVpcEndpoint</b> operation to add a zone to an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddZoneToVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// AddZoneToVpcEndpointResponse
        /// </returns>
        public AddZoneToVpcEndpointResponse AddZoneToVpcEndpoint(AddZoneToVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddZoneToVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a zone to an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AddZoneToVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the state of the zone.
        ///     *   If the zone is in the <b>Creating</b> state, the zone is being added.
        ///     *   If the zone is in the Wait state, the zone is added.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AddZoneToVpcEndpoint</b> operation to add a zone to an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddZoneToVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// AddZoneToVpcEndpointResponse
        /// </returns>
        public async Task<AddZoneToVpcEndpointResponse> AddZoneToVpcEndpointAsync(AddZoneToVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddZoneToVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a service resource to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add a service resource to an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachResourceToVpcEndpointService</b> operation to add a service resource to an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachResourceToVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachResourceToVpcEndpointServiceResponse
        /// </returns>
        public AttachResourceToVpcEndpointServiceResponse AttachResourceToVpcEndpointServiceWithOptions(AttachResourceToVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachResourceToVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachResourceToVpcEndpointServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a service resource to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add a service resource to an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachResourceToVpcEndpointService</b> operation to add a service resource to an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachResourceToVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachResourceToVpcEndpointServiceResponse
        /// </returns>
        public async Task<AttachResourceToVpcEndpointServiceResponse> AttachResourceToVpcEndpointServiceWithOptionsAsync(AttachResourceToVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachResourceToVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachResourceToVpcEndpointServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a service resource to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add a service resource to an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachResourceToVpcEndpointService</b> operation to add a service resource to an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachResourceToVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachResourceToVpcEndpointServiceResponse
        /// </returns>
        public AttachResourceToVpcEndpointServiceResponse AttachResourceToVpcEndpointService(AttachResourceToVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachResourceToVpcEndpointServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a service resource to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you add a service resource to an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachResourceToVpcEndpointService</b> operation to add a service resource to an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachResourceToVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachResourceToVpcEndpointServiceResponse
        /// </returns>
        public async Task<AttachResourceToVpcEndpointServiceResponse> AttachResourceToVpcEndpointServiceAsync(AttachResourceToVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachResourceToVpcEndpointServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an endpoint with a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AttachSecurityGroupToVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> operation to query the state of the endpoint.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being associated with the security group.
        ///     *   If the endpoint is in the <b>Active</b> state, the endpoint is associated with the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachSecurityGroupToVpcEndpoint</b> operation to associate an endpoint with a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachSecurityGroupToVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachSecurityGroupToVpcEndpointResponse
        /// </returns>
        public AttachSecurityGroupToVpcEndpointResponse AttachSecurityGroupToVpcEndpointWithOptions(AttachSecurityGroupToVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachSecurityGroupToVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachSecurityGroupToVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an endpoint with a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AttachSecurityGroupToVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> operation to query the state of the endpoint.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being associated with the security group.
        ///     *   If the endpoint is in the <b>Active</b> state, the endpoint is associated with the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachSecurityGroupToVpcEndpoint</b> operation to associate an endpoint with a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachSecurityGroupToVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachSecurityGroupToVpcEndpointResponse
        /// </returns>
        public async Task<AttachSecurityGroupToVpcEndpointResponse> AttachSecurityGroupToVpcEndpointWithOptionsAsync(AttachSecurityGroupToVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachSecurityGroupToVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachSecurityGroupToVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an endpoint with a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AttachSecurityGroupToVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> operation to query the state of the endpoint.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being associated with the security group.
        ///     *   If the endpoint is in the <b>Active</b> state, the endpoint is associated with the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachSecurityGroupToVpcEndpoint</b> operation to associate an endpoint with a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachSecurityGroupToVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachSecurityGroupToVpcEndpointResponse
        /// </returns>
        public AttachSecurityGroupToVpcEndpointResponse AttachSecurityGroupToVpcEndpoint(AttachSecurityGroupToVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachSecurityGroupToVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an endpoint with a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>AttachSecurityGroupToVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> operation to query the state of the endpoint.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being associated with the security group.
        ///     *   If the endpoint is in the <b>Active</b> state, the endpoint is associated with the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>AttachSecurityGroupToVpcEndpoint</b> operation to associate an endpoint with a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachSecurityGroupToVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachSecurityGroupToVpcEndpointResponse
        /// </returns>
        public async Task<AttachSecurityGroupToVpcEndpointResponse> AttachSecurityGroupToVpcEndpointAsync(AttachSecurityGroupToVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachSecurityGroupToVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-04-15",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2020-04-15",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether PrivateLink is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckProductOpenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckProductOpenResponse
        /// </returns>
        public CheckProductOpenResponse CheckProductOpenWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckProductOpen",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckProductOpenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether PrivateLink is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckProductOpenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckProductOpenResponse
        /// </returns>
        public async Task<CheckProductOpenResponse> CheckProductOpenWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckProductOpen",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckProductOpenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether PrivateLink is activated.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckProductOpenResponse
        /// </returns>
        public CheckProductOpenResponse CheckProductOpen()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckProductOpenWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether PrivateLink is activated.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckProductOpenResponse
        /// </returns>
        public async Task<CheckProductOpenResponse> CheckProductOpenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckProductOpenWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateVpcEndpoint</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is created.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint is in the <b>Creating</b> state, the endpoint is being created.</description></item>
        /// <item><description>If the endpoint is in the <b>Active</b> state, the endpoint is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointResponse
        /// </returns>
        public CreateVpcEndpointResponse CreateVpcEndpointWithOptions(CreateVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointDescription))
            {
                query["EndpointDescription"] = request.EndpointDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["EndpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectedEnabled))
            {
                query["ProtectedEnabled"] = request.ProtectedEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                query["Zone"] = request.Zone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZonePrivateIpAddressCount))
            {
                query["ZonePrivateIpAddressCount"] = request.ZonePrivateIpAddressCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateVpcEndpoint</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is created.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint is in the <b>Creating</b> state, the endpoint is being created.</description></item>
        /// <item><description>If the endpoint is in the <b>Active</b> state, the endpoint is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointResponse
        /// </returns>
        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointWithOptionsAsync(CreateVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointDescription))
            {
                query["EndpointDescription"] = request.EndpointDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["EndpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectedEnabled))
            {
                query["ProtectedEnabled"] = request.ProtectedEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                query["Zone"] = request.Zone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZonePrivateIpAddressCount))
            {
                query["ZonePrivateIpAddressCount"] = request.ZonePrivateIpAddressCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateVpcEndpoint</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is created.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint is in the <b>Creating</b> state, the endpoint is being created.</description></item>
        /// <item><description>If the endpoint is in the <b>Active</b> state, the endpoint is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointResponse
        /// </returns>
        public CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateVpcEndpoint</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is created.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint is in the <b>Creating</b> state, the endpoint is being created.</description></item>
        /// <item><description>If the endpoint is in the <b>Active</b> state, the endpoint is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointResponse
        /// </returns>
        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create an endpoint service, make sure that you have created a Server Load Balancer (SLB) instance that supports PrivateLink. For more information, see <a href="https://help.aliyun.com/document_detail/174064.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcEndpointService</b> is an asynchronous operation. After a request is sent, the system returns a request ID and an instance ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Creating</b> state, the endpoint service is being created.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the endpoint service is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointServiceResponse
        /// </returns>
        public CreateVpcEndpointServiceResponse CreateVpcEndpointServiceWithOptions(CreateVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAcceptEnabled))
            {
                query["AutoAcceptEnabled"] = request.AutoAcceptEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payer))
            {
                query["Payer"] = request.Payer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSupportIPv6))
            {
                query["ServiceSupportIPv6"] = request.ServiceSupportIPv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcEndpointServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create an endpoint service, make sure that you have created a Server Load Balancer (SLB) instance that supports PrivateLink. For more information, see <a href="https://help.aliyun.com/document_detail/174064.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcEndpointService</b> is an asynchronous operation. After a request is sent, the system returns a request ID and an instance ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Creating</b> state, the endpoint service is being created.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the endpoint service is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointServiceResponse
        /// </returns>
        public async Task<CreateVpcEndpointServiceResponse> CreateVpcEndpointServiceWithOptionsAsync(CreateVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAcceptEnabled))
            {
                query["AutoAcceptEnabled"] = request.AutoAcceptEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payer))
            {
                query["Payer"] = request.Payer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSupportIPv6))
            {
                query["ServiceSupportIPv6"] = request.ServiceSupportIPv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcEndpointServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create an endpoint service, make sure that you have created a Server Load Balancer (SLB) instance that supports PrivateLink. For more information, see <a href="https://help.aliyun.com/document_detail/174064.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcEndpointService</b> is an asynchronous operation. After a request is sent, the system returns a request ID and an instance ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Creating</b> state, the endpoint service is being created.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the endpoint service is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointServiceResponse
        /// </returns>
        public CreateVpcEndpointServiceResponse CreateVpcEndpointService(CreateVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcEndpointServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create an endpoint service, make sure that you have created a Server Load Balancer (SLB) instance that supports PrivateLink. For more information, see <a href="https://help.aliyun.com/document_detail/174064.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcEndpointService</b> is an asynchronous operation. After a request is sent, the system returns a request ID and an instance ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Creating</b> state, the endpoint service is being created.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the endpoint service is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcEndpointServiceResponse
        /// </returns>
        public async Task<CreateVpcEndpointServiceResponse> CreateVpcEndpointServiceAsync(CreateVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcEndpointServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint, you must delete the zones that are added to the endpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is deleted.<list type="bullet">
        /// <item><description>If the endpoint is in the <b>Deleting</b> state, the endpoint is being deleted.</description></item>
        /// <item><description>If the endpoint cannot be queried, the endpoint is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointResponse
        /// </returns>
        public DeleteVpcEndpointResponse DeleteVpcEndpointWithOptions(DeleteVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DeleteVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint, you must delete the zones that are added to the endpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is deleted.<list type="bullet">
        /// <item><description>If the endpoint is in the <b>Deleting</b> state, the endpoint is being deleted.</description></item>
        /// <item><description>If the endpoint cannot be queried, the endpoint is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointResponse
        /// </returns>
        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointWithOptionsAsync(DeleteVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DeleteVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint, you must delete the zones that are added to the endpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is deleted.<list type="bullet">
        /// <item><description>If the endpoint is in the <b>Deleting</b> state, the endpoint is being deleted.</description></item>
        /// <item><description>If the endpoint cannot be queried, the endpoint is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointResponse
        /// </returns>
        public DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint, you must delete the zones that are added to the endpoint.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to check whether the endpoint is deleted.<list type="bullet">
        /// <item><description>If the endpoint is in the <b>Deleting</b> state, the endpoint is being deleted.</description></item>
        /// <item><description>If the endpoint cannot be queried, the endpoint is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointResponse
        /// </returns>
        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint service, you must disconnect the endpoint from the endpoint service and remove the service resources.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpointService</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to check whether the endpoint service is deleted.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Deleting</b> state, the endpoint service is being deleted.</description></item>
        /// <item><description>If the endpoint service cannot be queried, the endpoint service is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcEndpointService</b> operation to delete an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointServiceResponse
        /// </returns>
        public DeleteVpcEndpointServiceResponse DeleteVpcEndpointServiceWithOptions(DeleteVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcEndpointServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint service, you must disconnect the endpoint from the endpoint service and remove the service resources.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpointService</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to check whether the endpoint service is deleted.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Deleting</b> state, the endpoint service is being deleted.</description></item>
        /// <item><description>If the endpoint service cannot be queried, the endpoint service is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcEndpointService</b> operation to delete an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointServiceResponse
        /// </returns>
        public async Task<DeleteVpcEndpointServiceResponse> DeleteVpcEndpointServiceWithOptionsAsync(DeleteVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcEndpointServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint service, you must disconnect the endpoint from the endpoint service and remove the service resources.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpointService</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to check whether the endpoint service is deleted.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Deleting</b> state, the endpoint service is being deleted.</description></item>
        /// <item><description>If the endpoint service cannot be queried, the endpoint service is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcEndpointService</b> operation to delete an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointServiceResponse
        /// </returns>
        public DeleteVpcEndpointServiceResponse DeleteVpcEndpointService(DeleteVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcEndpointServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you delete an endpoint service, you must disconnect the endpoint from the endpoint service and remove the service resources.</para>
        /// <list type="bullet">
        /// <item><description><b>DeleteVpcEndpointService</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183542.html">GetVpcEndpointServiceAttribute</a> operation to check whether the endpoint service is deleted.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Deleting</b> state, the endpoint service is being deleted.</description></item>
        /// <item><description>If the endpoint service cannot be queried, the endpoint service is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcEndpointService</b> operation to delete an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcEndpointServiceResponse
        /// </returns>
        public async Task<DeleteVpcEndpointServiceResponse> DeleteVpcEndpointServiceAsync(DeleteVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcEndpointServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions and zones.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-04-15",
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
        /// <para>Queries available regions and zones.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-04-15",
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
        /// <para>Queries available regions and zones.</para>
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
        /// <para>Queries available regions and zones.</para>
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
        /// <para>Queries a list of zones in a specified region.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2020-04-15",
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
        /// <para>Queries a list of zones in a specified region.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2020-04-15",
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
        /// <para>Queries a list of zones in a specified region.</para>
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
        /// <para>Queries a list of zones in a specified region.</para>
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
        /// <para>Removes a service resource from an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove a service resource from an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachResourceFromVpcEndpointService</b> operation to remove a service resource from an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachResourceFromVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachResourceFromVpcEndpointServiceResponse
        /// </returns>
        public DetachResourceFromVpcEndpointServiceResponse DetachResourceFromVpcEndpointServiceWithOptions(DetachResourceFromVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachResourceFromVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachResourceFromVpcEndpointServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a service resource from an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove a service resource from an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachResourceFromVpcEndpointService</b> operation to remove a service resource from an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachResourceFromVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachResourceFromVpcEndpointServiceResponse
        /// </returns>
        public async Task<DetachResourceFromVpcEndpointServiceResponse> DetachResourceFromVpcEndpointServiceWithOptionsAsync(DetachResourceFromVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachResourceFromVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachResourceFromVpcEndpointServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a service resource from an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove a service resource from an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachResourceFromVpcEndpointService</b> operation to remove a service resource from an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachResourceFromVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachResourceFromVpcEndpointServiceResponse
        /// </returns>
        public DetachResourceFromVpcEndpointServiceResponse DetachResourceFromVpcEndpointService(DetachResourceFromVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachResourceFromVpcEndpointServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a service resource from an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove a service resource from an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachResourceFromVpcEndpointService</b> operation to remove a service resource from an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachResourceFromVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachResourceFromVpcEndpointServiceResponse
        /// </returns>
        public async Task<DetachResourceFromVpcEndpointServiceResponse> DetachResourceFromVpcEndpointServiceAsync(DetachResourceFromVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachResourceFromVpcEndpointServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an endpoint from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DetachSecurityGroupFromVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> to check whether the endpoint is disassociated from the security group.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being disassociated from the security group.
        ///     *   If you cannot query the endpoint in the security group, the endpoint is disassociated from the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachSecurityGroupFromVpcEndpoint</b> operation to disassociate an endpoint from a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachSecurityGroupFromVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachSecurityGroupFromVpcEndpointResponse
        /// </returns>
        public DetachSecurityGroupFromVpcEndpointResponse DetachSecurityGroupFromVpcEndpointWithOptions(DetachSecurityGroupFromVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachSecurityGroupFromVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachSecurityGroupFromVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an endpoint from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DetachSecurityGroupFromVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> to check whether the endpoint is disassociated from the security group.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being disassociated from the security group.
        ///     *   If you cannot query the endpoint in the security group, the endpoint is disassociated from the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachSecurityGroupFromVpcEndpoint</b> operation to disassociate an endpoint from a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachSecurityGroupFromVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachSecurityGroupFromVpcEndpointResponse
        /// </returns>
        public async Task<DetachSecurityGroupFromVpcEndpointResponse> DetachSecurityGroupFromVpcEndpointWithOptionsAsync(DetachSecurityGroupFromVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachSecurityGroupFromVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachSecurityGroupFromVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an endpoint from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DetachSecurityGroupFromVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> to check whether the endpoint is disassociated from the security group.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being disassociated from the security group.
        ///     *   If you cannot query the endpoint in the security group, the endpoint is disassociated from the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachSecurityGroupFromVpcEndpoint</b> operation to disassociate an endpoint from a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachSecurityGroupFromVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachSecurityGroupFromVpcEndpointResponse
        /// </returns>
        public DetachSecurityGroupFromVpcEndpointResponse DetachSecurityGroupFromVpcEndpoint(DetachSecurityGroupFromVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachSecurityGroupFromVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an endpoint from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DetachSecurityGroupFromVpcEndpoint</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183558.html">ListVpcEndpoints</a> to check whether the endpoint is disassociated from the security group.
        ///     *   If the endpoint is in the <b>Pending</b> state, the endpoint is being disassociated from the security group.
        ///     *   If you cannot query the endpoint in the security group, the endpoint is disassociated from the security group.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DetachSecurityGroupFromVpcEndpoint</b> operation to disassociate an endpoint from a security group within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachSecurityGroupFromVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachSecurityGroupFromVpcEndpointResponse
        /// </returns>
        public async Task<DetachSecurityGroupFromVpcEndpointResponse> DetachSecurityGroupFromVpcEndpointAsync(DetachSecurityGroupFromVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachSecurityGroupFromVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a connection request from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DisableVpcEndpointConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the endpoint connection is in the <b>Disconnecting</b> state, the endpoint is being disconnected from the endpoint service.
        ///     *   If the endpoint connection is in the <b>Disconnected</b> state, the endpoint is disconnected from the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointConnection</b> operation to allow an endpoint service to reject a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointConnectionResponse
        /// </returns>
        public DisableVpcEndpointConnectionResponse DisableVpcEndpointConnectionWithOptions(DisableVpcEndpointConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVpcEndpointConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVpcEndpointConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a connection request from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DisableVpcEndpointConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the endpoint connection is in the <b>Disconnecting</b> state, the endpoint is being disconnected from the endpoint service.
        ///     *   If the endpoint connection is in the <b>Disconnected</b> state, the endpoint is disconnected from the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointConnection</b> operation to allow an endpoint service to reject a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointConnectionResponse
        /// </returns>
        public async Task<DisableVpcEndpointConnectionResponse> DisableVpcEndpointConnectionWithOptionsAsync(DisableVpcEndpointConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVpcEndpointConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVpcEndpointConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a connection request from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DisableVpcEndpointConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the endpoint connection is in the <b>Disconnecting</b> state, the endpoint is being disconnected from the endpoint service.
        ///     *   If the endpoint connection is in the <b>Disconnected</b> state, the endpoint is disconnected from the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointConnection</b> operation to allow an endpoint service to reject a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointConnectionResponse
        /// </returns>
        public DisableVpcEndpointConnectionResponse DisableVpcEndpointConnection(DisableVpcEndpointConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableVpcEndpointConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a connection request from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>DisableVpcEndpointConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the endpoint connection is in the <b>Disconnecting</b> state, the endpoint is being disconnected from the endpoint service.
        ///     *   If the endpoint connection is in the <b>Disconnected</b> state, the endpoint is disconnected from the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointConnection</b> operation to allow an endpoint service to reject a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointConnectionResponse
        /// </returns>
        public async Task<DisableVpcEndpointConnectionResponse> DisableVpcEndpointConnectionAsync(DisableVpcEndpointConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableVpcEndpointConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes connections in an endpoint zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the zone associated with the endpoint is <b>Connected</b> or <b>Migrated</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>DisableVpcEndpointZoneConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the zone is in the <b>Disconnecting</b> state, the task is running.</description></item>
        /// <item><description>If the zone is in the <b>Disconnected</b> state, the task is successful.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointZoneConnection</b> operation to allow an endpoint service to reject a connection request from the endpoint in the zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointZoneConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointZoneConnectionResponse
        /// </returns>
        public DisableVpcEndpointZoneConnectionResponse DisableVpcEndpointZoneConnectionWithOptions(DisableVpcEndpointZoneConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacedResource))
            {
                query["ReplacedResource"] = request.ReplacedResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVpcEndpointZoneConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVpcEndpointZoneConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes connections in an endpoint zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the zone associated with the endpoint is <b>Connected</b> or <b>Migrated</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>DisableVpcEndpointZoneConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the zone is in the <b>Disconnecting</b> state, the task is running.</description></item>
        /// <item><description>If the zone is in the <b>Disconnected</b> state, the task is successful.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointZoneConnection</b> operation to allow an endpoint service to reject a connection request from the endpoint in the zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointZoneConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointZoneConnectionResponse
        /// </returns>
        public async Task<DisableVpcEndpointZoneConnectionResponse> DisableVpcEndpointZoneConnectionWithOptionsAsync(DisableVpcEndpointZoneConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacedResource))
            {
                query["ReplacedResource"] = request.ReplacedResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVpcEndpointZoneConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVpcEndpointZoneConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes connections in an endpoint zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the zone associated with the endpoint is <b>Connected</b> or <b>Migrated</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>DisableVpcEndpointZoneConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the zone is in the <b>Disconnecting</b> state, the task is running.</description></item>
        /// <item><description>If the zone is in the <b>Disconnected</b> state, the task is successful.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointZoneConnection</b> operation to allow an endpoint service to reject a connection request from the endpoint in the zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointZoneConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointZoneConnectionResponse
        /// </returns>
        public DisableVpcEndpointZoneConnectionResponse DisableVpcEndpointZoneConnection(DisableVpcEndpointZoneConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableVpcEndpointZoneConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes connections in an endpoint zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the zone associated with the endpoint is <b>Connected</b> or <b>Migrated</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>DisableVpcEndpointZoneConnection</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the zone is in the <b>Disconnecting</b> state, the task is running.</description></item>
        /// <item><description>If the zone is in the <b>Disconnected</b> state, the task is successful.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DisableVpcEndpointZoneConnection</b> operation to allow an endpoint service to reject a connection request from the endpoint in the zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableVpcEndpointZoneConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableVpcEndpointZoneConnectionResponse
        /// </returns>
        public async Task<DisableVpcEndpointZoneConnectionResponse> DisableVpcEndpointZoneConnectionAsync(DisableVpcEndpointZoneConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableVpcEndpointZoneConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts connection requests from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>EnableVpcEndpointConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the state is <b>Connecting</b>, the endpoint connection is being established.
        ///     *   If the state is <b>Connected</b>, the endpoint connection is established.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointConnection</b> operation to allow an endpoint service of an Alibaba Cloud account to accept a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointConnectionResponse
        /// </returns>
        public EnableVpcEndpointConnectionResponse EnableVpcEndpointConnectionWithOptions(EnableVpcEndpointConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableVpcEndpointConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableVpcEndpointConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts connection requests from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>EnableVpcEndpointConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the state is <b>Connecting</b>, the endpoint connection is being established.
        ///     *   If the state is <b>Connected</b>, the endpoint connection is established.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointConnection</b> operation to allow an endpoint service of an Alibaba Cloud account to accept a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointConnectionResponse
        /// </returns>
        public async Task<EnableVpcEndpointConnectionResponse> EnableVpcEndpointConnectionWithOptionsAsync(EnableVpcEndpointConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableVpcEndpointConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableVpcEndpointConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts connection requests from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>EnableVpcEndpointConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the state is <b>Connecting</b>, the endpoint connection is being established.
        ///     *   If the state is <b>Connected</b>, the endpoint connection is established.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointConnection</b> operation to allow an endpoint service of an Alibaba Cloud account to accept a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointConnectionResponse
        /// </returns>
        public EnableVpcEndpointConnectionResponse EnableVpcEndpointConnection(EnableVpcEndpointConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableVpcEndpointConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts connection requests from an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>EnableVpcEndpointConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183568.html">GetVpcEndpointAttribute</a> operation to query the state of the endpoint connection.
        ///     *   If the state is <b>Connecting</b>, the endpoint connection is being established.
        ///     *   If the state is <b>Connected</b>, the endpoint connection is established.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointConnection</b> operation to allow an endpoint service of an Alibaba Cloud account to accept a connection request from an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointConnectionResponse
        /// </returns>
        public async Task<EnableVpcEndpointConnectionResponse> EnableVpcEndpointConnectionAsync(EnableVpcEndpointConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableVpcEndpointConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allows connections to endpoint zones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the associated zone is <b>Disconnected</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>EnableVpcEndpointZoneConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the endpoint service accepts a connection request from the endpoint in the associated zone.<list type="bullet">
        /// <item><description>If the zone is in the <b>Connecting</b> state, the endpoint service is accepting the connection request from the endpoint.</description></item>
        /// <item><description>If the zone is in the <b>Connected</b> state, the endpoint service has accepted the connection request from the endpoint.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointZoneConnection</b> operation to allow an endpoint service to accept a connection request from an endpoint in the associated zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointZoneConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointZoneConnectionResponse
        /// </returns>
        public EnableVpcEndpointZoneConnectionResponse EnableVpcEndpointZoneConnectionWithOptions(EnableVpcEndpointZoneConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableVpcEndpointZoneConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableVpcEndpointZoneConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allows connections to endpoint zones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the associated zone is <b>Disconnected</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>EnableVpcEndpointZoneConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the endpoint service accepts a connection request from the endpoint in the associated zone.<list type="bullet">
        /// <item><description>If the zone is in the <b>Connecting</b> state, the endpoint service is accepting the connection request from the endpoint.</description></item>
        /// <item><description>If the zone is in the <b>Connected</b> state, the endpoint service has accepted the connection request from the endpoint.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointZoneConnection</b> operation to allow an endpoint service to accept a connection request from an endpoint in the associated zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointZoneConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointZoneConnectionResponse
        /// </returns>
        public async Task<EnableVpcEndpointZoneConnectionResponse> EnableVpcEndpointZoneConnectionWithOptionsAsync(EnableVpcEndpointZoneConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableVpcEndpointZoneConnection",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableVpcEndpointZoneConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allows connections to endpoint zones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the associated zone is <b>Disconnected</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>EnableVpcEndpointZoneConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the endpoint service accepts a connection request from the endpoint in the associated zone.<list type="bullet">
        /// <item><description>If the zone is in the <b>Connecting</b> state, the endpoint service is accepting the connection request from the endpoint.</description></item>
        /// <item><description>If the zone is in the <b>Connected</b> state, the endpoint service has accepted the connection request from the endpoint.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointZoneConnection</b> operation to allow an endpoint service to accept a connection request from an endpoint in the associated zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointZoneConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointZoneConnectionResponse
        /// </returns>
        public EnableVpcEndpointZoneConnectionResponse EnableVpcEndpointZoneConnection(EnableVpcEndpointZoneConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableVpcEndpointZoneConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allows connections to endpoint zones.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only when the state of the endpoint is <b>Connected</b> and the state of the associated zone is <b>Disconnected</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>EnableVpcEndpointZoneConnection</b> is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the endpoint service accepts a connection request from the endpoint in the associated zone.<list type="bullet">
        /// <item><description>If the zone is in the <b>Connecting</b> state, the endpoint service is accepting the connection request from the endpoint.</description></item>
        /// <item><description>If the zone is in the <b>Connected</b> state, the endpoint service has accepted the connection request from the endpoint.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>EnableVpcEndpointZoneConnection</b> operation to allow an endpoint service to accept a connection request from an endpoint in the associated zone within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableVpcEndpointZoneConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableVpcEndpointZoneConnectionResponse
        /// </returns>
        public async Task<EnableVpcEndpointZoneConnectionResponse> EnableVpcEndpointZoneConnectionAsync(EnableVpcEndpointZoneConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableVpcEndpointZoneConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointAttributeResponse
        /// </returns>
        public GetVpcEndpointAttributeResponse GetVpcEndpointAttributeWithOptions(GetVpcEndpointAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetVpcEndpointAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcEndpointAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointAttributeResponse
        /// </returns>
        public async Task<GetVpcEndpointAttributeResponse> GetVpcEndpointAttributeWithOptionsAsync(GetVpcEndpointAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetVpcEndpointAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcEndpointAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointAttributeResponse
        /// </returns>
        public GetVpcEndpointAttributeResponse GetVpcEndpointAttribute(GetVpcEndpointAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpcEndpointAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointAttributeResponse
        /// </returns>
        public async Task<GetVpcEndpointAttributeResponse> GetVpcEndpointAttributeAsync(GetVpcEndpointAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpcEndpointAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointServiceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointServiceAttributeResponse
        /// </returns>
        public GetVpcEndpointServiceAttributeResponse GetVpcEndpointServiceAttributeWithOptions(GetVpcEndpointServiceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcEndpointServiceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcEndpointServiceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointServiceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointServiceAttributeResponse
        /// </returns>
        public async Task<GetVpcEndpointServiceAttributeResponse> GetVpcEndpointServiceAttributeWithOptionsAsync(GetVpcEndpointServiceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcEndpointServiceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcEndpointServiceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointServiceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointServiceAttributeResponse
        /// </returns>
        public GetVpcEndpointServiceAttributeResponse GetVpcEndpointServiceAttribute(GetVpcEndpointServiceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpcEndpointServiceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcEndpointServiceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcEndpointServiceAttributeResponse
        /// </returns>
        public async Task<GetVpcEndpointServiceAttributeResponse> GetVpcEndpointServiceAttributeAsync(GetVpcEndpointServiceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpcEndpointServiceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must specify <b>ResourceId.N</b> or <b>Tag.N</b> in the request to specify the object that you want to query.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair (Tag.N.Key and Tag.N.Value). If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
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
                Version = "2020-04-15",
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
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must specify <b>ResourceId.N</b> or <b>Tag.N</b> in the request to specify the object that you want to query.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair (Tag.N.Key and Tag.N.Value). If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
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
                Version = "2020-04-15",
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
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must specify <b>ResourceId.N</b> or <b>Tag.N</b> in the request to specify the object that you want to query.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair (Tag.N.Key and Tag.N.Value). If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must specify <b>ResourceId.N</b> or <b>Tag.N</b> in the request to specify the object that you want to query.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair (Tag.N.Key and Tag.N.Value). If you specify only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you specify only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you specify <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries endpoint connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointConnectionsResponse
        /// </returns>
        public ListVpcEndpointConnectionsResponse ListVpcEndpointConnectionsWithOptions(ListVpcEndpointConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStatus))
            {
                query["ConnectionStatus"] = request.ConnectionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointOwnerId))
            {
                query["EndpointOwnerId"] = request.EndpointOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EniId))
            {
                query["EniId"] = request.EniId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacedResourceId))
            {
                query["ReplacedResourceId"] = request.ReplacedResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointConnections",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointConnectionsResponse
        /// </returns>
        public async Task<ListVpcEndpointConnectionsResponse> ListVpcEndpointConnectionsWithOptionsAsync(ListVpcEndpointConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStatus))
            {
                query["ConnectionStatus"] = request.ConnectionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointOwnerId))
            {
                query["EndpointOwnerId"] = request.EndpointOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EniId))
            {
                query["EniId"] = request.EniId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacedResourceId))
            {
                query["ReplacedResourceId"] = request.ReplacedResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointConnections",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointConnectionsResponse
        /// </returns>
        public ListVpcEndpointConnectionsResponse ListVpcEndpointConnections(ListVpcEndpointConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointConnectionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointConnectionsResponse
        /// </returns>
        public async Task<ListVpcEndpointConnectionsResponse> ListVpcEndpointConnectionsAsync(ListVpcEndpointConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointConnectionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security groups that are associated with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointSecurityGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointSecurityGroupsResponse
        /// </returns>
        public ListVpcEndpointSecurityGroupsResponse ListVpcEndpointSecurityGroupsWithOptions(ListVpcEndpointSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListVpcEndpointSecurityGroups",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointSecurityGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security groups that are associated with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointSecurityGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointSecurityGroupsResponse
        /// </returns>
        public async Task<ListVpcEndpointSecurityGroupsResponse> ListVpcEndpointSecurityGroupsWithOptionsAsync(ListVpcEndpointSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListVpcEndpointSecurityGroups",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointSecurityGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security groups that are associated with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointSecurityGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointSecurityGroupsResponse
        /// </returns>
        public ListVpcEndpointSecurityGroupsResponse ListVpcEndpointSecurityGroups(ListVpcEndpointSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointSecurityGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security groups that are associated with an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointSecurityGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointSecurityGroupsResponse
        /// </returns>
        public async Task<ListVpcEndpointSecurityGroupsResponse> ListVpcEndpointSecurityGroupsAsync(ListVpcEndpointSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointSecurityGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the service resources that are added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceResourcesResponse
        /// </returns>
        public ListVpcEndpointServiceResourcesResponse ListVpcEndpointServiceResourcesWithOptions(ListVpcEndpointServiceResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointServiceResources",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServiceResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the service resources that are added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceResourcesResponse
        /// </returns>
        public async Task<ListVpcEndpointServiceResourcesResponse> ListVpcEndpointServiceResourcesWithOptionsAsync(ListVpcEndpointServiceResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointServiceResources",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServiceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the service resources that are added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceResourcesResponse
        /// </returns>
        public ListVpcEndpointServiceResourcesResponse ListVpcEndpointServiceResources(ListVpcEndpointServiceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointServiceResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the service resources that are added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceResourcesResponse
        /// </returns>
        public async Task<ListVpcEndpointServiceResourcesResponse> ListVpcEndpointServiceResourcesAsync(ListVpcEndpointServiceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointServiceResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceUsersResponse
        /// </returns>
        public ListVpcEndpointServiceUsersResponse ListVpcEndpointServiceUsersWithOptions(ListVpcEndpointServiceUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListType))
            {
                query["UserListType"] = request.UserListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointServiceUsers",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServiceUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceUsersResponse
        /// </returns>
        public async Task<ListVpcEndpointServiceUsersResponse> ListVpcEndpointServiceUsersWithOptionsAsync(ListVpcEndpointServiceUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListType))
            {
                query["UserListType"] = request.UserListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointServiceUsers",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServiceUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceUsersResponse
        /// </returns>
        public ListVpcEndpointServiceUsersResponse ListVpcEndpointServiceUsers(ListVpcEndpointServiceUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointServiceUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServiceUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServiceUsersResponse
        /// </returns>
        public async Task<ListVpcEndpointServiceUsersResponse> ListVpcEndpointServiceUsersAsync(ListVpcEndpointServiceUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointServiceUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesResponse
        /// </returns>
        public ListVpcEndpointServicesResponse ListVpcEndpointServicesWithOptions(ListVpcEndpointServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAcceptEnabled))
            {
                query["AutoAcceptEnabled"] = request.AutoAcceptEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceBusinessStatus))
            {
                query["ServiceBusinessStatus"] = request.ServiceBusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                query["ServiceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointServices",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesResponse
        /// </returns>
        public async Task<ListVpcEndpointServicesResponse> ListVpcEndpointServicesWithOptionsAsync(ListVpcEndpointServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAcceptEnabled))
            {
                query["AutoAcceptEnabled"] = request.AutoAcceptEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceBusinessStatus))
            {
                query["ServiceBusinessStatus"] = request.ServiceBusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceResourceType))
            {
                query["ServiceResourceType"] = request.ServiceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                query["ServiceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpointServices",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesResponse
        /// </returns>
        public ListVpcEndpointServicesResponse ListVpcEndpointServices(ListVpcEndpointServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointServicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesResponse
        /// </returns>
        public async Task<ListVpcEndpointServicesResponse> ListVpcEndpointServicesAsync(ListVpcEndpointServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointServicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services that can be associated with the endpoint created within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesByEndUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesByEndUserResponse
        /// </returns>
        public ListVpcEndpointServicesByEndUserResponse ListVpcEndpointServicesByEndUserWithOptions(ListVpcEndpointServicesByEndUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
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
                Action = "ListVpcEndpointServicesByEndUser",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServicesByEndUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services that can be associated with the endpoint created within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesByEndUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesByEndUserResponse
        /// </returns>
        public async Task<ListVpcEndpointServicesByEndUserResponse> ListVpcEndpointServicesByEndUserWithOptionsAsync(ListVpcEndpointServicesByEndUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
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
                Action = "ListVpcEndpointServicesByEndUser",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointServicesByEndUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services that can be associated with the endpoint created within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesByEndUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesByEndUserResponse
        /// </returns>
        public ListVpcEndpointServicesByEndUserResponse ListVpcEndpointServicesByEndUser(ListVpcEndpointServicesByEndUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointServicesByEndUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoint services that can be associated with the endpoint created within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointServicesByEndUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointServicesByEndUserResponse
        /// </returns>
        public async Task<ListVpcEndpointServicesByEndUserResponse> ListVpcEndpointServicesByEndUserAsync(ListVpcEndpointServicesByEndUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointServicesByEndUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the zones of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointZonesResponse
        /// </returns>
        public ListVpcEndpointZonesResponse ListVpcEndpointZonesWithOptions(ListVpcEndpointZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListVpcEndpointZones",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the zones of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointZonesResponse
        /// </returns>
        public async Task<ListVpcEndpointZonesResponse> ListVpcEndpointZonesWithOptionsAsync(ListVpcEndpointZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListVpcEndpointZones",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the zones of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointZonesResponse
        /// </returns>
        public ListVpcEndpointZonesResponse ListVpcEndpointZones(ListVpcEndpointZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the zones of an endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointZonesResponse
        /// </returns>
        public async Task<ListVpcEndpointZonesResponse> ListVpcEndpointZonesAsync(ListVpcEndpointZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointsResponse
        /// </returns>
        public ListVpcEndpointsResponse ListVpcEndpointsWithOptions(ListVpcEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStatus))
            {
                query["ConnectionStatus"] = request.ConnectionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["EndpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointStatus))
            {
                query["EndpointStatus"] = request.EndpointStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpoints",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointsResponse
        /// </returns>
        public async Task<ListVpcEndpointsResponse> ListVpcEndpointsWithOptionsAsync(ListVpcEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStatus))
            {
                query["ConnectionStatus"] = request.ConnectionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["EndpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointStatus))
            {
                query["EndpointStatus"] = request.EndpointStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcEndpoints",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointsResponse
        /// </returns>
        public ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of endpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcEndpointsResponse
        /// </returns>
        public async Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(ListVpcEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates PrivateLink.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenPrivateLinkServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenPrivateLinkServiceResponse
        /// </returns>
        public OpenPrivateLinkServiceResponse OpenPrivateLinkServiceWithOptions(OpenPrivateLinkServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenPrivateLinkService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenPrivateLinkServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates PrivateLink.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenPrivateLinkServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenPrivateLinkServiceResponse
        /// </returns>
        public async Task<OpenPrivateLinkServiceResponse> OpenPrivateLinkServiceWithOptionsAsync(OpenPrivateLinkServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenPrivateLinkService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenPrivateLinkServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates PrivateLink.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenPrivateLinkServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenPrivateLinkServiceResponse
        /// </returns>
        public OpenPrivateLinkServiceResponse OpenPrivateLinkService(OpenPrivateLinkServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenPrivateLinkServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates PrivateLink.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenPrivateLinkServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenPrivateLinkServiceResponse
        /// </returns>
        public async Task<OpenPrivateLinkServiceResponse> OpenPrivateLinkServiceAsync(OpenPrivateLinkServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenPrivateLinkServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an account ID from the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove an account ID from the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveUserFromVpcEndpointService</b> operation to remove the ID of an Alibaba Cloud account from the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromVpcEndpointServiceResponse
        /// </returns>
        public RemoveUserFromVpcEndpointServiceResponse RemoveUserFromVpcEndpointServiceWithOptions(RemoveUserFromVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserARN))
            {
                query["UserARN"] = request.UserARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserFromVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromVpcEndpointServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an account ID from the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove an account ID from the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveUserFromVpcEndpointService</b> operation to remove the ID of an Alibaba Cloud account from the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromVpcEndpointServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromVpcEndpointServiceResponse
        /// </returns>
        public async Task<RemoveUserFromVpcEndpointServiceResponse> RemoveUserFromVpcEndpointServiceWithOptionsAsync(RemoveUserFromVpcEndpointServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserARN))
            {
                query["UserARN"] = request.UserARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserFromVpcEndpointService",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromVpcEndpointServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an account ID from the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove an account ID from the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveUserFromVpcEndpointService</b> operation to remove the ID of an Alibaba Cloud account from the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromVpcEndpointServiceResponse
        /// </returns>
        public RemoveUserFromVpcEndpointServiceResponse RemoveUserFromVpcEndpointService(RemoveUserFromVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserFromVpcEndpointServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an account ID from the whitelist of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you remove an account ID from the whitelist of an endpoint service, make sure that the endpoint service is in the <b>Active</b> state. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to query the status of the endpoint service.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveUserFromVpcEndpointService</b> operation to remove the ID of an Alibaba Cloud account from the whitelist of an endpoint service within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromVpcEndpointServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromVpcEndpointServiceResponse
        /// </returns>
        public async Task<RemoveUserFromVpcEndpointServiceResponse> RemoveUserFromVpcEndpointServiceAsync(RemoveUserFromVpcEndpointServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserFromVpcEndpointServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a zone of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>RemoveZoneFromVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the zone of the endpoint is deleted.
        ///     *   If the zone of the endpoint is in the <b>Deleting</b> state, the zone is being deleted.
        ///     *   If the zone cannot be queried, the zone is deleted.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveZoneFromVpcEndpoint</b> operation to delete a zone of an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveZoneFromVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveZoneFromVpcEndpointResponse
        /// </returns>
        public RemoveZoneFromVpcEndpointResponse RemoveZoneFromVpcEndpointWithOptions(RemoveZoneFromVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveZoneFromVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveZoneFromVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a zone of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>RemoveZoneFromVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the zone of the endpoint is deleted.
        ///     *   If the zone of the endpoint is in the <b>Deleting</b> state, the zone is being deleted.
        ///     *   If the zone cannot be queried, the zone is deleted.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveZoneFromVpcEndpoint</b> operation to delete a zone of an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveZoneFromVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveZoneFromVpcEndpointResponse
        /// </returns>
        public async Task<RemoveZoneFromVpcEndpointResponse> RemoveZoneFromVpcEndpointWithOptionsAsync(RemoveZoneFromVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveZoneFromVpcEndpoint",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveZoneFromVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a zone of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>RemoveZoneFromVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the zone of the endpoint is deleted.
        ///     *   If the zone of the endpoint is in the <b>Deleting</b> state, the zone is being deleted.
        ///     *   If the zone cannot be queried, the zone is deleted.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveZoneFromVpcEndpoint</b> operation to delete a zone of an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveZoneFromVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveZoneFromVpcEndpointResponse
        /// </returns>
        public RemoveZoneFromVpcEndpointResponse RemoveZoneFromVpcEndpoint(RemoveZoneFromVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveZoneFromVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a zone of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>RemoveZoneFromVpcEndpoint</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/183560.html">ListVpcEndpointZones</a> operation to check whether the zone of the endpoint is deleted.
        ///     *   If the zone of the endpoint is in the <b>Deleting</b> state, the zone is being deleted.
        ///     *   If the zone cannot be queried, the zone is deleted.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RemoveZoneFromVpcEndpoint</b> operation to delete a zone of an endpoint within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveZoneFromVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveZoneFromVpcEndpointResponse
        /// </returns>
        public async Task<RemoveZoneFromVpcEndpointResponse> RemoveZoneFromVpcEndpointAsync(RemoveZoneFromVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveZoneFromVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources. You can call this API operation to add tags to one or more endpoints or endpoint services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>You can add up to 20 tags to an instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
        /// </remarks>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
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
                Version = "2020-04-15",
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
        /// <para>Adds tags to resources. You can call this API operation to add tags to one or more endpoints or endpoint services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>You can add up to 20 tags to an instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
        /// </remarks>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
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
                Version = "2020-04-15",
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
        /// <para>Adds tags to resources. You can call this API operation to add tags to one or more endpoints or endpoint services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>You can add up to 20 tags to an instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Adds tags to resources. You can call this API operation to add tags to one or more endpoints or endpoint services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>You can add up to 20 tags to an instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Removes tags from one or more endpoints or endpoint services at a time.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
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
                Version = "2020-04-15",
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
        /// <para>Removes tags from one or more endpoints or endpoint services at a time.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
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
                Version = "2020-04-15",
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
        /// <para>Removes tags from one or more endpoints or endpoint services at a time.</para>
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
        /// <para>Removes tags from one or more endpoints or endpoint services at a time.</para>
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
        /// <para>Modifies the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointAttribute</b> operation to modify the attributes of an endpoint that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointAttributeResponse
        /// </returns>
        public UpdateVpcEndpointAttributeResponse UpdateVpcEndpointAttributeWithOptions(UpdateVpcEndpointAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointDescription))
            {
                query["EndpointDescription"] = request.EndpointDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["EndpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointAttribute</b> operation to modify the attributes of an endpoint that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointAttributeResponse> UpdateVpcEndpointAttributeWithOptionsAsync(UpdateVpcEndpointAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointDescription))
            {
                query["EndpointDescription"] = request.EndpointDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["EndpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointAttribute</b> operation to modify the attributes of an endpoint that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointAttributeResponse
        /// </returns>
        public UpdateVpcEndpointAttributeResponse UpdateVpcEndpointAttribute(UpdateVpcEndpointAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVpcEndpointAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointAttribute</b> operation to modify the attributes of an endpoint that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointAttributeResponse> UpdateVpcEndpointAttributeAsync(UpdateVpcEndpointAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVpcEndpointAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointConnectionAttribute</b> operation to modify the bandwidth of an endpoint connection that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointConnectionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointConnectionAttributeResponse
        /// </returns>
        public UpdateVpcEndpointConnectionAttributeResponse UpdateVpcEndpointConnectionAttributeWithOptions(UpdateVpcEndpointConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointConnectionAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointConnectionAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointConnectionAttribute</b> operation to modify the bandwidth of an endpoint connection that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointConnectionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointConnectionAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointConnectionAttributeResponse> UpdateVpcEndpointConnectionAttributeWithOptionsAsync(UpdateVpcEndpointConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointConnectionAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointConnectionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointConnectionAttribute</b> operation to modify the bandwidth of an endpoint connection that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointConnectionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointConnectionAttributeResponse
        /// </returns>
        public UpdateVpcEndpointConnectionAttributeResponse UpdateVpcEndpointConnectionAttribute(UpdateVpcEndpointConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVpcEndpointConnectionAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointConnectionAttribute</b> operation to modify the bandwidth of an endpoint connection that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointConnectionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointConnectionAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointConnectionAttributeResponse> UpdateVpcEndpointConnectionAttributeAsync(UpdateVpcEndpointConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVpcEndpointConnectionAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceAttribute</b> operation to modify the attributes of an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceAttributeResponse
        /// </returns>
        public UpdateVpcEndpointServiceAttributeResponse UpdateVpcEndpointServiceAttributeWithOptions(UpdateVpcEndpointServiceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAcceptEnabled))
            {
                query["AutoAcceptEnabled"] = request.AutoAcceptEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectBandwidth))
            {
                query["ConnectBandwidth"] = request.ConnectBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSupportIPv6))
            {
                query["ServiceSupportIPv6"] = request.ServiceSupportIPv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointServiceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointServiceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceAttribute</b> operation to modify the attributes of an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointServiceAttributeResponse> UpdateVpcEndpointServiceAttributeWithOptionsAsync(UpdateVpcEndpointServiceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAcceptEnabled))
            {
                query["AutoAcceptEnabled"] = request.AutoAcceptEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectBandwidth))
            {
                query["ConnectBandwidth"] = request.ConnectBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSupportIPv6))
            {
                query["ServiceSupportIPv6"] = request.ServiceSupportIPv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneAffinityEnabled))
            {
                query["ZoneAffinityEnabled"] = request.ZoneAffinityEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointServiceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointServiceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceAttribute</b> operation to modify the attributes of an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceAttributeResponse
        /// </returns>
        public UpdateVpcEndpointServiceAttributeResponse UpdateVpcEndpointServiceAttribute(UpdateVpcEndpointServiceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVpcEndpointServiceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceAttribute</b> operation to modify the attributes of an endpoint service that belongs to an Alibaba Cloud account within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointServiceAttributeResponse> UpdateVpcEndpointServiceAttributeAsync(UpdateVpcEndpointServiceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVpcEndpointServiceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a service resource that is added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceResourceAttribute</b> operation to modify the attributes of a service resource that is added to an endpoint service within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceResourceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceResourceAttributeResponse
        /// </returns>
        public UpdateVpcEndpointServiceResourceAttributeResponse UpdateVpcEndpointServiceResourceAttributeWithOptions(UpdateVpcEndpointServiceResourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAllocatedEnabled))
            {
                query["AutoAllocatedEnabled"] = request.AutoAllocatedEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointServiceResourceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointServiceResourceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a service resource that is added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceResourceAttribute</b> operation to modify the attributes of a service resource that is added to an endpoint service within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceResourceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceResourceAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointServiceResourceAttributeResponse> UpdateVpcEndpointServiceResourceAttributeWithOptionsAsync(UpdateVpcEndpointServiceResourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAllocatedEnabled))
            {
                query["AutoAllocatedEnabled"] = request.AutoAllocatedEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointServiceResourceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointServiceResourceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a service resource that is added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceResourceAttribute</b> operation to modify the attributes of a service resource that is added to an endpoint service within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceResourceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceResourceAttributeResponse
        /// </returns>
        public UpdateVpcEndpointServiceResourceAttributeResponse UpdateVpcEndpointServiceResourceAttribute(UpdateVpcEndpointServiceResourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVpcEndpointServiceResourceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a service resource that is added to an endpoint service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot repeatedly call the <b>UpdateVpcEndpointServiceResourceAttribute</b> operation to modify the attributes of a service resource that is added to an endpoint service within a specified period of time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointServiceResourceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointServiceResourceAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointServiceResourceAttributeResponse> UpdateVpcEndpointServiceResourceAttributeAsync(UpdateVpcEndpointServiceResourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVpcEndpointServiceResourceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a service resource of a zone to which an endpoint connection belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>By default, the feature of modifying a service resource of a zone to which an endpoint connection belongs is unavailable. To use this feature, log on to the <a href="https://quotas.console.aliyun.com/white-list-products/privatelink/quotas">Quota Center console</a>. Click Whitelist Quotas in the left-side navigation pane and click PrivateLink in the Networking section. On the page that appears, search for <c>privatelink_whitelist/svc_res_mgt_uat</c> and click Apply in the Actions column.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>If the endpoint connection is in the <b>Disconnected</b> state, you can manually allocate the service resource in the zone.</description></item>
        /// <item><description>If the endpoint connection is in the <b>Connected</b> state, you can manually migrate the service resource in the zone. In this case, the connection might be interrupted.</description></item>
        /// <item><description><b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to check whether the service resource is modified.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Pending</b> state, the service resource is being modified.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the service resource is modified.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> operation to modify a service resource in the zone to which an endpoint connection belongs within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointZoneConnectionResourceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointZoneConnectionResourceAttributeResponse
        /// </returns>
        public UpdateVpcEndpointZoneConnectionResourceAttributeResponse UpdateVpcEndpointZoneConnectionResourceAttributeWithOptions(UpdateVpcEndpointZoneConnectionResourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAllocateMode))
            {
                query["ResourceAllocateMode"] = request.ResourceAllocateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceReplaceMode))
            {
                query["ResourceReplaceMode"] = request.ResourceReplaceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointZoneConnectionResourceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointZoneConnectionResourceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a service resource of a zone to which an endpoint connection belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>By default, the feature of modifying a service resource of a zone to which an endpoint connection belongs is unavailable. To use this feature, log on to the <a href="https://quotas.console.aliyun.com/white-list-products/privatelink/quotas">Quota Center console</a>. Click Whitelist Quotas in the left-side navigation pane and click PrivateLink in the Networking section. On the page that appears, search for <c>privatelink_whitelist/svc_res_mgt_uat</c> and click Apply in the Actions column.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>If the endpoint connection is in the <b>Disconnected</b> state, you can manually allocate the service resource in the zone.</description></item>
        /// <item><description>If the endpoint connection is in the <b>Connected</b> state, you can manually migrate the service resource in the zone. In this case, the connection might be interrupted.</description></item>
        /// <item><description><b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to check whether the service resource is modified.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Pending</b> state, the service resource is being modified.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the service resource is modified.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> operation to modify a service resource in the zone to which an endpoint connection belongs within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointZoneConnectionResourceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointZoneConnectionResourceAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointZoneConnectionResourceAttributeResponse> UpdateVpcEndpointZoneConnectionResourceAttributeWithOptionsAsync(UpdateVpcEndpointZoneConnectionResourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointId))
            {
                query["EndpointId"] = request.EndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAllocateMode))
            {
                query["ResourceAllocateMode"] = request.ResourceAllocateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceReplaceMode))
            {
                query["ResourceReplaceMode"] = request.ResourceReplaceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVpcEndpointZoneConnectionResourceAttribute",
                Version = "2020-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVpcEndpointZoneConnectionResourceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a service resource of a zone to which an endpoint connection belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>By default, the feature of modifying a service resource of a zone to which an endpoint connection belongs is unavailable. To use this feature, log on to the <a href="https://quotas.console.aliyun.com/white-list-products/privatelink/quotas">Quota Center console</a>. Click Whitelist Quotas in the left-side navigation pane and click PrivateLink in the Networking section. On the page that appears, search for <c>privatelink_whitelist/svc_res_mgt_uat</c> and click Apply in the Actions column.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>If the endpoint connection is in the <b>Disconnected</b> state, you can manually allocate the service resource in the zone.</description></item>
        /// <item><description>If the endpoint connection is in the <b>Connected</b> state, you can manually migrate the service resource in the zone. In this case, the connection might be interrupted.</description></item>
        /// <item><description><b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to check whether the service resource is modified.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Pending</b> state, the service resource is being modified.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the service resource is modified.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> operation to modify a service resource in the zone to which an endpoint connection belongs within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointZoneConnectionResourceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointZoneConnectionResourceAttributeResponse
        /// </returns>
        public UpdateVpcEndpointZoneConnectionResourceAttributeResponse UpdateVpcEndpointZoneConnectionResourceAttribute(UpdateVpcEndpointZoneConnectionResourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVpcEndpointZoneConnectionResourceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a service resource of a zone to which an endpoint connection belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>By default, the feature of modifying a service resource of a zone to which an endpoint connection belongs is unavailable. To use this feature, log on to the <a href="https://quotas.console.aliyun.com/white-list-products/privatelink/quotas">Quota Center console</a>. Click Whitelist Quotas in the left-side navigation pane and click PrivateLink in the Networking section. On the page that appears, search for <c>privatelink_whitelist/svc_res_mgt_uat</c> and click Apply in the Actions column.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>If the endpoint connection is in the <b>Disconnected</b> state, you can manually allocate the service resource in the zone.</description></item>
        /// <item><description>If the endpoint connection is in the <b>Connected</b> state, you can manually migrate the service resource in the zone. In this case, the connection might be interrupted.</description></item>
        /// <item><description><b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/469330.html">GetVpcEndpointServiceAttribute</a> operation to check whether the service resource is modified.<list type="bullet">
        /// <item><description>If the endpoint service is in the <b>Pending</b> state, the service resource is being modified.</description></item>
        /// <item><description>If the endpoint service is in the <b>Active</b> state, the service resource is modified.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>UpdateVpcEndpointZoneConnectionResourceAttribute</b> operation to modify a service resource in the zone to which an endpoint connection belongs within a specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVpcEndpointZoneConnectionResourceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVpcEndpointZoneConnectionResourceAttributeResponse
        /// </returns>
        public async Task<UpdateVpcEndpointZoneConnectionResourceAttributeResponse> UpdateVpcEndpointZoneConnectionResourceAttributeAsync(UpdateVpcEndpointZoneConnectionResourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVpcEndpointZoneConnectionResourceAttributeWithOptionsAsync(request, runtime);
        }

    }
}
