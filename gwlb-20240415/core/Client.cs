// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Gwlb20240415.Models;

namespace AlibabaCloud.SDK.Gwlb20240415
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("gwlb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds backend servers to the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of the server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the ListServerGroupServers operation to query the status of the backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the backend server is in the <b>Adding</b> state, the backend server is being added to the server group.</description></item>
        /// <item><description>If the backend server is in the <b>Available</b> state, the server is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddServersToServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddServersToServerGroupResponse
        /// </returns>
        public AddServersToServerGroupResponse AddServersToServerGroupWithOptions(AddServersToServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                bodyFlat["Servers"] = request.Servers;
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
                Action = "AddServersToServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddServersToServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of the server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the ListServerGroupServers operation to query the status of the backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the backend server is in the <b>Adding</b> state, the backend server is being added to the server group.</description></item>
        /// <item><description>If the backend server is in the <b>Available</b> state, the server is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddServersToServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddServersToServerGroupResponse
        /// </returns>
        public async Task<AddServersToServerGroupResponse> AddServersToServerGroupWithOptionsAsync(AddServersToServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                bodyFlat["Servers"] = request.Servers;
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
                Action = "AddServersToServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddServersToServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of the server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the ListServerGroupServers operation to query the status of the backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the backend server is in the <b>Adding</b> state, the backend server is being added to the server group.</description></item>
        /// <item><description>If the backend server is in the <b>Available</b> state, the server is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddServersToServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddServersToServerGroupResponse
        /// </returns>
        public AddServersToServerGroupResponse AddServersToServerGroup(AddServersToServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddServersToServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of the server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the ListServerGroupServers operation to query the status of the backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If the backend server is in the <b>Adding</b> state, the backend server is being added to the server group.</description></item>
        /// <item><description>If the backend server is in the <b>Available</b> state, the server is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddServersToServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddServersToServerGroupResponse
        /// </returns>
        public async Task<AddServersToServerGroupResponse> AddServersToServerGroupAsync(AddServersToServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddServersToServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a listener for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Provisioning</b> state, the listener is being created.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateListenerResponse
        /// </returns>
        public CreateListenerResponse CreateListenerWithOptions(CreateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                body["ListenerDescription"] = request.ListenerDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TcpIdleTimeout))
            {
                body["TcpIdleTimeout"] = request.TcpIdleTimeout;
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
                Action = "CreateListener",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a listener for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Provisioning</b> state, the listener is being created.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateListenerResponse
        /// </returns>
        public async Task<CreateListenerResponse> CreateListenerWithOptionsAsync(CreateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                body["ListenerDescription"] = request.ListenerDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TcpIdleTimeout))
            {
                body["TcpIdleTimeout"] = request.TcpIdleTimeout;
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
                Action = "CreateListener",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a listener for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Provisioning</b> state, the listener is being created.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateListenerResponse
        /// </returns>
        public CreateListenerResponse CreateListener(CreateListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a listener for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Provisioning</b> state, the listener is being created.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is running.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateListenerResponse
        /// </returns>
        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*</para>
        /// <list type="bullet">
        /// <item><description>When you create a GWLB instance, the service-linked role AliyunServiceRoleForGwlb is automatically created.</description></item>
        /// <item><description><b>CreateLoadBalancer</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of a GWLB instance.<list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Provisioning</b> state, the GWLB instance is being created.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public CreateLoadBalancerResponse CreateLoadBalancerWithOptions(CreateLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                body["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                body["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
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
                Action = "CreateLoadBalancer",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*</para>
        /// <list type="bullet">
        /// <item><description>When you create a GWLB instance, the service-linked role AliyunServiceRoleForGwlb is automatically created.</description></item>
        /// <item><description><b>CreateLoadBalancer</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of a GWLB instance.<list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Provisioning</b> state, the GWLB instance is being created.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerWithOptionsAsync(CreateLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                body["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                body["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
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
                Action = "CreateLoadBalancer",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*</para>
        /// <list type="bullet">
        /// <item><description>When you create a GWLB instance, the service-linked role AliyunServiceRoleForGwlb is automatically created.</description></item>
        /// <item><description><b>CreateLoadBalancer</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of a GWLB instance.<list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Provisioning</b> state, the GWLB instance is being created.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*</para>
        /// <list type="bullet">
        /// <item><description>When you create a GWLB instance, the service-linked role AliyunServiceRoleForGwlb is automatically created.</description></item>
        /// <item><description><b>CreateLoadBalancer</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of a GWLB instance.<list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Provisioning</b> state, the GWLB instance is being created.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is created.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerResponse
        /// </returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a server group for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServerGroupResponse
        /// </returns>
        public CreateServerGroupResponse CreateServerGroupWithOptions(CreateServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                bodyFlat["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                bodyFlat["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerFailoverMode))
            {
                body["ServerFailoverMode"] = request.ServerFailoverMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                body["ServerGroupName"] = request.ServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                body["ServerGroupType"] = request.ServerGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
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
                Action = "CreateServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a server group for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServerGroupResponse
        /// </returns>
        public async Task<CreateServerGroupResponse> CreateServerGroupWithOptionsAsync(CreateServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                bodyFlat["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                bodyFlat["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerFailoverMode))
            {
                body["ServerFailoverMode"] = request.ServerFailoverMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                body["ServerGroupName"] = request.ServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                body["ServerGroupType"] = request.ServerGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
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
                Action = "CreateServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a server group for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServerGroupResponse
        /// </returns>
        public CreateServerGroupResponse CreateServerGroup(CreateServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a server group for a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServerGroupResponse
        /// </returns>
        public async Task<CreateServerGroupResponse> CreateServerGroupAsync(CreateServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Deleting</b> state, the listener is being deleted.</description></item>
        /// <item><description>If the listener cannot be found, the listener is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteListenerResponse
        /// </returns>
        public DeleteListenerResponse DeleteListenerWithOptions(DeleteListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteListener",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Deleting</b> state, the listener is being deleted.</description></item>
        /// <item><description>If the listener cannot be found, the listener is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteListenerResponse
        /// </returns>
        public async Task<DeleteListenerResponse> DeleteListenerWithOptionsAsync(DeleteListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteListener",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Deleting</b> state, the listener is being deleted.</description></item>
        /// <item><description>If the listener cannot be found, the listener is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteListenerResponse
        /// </returns>
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Deleting</b> state, the listener is being deleted.</description></item>
        /// <item><description>If the listener cannot be found, the listener is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteListenerResponse
        /// </returns>
        public async Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerWithOptions(DeleteLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerWithOptionsAsync(DeleteLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server group from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete server groups that are not associated with listeners.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerGroupResponse
        /// </returns>
        public DeleteServerGroupResponse DeleteServerGroupWithOptions(DeleteServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server group from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete server groups that are not associated with listeners.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerGroupResponse
        /// </returns>
        public async Task<DeleteServerGroupResponse> DeleteServerGroupWithOptionsAsync(DeleteServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server group from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete server groups that are not associated with listeners.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerGroupResponse
        /// </returns>
        public DeleteServerGroupResponse DeleteServerGroup(DeleteServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server group from a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete server groups that are not associated with listeners.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerGroupResponse
        /// </returns>
        public async Task<DeleteServerGroupResponse> DeleteServerGroupAsync(DeleteServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the most recent region list of Gateway Load Balancer (GWLB).</para>
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
                Version = "2024-04-15",
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
        /// <para>Queries the most recent region list of Gateway Load Balancer (GWLB).</para>
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
                Version = "2024-04-15",
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
        /// <para>Queries the most recent region list of Gateway Load Balancer (GWLB).</para>
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
        /// <para>Queries the most recent region list of Gateway Load Balancer (GWLB).</para>
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
        /// <para>Queries the most recent zone list of Gateway Load Balancer (GWLB).</para>
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
                Version = "2024-04-15",
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
        /// <para>Queries the most recent zone list of Gateway Load Balancer (GWLB).</para>
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
                Version = "2024-04-15",
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
        /// <para>Queries the most recent zone list of Gateway Load Balancer (GWLB).</para>
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
        /// <para>Queries the most recent zone list of Gateway Load Balancer (GWLB).</para>
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
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListenerAttributeResponse
        /// </returns>
        public GetListenerAttributeResponse GetListenerAttributeWithOptions(GetListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListenerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListenerAttributeResponse
        /// </returns>
        public async Task<GetListenerAttributeResponse> GetListenerAttributeWithOptionsAsync(GetListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListenerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListenerAttributeResponse
        /// </returns>
        public GetListenerAttributeResponse GetListenerAttribute(GetListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListenerAttributeResponse
        /// </returns>
        public async Task<GetListenerAttributeResponse> GetListenerAttributeAsync(GetListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health check status of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerHealthStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListenerHealthStatusResponse
        /// </returns>
        public GetListenerHealthStatusResponse GetListenerHealthStatusWithOptions(GetListenerHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                bodyFlat["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
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
                Action = "GetListenerHealthStatus",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListenerHealthStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health check status of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerHealthStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListenerHealthStatusResponse
        /// </returns>
        public async Task<GetListenerHealthStatusResponse> GetListenerHealthStatusWithOptionsAsync(GetListenerHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                bodyFlat["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
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
                Action = "GetListenerHealthStatus",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListenerHealthStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health check status of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerHealthStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListenerHealthStatusResponse
        /// </returns>
        public GetListenerHealthStatusResponse GetListenerHealthStatus(GetListenerHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetListenerHealthStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health check status of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListenerHealthStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListenerHealthStatusResponse
        /// </returns>
        public async Task<GetListenerHealthStatusResponse> GetListenerHealthStatusAsync(GetListenerHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetListenerHealthStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoadBalancerAttributeResponse
        /// </returns>
        public GetLoadBalancerAttributeResponse GetLoadBalancerAttributeWithOptions(GetLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoadBalancerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoadBalancerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoadBalancerAttributeResponse
        /// </returns>
        public async Task<GetLoadBalancerAttributeResponse> GetLoadBalancerAttributeWithOptionsAsync(GetLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoadBalancerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoadBalancerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoadBalancerAttributeResponse
        /// </returns>
        public GetLoadBalancerAttributeResponse GetLoadBalancerAttribute(GetLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoadBalancerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoadBalancerAttributeResponse
        /// </returns>
        public async Task<GetLoadBalancerAttributeResponse> GetLoadBalancerAttributeAsync(GetLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoadBalancerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) listeners.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListListenersResponse
        /// </returns>
        public ListListenersResponse ListListenersWithOptions(ListListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                bodyFlat["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                bodyFlat["LoadBalancerIds"] = request.LoadBalancerIds;
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
                Action = "ListListeners",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) listeners.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListListenersResponse
        /// </returns>
        public async Task<ListListenersResponse> ListListenersWithOptionsAsync(ListListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                bodyFlat["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                bodyFlat["LoadBalancerIds"] = request.LoadBalancerIds;
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
                Action = "ListListeners",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) listeners.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListListenersResponse
        /// </returns>
        public ListListenersResponse ListListeners(ListListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListenersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) listeners.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListListenersResponse
        /// </returns>
        public async Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListenersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancersResponse
        /// </returns>
        public ListLoadBalancersResponse ListLoadBalancersWithOptions(ListLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                body["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerBusinessStatus))
            {
                body["LoadBalancerBusinessStatus"] = request.LoadBalancerBusinessStatus;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                bodyFlat["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerNames))
            {
                bodyFlat["LoadBalancerNames"] = request.LoadBalancerNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                body["LoadBalancerStatus"] = request.LoadBalancerStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                body["TrafficMode"] = request.TrafficMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIds))
            {
                bodyFlat["VpcIds"] = request.VpcIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIds))
            {
                bodyFlat["ZoneIds"] = request.ZoneIds;
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
                Action = "ListLoadBalancers",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLoadBalancersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancersResponse
        /// </returns>
        public async Task<ListLoadBalancersResponse> ListLoadBalancersWithOptionsAsync(ListLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                body["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerBusinessStatus))
            {
                body["LoadBalancerBusinessStatus"] = request.LoadBalancerBusinessStatus;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                bodyFlat["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerNames))
            {
                bodyFlat["LoadBalancerNames"] = request.LoadBalancerNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                body["LoadBalancerStatus"] = request.LoadBalancerStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                body["TrafficMode"] = request.TrafficMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIds))
            {
                bodyFlat["VpcIds"] = request.VpcIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIds))
            {
                bodyFlat["ZoneIds"] = request.ZoneIds;
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
                Action = "ListLoadBalancers",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLoadBalancersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancersResponse
        /// </returns>
        public ListLoadBalancersResponse ListLoadBalancers(ListLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLoadBalancersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Gateway Load Balancer (GWLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLoadBalancersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLoadBalancersResponse
        /// </returns>
        public async Task<ListLoadBalancersResponse> ListLoadBalancersAsync(ListLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLoadBalancersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupServersResponse
        /// </returns>
        public ListServerGroupServersResponse ListServerGroupServersWithOptions(ListServerGroupServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIds))
            {
                bodyFlat["ServerIds"] = request.ServerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIps))
            {
                bodyFlat["ServerIps"] = request.ServerIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
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
                Action = "ListServerGroupServers",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServerGroupServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupServersResponse
        /// </returns>
        public async Task<ListServerGroupServersResponse> ListServerGroupServersWithOptionsAsync(ListServerGroupServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIds))
            {
                bodyFlat["ServerIds"] = request.ServerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIps))
            {
                bodyFlat["ServerIps"] = request.ServerIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
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
                Action = "ListServerGroupServers",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServerGroupServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupServersResponse
        /// </returns>
        public ListServerGroupServersResponse ListServerGroupServers(ListServerGroupServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServerGroupServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupServersResponse
        /// </returns>
        public async Task<ListServerGroupServersResponse> ListServerGroupServersAsync(ListServerGroupServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServerGroupServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupsResponse
        /// </returns>
        public ListServerGroupsResponse ListServerGroupsWithOptions(ListServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupIds))
            {
                bodyFlat["ServerGroupIds"] = request.ServerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupNames))
            {
                bodyFlat["ServerGroupNames"] = request.ServerGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                body["ServerGroupType"] = request.ServerGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
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
                Action = "ListServerGroups",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupsResponse
        /// </returns>
        public async Task<ListServerGroupsResponse> ListServerGroupsWithOptionsAsync(ListServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupIds))
            {
                bodyFlat["ServerGroupIds"] = request.ServerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupNames))
            {
                bodyFlat["ServerGroupNames"] = request.ServerGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                body["ServerGroupType"] = request.ServerGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                bodyFlat["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
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
                Action = "ListServerGroups",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupsResponse
        /// </returns>
        public ListServerGroupsResponse ListServerGroups(ListServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServerGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server groups of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServerGroupsResponse
        /// </returns>
        public async Task<ListServerGroupsResponse> ListServerGroupsAsync(ListServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServerGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of resources.</para>
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
                Version = "2024-04-15",
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
        /// <para>Queries the tags of resources.</para>
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
                Version = "2024-04-15",
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
        /// <para>Queries the tags of resources.</para>
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
        /// <para>Queries the tags of resources.</para>
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
        /// <para>Changes the resource group to which a specified cloud resource belongs.</para>
        /// </summary>
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
                Version = "2024-04-15",
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
        /// <para>Changes the resource group to which a specified cloud resource belongs.</para>
        /// </summary>
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
                Version = "2024-04-15",
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
        /// <para>Changes the resource group to which a specified cloud resource belongs.</para>
        /// </summary>
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
        /// <para>Changes the resource group to which a specified cloud resource belongs.</para>
        /// </summary>
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
        /// <para>Removes backend servers from the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the ListServerGroupServers operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.<remarks>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If connection draining id enabled (<b>ConnectionDrainEnabled</b> set to true) for the server group of the backend server, the backend server that you remove enters the <b>Removing</b> state before entering the <b>Draining</b> state. When the connection draining timeout period (<b>ConnectionDrainTimeout</b>) ends, the backend server is removed from the server group.</description></item>
        /// <item><description>You can add the backend server to the server group again before the connection draining timeout period ends. In this case, the status of the backend server changes from <b>Draining</b> to <b>Adding</b>. After the backend server is added to the server group, the backend server enters the <b>Available</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveServersFromServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveServersFromServerGroupResponse
        /// </returns>
        public RemoveServersFromServerGroupResponse RemoveServersFromServerGroupWithOptions(RemoveServersFromServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                bodyFlat["Servers"] = request.Servers;
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
                Action = "RemoveServersFromServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveServersFromServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the ListServerGroupServers operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.<remarks>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If connection draining id enabled (<b>ConnectionDrainEnabled</b> set to true) for the server group of the backend server, the backend server that you remove enters the <b>Removing</b> state before entering the <b>Draining</b> state. When the connection draining timeout period (<b>ConnectionDrainTimeout</b>) ends, the backend server is removed from the server group.</description></item>
        /// <item><description>You can add the backend server to the server group again before the connection draining timeout period ends. In this case, the status of the backend server changes from <b>Draining</b> to <b>Adding</b>. After the backend server is added to the server group, the backend server enters the <b>Available</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveServersFromServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveServersFromServerGroupResponse
        /// </returns>
        public async Task<RemoveServersFromServerGroupResponse> RemoveServersFromServerGroupWithOptionsAsync(RemoveServersFromServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                bodyFlat["Servers"] = request.Servers;
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
                Action = "RemoveServersFromServerGroup",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveServersFromServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the ListServerGroupServers operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.<remarks>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If connection draining id enabled (<b>ConnectionDrainEnabled</b> set to true) for the server group of the backend server, the backend server that you remove enters the <b>Removing</b> state before entering the <b>Draining</b> state. When the connection draining timeout period (<b>ConnectionDrainTimeout</b>) ends, the backend server is removed from the server group.</description></item>
        /// <item><description>You can add the backend server to the server group again before the connection draining timeout period ends. In this case, the status of the backend server changes from <b>Draining</b> to <b>Adding</b>. After the backend server is added to the server group, the backend server enters the <b>Available</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveServersFromServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveServersFromServerGroupResponse
        /// </returns>
        public RemoveServersFromServerGroupResponse RemoveServersFromServerGroup(RemoveServersFromServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveServersFromServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from the server group of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the ListServerGroups operation to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the ListServerGroupServers operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.<remarks>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If connection draining id enabled (<b>ConnectionDrainEnabled</b> set to true) for the server group of the backend server, the backend server that you remove enters the <b>Removing</b> state before entering the <b>Draining</b> state. When the connection draining timeout period (<b>ConnectionDrainTimeout</b>) ends, the backend server is removed from the server group.</description></item>
        /// <item><description>You can add the backend server to the server group again before the connection draining timeout period ends. In this case, the status of the backend server changes from <b>Draining</b> to <b>Adding</b>. After the backend server is added to the server group, the backend server enters the <b>Available</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveServersFromServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveServersFromServerGroupResponse
        /// </returns>
        public async Task<RemoveServersFromServerGroupResponse> RemoveServersFromServerGroupAsync(RemoveServersFromServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveServersFromServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and adds tags to resources.</para>
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
                Version = "2024-04-15",
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
        /// <para>Creates and adds tags to resources.</para>
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
                Version = "2024-04-15",
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
        /// <para>Creates and adds tags to resources.</para>
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
        /// <para>Creates and adds tags to resources.</para>
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
        /// <para>Removes tags from resources.</para>
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
                Version = "2024-04-15",
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
        /// <para>Removes tags from resources.</para>
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
                Version = "2024-04-15",
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
        /// <para>Removes tags from resources.</para>
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
        /// <para>Removes tags from resources.</para>
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
        /// <para>Updates the configurations of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of a listener.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Configuring</b> state, the listener is being modified.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerAttributeResponse
        /// </returns>
        public UpdateListenerAttributeResponse UpdateListenerAttributeWithOptions(UpdateListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                body["ListenerDescription"] = request.ListenerDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TcpIdleTimeout))
            {
                body["TcpIdleTimeout"] = request.TcpIdleTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListenerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of a listener.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Configuring</b> state, the listener is being modified.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerAttributeResponse
        /// </returns>
        public async Task<UpdateListenerAttributeResponse> UpdateListenerAttributeWithOptionsAsync(UpdateListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                body["ListenerDescription"] = request.ListenerDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                body["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TcpIdleTimeout))
            {
                body["TcpIdleTimeout"] = request.TcpIdleTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListenerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of a listener.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Configuring</b> state, the listener is being modified.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerAttributeResponse
        /// </returns>
        public UpdateListenerAttributeResponse UpdateListenerAttribute(UpdateListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a Gateway Load Balancer (GWLB) listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <b>GetListenerAttribute</b> operation to query the status of a listener.</para>
        /// <list type="bullet">
        /// <item><description>If the listener is in the <b>Configuring</b> state, the listener is being modified.</description></item>
        /// <item><description>If the listener is in the <b>Running</b> state, the listener is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerAttributeResponse
        /// </returns>
        public async Task<UpdateListenerAttributeResponse> UpdateListenerAttributeAsync(UpdateListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  UpdateLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the GetLoadBalancerAttribute operation to query the status of the GWLB instance.
        ///     *   If the GWLB instance is in the Configuring state, the GWLB instance is being modified.
        ///     *   If the GWLB instance is in the Active state, the GWLB instance is modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAttributeResponse
        /// </returns>
        public UpdateLoadBalancerAttributeResponse UpdateLoadBalancerAttributeWithOptions(UpdateLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                body["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                body["TrafficMode"] = request.TrafficMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  UpdateLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the GetLoadBalancerAttribute operation to query the status of the GWLB instance.
        ///     *   If the GWLB instance is in the Configuring state, the GWLB instance is being modified.
        ///     *   If the GWLB instance is in the Active state, the GWLB instance is modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAttributeResponse
        /// </returns>
        public async Task<UpdateLoadBalancerAttributeResponse> UpdateLoadBalancerAttributeWithOptionsAsync(UpdateLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                body["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                body["TrafficMode"] = request.TrafficMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  UpdateLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the GetLoadBalancerAttribute operation to query the status of the GWLB instance.
        ///     *   If the GWLB instance is in the Configuring state, the GWLB instance is being modified.
        ///     *   If the GWLB instance is in the Active state, the GWLB instance is modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAttributeResponse
        /// </returns>
        public UpdateLoadBalancerAttributeResponse UpdateLoadBalancerAttribute(UpdateLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoadBalancerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  UpdateLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the GetLoadBalancerAttribute operation to query the status of the GWLB instance.
        ///     *   If the GWLB instance is in the Configuring state, the GWLB instance is being modified.
        ///     *   If the GWLB instance is in the Active state, the GWLB instance is modified.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAttributeResponse
        /// </returns>
        public async Task<UpdateLoadBalancerAttributeResponse> UpdateLoadBalancerAttributeAsync(UpdateLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoadBalancerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the zones of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*
        /// <b>UpdateLoadBalancerZones</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of the GWLB instance.</para>
        /// <list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Configuring</b> state, the GWLB instance is being modified.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is modified.<remarks>
        /// <para> Before you initiate a call, ensure that all zones, including the current zones and the zones that you want to add, are specified. The zones that you do not specify are deleted. You can call the GetLoadBalancerAttribute operation to query the current zones of your GWLB instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerZonesResponse
        /// </returns>
        public UpdateLoadBalancerZonesResponse UpdateLoadBalancerZonesWithOptions(UpdateLoadBalancerZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "UpdateLoadBalancerZones",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the zones of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*
        /// <b>UpdateLoadBalancerZones</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of the GWLB instance.</para>
        /// <list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Configuring</b> state, the GWLB instance is being modified.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is modified.<remarks>
        /// <para> Before you initiate a call, ensure that all zones, including the current zones and the zones that you want to add, are specified. The zones that you do not specify are deleted. You can call the GetLoadBalancerAttribute operation to query the current zones of your GWLB instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerZonesResponse
        /// </returns>
        public async Task<UpdateLoadBalancerZonesResponse> UpdateLoadBalancerZonesWithOptionsAsync(UpdateLoadBalancerZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "UpdateLoadBalancerZones",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the zones of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*
        /// <b>UpdateLoadBalancerZones</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of the GWLB instance.</para>
        /// <list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Configuring</b> state, the GWLB instance is being modified.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is modified.<remarks>
        /// <para> Before you initiate a call, ensure that all zones, including the current zones and the zones that you want to add, are specified. The zones that you do not specify are deleted. You can call the GetLoadBalancerAttribute operation to query the current zones of your GWLB instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerZonesResponse
        /// </returns>
        public UpdateLoadBalancerZonesResponse UpdateLoadBalancerZones(UpdateLoadBalancerZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoadBalancerZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the zones of a Gateway Load Balancer (GWLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Ensure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/2806160.html">pricing</a> of GWLB before calling this operation.</em>*
        /// <b>UpdateLoadBalancerZones</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2853555.html">GetLoadBalancerAttribute</a> operation to query the status of the GWLB instance.</para>
        /// <list type="bullet">
        /// <item><description>If the GWLB instance is in the <b>Configuring</b> state, the GWLB instance is being modified.</description></item>
        /// <item><description>If the GWLB instance is in the <b>Active</b> state, the GWLB instance is modified.<remarks>
        /// <para> Before you initiate a call, ensure that all zones, including the current zones and the zones that you want to add, are specified. The zones that you do not specify are deleted. You can call the GetLoadBalancerAttribute operation to query the current zones of your GWLB instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerZonesResponse
        /// </returns>
        public async Task<UpdateLoadBalancerZonesResponse> UpdateLoadBalancerZonesAsync(UpdateLoadBalancerZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoadBalancerZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupAttributeResponse
        /// </returns>
        public UpdateServerGroupAttributeResponse UpdateServerGroupAttributeWithOptions(UpdateServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                bodyFlat["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                bodyFlat["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerFailoverMode))
            {
                body["ServerFailoverMode"] = request.ServerFailoverMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                body["ServerGroupName"] = request.ServerGroupName;
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
                Action = "UpdateServerGroupAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServerGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupAttributeResponse
        /// </returns>
        public async Task<UpdateServerGroupAttributeResponse> UpdateServerGroupAttributeWithOptionsAsync(UpdateServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                bodyFlat["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                bodyFlat["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerFailoverMode))
            {
                body["ServerFailoverMode"] = request.ServerFailoverMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                body["ServerGroupName"] = request.ServerGroupName;
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
                Action = "UpdateServerGroupAttribute",
                Version = "2024-04-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServerGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupAttributeResponse
        /// </returns>
        public UpdateServerGroupAttributeResponse UpdateServerGroupAttribute(UpdateServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServerGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the ListServerGroups operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupAttributeResponse
        /// </returns>
        public async Task<UpdateServerGroupAttributeResponse> UpdateServerGroupAttributeAsync(UpdateServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServerGroupAttributeWithOptionsAsync(request, runtime);
        }

    }
}
