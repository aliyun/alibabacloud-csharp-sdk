// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Slb20140515.Models;

namespace AlibabaCloud.SDK.Slb20140515
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "slb.aliyuncs.com"},
                {"cn-beijing", "slb.aliyuncs.com"},
                {"cn-hangzhou", "slb.aliyuncs.com"},
                {"cn-shanghai", "slb.aliyuncs.com"},
                {"cn-shenzhen", "slb.aliyuncs.com"},
                {"cn-hongkong", "slb.aliyuncs.com"},
                {"ap-southeast-1", "slb.aliyuncs.com"},
                {"us-east-1", "slb.aliyuncs.com"},
                {"us-west-1", "slb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "slb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "slb.aliyuncs.com"},
                {"cn-north-2-gov-1", "slb.aliyuncs.com"},
                {"ap-northeast-2-pop", "slb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "slb.aliyuncs.com"},
                {"cn-beijing-gov-1", "slb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "slb.aliyuncs.com"},
                {"cn-edge-1", "slb.aliyuncs.com"},
                {"cn-fujian", "slb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "slb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "slb.aliyuncs.com"},
                {"cn-hangzhou-finance", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "slb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "slb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "slb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "slb-api.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "slb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "slb.aliyuncs.com"},
                {"cn-shanghai-inner", "slb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "slb.aliyuncs.com"},
                {"cn-shenzhen-inner", "slb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "slb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "slb.aliyuncs.com"},
                {"cn-wuhan", "slb.aliyuncs.com"},
                {"cn-yushanfang", "slb.aliyuncs.com"},
                {"cn-zhangbei", "slb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "slb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "slb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "slb.aliyuncs.com"},
                {"eu-west-1-oxs", "slb.aliyuncs.com"},
                {"rus-west-1-pop", "slb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("slb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:</para>
        /// <list type="bullet">
        /// <item><description>The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50</description></item>
        /// <item><description>The maximum number of IP entries that each network ACL can contain: 300</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccessControlListEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAccessControlListEntryResponse
        /// </returns>
        public AddAccessControlListEntryResponse AddAccessControlListEntryWithOptions(AddAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntrys))
            {
                query["AclEntrys"] = request.AclEntrys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAccessControlListEntry",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAccessControlListEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:</para>
        /// <list type="bullet">
        /// <item><description>The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50</description></item>
        /// <item><description>The maximum number of IP entries that each network ACL can contain: 300</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccessControlListEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAccessControlListEntryResponse
        /// </returns>
        public async Task<AddAccessControlListEntryResponse> AddAccessControlListEntryWithOptionsAsync(AddAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntrys))
            {
                query["AclEntrys"] = request.AclEntrys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAccessControlListEntry",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAccessControlListEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:</para>
        /// <list type="bullet">
        /// <item><description>The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50</description></item>
        /// <item><description>The maximum number of IP entries that each network ACL can contain: 300</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccessControlListEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAccessControlListEntryResponse
        /// </returns>
        public AddAccessControlListEntryResponse AddAccessControlListEntry(AddAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAccessControlListEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:</para>
        /// <list type="bullet">
        /// <item><description>The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50</description></item>
        /// <item><description>The maximum number of IP entries that each network ACL can contain: 300</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccessControlListEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAccessControlListEntryResponse
        /// </returns>
        public async Task<AddAccessControlListEntryResponse> AddAccessControlListEntryAsync(AddAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAccessControlListEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public AddBackendServersResponse AddBackendServersWithOptions(AddBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public async Task<AddBackendServersResponse> AddBackendServersWithOptionsAsync(AddBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public AddBackendServersResponse AddBackendServers(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AddBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBackendServersResponse
        /// </returns>
        public async Task<AddBackendServersResponse> AddBackendServersAsync(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP addresses to the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddListenerWhiteListItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddListenerWhiteListItemResponse
        /// </returns>
        public AddListenerWhiteListItemResponse AddListenerWhiteListItemWithOptions(AddListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceItems))
            {
                query["SourceItems"] = request.SourceItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddListenerWhiteListItem",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddListenerWhiteListItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP addresses to the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddListenerWhiteListItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddListenerWhiteListItemResponse
        /// </returns>
        public async Task<AddListenerWhiteListItemResponse> AddListenerWhiteListItemWithOptionsAsync(AddListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceItems))
            {
                query["SourceItems"] = request.SourceItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddListenerWhiteListItem",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddListenerWhiteListItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP addresses to the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddListenerWhiteListItemRequest
        /// </param>
        /// 
        /// <returns>
        /// AddListenerWhiteListItemResponse
        /// </returns>
        public AddListenerWhiteListItemResponse AddListenerWhiteListItem(AddListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddListenerWhiteListItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP addresses to the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddListenerWhiteListItemRequest
        /// </param>
        /// 
        /// <returns>
        /// AddListenerWhiteListItemResponse
        /// </returns>
        public async Task<AddListenerWhiteListItemResponse> AddListenerWhiteListItemAsync(AddListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddListenerWhiteListItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an SLB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Limits</h1>
        /// <para>Before you call this API, note the following limits:</para>
        /// <list type="bullet">
        /// <item><description>You can add up to 10 tags to each SLB instance.</description></item>
        /// <item><description>You can add up to five pairs of tags at a time.</description></item>
        /// <item><description>All the tags and keys added to an SLB instance must be unique.</description></item>
        /// <item><description>If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTagsResponse
        /// </returns>
        public AddTagsResponse AddTagsWithOptions(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "AddTags",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an SLB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Limits</h1>
        /// <para>Before you call this API, note the following limits:</para>
        /// <list type="bullet">
        /// <item><description>You can add up to 10 tags to each SLB instance.</description></item>
        /// <item><description>You can add up to five pairs of tags at a time.</description></item>
        /// <item><description>All the tags and keys added to an SLB instance must be unique.</description></item>
        /// <item><description>If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTagsResponse
        /// </returns>
        public async Task<AddTagsResponse> AddTagsWithOptionsAsync(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "AddTags",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an SLB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Limits</h1>
        /// <para>Before you call this API, note the following limits:</para>
        /// <list type="bullet">
        /// <item><description>You can add up to 10 tags to each SLB instance.</description></item>
        /// <item><description>You can add up to five pairs of tags at a time.</description></item>
        /// <item><description>All the tags and keys added to an SLB instance must be unique.</description></item>
        /// <item><description>If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTagsResponse
        /// </returns>
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an SLB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Limits</h1>
        /// <para>Before you call this API, note the following limits:</para>
        /// <list type="bullet">
        /// <item><description>You can add up to 10 tags to each SLB instance.</description></item>
        /// <item><description>You can add up to five pairs of tags at a time.</description></item>
        /// <item><description>All the tags and keys added to an SLB instance must be unique.</description></item>
        /// <item><description>If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTagsResponse
        /// </returns>
        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddVServerGroupBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddVServerGroupBackendServersResponse
        /// </returns>
        public AddVServerGroupBackendServersResponse AddVServerGroupBackendServersWithOptions(AddVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVServerGroupBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVServerGroupBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddVServerGroupBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddVServerGroupBackendServersResponse
        /// </returns>
        public async Task<AddVServerGroupBackendServersResponse> AddVServerGroupBackendServersWithOptionsAsync(AddVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVServerGroupBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVServerGroupBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddVServerGroupBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddVServerGroupBackendServersResponse
        /// </returns>
        public AddVServerGroupBackendServersResponse AddVServerGroupBackendServers(AddVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVServerGroupBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddVServerGroupBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddVServerGroupBackendServersResponse
        /// </returns>
        public async Task<AddVServerGroupBackendServersResponse> AddVServerGroupBackendServersAsync(AddVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>An account can have a maximum of 50 ACLs in each region.</description></item>
        /// <item><description>You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.</description></item>
        /// <item><description>Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessControlListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessControlListResponse
        /// </returns>
        public CreateAccessControlListResponse CreateAccessControlListWithOptions(CreateAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
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
                Action = "CreateAccessControlList",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessControlListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>An account can have a maximum of 50 ACLs in each region.</description></item>
        /// <item><description>You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.</description></item>
        /// <item><description>Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessControlListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessControlListResponse
        /// </returns>
        public async Task<CreateAccessControlListResponse> CreateAccessControlListWithOptionsAsync(CreateAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
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
                Action = "CreateAccessControlList",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessControlListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>An account can have a maximum of 50 ACLs in each region.</description></item>
        /// <item><description>You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.</description></item>
        /// <item><description>Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessControlListRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessControlListResponse
        /// </returns>
        public CreateAccessControlListResponse CreateAccessControlList(CreateAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessControlListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>An account can have a maximum of 50 ACLs in each region.</description></item>
        /// <item><description>You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.</description></item>
        /// <item><description>Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessControlListRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessControlListResponse
        /// </returns>
        public async Task<CreateAccessControlListResponse> CreateAccessControlListAsync(CreateAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessControlListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDomainExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainExtensionResponse
        /// </returns>
        public CreateDomainExtensionResponse CreateDomainExtensionWithOptions(CreateDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomainExtension",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainExtensionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDomainExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainExtensionResponse
        /// </returns>
        public async Task<CreateDomainExtensionResponse> CreateDomainExtensionWithOptionsAsync(CreateDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomainExtension",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDomainExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainExtensionResponse
        /// </returns>
        public CreateDomainExtensionResponse CreateDomainExtension(CreateDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainExtensionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDomainExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDomainExtensionResponse
        /// </returns>
        public async Task<CreateDomainExtensionResponse> CreateDomainExtensionAsync(CreateDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainExtensionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create a CLB instance, call the <a href="~~DescribeAvailableResource~~">DescribeAvailableResource</a> operation to query the resources available for purchase in the region where you want to create the CLB instance.</para>
        /// <list type="bullet">
        /// <item><description>After a CLB instance is created, you are charged for using the CLB instance.</description></item>
        /// <item><description>The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteProtection))
            {
                query["DeleteProtection"] = request.DeleteProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                query["LoadBalancerSpec"] = request.LoadBalancerSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                query["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionReason))
            {
                query["ModificationProtectionReason"] = request.ModificationProtectionReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionStatus))
            {
                query["ModificationProtectionStatus"] = request.ModificationProtectionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlaveZoneId))
            {
                query["SlaveZoneId"] = request.SlaveZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "CreateLoadBalancer",
                Version = "2014-05-15",
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
        /// <para>Creates a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create a CLB instance, call the <a href="~~DescribeAvailableResource~~">DescribeAvailableResource</a> operation to query the resources available for purchase in the region where you want to create the CLB instance.</para>
        /// <list type="bullet">
        /// <item><description>After a CLB instance is created, you are charged for using the CLB instance.</description></item>
        /// <item><description>The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteProtection))
            {
                query["DeleteProtection"] = request.DeleteProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                query["LoadBalancerSpec"] = request.LoadBalancerSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                query["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionReason))
            {
                query["ModificationProtectionReason"] = request.ModificationProtectionReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionStatus))
            {
                query["ModificationProtectionStatus"] = request.ModificationProtectionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlaveZoneId))
            {
                query["SlaveZoneId"] = request.SlaveZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "CreateLoadBalancer",
                Version = "2014-05-15",
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
        /// <para>Creates a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create a CLB instance, call the <a href="~~DescribeAvailableResource~~">DescribeAvailableResource</a> operation to query the resources available for purchase in the region where you want to create the CLB instance.</para>
        /// <list type="bullet">
        /// <item><description>After a CLB instance is created, you are charged for using the CLB instance.</description></item>
        /// <item><description>The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.</description></item>
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
        /// <para>Creates a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you create a CLB instance, call the <a href="~~DescribeAvailableResource~~">DescribeAvailableResource</a> operation to query the resources available for purchase in the region where you want to create the CLB instance.</para>
        /// <list type="bullet">
        /// <item><description>After a CLB instance is created, you are charged for using the CLB instance.</description></item>
        /// <item><description>The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.</description></item>
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
        /// <para>Creates an HTTP listener for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="~~StartLoadBalancerListener~~">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="~~StartLoadBalancerListener~~">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListenerWithOptions(CreateLoadBalancerHTTPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardPort))
            {
                query["ForwardPort"] = request.ForwardPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerForward))
            {
                query["ListenerForward"] = request.ListenerForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerHTTPListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP listener for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="~~StartLoadBalancerListener~~">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="~~StartLoadBalancerListener~~">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerWithOptionsAsync(CreateLoadBalancerHTTPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardPort))
            {
                query["ForwardPort"] = request.ForwardPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerForward))
            {
                query["ListenerForward"] = request.ListenerForward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerHTTPListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP listener for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="~~StartLoadBalancerListener~~">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="~~StartLoadBalancerListener~~">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListener(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTP listener for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="~~StartLoadBalancerListener~~">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="~~StartLoadBalancerListener~~">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerAsync(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPSListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPSListenerResponse
        /// </returns>
        public CreateLoadBalancerHTTPSListenerResponse CreateLoadBalancerHTTPSListenerWithOptions(CreateLoadBalancerHTTPSListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHttp2))
            {
                query["EnableHttp2"] = request.EnableHttp2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicy))
            {
                query["TLSCipherPolicy"] = request.TLSCipherPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerHTTPSListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPSListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPSListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPSListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerHTTPSListenerResponse> CreateLoadBalancerHTTPSListenerWithOptionsAsync(CreateLoadBalancerHTTPSListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHttp2))
            {
                query["EnableHttp2"] = request.EnableHttp2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicy))
            {
                query["TLSCipherPolicy"] = request.TLSCipherPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerHTTPSListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPSListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPSListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPSListenerResponse
        /// </returns>
        public CreateLoadBalancerHTTPSListenerResponse CreateLoadBalancerHTTPSListener(CreateLoadBalancerHTTPSListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPSListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.</para>
        /// <h2>Prerequisites</h2>
        /// <para>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2">CreateLoadBalancer</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerHTTPSListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerHTTPSListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerHTTPSListenerResponse> CreateLoadBalancerHTTPSListenerAsync(CreateLoadBalancerHTTPSListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPSListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TCP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Newly created listeners are in the <b>stopped</b> state. After a listener is created, call the <a href="https://help.aliyun.com/document_detail/2401757.html">StartLoadBalancerListener</a> operation to enable the listener to forward network traffic.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListenerWithOptions(CreateLoadBalancerTCPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrain))
            {
                query["ConnectionDrain"] = request.ConnectionDrain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainTimeout))
            {
                query["ConnectionDrainTimeout"] = request.ConnectionDrainTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstablishedTimeout))
            {
                query["EstablishedTimeout"] = request.EstablishedTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["healthCheckInterval"] = request.HealthCheckInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerTCPListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerTCPListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TCP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Newly created listeners are in the <b>stopped</b> state. After a listener is created, call the <a href="https://help.aliyun.com/document_detail/2401757.html">StartLoadBalancerListener</a> operation to enable the listener to forward network traffic.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerWithOptionsAsync(CreateLoadBalancerTCPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrain))
            {
                query["ConnectionDrain"] = request.ConnectionDrain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainTimeout))
            {
                query["ConnectionDrainTimeout"] = request.ConnectionDrainTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstablishedTimeout))
            {
                query["EstablishedTimeout"] = request.EstablishedTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["healthCheckInterval"] = request.HealthCheckInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerTCPListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerTCPListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TCP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Newly created listeners are in the <b>stopped</b> state. After a listener is created, call the <a href="https://help.aliyun.com/document_detail/2401757.html">StartLoadBalancerListener</a> operation to enable the listener to forward network traffic.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListener(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerTCPListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TCP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Newly created listeners are in the <b>stopped</b> state. After a listener is created, call the <a href="https://help.aliyun.com/document_detail/2401757.html">StartLoadBalancerListener</a> operation to enable the listener to forward network traffic.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerTCPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerTCPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerAsync(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerTCPListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.</para>
        /// <remarks>
        /// <para> A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to enable the listener to forward traffic to backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerUDPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerUDPListenerResponse
        /// </returns>
        public CreateLoadBalancerUDPListenerResponse CreateLoadBalancerUDPListenerWithOptions(CreateLoadBalancerUDPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckExp))
            {
                query["healthCheckExp"] = request.HealthCheckExp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["healthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckReq))
            {
                query["healthCheckReq"] = request.HealthCheckReq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerUDPListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerUDPListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.</para>
        /// <remarks>
        /// <para> A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to enable the listener to forward traffic to backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerUDPListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerUDPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerUDPListenerResponse> CreateLoadBalancerUDPListenerWithOptionsAsync(CreateLoadBalancerUDPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServerPort))
            {
                query["BackendServerPort"] = request.BackendServerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckExp))
            {
                query["healthCheckExp"] = request.HealthCheckExp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["healthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckReq))
            {
                query["healthCheckReq"] = request.HealthCheckReq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancerUDPListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoadBalancerUDPListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.</para>
        /// <remarks>
        /// <para> A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to enable the listener to forward traffic to backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerUDPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerUDPListenerResponse
        /// </returns>
        public CreateLoadBalancerUDPListenerResponse CreateLoadBalancerUDPListener(CreateLoadBalancerUDPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerUDPListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.</para>
        /// <remarks>
        /// <para> A newly created listener is in the <b>stopped</b> state. After a listener is created, you can call the <a href="https://help.aliyun.com/document_detail/27597.html">StartLoadBalancerListener</a> operation to enable the listener to forward traffic to backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateLoadBalancerUDPListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoadBalancerUDPListenerResponse
        /// </returns>
        public async Task<CreateLoadBalancerUDPListenerResponse> CreateLoadBalancerUDPListenerAsync(CreateLoadBalancerUDPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerUDPListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a primary/secondary server group. Each primary/secondary server group consists of two backend servers. One backend server functions as the primary server, and the other backend server functions as the secondary backend server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMasterSlaveServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMasterSlaveServerGroupResponse
        /// </returns>
        public CreateMasterSlaveServerGroupResponse CreateMasterSlaveServerGroupWithOptions(CreateMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveBackendServers))
            {
                query["MasterSlaveBackendServers"] = request.MasterSlaveBackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupName))
            {
                query["MasterSlaveServerGroupName"] = request.MasterSlaveServerGroupName;
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
                Action = "CreateMasterSlaveServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMasterSlaveServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a primary/secondary server group. Each primary/secondary server group consists of two backend servers. One backend server functions as the primary server, and the other backend server functions as the secondary backend server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMasterSlaveServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMasterSlaveServerGroupResponse
        /// </returns>
        public async Task<CreateMasterSlaveServerGroupResponse> CreateMasterSlaveServerGroupWithOptionsAsync(CreateMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveBackendServers))
            {
                query["MasterSlaveBackendServers"] = request.MasterSlaveBackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupName))
            {
                query["MasterSlaveServerGroupName"] = request.MasterSlaveServerGroupName;
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
                Action = "CreateMasterSlaveServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMasterSlaveServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a primary/secondary server group. Each primary/secondary server group consists of two backend servers. One backend server functions as the primary server, and the other backend server functions as the secondary backend server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMasterSlaveServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMasterSlaveServerGroupResponse
        /// </returns>
        public CreateMasterSlaveServerGroupResponse CreateMasterSlaveServerGroup(CreateMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMasterSlaveServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a primary/secondary server group. Each primary/secondary server group consists of two backend servers. One backend server functions as the primary server, and the other backend server functions as the secondary backend server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMasterSlaveServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMasterSlaveServerGroupResponse
        /// </returns>
        public async Task<CreateMasterSlaveServerGroupResponse> CreateMasterSlaveServerGroupAsync(CreateMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMasterSlaveServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates forwarding rules for an HTTP or HTTPS listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRulesResponse
        /// </returns>
        public CreateRulesResponse CreateRulesWithOptions(CreateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleList))
            {
                query["RuleList"] = request.RuleList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRules",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates forwarding rules for an HTTP or HTTPS listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRulesResponse
        /// </returns>
        public async Task<CreateRulesResponse> CreateRulesWithOptionsAsync(CreateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleList))
            {
                query["RuleList"] = request.RuleList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRules",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates forwarding rules for an HTTP or HTTPS listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRulesResponse
        /// </returns>
        public CreateRulesResponse CreateRules(CreateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates forwarding rules for an HTTP or HTTPS listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRulesResponse
        /// </returns>
        public async Task<CreateRulesResponse> CreateRulesAsync(CreateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTLSCipherPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTLSCipherPolicyResponse
        /// </returns>
        public CreateTLSCipherPolicyResponse CreateTLSCipherPolicyWithOptions(CreateTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSVersions))
            {
                query["TLSVersions"] = request.TLSVersions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTLSCipherPolicy",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTLSCipherPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTLSCipherPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTLSCipherPolicyResponse
        /// </returns>
        public async Task<CreateTLSCipherPolicyResponse> CreateTLSCipherPolicyWithOptionsAsync(CreateTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSVersions))
            {
                query["TLSVersions"] = request.TLSVersions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTLSCipherPolicy",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTLSCipherPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTLSCipherPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTLSCipherPolicyResponse
        /// </returns>
        public CreateTLSCipherPolicyResponse CreateTLSCipherPolicy(CreateTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTLSCipherPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTLSCipherPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTLSCipherPolicyResponse
        /// </returns>
        public async Task<CreateTLSCipherPolicyResponse> CreateTLSCipherPolicyAsync(CreateTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTLSCipherPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vServer group and adds backend servers to the vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVServerGroupResponse
        /// </returns>
        public CreateVServerGroupResponse CreateVServerGroupWithOptions(CreateVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vServer group and adds backend servers to the vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVServerGroupResponse
        /// </returns>
        public async Task<CreateVServerGroupResponse> CreateVServerGroupWithOptionsAsync(CreateVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vServer group and adds backend servers to the vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVServerGroupResponse
        /// </returns>
        public CreateVServerGroupResponse CreateVServerGroup(CreateVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vServer group and adds backend servers to the vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVServerGroupResponse
        /// </returns>
        public async Task<CreateVServerGroupResponse> CreateVServerGroupAsync(CreateVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete an ACL only if it is not associated with a listener.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessControlListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessControlListResponse
        /// </returns>
        public DeleteAccessControlListResponse DeleteAccessControlListWithOptions(DeleteAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessControlList",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessControlListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete an ACL only if it is not associated with a listener.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessControlListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessControlListResponse
        /// </returns>
        public async Task<DeleteAccessControlListResponse> DeleteAccessControlListWithOptionsAsync(DeleteAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessControlList",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessControlListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete an ACL only if it is not associated with a listener.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessControlListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessControlListResponse
        /// </returns>
        public DeleteAccessControlListResponse DeleteAccessControlList(DeleteAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessControlListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete an ACL only if it is not associated with a listener.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessControlListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessControlListResponse
        /// </returns>
        public async Task<DeleteAccessControlListResponse> DeleteAccessControlListAsync(DeleteAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessControlListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessLogsDownloadAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessLogsDownloadAttributeResponse
        /// </returns>
        public DeleteAccessLogsDownloadAttributeResponse DeleteAccessLogsDownloadAttributeWithOptions(DeleteAccessLogsDownloadAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogsDownloadAttributes))
            {
                query["LogsDownloadAttributes"] = request.LogsDownloadAttributes;
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
                Action = "DeleteAccessLogsDownloadAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessLogsDownloadAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessLogsDownloadAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessLogsDownloadAttributeResponse
        /// </returns>
        public async Task<DeleteAccessLogsDownloadAttributeResponse> DeleteAccessLogsDownloadAttributeWithOptionsAsync(DeleteAccessLogsDownloadAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogsDownloadAttributes))
            {
                query["LogsDownloadAttributes"] = request.LogsDownloadAttributes;
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
                Action = "DeleteAccessLogsDownloadAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessLogsDownloadAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessLogsDownloadAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessLogsDownloadAttributeResponse
        /// </returns>
        public DeleteAccessLogsDownloadAttributeResponse DeleteAccessLogsDownloadAttribute(DeleteAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessLogsDownloadAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessLogsDownloadAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessLogsDownloadAttributeResponse
        /// </returns>
        public async Task<DeleteAccessLogsDownloadAttributeResponse> DeleteAccessLogsDownloadAttributeAsync(DeleteAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessLogsDownloadAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete a CA certificate that is in use.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCACertificateResponse
        /// </returns>
        public DeleteCACertificateResponse DeleteCACertificateWithOptions(DeleteCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCACertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCACertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete a CA certificate that is in use.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCACertificateResponse
        /// </returns>
        public async Task<DeleteCACertificateResponse> DeleteCACertificateWithOptionsAsync(DeleteCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCACertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete a CA certificate that is in use.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCACertificateResponse
        /// </returns>
        public DeleteCACertificateResponse DeleteCACertificate(DeleteCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCACertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete a CA certificate that is in use.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCACertificateResponse
        /// </returns>
        public async Task<DeleteCACertificateResponse> DeleteCACertificateAsync(DeleteCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCACertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainExtensionResponse
        /// </returns>
        public DeleteDomainExtensionResponse DeleteDomainExtensionWithOptions(DeleteDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainExtension",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainExtensionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainExtensionResponse
        /// </returns>
        public async Task<DeleteDomainExtensionResponse> DeleteDomainExtensionWithOptionsAsync(DeleteDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainExtension",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainExtensionResponse
        /// </returns>
        public DeleteDomainExtensionResponse DeleteDomainExtension(DeleteDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainExtensionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainExtensionResponse
        /// </returns>
        public async Task<DeleteDomainExtensionResponse> DeleteDomainExtensionAsync(DeleteDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainExtensionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a pay-as-you-go Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The listeners and tags of the SLB instance are deleted along with the SLB instance.</para>
        /// </remarks>
        /// </description>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2014-05-15",
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
        /// <para>Deletes a pay-as-you-go Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The listeners and tags of the SLB instance are deleted along with the SLB instance.</para>
        /// </remarks>
        /// </description>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2014-05-15",
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
        /// <para>Deletes a pay-as-you-go Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The listeners and tags of the SLB instance are deleted along with the SLB instance.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Deletes a pay-as-you-go Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The listeners and tags of the SLB instance are deleted along with the SLB instance.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can delete only listeners that are in the <b>stopped</b> or <b>running</b> state.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListenerWithOptions(DeleteLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancerListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can delete only listeners that are in the <b>stopped</b> or <b>running</b> state.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerWithOptionsAsync(DeleteLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancerListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoadBalancerListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can delete only listeners that are in the <b>stopped</b> or <b>running</b> state.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListener(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can delete only listeners that are in the <b>stopped</b> or <b>running</b> state.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoadBalancerListenerResponse
        /// </returns>
        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerAsync(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMasterSlaveServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMasterSlaveServerGroupResponse
        /// </returns>
        public DeleteMasterSlaveServerGroupResponse DeleteMasterSlaveServerGroupWithOptions(DeleteMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMasterSlaveServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMasterSlaveServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMasterSlaveServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMasterSlaveServerGroupResponse
        /// </returns>
        public async Task<DeleteMasterSlaveServerGroupResponse> DeleteMasterSlaveServerGroupWithOptionsAsync(DeleteMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMasterSlaveServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMasterSlaveServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMasterSlaveServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMasterSlaveServerGroupResponse
        /// </returns>
        public DeleteMasterSlaveServerGroupResponse DeleteMasterSlaveServerGroup(DeleteMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMasterSlaveServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMasterSlaveServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMasterSlaveServerGroupResponse
        /// </returns>
        public async Task<DeleteMasterSlaveServerGroupResponse> DeleteMasterSlaveServerGroupAsync(DeleteMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMasterSlaveServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify at least one forwarding rule that you want to delete. You can specify at most 10 forwarding rules in each call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRulesResponse
        /// </returns>
        public DeleteRulesResponse DeleteRulesWithOptions(DeleteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRules",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify at least one forwarding rule that you want to delete. You can specify at most 10 forwarding rules in each call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRulesResponse
        /// </returns>
        public async Task<DeleteRulesResponse> DeleteRulesWithOptionsAsync(DeleteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRules",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify at least one forwarding rule that you want to delete. You can specify at most 10 forwarding rules in each call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRulesResponse
        /// </returns>
        public DeleteRulesResponse DeleteRules(DeleteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify at least one forwarding rule that you want to delete. You can specify at most 10 forwarding rules in each call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRulesResponse
        /// </returns>
        public async Task<DeleteRulesResponse> DeleteRulesAsync(DeleteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot delete server certificates that are in use.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerCertificateResponse
        /// </returns>
        public DeleteServerCertificateResponse DeleteServerCertificateWithOptions(DeleteServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServerCertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServerCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot delete server certificates that are in use.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerCertificateResponse
        /// </returns>
        public async Task<DeleteServerCertificateResponse> DeleteServerCertificateWithOptionsAsync(DeleteServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServerCertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServerCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot delete server certificates that are in use.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerCertificateResponse
        /// </returns>
        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServerCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot delete server certificates that are in use.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteServerCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServerCertificateResponse
        /// </returns>
        public async Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServerCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a TLS policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Slb%5C&api=DeleteTLSCipherPolicy%5C&type=RPC%5C&version=2014-05-15">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTLSCipherPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTLSCipherPolicyResponse
        /// </returns>
        public DeleteTLSCipherPolicyResponse DeleteTLSCipherPolicyWithOptions(DeleteTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicyId))
            {
                query["TLSCipherPolicyId"] = request.TLSCipherPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTLSCipherPolicy",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTLSCipherPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a TLS policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Slb%5C&api=DeleteTLSCipherPolicy%5C&type=RPC%5C&version=2014-05-15">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTLSCipherPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTLSCipherPolicyResponse
        /// </returns>
        public async Task<DeleteTLSCipherPolicyResponse> DeleteTLSCipherPolicyWithOptionsAsync(DeleteTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicyId))
            {
                query["TLSCipherPolicyId"] = request.TLSCipherPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTLSCipherPolicy",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTLSCipherPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a TLS policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Slb%5C&api=DeleteTLSCipherPolicy%5C&type=RPC%5C&version=2014-05-15">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTLSCipherPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTLSCipherPolicyResponse
        /// </returns>
        public DeleteTLSCipherPolicyResponse DeleteTLSCipherPolicy(DeleteTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTLSCipherPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a TLS policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Slb%5C&api=DeleteTLSCipherPolicy%5C&type=RPC%5C&version=2014-05-15">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTLSCipherPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTLSCipherPolicyResponse
        /// </returns>
        public async Task<DeleteTLSCipherPolicyResponse> DeleteTLSCipherPolicyAsync(DeleteTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTLSCipherPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVServerGroupResponse
        /// </returns>
        public DeleteVServerGroupResponse DeleteVServerGroupWithOptions(DeleteVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVServerGroupResponse
        /// </returns>
        public async Task<DeleteVServerGroupResponse> DeleteVServerGroupWithOptionsAsync(DeleteVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVServerGroup",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVServerGroupResponse
        /// </returns>
        public DeleteVServerGroupResponse DeleteVServerGroup(DeleteVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVServerGroupResponse
        /// </returns>
        public async Task<DeleteVServerGroupResponse> DeleteVServerGroupAsync(DeleteVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListAttributeResponse
        /// </returns>
        public DescribeAccessControlListAttributeResponse DescribeAccessControlListAttributeWithOptions(DescribeAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntryComment))
            {
                query["AclEntryComment"] = request.AclEntryComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessControlListAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessControlListAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListAttributeResponse
        /// </returns>
        public async Task<DescribeAccessControlListAttributeResponse> DescribeAccessControlListAttributeWithOptionsAsync(DescribeAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntryComment))
            {
                query["AclEntryComment"] = request.AclEntryComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessControlListAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessControlListAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListAttributeResponse
        /// </returns>
        public DescribeAccessControlListAttributeResponse DescribeAccessControlListAttribute(DescribeAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessControlListAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListAttributeResponse
        /// </returns>
        public async Task<DescribeAccessControlListAttributeResponse> DescribeAccessControlListAttributeAsync(DescribeAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessControlListAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListsResponse
        /// </returns>
        public DescribeAccessControlListsResponse DescribeAccessControlListsWithOptions(DescribeAccessControlListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
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
                Action = "DescribeAccessControlLists",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessControlListsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListsResponse
        /// </returns>
        public async Task<DescribeAccessControlListsResponse> DescribeAccessControlListsWithOptionsAsync(DescribeAccessControlListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
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
                Action = "DescribeAccessControlLists",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessControlListsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListsResponse
        /// </returns>
        public DescribeAccessControlListsResponse DescribeAccessControlLists(DescribeAccessControlListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessControlListsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessControlListsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessControlListsResponse
        /// </returns>
        public async Task<DescribeAccessControlListsResponse> DescribeAccessControlListsAsync(DescribeAccessControlListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessControlListsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessLogsDownloadAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessLogsDownloadAttributeResponse
        /// </returns>
        public DescribeAccessLogsDownloadAttributeResponse DescribeAccessLogsDownloadAttributeWithOptions(DescribeAccessLogsDownloadAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
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
                Action = "DescribeAccessLogsDownloadAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessLogsDownloadAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessLogsDownloadAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessLogsDownloadAttributeResponse
        /// </returns>
        public async Task<DescribeAccessLogsDownloadAttributeResponse> DescribeAccessLogsDownloadAttributeWithOptionsAsync(DescribeAccessLogsDownloadAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
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
                Action = "DescribeAccessLogsDownloadAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessLogsDownloadAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessLogsDownloadAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessLogsDownloadAttributeResponse
        /// </returns>
        public DescribeAccessLogsDownloadAttributeResponse DescribeAccessLogsDownloadAttribute(DescribeAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessLogsDownloadAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access log of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessLogsDownloadAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessLogsDownloadAttributeResponse
        /// </returns>
        public async Task<DescribeAccessLogsDownloadAttributeResponse> DescribeAccessLogsDownloadAttributeAsync(DescribeAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessLogsDownloadAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available resources and resources that are available for purchase in the zones of a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Only the available resources and zones are returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableResource",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available resources and resources that are available for purchase in the zones of a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Only the available resources and zones are returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableResource",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available resources and resources that are available for purchase in the zones of a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Only the available resources and zones are returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available resources and resources that are available for purchase in the zones of a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Only the available resources and zones are returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificatesResponse
        /// </returns>
        public DescribeCACertificatesResponse DescribeCACertificatesWithOptions(DescribeCACertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
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
                Action = "DescribeCACertificates",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificatesResponse
        /// </returns>
        public async Task<DescribeCACertificatesResponse> DescribeCACertificatesWithOptionsAsync(DescribeCACertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
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
                Action = "DescribeCACertificates",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificatesResponse
        /// </returns>
        public DescribeCACertificatesResponse DescribeCACertificates(DescribeCACertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificatesResponse
        /// </returns>
        public async Task<DescribeCACertificatesResponse> DescribeCACertificatesAsync(DescribeCACertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionAttributeResponse
        /// </returns>
        public DescribeDomainExtensionAttributeResponse DescribeDomainExtensionAttributeWithOptions(DescribeDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainExtensionAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainExtensionAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionAttributeResponse
        /// </returns>
        public async Task<DescribeDomainExtensionAttributeResponse> DescribeDomainExtensionAttributeWithOptionsAsync(DescribeDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainExtensionAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainExtensionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionAttributeResponse
        /// </returns>
        public DescribeDomainExtensionAttributeResponse DescribeDomainExtensionAttribute(DescribeDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainExtensionAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attributes of an additional domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionAttributeResponse
        /// </returns>
        public async Task<DescribeDomainExtensionAttributeResponse> DescribeDomainExtensionAttributeAsync(DescribeDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainExtensionAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries additional domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionsResponse
        /// </returns>
        public DescribeDomainExtensionsResponse DescribeDomainExtensionsWithOptions(DescribeDomainExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainExtensions",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainExtensionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries additional domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionsResponse
        /// </returns>
        public async Task<DescribeDomainExtensionsResponse> DescribeDomainExtensionsWithOptionsAsync(DescribeDomainExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainExtensions",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainExtensionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries additional domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionsResponse
        /// </returns>
        public DescribeDomainExtensionsResponse DescribeDomainExtensions(DescribeDomainExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainExtensionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries additional domain names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainExtensionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainExtensionsResponse
        /// </returns>
        public async Task<DescribeDomainExtensionsResponse> DescribeDomainExtensionsAsync(DescribeDomainExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainExtensionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health status of backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHealthStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthStatusResponse
        /// </returns>
        public DescribeHealthStatusResponse DescribeHealthStatusWithOptions(DescribeHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHealthStatus",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHealthStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health status of backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHealthStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthStatusResponse
        /// </returns>
        public async Task<DescribeHealthStatusResponse> DescribeHealthStatusWithOptionsAsync(DescribeHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHealthStatus",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHealthStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health status of backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHealthStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthStatusResponse
        /// </returns>
        public DescribeHealthStatusResponse DescribeHealthStatus(DescribeHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health status of backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHealthStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthStatusResponse
        /// </returns>
        public async Task<DescribeHealthStatusResponse> DescribeHealthStatusAsync(DescribeHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of fine-grained monitoring in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHighDefinationMonitorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHighDefinationMonitorResponse
        /// </returns>
        public DescribeHighDefinationMonitorResponse DescribeHighDefinationMonitorWithOptions(DescribeHighDefinationMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeHighDefinationMonitor",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHighDefinationMonitorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of fine-grained monitoring in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHighDefinationMonitorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHighDefinationMonitorResponse
        /// </returns>
        public async Task<DescribeHighDefinationMonitorResponse> DescribeHighDefinationMonitorWithOptionsAsync(DescribeHighDefinationMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeHighDefinationMonitor",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHighDefinationMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of fine-grained monitoring in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHighDefinationMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHighDefinationMonitorResponse
        /// </returns>
        public DescribeHighDefinationMonitorResponse DescribeHighDefinationMonitor(DescribeHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHighDefinationMonitorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of fine-grained monitoring in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHighDefinationMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHighDefinationMonitorResponse
        /// </returns>
        public async Task<DescribeHighDefinationMonitorResponse> DescribeHighDefinationMonitorAsync(DescribeHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHighDefinationMonitorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist configurations of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeListenerAccessControlAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeListenerAccessControlAttributeResponse
        /// </returns>
        public DescribeListenerAccessControlAttributeResponse DescribeListenerAccessControlAttributeWithOptions(DescribeListenerAccessControlAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeListenerAccessControlAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeListenerAccessControlAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist configurations of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeListenerAccessControlAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeListenerAccessControlAttributeResponse
        /// </returns>
        public async Task<DescribeListenerAccessControlAttributeResponse> DescribeListenerAccessControlAttributeWithOptionsAsync(DescribeListenerAccessControlAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeListenerAccessControlAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeListenerAccessControlAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist configurations of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeListenerAccessControlAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeListenerAccessControlAttributeResponse
        /// </returns>
        public DescribeListenerAccessControlAttributeResponse DescribeListenerAccessControlAttribute(DescribeListenerAccessControlAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeListenerAccessControlAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist configurations of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeListenerAccessControlAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeListenerAccessControlAttributeResponse
        /// </returns>
        public async Task<DescribeListenerAccessControlAttributeResponse> DescribeListenerAccessControlAttributeAsync(DescribeListenerAccessControlAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeListenerAccessControlAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detail of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If backend servers are deployed in a vServer group, you can call the <a href="https://help.aliyun.com/document_detail/35224.html">DescribeVServerGroupAttribute</a> operation to query the backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttributeWithOptions(DescribeLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detail of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If backend servers are deployed in a vServer group, you can call the <a href="https://help.aliyun.com/document_detail/35224.html">DescribeVServerGroupAttribute</a> operation to query the backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeWithOptionsAsync(DescribeLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detail of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If backend servers are deployed in a vServer group, you can call the <a href="https://help.aliyun.com/document_detail/35224.html">DescribeVServerGroupAttribute</a> operation to query the backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttribute(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detail of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If backend servers are deployed in a vServer group, you can call the <a href="https://help.aliyun.com/document_detail/35224.html">DescribeVServerGroupAttribute</a> operation to query the backend servers.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeAsync(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttributeWithOptions(DescribeLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerHTTPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerHTTPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttribute(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerHTTPSListenerAttributeResponse DescribeLoadBalancerHTTPSListenerAttributeWithOptions(DescribeLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerHTTPSListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPSListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerHTTPSListenerAttributeResponse> DescribeLoadBalancerHTTPSListenerAttributeWithOptionsAsync(DescribeLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerHTTPSListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPSListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerHTTPSListenerAttributeResponse DescribeLoadBalancerHTTPSListenerAttribute(DescribeLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPSListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerHTTPSListenerAttributeResponse> DescribeLoadBalancerHTTPSListenerAttributeAsync(DescribeLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPSListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>One or more listeners are added to the CLB instance. For more information, see the following topics:<list type="bullet">
        /// <item><description><a href="~~CreateLoadBalancerUDPListener~~">CreateLoadBalancerUDPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPListener~~">CreateLoadBalancerHTTPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPSListener~~">CreateLoadBalancerHTTPSListener</a></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerListenersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerListenersResponse
        /// </returns>
        public DescribeLoadBalancerListenersResponse DescribeLoadBalancerListenersWithOptions(DescribeLoadBalancerListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "DescribeLoadBalancerListeners",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerListenersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>One or more listeners are added to the CLB instance. For more information, see the following topics:<list type="bullet">
        /// <item><description><a href="~~CreateLoadBalancerUDPListener~~">CreateLoadBalancerUDPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPListener~~">CreateLoadBalancerHTTPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPSListener~~">CreateLoadBalancerHTTPSListener</a></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerListenersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerListenersResponse
        /// </returns>
        public async Task<DescribeLoadBalancerListenersResponse> DescribeLoadBalancerListenersWithOptionsAsync(DescribeLoadBalancerListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "DescribeLoadBalancerListeners",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerListenersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>One or more listeners are added to the CLB instance. For more information, see the following topics:<list type="bullet">
        /// <item><description><a href="~~CreateLoadBalancerUDPListener~~">CreateLoadBalancerUDPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPListener~~">CreateLoadBalancerHTTPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPSListener~~">CreateLoadBalancerHTTPSListener</a></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerListenersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerListenersResponse
        /// </returns>
        public DescribeLoadBalancerListenersResponse DescribeLoadBalancerListeners(DescribeLoadBalancerListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerListenersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>One or more listeners are added to the CLB instance. For more information, see the following topics:<list type="bullet">
        /// <item><description><a href="~~CreateLoadBalancerUDPListener~~">CreateLoadBalancerUDPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPListener~~">CreateLoadBalancerHTTPListener</a></description></item>
        /// <item><description><a href="~~CreateLoadBalancerHTTPSListener~~">CreateLoadBalancerHTTPSListener</a></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerListenersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerListenersResponse
        /// </returns>
        public async Task<DescribeLoadBalancerListenersResponse> DescribeLoadBalancerListenersAsync(DescribeLoadBalancerListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerListenersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttributeWithOptions(DescribeLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerTCPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerTCPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(DescribeLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerTCPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerTCPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttribute(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeAsync(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerUDPListenerAttributeResponse DescribeLoadBalancerUDPListenerAttributeWithOptions(DescribeLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerUDPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerUDPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerUDPListenerAttributeResponse> DescribeLoadBalancerUDPListenerAttributeWithOptionsAsync(DescribeLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLoadBalancerUDPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancerUDPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public DescribeLoadBalancerUDPListenerAttributeResponse DescribeLoadBalancerUDPListenerAttribute(DescribeLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerUDPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public async Task<DescribeLoadBalancerUDPListenerAttributeResponse> DescribeLoadBalancerUDPListenerAttributeAsync(DescribeLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerUDPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Classic Load Balancer (CLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersWithOptions(DescribeLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                query["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIntranetAddress))
            {
                query["ServerIntranetAddress"] = request.ServerIntranetAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlaveZoneId))
            {
                query["SlaveZoneId"] = request.SlaveZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "DescribeLoadBalancers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Classic Load Balancer (CLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersWithOptionsAsync(DescribeLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIPVersion))
            {
                query["AddressIPVersion"] = request.AddressIPVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterZoneId))
            {
                query["MasterZoneId"] = request.MasterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIntranetAddress))
            {
                query["ServerIntranetAddress"] = request.ServerIntranetAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlaveZoneId))
            {
                query["SlaveZoneId"] = request.SlaveZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "DescribeLoadBalancers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLoadBalancersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Classic Load Balancer (CLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Classic Load Balancer (CLB) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLoadBalancersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLoadBalancersResponse
        /// </returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupAttributeResponse
        /// </returns>
        public DescribeMasterSlaveServerGroupAttributeResponse DescribeMasterSlaveServerGroupAttributeWithOptions(DescribeMasterSlaveServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMasterSlaveServerGroupAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupAttributeResponse
        /// </returns>
        public async Task<DescribeMasterSlaveServerGroupAttributeResponse> DescribeMasterSlaveServerGroupAttributeWithOptionsAsync(DescribeMasterSlaveServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMasterSlaveServerGroupAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupAttributeResponse
        /// </returns>
        public DescribeMasterSlaveServerGroupAttributeResponse DescribeMasterSlaveServerGroupAttribute(DescribeMasterSlaveServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMasterSlaveServerGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a primary/secondary server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupAttributeResponse
        /// </returns>
        public async Task<DescribeMasterSlaveServerGroupAttributeResponse> DescribeMasterSlaveServerGroupAttributeAsync(DescribeMasterSlaveServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMasterSlaveServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries primary/secondary server groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupsResponse
        /// </returns>
        public DescribeMasterSlaveServerGroupsResponse DescribeMasterSlaveServerGroupsWithOptions(DescribeMasterSlaveServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeListener))
            {
                query["IncludeListener"] = request.IncludeListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DescribeMasterSlaveServerGroups",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries primary/secondary server groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupsResponse
        /// </returns>
        public async Task<DescribeMasterSlaveServerGroupsResponse> DescribeMasterSlaveServerGroupsWithOptionsAsync(DescribeMasterSlaveServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeListener))
            {
                query["IncludeListener"] = request.IncludeListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DescribeMasterSlaveServerGroups",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries primary/secondary server groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupsResponse
        /// </returns>
        public DescribeMasterSlaveServerGroupsResponse DescribeMasterSlaveServerGroups(DescribeMasterSlaveServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMasterSlaveServerGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries primary/secondary server groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMasterSlaveServerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMasterSlaveServerGroupsResponse
        /// </returns>
        public async Task<DescribeMasterSlaveServerGroupsResponse> DescribeMasterSlaveServerGroupsAsync(DescribeMasterSlaveServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMasterSlaveServerGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2014-05-15",
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
        /// <para>Queries available regions.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2014-05-15",
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
        /// <para>Queries available regions.</para>
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
        /// <para>Queries available regions.</para>
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
        /// <para>Queries the configurations of a specified forwarding rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleAttributeResponse
        /// </returns>
        public DescribeRuleAttributeResponse DescribeRuleAttributeWithOptions(DescribeRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a specified forwarding rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleAttributeResponse
        /// </returns>
        public async Task<DescribeRuleAttributeResponse> DescribeRuleAttributeWithOptionsAsync(DescribeRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a specified forwarding rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleAttributeResponse
        /// </returns>
        public DescribeRuleAttributeResponse DescribeRuleAttribute(DescribeRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a specified forwarding rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleAttributeResponse
        /// </returns>
        public async Task<DescribeRuleAttributeResponse> DescribeRuleAttributeAsync(DescribeRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules that are configured for a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRulesResponse
        /// </returns>
        public DescribeRulesResponse DescribeRulesWithOptions(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRules",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules that are configured for a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRulesResponse
        /// </returns>
        public async Task<DescribeRulesResponse> DescribeRulesWithOptionsAsync(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRules",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules that are configured for a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRulesResponse
        /// </returns>
        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules that are configured for a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRulesResponse
        /// </returns>
        public async Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server certificates in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> For security reasons, only the fingerprints and names of server certificates are returned. The content of server certificates and private keys is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeServerCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServerCertificatesResponse
        /// </returns>
        public DescribeServerCertificatesResponse DescribeServerCertificatesWithOptions(DescribeServerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
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
                Action = "DescribeServerCertificates",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServerCertificatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server certificates in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> For security reasons, only the fingerprints and names of server certificates are returned. The content of server certificates and private keys is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeServerCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServerCertificatesResponse
        /// </returns>
        public async Task<DescribeServerCertificatesResponse> DescribeServerCertificatesWithOptionsAsync(DescribeServerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
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
                Action = "DescribeServerCertificates",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServerCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server certificates in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> For security reasons, only the fingerprints and names of server certificates are returned. The content of server certificates and private keys is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeServerCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServerCertificatesResponse
        /// </returns>
        public DescribeServerCertificatesResponse DescribeServerCertificates(DescribeServerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServerCertificatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the server certificates in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> For security reasons, only the fingerprints and names of server certificates are returned. The content of server certificates and private keys is not returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeServerCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServerCertificatesResponse
        /// </returns>
        public async Task<DescribeServerCertificatesResponse> DescribeServerCertificatesAsync(DescribeServerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServerCertificatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The system queries tags based on the instance ID, tag key, and tag value specified by you.</description></item>
        /// <item><description>If the logical relationship among the specified conditions is AND, only tags that match all the specified conditions are returned.</description></item>
        /// <item><description>If the Tagkey parameter is specified and but Tagvalue parameter is not specified, all tags that contain the specified tag key are returned.</description></item>
        /// <item><description>If you specify the Tagvalue parameter in a request, you must also specify the Tagkey parameter in the request.</description></item>
        /// <item><description>If you specify both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagsResponse
        /// </returns>
        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistinctKey))
            {
                query["DistinctKey"] = request.DistinctKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DescribeTags",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The system queries tags based on the instance ID, tag key, and tag value specified by you.</description></item>
        /// <item><description>If the logical relationship among the specified conditions is AND, only tags that match all the specified conditions are returned.</description></item>
        /// <item><description>If the Tagkey parameter is specified and but Tagvalue parameter is not specified, all tags that contain the specified tag key are returned.</description></item>
        /// <item><description>If you specify the Tagvalue parameter in a request, you must also specify the Tagkey parameter in the request.</description></item>
        /// <item><description>If you specify both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagsResponse
        /// </returns>
        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistinctKey))
            {
                query["DistinctKey"] = request.DistinctKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DescribeTags",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The system queries tags based on the instance ID, tag key, and tag value specified by you.</description></item>
        /// <item><description>If the logical relationship among the specified conditions is AND, only tags that match all the specified conditions are returned.</description></item>
        /// <item><description>If the Tagkey parameter is specified and but Tagvalue parameter is not specified, all tags that contain the specified tag key are returned.</description></item>
        /// <item><description>If you specify the Tagvalue parameter in a request, you must also specify the Tagkey parameter in the request.</description></item>
        /// <item><description>If you specify both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagsResponse
        /// </returns>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The system queries tags based on the instance ID, tag key, and tag value specified by you.</description></item>
        /// <item><description>If the logical relationship among the specified conditions is AND, only tags that match all the specified conditions are returned.</description></item>
        /// <item><description>If the Tagkey parameter is specified and but Tagvalue parameter is not specified, all tags that contain the specified tag key are returned.</description></item>
        /// <item><description>If you specify the Tagvalue parameter in a request, you must also specify the Tagkey parameter in the request.</description></item>
        /// <item><description>If you specify both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTagsResponse
        /// </returns>
        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupAttributeResponse
        /// </returns>
        public DescribeVServerGroupAttributeResponse DescribeVServerGroupAttributeWithOptions(DescribeVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVServerGroupAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVServerGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupAttributeResponse
        /// </returns>
        public async Task<DescribeVServerGroupAttributeResponse> DescribeVServerGroupAttributeWithOptionsAsync(DescribeVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVServerGroupAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVServerGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupAttributeResponse
        /// </returns>
        public DescribeVServerGroupAttributeResponse DescribeVServerGroupAttribute(DescribeVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVServerGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupAttributeResponse
        /// </returns>
        public async Task<DescribeVServerGroupAttributeResponse> DescribeVServerGroupAttributeAsync(DescribeVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries vServer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupsResponse
        /// </returns>
        public DescribeVServerGroupsResponse DescribeVServerGroupsWithOptions(DescribeVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeListener))
            {
                query["IncludeListener"] = request.IncludeListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRule))
            {
                query["IncludeRule"] = request.IncludeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DescribeVServerGroups",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVServerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries vServer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupsResponse
        /// </returns>
        public async Task<DescribeVServerGroupsResponse> DescribeVServerGroupsWithOptionsAsync(DescribeVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeListener))
            {
                query["IncludeListener"] = request.IncludeListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRule))
            {
                query["IncludeRule"] = request.IncludeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DescribeVServerGroups",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVServerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries vServer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupsResponse
        /// </returns>
        public DescribeVServerGroupsResponse DescribeVServerGroups(DescribeVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVServerGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries vServer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVServerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVServerGroupsResponse
        /// </returns>
        public async Task<DescribeVServerGroupsResponse> DescribeVServerGroupsAsync(DescribeVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVServerGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the zones in a region.</para>
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2014-05-15",
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
        /// <para>Queries the zones in a region.</para>
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2014-05-15",
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
        /// <para>Queries the zones in a region.</para>
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
        /// <para>Queries the zones in a region.</para>
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
        /// <para>Enables fine-grained monitoring for the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHighDefinationMonitorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableHighDefinationMonitorResponse
        /// </returns>
        public EnableHighDefinationMonitorResponse EnableHighDefinationMonitorWithOptions(EnableHighDefinationMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                query["LogProject"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
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
                Action = "EnableHighDefinationMonitor",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHighDefinationMonitorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables fine-grained monitoring for the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHighDefinationMonitorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableHighDefinationMonitorResponse
        /// </returns>
        public async Task<EnableHighDefinationMonitorResponse> EnableHighDefinationMonitorWithOptionsAsync(EnableHighDefinationMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                query["LogProject"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
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
                Action = "EnableHighDefinationMonitor",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHighDefinationMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables fine-grained monitoring for the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHighDefinationMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableHighDefinationMonitorResponse
        /// </returns>
        public EnableHighDefinationMonitorResponse EnableHighDefinationMonitor(EnableHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHighDefinationMonitorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables fine-grained monitoring for the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableHighDefinationMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableHighDefinationMonitorResponse
        /// </returns>
        public async Task<EnableHighDefinationMonitorResponse> EnableHighDefinationMonitorAsync(EnableHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHighDefinationMonitorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Transport Layer Security (TLS) policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTLSCipherPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTLSCipherPoliciesResponse
        /// </returns>
        public ListTLSCipherPoliciesResponse ListTLSCipherPoliciesWithOptions(ListTLSCipherPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeListener))
            {
                query["IncludeListener"] = request.IncludeListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicyId))
            {
                query["TLSCipherPolicyId"] = request.TLSCipherPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTLSCipherPolicies",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTLSCipherPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Transport Layer Security (TLS) policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTLSCipherPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTLSCipherPoliciesResponse
        /// </returns>
        public async Task<ListTLSCipherPoliciesResponse> ListTLSCipherPoliciesWithOptionsAsync(ListTLSCipherPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeListener))
            {
                query["IncludeListener"] = request.IncludeListener;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicyId))
            {
                query["TLSCipherPolicyId"] = request.TLSCipherPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTLSCipherPolicies",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTLSCipherPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Transport Layer Security (TLS) policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTLSCipherPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTLSCipherPoliciesResponse
        /// </returns>
        public ListTLSCipherPoliciesResponse ListTLSCipherPolicies(ListTLSCipherPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTLSCipherPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Transport Layer Security (TLS) policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTLSCipherPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTLSCipherPoliciesResponse
        /// </returns>
        public async Task<ListTLSCipherPoliciesResponse> ListTLSCipherPoliciesAsync(ListTLSCipherPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTLSCipherPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified tag key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2014-05-15",
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
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified tag key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2014-05-15",
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
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified tag key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
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
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified tag key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
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
        /// <para>Modifies the configuration of fine-grained monitoring in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHighDefinationMonitorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyHighDefinationMonitorResponse
        /// </returns>
        public ModifyHighDefinationMonitorResponse ModifyHighDefinationMonitorWithOptions(ModifyHighDefinationMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                query["LogProject"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHighDefinationMonitor",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHighDefinationMonitorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of fine-grained monitoring in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHighDefinationMonitorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyHighDefinationMonitorResponse
        /// </returns>
        public async Task<ModifyHighDefinationMonitorResponse> ModifyHighDefinationMonitorWithOptionsAsync(ModifyHighDefinationMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                query["LogProject"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHighDefinationMonitor",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHighDefinationMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of fine-grained monitoring in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHighDefinationMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyHighDefinationMonitorResponse
        /// </returns>
        public ModifyHighDefinationMonitorResponse ModifyHighDefinationMonitor(ModifyHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHighDefinationMonitorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of fine-grained monitoring in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyHighDefinationMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyHighDefinationMonitorResponse
        /// </returns>
        public async Task<ModifyHighDefinationMonitorResponse> ModifyHighDefinationMonitorAsync(ModifyHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHighDefinationMonitorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.</description></item>
        /// <item><description>This operation can change the metering method of only one instance at a time.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceChargeTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceChargeTypeResponse
        /// </returns>
        public ModifyLoadBalancerInstanceChargeTypeResponse ModifyLoadBalancerInstanceChargeTypeWithOptions(ModifyLoadBalancerInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                query["LoadBalancerSpec"] = request.LoadBalancerSpec;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLoadBalancerInstanceChargeType",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerInstanceChargeTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.</description></item>
        /// <item><description>This operation can change the metering method of only one instance at a time.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceChargeTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceChargeTypeResponse
        /// </returns>
        public async Task<ModifyLoadBalancerInstanceChargeTypeResponse> ModifyLoadBalancerInstanceChargeTypeWithOptionsAsync(ModifyLoadBalancerInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                query["LoadBalancerSpec"] = request.LoadBalancerSpec;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLoadBalancerInstanceChargeType",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerInstanceChargeTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.</description></item>
        /// <item><description>This operation can change the metering method of only one instance at a time.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceChargeTypeResponse
        /// </returns>
        public ModifyLoadBalancerInstanceChargeTypeResponse ModifyLoadBalancerInstanceChargeType(ModifyLoadBalancerInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInstanceChargeTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.</description></item>
        /// <item><description>This operation can change the metering method of only one instance at a time.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceChargeTypeResponse
        /// </returns>
        public async Task<ModifyLoadBalancerInstanceChargeTypeResponse> ModifyLoadBalancerInstanceChargeTypeAsync(ModifyLoadBalancerInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInstanceChargeTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specification of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceSpecResponse
        /// </returns>
        public ModifyLoadBalancerInstanceSpecResponse ModifyLoadBalancerInstanceSpecWithOptions(ModifyLoadBalancerInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                query["LoadBalancerSpec"] = request.LoadBalancerSpec;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLoadBalancerInstanceSpec",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specification of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceSpecResponse
        /// </returns>
        public async Task<ModifyLoadBalancerInstanceSpecResponse> ModifyLoadBalancerInstanceSpecWithOptionsAsync(ModifyLoadBalancerInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                query["LoadBalancerSpec"] = request.LoadBalancerSpec;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLoadBalancerInstanceSpec",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specification of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceSpecResponse
        /// </returns>
        public ModifyLoadBalancerInstanceSpecResponse ModifyLoadBalancerInstanceSpec(ModifyLoadBalancerInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInstanceSpecWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specification of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInstanceSpecResponse
        /// </returns>
        public async Task<ModifyLoadBalancerInstanceSpecResponse> ModifyLoadBalancerInstanceSpecAsync(ModifyLoadBalancerInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInstanceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.</description></item>
        /// <item><description>If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInternetSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInternetSpecResponse
        /// </returns>
        public ModifyLoadBalancerInternetSpecResponse ModifyLoadBalancerInternetSpecWithOptions(ModifyLoadBalancerInternetSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLoadBalancerInternetSpec",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerInternetSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.</description></item>
        /// <item><description>If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInternetSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInternetSpecResponse
        /// </returns>
        public async Task<ModifyLoadBalancerInternetSpecResponse> ModifyLoadBalancerInternetSpecWithOptionsAsync(ModifyLoadBalancerInternetSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyLoadBalancerInternetSpec",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerInternetSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.</description></item>
        /// <item><description>If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInternetSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInternetSpecResponse
        /// </returns>
        public ModifyLoadBalancerInternetSpecResponse ModifyLoadBalancerInternetSpec(ModifyLoadBalancerInternetSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInternetSpecWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.</description></item>
        /// <item><description>If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerInternetSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerInternetSpecResponse
        /// </returns>
        public async Task<ModifyLoadBalancerInternetSpecResponse> ModifyLoadBalancerInternetSpecAsync(ModifyLoadBalancerInternetSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInternetSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLoadBalancerPayType is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerPayTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerPayTypeResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLoadBalancerPayType is deprecated")]
        // Deprecated
        public ModifyLoadBalancerPayTypeResponse ModifyLoadBalancerPayTypeWithOptions(ModifyLoadBalancerPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
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
                Action = "ModifyLoadBalancerPayType",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerPayTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLoadBalancerPayType is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerPayTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerPayTypeResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLoadBalancerPayType is deprecated")]
        // Deprecated
        public async Task<ModifyLoadBalancerPayTypeResponse> ModifyLoadBalancerPayTypeWithOptionsAsync(ModifyLoadBalancerPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
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
                Action = "ModifyLoadBalancerPayType",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyLoadBalancerPayTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLoadBalancerPayType is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerPayTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerPayTypeResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLoadBalancerPayType is deprecated")]
        // Deprecated
        public ModifyLoadBalancerPayTypeResponse ModifyLoadBalancerPayType(ModifyLoadBalancerPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerPayTypeWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyLoadBalancerPayType is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyLoadBalancerPayTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyLoadBalancerPayTypeResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyLoadBalancerPayType is deprecated")]
        // Deprecated
        public async Task<ModifyLoadBalancerPayTypeResponse> ModifyLoadBalancerPayTypeAsync(ModifyLoadBalancerPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerPayTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used only to replace backend servers in a vServer group. To modify the attributes of backend servers, such as weights, call the <a href="https://help.aliyun.com/document_detail/35217.html">SetVServerGroupAttribute</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVServerGroupBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVServerGroupBackendServersResponse
        /// </returns>
        public ModifyVServerGroupBackendServersResponse ModifyVServerGroupBackendServersWithOptions(ModifyVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBackendServers))
            {
                query["NewBackendServers"] = request.NewBackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldBackendServers))
            {
                query["OldBackendServers"] = request.OldBackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVServerGroupBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVServerGroupBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used only to replace backend servers in a vServer group. To modify the attributes of backend servers, such as weights, call the <a href="https://help.aliyun.com/document_detail/35217.html">SetVServerGroupAttribute</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVServerGroupBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVServerGroupBackendServersResponse
        /// </returns>
        public async Task<ModifyVServerGroupBackendServersResponse> ModifyVServerGroupBackendServersWithOptionsAsync(ModifyVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewBackendServers))
            {
                query["NewBackendServers"] = request.NewBackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldBackendServers))
            {
                query["OldBackendServers"] = request.OldBackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVServerGroupBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVServerGroupBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used only to replace backend servers in a vServer group. To modify the attributes of backend servers, such as weights, call the <a href="https://help.aliyun.com/document_detail/35217.html">SetVServerGroupAttribute</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVServerGroupBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVServerGroupBackendServersResponse
        /// </returns>
        public ModifyVServerGroupBackendServersResponse ModifyVServerGroupBackendServers(ModifyVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVServerGroupBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used only to replace backend servers in a vServer group. To modify the attributes of backend servers, such as weights, call the <a href="https://help.aliyun.com/document_detail/35217.html">SetVServerGroupAttribute</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVServerGroupBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVServerGroupBackendServersResponse
        /// </returns>
        public async Task<ModifyVServerGroupBackendServersResponse> ModifyVServerGroupBackendServersAsync(ModifyVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource to another resource group.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2014-05-15",
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
        /// <para>Moves a resource to another resource group.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyId))
            {
                query["access_key_id"] = request.AccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2014-05-15",
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
        /// <para>Moves a resource to another resource group.</para>
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
        /// <para>Moves a resource to another resource group.</para>
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
        /// <para>Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAccessControlListEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveAccessControlListEntryResponse
        /// </returns>
        public RemoveAccessControlListEntryResponse RemoveAccessControlListEntryWithOptions(RemoveAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntrys))
            {
                query["AclEntrys"] = request.AclEntrys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAccessControlListEntry",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAccessControlListEntryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAccessControlListEntryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveAccessControlListEntryResponse
        /// </returns>
        public async Task<RemoveAccessControlListEntryResponse> RemoveAccessControlListEntryWithOptionsAsync(RemoveAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntrys))
            {
                query["AclEntrys"] = request.AclEntrys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAccessControlListEntry",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAccessControlListEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAccessControlListEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveAccessControlListEntryResponse
        /// </returns>
        public RemoveAccessControlListEntryResponse RemoveAccessControlListEntry(RemoveAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAccessControlListEntryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAccessControlListEntryRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveAccessControlListEntryResponse
        /// </returns>
        public async Task<RemoveAccessControlListEntryResponse> RemoveAccessControlListEntryAsync(RemoveAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAccessControlListEntryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public RemoveBackendServersResponse RemoveBackendServersWithOptions(RemoveBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public async Task<RemoveBackendServersResponse> RemoveBackendServersWithOptionsAsync(RemoveBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public RemoveBackendServersResponse RemoveBackendServers(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveBackendServersResponse
        /// </returns>
        public async Task<RemoveBackendServersResponse> RemoveBackendServersAsync(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP addresses or CIDR blocks from the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveListenerWhiteListItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveListenerWhiteListItemResponse
        /// </returns>
        public RemoveListenerWhiteListItemResponse RemoveListenerWhiteListItemWithOptions(RemoveListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceItems))
            {
                query["SourceItems"] = request.SourceItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveListenerWhiteListItem",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveListenerWhiteListItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP addresses or CIDR blocks from the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveListenerWhiteListItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveListenerWhiteListItemResponse
        /// </returns>
        public async Task<RemoveListenerWhiteListItemResponse> RemoveListenerWhiteListItemWithOptionsAsync(RemoveListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceItems))
            {
                query["SourceItems"] = request.SourceItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveListenerWhiteListItem",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveListenerWhiteListItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP addresses or CIDR blocks from the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveListenerWhiteListItemRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveListenerWhiteListItemResponse
        /// </returns>
        public RemoveListenerWhiteListItemResponse RemoveListenerWhiteListItem(RemoveListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveListenerWhiteListItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes IP addresses or CIDR blocks from the whitelist of a listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveListenerWhiteListItemRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveListenerWhiteListItemResponse
        /// </returns>
        public async Task<RemoveListenerWhiteListItemResponse> RemoveListenerWhiteListItemAsync(RemoveListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveListenerWhiteListItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagsResponse
        /// </returns>
        public RemoveTagsResponse RemoveTagsWithOptions(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "RemoveTags",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagsResponse
        /// </returns>
        public async Task<RemoveTagsResponse> RemoveTagsWithOptionsAsync(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "RemoveTags",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagsResponse
        /// </returns>
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTagsResponse
        /// </returns>
        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers specified by the <b>BackendServers</b> parameter do not exist in the vServer group, the backend servers are ignored. No error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveVServerGroupBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveVServerGroupBackendServersResponse
        /// </returns>
        public RemoveVServerGroupBackendServersResponse RemoveVServerGroupBackendServersWithOptions(RemoveVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveVServerGroupBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveVServerGroupBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers specified by the <b>BackendServers</b> parameter do not exist in the vServer group, the backend servers are ignored. No error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveVServerGroupBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveVServerGroupBackendServersResponse
        /// </returns>
        public async Task<RemoveVServerGroupBackendServersResponse> RemoveVServerGroupBackendServersWithOptionsAsync(RemoveVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveVServerGroupBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveVServerGroupBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers specified by the <b>BackendServers</b> parameter do not exist in the vServer group, the backend servers are ignored. No error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveVServerGroupBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveVServerGroupBackendServersResponse
        /// </returns>
        public RemoveVServerGroupBackendServersResponse RemoveVServerGroupBackendServers(RemoveVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVServerGroupBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If the backend servers specified by the <b>BackendServers</b> parameter do not exist in the vServer group, the backend servers are ignored. No error message is returned.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveVServerGroupBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveVServerGroupBackendServersResponse
        /// </returns>
        public async Task<RemoveVServerGroupBackendServersResponse> RemoveVServerGroupBackendServersAsync(RemoveVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessControlListAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAccessControlListAttributeResponse
        /// </returns>
        public SetAccessControlListAttributeResponse SetAccessControlListAttributeWithOptions(SetAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAccessControlListAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccessControlListAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessControlListAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAccessControlListAttributeResponse
        /// </returns>
        public async Task<SetAccessControlListAttributeResponse> SetAccessControlListAttributeWithOptionsAsync(SetAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAccessControlListAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccessControlListAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessControlListAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAccessControlListAttributeResponse
        /// </returns>
        public SetAccessControlListAttributeResponse SetAccessControlListAttribute(SetAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccessControlListAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessControlListAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAccessControlListAttributeResponse
        /// </returns>
        public async Task<SetAccessControlListAttributeResponse> SetAccessControlListAttributeAsync(SetAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccessControlListAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an access log forwarding rule to a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessLogsDownloadAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAccessLogsDownloadAttributeResponse
        /// </returns>
        public SetAccessLogsDownloadAttributeResponse SetAccessLogsDownloadAttributeWithOptions(SetAccessLogsDownloadAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogsDownloadAttributes))
            {
                query["LogsDownloadAttributes"] = request.LogsDownloadAttributes;
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
                Action = "SetAccessLogsDownloadAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccessLogsDownloadAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an access log forwarding rule to a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessLogsDownloadAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAccessLogsDownloadAttributeResponse
        /// </returns>
        public async Task<SetAccessLogsDownloadAttributeResponse> SetAccessLogsDownloadAttributeWithOptionsAsync(SetAccessLogsDownloadAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogsDownloadAttributes))
            {
                query["LogsDownloadAttributes"] = request.LogsDownloadAttributes;
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
                Action = "SetAccessLogsDownloadAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccessLogsDownloadAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an access log forwarding rule to a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessLogsDownloadAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAccessLogsDownloadAttributeResponse
        /// </returns>
        public SetAccessLogsDownloadAttributeResponse SetAccessLogsDownloadAttribute(SetAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccessLogsDownloadAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an access log forwarding rule to a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAccessLogsDownloadAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAccessLogsDownloadAttributeResponse
        /// </returns>
        public async Task<SetAccessLogsDownloadAttributeResponse> SetAccessLogsDownloadAttributeAsync(SetAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccessLogsDownloadAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies weights for backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetBackendServersResponse
        /// </returns>
        public SetBackendServersResponse SetBackendServersWithOptions(SetBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBackendServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies weights for backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBackendServersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetBackendServersResponse
        /// </returns>
        public async Task<SetBackendServersResponse> SetBackendServersWithOptionsAsync(SetBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetBackendServers",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetBackendServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies weights for backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// SetBackendServersResponse
        /// </returns>
        public SetBackendServersResponse SetBackendServers(SetBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackendServersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies weights for backend servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetBackendServersRequest
        /// </param>
        /// 
        /// <returns>
        /// SetBackendServersResponse
        /// </returns>
        public async Task<SetBackendServersResponse> SetBackendServersAsync(SetBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackendServersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a name for a CA certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCACertificateNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCACertificateNameResponse
        /// </returns>
        public SetCACertificateNameResponse SetCACertificateNameWithOptions(SetCACertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateName))
            {
                query["CACertificateName"] = request.CACertificateName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCACertificateName",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCACertificateNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a name for a CA certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCACertificateNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetCACertificateNameResponse
        /// </returns>
        public async Task<SetCACertificateNameResponse> SetCACertificateNameWithOptionsAsync(SetCACertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateName))
            {
                query["CACertificateName"] = request.CACertificateName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCACertificateName",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCACertificateNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a name for a CA certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCACertificateNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCACertificateNameResponse
        /// </returns>
        public SetCACertificateNameResponse SetCACertificateName(SetCACertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCACertificateNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a name for a CA certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetCACertificateNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetCACertificateNameResponse
        /// </returns>
        public async Task<SetCACertificateNameResponse> SetCACertificateNameAsync(SetCACertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCACertificateNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces the certificate of an additional domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDomainExtensionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDomainExtensionAttributeResponse
        /// </returns>
        public SetDomainExtensionAttributeResponse SetDomainExtensionAttributeWithOptions(SetDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainExtensionAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainExtensionAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces the certificate of an additional domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDomainExtensionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDomainExtensionAttributeResponse
        /// </returns>
        public async Task<SetDomainExtensionAttributeResponse> SetDomainExtensionAttributeWithOptionsAsync(SetDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainExtensionId))
            {
                query["DomainExtensionId"] = request.DomainExtensionId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainExtensionAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainExtensionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces the certificate of an additional domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDomainExtensionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDomainExtensionAttributeResponse
        /// </returns>
        public SetDomainExtensionAttributeResponse SetDomainExtensionAttribute(SetDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainExtensionAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces the certificate of an additional domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDomainExtensionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDomainExtensionAttributeResponse
        /// </returns>
        public async Task<SetDomainExtensionAttributeResponse> SetDomainExtensionAttributeAsync(SetDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainExtensionAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the whitelist of a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetListenerAccessControlStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetListenerAccessControlStatusResponse
        /// </returns>
        public SetListenerAccessControlStatusResponse SetListenerAccessControlStatusWithOptions(SetListenerAccessControlStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlStatus))
            {
                query["AccessControlStatus"] = request.AccessControlStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetListenerAccessControlStatus",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetListenerAccessControlStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the whitelist of a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetListenerAccessControlStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetListenerAccessControlStatusResponse
        /// </returns>
        public async Task<SetListenerAccessControlStatusResponse> SetListenerAccessControlStatusWithOptionsAsync(SetListenerAccessControlStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlStatus))
            {
                query["AccessControlStatus"] = request.AccessControlStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetListenerAccessControlStatus",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetListenerAccessControlStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the whitelist of a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetListenerAccessControlStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetListenerAccessControlStatusResponse
        /// </returns>
        public SetListenerAccessControlStatusResponse SetListenerAccessControlStatus(SetListenerAccessControlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetListenerAccessControlStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the whitelist of a specified listener.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetListenerAccessControlStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetListenerAccessControlStatusResponse
        /// </returns>
        public async Task<SetListenerAccessControlStatusResponse> SetListenerAccessControlStatusAsync(SetListenerAccessControlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetListenerAccessControlStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for an SLB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerDeleteProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerDeleteProtectionResponse
        /// </returns>
        public SetLoadBalancerDeleteProtectionResponse SetLoadBalancerDeleteProtectionWithOptions(SetLoadBalancerDeleteProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteProtection))
            {
                query["DeleteProtection"] = request.DeleteProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerDeleteProtection",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerDeleteProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for an SLB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerDeleteProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerDeleteProtectionResponse
        /// </returns>
        public async Task<SetLoadBalancerDeleteProtectionResponse> SetLoadBalancerDeleteProtectionWithOptionsAsync(SetLoadBalancerDeleteProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteProtection))
            {
                query["DeleteProtection"] = request.DeleteProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerDeleteProtection",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerDeleteProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for an SLB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerDeleteProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerDeleteProtectionResponse
        /// </returns>
        public SetLoadBalancerDeleteProtectionResponse SetLoadBalancerDeleteProtection(SetLoadBalancerDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerDeleteProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for an SLB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerDeleteProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerDeleteProtectionResponse
        /// </returns>
        public async Task<SetLoadBalancerDeleteProtectionResponse> SetLoadBalancerDeleteProtectionAsync(SetLoadBalancerDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerDeleteProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttributeWithOptions(SetLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerHTTPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(SetLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerHTTPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttribute(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>An HTTP listener is created. For more information about how to create an HTTP listener, see <a href="https://help.aliyun.com/document_detail/27592.html">CreateLoadBalancerHTTPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeAsync(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerHTTPSListenerAttributeResponse SetLoadBalancerHTTPSListenerAttributeWithOptions(SetLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHttp2))
            {
                query["EnableHttp2"] = request.EnableHttp2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicy))
            {
                query["TLSCipherPolicy"] = request.TLSCipherPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerHTTPSListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPSListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerHTTPSListenerAttributeResponse> SetLoadBalancerHTTPSListenerAttributeWithOptionsAsync(SetLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateId))
            {
                query["CACertificateId"] = request.CACertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHttp2))
            {
                query["EnableHttp2"] = request.EnableHttp2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gzip))
            {
                query["Gzip"] = request.Gzip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicy))
            {
                query["TLSCipherPolicy"] = request.TLSCipherPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor))
            {
                query["XForwardedFor"] = request.XForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_ClientSrcPort))
            {
                query["XForwardedFor_ClientSrcPort"] = request.XForwardedFor_ClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBID))
            {
                query["XForwardedFor_SLBID"] = request.XForwardedFor_SLBID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBIP))
            {
                query["XForwardedFor_SLBIP"] = request.XForwardedFor_SLBIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_SLBPORT))
            {
                query["XForwardedFor_SLBPORT"] = request.XForwardedFor_SLBPORT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedFor_proto))
            {
                query["XForwardedFor_proto"] = request.XForwardedFor_proto;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerHTTPSListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPSListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerHTTPSListenerAttributeResponse SetLoadBalancerHTTPSListenerAttribute(SetLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPSListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an HTTPS listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>An HTTPS listener is created. For more information about how to create an HTTPS listener, see <a href="https://help.aliyun.com/document_detail/27593.html">CreateLoadBalancerHTTPSListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerHTTPSListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerHTTPSListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerHTTPSListenerAttributeResponse> SetLoadBalancerHTTPSListenerAttributeAsync(SetLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPSListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerModificationProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerModificationProtectionResponse
        /// </returns>
        public SetLoadBalancerModificationProtectionResponse SetLoadBalancerModificationProtectionWithOptions(SetLoadBalancerModificationProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionReason))
            {
                query["ModificationProtectionReason"] = request.ModificationProtectionReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionStatus))
            {
                query["ModificationProtectionStatus"] = request.ModificationProtectionStatus;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerModificationProtection",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerModificationProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerModificationProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerModificationProtectionResponse
        /// </returns>
        public async Task<SetLoadBalancerModificationProtectionResponse> SetLoadBalancerModificationProtectionWithOptionsAsync(SetLoadBalancerModificationProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionReason))
            {
                query["ModificationProtectionReason"] = request.ModificationProtectionReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionStatus))
            {
                query["ModificationProtectionStatus"] = request.ModificationProtectionStatus;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerModificationProtection",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerModificationProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerModificationProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerModificationProtectionResponse
        /// </returns>
        public SetLoadBalancerModificationProtectionResponse SetLoadBalancerModificationProtection(SetLoadBalancerModificationProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerModificationProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerModificationProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerModificationProtectionResponse
        /// </returns>
        public async Task<SetLoadBalancerModificationProtectionResponse> SetLoadBalancerModificationProtectionAsync(SetLoadBalancerModificationProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerModificationProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public SetLoadBalancerNameResponse SetLoadBalancerNameWithOptions(SetLoadBalancerNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerName",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameWithOptionsAsync(SetLoadBalancerNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerName",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public SetLoadBalancerNameResponse SetLoadBalancerName(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerNameResponse
        /// </returns>
        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameAsync(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the state of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public SetLoadBalancerStatusResponse SetLoadBalancerStatusWithOptions(SetLoadBalancerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerStatus",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the state of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusWithOptionsAsync(SetLoadBalancerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerStatus",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the state of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public SetLoadBalancerStatusResponse SetLoadBalancerStatus(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the state of a Classic Load Balancer (CLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoadBalancerStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerStatusResponse
        /// </returns>
        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusAsync(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A TCP listener is created. For more information, see <a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttributeWithOptions(SetLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrain))
            {
                query["ConnectionDrain"] = request.ConnectionDrain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainTimeout))
            {
                query["ConnectionDrainTimeout"] = request.ConnectionDrainTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstablishedTimeout))
            {
                query["EstablishedTimeout"] = request.EstablishedTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroup))
            {
                query["MasterSlaveServerGroup"] = request.MasterSlaveServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynProxy))
            {
                query["SynProxy"] = request.SynProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerTCPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerTCPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A TCP listener is created. For more information, see <a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeWithOptionsAsync(SetLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrain))
            {
                query["ConnectionDrain"] = request.ConnectionDrain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainTimeout))
            {
                query["ConnectionDrainTimeout"] = request.ConnectionDrainTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstablishedTimeout))
            {
                query["EstablishedTimeout"] = request.EstablishedTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckType))
            {
                query["HealthCheckType"] = request.HealthCheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroup))
            {
                query["MasterSlaveServerGroup"] = request.MasterSlaveServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersistenceTimeout))
            {
                query["PersistenceTimeout"] = request.PersistenceTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynProxy))
            {
                query["SynProxy"] = request.SynProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerTCPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerTCPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A TCP listener is created. For more information, see <a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttribute(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A CLB instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/2401685.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A TCP listener is created. For more information, see <a href="~~CreateLoadBalancerTCPListener~~">CreateLoadBalancerTCPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerTCPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerTCPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeAsync(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A UDP listener is created. For more information, see <a href="https://help.aliyun.com/document_detail/27595.html">CreateLoadBalancerUDPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerUDPListenerAttributeResponse SetLoadBalancerUDPListenerAttributeWithOptions(SetLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroup))
            {
                query["MasterSlaveServerGroup"] = request.MasterSlaveServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckExp))
            {
                query["healthCheckExp"] = request.HealthCheckExp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckReq))
            {
                query["healthCheckReq"] = request.HealthCheckReq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerUDPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerUDPListenerAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A UDP listener is created. For more information, see <a href="https://help.aliyun.com/document_detail/27595.html">CreateLoadBalancerUDPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerUDPListenerAttributeResponse> SetLoadBalancerUDPListenerAttributeWithOptionsAsync(SetLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclStatus))
            {
                query["AclStatus"] = request.AclStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectTimeout))
            {
                query["HealthCheckConnectTimeout"] = request.HealthCheckConnectTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSwitch))
            {
                query["HealthCheckSwitch"] = request.HealthCheckSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroup))
            {
                query["MasterSlaveServerGroup"] = request.MasterSlaveServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSlaveServerGroupId))
            {
                query["MasterSlaveServerGroupId"] = request.MasterSlaveServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyProtocolV2Enabled))
            {
                query["ProxyProtocolV2Enabled"] = request.ProxyProtocolV2Enabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroup))
            {
                query["VServerGroup"] = request.VServerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckExp))
            {
                query["healthCheckExp"] = request.HealthCheckExp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckReq))
            {
                query["healthCheckReq"] = request.HealthCheckReq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoadBalancerUDPListenerAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoadBalancerUDPListenerAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A UDP listener is created. For more information, see <a href="https://help.aliyun.com/document_detail/27595.html">CreateLoadBalancerUDPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public SetLoadBalancerUDPListenerAttributeResponse SetLoadBalancerUDPListenerAttribute(SetLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerUDPListenerAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a UDP listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A Classic Load Balancer (CLB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/27577.html">CreateLoadBalancer</a>.</para>
        /// <list type="bullet">
        /// <item><description>A UDP listener is created. For more information, see <a href="https://help.aliyun.com/document_detail/27595.html">CreateLoadBalancerUDPListener</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetLoadBalancerUDPListenerAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoadBalancerUDPListenerAttributeResponse
        /// </returns>
        public async Task<SetLoadBalancerUDPListenerAttributeResponse> SetLoadBalancerUDPListenerAttributeAsync(SetLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerUDPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a forwarding rule that is associated with a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRuleResponse
        /// </returns>
        public SetRuleResponse SetRuleWithOptions(SetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerSync))
            {
                query["ListenerSync"] = request.ListenerSync;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRule",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a forwarding rule that is associated with a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRuleResponse
        /// </returns>
        public async Task<SetRuleResponse> SetRuleWithOptionsAsync(SetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cookie))
            {
                query["Cookie"] = request.Cookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CookieTimeout))
            {
                query["CookieTimeout"] = request.CookieTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckDomain))
            {
                query["HealthCheckDomain"] = request.HealthCheckDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpCode))
            {
                query["HealthCheckHttpCode"] = request.HealthCheckHttpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckURI))
            {
                query["HealthCheckURI"] = request.HealthCheckURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerSync))
            {
                query["ListenerSync"] = request.ListenerSync;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySession))
            {
                query["StickySession"] = request.StickySession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionType))
            {
                query["StickySessionType"] = request.StickySessionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRule",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a forwarding rule that is associated with a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRuleResponse
        /// </returns>
        public SetRuleResponse SetRule(SetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a forwarding rule that is associated with a vServer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRuleResponse
        /// </returns>
        public async Task<SetRuleResponse> SetRuleAsync(SetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a name for a server certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServerCertificateNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetServerCertificateNameResponse
        /// </returns>
        public SetServerCertificateNameResponse SetServerCertificateNameWithOptions(SetServerCertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateName))
            {
                query["ServerCertificateName"] = request.ServerCertificateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetServerCertificateName",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetServerCertificateNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a name for a server certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServerCertificateNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetServerCertificateNameResponse
        /// </returns>
        public async Task<SetServerCertificateNameResponse> SetServerCertificateNameWithOptionsAsync(SetServerCertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateId))
            {
                query["ServerCertificateId"] = request.ServerCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateName))
            {
                query["ServerCertificateName"] = request.ServerCertificateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetServerCertificateName",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetServerCertificateNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a name for a server certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServerCertificateNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetServerCertificateNameResponse
        /// </returns>
        public SetServerCertificateNameResponse SetServerCertificateName(SetServerCertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetServerCertificateNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a name for a server certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServerCertificateNameRequest
        /// </param>
        /// 
        /// <returns>
        /// SetServerCertificateNameResponse
        /// </returns>
        public async Task<SetServerCertificateNameResponse> SetServerCertificateNameAsync(SetServerCertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetServerCertificateNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTLSCipherPolicyAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTLSCipherPolicyAttributeResponse
        /// </returns>
        public SetTLSCipherPolicyAttributeResponse SetTLSCipherPolicyAttributeWithOptions(SetTLSCipherPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicyId))
            {
                query["TLSCipherPolicyId"] = request.TLSCipherPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSVersions))
            {
                query["TLSVersions"] = request.TLSVersions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTLSCipherPolicyAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTLSCipherPolicyAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTLSCipherPolicyAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTLSCipherPolicyAttributeResponse
        /// </returns>
        public async Task<SetTLSCipherPolicyAttributeResponse> SetTLSCipherPolicyAttributeWithOptionsAsync(SetTLSCipherPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSCipherPolicyId))
            {
                query["TLSCipherPolicyId"] = request.TLSCipherPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSVersions))
            {
                query["TLSVersions"] = request.TLSVersions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTLSCipherPolicyAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTLSCipherPolicyAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTLSCipherPolicyAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTLSCipherPolicyAttributeResponse
        /// </returns>
        public SetTLSCipherPolicyAttributeResponse SetTLSCipherPolicyAttribute(SetTLSCipherPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTLSCipherPolicyAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Transport Layer Security (TLS) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTLSCipherPolicyAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTLSCipherPolicyAttributeResponse
        /// </returns>
        public async Task<SetTLSCipherPolicyAttributeResponse> SetTLSCipherPolicyAttributeAsync(SetTLSCipherPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTLSCipherPolicyAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used to modify the weights of backend servers and names of vServer groups.</para>
        /// <list type="bullet">
        /// <item><description>If you want to modify backend servers in a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35220.html">ModifyVServerGroupBackendServers</a> operation.</description></item>
        /// <item><description>If you want to add backend servers to a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35218.html">AddVServerGroupBackendServers</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetVServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetVServerGroupAttributeResponse
        /// </returns>
        public SetVServerGroupAttributeResponse SetVServerGroupAttributeWithOptions(SetVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetVServerGroupAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetVServerGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used to modify the weights of backend servers and names of vServer groups.</para>
        /// <list type="bullet">
        /// <item><description>If you want to modify backend servers in a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35220.html">ModifyVServerGroupBackendServers</a> operation.</description></item>
        /// <item><description>If you want to add backend servers to a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35218.html">AddVServerGroupBackendServers</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetVServerGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetVServerGroupAttributeResponse
        /// </returns>
        public async Task<SetVServerGroupAttributeResponse> SetVServerGroupAttributeWithOptionsAsync(SetVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendServers))
            {
                query["BackendServers"] = request.BackendServers;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupId))
            {
                query["VServerGroupId"] = request.VServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VServerGroupName))
            {
                query["VServerGroupName"] = request.VServerGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetVServerGroupAttribute",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetVServerGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used to modify the weights of backend servers and names of vServer groups.</para>
        /// <list type="bullet">
        /// <item><description>If you want to modify backend servers in a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35220.html">ModifyVServerGroupBackendServers</a> operation.</description></item>
        /// <item><description>If you want to add backend servers to a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35218.html">AddVServerGroupBackendServers</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetVServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetVServerGroupAttributeResponse
        /// </returns>
        public SetVServerGroupAttributeResponse SetVServerGroupAttribute(SetVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVServerGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a vServer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be used to modify the weights of backend servers and names of vServer groups.</para>
        /// <list type="bullet">
        /// <item><description>If you want to modify backend servers in a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35220.html">ModifyVServerGroupBackendServers</a> operation.</description></item>
        /// <item><description>If you want to add backend servers to a specified vServer group, call the <a href="https://help.aliyun.com/document_detail/35218.html">AddVServerGroupBackendServers</a> operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetVServerGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetVServerGroupAttributeResponse
        /// </returns>
        public async Task<SetVServerGroupAttributeResponse> SetVServerGroupAttributeAsync(SetVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can call the operation only when the listener is in the Stopped state.</description></item>
        /// <item><description>If the operation is successful, the listener switches to the Starting state.</description></item>
        /// <item><description>You cannot perform this operation when the Classic Load Balancer (CLB) instance to which the listener belongs is in the Locked state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLoadBalancerListenerResponse
        /// </returns>
        public StartLoadBalancerListenerResponse StartLoadBalancerListenerWithOptions(StartLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLoadBalancerListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLoadBalancerListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can call the operation only when the listener is in the Stopped state.</description></item>
        /// <item><description>If the operation is successful, the listener switches to the Starting state.</description></item>
        /// <item><description>You cannot perform this operation when the Classic Load Balancer (CLB) instance to which the listener belongs is in the Locked state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLoadBalancerListenerResponse
        /// </returns>
        public async Task<StartLoadBalancerListenerResponse> StartLoadBalancerListenerWithOptionsAsync(StartLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLoadBalancerListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLoadBalancerListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can call the operation only when the listener is in the Stopped state.</description></item>
        /// <item><description>If the operation is successful, the listener switches to the Starting state.</description></item>
        /// <item><description>You cannot perform this operation when the Classic Load Balancer (CLB) instance to which the listener belongs is in the Locked state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLoadBalancerListenerResponse
        /// </returns>
        public StartLoadBalancerListenerResponse StartLoadBalancerListener(StartLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLoadBalancerListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You can call the operation only when the listener is in the Stopped state.</description></item>
        /// <item><description>If the operation is successful, the listener switches to the Starting state.</description></item>
        /// <item><description>You cannot perform this operation when the Classic Load Balancer (CLB) instance to which the listener belongs is in the Locked state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLoadBalancerListenerResponse
        /// </returns>
        public async Task<StartLoadBalancerListenerResponse> StartLoadBalancerListenerAsync(StartLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you make this API call, note the following:</para>
        /// <list type="bullet">
        /// <item><description>After the API call is successfully made, the listener enters the stopped state.</description></item>
        /// <item><description>If the Classic Load Balancer (CLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.<remarks>
        /// <para> If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLoadBalancerListenerResponse
        /// </returns>
        public StopLoadBalancerListenerResponse StopLoadBalancerListenerWithOptions(StopLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLoadBalancerListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLoadBalancerListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you make this API call, note the following:</para>
        /// <list type="bullet">
        /// <item><description>After the API call is successfully made, the listener enters the stopped state.</description></item>
        /// <item><description>If the Classic Load Balancer (CLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.<remarks>
        /// <para> If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoadBalancerListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLoadBalancerListenerResponse
        /// </returns>
        public async Task<StopLoadBalancerListenerResponse> StopLoadBalancerListenerWithOptionsAsync(StopLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLoadBalancerListener",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLoadBalancerListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you make this API call, note the following:</para>
        /// <list type="bullet">
        /// <item><description>After the API call is successfully made, the listener enters the stopped state.</description></item>
        /// <item><description>If the Classic Load Balancer (CLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.<remarks>
        /// <para> If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLoadBalancerListenerResponse
        /// </returns>
        public StopLoadBalancerListenerResponse StopLoadBalancerListener(StopLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLoadBalancerListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you make this API call, note the following:</para>
        /// <list type="bullet">
        /// <item><description>After the API call is successfully made, the listener enters the stopped state.</description></item>
        /// <item><description>If the Classic Load Balancer (CLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.<remarks>
        /// <para> If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoadBalancerListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLoadBalancerListenerResponse
        /// </returns>
        public async Task<StopLoadBalancerListenerResponse> StopLoadBalancerListenerAsync(StopLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds the tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2014-05-15",
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
        /// <para>Creates tags and adds the tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2014-05-15",
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
        /// <para>Creates tags and adds the tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
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
        /// <para>Creates tags and adds the tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.</para>
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
        /// <para>Removes tags from a resource.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2014-05-15",
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
        /// <para>Removes tags from a resource.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2014-05-15",
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
        /// <para>Removes tags from a resource.</para>
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
        /// <para>Removes tags from a resource.</para>
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
        /// <para>Uploads a CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadCACertificateResponse
        /// </returns>
        public UploadCACertificateResponse UploadCACertificateWithOptions(UploadCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificate))
            {
                query["CACertificate"] = request.CACertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateName))
            {
                query["CACertificateName"] = request.CACertificateName;
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
                Action = "UploadCACertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCACertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadCACertificateResponse
        /// </returns>
        public async Task<UploadCACertificateResponse> UploadCACertificateWithOptionsAsync(UploadCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificate))
            {
                query["CACertificate"] = request.CACertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CACertificateName))
            {
                query["CACertificateName"] = request.CACertificateName;
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
                Action = "UploadCACertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadCACertificateResponse
        /// </returns>
        public UploadCACertificateResponse UploadCACertificate(UploadCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCACertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadCACertificateResponse
        /// </returns>
        public async Task<UploadCACertificateResponse> UploadCACertificateAsync(UploadCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCACertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can upload only one server certificate and its private key in each call.</para>
        /// <list type="bullet">
        /// <item><description>After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadServerCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadServerCertificateResponse
        /// </returns>
        public UploadServerCertificateResponse UploadServerCertificateWithOptions(UploadServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCloudCertificateId))
            {
                query["AliCloudCertificateId"] = request.AliCloudCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCloudCertificateName))
            {
                query["AliCloudCertificateName"] = request.AliCloudCertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCloudCertificateRegionId))
            {
                query["AliCloudCertificateRegionId"] = request.AliCloudCertificateRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificate))
            {
                query["ServerCertificate"] = request.ServerCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateName))
            {
                query["ServerCertificateName"] = request.ServerCertificateName;
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
                Action = "UploadServerCertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadServerCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can upload only one server certificate and its private key in each call.</para>
        /// <list type="bullet">
        /// <item><description>After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadServerCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadServerCertificateResponse
        /// </returns>
        public async Task<UploadServerCertificateResponse> UploadServerCertificateWithOptionsAsync(UploadServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCloudCertificateId))
            {
                query["AliCloudCertificateId"] = request.AliCloudCertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCloudCertificateName))
            {
                query["AliCloudCertificateName"] = request.AliCloudCertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCloudCertificateRegionId))
            {
                query["AliCloudCertificateRegionId"] = request.AliCloudCertificateRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificate))
            {
                query["ServerCertificate"] = request.ServerCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCertificateName))
            {
                query["ServerCertificateName"] = request.ServerCertificateName;
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
                Action = "UploadServerCertificate",
                Version = "2014-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadServerCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can upload only one server certificate and its private key in each call.</para>
        /// <list type="bullet">
        /// <item><description>After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadServerCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadServerCertificateResponse
        /// </returns>
        public UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadServerCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can upload only one server certificate and its private key in each call.</para>
        /// <list type="bullet">
        /// <item><description>After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadServerCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadServerCertificateResponse
        /// </returns>
        public async Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadServerCertificateWithOptionsAsync(request, runtime);
        }

    }
}
