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

        /**
         * @summary Adds IP entries to a network access control list (ACL).
         *
         * @description Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:
         * *   The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50
         * *   The maximum number of IP entries that each network ACL can contain: 300
         *
         * @param request AddAccessControlListEntryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAccessControlListEntryResponse
         */
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

        /**
         * @summary Adds IP entries to a network access control list (ACL).
         *
         * @description Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:
         * *   The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50
         * *   The maximum number of IP entries that each network ACL can contain: 300
         *
         * @param request AddAccessControlListEntryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAccessControlListEntryResponse
         */
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

        /**
         * @summary Adds IP entries to a network access control list (ACL).
         *
         * @description Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:
         * *   The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50
         * *   The maximum number of IP entries that each network ACL can contain: 300
         *
         * @param request AddAccessControlListEntryRequest
         * @return AddAccessControlListEntryResponse
         */
        public AddAccessControlListEntryResponse AddAccessControlListEntry(AddAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAccessControlListEntryWithOptions(request, runtime);
        }

        /**
         * @summary Adds IP entries to a network access control list (ACL).
         *
         * @description Each network ACL can contain one or more IP addresses or CIDR blocks. Take note of the following limits on network ACLs:
         * *   The number of IP entries that can be added to a network ACL with each Alibaba Cloud account at a time: 50
         * *   The maximum number of IP entries that each network ACL can contain: 300
         *
         * @param request AddAccessControlListEntryRequest
         * @return AddAccessControlListEntryResponse
         */
        public async Task<AddAccessControlListEntryResponse> AddAccessControlListEntryAsync(AddAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAccessControlListEntryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds backend servers.
         *
         * @description >  If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.
         *
         * @param request AddBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddBackendServersResponse
         */
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

        /**
         * @summary Adds backend servers.
         *
         * @description >  If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.
         *
         * @param request AddBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddBackendServersResponse
         */
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

        /**
         * @summary Adds backend servers.
         *
         * @description >  If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.
         *
         * @param request AddBackendServersRequest
         * @return AddBackendServersResponse
         */
        public AddBackendServersResponse AddBackendServers(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBackendServersWithOptions(request, runtime);
        }

        /**
         * @summary Adds backend servers.
         *
         * @description >  If multiple identical Elastic Compute Service (ECS) instances are specified in a request, only the first ECS instance is added. The other ECS instances are ignored. If the backend server that you add is the same as one of the existing backend servers that are already associated with the listener, an error message is returned.
         *
         * @param request AddBackendServersRequest
         * @return AddBackendServersResponse
         */
        public async Task<AddBackendServersResponse> AddBackendServersAsync(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBackendServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds IP addresses to the whitelist of a listener.
         *
         * @param request AddListenerWhiteListItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddListenerWhiteListItemResponse
         */
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

        /**
         * @summary Adds IP addresses to the whitelist of a listener.
         *
         * @param request AddListenerWhiteListItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddListenerWhiteListItemResponse
         */
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

        /**
         * @summary Adds IP addresses to the whitelist of a listener.
         *
         * @param request AddListenerWhiteListItemRequest
         * @return AddListenerWhiteListItemResponse
         */
        public AddListenerWhiteListItemResponse AddListenerWhiteListItem(AddListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddListenerWhiteListItemWithOptions(request, runtime);
        }

        /**
         * @summary Adds IP addresses to the whitelist of a listener.
         *
         * @param request AddListenerWhiteListItemRequest
         * @return AddListenerWhiteListItemResponse
         */
        public async Task<AddListenerWhiteListItemResponse> AddListenerWhiteListItemAsync(AddListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddListenerWhiteListItemWithOptionsAsync(request, runtime);
        }

        /**
         * @description # Limits
         * Before you call this API, note the following limits:
         * *   You can add up to 10 tags to each SLB instance.
         * *   You can add up to five pairs of tags at a time.
         * *   All the tags and keys added to an SLB instance must be unique.
         * *   If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.
         *
         * @param request AddTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTagsResponse
         */
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

        /**
         * @description # Limits
         * Before you call this API, note the following limits:
         * *   You can add up to 10 tags to each SLB instance.
         * *   You can add up to five pairs of tags at a time.
         * *   All the tags and keys added to an SLB instance must be unique.
         * *   If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.
         *
         * @param request AddTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTagsResponse
         */
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

        /**
         * @description # Limits
         * Before you call this API, note the following limits:
         * *   You can add up to 10 tags to each SLB instance.
         * *   You can add up to five pairs of tags at a time.
         * *   All the tags and keys added to an SLB instance must be unique.
         * *   If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.
         *
         * @param request AddTagsRequest
         * @return AddTagsResponse
         */
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        /**
         * @description # Limits
         * Before you call this API, note the following limits:
         * *   You can add up to 10 tags to each SLB instance.
         * *   You can add up to five pairs of tags at a time.
         * *   All the tags and keys added to an SLB instance must be unique.
         * *   If you add a tag of which the key is the same as that of an existing tag, but the value is different, the new tag overwrites the existing one.
         *
         * @param request AddTagsRequest
         * @return AddTagsResponse
         */
        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds backend servers to a specified server group.
         *
         * @param request AddVServerGroupBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddVServerGroupBackendServersResponse
         */
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

        /**
         * @summary Adds backend servers to a specified server group.
         *
         * @param request AddVServerGroupBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddVServerGroupBackendServersResponse
         */
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

        /**
         * @summary Adds backend servers to a specified server group.
         *
         * @param request AddVServerGroupBackendServersRequest
         * @return AddVServerGroupBackendServersResponse
         */
        public AddVServerGroupBackendServersResponse AddVServerGroupBackendServers(AddVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVServerGroupBackendServersWithOptions(request, runtime);
        }

        /**
         * @summary Adds backend servers to a specified server group.
         *
         * @param request AddVServerGroupBackendServersRequest
         * @return AddVServerGroupBackendServersResponse
         */
        public async Task<AddVServerGroupBackendServersResponse> AddVServerGroupBackendServersAsync(AddVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access control list (ACL).
         *
         * @description You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:
         * *   An account can have a maximum of 50 ACLs in each region.
         * *   You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.
         * *   Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.
         *
         * @param request CreateAccessControlListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessControlListResponse
         */
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

        /**
         * @summary Creates an access control list (ACL).
         *
         * @description You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:
         * *   An account can have a maximum of 50 ACLs in each region.
         * *   You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.
         * *   Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.
         *
         * @param request CreateAccessControlListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessControlListResponse
         */
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

        /**
         * @summary Creates an access control list (ACL).
         *
         * @description You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:
         * *   An account can have a maximum of 50 ACLs in each region.
         * *   You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.
         * *   Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.
         *
         * @param request CreateAccessControlListRequest
         * @return CreateAccessControlListResponse
         */
        public CreateAccessControlListResponse CreateAccessControlList(CreateAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessControlListWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access control list (ACL).
         *
         * @description You can create multiple ACLs. Each ACL can contain one or more IP addresses or CIDR blocks. Before you create an ACL, take note of the following limits:
         * *   An account can have a maximum of 50 ACLs in each region.
         * *   You can add a maximum of 50 IP addresses or CIDR blocks at a time within an account.
         * *   Each ACL can contain a maximum of 300 IP addresses or CIDR blocks.
         *
         * @param request CreateAccessControlListRequest
         * @return CreateAccessControlListResponse
         */
        public async Task<CreateAccessControlListResponse> CreateAccessControlListAsync(CreateAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessControlListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a domain name extension.
         *
         * @param request CreateDomainExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainExtensionResponse
         */
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

        /**
         * @summary Creates a domain name extension.
         *
         * @param request CreateDomainExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainExtensionResponse
         */
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

        /**
         * @summary Creates a domain name extension.
         *
         * @param request CreateDomainExtensionRequest
         * @return CreateDomainExtensionResponse
         */
        public CreateDomainExtensionResponse CreateDomainExtension(CreateDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainExtensionWithOptions(request, runtime);
        }

        /**
         * @summary Creates a domain name extension.
         *
         * @param request CreateDomainExtensionRequest
         * @return CreateDomainExtensionResponse
         */
        public async Task<CreateDomainExtensionResponse> CreateDomainExtensionAsync(CreateDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainExtensionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a Classic Load Balancer (CLB) instance.
         *
         * @description *   Before you create a CLB instance, call the [DescribeAvailableResource](~~DescribeAvailableResource~~) operation to query the resources available for purchase in the region where you want to create the CLB instance.
         * *   After a CLB instance is created, you are charged for using the CLB instance.
         * *   The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.
         *
         * @param request CreateLoadBalancerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerResponse
         */
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

        /**
         * @summary Creates a Classic Load Balancer (CLB) instance.
         *
         * @description *   Before you create a CLB instance, call the [DescribeAvailableResource](~~DescribeAvailableResource~~) operation to query the resources available for purchase in the region where you want to create the CLB instance.
         * *   After a CLB instance is created, you are charged for using the CLB instance.
         * *   The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.
         *
         * @param request CreateLoadBalancerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerResponse
         */
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

        /**
         * @summary Creates a Classic Load Balancer (CLB) instance.
         *
         * @description *   Before you create a CLB instance, call the [DescribeAvailableResource](~~DescribeAvailableResource~~) operation to query the resources available for purchase in the region where you want to create the CLB instance.
         * *   After a CLB instance is created, you are charged for using the CLB instance.
         * *   The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.
         *
         * @param request CreateLoadBalancerRequest
         * @return CreateLoadBalancerResponse
         */
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Classic Load Balancer (CLB) instance.
         *
         * @description *   Before you create a CLB instance, call the [DescribeAvailableResource](~~DescribeAvailableResource~~) operation to query the resources available for purchase in the region where you want to create the CLB instance.
         * *   After a CLB instance is created, you are charged for using the CLB instance.
         * *   The pay-as-you-go billing method supports the pay-by-specification and pay-by-LCU metering methods.
         *
         * @param request CreateLoadBalancerRequest
         * @return CreateLoadBalancerResponse
         */
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an HTTP listener for a Classic Load Balancer (CLB) instance.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](~~StartLoadBalancerListener~~) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](~~StartLoadBalancerListener~~).
         *
         * @param request CreateLoadBalancerHTTPListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerHTTPListenerResponse
         */
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

        /**
         * @summary Creates an HTTP listener for a Classic Load Balancer (CLB) instance.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](~~StartLoadBalancerListener~~) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](~~StartLoadBalancerListener~~).
         *
         * @param request CreateLoadBalancerHTTPListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerHTTPListenerResponse
         */
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

        /**
         * @summary Creates an HTTP listener for a Classic Load Balancer (CLB) instance.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](~~StartLoadBalancerListener~~) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](~~StartLoadBalancerListener~~).
         *
         * @param request CreateLoadBalancerHTTPListenerRequest
         * @return CreateLoadBalancerHTTPListenerResponse
         */
        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListener(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPListenerWithOptions(request, runtime);
        }

        /**
         * @summary Creates an HTTP listener for a Classic Load Balancer (CLB) instance.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](~~StartLoadBalancerListener~~) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](~~StartLoadBalancerListener~~).
         *
         * @param request CreateLoadBalancerHTTPListenerRequest
         * @return CreateLoadBalancerHTTPListenerResponse
         */
        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerAsync(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an HTTPS listener.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2).
         *
         * @param request CreateLoadBalancerHTTPSListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerHTTPSListenerResponse
         */
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

        /**
         * @summary Creates an HTTPS listener.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2).
         *
         * @param request CreateLoadBalancerHTTPSListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerHTTPSListenerResponse
         */
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

        /**
         * @summary Creates an HTTPS listener.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2).
         *
         * @param request CreateLoadBalancerHTTPSListenerRequest
         * @return CreateLoadBalancerHTTPSListenerResponse
         */
        public CreateLoadBalancerHTTPSListenerResponse CreateLoadBalancerHTTPSListener(CreateLoadBalancerHTTPSListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPSListenerWithOptions(request, runtime);
        }

        /**
         * @summary Creates an HTTPS listener.
         *
         * @description A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to start the listener. After the listener is started, the listener can forward traffic to backend servers.
         * ## Prerequisites
         * A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://www.alibabacloud.com/help/en/server-load-balancer/latest/createloadbalancer-2).
         *
         * @param request CreateLoadBalancerHTTPSListenerRequest
         * @return CreateLoadBalancerHTTPSListenerResponse
         */
        public async Task<CreateLoadBalancerHTTPSListenerResponse> CreateLoadBalancerHTTPSListenerAsync(CreateLoadBalancerHTTPSListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPSListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a TCP listener.
         *
         * @description >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerTCPListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerTCPListenerResponse
         */
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

        /**
         * @summary Creates a TCP listener.
         *
         * @description >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerTCPListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerTCPListenerResponse
         */
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

        /**
         * @summary Creates a TCP listener.
         *
         * @description >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerTCPListenerRequest
         * @return CreateLoadBalancerTCPListenerResponse
         */
        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListener(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerTCPListenerWithOptions(request, runtime);
        }

        /**
         * @summary Creates a TCP listener.
         *
         * @description >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerTCPListenerRequest
         * @return CreateLoadBalancerTCPListenerResponse
         */
        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerAsync(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerTCPListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a UDP listener.
         *
         * @description UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.
         * >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerUDPListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerUDPListenerResponse
         */
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

        /**
         * @summary Creates a UDP listener.
         *
         * @description UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.
         * >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerUDPListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoadBalancerUDPListenerResponse
         */
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

        /**
         * @summary Creates a UDP listener.
         *
         * @description UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.
         * >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerUDPListenerRequest
         * @return CreateLoadBalancerUDPListenerResponse
         */
        public CreateLoadBalancerUDPListenerResponse CreateLoadBalancerUDPListener(CreateLoadBalancerUDPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerUDPListenerWithOptions(request, runtime);
        }

        /**
         * @summary Creates a UDP listener.
         *
         * @description UDP listeners of Classic Load Balancer (CLB) instances in a classic network cannot pass client IP addresses to backend servers.
         * >  A newly created listener is in the **stopped** state. After a listener is created, you can call the [StartLoadBalancerListener](https://help.aliyun.com/document_detail/27597.html) operation to enable the listener to forward traffic to backend servers.
         *
         * @param request CreateLoadBalancerUDPListenerRequest
         * @return CreateLoadBalancerUDPListenerResponse
         */
        public async Task<CreateLoadBalancerUDPListenerResponse> CreateLoadBalancerUDPListenerAsync(CreateLoadBalancerUDPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerUDPListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a primary/secondary server group. A primary/secondary server group can contain only two Elastic Compute Service (ECS) instances. One of the ECS instances functions as the primary server and the other functions as the secondary server.
         *
         * @param request CreateMasterSlaveServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMasterSlaveServerGroupResponse
         */
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

        /**
         * @summary Creates a primary/secondary server group. A primary/secondary server group can contain only two Elastic Compute Service (ECS) instances. One of the ECS instances functions as the primary server and the other functions as the secondary server.
         *
         * @param request CreateMasterSlaveServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMasterSlaveServerGroupResponse
         */
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

        /**
         * @summary Creates a primary/secondary server group. A primary/secondary server group can contain only two Elastic Compute Service (ECS) instances. One of the ECS instances functions as the primary server and the other functions as the secondary server.
         *
         * @param request CreateMasterSlaveServerGroupRequest
         * @return CreateMasterSlaveServerGroupResponse
         */
        public CreateMasterSlaveServerGroupResponse CreateMasterSlaveServerGroup(CreateMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMasterSlaveServerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a primary/secondary server group. A primary/secondary server group can contain only two Elastic Compute Service (ECS) instances. One of the ECS instances functions as the primary server and the other functions as the secondary server.
         *
         * @param request CreateMasterSlaveServerGroupRequest
         * @return CreateMasterSlaveServerGroupResponse
         */
        public async Task<CreateMasterSlaveServerGroupResponse> CreateMasterSlaveServerGroupAsync(CreateMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMasterSlaveServerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates forwarding rules for an HTTP or HTTPS listener.
         *
         * @param request CreateRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRulesResponse
         */
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

        /**
         * @summary Creates forwarding rules for an HTTP or HTTPS listener.
         *
         * @param request CreateRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRulesResponse
         */
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

        /**
         * @summary Creates forwarding rules for an HTTP or HTTPS listener.
         *
         * @param request CreateRulesRequest
         * @return CreateRulesResponse
         */
        public CreateRulesResponse CreateRules(CreateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRulesWithOptions(request, runtime);
        }

        /**
         * @summary Creates forwarding rules for an HTTP or HTTPS listener.
         *
         * @param request CreateRulesRequest
         * @return CreateRulesResponse
         */
        public async Task<CreateRulesResponse> CreateRulesAsync(CreateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a Transport Layer Security (TLS) policy.
         *
         * @param request CreateTLSCipherPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTLSCipherPolicyResponse
         */
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

        /**
         * @summary Creates a Transport Layer Security (TLS) policy.
         *
         * @param request CreateTLSCipherPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTLSCipherPolicyResponse
         */
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

        /**
         * @summary Creates a Transport Layer Security (TLS) policy.
         *
         * @param request CreateTLSCipherPolicyRequest
         * @return CreateTLSCipherPolicyResponse
         */
        public CreateTLSCipherPolicyResponse CreateTLSCipherPolicy(CreateTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTLSCipherPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Transport Layer Security (TLS) policy.
         *
         * @param request CreateTLSCipherPolicyRequest
         * @return CreateTLSCipherPolicyResponse
         */
        public async Task<CreateTLSCipherPolicyResponse> CreateTLSCipherPolicyAsync(CreateTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTLSCipherPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a vServer group and adds backend servers to the vServer group.
         *
         * @param request CreateVServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVServerGroupResponse
         */
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

        /**
         * @summary Creates a vServer group and adds backend servers to the vServer group.
         *
         * @param request CreateVServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVServerGroupResponse
         */
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

        /**
         * @summary Creates a vServer group and adds backend servers to the vServer group.
         *
         * @param request CreateVServerGroupRequest
         * @return CreateVServerGroupResponse
         */
        public CreateVServerGroupResponse CreateVServerGroup(CreateVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVServerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a vServer group and adds backend servers to the vServer group.
         *
         * @param request CreateVServerGroupRequest
         * @return CreateVServerGroupResponse
         */
        public async Task<CreateVServerGroupResponse> CreateVServerGroupAsync(CreateVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVServerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @description You can delete an ACL only if it is not associated with a listener.
         *
         * @param request DeleteAccessControlListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessControlListResponse
         */
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

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @description You can delete an ACL only if it is not associated with a listener.
         *
         * @param request DeleteAccessControlListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessControlListResponse
         */
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

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @description You can delete an ACL only if it is not associated with a listener.
         *
         * @param request DeleteAccessControlListRequest
         * @return DeleteAccessControlListResponse
         */
        public DeleteAccessControlListResponse DeleteAccessControlList(DeleteAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessControlListWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @description You can delete an ACL only if it is not associated with a listener.
         *
         * @param request DeleteAccessControlListRequest
         * @return DeleteAccessControlListResponse
         */
        public async Task<DeleteAccessControlListResponse> DeleteAccessControlListAsync(DeleteAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessControlListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DeleteAccessLogsDownloadAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessLogsDownloadAttributeResponse
         */
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

        /**
         * @summary Deletes the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DeleteAccessLogsDownloadAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessLogsDownloadAttributeResponse
         */
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

        /**
         * @summary Deletes the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DeleteAccessLogsDownloadAttributeRequest
         * @return DeleteAccessLogsDownloadAttributeResponse
         */
        public DeleteAccessLogsDownloadAttributeResponse DeleteAccessLogsDownloadAttribute(DeleteAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessLogsDownloadAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Deletes the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DeleteAccessLogsDownloadAttributeRequest
         * @return DeleteAccessLogsDownloadAttributeResponse
         */
        public async Task<DeleteAccessLogsDownloadAttributeResponse> DeleteAccessLogsDownloadAttributeAsync(DeleteAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessLogsDownloadAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a certificate authority (CA) certificate.
         *
         * @description You cannot delete a CA certificate that is in use.
         *
         * @param request DeleteCACertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCACertificateResponse
         */
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

        /**
         * @summary Deletes a certificate authority (CA) certificate.
         *
         * @description You cannot delete a CA certificate that is in use.
         *
         * @param request DeleteCACertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCACertificateResponse
         */
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

        /**
         * @summary Deletes a certificate authority (CA) certificate.
         *
         * @description You cannot delete a CA certificate that is in use.
         *
         * @param request DeleteCACertificateRequest
         * @return DeleteCACertificateResponse
         */
        public DeleteCACertificateResponse DeleteCACertificate(DeleteCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCACertificateWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a certificate authority (CA) certificate.
         *
         * @description You cannot delete a CA certificate that is in use.
         *
         * @param request DeleteCACertificateRequest
         * @return DeleteCACertificateResponse
         */
        public async Task<DeleteCACertificateResponse> DeleteCACertificateAsync(DeleteCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCACertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an additional domain name.
         *
         * @param request DeleteDomainExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainExtensionResponse
         */
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

        /**
         * @summary Deletes an additional domain name.
         *
         * @param request DeleteDomainExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainExtensionResponse
         */
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

        /**
         * @summary Deletes an additional domain name.
         *
         * @param request DeleteDomainExtensionRequest
         * @return DeleteDomainExtensionResponse
         */
        public DeleteDomainExtensionResponse DeleteDomainExtension(DeleteDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainExtensionWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an additional domain name.
         *
         * @param request DeleteDomainExtensionRequest
         * @return DeleteDomainExtensionResponse
         */
        public async Task<DeleteDomainExtensionResponse> DeleteDomainExtensionAsync(DeleteDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainExtensionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a pay-as-you-go Server Load Balancer (SLB) instance.
         *
         * @description > The listeners and tags of the SLB instance are deleted along with the SLB instance.
         *
         * @param request DeleteLoadBalancerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoadBalancerResponse
         */
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

        /**
         * @summary Deletes a pay-as-you-go Server Load Balancer (SLB) instance.
         *
         * @description > The listeners and tags of the SLB instance are deleted along with the SLB instance.
         *
         * @param request DeleteLoadBalancerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoadBalancerResponse
         */
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

        /**
         * @summary Deletes a pay-as-you-go Server Load Balancer (SLB) instance.
         *
         * @description > The listeners and tags of the SLB instance are deleted along with the SLB instance.
         *
         * @param request DeleteLoadBalancerRequest
         * @return DeleteLoadBalancerResponse
         */
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a pay-as-you-go Server Load Balancer (SLB) instance.
         *
         * @description > The listeners and tags of the SLB instance are deleted along with the SLB instance.
         *
         * @param request DeleteLoadBalancerRequest
         * @return DeleteLoadBalancerResponse
         */
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a listener.
         *
         * @description >  You can delete only listeners that are in the **stopped** or **running** state.
         *
         * @param request DeleteLoadBalancerListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoadBalancerListenerResponse
         */
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

        /**
         * @summary Deletes a listener.
         *
         * @description >  You can delete only listeners that are in the **stopped** or **running** state.
         *
         * @param request DeleteLoadBalancerListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoadBalancerListenerResponse
         */
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

        /**
         * @summary Deletes a listener.
         *
         * @description >  You can delete only listeners that are in the **stopped** or **running** state.
         *
         * @param request DeleteLoadBalancerListenerRequest
         * @return DeleteLoadBalancerListenerResponse
         */
        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListener(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerListenerWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a listener.
         *
         * @description >  You can delete only listeners that are in the **stopped** or **running** state.
         *
         * @param request DeleteLoadBalancerListenerRequest
         * @return DeleteLoadBalancerListenerResponse
         */
        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerAsync(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an active/standby server group.
         *
         * @param request DeleteMasterSlaveServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMasterSlaveServerGroupResponse
         */
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

        /**
         * @summary Deletes an active/standby server group.
         *
         * @param request DeleteMasterSlaveServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMasterSlaveServerGroupResponse
         */
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

        /**
         * @summary Deletes an active/standby server group.
         *
         * @param request DeleteMasterSlaveServerGroupRequest
         * @return DeleteMasterSlaveServerGroupResponse
         */
        public DeleteMasterSlaveServerGroupResponse DeleteMasterSlaveServerGroup(DeleteMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMasterSlaveServerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an active/standby server group.
         *
         * @param request DeleteMasterSlaveServerGroupRequest
         * @return DeleteMasterSlaveServerGroupResponse
         */
        public async Task<DeleteMasterSlaveServerGroupResponse> DeleteMasterSlaveServerGroupAsync(DeleteMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMasterSlaveServerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes forwarding rules.
         *
         * @description ## Limits
         * The RuleIds parameter is required. You can specify up to 10 forwarding rules in each request.
         *
         * @param request DeleteRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRulesResponse
         */
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

        /**
         * @summary Deletes forwarding rules.
         *
         * @description ## Limits
         * The RuleIds parameter is required. You can specify up to 10 forwarding rules in each request.
         *
         * @param request DeleteRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRulesResponse
         */
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

        /**
         * @summary Deletes forwarding rules.
         *
         * @description ## Limits
         * The RuleIds parameter is required. You can specify up to 10 forwarding rules in each request.
         *
         * @param request DeleteRulesRequest
         * @return DeleteRulesResponse
         */
        public DeleteRulesResponse DeleteRules(DeleteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRulesWithOptions(request, runtime);
        }

        /**
         * @summary Deletes forwarding rules.
         *
         * @description ## Limits
         * The RuleIds parameter is required. You can specify up to 10 forwarding rules in each request.
         *
         * @param request DeleteRulesRequest
         * @return DeleteRulesResponse
         */
        public async Task<DeleteRulesResponse> DeleteRulesAsync(DeleteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a server certificate.
         *
         * @description >  You cannot delete server certificates that are in use.
         *
         * @param request DeleteServerCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServerCertificateResponse
         */
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

        /**
         * @summary Deletes a server certificate.
         *
         * @description >  You cannot delete server certificates that are in use.
         *
         * @param request DeleteServerCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServerCertificateResponse
         */
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

        /**
         * @summary Deletes a server certificate.
         *
         * @description >  You cannot delete server certificates that are in use.
         *
         * @param request DeleteServerCertificateRequest
         * @return DeleteServerCertificateResponse
         */
        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServerCertificateWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a server certificate.
         *
         * @description >  You cannot delete server certificates that are in use.
         *
         * @param request DeleteServerCertificateRequest
         * @return DeleteServerCertificateResponse
         */
        public async Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServerCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a TLS policy.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Slb\\&api=DeleteTLSCipherPolicy\\&type=RPC\\&version=2014-05-15)
         *
         * @param request DeleteTLSCipherPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTLSCipherPolicyResponse
         */
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

        /**
         * @summary Deletes a TLS policy.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Slb\\&api=DeleteTLSCipherPolicy\\&type=RPC\\&version=2014-05-15)
         *
         * @param request DeleteTLSCipherPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTLSCipherPolicyResponse
         */
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

        /**
         * @summary Deletes a TLS policy.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Slb\\&api=DeleteTLSCipherPolicy\\&type=RPC\\&version=2014-05-15)
         *
         * @param request DeleteTLSCipherPolicyRequest
         * @return DeleteTLSCipherPolicyResponse
         */
        public DeleteTLSCipherPolicyResponse DeleteTLSCipherPolicy(DeleteTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTLSCipherPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a TLS policy.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Slb\\&api=DeleteTLSCipherPolicy\\&type=RPC\\&version=2014-05-15)
         *
         * @param request DeleteTLSCipherPolicyRequest
         * @return DeleteTLSCipherPolicyResponse
         */
        public async Task<DeleteTLSCipherPolicyResponse> DeleteTLSCipherPolicyAsync(DeleteTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTLSCipherPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a VServer group.
         *
         * @param request DeleteVServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVServerGroupResponse
         */
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

        /**
         * @summary Deletes a VServer group.
         *
         * @param request DeleteVServerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVServerGroupResponse
         */
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

        /**
         * @summary Deletes a VServer group.
         *
         * @param request DeleteVServerGroupRequest
         * @return DeleteVServerGroupResponse
         */
        public DeleteVServerGroupResponse DeleteVServerGroup(DeleteVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVServerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a VServer group.
         *
         * @param request DeleteVServerGroupRequest
         * @return DeleteVServerGroupResponse
         */
        public async Task<DeleteVServerGroupResponse> DeleteVServerGroupAsync(DeleteVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVServerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configuration of an access control list (ACL).
         *
         * @param request DescribeAccessControlListAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessControlListAttributeResponse
         */
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

        /**
         * @summary Queries the configuration of an access control list (ACL).
         *
         * @param request DescribeAccessControlListAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessControlListAttributeResponse
         */
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

        /**
         * @summary Queries the configuration of an access control list (ACL).
         *
         * @param request DescribeAccessControlListAttributeRequest
         * @return DescribeAccessControlListAttributeResponse
         */
        public DescribeAccessControlListAttributeResponse DescribeAccessControlListAttribute(DescribeAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessControlListAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configuration of an access control list (ACL).
         *
         * @param request DescribeAccessControlListAttributeRequest
         * @return DescribeAccessControlListAttributeResponse
         */
        public async Task<DescribeAccessControlListAttributeResponse> DescribeAccessControlListAttributeAsync(DescribeAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessControlListAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAccessControlListsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessControlListsResponse
         */
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

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAccessControlListsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessControlListsResponse
         */
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

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAccessControlListsRequest
         * @return DescribeAccessControlListsResponse
         */
        public DescribeAccessControlListsResponse DescribeAccessControlLists(DescribeAccessControlListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessControlListsWithOptions(request, runtime);
        }

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAccessControlListsRequest
         * @return DescribeAccessControlListsResponse
         */
        public async Task<DescribeAccessControlListsResponse> DescribeAccessControlListsAsync(DescribeAccessControlListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessControlListsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DescribeAccessLogsDownloadAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessLogsDownloadAttributeResponse
         */
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

        /**
         * @summary Queries the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DescribeAccessLogsDownloadAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccessLogsDownloadAttributeResponse
         */
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

        /**
         * @summary Queries the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DescribeAccessLogsDownloadAttributeRequest
         * @return DescribeAccessLogsDownloadAttributeResponse
         */
        public DescribeAccessLogsDownloadAttributeResponse DescribeAccessLogsDownloadAttribute(DescribeAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessLogsDownloadAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the access log of a Classic Load Balancer (CLB) instance.
         *
         * @param request DescribeAccessLogsDownloadAttributeRequest
         * @return DescribeAccessLogsDownloadAttributeResponse
         */
        public async Task<DescribeAccessLogsDownloadAttributeResponse> DescribeAccessLogsDownloadAttributeAsync(DescribeAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessLogsDownloadAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the available resources and resources that are available for purchase in the zones of a region.
         *
         * @description > Only the available resources and zones are returned.
         *
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
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

        /**
         * @summary Queries the available resources and resources that are available for purchase in the zones of a region.
         *
         * @description > Only the available resources and zones are returned.
         *
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
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

        /**
         * @summary Queries the available resources and resources that are available for purchase in the zones of a region.
         *
         * @description > Only the available resources and zones are returned.
         *
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the available resources and resources that are available for purchase in the zones of a region.
         *
         * @description > Only the available resources and zones are returned.
         *
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries certificate authority (CA) certificates.
         *
         * @description > To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.
         *
         * @param request DescribeCACertificatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCACertificatesResponse
         */
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

        /**
         * @summary Queries certificate authority (CA) certificates.
         *
         * @description > To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.
         *
         * @param request DescribeCACertificatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCACertificatesResponse
         */
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

        /**
         * @summary Queries certificate authority (CA) certificates.
         *
         * @description > To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.
         *
         * @param request DescribeCACertificatesRequest
         * @return DescribeCACertificatesResponse
         */
        public DescribeCACertificatesResponse DescribeCACertificates(DescribeCACertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificatesWithOptions(request, runtime);
        }

        /**
         * @summary Queries certificate authority (CA) certificates.
         *
         * @description > To ensure data confidentiality, only the certificate fingerprint and name are returned. The certificate content is not returned.
         *
         * @param request DescribeCACertificatesRequest
         * @return DescribeCACertificatesResponse
         */
        public async Task<DescribeCACertificatesResponse> DescribeCACertificatesAsync(DescribeCACertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the attributes of an additional certificate.
         *
         * @param request DescribeDomainExtensionAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainExtensionAttributeResponse
         */
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

        /**
         * @summary Queries the attributes of an additional certificate.
         *
         * @param request DescribeDomainExtensionAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainExtensionAttributeResponse
         */
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

        /**
         * @summary Queries the attributes of an additional certificate.
         *
         * @param request DescribeDomainExtensionAttributeRequest
         * @return DescribeDomainExtensionAttributeResponse
         */
        public DescribeDomainExtensionAttributeResponse DescribeDomainExtensionAttribute(DescribeDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainExtensionAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the attributes of an additional certificate.
         *
         * @param request DescribeDomainExtensionAttributeRequest
         * @return DescribeDomainExtensionAttributeResponse
         */
        public async Task<DescribeDomainExtensionAttributeResponse> DescribeDomainExtensionAttributeAsync(DescribeDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainExtensionAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries additional certificates.
         *
         * @param request DescribeDomainExtensionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainExtensionsResponse
         */
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

        /**
         * @summary Queries additional certificates.
         *
         * @param request DescribeDomainExtensionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainExtensionsResponse
         */
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

        /**
         * @summary Queries additional certificates.
         *
         * @param request DescribeDomainExtensionsRequest
         * @return DescribeDomainExtensionsResponse
         */
        public DescribeDomainExtensionsResponse DescribeDomainExtensions(DescribeDomainExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainExtensionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries additional certificates.
         *
         * @param request DescribeDomainExtensionsRequest
         * @return DescribeDomainExtensionsResponse
         */
        public async Task<DescribeDomainExtensionsResponse> DescribeDomainExtensionsAsync(DescribeDomainExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainExtensionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the health status of backend servers.
         *
         * @param request DescribeHealthStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHealthStatusResponse
         */
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

        /**
         * @summary Queries the health status of backend servers.
         *
         * @param request DescribeHealthStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHealthStatusResponse
         */
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

        /**
         * @summary Queries the health status of backend servers.
         *
         * @param request DescribeHealthStatusRequest
         * @return DescribeHealthStatusResponse
         */
        public DescribeHealthStatusResponse DescribeHealthStatus(DescribeHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the health status of backend servers.
         *
         * @param request DescribeHealthStatusRequest
         * @return DescribeHealthStatusResponse
         */
        public async Task<DescribeHealthStatusResponse> DescribeHealthStatusAsync(DescribeHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configurations of fine-grained monitoring in a region.
         *
         * @param request DescribeHighDefinationMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHighDefinationMonitorResponse
         */
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

        /**
         * @summary Queries the configurations of fine-grained monitoring in a region.
         *
         * @param request DescribeHighDefinationMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHighDefinationMonitorResponse
         */
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

        /**
         * @summary Queries the configurations of fine-grained monitoring in a region.
         *
         * @param request DescribeHighDefinationMonitorRequest
         * @return DescribeHighDefinationMonitorResponse
         */
        public DescribeHighDefinationMonitorResponse DescribeHighDefinationMonitor(DescribeHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHighDefinationMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of fine-grained monitoring in a region.
         *
         * @param request DescribeHighDefinationMonitorRequest
         * @return DescribeHighDefinationMonitorResponse
         */
        public async Task<DescribeHighDefinationMonitorResponse> DescribeHighDefinationMonitorAsync(DescribeHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHighDefinationMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the whitelist configurations of a listener.
         *
         * @param request DescribeListenerAccessControlAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeListenerAccessControlAttributeResponse
         */
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

        /**
         * @summary Queries the whitelist configurations of a listener.
         *
         * @param request DescribeListenerAccessControlAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeListenerAccessControlAttributeResponse
         */
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

        /**
         * @summary Queries the whitelist configurations of a listener.
         *
         * @param request DescribeListenerAccessControlAttributeRequest
         * @return DescribeListenerAccessControlAttributeResponse
         */
        public DescribeListenerAccessControlAttributeResponse DescribeListenerAccessControlAttribute(DescribeListenerAccessControlAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeListenerAccessControlAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the whitelist configurations of a listener.
         *
         * @param request DescribeListenerAccessControlAttributeRequest
         * @return DescribeListenerAccessControlAttributeResponse
         */
        public async Task<DescribeListenerAccessControlAttributeResponse> DescribeListenerAccessControlAttributeAsync(DescribeListenerAccessControlAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeListenerAccessControlAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the detail of a Classic Load Balancer (CLB) instance.
         *
         * @description >  If backend servers are deployed in a vServer group, you can call the [DescribeVServerGroupAttribute](https://help.aliyun.com/document_detail/35224.html) operation to query the backend servers.
         *
         * @param request DescribeLoadBalancerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerAttributeResponse
         */
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

        /**
         * @summary Queries the detail of a Classic Load Balancer (CLB) instance.
         *
         * @description >  If backend servers are deployed in a vServer group, you can call the [DescribeVServerGroupAttribute](https://help.aliyun.com/document_detail/35224.html) operation to query the backend servers.
         *
         * @param request DescribeLoadBalancerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerAttributeResponse
         */
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

        /**
         * @summary Queries the detail of a Classic Load Balancer (CLB) instance.
         *
         * @description >  If backend servers are deployed in a vServer group, you can call the [DescribeVServerGroupAttribute](https://help.aliyun.com/document_detail/35224.html) operation to query the backend servers.
         *
         * @param request DescribeLoadBalancerAttributeRequest
         * @return DescribeLoadBalancerAttributeResponse
         */
        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttribute(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the detail of a Classic Load Balancer (CLB) instance.
         *
         * @description >  If backend servers are deployed in a vServer group, you can call the [DescribeVServerGroupAttribute](https://help.aliyun.com/document_detail/35224.html) operation to query the backend servers.
         *
         * @param request DescribeLoadBalancerAttributeRequest
         * @return DescribeLoadBalancerAttributeResponse
         */
        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeAsync(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configurations of an HTTP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request DescribeLoadBalancerHTTPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerHTTPListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of an HTTP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request DescribeLoadBalancerHTTPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerHTTPListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of an HTTP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request DescribeLoadBalancerHTTPListenerAttributeRequest
         * @return DescribeLoadBalancerHTTPListenerAttributeResponse
         */
        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttribute(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of an HTTP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request DescribeLoadBalancerHTTPListenerAttributeRequest
         * @return DescribeLoadBalancerHTTPListenerAttributeResponse
         */
        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request DescribeLoadBalancerHTTPSListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerHTTPSListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request DescribeLoadBalancerHTTPSListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerHTTPSListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request DescribeLoadBalancerHTTPSListenerAttributeRequest
         * @return DescribeLoadBalancerHTTPSListenerAttributeResponse
         */
        public DescribeLoadBalancerHTTPSListenerAttributeResponse DescribeLoadBalancerHTTPSListenerAttribute(DescribeLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPSListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request DescribeLoadBalancerHTTPSListenerAttributeRequest
         * @return DescribeLoadBalancerHTTPSListenerAttributeResponse
         */
        public async Task<DescribeLoadBalancerHTTPSListenerAttributeResponse> DescribeLoadBalancerHTTPSListenerAttributeAsync(DescribeLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPSListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the listeners of a Classic Load Balancer (CLB) instance.
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   One or more listeners are added to the CLB instance. For more information, see the following topics:
         *     *   [CreateLoadBalancerUDPListener](~~CreateLoadBalancerUDPListener~~)
         *     *   [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~)
         *     *   [CreateLoadBalancerHTTPListener](~~CreateLoadBalancerHTTPListener~~)
         *     *   [CreateLoadBalancerHTTPSListener](~~CreateLoadBalancerHTTPSListener~~)
         *
         * @param request DescribeLoadBalancerListenersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerListenersResponse
         */
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

        /**
         * @summary Queries the listeners of a Classic Load Balancer (CLB) instance.
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   One or more listeners are added to the CLB instance. For more information, see the following topics:
         *     *   [CreateLoadBalancerUDPListener](~~CreateLoadBalancerUDPListener~~)
         *     *   [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~)
         *     *   [CreateLoadBalancerHTTPListener](~~CreateLoadBalancerHTTPListener~~)
         *     *   [CreateLoadBalancerHTTPSListener](~~CreateLoadBalancerHTTPSListener~~)
         *
         * @param request DescribeLoadBalancerListenersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerListenersResponse
         */
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

        /**
         * @summary Queries the listeners of a Classic Load Balancer (CLB) instance.
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   One or more listeners are added to the CLB instance. For more information, see the following topics:
         *     *   [CreateLoadBalancerUDPListener](~~CreateLoadBalancerUDPListener~~)
         *     *   [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~)
         *     *   [CreateLoadBalancerHTTPListener](~~CreateLoadBalancerHTTPListener~~)
         *     *   [CreateLoadBalancerHTTPSListener](~~CreateLoadBalancerHTTPSListener~~)
         *
         * @param request DescribeLoadBalancerListenersRequest
         * @return DescribeLoadBalancerListenersResponse
         */
        public DescribeLoadBalancerListenersResponse DescribeLoadBalancerListeners(DescribeLoadBalancerListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerListenersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the listeners of a Classic Load Balancer (CLB) instance.
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   One or more listeners are added to the CLB instance. For more information, see the following topics:
         *     *   [CreateLoadBalancerUDPListener](~~CreateLoadBalancerUDPListener~~)
         *     *   [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~)
         *     *   [CreateLoadBalancerHTTPListener](~~CreateLoadBalancerHTTPListener~~)
         *     *   [CreateLoadBalancerHTTPSListener](~~CreateLoadBalancerHTTPSListener~~)
         *
         * @param request DescribeLoadBalancerListenersRequest
         * @return DescribeLoadBalancerListenersResponse
         */
        public async Task<DescribeLoadBalancerListenersResponse> DescribeLoadBalancerListenersAsync(DescribeLoadBalancerListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerListenersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @param request DescribeLoadBalancerTCPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerTCPListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @param request DescribeLoadBalancerTCPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerTCPListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @param request DescribeLoadBalancerTCPListenerAttributeRequest
         * @return DescribeLoadBalancerTCPListenerAttributeResponse
         */
        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttribute(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @param request DescribeLoadBalancerTCPListenerAttributeRequest
         * @return DescribeLoadBalancerTCPListenerAttributeResponse
         */
        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeAsync(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configurations of a UDP listener.
         *
         * @param request DescribeLoadBalancerUDPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerUDPListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of a UDP listener.
         *
         * @param request DescribeLoadBalancerUDPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancerUDPListenerAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of a UDP listener.
         *
         * @param request DescribeLoadBalancerUDPListenerAttributeRequest
         * @return DescribeLoadBalancerUDPListenerAttributeResponse
         */
        public DescribeLoadBalancerUDPListenerAttributeResponse DescribeLoadBalancerUDPListenerAttribute(DescribeLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerUDPListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of a UDP listener.
         *
         * @param request DescribeLoadBalancerUDPListenerAttributeRequest
         * @return DescribeLoadBalancerUDPListenerAttributeResponse
         */
        public async Task<DescribeLoadBalancerUDPListenerAttributeResponse> DescribeLoadBalancerUDPListenerAttributeAsync(DescribeLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerUDPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries Classic Load Balancer (CLB) instances.
         *
         * @param request DescribeLoadBalancersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancersResponse
         */
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

        /**
         * @summary Queries Classic Load Balancer (CLB) instances.
         *
         * @param request DescribeLoadBalancersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLoadBalancersResponse
         */
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

        /**
         * @summary Queries Classic Load Balancer (CLB) instances.
         *
         * @param request DescribeLoadBalancersRequest
         * @return DescribeLoadBalancersResponse
         */
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancersWithOptions(request, runtime);
        }

        /**
         * @summary Queries Classic Load Balancer (CLB) instances.
         *
         * @param request DescribeLoadBalancersRequest
         * @return DescribeLoadBalancersResponse
         */
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the detailed information about a primary/secondary server group.
         *
         * @param request DescribeMasterSlaveServerGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMasterSlaveServerGroupAttributeResponse
         */
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

        /**
         * @summary Queries the detailed information about a primary/secondary server group.
         *
         * @param request DescribeMasterSlaveServerGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMasterSlaveServerGroupAttributeResponse
         */
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

        /**
         * @summary Queries the detailed information about a primary/secondary server group.
         *
         * @param request DescribeMasterSlaveServerGroupAttributeRequest
         * @return DescribeMasterSlaveServerGroupAttributeResponse
         */
        public DescribeMasterSlaveServerGroupAttributeResponse DescribeMasterSlaveServerGroupAttribute(DescribeMasterSlaveServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMasterSlaveServerGroupAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the detailed information about a primary/secondary server group.
         *
         * @param request DescribeMasterSlaveServerGroupAttributeRequest
         * @return DescribeMasterSlaveServerGroupAttributeResponse
         */
        public async Task<DescribeMasterSlaveServerGroupAttributeResponse> DescribeMasterSlaveServerGroupAttributeAsync(DescribeMasterSlaveServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMasterSlaveServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries primary/secondary server groups.
         *
         * @param request DescribeMasterSlaveServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMasterSlaveServerGroupsResponse
         */
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

        /**
         * @summary Queries primary/secondary server groups.
         *
         * @param request DescribeMasterSlaveServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMasterSlaveServerGroupsResponse
         */
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

        /**
         * @summary Queries primary/secondary server groups.
         *
         * @param request DescribeMasterSlaveServerGroupsRequest
         * @return DescribeMasterSlaveServerGroupsResponse
         */
        public DescribeMasterSlaveServerGroupsResponse DescribeMasterSlaveServerGroups(DescribeMasterSlaveServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMasterSlaveServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries primary/secondary server groups.
         *
         * @param request DescribeMasterSlaveServerGroupsRequest
         * @return DescribeMasterSlaveServerGroupsResponse
         */
        public async Task<DescribeMasterSlaveServerGroupsResponse> DescribeMasterSlaveServerGroupsAsync(DescribeMasterSlaveServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMasterSlaveServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries regions.
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

        /**
         * @summary Queries regions.
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

        /**
         * @summary Queries regions.
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
         * @summary Queries regions.
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
         * @summary Queries the configurations of a specified forwarding rule.
         *
         * @param request DescribeRuleAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of a specified forwarding rule.
         *
         * @param request DescribeRuleAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleAttributeResponse
         */
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

        /**
         * @summary Queries the configurations of a specified forwarding rule.
         *
         * @param request DescribeRuleAttributeRequest
         * @return DescribeRuleAttributeResponse
         */
        public DescribeRuleAttributeResponse DescribeRuleAttribute(DescribeRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of a specified forwarding rule.
         *
         * @param request DescribeRuleAttributeRequest
         * @return DescribeRuleAttributeResponse
         */
        public async Task<DescribeRuleAttributeResponse> DescribeRuleAttributeAsync(DescribeRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the forwarding rules that are configured for a specified listener.
         *
         * @param request DescribeRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRulesResponse
         */
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

        /**
         * @summary Queries the forwarding rules that are configured for a specified listener.
         *
         * @param request DescribeRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRulesResponse
         */
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

        /**
         * @summary Queries the forwarding rules that are configured for a specified listener.
         *
         * @param request DescribeRulesRequest
         * @return DescribeRulesResponse
         */
        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the forwarding rules that are configured for a specified listener.
         *
         * @param request DescribeRulesRequest
         * @return DescribeRulesResponse
         */
        public async Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries server certificates of Classic Load Balancer (CLB) instances in a specified region.
         *
         * @description >  For security reasons, only fingerprints and names of the server certificates are returned. The content of the server certificates and private keys is not returned.
         *
         * @param request DescribeServerCertificatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServerCertificatesResponse
         */
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

        /**
         * @summary Queries server certificates of Classic Load Balancer (CLB) instances in a specified region.
         *
         * @description >  For security reasons, only fingerprints and names of the server certificates are returned. The content of the server certificates and private keys is not returned.
         *
         * @param request DescribeServerCertificatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServerCertificatesResponse
         */
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

        /**
         * @summary Queries server certificates of Classic Load Balancer (CLB) instances in a specified region.
         *
         * @description >  For security reasons, only fingerprints and names of the server certificates are returned. The content of the server certificates and private keys is not returned.
         *
         * @param request DescribeServerCertificatesRequest
         * @return DescribeServerCertificatesResponse
         */
        public DescribeServerCertificatesResponse DescribeServerCertificates(DescribeServerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServerCertificatesWithOptions(request, runtime);
        }

        /**
         * @summary Queries server certificates of Classic Load Balancer (CLB) instances in a specified region.
         *
         * @description >  For security reasons, only fingerprints and names of the server certificates are returned. The content of the server certificates and private keys is not returned.
         *
         * @param request DescribeServerCertificatesRequest
         * @return DescribeServerCertificatesResponse
         */
        public async Task<DescribeServerCertificatesResponse> DescribeServerCertificatesAsync(DescribeServerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServerCertificatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tags.
         *
         * @description When you call this operation, take note of the following items:
         * *   You can query tags by instance ID, tag key, and tag value. If the operation is successful, the system returns all tags that match the specified conditions.
         * *   The logical relationship among the specified conditions is AND. Only tags that match all the specified conditions are returned.
         * *   If the Tagkey parameter is set and the Tagvalue parameter is not set, all tags that contain the specified tag key are returned.
         * *   If you set the Tagvalue parameter in a request, you must also set the Tagkey parameter in the request.
         * *   If you set both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.
         *
         * @param request DescribeTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagsResponse
         */
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

        /**
         * @summary Queries tags.
         *
         * @description When you call this operation, take note of the following items:
         * *   You can query tags by instance ID, tag key, and tag value. If the operation is successful, the system returns all tags that match the specified conditions.
         * *   The logical relationship among the specified conditions is AND. Only tags that match all the specified conditions are returned.
         * *   If the Tagkey parameter is set and the Tagvalue parameter is not set, all tags that contain the specified tag key are returned.
         * *   If you set the Tagvalue parameter in a request, you must also set the Tagkey parameter in the request.
         * *   If you set both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.
         *
         * @param request DescribeTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagsResponse
         */
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

        /**
         * @summary Queries tags.
         *
         * @description When you call this operation, take note of the following items:
         * *   You can query tags by instance ID, tag key, and tag value. If the operation is successful, the system returns all tags that match the specified conditions.
         * *   The logical relationship among the specified conditions is AND. Only tags that match all the specified conditions are returned.
         * *   If the Tagkey parameter is set and the Tagvalue parameter is not set, all tags that contain the specified tag key are returned.
         * *   If you set the Tagvalue parameter in a request, you must also set the Tagkey parameter in the request.
         * *   If you set both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.
         *
         * @param request DescribeTagsRequest
         * @return DescribeTagsResponse
         */
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        /**
         * @summary Queries tags.
         *
         * @description When you call this operation, take note of the following items:
         * *   You can query tags by instance ID, tag key, and tag value. If the operation is successful, the system returns all tags that match the specified conditions.
         * *   The logical relationship among the specified conditions is AND. Only tags that match all the specified conditions are returned.
         * *   If the Tagkey parameter is set and the Tagvalue parameter is not set, all tags that contain the specified tag key are returned.
         * *   If you set the Tagvalue parameter in a request, you must also set the Tagkey parameter in the request.
         * *   If you set both the Tagkey and Tagvalue parameters, only tags that contain the specified keys and values are returned.
         *
         * @param request DescribeTagsRequest
         * @return DescribeTagsResponse
         */
        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries detailed information about a vServer group.
         *
         * @param request DescribeVServerGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVServerGroupAttributeResponse
         */
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

        /**
         * @summary Queries detailed information about a vServer group.
         *
         * @param request DescribeVServerGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVServerGroupAttributeResponse
         */
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

        /**
         * @summary Queries detailed information about a vServer group.
         *
         * @param request DescribeVServerGroupAttributeRequest
         * @return DescribeVServerGroupAttributeResponse
         */
        public DescribeVServerGroupAttributeResponse DescribeVServerGroupAttribute(DescribeVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVServerGroupAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about a vServer group.
         *
         * @param request DescribeVServerGroupAttributeRequest
         * @return DescribeVServerGroupAttributeResponse
         */
        public async Task<DescribeVServerGroupAttributeResponse> DescribeVServerGroupAttributeAsync(DescribeVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries server groups.
         *
         * @param request DescribeVServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVServerGroupsResponse
         */
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

        /**
         * @summary Queries server groups.
         *
         * @param request DescribeVServerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVServerGroupsResponse
         */
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

        /**
         * @summary Queries server groups.
         *
         * @param request DescribeVServerGroupsRequest
         * @return DescribeVServerGroupsResponse
         */
        public DescribeVServerGroupsResponse DescribeVServerGroups(DescribeVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVServerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries server groups.
         *
         * @param request DescribeVServerGroupsRequest
         * @return DescribeVServerGroupsResponse
         */
        public async Task<DescribeVServerGroupsResponse> DescribeVServerGroupsAsync(DescribeVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVServerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the zones in a region.
         *
         * @param request DescribeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeZonesResponse
         */
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

        /**
         * @summary Queries the zones in a region.
         *
         * @param request DescribeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeZonesResponse
         */
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

        /**
         * @summary Queries the zones in a region.
         *
         * @param request DescribeZonesRequest
         * @return DescribeZonesResponse
         */
        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the zones in a region.
         *
         * @param request DescribeZonesRequest
         * @return DescribeZonesResponse
         */
        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables fine-grained monitoring for the current region.
         *
         * @param request EnableHighDefinationMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableHighDefinationMonitorResponse
         */
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

        /**
         * @summary Enables fine-grained monitoring for the current region.
         *
         * @param request EnableHighDefinationMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableHighDefinationMonitorResponse
         */
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

        /**
         * @summary Enables fine-grained monitoring for the current region.
         *
         * @param request EnableHighDefinationMonitorRequest
         * @return EnableHighDefinationMonitorResponse
         */
        public EnableHighDefinationMonitorResponse EnableHighDefinationMonitor(EnableHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHighDefinationMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Enables fine-grained monitoring for the current region.
         *
         * @param request EnableHighDefinationMonitorRequest
         * @return EnableHighDefinationMonitorResponse
         */
        public async Task<EnableHighDefinationMonitorResponse> EnableHighDefinationMonitorAsync(EnableHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHighDefinationMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries Transport Layer Security (TLS) policies.
         *
         * @param request ListTLSCipherPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTLSCipherPoliciesResponse
         */
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

        /**
         * @summary Queries Transport Layer Security (TLS) policies.
         *
         * @param request ListTLSCipherPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTLSCipherPoliciesResponse
         */
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

        /**
         * @summary Queries Transport Layer Security (TLS) policies.
         *
         * @param request ListTLSCipherPoliciesRequest
         * @return ListTLSCipherPoliciesResponse
         */
        public ListTLSCipherPoliciesResponse ListTLSCipherPolicies(ListTLSCipherPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTLSCipherPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Queries Transport Layer Security (TLS) policies.
         *
         * @param request ListTLSCipherPoliciesRequest
         * @return ListTLSCipherPoliciesResponse
         */
        public async Task<ListTLSCipherPoliciesResponse> ListTLSCipherPoliciesAsync(ListTLSCipherPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTLSCipherPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tags that are added to one or more instances.
         *
         * @description *   Set **ResourceId.N** or **Tag.N** that consists of **Tag.N.Key** and **Tag.N.Value** in the request to specify the object to be queried.
         * *   **Tag.N** is a resource tag that consists of a key-value pair. If you set only **Tag.N.Key**, all tag values that are associated with the specified tag key are returned. If you set only **Tag.N.Value**, an error message is returned.
         * *   If you set **Tag.N** and **ResourceId.N** to filter tags, **ResourceId.N** must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
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

        /**
         * @summary Queries tags that are added to one or more instances.
         *
         * @description *   Set **ResourceId.N** or **Tag.N** that consists of **Tag.N.Key** and **Tag.N.Value** in the request to specify the object to be queried.
         * *   **Tag.N** is a resource tag that consists of a key-value pair. If you set only **Tag.N.Key**, all tag values that are associated with the specified tag key are returned. If you set only **Tag.N.Value**, an error message is returned.
         * *   If you set **Tag.N** and **ResourceId.N** to filter tags, **ResourceId.N** must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
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

        /**
         * @summary Queries tags that are added to one or more instances.
         *
         * @description *   Set **ResourceId.N** or **Tag.N** that consists of **Tag.N.Key** and **Tag.N.Value** in the request to specify the object to be queried.
         * *   **Tag.N** is a resource tag that consists of a key-value pair. If you set only **Tag.N.Key**, all tag values that are associated with the specified tag key are returned. If you set only **Tag.N.Value**, an error message is returned.
         * *   If you set **Tag.N** and **ResourceId.N** to filter tags, **ResourceId.N** must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
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
         * @summary Queries tags that are added to one or more instances.
         *
         * @description *   Set **ResourceId.N** or **Tag.N** that consists of **Tag.N.Key** and **Tag.N.Value** in the request to specify the object to be queried.
         * *   **Tag.N** is a resource tag that consists of a key-value pair. If you set only **Tag.N.Key**, all tag values that are associated with the specified tag key are returned. If you set only **Tag.N.Value**, an error message is returned.
         * *   If you set **Tag.N** and **ResourceId.N** to filter tags, **ResourceId.N** must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
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
         * @summary Modifies the configuration of fine-grained monitoring in a specified region.
         *
         * @param request ModifyHighDefinationMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyHighDefinationMonitorResponse
         */
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

        /**
         * @summary Modifies the configuration of fine-grained monitoring in a specified region.
         *
         * @param request ModifyHighDefinationMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyHighDefinationMonitorResponse
         */
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

        /**
         * @summary Modifies the configuration of fine-grained monitoring in a specified region.
         *
         * @param request ModifyHighDefinationMonitorRequest
         * @return ModifyHighDefinationMonitorResponse
         */
        public ModifyHighDefinationMonitorResponse ModifyHighDefinationMonitor(ModifyHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHighDefinationMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configuration of fine-grained monitoring in a specified region.
         *
         * @param request ModifyHighDefinationMonitorRequest
         * @return ModifyHighDefinationMonitorResponse
         */
        public async Task<ModifyHighDefinationMonitorResponse> ModifyHighDefinationMonitorAsync(ModifyHighDefinationMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHighDefinationMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.
         *
         * @description > *   For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.
         * >*   This operation can change the metering method of only one instance at a time.
         *
         * @param request ModifyLoadBalancerInstanceChargeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerInstanceChargeTypeResponse
         */
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

        /**
         * @summary Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.
         *
         * @description > *   For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.
         * >*   This operation can change the metering method of only one instance at a time.
         *
         * @param request ModifyLoadBalancerInstanceChargeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerInstanceChargeTypeResponse
         */
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

        /**
         * @summary Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.
         *
         * @description > *   For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.
         * >*   This operation can change the metering method of only one instance at a time.
         *
         * @param request ModifyLoadBalancerInstanceChargeTypeRequest
         * @return ModifyLoadBalancerInstanceChargeTypeResponse
         */
        public ModifyLoadBalancerInstanceChargeTypeResponse ModifyLoadBalancerInstanceChargeType(ModifyLoadBalancerInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInstanceChargeTypeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the metering method of a pay-as-you-go Classic Load Balancer (CLB) instance.
         *
         * @description > *   For pay-as-you-go CLB instances, you can only change the metering method from pay-by-specification to pay-by-LCU. You cannot change the metering method from pay-by-LCU to pay-by-specification.
         * >*   This operation can change the metering method of only one instance at a time.
         *
         * @param request ModifyLoadBalancerInstanceChargeTypeRequest
         * @return ModifyLoadBalancerInstanceChargeTypeResponse
         */
        public async Task<ModifyLoadBalancerInstanceChargeTypeResponse> ModifyLoadBalancerInstanceChargeTypeAsync(ModifyLoadBalancerInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInstanceChargeTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the specification of a Classic Load Balancer (CLB) instance.
         *
         * @param request ModifyLoadBalancerInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerInstanceSpecResponse
         */
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

        /**
         * @summary Modifies the specification of a Classic Load Balancer (CLB) instance.
         *
         * @param request ModifyLoadBalancerInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerInstanceSpecResponse
         */
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

        /**
         * @summary Modifies the specification of a Classic Load Balancer (CLB) instance.
         *
         * @param request ModifyLoadBalancerInstanceSpecRequest
         * @return ModifyLoadBalancerInstanceSpecResponse
         */
        public ModifyLoadBalancerInstanceSpecResponse ModifyLoadBalancerInstanceSpec(ModifyLoadBalancerInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInstanceSpecWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the specification of a Classic Load Balancer (CLB) instance.
         *
         * @param request ModifyLoadBalancerInstanceSpecRequest
         * @return ModifyLoadBalancerInstanceSpecResponse
         */
        public async Task<ModifyLoadBalancerInstanceSpecResponse> ModifyLoadBalancerInstanceSpecAsync(ModifyLoadBalancerInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInstanceSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.
         *
         * @description ## Description
         * *   If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.
         * *   If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.
         *
         * @param request ModifyLoadBalancerInternetSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerInternetSpecResponse
         */
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

        /**
         * @summary Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.
         *
         * @description ## Description
         * *   If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.
         * *   If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.
         *
         * @param request ModifyLoadBalancerInternetSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerInternetSpecResponse
         */
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

        /**
         * @summary Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.
         *
         * @description ## Description
         * *   If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.
         * *   If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.
         *
         * @param request ModifyLoadBalancerInternetSpecRequest
         * @return ModifyLoadBalancerInternetSpecResponse
         */
        public ModifyLoadBalancerInternetSpecResponse ModifyLoadBalancerInternetSpec(ModifyLoadBalancerInternetSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInternetSpecWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the metering method of an Internet-facing Classic Load Balancer (CLB) instance.
         *
         * @description ## Description
         * *   If you modify only the maximum bandwidth of a pay-by-bandwidth CLB instance, the new bandwidth immediately takes effect.
         * *   If you modify the metering method (for example, switch from pay-by-bandwidth to pay-by-data-transfer), the new metering method and the other changes specified in the operation take effect at 00:00:00 the next day.
         *
         * @param request ModifyLoadBalancerInternetSpecRequest
         * @return ModifyLoadBalancerInternetSpecResponse
         */
        public async Task<ModifyLoadBalancerInternetSpecResponse> ModifyLoadBalancerInternetSpecAsync(ModifyLoadBalancerInternetSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInternetSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.
         *
         * @param request ModifyLoadBalancerPayTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerPayTypeResponse
         */
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

        /**
         * @summary Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.
         *
         * @param request ModifyLoadBalancerPayTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyLoadBalancerPayTypeResponse
         */
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

        /**
         * @summary Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.
         *
         * @param request ModifyLoadBalancerPayTypeRequest
         * @return ModifyLoadBalancerPayTypeResponse
         */
        public ModifyLoadBalancerPayTypeResponse ModifyLoadBalancerPayType(ModifyLoadBalancerPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerPayTypeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the billing method of a Classic Load Balancer (CLB) instance from pay-as-you-go to subscription.
         *
         * @param request ModifyLoadBalancerPayTypeRequest
         * @return ModifyLoadBalancerPayTypeResponse
         */
        public async Task<ModifyLoadBalancerPayTypeResponse> ModifyLoadBalancerPayTypeAsync(ModifyLoadBalancerPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerPayTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Replaces backend servers in a specified vServer group.
         *
         * @description You can call this operation to replace the backend servers in a specified vServer group. To modify the configurations of the backend servers, such as their weights, you can call the [SetVServerGroupAttribute](https://help.aliyun.com/document_detail/35217.html) operation.
         *
         * @param request ModifyVServerGroupBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVServerGroupBackendServersResponse
         */
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

        /**
         * @summary Replaces backend servers in a specified vServer group.
         *
         * @description You can call this operation to replace the backend servers in a specified vServer group. To modify the configurations of the backend servers, such as their weights, you can call the [SetVServerGroupAttribute](https://help.aliyun.com/document_detail/35217.html) operation.
         *
         * @param request ModifyVServerGroupBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVServerGroupBackendServersResponse
         */
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

        /**
         * @summary Replaces backend servers in a specified vServer group.
         *
         * @description You can call this operation to replace the backend servers in a specified vServer group. To modify the configurations of the backend servers, such as their weights, you can call the [SetVServerGroupAttribute](https://help.aliyun.com/document_detail/35217.html) operation.
         *
         * @param request ModifyVServerGroupBackendServersRequest
         * @return ModifyVServerGroupBackendServersResponse
         */
        public ModifyVServerGroupBackendServersResponse ModifyVServerGroupBackendServers(ModifyVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVServerGroupBackendServersWithOptions(request, runtime);
        }

        /**
         * @summary Replaces backend servers in a specified vServer group.
         *
         * @description You can call this operation to replace the backend servers in a specified vServer group. To modify the configurations of the backend servers, such as their weights, you can call the [SetVServerGroupAttribute](https://help.aliyun.com/document_detail/35217.html) operation.
         *
         * @param request ModifyVServerGroupBackendServersRequest
         * @return ModifyVServerGroupBackendServersResponse
         */
        public async Task<ModifyVServerGroupBackendServersResponse> ModifyVServerGroupBackendServersAsync(ModifyVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moves a resource to another resource group.
         *
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
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

        /**
         * @summary Moves a resource to another resource group.
         *
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
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

        /**
         * @summary Moves a resource to another resource group.
         *
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Moves a resource to another resource group.
         *
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.
         *
         * @param request RemoveAccessControlListEntryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveAccessControlListEntryResponse
         */
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

        /**
         * @summary Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.
         *
         * @param request RemoveAccessControlListEntryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveAccessControlListEntryResponse
         */
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

        /**
         * @summary Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.
         *
         * @param request RemoveAccessControlListEntryRequest
         * @return RemoveAccessControlListEntryResponse
         */
        public RemoveAccessControlListEntryResponse RemoveAccessControlListEntry(RemoveAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAccessControlListEntryWithOptions(request, runtime);
        }

        /**
         * @summary Removes IP entries from the network access control list (ACL) of a Classic Load Balancer (CLB) instance.
         *
         * @param request RemoveAccessControlListEntryRequest
         * @return RemoveAccessControlListEntryResponse
         */
        public async Task<RemoveAccessControlListEntryResponse> RemoveAccessControlListEntryAsync(RemoveAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAccessControlListEntryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes backend servers.
         *
         * @description >  If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.
         *
         * @param request RemoveBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveBackendServersResponse
         */
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

        /**
         * @summary Removes backend servers.
         *
         * @description >  If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.
         *
         * @param request RemoveBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveBackendServersResponse
         */
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

        /**
         * @summary Removes backend servers.
         *
         * @description >  If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.
         *
         * @param request RemoveBackendServersRequest
         * @return RemoveBackendServersResponse
         */
        public RemoveBackendServersResponse RemoveBackendServers(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBackendServersWithOptions(request, runtime);
        }

        /**
         * @summary Removes backend servers.
         *
         * @description >  If the backend servers that you want to remove are not in the server list of the Classic Load Balancer (CLB) instance, the request fails. However, the system does not report an error.
         *
         * @param request RemoveBackendServersRequest
         * @return RemoveBackendServersResponse
         */
        public async Task<RemoveBackendServersResponse> RemoveBackendServersAsync(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBackendServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes IP addresses or CIDR blocks from the whitelist of a listener.
         *
         * @param request RemoveListenerWhiteListItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveListenerWhiteListItemResponse
         */
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

        /**
         * @summary Removes IP addresses or CIDR blocks from the whitelist of a listener.
         *
         * @param request RemoveListenerWhiteListItemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveListenerWhiteListItemResponse
         */
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

        /**
         * @summary Removes IP addresses or CIDR blocks from the whitelist of a listener.
         *
         * @param request RemoveListenerWhiteListItemRequest
         * @return RemoveListenerWhiteListItemResponse
         */
        public RemoveListenerWhiteListItemResponse RemoveListenerWhiteListItem(RemoveListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveListenerWhiteListItemWithOptions(request, runtime);
        }

        /**
         * @summary Removes IP addresses or CIDR blocks from the whitelist of a listener.
         *
         * @param request RemoveListenerWhiteListItemRequest
         * @return RemoveListenerWhiteListItemResponse
         */
        public async Task<RemoveListenerWhiteListItemResponse> RemoveListenerWhiteListItemAsync(RemoveListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveListenerWhiteListItemWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RemoveTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveTagsResponse
         */
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

        /**
         * @param request RemoveTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveTagsResponse
         */
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

        /**
         * @param request RemoveTagsRequest
         * @return RemoveTagsResponse
         */
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        /**
         * @param request RemoveTagsRequest
         * @return RemoveTagsResponse
         */
        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes one or more backend servers from a specified vServer group.
         *
         * @description >  If one or more backend servers specified by the **BackendServers** parameter do not exist in the specified vServer group, these backend servers are ignored and no error message is returned.
         *
         * @param request RemoveVServerGroupBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveVServerGroupBackendServersResponse
         */
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

        /**
         * @summary Removes one or more backend servers from a specified vServer group.
         *
         * @description >  If one or more backend servers specified by the **BackendServers** parameter do not exist in the specified vServer group, these backend servers are ignored and no error message is returned.
         *
         * @param request RemoveVServerGroupBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveVServerGroupBackendServersResponse
         */
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

        /**
         * @summary Removes one or more backend servers from a specified vServer group.
         *
         * @description >  If one or more backend servers specified by the **BackendServers** parameter do not exist in the specified vServer group, these backend servers are ignored and no error message is returned.
         *
         * @param request RemoveVServerGroupBackendServersRequest
         * @return RemoveVServerGroupBackendServersResponse
         */
        public RemoveVServerGroupBackendServersResponse RemoveVServerGroupBackendServers(RemoveVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVServerGroupBackendServersWithOptions(request, runtime);
        }

        /**
         * @summary Removes one or more backend servers from a specified vServer group.
         *
         * @description >  If one or more backend servers specified by the **BackendServers** parameter do not exist in the specified vServer group, these backend servers are ignored and no error message is returned.
         *
         * @param request RemoveVServerGroupBackendServersRequest
         * @return RemoveVServerGroupBackendServersResponse
         */
        public async Task<RemoveVServerGroupBackendServersResponse> RemoveVServerGroupBackendServersAsync(RemoveVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the name of a network access control list (ACL).
         *
         * @param request SetAccessControlListAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAccessControlListAttributeResponse
         */
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

        /**
         * @summary Modifies the name of a network access control list (ACL).
         *
         * @param request SetAccessControlListAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAccessControlListAttributeResponse
         */
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

        /**
         * @summary Modifies the name of a network access control list (ACL).
         *
         * @param request SetAccessControlListAttributeRequest
         * @return SetAccessControlListAttributeResponse
         */
        public SetAccessControlListAttributeResponse SetAccessControlListAttribute(SetAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccessControlListAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the name of a network access control list (ACL).
         *
         * @param request SetAccessControlListAttributeRequest
         * @return SetAccessControlListAttributeResponse
         */
        public async Task<SetAccessControlListAttributeResponse> SetAccessControlListAttributeAsync(SetAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccessControlListAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds an access log forwarding rule for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetAccessLogsDownloadAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAccessLogsDownloadAttributeResponse
         */
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

        /**
         * @summary Adds an access log forwarding rule for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetAccessLogsDownloadAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAccessLogsDownloadAttributeResponse
         */
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

        /**
         * @summary Adds an access log forwarding rule for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetAccessLogsDownloadAttributeRequest
         * @return SetAccessLogsDownloadAttributeResponse
         */
        public SetAccessLogsDownloadAttributeResponse SetAccessLogsDownloadAttribute(SetAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccessLogsDownloadAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Adds an access log forwarding rule for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetAccessLogsDownloadAttributeRequest
         * @return SetAccessLogsDownloadAttributeResponse
         */
        public async Task<SetAccessLogsDownloadAttributeResponse> SetAccessLogsDownloadAttributeAsync(SetAccessLogsDownloadAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccessLogsDownloadAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the weights of backend servers.
         *
         * @param request SetBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetBackendServersResponse
         */
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

        /**
         * @summary Sets the weights of backend servers.
         *
         * @param request SetBackendServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetBackendServersResponse
         */
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

        /**
         * @summary Sets the weights of backend servers.
         *
         * @param request SetBackendServersRequest
         * @return SetBackendServersResponse
         */
        public SetBackendServersResponse SetBackendServers(SetBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackendServersWithOptions(request, runtime);
        }

        /**
         * @summary Sets the weights of backend servers.
         *
         * @param request SetBackendServersRequest
         * @return SetBackendServersResponse
         */
        public async Task<SetBackendServersResponse> SetBackendServersAsync(SetBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackendServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the name of a CA Certificate.
         *
         * @param request SetCACertificateNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetCACertificateNameResponse
         */
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

        /**
         * @summary Sets the name of a CA Certificate.
         *
         * @param request SetCACertificateNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetCACertificateNameResponse
         */
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

        /**
         * @summary Sets the name of a CA Certificate.
         *
         * @param request SetCACertificateNameRequest
         * @return SetCACertificateNameResponse
         */
        public SetCACertificateNameResponse SetCACertificateName(SetCACertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCACertificateNameWithOptions(request, runtime);
        }

        /**
         * @summary Sets the name of a CA Certificate.
         *
         * @param request SetCACertificateNameRequest
         * @return SetCACertificateNameResponse
         */
        public async Task<SetCACertificateNameResponse> SetCACertificateNameAsync(SetCACertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCACertificateNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Replaces an additional certificate.
         *
         * @description >  You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.
         *
         * @param request SetDomainExtensionAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainExtensionAttributeResponse
         */
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

        /**
         * @summary Replaces an additional certificate.
         *
         * @description >  You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.
         *
         * @param request SetDomainExtensionAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainExtensionAttributeResponse
         */
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

        /**
         * @summary Replaces an additional certificate.
         *
         * @description >  You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.
         *
         * @param request SetDomainExtensionAttributeRequest
         * @return SetDomainExtensionAttributeResponse
         */
        public SetDomainExtensionAttributeResponse SetDomainExtensionAttribute(SetDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainExtensionAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Replaces an additional certificate.
         *
         * @description >  You cannot replace an additional certificate for a listener that is added to a shared-resource Server Load Balancer (SLB) instance.
         *
         * @param request SetDomainExtensionAttributeRequest
         * @return SetDomainExtensionAttributeResponse
         */
        public async Task<SetDomainExtensionAttributeResponse> SetDomainExtensionAttributeAsync(SetDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainExtensionAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the whitelist of a specified listener.
         *
         * @param request SetListenerAccessControlStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetListenerAccessControlStatusResponse
         */
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

        /**
         * @summary Enables or disables the whitelist of a specified listener.
         *
         * @param request SetListenerAccessControlStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetListenerAccessControlStatusResponse
         */
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

        /**
         * @summary Enables or disables the whitelist of a specified listener.
         *
         * @param request SetListenerAccessControlStatusRequest
         * @return SetListenerAccessControlStatusResponse
         */
        public SetListenerAccessControlStatusResponse SetListenerAccessControlStatus(SetListenerAccessControlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetListenerAccessControlStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the whitelist of a specified listener.
         *
         * @param request SetListenerAccessControlStatusRequest
         * @return SetListenerAccessControlStatusResponse
         */
        public async Task<SetListenerAccessControlStatusResponse> SetListenerAccessControlStatusAsync(SetListenerAccessControlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetListenerAccessControlStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables deletion protection for an SLB instance.
         *
         * @param request SetLoadBalancerDeleteProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerDeleteProtectionResponse
         */
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

        /**
         * @summary Enables or disables deletion protection for an SLB instance.
         *
         * @param request SetLoadBalancerDeleteProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerDeleteProtectionResponse
         */
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

        /**
         * @summary Enables or disables deletion protection for an SLB instance.
         *
         * @param request SetLoadBalancerDeleteProtectionRequest
         * @return SetLoadBalancerDeleteProtectionResponse
         */
        public SetLoadBalancerDeleteProtectionResponse SetLoadBalancerDeleteProtection(SetLoadBalancerDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerDeleteProtectionWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables deletion protection for an SLB instance.
         *
         * @param request SetLoadBalancerDeleteProtectionRequest
         * @return SetLoadBalancerDeleteProtectionResponse
         */
        public async Task<SetLoadBalancerDeleteProtectionResponse> SetLoadBalancerDeleteProtectionAsync(SetLoadBalancerDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerDeleteProtectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an HTTP listener.
         *
         * @description ### Prerequisites
         * *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request SetLoadBalancerHTTPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerHTTPListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of an HTTP listener.
         *
         * @description ### Prerequisites
         * *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request SetLoadBalancerHTTPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerHTTPListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of an HTTP listener.
         *
         * @description ### Prerequisites
         * *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request SetLoadBalancerHTTPListenerAttributeRequest
         * @return SetLoadBalancerHTTPListenerAttributeResponse
         */
        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttribute(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an HTTP listener.
         *
         * @description ### Prerequisites
         * *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTP listener is created. For more information about how to create an HTTP listener, see [CreateLoadBalancerHTTPListener](https://help.aliyun.com/document_detail/27592.html).
         *
         * @param request SetLoadBalancerHTTPListenerAttributeRequest
         * @return SetLoadBalancerHTTPListenerAttributeResponse
         */
        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeAsync(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request SetLoadBalancerHTTPSListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerHTTPSListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request SetLoadBalancerHTTPSListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerHTTPSListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request SetLoadBalancerHTTPSListenerAttributeRequest
         * @return SetLoadBalancerHTTPSListenerAttributeResponse
         */
        public SetLoadBalancerHTTPSListenerAttributeResponse SetLoadBalancerHTTPSListenerAttribute(SetLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPSListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an HTTPS listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   An HTTPS listener is created. For more information about how to create an HTTPS listener, see [CreateLoadBalancerHTTPSListener](https://help.aliyun.com/document_detail/27593.html).
         *
         * @param request SetLoadBalancerHTTPSListenerAttributeRequest
         * @return SetLoadBalancerHTTPSListenerAttributeResponse
         */
        public async Task<SetLoadBalancerHTTPSListenerAttributeResponse> SetLoadBalancerHTTPSListenerAttributeAsync(SetLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPSListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerModificationProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerModificationProtectionResponse
         */
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

        /**
         * @summary Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerModificationProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerModificationProtectionResponse
         */
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

        /**
         * @summary Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerModificationProtectionRequest
         * @return SetLoadBalancerModificationProtectionResponse
         */
        public SetLoadBalancerModificationProtectionResponse SetLoadBalancerModificationProtection(SetLoadBalancerModificationProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerModificationProtectionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configuration of the configuration read-only mode for a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerModificationProtectionRequest
         * @return SetLoadBalancerModificationProtectionResponse
         */
        public async Task<SetLoadBalancerModificationProtectionResponse> SetLoadBalancerModificationProtectionAsync(SetLoadBalancerModificationProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerModificationProtectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the name of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerNameResponse
         */
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

        /**
         * @summary Modifies the name of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerNameResponse
         */
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

        /**
         * @summary Modifies the name of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerNameRequest
         * @return SetLoadBalancerNameResponse
         */
        public SetLoadBalancerNameResponse SetLoadBalancerName(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerNameWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the name of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerNameRequest
         * @return SetLoadBalancerNameResponse
         */
        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameAsync(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the state of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerStatusResponse
         */
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

        /**
         * @summary Modifies the state of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerStatusResponse
         */
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

        /**
         * @summary Modifies the state of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerStatusRequest
         * @return SetLoadBalancerStatusResponse
         */
        public SetLoadBalancerStatusResponse SetLoadBalancerStatus(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerStatusWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the state of a Classic Load Balancer (CLB) instance.
         *
         * @param request SetLoadBalancerStatusRequest
         * @return SetLoadBalancerStatusResponse
         */
        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusAsync(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   A TCP listener is created. For more information, see [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~).
         *
         * @param request SetLoadBalancerTCPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerTCPListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   A TCP listener is created. For more information, see [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~).
         *
         * @param request SetLoadBalancerTCPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerTCPListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   A TCP listener is created. For more information, see [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~).
         *
         * @param request SetLoadBalancerTCPListenerAttributeRequest
         * @return SetLoadBalancerTCPListenerAttributeResponse
         */
        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttribute(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a TCP listener of Classic Load Balancer (CLB).
         *
         * @description *   A CLB instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/2401685.html).
         * *   A TCP listener is created. For more information, see [CreateLoadBalancerTCPListener](~~CreateLoadBalancerTCPListener~~).
         *
         * @param request SetLoadBalancerTCPListenerAttributeRequest
         * @return SetLoadBalancerTCPListenerAttributeResponse
         */
        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeAsync(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a UDP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   A UDP listener is created. For more information, see [CreateLoadBalancerUDPListener](https://help.aliyun.com/document_detail/27595.html).
         *
         * @param request SetLoadBalancerUDPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerUDPListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of a UDP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   A UDP listener is created. For more information, see [CreateLoadBalancerUDPListener](https://help.aliyun.com/document_detail/27595.html).
         *
         * @param request SetLoadBalancerUDPListenerAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetLoadBalancerUDPListenerAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of a UDP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   A UDP listener is created. For more information, see [CreateLoadBalancerUDPListener](https://help.aliyun.com/document_detail/27595.html).
         *
         * @param request SetLoadBalancerUDPListenerAttributeRequest
         * @return SetLoadBalancerUDPListenerAttributeResponse
         */
        public SetLoadBalancerUDPListenerAttributeResponse SetLoadBalancerUDPListenerAttribute(SetLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerUDPListenerAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a UDP listener.
         *
         * @description *   A Classic Load Balancer (CLB) instance is created. For more information, see [CreateLoadBalancer](https://help.aliyun.com/document_detail/27577.html).
         * *   A UDP listener is created. For more information, see [CreateLoadBalancerUDPListener](https://help.aliyun.com/document_detail/27595.html).
         *
         * @param request SetLoadBalancerUDPListenerAttributeRequest
         * @return SetLoadBalancerUDPListenerAttributeResponse
         */
        public async Task<SetLoadBalancerUDPListenerAttributeResponse> SetLoadBalancerUDPListenerAttributeAsync(SetLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerUDPListenerAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a forwarding rule that is associated with a vServer group.
         *
         * @param request SetRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRuleResponse
         */
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

        /**
         * @summary Modifies a forwarding rule that is associated with a vServer group.
         *
         * @param request SetRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRuleResponse
         */
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

        /**
         * @summary Modifies a forwarding rule that is associated with a vServer group.
         *
         * @param request SetRuleRequest
         * @return SetRuleResponse
         */
        public SetRuleResponse SetRule(SetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRuleWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a forwarding rule that is associated with a vServer group.
         *
         * @param request SetRuleRequest
         * @return SetRuleResponse
         */
        public async Task<SetRuleResponse> SetRuleAsync(SetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets a name for a server certificate.
         *
         * @param request SetServerCertificateNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetServerCertificateNameResponse
         */
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

        /**
         * @summary Sets a name for a server certificate.
         *
         * @param request SetServerCertificateNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetServerCertificateNameResponse
         */
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

        /**
         * @summary Sets a name for a server certificate.
         *
         * @param request SetServerCertificateNameRequest
         * @return SetServerCertificateNameResponse
         */
        public SetServerCertificateNameResponse SetServerCertificateName(SetServerCertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetServerCertificateNameWithOptions(request, runtime);
        }

        /**
         * @summary Sets a name for a server certificate.
         *
         * @param request SetServerCertificateNameRequest
         * @return SetServerCertificateNameResponse
         */
        public async Task<SetServerCertificateNameResponse> SetServerCertificateNameAsync(SetServerCertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetServerCertificateNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures a Transport Layer Security (TLS) policy.
         *
         * @param request SetTLSCipherPolicyAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetTLSCipherPolicyAttributeResponse
         */
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

        /**
         * @summary Configures a Transport Layer Security (TLS) policy.
         *
         * @param request SetTLSCipherPolicyAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetTLSCipherPolicyAttributeResponse
         */
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

        /**
         * @summary Configures a Transport Layer Security (TLS) policy.
         *
         * @param request SetTLSCipherPolicyAttributeRequest
         * @return SetTLSCipherPolicyAttributeResponse
         */
        public SetTLSCipherPolicyAttributeResponse SetTLSCipherPolicyAttribute(SetTLSCipherPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTLSCipherPolicyAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Configures a Transport Layer Security (TLS) policy.
         *
         * @param request SetTLSCipherPolicyAttributeRequest
         * @return SetTLSCipherPolicyAttributeResponse
         */
        public async Task<SetTLSCipherPolicyAttributeResponse> SetTLSCipherPolicyAttributeAsync(SetTLSCipherPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTLSCipherPolicyAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a vServer group.
         *
         * @description This operation allows you to modify only the name of a vServer group and the weights of the backend servers in the vServer group.
         * *   If you want to modify backend servers in a specified vServer group, call the [ModifyVServerGroupBackendServers](https://help.aliyun.com/document_detail/35220.html) operation.
         * *   If you want to add backend servers to a specified vServer group, call the [AddVServerGroupBackendServers](https://help.aliyun.com/document_detail/35218.html) operation.
         *
         * @param request SetVServerGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetVServerGroupAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of a vServer group.
         *
         * @description This operation allows you to modify only the name of a vServer group and the weights of the backend servers in the vServer group.
         * *   If you want to modify backend servers in a specified vServer group, call the [ModifyVServerGroupBackendServers](https://help.aliyun.com/document_detail/35220.html) operation.
         * *   If you want to add backend servers to a specified vServer group, call the [AddVServerGroupBackendServers](https://help.aliyun.com/document_detail/35218.html) operation.
         *
         * @param request SetVServerGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetVServerGroupAttributeResponse
         */
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

        /**
         * @summary Modifies the configurations of a vServer group.
         *
         * @description This operation allows you to modify only the name of a vServer group and the weights of the backend servers in the vServer group.
         * *   If you want to modify backend servers in a specified vServer group, call the [ModifyVServerGroupBackendServers](https://help.aliyun.com/document_detail/35220.html) operation.
         * *   If you want to add backend servers to a specified vServer group, call the [AddVServerGroupBackendServers](https://help.aliyun.com/document_detail/35218.html) operation.
         *
         * @param request SetVServerGroupAttributeRequest
         * @return SetVServerGroupAttributeResponse
         */
        public SetVServerGroupAttributeResponse SetVServerGroupAttribute(SetVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVServerGroupAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a vServer group.
         *
         * @description This operation allows you to modify only the name of a vServer group and the weights of the backend servers in the vServer group.
         * *   If you want to modify backend servers in a specified vServer group, call the [ModifyVServerGroupBackendServers](https://help.aliyun.com/document_detail/35220.html) operation.
         * *   If you want to add backend servers to a specified vServer group, call the [AddVServerGroupBackendServers](https://help.aliyun.com/document_detail/35218.html) operation.
         *
         * @param request SetVServerGroupAttributeRequest
         * @return SetVServerGroupAttributeResponse
         */
        public async Task<SetVServerGroupAttributeResponse> SetVServerGroupAttributeAsync(SetVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to start a listener.
         *
         * @description When you call this operation, note the following items:
         * *   You can call the operation only when the listener is in the Stopped state.
         * *   After the operation is called, the status of the listener changes to Starting.
         * *   You cannot call this operation when the SLB instance to which the listener is bound is in the Locked state.
         *
         * @param request StartLoadBalancerListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartLoadBalancerListenerResponse
         */
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

        /**
         * @summary You can call this operation to start a listener.
         *
         * @description When you call this operation, note the following items:
         * *   You can call the operation only when the listener is in the Stopped state.
         * *   After the operation is called, the status of the listener changes to Starting.
         * *   You cannot call this operation when the SLB instance to which the listener is bound is in the Locked state.
         *
         * @param request StartLoadBalancerListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartLoadBalancerListenerResponse
         */
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

        /**
         * @summary You can call this operation to start a listener.
         *
         * @description When you call this operation, note the following items:
         * *   You can call the operation only when the listener is in the Stopped state.
         * *   After the operation is called, the status of the listener changes to Starting.
         * *   You cannot call this operation when the SLB instance to which the listener is bound is in the Locked state.
         *
         * @param request StartLoadBalancerListenerRequest
         * @return StartLoadBalancerListenerResponse
         */
        public StartLoadBalancerListenerResponse StartLoadBalancerListener(StartLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLoadBalancerListenerWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to start a listener.
         *
         * @description When you call this operation, note the following items:
         * *   You can call the operation only when the listener is in the Stopped state.
         * *   After the operation is called, the status of the listener changes to Starting.
         * *   You cannot call this operation when the SLB instance to which the listener is bound is in the Locked state.
         *
         * @param request StartLoadBalancerListenerRequest
         * @return StartLoadBalancerListenerResponse
         */
        public async Task<StartLoadBalancerListenerResponse> StartLoadBalancerListenerAsync(StartLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Stops a listener.
         *
         * @description Before you make this API call, note the following:
         * *   After the API call is successfully made, the listener enters the stopped state.
         * *   If the Server Load Balancer (SLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.
         * >  If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.
         *
         * @param request StopLoadBalancerListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopLoadBalancerListenerResponse
         */
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

        /**
         * @summary Stops a listener.
         *
         * @description Before you make this API call, note the following:
         * *   After the API call is successfully made, the listener enters the stopped state.
         * *   If the Server Load Balancer (SLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.
         * >  If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.
         *
         * @param request StopLoadBalancerListenerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopLoadBalancerListenerResponse
         */
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

        /**
         * @summary Stops a listener.
         *
         * @description Before you make this API call, note the following:
         * *   After the API call is successfully made, the listener enters the stopped state.
         * *   If the Server Load Balancer (SLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.
         * >  If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.
         *
         * @param request StopLoadBalancerListenerRequest
         * @return StopLoadBalancerListenerResponse
         */
        public StopLoadBalancerListenerResponse StopLoadBalancerListener(StopLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLoadBalancerListenerWithOptions(request, runtime);
        }

        /**
         * @summary Stops a listener.
         *
         * @description Before you make this API call, note the following:
         * *   After the API call is successfully made, the listener enters the stopped state.
         * *   If the Server Load Balancer (SLB) instance to which the listener to be stopped belongs is in the locked state, this API call cannot be made.
         * >  If you stop the listener, your services will be disrupted. Exercise caution when you perform this action.
         *
         * @param request StopLoadBalancerListenerRequest
         * @return StopLoadBalancerListenerResponse
         */
        public async Task<StopLoadBalancerListenerResponse> StopLoadBalancerListenerAsync(StopLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates tags and adds the tags to resources.
         *
         * @description >  You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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

        /**
         * @summary Creates tags and adds the tags to resources.
         *
         * @description >  You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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

        /**
         * @summary Creates tags and adds the tags to resources.
         *
         * @description >  You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.
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
         * @summary Creates tags and adds the tags to resources.
         *
         * @description >  You can add at most 20 tags to each instance. Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number is reached, an error message is returned.
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
         * @summary Removes tags from specified resources.
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

        /**
         * @summary Removes tags from specified resources.
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

        /**
         * @summary Removes tags from specified resources.
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
         * @summary Removes tags from specified resources.
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
         * @summary Uploads a CA certificate.
         *
         * @description You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.
         *
         * @param request UploadCACertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCACertificateResponse
         */
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

        /**
         * @summary Uploads a CA certificate.
         *
         * @description You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.
         *
         * @param request UploadCACertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCACertificateResponse
         */
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

        /**
         * @summary Uploads a CA certificate.
         *
         * @description You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.
         *
         * @param request UploadCACertificateRequest
         * @return UploadCACertificateResponse
         */
        public UploadCACertificateResponse UploadCACertificate(UploadCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCACertificateWithOptions(request, runtime);
        }

        /**
         * @summary Uploads a CA certificate.
         *
         * @description You can upload only one CA certificate at a time. After a CA certificate is uploaded, the certificate ID, name, and fingerprint are returned.
         *
         * @param request UploadCACertificateRequest
         * @return UploadCACertificateResponse
         */
        public async Task<UploadCACertificateResponse> UploadCACertificateAsync(UploadCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCACertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Uploads a server certificate.
         *
         * @description *   You can upload only one server certificate and its private key in each call.
         * *   After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.
         *
         * @param request UploadServerCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadServerCertificateResponse
         */
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

        /**
         * @summary Uploads a server certificate.
         *
         * @description *   You can upload only one server certificate and its private key in each call.
         * *   After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.
         *
         * @param request UploadServerCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadServerCertificateResponse
         */
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

        /**
         * @summary Uploads a server certificate.
         *
         * @description *   You can upload only one server certificate and its private key in each call.
         * *   After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.
         *
         * @param request UploadServerCertificateRequest
         * @return UploadServerCertificateResponse
         */
        public UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadServerCertificateWithOptions(request, runtime);
        }

        /**
         * @summary Uploads a server certificate.
         *
         * @description *   You can upload only one server certificate and its private key in each call.
         * *   After a server certificate and its private key are uploaded, the fingerprints of all server certificates that belong to your Alibaba Cloud account are returned.
         *
         * @param request UploadServerCertificateRequest
         * @return UploadServerCertificateResponse
         */
        public async Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadServerCertificateWithOptionsAsync(request, runtime);
        }

    }
}
