// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.VpcPeer20220101.Models;

namespace AlibabaCloud.SDK.VpcPeer20220101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vpcpeer", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Accepts a VPC peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection, the VPC peering connection instance is activated only after the acceptor accepts the connection request.</description></item>
        /// <item><description>The <b>AcceptVpcPeerConnection</b> operation is asynchronous. After you call this operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately activated. The activation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Updating</b> state, the instance is being activated.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Activated</b> state, the instance is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>AcceptVpcPeerConnection</b> operation to concurrently accept requests for the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public AcceptVpcPeerConnectionResponse AcceptVpcPeerConnectionWithOptions(AcceptVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a VPC peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection, the VPC peering connection instance is activated only after the acceptor accepts the connection request.</description></item>
        /// <item><description>The <b>AcceptVpcPeerConnection</b> operation is asynchronous. After you call this operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately activated. The activation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Updating</b> state, the instance is being activated.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Activated</b> state, the instance is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>AcceptVpcPeerConnection</b> operation to concurrently accept requests for the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public async Task<AcceptVpcPeerConnectionResponse> AcceptVpcPeerConnectionWithOptionsAsync(AcceptVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a VPC peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection, the VPC peering connection instance is activated only after the acceptor accepts the connection request.</description></item>
        /// <item><description>The <b>AcceptVpcPeerConnection</b> operation is asynchronous. After you call this operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately activated. The activation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Updating</b> state, the instance is being activated.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Activated</b> state, the instance is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>AcceptVpcPeerConnection</b> operation to concurrently accept requests for the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public AcceptVpcPeerConnectionResponse AcceptVpcPeerConnection(AcceptVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a VPC peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection, the VPC peering connection instance is activated only after the acceptor accepts the connection request.</description></item>
        /// <item><description>The <b>AcceptVpcPeerConnection</b> operation is asynchronous. After you call this operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately activated. The activation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Updating</b> state, the instance is being activated.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Activated</b> state, the instance is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>AcceptVpcPeerConnection</b> operation to concurrently accept requests for the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public async Task<AcceptVpcPeerConnectionResponse> AcceptVpcPeerConnectionAsync(AcceptVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CreateVpcPeerConnection operation to create a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After you call this operation, the system returns an <b>InstanceId</b>, but the VPC peering connection is not created yet and the creation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.    </description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, the VPC peering connection is created across accounts and must be accepted by the acceptor.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>CreateVpcPeerConnection</b> operation to concurrently create VPC peering connections in the same VPC.
        /// &lt;props=&quot;china&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer and cross-border data transfer.
        /// &lt;props=&quot;intl&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public CreateVpcPeerConnectionResponse CreateVpcPeerConnectionWithOptions(CreateVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingAliUid))
            {
                body["AcceptingAliUid"] = request.AcceptingAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingRegionId))
            {
                body["AcceptingRegionId"] = request.AcceptingRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingVpcId))
            {
                body["AcceptingVpcId"] = request.AcceptingVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableJumboFrame))
            {
                body["EnableJumboFrame"] = request.EnableJumboFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CreateVpcPeerConnection operation to create a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After you call this operation, the system returns an <b>InstanceId</b>, but the VPC peering connection is not created yet and the creation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.    </description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, the VPC peering connection is created across accounts and must be accepted by the acceptor.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>CreateVpcPeerConnection</b> operation to concurrently create VPC peering connections in the same VPC.
        /// &lt;props=&quot;china&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer and cross-border data transfer.
        /// &lt;props=&quot;intl&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public async Task<CreateVpcPeerConnectionResponse> CreateVpcPeerConnectionWithOptionsAsync(CreateVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingAliUid))
            {
                body["AcceptingAliUid"] = request.AcceptingAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingRegionId))
            {
                body["AcceptingRegionId"] = request.AcceptingRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingVpcId))
            {
                body["AcceptingVpcId"] = request.AcceptingVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableJumboFrame))
            {
                body["EnableJumboFrame"] = request.EnableJumboFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CreateVpcPeerConnection operation to create a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After you call this operation, the system returns an <b>InstanceId</b>, but the VPC peering connection is not created yet and the creation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.    </description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, the VPC peering connection is created across accounts and must be accepted by the acceptor.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>CreateVpcPeerConnection</b> operation to concurrently create VPC peering connections in the same VPC.
        /// &lt;props=&quot;china&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer and cross-border data transfer.
        /// &lt;props=&quot;intl&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public CreateVpcPeerConnectionResponse CreateVpcPeerConnection(CreateVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CreateVpcPeerConnection operation to create a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After you call this operation, the system returns an <b>InstanceId</b>, but the VPC peering connection is not created yet and the creation task is still running in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.    </description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, the VPC peering connection is created across accounts and must be accepted by the acceptor.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>CreateVpcPeerConnection</b> operation to concurrently create VPC peering connections in the same VPC.
        /// &lt;props=&quot;china&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer and cross-border data transfer.
        /// &lt;props=&quot;intl&quot;&gt;When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for non-cross-border data transfer.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public async Task<CreateVpcPeerConnectionResponse> CreateVpcPeerConnectionAsync(CreateVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete a VPC peering connection instance. After the instance is deleted, your services will be interrupted. Perform this operation only when it does not affect your services.<list type="bullet">
        /// <item><description>If you choose to force delete the instance, the system deletes the route entry that points to the VPC peering connection instance from the VPC routing table.</description></item>
        /// <item><description>If you do not choose to force delete the instance, the system does not delete the route entry that points to the VPC peering connection instance from the VPC routing table. You must manually delete the route entry.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you call the operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately deleted. The deletion task is still running in the background. You can call the <a href="https://help.aliyun.com/document_detail/2523294.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Deleting</b> state, the instance is being deleted.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Deleted</b> state, the instance is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>DeleteVpcPeerConnection</b> operation to concurrently delete the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public DeleteVpcPeerConnectionResponse DeleteVpcPeerConnectionWithOptions(DeleteVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete a VPC peering connection instance. After the instance is deleted, your services will be interrupted. Perform this operation only when it does not affect your services.<list type="bullet">
        /// <item><description>If you choose to force delete the instance, the system deletes the route entry that points to the VPC peering connection instance from the VPC routing table.</description></item>
        /// <item><description>If you do not choose to force delete the instance, the system does not delete the route entry that points to the VPC peering connection instance from the VPC routing table. You must manually delete the route entry.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you call the operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately deleted. The deletion task is still running in the background. You can call the <a href="https://help.aliyun.com/document_detail/2523294.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Deleting</b> state, the instance is being deleted.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Deleted</b> state, the instance is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>DeleteVpcPeerConnection</b> operation to concurrently delete the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public async Task<DeleteVpcPeerConnectionResponse> DeleteVpcPeerConnectionWithOptionsAsync(DeleteVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete a VPC peering connection instance. After the instance is deleted, your services will be interrupted. Perform this operation only when it does not affect your services.<list type="bullet">
        /// <item><description>If you choose to force delete the instance, the system deletes the route entry that points to the VPC peering connection instance from the VPC routing table.</description></item>
        /// <item><description>If you do not choose to force delete the instance, the system does not delete the route entry that points to the VPC peering connection instance from the VPC routing table. You must manually delete the route entry.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you call the operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately deleted. The deletion task is still running in the background. You can call the <a href="https://help.aliyun.com/document_detail/2523294.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Deleting</b> state, the instance is being deleted.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Deleted</b> state, the instance is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>DeleteVpcPeerConnection</b> operation to concurrently delete the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public DeleteVpcPeerConnectionResponse DeleteVpcPeerConnection(DeleteVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can delete a VPC peering connection instance. After the instance is deleted, your services will be interrupted. Perform this operation only when it does not affect your services.<list type="bullet">
        /// <item><description>If you choose to force delete the instance, the system deletes the route entry that points to the VPC peering connection instance from the VPC routing table.</description></item>
        /// <item><description>If you do not choose to force delete the instance, the system does not delete the route entry that points to the VPC peering connection instance from the VPC routing table. You must manually delete the route entry.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you call the operation, the system returns a <b>RequestId</b>, but the VPC peering connection instance is not immediately deleted. The deletion task is still running in the background. You can call the <a href="https://help.aliyun.com/document_detail/2523294.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the VPC peering connection instance.<list type="bullet">
        /// <item><description>If the VPC peering connection instance is in the <b>Deleting</b> state, the instance is being deleted.</description></item>
        /// <item><description>If the VPC peering connection instance is in the <b>Deleted</b> state, the instance is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot call the <b>DeleteVpcPeerConnection</b> operation to concurrently delete the same VPC peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public async Task<DeleteVpcPeerConnectionResponse> DeleteVpcPeerConnectionAsync(DeleteVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified VPC peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public GetVpcPeerConnectionAttributeResponse GetVpcPeerConnectionAttributeWithOptions(GetVpcPeerConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcPeerConnectionAttribute",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcPeerConnectionAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified VPC peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public async Task<GetVpcPeerConnectionAttributeResponse> GetVpcPeerConnectionAttributeWithOptionsAsync(GetVpcPeerConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcPeerConnectionAttribute",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcPeerConnectionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified VPC peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public GetVpcPeerConnectionAttributeResponse GetVpcPeerConnectionAttribute(GetVpcPeerConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpcPeerConnectionAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified VPC peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public async Task<GetVpcPeerConnectionAttributeResponse> GetVpcPeerConnectionAttributeAsync(GetVpcPeerConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpcPeerConnectionAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags bound to VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>) parameters in the request to determine the resources to query.</description></item>
        /// <item><description><b>Tag.N</b> is the tag of the resource and consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values associated with the tag key are returned. If you specify only <b>Tag.N.Value</b>, an error is reported.</description></item>
        /// <item><description>If you specify both <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, the <b>ResourceId.N</b> parameter must match all the specified tag key-value pairs.</description></item>
        /// <item><description>If you specify multiple tag key-value pairs, the returned resources contain all the specified key-value pairs.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
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
                Version = "2022-01-01",
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
        /// <para>Queries the tags bound to VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>) parameters in the request to determine the resources to query.</description></item>
        /// <item><description><b>Tag.N</b> is the tag of the resource and consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values associated with the tag key are returned. If you specify only <b>Tag.N.Value</b>, an error is reported.</description></item>
        /// <item><description>If you specify both <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, the <b>ResourceId.N</b> parameter must match all the specified tag key-value pairs.</description></item>
        /// <item><description>If you specify multiple tag key-value pairs, the returned resources contain all the specified key-value pairs.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
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
                Version = "2022-01-01",
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
        /// <para>Queries the tags bound to VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>) parameters in the request to determine the resources to query.</description></item>
        /// <item><description><b>Tag.N</b> is the tag of the resource and consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values associated with the tag key are returned. If you specify only <b>Tag.N.Value</b>, an error is reported.</description></item>
        /// <item><description>If you specify both <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, the <b>ResourceId.N</b> parameter must match all the specified tag key-value pairs.</description></item>
        /// <item><description>If you specify multiple tag key-value pairs, the returned resources contain all the specified key-value pairs.</description></item>
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
        /// <para>Queries the tags bound to VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>) parameters in the request to determine the resources to query.</description></item>
        /// <item><description><b>Tag.N</b> is the tag of the resource and consists of a key-value pair. If you specify only <b>Tag.N.Key</b>, all tag values associated with the tag key are returned. If you specify only <b>Tag.N.Value</b>, an error is reported.</description></item>
        /// <item><description>If you specify both <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, the <b>ResourceId.N</b> parameter must match all the specified tag key-value pairs.</description></item>
        /// <item><description>If you specify multiple tag key-value pairs, the returned resources contain all the specified key-value pairs.</description></item>
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
        /// <para>Queries the details of VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public ListVpcPeerConnectionsResponse ListVpcPeerConnectionsWithOptions(ListVpcPeerConnectionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVpcPeerConnectionsShrinkRequest request = new ListVpcPeerConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VpcId))
            {
                request.VpcIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VpcId, "VpcId", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIdShrink))
            {
                body["VpcId"] = request.VpcIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcPeerConnections",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcPeerConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public async Task<ListVpcPeerConnectionsResponse> ListVpcPeerConnectionsWithOptionsAsync(ListVpcPeerConnectionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVpcPeerConnectionsShrinkRequest request = new ListVpcPeerConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VpcId))
            {
                request.VpcIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VpcId, "VpcId", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIdShrink))
            {
                body["VpcId"] = request.VpcIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcPeerConnections",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcPeerConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public ListVpcPeerConnectionsResponse ListVpcPeerConnections(ListVpcPeerConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcPeerConnectionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public async Task<ListVpcPeerConnectionsResponse> ListVpcPeerConnectionsAsync(ListVpcPeerConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcPeerConnectionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name or description of a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>ModifyVpcPeerConnection</b> is an asynchronous operation. The system returns a <b>RequestId</b>, but the VPC peering connection is not immediately modified. The modification task continues in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Updating</b> state, it is being modified.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the modification is complete.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ModifyVpcPeerConnection</b> does not support concurrent modifications to the name and description of the same VPC peering connection.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public ModifyVpcPeerConnectionResponse ModifyVpcPeerConnectionWithOptions(ModifyVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableJumboFrame))
            {
                body["EnableJumboFrame"] = request.EnableJumboFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name or description of a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>ModifyVpcPeerConnection</b> is an asynchronous operation. The system returns a <b>RequestId</b>, but the VPC peering connection is not immediately modified. The modification task continues in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Updating</b> state, it is being modified.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the modification is complete.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ModifyVpcPeerConnection</b> does not support concurrent modifications to the name and description of the same VPC peering connection.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public async Task<ModifyVpcPeerConnectionResponse> ModifyVpcPeerConnectionWithOptionsAsync(ModifyVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableJumboFrame))
            {
                body["EnableJumboFrame"] = request.EnableJumboFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name or description of a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>ModifyVpcPeerConnection</b> is an asynchronous operation. The system returns a <b>RequestId</b>, but the VPC peering connection is not immediately modified. The modification task continues in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Updating</b> state, it is being modified.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the modification is complete.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ModifyVpcPeerConnection</b> does not support concurrent modifications to the name and description of the same VPC peering connection.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public ModifyVpcPeerConnectionResponse ModifyVpcPeerConnection(ModifyVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name or description of a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>ModifyVpcPeerConnection</b> is an asynchronous operation. The system returns a <b>RequestId</b>, but the VPC peering connection is not immediately modified. The modification task continues in the background. You can call <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> to query the status of the VPC peering connection.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Updating</b> state, it is being modified.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the modification is complete.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ModifyVpcPeerConnection</b> does not support concurrent modifications to the name and description of the same VPC peering connection.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public async Task<ModifyVpcPeerConnectionResponse> ModifyVpcPeerConnectionAsync(ModifyVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group of a VPC peering connection.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2022-01-01",
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
        /// <para>Modifies the resource group of a VPC peering connection.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2022-01-01",
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
        /// <para>Modifies the resource group of a VPC peering connection.</para>
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
        /// <para>Modifies the resource group of a VPC peering connection.</para>
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
        /// <para>Rejects a request for a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection instance, the acceptor can reject the connection request. A VPC peering connection instance whose connection request is rejected enters the <b>Rejected</b> state.</description></item>
        /// <item><description><b>RejectVpcPeerConnection</b> does not support concurrent requests to reject the same peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public RejectVpcPeerConnectionResponse RejectVpcPeerConnectionWithOptions(RejectVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a request for a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection instance, the acceptor can reject the connection request. A VPC peering connection instance whose connection request is rejected enters the <b>Rejected</b> state.</description></item>
        /// <item><description><b>RejectVpcPeerConnection</b> does not support concurrent requests to reject the same peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public async Task<RejectVpcPeerConnectionResponse> RejectVpcPeerConnectionWithOptionsAsync(RejectVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a request for a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection instance, the acceptor can reject the connection request. A VPC peering connection instance whose connection request is rejected enters the <b>Rejected</b> state.</description></item>
        /// <item><description><b>RejectVpcPeerConnection</b> does not support concurrent requests to reject the same peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public RejectVpcPeerConnectionResponse RejectVpcPeerConnection(RejectVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rejects a request for a VPC peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For a cross-account VPC peering connection instance, the acceptor can reject the connection request. A VPC peering connection instance whose connection request is rejected enters the <b>Rejected</b> state.</description></item>
        /// <item><description><b>RejectVpcPeerConnection</b> does not support concurrent requests to reject the same peering connection instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public async Task<RejectVpcPeerConnectionResponse> RejectVpcPeerConnectionAsync(RejectVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and attaches tags to one or more specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are labels that you assign to instances. Instance tag consists of a key-value pair. Take note of the following limits on tags: </para>
        /// <list type="bullet">
        /// <item><description>The key of instance tag on an instance must be unique.</description></item>
        /// <item><description>Tags must be attached to instances. Unattached tags are not supported.</description></item>
        /// <item><description>Tag information is not shared across regions. 
        ///   For example, tags created in the China (Hangzhou) region are not visible in the China (Shanghai) region.</description></item>
        /// <item><description>Within the same account and region, tag information is shared across different VPC peering connections. 
        ///  For example, if a tag is attached to a VPC peering connection within the same account and region, you can directly select and attach this tag to other VPC peering connections on the Edit Tags page without manually entering the key-value pair. You can modify the key and value of a tag, or delete the tag from an instance at any time. If an instance is deleted, all tags attached to the instance are also deleted.</description></item>
        /// <item><description>You can attach up to 20 tags to a single instance. Before attaching tags, Alibaba Cloud verifies the number of existing tags on the resource. If the limit is exceeded, an error message is returned.</description></item>
        /// </list>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "TagResources",
                Version = "2022-01-01",
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
        /// <para>Creates and attaches tags to one or more specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are labels that you assign to instances. Instance tag consists of a key-value pair. Take note of the following limits on tags: </para>
        /// <list type="bullet">
        /// <item><description>The key of instance tag on an instance must be unique.</description></item>
        /// <item><description>Tags must be attached to instances. Unattached tags are not supported.</description></item>
        /// <item><description>Tag information is not shared across regions. 
        ///   For example, tags created in the China (Hangzhou) region are not visible in the China (Shanghai) region.</description></item>
        /// <item><description>Within the same account and region, tag information is shared across different VPC peering connections. 
        ///  For example, if a tag is attached to a VPC peering connection within the same account and region, you can directly select and attach this tag to other VPC peering connections on the Edit Tags page without manually entering the key-value pair. You can modify the key and value of a tag, or delete the tag from an instance at any time. If an instance is deleted, all tags attached to the instance are also deleted.</description></item>
        /// <item><description>You can attach up to 20 tags to a single instance. Before attaching tags, Alibaba Cloud verifies the number of existing tags on the resource. If the limit is exceeded, an error message is returned.</description></item>
        /// </list>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "TagResources",
                Version = "2022-01-01",
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
        /// <para>Creates and attaches tags to one or more specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are labels that you assign to instances. Instance tag consists of a key-value pair. Take note of the following limits on tags: </para>
        /// <list type="bullet">
        /// <item><description>The key of instance tag on an instance must be unique.</description></item>
        /// <item><description>Tags must be attached to instances. Unattached tags are not supported.</description></item>
        /// <item><description>Tag information is not shared across regions. 
        ///   For example, tags created in the China (Hangzhou) region are not visible in the China (Shanghai) region.</description></item>
        /// <item><description>Within the same account and region, tag information is shared across different VPC peering connections. 
        ///  For example, if a tag is attached to a VPC peering connection within the same account and region, you can directly select and attach this tag to other VPC peering connections on the Edit Tags page without manually entering the key-value pair. You can modify the key and value of a tag, or delete the tag from an instance at any time. If an instance is deleted, all tags attached to the instance are also deleted.</description></item>
        /// <item><description>You can attach up to 20 tags to a single instance. Before attaching tags, Alibaba Cloud verifies the number of existing tags on the resource. If the limit is exceeded, an error message is returned.</description></item>
        /// </list>
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
        /// <para>Creates and attaches tags to one or more specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are labels that you assign to instances. Instance tag consists of a key-value pair. Take note of the following limits on tags: </para>
        /// <list type="bullet">
        /// <item><description>The key of instance tag on an instance must be unique.</description></item>
        /// <item><description>Tags must be attached to instances. Unattached tags are not supported.</description></item>
        /// <item><description>Tag information is not shared across regions. 
        ///   For example, tags created in the China (Hangzhou) region are not visible in the China (Shanghai) region.</description></item>
        /// <item><description>Within the same account and region, tag information is shared across different VPC peering connections. 
        ///  For example, if a tag is attached to a VPC peering connection within the same account and region, you can directly select and attach this tag to other VPC peering connections on the Edit Tags page without manually entering the key-value pair. You can modify the key and value of a tag, or delete the tag from an instance at any time. If an instance is deleted, all tags attached to the instance are also deleted.</description></item>
        /// <item><description>You can attach up to 20 tags to a single instance. Before attaching tags, Alibaba Cloud verifies the number of existing tags on the resource. If the limit is exceeded, an error message is returned.</description></item>
        /// </list>
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
        /// <para>Removes tags from specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "UnTagResources",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "UnTagResources",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified VPC peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
