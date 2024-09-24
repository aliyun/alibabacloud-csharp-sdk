// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudfw20171207.Models;

namespace AlibabaCloud.SDK.Cloudfw20171207
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "cloudfw.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou", "cloudfw.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudfw", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.
         *
         * @description You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAddressBookResponse
         */
        public AddAddressBookResponse AddAddressBookWithOptions(AddAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAddressBookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.
         *
         * @description You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAddressBookResponse
         */
        public async Task<AddAddressBookResponse> AddAddressBookWithOptionsAsync(AddAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.
         *
         * @description You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAddressBookRequest
         * @return AddAddressBookResponse
         */
        public AddAddressBookResponse AddAddressBook(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAddressBookWithOptions(request, runtime);
        }

        /**
         * @summary Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.
         *
         * @description You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddAddressBookRequest
         * @return AddAddressBookResponse
         */
        public async Task<AddAddressBookResponse> AddAddressBookAsync(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAddressBookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access control policy.
         *
         * @description You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddControlPolicyResponse
         */
        public AddControlPolicyResponse AddControlPolicyWithOptions(AddControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "AddControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an access control policy.
         *
         * @description You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddControlPolicyResponse
         */
        public async Task<AddControlPolicyResponse> AddControlPolicyWithOptionsAsync(AddControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "AddControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an access control policy.
         *
         * @description You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddControlPolicyRequest
         * @return AddControlPolicyResponse
         */
        public AddControlPolicyResponse AddControlPolicy(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access control policy.
         *
         * @description You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddControlPolicyRequest
         * @return AddControlPolicyResponse
         */
        public async Task<AddControlPolicyResponse> AddControlPolicyAsync(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds members to Cloud Firewall.
         *
         * @description You can call this operation to add members to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddInstanceMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddInstanceMembersResponse
         */
        public AddInstanceMembersResponse AddInstanceMembersWithOptions(AddInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInstanceMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds members to Cloud Firewall.
         *
         * @description You can call this operation to add members to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddInstanceMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddInstanceMembersResponse
         */
        public async Task<AddInstanceMembersResponse> AddInstanceMembersWithOptionsAsync(AddInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInstanceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds members to Cloud Firewall.
         *
         * @description You can call this operation to add members to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddInstanceMembersRequest
         * @return AddInstanceMembersResponse
         */
        public AddInstanceMembersResponse AddInstanceMembers(AddInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddInstanceMembersWithOptions(request, runtime);
        }

        /**
         * @summary Adds members to Cloud Firewall.
         *
         * @description You can call this operation to add members to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddInstanceMembersRequest
         * @return AddInstanceMembersResponse
         */
        public async Task<AddInstanceMembersResponse> AddInstanceMembersAsync(AddInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddInstanceMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.
         *
         * @description You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.  
         * Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see [Back up an access control policy](https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy).  
         * After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.  
         * The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.
         *
         * @param request BatchCopyVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchCopyVpcFirewallControlPolicyResponse
         */
        public BatchCopyVpcFirewallControlPolicyResponse BatchCopyVpcFirewallControlPolicyWithOptions(BatchCopyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVpcFirewallId))
            {
                query["SourceVpcFirewallId"] = request.SourceVpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVpcFirewallId))
            {
                query["TargetVpcFirewallId"] = request.TargetVpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCopyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCopyVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.
         *
         * @description You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.  
         * Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see [Back up an access control policy](https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy).  
         * After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.  
         * The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.
         *
         * @param request BatchCopyVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchCopyVpcFirewallControlPolicyResponse
         */
        public async Task<BatchCopyVpcFirewallControlPolicyResponse> BatchCopyVpcFirewallControlPolicyWithOptionsAsync(BatchCopyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVpcFirewallId))
            {
                query["SourceVpcFirewallId"] = request.SourceVpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVpcFirewallId))
            {
                query["TargetVpcFirewallId"] = request.TargetVpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCopyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCopyVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.
         *
         * @description You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.  
         * Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see [Back up an access control policy](https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy).  
         * After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.  
         * The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.
         *
         * @param request BatchCopyVpcFirewallControlPolicyRequest
         * @return BatchCopyVpcFirewallControlPolicyResponse
         */
        public BatchCopyVpcFirewallControlPolicyResponse BatchCopyVpcFirewallControlPolicy(BatchCopyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCopyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.
         *
         * @description You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.  
         * Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see [Back up an access control policy](https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy).  
         * After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.  
         * The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.
         *
         * @param request BatchCopyVpcFirewallControlPolicyRequest
         * @return BatchCopyVpcFirewallControlPolicyResponse
         */
        public async Task<BatchCopyVpcFirewallControlPolicyResponse> BatchCopyVpcFirewallControlPolicyAsync(BatchCopyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCopyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.
         *
         * @param request BatchDeleteVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteVpcFirewallControlPolicyResponse
         */
        public BatchDeleteVpcFirewallControlPolicyResponse BatchDeleteVpcFirewallControlPolicyWithOptions(BatchDeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuidList))
            {
                query["AclUuidList"] = request.AclUuidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.
         *
         * @param request BatchDeleteVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteVpcFirewallControlPolicyResponse
         */
        public async Task<BatchDeleteVpcFirewallControlPolicyResponse> BatchDeleteVpcFirewallControlPolicyWithOptionsAsync(BatchDeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuidList))
            {
                query["AclUuidList"] = request.AclUuidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.
         *
         * @param request BatchDeleteVpcFirewallControlPolicyRequest
         * @return BatchDeleteVpcFirewallControlPolicyResponse
         */
        public BatchDeleteVpcFirewallControlPolicyResponse BatchDeleteVpcFirewallControlPolicy(BatchDeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.
         *
         * @param request BatchDeleteVpcFirewallControlPolicyRequest
         * @return BatchDeleteVpcFirewallControlPolicyResponse
         */
        public async Task<BatchDeleteVpcFirewallControlPolicyResponse> BatchDeleteVpcFirewallControlPolicyAsync(BatchDeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a file download task.
         *
         * @param request CreateDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadTaskResponse
         */
        public CreateDownloadTaskResponse CreateDownloadTaskWithOptions(CreateDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskData))
            {
                query["TaskData"] = request.TaskData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadTask",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a file download task.
         *
         * @param request CreateDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadTaskResponse
         */
        public async Task<CreateDownloadTaskResponse> CreateDownloadTaskWithOptionsAsync(CreateDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskData))
            {
                query["TaskData"] = request.TaskData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadTask",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a file download task.
         *
         * @param request CreateDownloadTaskRequest
         * @return CreateDownloadTaskResponse
         */
        public CreateDownloadTaskResponse CreateDownloadTask(CreateDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadTaskWithOptions(request, runtime);
        }

        /**
         * @summary Creates a file download task.
         *
         * @param request CreateDownloadTaskRequest
         * @return CreateDownloadTaskResponse
         */
        public async Task<CreateDownloadTaskResponse> CreateDownloadTaskAsync(CreateDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access control policy for a NAT firewall.
         *
         * @description You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.
         *
         * @param request CreateNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNatFirewallControlPolicyResponse
         */
        public CreateNatFirewallControlPolicyResponse CreateNatFirewallControlPolicyWithOptions(CreateNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "CreateNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNatFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an access control policy for a NAT firewall.
         *
         * @description You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.
         *
         * @param request CreateNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNatFirewallControlPolicyResponse
         */
        public async Task<CreateNatFirewallControlPolicyResponse> CreateNatFirewallControlPolicyWithOptionsAsync(CreateNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "CreateNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNatFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an access control policy for a NAT firewall.
         *
         * @description You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.
         *
         * @param request CreateNatFirewallControlPolicyRequest
         * @return CreateNatFirewallControlPolicyResponse
         */
        public CreateNatFirewallControlPolicyResponse CreateNatFirewallControlPolicy(CreateNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access control policy for a NAT firewall.
         *
         * @description You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.
         *
         * @param request CreateNatFirewallControlPolicyRequest
         * @return CreateNatFirewallControlPolicyResponse
         */
        public async Task<CreateNatFirewallControlPolicyResponse> CreateNatFirewallControlPolicyAsync(CreateNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a NAT firewall.
         *
         * @param request CreateSecurityProxyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecurityProxyResponse
         */
        public CreateSecurityProxyResponse CreateSecurityProxyWithOptions(CreateSecurityProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatRouteEntryList))
            {
                query["NatRouteEntryList"] = request.NatRouteEntryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyName))
            {
                query["ProxyName"] = request.ProxyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictMode))
            {
                query["StrictMode"] = request.StrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchAuto))
            {
                query["VswitchAuto"] = request.VswitchAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchCidr))
            {
                query["VswitchCidr"] = request.VswitchCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecurityProxy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecurityProxyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a NAT firewall.
         *
         * @param request CreateSecurityProxyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecurityProxyResponse
         */
        public async Task<CreateSecurityProxyResponse> CreateSecurityProxyWithOptionsAsync(CreateSecurityProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatRouteEntryList))
            {
                query["NatRouteEntryList"] = request.NatRouteEntryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyName))
            {
                query["ProxyName"] = request.ProxyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictMode))
            {
                query["StrictMode"] = request.StrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchAuto))
            {
                query["VswitchAuto"] = request.VswitchAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchCidr))
            {
                query["VswitchCidr"] = request.VswitchCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecurityProxy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecurityProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a NAT firewall.
         *
         * @param request CreateSecurityProxyRequest
         * @return CreateSecurityProxyResponse
         */
        public CreateSecurityProxyResponse CreateSecurityProxy(CreateSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityProxyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a NAT firewall.
         *
         * @param request CreateSecurityProxyRequest
         * @return CreateSecurityProxyResponse
         */
        public async Task<CreateSecurityProxyResponse> CreateSecurityProxyAsync(CreateSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityProxyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建云防火墙SLS日志投递
         *
         * @param request CreateSlsLogDispatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSlsLogDispatchResponse
         */
        public CreateSlsLogDispatchResponse CreateSlsLogDispatchWithOptions(CreateSlsLogDispatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsRegionId))
            {
                body["SlsRegionId"] = request.SlsRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSlsLogDispatch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlsLogDispatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建云防火墙SLS日志投递
         *
         * @param request CreateSlsLogDispatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSlsLogDispatchResponse
         */
        public async Task<CreateSlsLogDispatchResponse> CreateSlsLogDispatchWithOptionsAsync(CreateSlsLogDispatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsRegionId))
            {
                body["SlsRegionId"] = request.SlsRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSlsLogDispatch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlsLogDispatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建云防火墙SLS日志投递
         *
         * @param request CreateSlsLogDispatchRequest
         * @return CreateSlsLogDispatchResponse
         */
        public CreateSlsLogDispatchResponse CreateSlsLogDispatch(CreateSlsLogDispatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSlsLogDispatchWithOptions(request, runtime);
        }

        /**
         * @summary 创建云防火墙SLS日志投递
         *
         * @param request CreateSlsLogDispatchRequest
         * @return CreateSlsLogDispatchResponse
         */
        public async Task<CreateSlsLogDispatchResponse> CreateSlsLogDispatchAsync(CreateSlsLogDispatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSlsLogDispatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall for a transit router.
         *
         * @param request CreateTrFirewallV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrFirewallV2Response
         */
        public CreateTrFirewallV2Response CreateTrFirewallV2WithOptions(CreateTrFirewallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallDescription))
            {
                query["FirewallDescription"] = request.FirewallDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallName))
            {
                query["FirewallName"] = request.FirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSubnetCidr))
            {
                query["FirewallSubnetCidr"] = request.FirewallSubnetCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcCidr))
            {
                query["FirewallVpcCidr"] = request.FirewallVpcCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcId))
            {
                query["FirewallVpcId"] = request.FirewallVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVswitchId))
            {
                query["FirewallVswitchId"] = request.FirewallVswitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentMasterCidr))
            {
                query["TrAttachmentMasterCidr"] = request.TrAttachmentMasterCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentMasterZone))
            {
                query["TrAttachmentMasterZone"] = request.TrAttachmentMasterZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentSlaveCidr))
            {
                query["TrAttachmentSlaveCidr"] = request.TrAttachmentSlaveCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentSlaveZone))
            {
                query["TrAttachmentSlaveZone"] = request.TrAttachmentSlaveZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrFirewallV2",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrFirewallV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall for a transit router.
         *
         * @param request CreateTrFirewallV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrFirewallV2Response
         */
        public async Task<CreateTrFirewallV2Response> CreateTrFirewallV2WithOptionsAsync(CreateTrFirewallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallDescription))
            {
                query["FirewallDescription"] = request.FirewallDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallName))
            {
                query["FirewallName"] = request.FirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSubnetCidr))
            {
                query["FirewallSubnetCidr"] = request.FirewallSubnetCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcCidr))
            {
                query["FirewallVpcCidr"] = request.FirewallVpcCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcId))
            {
                query["FirewallVpcId"] = request.FirewallVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVswitchId))
            {
                query["FirewallVswitchId"] = request.FirewallVswitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentMasterCidr))
            {
                query["TrAttachmentMasterCidr"] = request.TrAttachmentMasterCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentMasterZone))
            {
                query["TrAttachmentMasterZone"] = request.TrAttachmentMasterZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentSlaveCidr))
            {
                query["TrAttachmentSlaveCidr"] = request.TrAttachmentSlaveCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrAttachmentSlaveZone))
            {
                query["TrAttachmentSlaveZone"] = request.TrAttachmentSlaveZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrFirewallV2",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrFirewallV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall for a transit router.
         *
         * @param request CreateTrFirewallV2Request
         * @return CreateTrFirewallV2Response
         */
        public CreateTrFirewallV2Response CreateTrFirewallV2(CreateTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrFirewallV2WithOptions(request, runtime);
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall for a transit router.
         *
         * @param request CreateTrFirewallV2Request
         * @return CreateTrFirewallV2Response
         */
        public async Task<CreateTrFirewallV2Response> CreateTrFirewallV2Async(CreateTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrFirewallV2WithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a routing policy for a VPC firewall of a transit router.
         *
         * @param tmpReq CreateTrFirewallV2RoutePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrFirewallV2RoutePolicyResponse
         */
        public CreateTrFirewallV2RoutePolicyResponse CreateTrFirewallV2RoutePolicyWithOptions(CreateTrFirewallV2RoutePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTrFirewallV2RoutePolicyShrinkRequest request = new CreateTrFirewallV2RoutePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestCandidateList))
            {
                request.DestCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestCandidateList, "DestCandidateList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SrcCandidateList))
            {
                request.SrcCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SrcCandidateList, "SrcCandidateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestCandidateListShrink))
            {
                query["DestCandidateList"] = request.DestCandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDescription))
            {
                query["PolicyDescription"] = request.PolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcCandidateListShrink))
            {
                query["SrcCandidateList"] = request.SrcCandidateListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrFirewallV2RoutePolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrFirewallV2RoutePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a routing policy for a VPC firewall of a transit router.
         *
         * @param tmpReq CreateTrFirewallV2RoutePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrFirewallV2RoutePolicyResponse
         */
        public async Task<CreateTrFirewallV2RoutePolicyResponse> CreateTrFirewallV2RoutePolicyWithOptionsAsync(CreateTrFirewallV2RoutePolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTrFirewallV2RoutePolicyShrinkRequest request = new CreateTrFirewallV2RoutePolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestCandidateList))
            {
                request.DestCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestCandidateList, "DestCandidateList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SrcCandidateList))
            {
                request.SrcCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SrcCandidateList, "SrcCandidateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestCandidateListShrink))
            {
                query["DestCandidateList"] = request.DestCandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDescription))
            {
                query["PolicyDescription"] = request.PolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcCandidateListShrink))
            {
                query["SrcCandidateList"] = request.SrcCandidateListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrFirewallV2RoutePolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrFirewallV2RoutePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a routing policy for a VPC firewall of a transit router.
         *
         * @param request CreateTrFirewallV2RoutePolicyRequest
         * @return CreateTrFirewallV2RoutePolicyResponse
         */
        public CreateTrFirewallV2RoutePolicyResponse CreateTrFirewallV2RoutePolicy(CreateTrFirewallV2RoutePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrFirewallV2RoutePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a routing policy for a VPC firewall of a transit router.
         *
         * @param request CreateTrFirewallV2RoutePolicyRequest
         * @return CreateTrFirewallV2RoutePolicyResponse
         */
        public async Task<CreateTrFirewallV2RoutePolicyResponse> CreateTrFirewallV2RoutePolicyAsync(CreateTrFirewallV2RoutePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrFirewallV2RoutePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallCenConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcFirewallCenConfigureResponse
         */
        public CreateVpcFirewallCenConfigureResponse CreateVpcFirewallCenConfigureWithOptions(CreateVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVSwitchCidrBlock))
            {
                query["FirewallVSwitchCidrBlock"] = request.FirewallVSwitchCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcCidrBlock))
            {
                query["FirewallVpcCidrBlock"] = request.FirewallVpcCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcZoneId))
            {
                query["FirewallVpcZoneId"] = request.FirewallVpcZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegion))
            {
                query["VpcRegion"] = request.VpcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallCenConfigureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallCenConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcFirewallCenConfigureResponse
         */
        public async Task<CreateVpcFirewallCenConfigureResponse> CreateVpcFirewallCenConfigureWithOptionsAsync(CreateVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVSwitchCidrBlock))
            {
                query["FirewallVSwitchCidrBlock"] = request.FirewallVSwitchCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcCidrBlock))
            {
                query["FirewallVpcCidrBlock"] = request.FirewallVpcCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcZoneId))
            {
                query["FirewallVpcZoneId"] = request.FirewallVpcZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegion))
            {
                query["VpcRegion"] = request.VpcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallCenConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallCenConfigureRequest
         * @return CreateVpcFirewallCenConfigureResponse
         */
        public CreateVpcFirewallCenConfigureResponse CreateVpcFirewallCenConfigure(CreateVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        /**
         * @summary Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallCenConfigureRequest
         * @return CreateVpcFirewallCenConfigureResponse
         */
        public async Task<CreateVpcFirewallCenConfigureResponse> CreateVpcFirewallCenConfigureAsync(CreateVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.
         *
         * @description You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ### [](#qps)QPS limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcFirewallConfigureResponse
         */
        public CreateVpcFirewallConfigureResponse CreateVpcFirewallConfigureWithOptions(CreateVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcRegion))
            {
                query["LocalVpcRegion"] = request.LocalVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcRegion))
            {
                query["PeerVpcRegion"] = request.PeerVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallConfigureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.
         *
         * @description You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ### [](#qps)QPS limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcFirewallConfigureResponse
         */
        public async Task<CreateVpcFirewallConfigureResponse> CreateVpcFirewallConfigureWithOptionsAsync(CreateVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcRegion))
            {
                query["LocalVpcRegion"] = request.LocalVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcRegion))
            {
                query["PeerVpcRegion"] = request.PeerVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.
         *
         * @description You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ### [](#qps)QPS limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallConfigureRequest
         * @return CreateVpcFirewallConfigureResponse
         */
        public CreateVpcFirewallConfigureResponse CreateVpcFirewallConfigure(CreateVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallConfigureWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.
         *
         * @description You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see [VPC firewall limits](https://help.aliyun.com/document_detail/172295.html).
         * ### [](#qps)QPS limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallConfigureRequest
         * @return CreateVpcFirewallConfigureResponse
         */
        public async Task<CreateVpcFirewallConfigureResponse> CreateVpcFirewallConfigureAsync(CreateVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcFirewallControlPolicyResponse
         */
        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicyWithOptions(CreateVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcFirewallControlPolicyResponse
         */
        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyWithOptionsAsync(CreateVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallControlPolicyRequest
         * @return CreateVpcFirewallControlPolicyResponse
         */
        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicy(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateVpcFirewallControlPolicyRequest
         * @return CreateVpcFirewallControlPolicyResponse
         */
        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyAsync(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an address book for access control.
         *
         * @description You can call the DeleteAddressBook operation to delete an address book for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAddressBookResponse
         */
        public DeleteAddressBookResponse DeleteAddressBookWithOptions(DeleteAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAddressBookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an address book for access control.
         *
         * @description You can call the DeleteAddressBook operation to delete an address book for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAddressBookResponse
         */
        public async Task<DeleteAddressBookResponse> DeleteAddressBookWithOptionsAsync(DeleteAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an address book for access control.
         *
         * @description You can call the DeleteAddressBook operation to delete an address book for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteAddressBookRequest
         * @return DeleteAddressBookResponse
         */
        public DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAddressBookWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an address book for access control.
         *
         * @description You can call the DeleteAddressBook operation to delete an address book for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteAddressBookRequest
         * @return DeleteAddressBookResponse
         */
        public async Task<DeleteAddressBookResponse> DeleteAddressBookAsync(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAddressBookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access control policy.
         *
         * @description You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteControlPolicyResponse
         */
        public DeleteControlPolicyResponse DeleteControlPolicyWithOptions(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy.
         *
         * @description You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteControlPolicyResponse
         */
        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyWithOptionsAsync(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy.
         *
         * @description You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteControlPolicyRequest
         * @return DeleteControlPolicyResponse
         */
        public DeleteControlPolicyResponse DeleteControlPolicy(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access control policy.
         *
         * @description You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteControlPolicyRequest
         * @return DeleteControlPolicyResponse
         */
        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyAsync(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access control policy template.
         *
         * @param request DeleteControlPolicyTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteControlPolicyTemplateResponse
         */
        public DeleteControlPolicyTemplateResponse DeleteControlPolicyTemplateWithOptions(DeleteControlPolicyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicyTemplate",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy template.
         *
         * @param request DeleteControlPolicyTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteControlPolicyTemplateResponse
         */
        public async Task<DeleteControlPolicyTemplateResponse> DeleteControlPolicyTemplateWithOptionsAsync(DeleteControlPolicyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicyTemplate",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy template.
         *
         * @param request DeleteControlPolicyTemplateRequest
         * @return DeleteControlPolicyTemplateResponse
         */
        public DeleteControlPolicyTemplateResponse DeleteControlPolicyTemplate(DeleteControlPolicyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access control policy template.
         *
         * @param request DeleteControlPolicyTemplateRequest
         * @return DeleteControlPolicyTemplateResponse
         */
        public async Task<DeleteControlPolicyTemplateResponse> DeleteControlPolicyTemplateAsync(DeleteControlPolicyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes file download tasks.
         *
         * @description You can call this operation to delete file download tasks and delete the files.
         * **
         * **Warning** Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.
         *
         * @param request DeleteDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDownloadTaskResponse
         */
        public DeleteDownloadTaskResponse DeleteDownloadTaskWithOptions(DeleteDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDownloadTask",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDownloadTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes file download tasks.
         *
         * @description You can call this operation to delete file download tasks and delete the files.
         * **
         * **Warning** Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.
         *
         * @param request DeleteDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDownloadTaskResponse
         */
        public async Task<DeleteDownloadTaskResponse> DeleteDownloadTaskWithOptionsAsync(DeleteDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDownloadTask",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDownloadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes file download tasks.
         *
         * @description You can call this operation to delete file download tasks and delete the files.
         * **
         * **Warning** Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.
         *
         * @param request DeleteDownloadTaskRequest
         * @return DeleteDownloadTaskResponse
         */
        public DeleteDownloadTaskResponse DeleteDownloadTask(DeleteDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDownloadTaskWithOptions(request, runtime);
        }

        /**
         * @summary Deletes file download tasks.
         *
         * @description You can call this operation to delete file download tasks and delete the files.
         * **
         * **Warning** Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.
         *
         * @param request DeleteDownloadTaskRequest
         * @return DeleteDownloadTaskResponse
         */
        public async Task<DeleteDownloadTaskResponse> DeleteDownloadTaskAsync(DeleteDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDownloadTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.
         *
         * @param request DeleteFirewallV2RoutePoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFirewallV2RoutePoliciesResponse
         */
        public DeleteFirewallV2RoutePoliciesResponse DeleteFirewallV2RoutePoliciesWithOptions(DeleteFirewallV2RoutePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFirewallV2RoutePolicies",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFirewallV2RoutePoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.
         *
         * @param request DeleteFirewallV2RoutePoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFirewallV2RoutePoliciesResponse
         */
        public async Task<DeleteFirewallV2RoutePoliciesResponse> DeleteFirewallV2RoutePoliciesWithOptionsAsync(DeleteFirewallV2RoutePoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFirewallV2RoutePolicies",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFirewallV2RoutePoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.
         *
         * @param request DeleteFirewallV2RoutePoliciesRequest
         * @return DeleteFirewallV2RoutePoliciesResponse
         */
        public DeleteFirewallV2RoutePoliciesResponse DeleteFirewallV2RoutePolicies(DeleteFirewallV2RoutePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFirewallV2RoutePoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.
         *
         * @param request DeleteFirewallV2RoutePoliciesRequest
         * @return DeleteFirewallV2RoutePoliciesResponse
         */
        public async Task<DeleteFirewallV2RoutePoliciesResponse> DeleteFirewallV2RoutePoliciesAsync(DeleteFirewallV2RoutePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFirewallV2RoutePoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes members from Cloud Firewall.
         *
         * @description You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the [DescribeInstanceMembers](https://help.aliyun.com/document_detail/271704.html) operation to obtain the information about the members that are added to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteInstanceMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceMembersResponse
         */
        public DeleteInstanceMembersResponse DeleteInstanceMembersWithOptions(DeleteInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUids))
            {
                query["MemberUids"] = request.MemberUids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes members from Cloud Firewall.
         *
         * @description You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the [DescribeInstanceMembers](https://help.aliyun.com/document_detail/271704.html) operation to obtain the information about the members that are added to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteInstanceMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceMembersResponse
         */
        public async Task<DeleteInstanceMembersResponse> DeleteInstanceMembersWithOptionsAsync(DeleteInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUids))
            {
                query["MemberUids"] = request.MemberUids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes members from Cloud Firewall.
         *
         * @description You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the [DescribeInstanceMembers](https://help.aliyun.com/document_detail/271704.html) operation to obtain the information about the members that are added to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteInstanceMembersRequest
         * @return DeleteInstanceMembersResponse
         */
        public DeleteInstanceMembersResponse DeleteInstanceMembers(DeleteInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceMembersWithOptions(request, runtime);
        }

        /**
         * @summary Removes members from Cloud Firewall.
         *
         * @description You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the [DescribeInstanceMembers](https://help.aliyun.com/document_detail/271704.html) operation to obtain the information about the members that are added to Cloud Firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteInstanceMembersRequest
         * @return DeleteInstanceMembersResponse
         */
        public async Task<DeleteInstanceMembersResponse> DeleteInstanceMembersAsync(DeleteInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to delete an outbound access control policy that is created for a NAT firewall.
         *
         * @param request DeleteNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNatFirewallControlPolicyResponse
         */
        public DeleteNatFirewallControlPolicyResponse DeleteNatFirewallControlPolicyWithOptions(DeleteNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNatFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to delete an outbound access control policy that is created for a NAT firewall.
         *
         * @param request DeleteNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNatFirewallControlPolicyResponse
         */
        public async Task<DeleteNatFirewallControlPolicyResponse> DeleteNatFirewallControlPolicyWithOptionsAsync(DeleteNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNatFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to delete an outbound access control policy that is created for a NAT firewall.
         *
         * @param request DeleteNatFirewallControlPolicyRequest
         * @return DeleteNatFirewallControlPolicyResponse
         */
        public DeleteNatFirewallControlPolicyResponse DeleteNatFirewallControlPolicy(DeleteNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to delete an outbound access control policy that is created for a NAT firewall.
         *
         * @param request DeleteNatFirewallControlPolicyRequest
         * @return DeleteNatFirewallControlPolicyResponse
         */
        public async Task<DeleteNatFirewallControlPolicyResponse> DeleteNatFirewallControlPolicyAsync(DeleteNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes access control policies that are created for a NAT firewall at a time.
         *
         * @param request DeleteNatFirewallControlPolicyBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNatFirewallControlPolicyBatchResponse
         */
        public DeleteNatFirewallControlPolicyBatchResponse DeleteNatFirewallControlPolicyBatchWithOptions(DeleteNatFirewallControlPolicyBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuidList))
            {
                query["AclUuidList"] = request.AclUuidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNatFirewallControlPolicyBatch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNatFirewallControlPolicyBatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes access control policies that are created for a NAT firewall at a time.
         *
         * @param request DeleteNatFirewallControlPolicyBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNatFirewallControlPolicyBatchResponse
         */
        public async Task<DeleteNatFirewallControlPolicyBatchResponse> DeleteNatFirewallControlPolicyBatchWithOptionsAsync(DeleteNatFirewallControlPolicyBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuidList))
            {
                query["AclUuidList"] = request.AclUuidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNatFirewallControlPolicyBatch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNatFirewallControlPolicyBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes access control policies that are created for a NAT firewall at a time.
         *
         * @param request DeleteNatFirewallControlPolicyBatchRequest
         * @return DeleteNatFirewallControlPolicyBatchResponse
         */
        public DeleteNatFirewallControlPolicyBatchResponse DeleteNatFirewallControlPolicyBatch(DeleteNatFirewallControlPolicyBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNatFirewallControlPolicyBatchWithOptions(request, runtime);
        }

        /**
         * @summary Deletes access control policies that are created for a NAT firewall at a time.
         *
         * @param request DeleteNatFirewallControlPolicyBatchRequest
         * @return DeleteNatFirewallControlPolicyBatchResponse
         */
        public async Task<DeleteNatFirewallControlPolicyBatchResponse> DeleteNatFirewallControlPolicyBatchAsync(DeleteNatFirewallControlPolicyBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNatFirewallControlPolicyBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a NAT firewall.
         *
         * @param request DeleteSecurityProxyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecurityProxyResponse
         */
        public DeleteSecurityProxyResponse DeleteSecurityProxyWithOptions(DeleteSecurityProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyId))
            {
                query["ProxyId"] = request.ProxyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityProxy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityProxyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a NAT firewall.
         *
         * @param request DeleteSecurityProxyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecurityProxyResponse
         */
        public async Task<DeleteSecurityProxyResponse> DeleteSecurityProxyWithOptionsAsync(DeleteSecurityProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyId))
            {
                query["ProxyId"] = request.ProxyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityProxy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a NAT firewall.
         *
         * @param request DeleteSecurityProxyRequest
         * @return DeleteSecurityProxyResponse
         */
        public DeleteSecurityProxyResponse DeleteSecurityProxy(DeleteSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityProxyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a NAT firewall.
         *
         * @param request DeleteSecurityProxyRequest
         * @return DeleteSecurityProxyResponse
         */
        public async Task<DeleteSecurityProxyResponse> DeleteSecurityProxyAsync(DeleteSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityProxyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DeleteTrFirewallV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrFirewallV2Response
         */
        public DeleteTrFirewallV2Response DeleteTrFirewallV2WithOptions(DeleteTrFirewallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrFirewallV2",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrFirewallV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DeleteTrFirewallV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrFirewallV2Response
         */
        public async Task<DeleteTrFirewallV2Response> DeleteTrFirewallV2WithOptionsAsync(DeleteTrFirewallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrFirewallV2",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrFirewallV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DeleteTrFirewallV2Request
         * @return DeleteTrFirewallV2Response
         */
        public DeleteTrFirewallV2Response DeleteTrFirewallV2(DeleteTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrFirewallV2WithOptions(request, runtime);
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DeleteTrFirewallV2Request
         * @return DeleteTrFirewallV2Response
         */
        public async Task<DeleteTrFirewallV2Response> DeleteTrFirewallV2Async(DeleteTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrFirewallV2WithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallCenConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcFirewallCenConfigureResponse
         */
        public DeleteVpcFirewallCenConfigureResponse DeleteVpcFirewallCenConfigureWithOptions(DeleteVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallCenConfigureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallCenConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcFirewallCenConfigureResponse
         */
        public async Task<DeleteVpcFirewallCenConfigureResponse> DeleteVpcFirewallCenConfigureWithOptionsAsync(DeleteVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallCenConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallCenConfigureRequest
         * @return DeleteVpcFirewallCenConfigureResponse
         */
        public DeleteVpcFirewallCenConfigureResponse DeleteVpcFirewallCenConfigure(DeleteVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallCenConfigureRequest
         * @return DeleteVpcFirewallCenConfigureResponse
         */
        public async Task<DeleteVpcFirewallCenConfigureResponse> DeleteVpcFirewallCenConfigureAsync(DeleteVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.
         *
         * @description You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcFirewallConfigureResponse
         */
        public DeleteVpcFirewallConfigureResponse DeleteVpcFirewallConfigureWithOptions(DeleteVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallConfigureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.
         *
         * @description You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcFirewallConfigureResponse
         */
        public async Task<DeleteVpcFirewallConfigureResponse> DeleteVpcFirewallConfigureWithOptionsAsync(DeleteVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.
         *
         * @description You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallConfigureRequest
         * @return DeleteVpcFirewallConfigureResponse
         */
        public DeleteVpcFirewallConfigureResponse DeleteVpcFirewallConfigure(DeleteVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallConfigureWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.
         *
         * @description You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallConfigureRequest
         * @return DeleteVpcFirewallConfigureResponse
         */
        public async Task<DeleteVpcFirewallConfigureResponse> DeleteVpcFirewallConfigureAsync(DeleteVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. 
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcFirewallControlPolicyResponse
         */
        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicyWithOptions(DeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. 
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcFirewallControlPolicyResponse
         */
        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyWithOptionsAsync(DeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. 
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallControlPolicyRequest
         * @return DeleteVpcFirewallControlPolicyResponse
         */
        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicy(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. 
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteVpcFirewallControlPolicyRequest
         * @return DeleteVpcFirewallControlPolicyResponse
         */
        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyAsync(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the statistics on the requests that are blocked by the access control list (ACL) feature.
         *
         * @param request DescribeACLProtectTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeACLProtectTrendResponse
         */
        public DescribeACLProtectTrendResponse DescribeACLProtectTrendWithOptions(DescribeACLProtectTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "DescribeACLProtectTrend",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeACLProtectTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the statistics on the requests that are blocked by the access control list (ACL) feature.
         *
         * @param request DescribeACLProtectTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeACLProtectTrendResponse
         */
        public async Task<DescribeACLProtectTrendResponse> DescribeACLProtectTrendWithOptionsAsync(DescribeACLProtectTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "DescribeACLProtectTrend",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeACLProtectTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the statistics on the requests that are blocked by the access control list (ACL) feature.
         *
         * @param request DescribeACLProtectTrendRequest
         * @return DescribeACLProtectTrendResponse
         */
        public DescribeACLProtectTrendResponse DescribeACLProtectTrend(DescribeACLProtectTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeACLProtectTrendWithOptions(request, runtime);
        }

        /**
         * @summary Queries the statistics on the requests that are blocked by the access control list (ACL) feature.
         *
         * @param request DescribeACLProtectTrendRequest
         * @return DescribeACLProtectTrendResponse
         */
        public async Task<DescribeACLProtectTrendResponse> DescribeACLProtectTrendAsync(DescribeACLProtectTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeACLProtectTrendWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about an address book for an access control policy.
         *
         * @description You can call this operation to query the details about an address book for an access control policy.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddressBookResponse
         */
        public DescribeAddressBookResponse DescribeAddressBookWithOptions(DescribeAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainPort))
            {
                query["ContainPort"] = request.ContainPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressBookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about an address book for an access control policy.
         *
         * @description You can call this operation to query the details about an address book for an access control policy.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddressBookResponse
         */
        public async Task<DescribeAddressBookResponse> DescribeAddressBookWithOptionsAsync(DescribeAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainPort))
            {
                query["ContainPort"] = request.ContainPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about an address book for an access control policy.
         *
         * @description You can call this operation to query the details about an address book for an access control policy.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAddressBookRequest
         * @return DescribeAddressBookResponse
         */
        public DescribeAddressBookResponse DescribeAddressBook(DescribeAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddressBookWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about an address book for an access control policy.
         *
         * @description You can call this operation to query the details about an address book for an access control policy.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAddressBookRequest
         * @return DescribeAddressBookResponse
         */
        public async Task<DescribeAddressBookResponse> DescribeAddressBookAsync(DescribeAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddressBookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the assets that are protected by Cloud Firewall.
         *
         * @description You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAssetListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAssetListResponse
         */
        public DescribeAssetListResponse DescribeAssetListWithOptions(DescribeAssetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceTag))
            {
                query["NewResourceTag"] = request.NewResourceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItem))
            {
                query["SearchItem"] = request.SearchItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgStatus))
            {
                query["SgStatus"] = request.SgStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the assets that are protected by Cloud Firewall.
         *
         * @description You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAssetListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAssetListResponse
         */
        public async Task<DescribeAssetListResponse> DescribeAssetListWithOptionsAsync(DescribeAssetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceTag))
            {
                query["NewResourceTag"] = request.NewResourceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItem))
            {
                query["SearchItem"] = request.SearchItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgStatus))
            {
                query["SgStatus"] = request.SgStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the assets that are protected by Cloud Firewall.
         *
         * @description You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAssetListRequest
         * @return DescribeAssetListResponse
         */
        public DescribeAssetListResponse DescribeAssetList(DescribeAssetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the assets that are protected by Cloud Firewall.
         *
         * @description You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeAssetListRequest
         * @return DescribeAssetListResponse
         */
        public async Task<DescribeAssetListResponse> DescribeAssetListAsync(DescribeAssetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the risk levels of assets.
         *
         * @param request DescribeAssetRiskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAssetRiskListResponse
         */
        public DescribeAssetRiskListResponse DescribeAssetRiskListWithOptions(DescribeAssetRiskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpAddrList))
            {
                query["IpAddrList"] = request.IpAddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetRiskList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetRiskListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the risk levels of assets.
         *
         * @param request DescribeAssetRiskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAssetRiskListResponse
         */
        public async Task<DescribeAssetRiskListResponse> DescribeAssetRiskListWithOptionsAsync(DescribeAssetRiskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpAddrList))
            {
                query["IpAddrList"] = request.IpAddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetRiskList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetRiskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the risk levels of assets.
         *
         * @param request DescribeAssetRiskListRequest
         * @return DescribeAssetRiskListResponse
         */
        public DescribeAssetRiskListResponse DescribeAssetRiskList(DescribeAssetRiskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetRiskListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the risk levels of assets.
         *
         * @param request DescribeAssetRiskListRequest
         * @return DescribeAssetRiskListResponse
         */
        public async Task<DescribeAssetRiskListResponse> DescribeAssetRiskListAsync(DescribeAssetRiskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetRiskListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the firewall risk level.
         *
         * @param request DescribeCfwRiskLevelSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCfwRiskLevelSummaryResponse
         */
        public DescribeCfwRiskLevelSummaryResponse DescribeCfwRiskLevelSummaryWithOptions(DescribeCfwRiskLevelSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeCfwRiskLevelSummary",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCfwRiskLevelSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the firewall risk level.
         *
         * @param request DescribeCfwRiskLevelSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCfwRiskLevelSummaryResponse
         */
        public async Task<DescribeCfwRiskLevelSummaryResponse> DescribeCfwRiskLevelSummaryWithOptionsAsync(DescribeCfwRiskLevelSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeCfwRiskLevelSummary",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCfwRiskLevelSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the firewall risk level.
         *
         * @param request DescribeCfwRiskLevelSummaryRequest
         * @return DescribeCfwRiskLevelSummaryResponse
         */
        public DescribeCfwRiskLevelSummaryResponse DescribeCfwRiskLevelSummary(DescribeCfwRiskLevelSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCfwRiskLevelSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the firewall risk level.
         *
         * @param request DescribeCfwRiskLevelSummaryRequest
         * @return DescribeCfwRiskLevelSummaryResponse
         */
        public async Task<DescribeCfwRiskLevelSummaryResponse> DescribeCfwRiskLevelSummaryAsync(DescribeCfwRiskLevelSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCfwRiskLevelSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about all access control policies.
         *
         * @description You can call the DescribeControlPolicy operation to query the details about access control policies by page.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeControlPolicyResponse
         */
        public DescribeControlPolicyResponse DescribeControlPolicyWithOptions(DescribeControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about all access control policies.
         *
         * @description You can call the DescribeControlPolicy operation to query the details about access control policies by page.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeControlPolicyResponse
         */
        public async Task<DescribeControlPolicyResponse> DescribeControlPolicyWithOptionsAsync(DescribeControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about all access control policies.
         *
         * @description You can call the DescribeControlPolicy operation to query the details about access control policies by page.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeControlPolicyRequest
         * @return DescribeControlPolicyResponse
         */
        public DescribeControlPolicyResponse DescribeControlPolicy(DescribeControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about all access control policies.
         *
         * @description You can call the DescribeControlPolicy operation to query the details about access control policies by page.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeControlPolicyRequest
         * @return DescribeControlPolicyResponse
         */
        public async Task<DescribeControlPolicyResponse> DescribeControlPolicyAsync(DescribeControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the default configurations of the intrusion prevention system (IPS).
         *
         * @param request DescribeDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefaultIPSConfigResponse
         */
        public DescribeDefaultIPSConfigResponse DescribeDefaultIPSConfigWithOptions(DescribeDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefaultIPSConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the default configurations of the intrusion prevention system (IPS).
         *
         * @param request DescribeDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefaultIPSConfigResponse
         */
        public async Task<DescribeDefaultIPSConfigResponse> DescribeDefaultIPSConfigWithOptionsAsync(DescribeDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefaultIPSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the default configurations of the intrusion prevention system (IPS).
         *
         * @param request DescribeDefaultIPSConfigRequest
         * @return DescribeDefaultIPSConfigResponse
         */
        public DescribeDefaultIPSConfigResponse DescribeDefaultIPSConfig(DescribeDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefaultIPSConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the default configurations of the intrusion prevention system (IPS).
         *
         * @param request DescribeDefaultIPSConfigRequest
         * @return DescribeDefaultIPSConfigResponse
         */
        public async Task<DescribeDefaultIPSConfigResponse> DescribeDefaultIPSConfigAsync(DescribeDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeDomainResolve is deprecated
         *
         * @summary Queries Domain Name System (DNS) records.
         *
         * @description You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDomainResolveRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainResolveResponse
         */
        // Deprecated
        public DescribeDomainResolveResponse DescribeDomainResolveWithOptions(DescribeDomainResolveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainResolve",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResolveResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeDomainResolve is deprecated
         *
         * @summary Queries Domain Name System (DNS) records.
         *
         * @description You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDomainResolveRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainResolveResponse
         */
        // Deprecated
        public async Task<DescribeDomainResolveResponse> DescribeDomainResolveWithOptionsAsync(DescribeDomainResolveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainResolve",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResolveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeDomainResolve is deprecated
         *
         * @summary Queries Domain Name System (DNS) records.
         *
         * @description You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDomainResolveRequest
         * @return DescribeDomainResolveResponse
         */
        // Deprecated
        public DescribeDomainResolveResponse DescribeDomainResolve(DescribeDomainResolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainResolveWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeDomainResolve is deprecated
         *
         * @summary Queries Domain Name System (DNS) records.
         *
         * @description You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDomainResolveRequest
         * @return DescribeDomainResolveResponse
         */
        // Deprecated
        public async Task<DescribeDomainResolveResponse> DescribeDomainResolveAsync(DescribeDomainResolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainResolveWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries file download tasks, including the task information and download URLs.
         *
         * @param request DescribeDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadTaskResponse
         */
        public DescribeDownloadTaskResponse DescribeDownloadTaskWithOptions(DescribeDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadTask",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries file download tasks, including the task information and download URLs.
         *
         * @param request DescribeDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadTaskResponse
         */
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskWithOptionsAsync(DescribeDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadTask",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries file download tasks, including the task information and download URLs.
         *
         * @param request DescribeDownloadTaskRequest
         * @return DescribeDownloadTaskResponse
         */
        public DescribeDownloadTaskResponse DescribeDownloadTask(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadTaskWithOptions(request, runtime);
        }

        /**
         * @summary Queries file download tasks, including the task information and download URLs.
         *
         * @param request DescribeDownloadTaskRequest
         * @return DescribeDownloadTaskResponse
         */
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskAsync(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.
         *
         * @param request DescribeDownloadTaskTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadTaskTypeResponse
         */
        public DescribeDownloadTaskTypeResponse DescribeDownloadTaskTypeWithOptions(DescribeDownloadTaskTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadTaskType",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.
         *
         * @param request DescribeDownloadTaskTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadTaskTypeResponse
         */
        public async Task<DescribeDownloadTaskTypeResponse> DescribeDownloadTaskTypeWithOptionsAsync(DescribeDownloadTaskTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadTaskType",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.
         *
         * @param request DescribeDownloadTaskTypeRequest
         * @return DescribeDownloadTaskTypeResponse
         */
        public DescribeDownloadTaskTypeResponse DescribeDownloadTaskType(DescribeDownloadTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadTaskTypeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.
         *
         * @param request DescribeDownloadTaskTypeRequest
         * @return DescribeDownloadTaskTypeResponse
         */
        public async Task<DescribeDownloadTaskTypeResponse> DescribeDownloadTaskTypeAsync(DescribeDownloadTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadTaskTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about members in Cloud Firewall.
         *
         * @description You can use this operation to query the information about members in Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceMembersResponse
         */
        public DescribeInstanceMembersResponse DescribeInstanceMembersWithOptions(DescribeInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDesc))
            {
                query["MemberDesc"] = request.MemberDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDisplayName))
            {
                query["MemberDisplayName"] = request.MemberDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about members in Cloud Firewall.
         *
         * @description You can use this operation to query the information about members in Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceMembersResponse
         */
        public async Task<DescribeInstanceMembersResponse> DescribeInstanceMembersWithOptionsAsync(DescribeInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDesc))
            {
                query["MemberDesc"] = request.MemberDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDisplayName))
            {
                query["MemberDisplayName"] = request.MemberDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about members in Cloud Firewall.
         *
         * @description You can use this operation to query the information about members in Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceMembersRequest
         * @return DescribeInstanceMembersResponse
         */
        public DescribeInstanceMembersResponse DescribeInstanceMembers(DescribeInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMembersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about members in Cloud Firewall.
         *
         * @description You can use this operation to query the information about members in Cloud Firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceMembersRequest
         * @return DescribeInstanceMembersResponse
         */
        public async Task<DescribeInstanceMembersResponse> DescribeInstanceMembersAsync(DescribeInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the risk levels of instances.
         *
         * @param request DescribeInstanceRiskLevelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceRiskLevelsResponse
         */
        public DescribeInstanceRiskLevelsResponse DescribeInstanceRiskLevelsWithOptions(DescribeInstanceRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceRiskLevels",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceRiskLevelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the risk levels of instances.
         *
         * @param request DescribeInstanceRiskLevelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceRiskLevelsResponse
         */
        public async Task<DescribeInstanceRiskLevelsResponse> DescribeInstanceRiskLevelsWithOptionsAsync(DescribeInstanceRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceRiskLevels",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceRiskLevelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the risk levels of instances.
         *
         * @param request DescribeInstanceRiskLevelsRequest
         * @return DescribeInstanceRiskLevelsResponse
         */
        public DescribeInstanceRiskLevelsResponse DescribeInstanceRiskLevels(DescribeInstanceRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceRiskLevelsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the risk levels of instances.
         *
         * @param request DescribeInstanceRiskLevelsRequest
         * @return DescribeInstanceRiskLevelsResponse
         */
        public async Task<DescribeInstanceRiskLevelsResponse> DescribeInstanceRiskLevelsAsync(DescribeInstanceRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceRiskLevelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the IP addresses that are open to the Internet.
         *
         * @param request DescribeInternetOpenIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInternetOpenIpResponse
         */
        public DescribeInternetOpenIpResponse DescribeInternetOpenIpWithOptions(DescribeInternetOpenIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceId))
            {
                query["AssetsInstanceId"] = request.AssetsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceName))
            {
                query["AssetsInstanceName"] = request.AssetsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsType))
            {
                query["AssetsType"] = request.AssetsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIp))
            {
                query["PublicIp"] = request.PublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
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
                Action = "DescribeInternetOpenIp",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInternetOpenIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IP addresses that are open to the Internet.
         *
         * @param request DescribeInternetOpenIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInternetOpenIpResponse
         */
        public async Task<DescribeInternetOpenIpResponse> DescribeInternetOpenIpWithOptionsAsync(DescribeInternetOpenIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceId))
            {
                query["AssetsInstanceId"] = request.AssetsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceName))
            {
                query["AssetsInstanceName"] = request.AssetsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsType))
            {
                query["AssetsType"] = request.AssetsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIp))
            {
                query["PublicIp"] = request.PublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
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
                Action = "DescribeInternetOpenIp",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInternetOpenIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IP addresses that are open to the Internet.
         *
         * @param request DescribeInternetOpenIpRequest
         * @return DescribeInternetOpenIpResponse
         */
        public DescribeInternetOpenIpResponse DescribeInternetOpenIp(DescribeInternetOpenIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInternetOpenIpWithOptions(request, runtime);
        }

        /**
         * @summary Queries the IP addresses that are open to the Internet.
         *
         * @param request DescribeInternetOpenIpRequest
         * @return DescribeInternetOpenIpResponse
         */
        public async Task<DescribeInternetOpenIpResponse> DescribeInternetOpenIpAsync(DescribeInternetOpenIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInternetOpenIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the trends of Internet traffic.
         *
         * @param request DescribeInternetTrafficTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInternetTrafficTrendResponse
         */
        public DescribeInternetTrafficTrendResponse DescribeInternetTrafficTrendWithOptions(DescribeInternetTrafficTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCode))
            {
                query["SourceCode"] = request.SourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPrivateIP))
            {
                query["SrcPrivateIP"] = request.SrcPrivateIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPublicIP))
            {
                query["SrcPublicIP"] = request.SrcPublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficType))
            {
                query["TrafficType"] = request.TrafficType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInternetTrafficTrend",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInternetTrafficTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the trends of Internet traffic.
         *
         * @param request DescribeInternetTrafficTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInternetTrafficTrendResponse
         */
        public async Task<DescribeInternetTrafficTrendResponse> DescribeInternetTrafficTrendWithOptionsAsync(DescribeInternetTrafficTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCode))
            {
                query["SourceCode"] = request.SourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPrivateIP))
            {
                query["SrcPrivateIP"] = request.SrcPrivateIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPublicIP))
            {
                query["SrcPublicIP"] = request.SrcPublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficType))
            {
                query["TrafficType"] = request.TrafficType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInternetTrafficTrend",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInternetTrafficTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the trends of Internet traffic.
         *
         * @param request DescribeInternetTrafficTrendRequest
         * @return DescribeInternetTrafficTrendResponse
         */
        public DescribeInternetTrafficTrendResponse DescribeInternetTrafficTrend(DescribeInternetTrafficTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInternetTrafficTrendWithOptions(request, runtime);
        }

        /**
         * @summary Queries the trends of Internet traffic.
         *
         * @param request DescribeInternetTrafficTrendRequest
         * @return DescribeInternetTrafficTrendResponse
         */
        public async Task<DescribeInternetTrafficTrendResponse> DescribeInternetTrafficTrendAsync(DescribeInternetTrafficTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInternetTrafficTrendWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the breach awareness events of a firewall.
         *
         * @param request DescribeInvadeEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInvadeEventListResponse
         */
        public DescribeInvadeEventListResponse DescribeInvadeEventListWithOptions(DescribeInvadeEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsIP))
            {
                query["AssetsIP"] = request.AssetsIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceId))
            {
                query["AssetsInstanceId"] = request.AssetsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceName))
            {
                query["AssetsInstanceName"] = request.AssetsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventKey))
            {
                query["EventKey"] = request.EventKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuid))
            {
                query["EventUuid"] = request.EventUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsIgnore))
            {
                query["IsIgnore"] = request.IsIgnore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessStatusList))
            {
                query["ProcessStatusList"] = request.ProcessStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "DescribeInvadeEventList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvadeEventListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the breach awareness events of a firewall.
         *
         * @param request DescribeInvadeEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInvadeEventListResponse
         */
        public async Task<DescribeInvadeEventListResponse> DescribeInvadeEventListWithOptionsAsync(DescribeInvadeEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsIP))
            {
                query["AssetsIP"] = request.AssetsIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceId))
            {
                query["AssetsInstanceId"] = request.AssetsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceName))
            {
                query["AssetsInstanceName"] = request.AssetsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventKey))
            {
                query["EventKey"] = request.EventKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuid))
            {
                query["EventUuid"] = request.EventUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsIgnore))
            {
                query["IsIgnore"] = request.IsIgnore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessStatusList))
            {
                query["ProcessStatusList"] = request.ProcessStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "DescribeInvadeEventList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvadeEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the breach awareness events of a firewall.
         *
         * @param request DescribeInvadeEventListRequest
         * @return DescribeInvadeEventListResponse
         */
        public DescribeInvadeEventListResponse DescribeInvadeEventList(DescribeInvadeEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvadeEventListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the breach awareness events of a firewall.
         *
         * @param request DescribeInvadeEventListRequest
         * @return DescribeInvadeEventListResponse
         */
        public async Task<DescribeInvadeEventListResponse> DescribeInvadeEventListAsync(DescribeInvadeEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvadeEventListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the pagination status of NAT firewalls.
         *
         * @param request DescribeNatAclPageStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatAclPageStatusResponse
         */
        public DescribeNatAclPageStatusResponse DescribeNatAclPageStatusWithOptions(DescribeNatAclPageStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatAclPageStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatAclPageStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the pagination status of NAT firewalls.
         *
         * @param request DescribeNatAclPageStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatAclPageStatusResponse
         */
        public async Task<DescribeNatAclPageStatusResponse> DescribeNatAclPageStatusWithOptionsAsync(DescribeNatAclPageStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatAclPageStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatAclPageStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the pagination status of NAT firewalls.
         *
         * @param request DescribeNatAclPageStatusRequest
         * @return DescribeNatAclPageStatusResponse
         */
        public DescribeNatAclPageStatusResponse DescribeNatAclPageStatus(DescribeNatAclPageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatAclPageStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the pagination status of NAT firewalls.
         *
         * @param request DescribeNatAclPageStatusRequest
         * @return DescribeNatAclPageStatusResponse
         */
        public async Task<DescribeNatAclPageStatusResponse> DescribeNatAclPageStatusAsync(DescribeNatAclPageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatAclPageStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about all access control policies that are created for NAT firewalls.
         *
         * @description You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.
         *
         * @param request DescribeNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatFirewallControlPolicyResponse
         */
        public DescribeNatFirewallControlPolicyResponse DescribeNatFirewallControlPolicyWithOptions(DescribeNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all access control policies that are created for NAT firewalls.
         *
         * @description You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.
         *
         * @param request DescribeNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatFirewallControlPolicyResponse
         */
        public async Task<DescribeNatFirewallControlPolicyResponse> DescribeNatFirewallControlPolicyWithOptionsAsync(DescribeNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all access control policies that are created for NAT firewalls.
         *
         * @description You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.
         *
         * @param request DescribeNatFirewallControlPolicyRequest
         * @return DescribeNatFirewallControlPolicyResponse
         */
        public DescribeNatFirewallControlPolicyResponse DescribeNatFirewallControlPolicy(DescribeNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about all access control policies that are created for NAT firewalls.
         *
         * @description You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.
         *
         * @param request DescribeNatFirewallControlPolicyRequest
         * @return DescribeNatFirewallControlPolicyResponse
         */
        public async Task<DescribeNatFirewallControlPolicyResponse> DescribeNatFirewallControlPolicyAsync(DescribeNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries details of NAT firewalls.
         *
         * @param request DescribeNatFirewallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatFirewallListResponse
         */
        public DescribeNatFirewallListResponse DescribeNatFirewallListWithOptions(DescribeNatFirewallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyId))
            {
                query["ProxyId"] = request.ProxyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyName))
            {
                query["ProxyName"] = request.ProxyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeNatFirewallList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries details of NAT firewalls.
         *
         * @param request DescribeNatFirewallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatFirewallListResponse
         */
        public async Task<DescribeNatFirewallListResponse> DescribeNatFirewallListWithOptionsAsync(DescribeNatFirewallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyId))
            {
                query["ProxyId"] = request.ProxyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyName))
            {
                query["ProxyName"] = request.ProxyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeNatFirewallList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries details of NAT firewalls.
         *
         * @param request DescribeNatFirewallListRequest
         * @return DescribeNatFirewallListResponse
         */
        public DescribeNatFirewallListResponse DescribeNatFirewallList(DescribeNatFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallListWithOptions(request, runtime);
        }

        /**
         * @summary Queries details of NAT firewalls.
         *
         * @param request DescribeNatFirewallListRequest
         * @return DescribeNatFirewallListResponse
         */
        public async Task<DescribeNatFirewallListResponse> DescribeNatFirewallListAsync(DescribeNatFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a NAT firewall.
         *
         * @description You can use this operation to query the priority range of access control policies that are created for a NAT firewall.
         *
         * @param request DescribeNatFirewallPolicyPriorUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatFirewallPolicyPriorUsedResponse
         */
        public DescribeNatFirewallPolicyPriorUsedResponse DescribeNatFirewallPolicyPriorUsedWithOptions(DescribeNatFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatFirewallPolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallPolicyPriorUsedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a NAT firewall.
         *
         * @description You can use this operation to query the priority range of access control policies that are created for a NAT firewall.
         *
         * @param request DescribeNatFirewallPolicyPriorUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNatFirewallPolicyPriorUsedResponse
         */
        public async Task<DescribeNatFirewallPolicyPriorUsedResponse> DescribeNatFirewallPolicyPriorUsedWithOptionsAsync(DescribeNatFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatFirewallPolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallPolicyPriorUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a NAT firewall.
         *
         * @description You can use this operation to query the priority range of access control policies that are created for a NAT firewall.
         *
         * @param request DescribeNatFirewallPolicyPriorUsedRequest
         * @return DescribeNatFirewallPolicyPriorUsedResponse
         */
        public DescribeNatFirewallPolicyPriorUsedResponse DescribeNatFirewallPolicyPriorUsed(DescribeNatFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallPolicyPriorUsedWithOptions(request, runtime);
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a NAT firewall.
         *
         * @description You can use this operation to query the priority range of access control policies that are created for a NAT firewall.
         *
         * @param request DescribeNatFirewallPolicyPriorUsedRequest
         * @return DescribeNatFirewallPolicyPriorUsedResponse
         */
        public async Task<DescribeNatFirewallPolicyPriorUsedResponse> DescribeNatFirewallPolicyPriorUsedAsync(DescribeNatFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallPolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the destination IP addresses in outbound connections.
         *
         * @param request DescribeOutgoingDestinationIPRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOutgoingDestinationIPResponse
         */
        public DescribeOutgoingDestinationIPResponse DescribeOutgoingDestinationIPWithOptions(DescribeOutgoingDestinationIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIP))
            {
                query["PrivateIP"] = request.PrivateIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIdNew))
            {
                query["TagIdNew"] = request.TagIdNew;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOutgoingDestinationIP",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDestinationIPResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the destination IP addresses in outbound connections.
         *
         * @param request DescribeOutgoingDestinationIPRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOutgoingDestinationIPResponse
         */
        public async Task<DescribeOutgoingDestinationIPResponse> DescribeOutgoingDestinationIPWithOptionsAsync(DescribeOutgoingDestinationIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIP))
            {
                query["PrivateIP"] = request.PrivateIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIdNew))
            {
                query["TagIdNew"] = request.TagIdNew;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOutgoingDestinationIP",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDestinationIPResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the destination IP addresses in outbound connections.
         *
         * @param request DescribeOutgoingDestinationIPRequest
         * @return DescribeOutgoingDestinationIPResponse
         */
        public DescribeOutgoingDestinationIPResponse DescribeOutgoingDestinationIP(DescribeOutgoingDestinationIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutgoingDestinationIPWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the destination IP addresses in outbound connections.
         *
         * @param request DescribeOutgoingDestinationIPRequest
         * @return DescribeOutgoingDestinationIPResponse
         */
        public async Task<DescribeOutgoingDestinationIPResponse> DescribeOutgoingDestinationIPAsync(DescribeOutgoingDestinationIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutgoingDestinationIPWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the domain names in outbound connections.
         *
         * @param request DescribeOutgoingDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOutgoingDomainResponse
         */
        public DescribeOutgoingDomainResponse DescribeOutgoingDomainWithOptions(DescribeOutgoingDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIdNew))
            {
                query["TagIdNew"] = request.TagIdNew;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOutgoingDomain",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the domain names in outbound connections.
         *
         * @param request DescribeOutgoingDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOutgoingDomainResponse
         */
        public async Task<DescribeOutgoingDomainResponse> DescribeOutgoingDomainWithOptionsAsync(DescribeOutgoingDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIdNew))
            {
                query["TagIdNew"] = request.TagIdNew;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOutgoingDomain",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the domain names in outbound connections.
         *
         * @param request DescribeOutgoingDomainRequest
         * @return DescribeOutgoingDomainResponse
         */
        public DescribeOutgoingDomainResponse DescribeOutgoingDomain(DescribeOutgoingDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutgoingDomainWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the domain names in outbound connections.
         *
         * @param request DescribeOutgoingDomainRequest
         * @return DescribeOutgoingDomainResponse
         */
        public async Task<DescribeOutgoingDomainResponse> DescribeOutgoingDomainAsync(DescribeOutgoingDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutgoingDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether the strict mode is enabled for an access control policy.
         *
         * @description You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyAdvancedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyAdvancedConfigResponse
         */
        public DescribePolicyAdvancedConfigResponse DescribePolicyAdvancedConfigWithOptions(DescribePolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyAdvancedConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether the strict mode is enabled for an access control policy.
         *
         * @description You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyAdvancedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyAdvancedConfigResponse
         */
        public async Task<DescribePolicyAdvancedConfigResponse> DescribePolicyAdvancedConfigWithOptionsAsync(DescribePolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyAdvancedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether the strict mode is enabled for an access control policy.
         *
         * @description You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyAdvancedConfigRequest
         * @return DescribePolicyAdvancedConfigResponse
         */
        public DescribePolicyAdvancedConfigResponse DescribePolicyAdvancedConfig(DescribePolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyAdvancedConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether the strict mode is enabled for an access control policy.
         *
         * @description You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyAdvancedConfigRequest
         * @return DescribePolicyAdvancedConfigResponse
         */
        public async Task<DescribePolicyAdvancedConfigResponse> DescribePolicyAdvancedConfigAsync(DescribePolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the priority range of access control policies.
         *
         * @description You can call this operation to query the priority range of the access control policies that match specific query conditions.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyPriorUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyPriorUsedResponse
         */
        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsedWithOptions(DescribePolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyPriorUsedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the priority range of access control policies.
         *
         * @description You can call this operation to query the priority range of the access control policies that match specific query conditions.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyPriorUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyPriorUsedResponse
         */
        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedWithOptionsAsync(DescribePolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyPriorUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the priority range of access control policies.
         *
         * @description You can call this operation to query the priority range of the access control policies that match specific query conditions.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyPriorUsedRequest
         * @return DescribePolicyPriorUsedResponse
         */
        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsed(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyPriorUsedWithOptions(request, runtime);
        }

        /**
         * @summary Queries the priority range of access control policies.
         *
         * @description You can call this operation to query the priority range of the access control policies that match specific query conditions.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePolicyPriorUsedRequest
         * @return DescribePolicyPriorUsedResponse
         */
        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedAsync(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of traffic billed based on the pay-as-you-go billing method.
         *
         * @description If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.
         *
         * @param request DescribePostpayTrafficDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePostpayTrafficDetailResponse
         */
        public DescribePostpayTrafficDetailResponse DescribePostpayTrafficDetailWithOptions(DescribePostpayTrafficDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItem))
            {
                query["SearchItem"] = request.SearchItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficType))
            {
                query["TrafficType"] = request.TrafficType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePostpayTrafficDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePostpayTrafficDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of traffic billed based on the pay-as-you-go billing method.
         *
         * @description If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.
         *
         * @param request DescribePostpayTrafficDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePostpayTrafficDetailResponse
         */
        public async Task<DescribePostpayTrafficDetailResponse> DescribePostpayTrafficDetailWithOptionsAsync(DescribePostpayTrafficDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItem))
            {
                query["SearchItem"] = request.SearchItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficType))
            {
                query["TrafficType"] = request.TrafficType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePostpayTrafficDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePostpayTrafficDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of traffic billed based on the pay-as-you-go billing method.
         *
         * @description If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.
         *
         * @param request DescribePostpayTrafficDetailRequest
         * @return DescribePostpayTrafficDetailResponse
         */
        public DescribePostpayTrafficDetailResponse DescribePostpayTrafficDetail(DescribePostpayTrafficDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePostpayTrafficDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of traffic billed based on the pay-as-you-go billing method.
         *
         * @description If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.
         *
         * @param request DescribePostpayTrafficDetailRequest
         * @return DescribePostpayTrafficDetailResponse
         */
        public async Task<DescribePostpayTrafficDetailResponse> DescribePostpayTrafficDetailAsync(DescribePostpayTrafficDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePostpayTrafficDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.
         *
         * @description You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.
         *
         * @param request DescribePostpayTrafficTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePostpayTrafficTotalResponse
         */
        public DescribePostpayTrafficTotalResponse DescribePostpayTrafficTotalWithOptions(DescribePostpayTrafficTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePostpayTrafficTotal",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePostpayTrafficTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.
         *
         * @description You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.
         *
         * @param request DescribePostpayTrafficTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePostpayTrafficTotalResponse
         */
        public async Task<DescribePostpayTrafficTotalResponse> DescribePostpayTrafficTotalWithOptionsAsync(DescribePostpayTrafficTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePostpayTrafficTotal",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePostpayTrafficTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.
         *
         * @description You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.
         *
         * @param request DescribePostpayTrafficTotalRequest
         * @return DescribePostpayTrafficTotalResponse
         */
        public DescribePostpayTrafficTotalResponse DescribePostpayTrafficTotal(DescribePostpayTrafficTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePostpayTrafficTotalWithOptions(request, runtime);
        }

        /**
         * @summary Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.
         *
         * @description You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.
         *
         * @param request DescribePostpayTrafficTotalRequest
         * @return DescribePostpayTrafficTotalResponse
         */
        public async Task<DescribePostpayTrafficTotalResponse> DescribePostpayTrafficTotalAsync(DescribePostpayTrafficTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePostpayTrafficTotalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries prefix lists.
         *
         * @param request DescribePrefixListsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePrefixListsResponse
         */
        public DescribePrefixListsResponse DescribePrefixListsWithOptions(DescribePrefixListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrefixLists",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePrefixListsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries prefix lists.
         *
         * @param request DescribePrefixListsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePrefixListsResponse
         */
        public async Task<DescribePrefixListsResponse> DescribePrefixListsWithOptionsAsync(DescribePrefixListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrefixLists",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePrefixListsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries prefix lists.
         *
         * @param request DescribePrefixListsRequest
         * @return DescribePrefixListsResponse
         */
        public DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePrefixListsWithOptions(request, runtime);
        }

        /**
         * @summary Queries prefix lists.
         *
         * @param request DescribePrefixListsRequest
         * @return DescribePrefixListsResponse
         */
        public async Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePrefixListsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of intrusion events.
         *
         * @description You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskEventGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRiskEventGroupResponse
         */
        public DescribeRiskEventGroupResponse DescribeRiskEventGroupWithOptions(DescribeRiskEventGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackApp))
            {
                query["AttackApp"] = request.AttackApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyVersion))
            {
                query["BuyVersion"] = request.BuyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstNetworkInstanceId))
            {
                query["DstNetworkInstanceId"] = request.DstNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallType))
            {
                query["FirewallType"] = request.FirewallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoLocation))
            {
                query["NoLocation"] = request.NoLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleResult))
            {
                query["RuleResult"] = request.RuleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleSource))
            {
                query["RuleSource"] = request.RuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIP))
            {
                query["SrcIP"] = request.SrcIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcNetworkInstanceId))
            {
                query["SrcNetworkInstanceId"] = request.SrcNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulLevel))
            {
                query["VulLevel"] = request.VulLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskEventGroup",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskEventGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of intrusion events.
         *
         * @description You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskEventGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRiskEventGroupResponse
         */
        public async Task<DescribeRiskEventGroupResponse> DescribeRiskEventGroupWithOptionsAsync(DescribeRiskEventGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackApp))
            {
                query["AttackApp"] = request.AttackApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyVersion))
            {
                query["BuyVersion"] = request.BuyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstNetworkInstanceId))
            {
                query["DstNetworkInstanceId"] = request.DstNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallType))
            {
                query["FirewallType"] = request.FirewallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoLocation))
            {
                query["NoLocation"] = request.NoLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleResult))
            {
                query["RuleResult"] = request.RuleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleSource))
            {
                query["RuleSource"] = request.RuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIP))
            {
                query["SrcIP"] = request.SrcIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcNetworkInstanceId))
            {
                query["SrcNetworkInstanceId"] = request.SrcNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulLevel))
            {
                query["VulLevel"] = request.VulLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskEventGroup",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskEventGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of intrusion events.
         *
         * @description You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskEventGroupRequest
         * @return DescribeRiskEventGroupResponse
         */
        public DescribeRiskEventGroupResponse DescribeRiskEventGroup(DescribeRiskEventGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskEventGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of intrusion events.
         *
         * @description You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskEventGroupRequest
         * @return DescribeRiskEventGroupResponse
         */
        public async Task<DescribeRiskEventGroupResponse> DescribeRiskEventGroupAsync(DescribeRiskEventGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskEventGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the attack payloads of intrusion events.
         *
         * @param request DescribeRiskEventPayloadRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRiskEventPayloadResponse
         */
        public DescribeRiskEventPayloadResponse DescribeRiskEventPayloadWithOptions(DescribeRiskEventPayloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstVpcId))
            {
                query["DstVpcId"] = request.DstVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallType))
            {
                query["FirewallType"] = request.FirewallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIP))
            {
                query["SrcIP"] = request.SrcIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcVpcId))
            {
                query["SrcVpcId"] = request.SrcVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UUID))
            {
                query["UUID"] = request.UUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskEventPayload",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskEventPayloadResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the attack payloads of intrusion events.
         *
         * @param request DescribeRiskEventPayloadRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRiskEventPayloadResponse
         */
        public async Task<DescribeRiskEventPayloadResponse> DescribeRiskEventPayloadWithOptionsAsync(DescribeRiskEventPayloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstVpcId))
            {
                query["DstVpcId"] = request.DstVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallType))
            {
                query["FirewallType"] = request.FirewallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIP))
            {
                query["SrcIP"] = request.SrcIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcVpcId))
            {
                query["SrcVpcId"] = request.SrcVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UUID))
            {
                query["UUID"] = request.UUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskEventPayload",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskEventPayloadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the attack payloads of intrusion events.
         *
         * @param request DescribeRiskEventPayloadRequest
         * @return DescribeRiskEventPayloadResponse
         */
        public DescribeRiskEventPayloadResponse DescribeRiskEventPayload(DescribeRiskEventPayloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskEventPayloadWithOptions(request, runtime);
        }

        /**
         * @summary Queries the attack payloads of intrusion events.
         *
         * @param request DescribeRiskEventPayloadRequest
         * @return DescribeRiskEventPayloadResponse
         */
        public async Task<DescribeRiskEventPayloadResponse> DescribeRiskEventPayloadAsync(DescribeRiskEventPayloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskEventPayloadWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about signature library versions.
         *
         * @param request DescribeSignatureLibVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSignatureLibVersionResponse
         */
        public DescribeSignatureLibVersionResponse DescribeSignatureLibVersionWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSignatureLibVersion",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSignatureLibVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about signature library versions.
         *
         * @param request DescribeSignatureLibVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSignatureLibVersionResponse
         */
        public async Task<DescribeSignatureLibVersionResponse> DescribeSignatureLibVersionWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSignatureLibVersion",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSignatureLibVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about signature library versions.
         *
         * @return DescribeSignatureLibVersionResponse
         */
        public DescribeSignatureLibVersionResponse DescribeSignatureLibVersion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSignatureLibVersionWithOptions(runtime);
        }

        /**
         * @summary Queries the information about signature library versions.
         *
         * @return DescribeSignatureLibVersionResponse
         */
        public async Task<DescribeSignatureLibVersionResponse> DescribeSignatureLibVersionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSignatureLibVersionWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.
         *
         * @param tmpReq DescribeTrFirewallPolicyBackUpAssociationListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallPolicyBackUpAssociationListResponse
         */
        public DescribeTrFirewallPolicyBackUpAssociationListResponse DescribeTrFirewallPolicyBackUpAssociationListWithOptions(DescribeTrFirewallPolicyBackUpAssociationListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeTrFirewallPolicyBackUpAssociationListShrinkRequest request = new DescribeTrFirewallPolicyBackUpAssociationListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CandidateList))
            {
                request.CandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CandidateList, "CandidateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateListShrink))
            {
                query["CandidateList"] = request.CandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallPolicyBackUpAssociationList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallPolicyBackUpAssociationListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.
         *
         * @param tmpReq DescribeTrFirewallPolicyBackUpAssociationListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallPolicyBackUpAssociationListResponse
         */
        public async Task<DescribeTrFirewallPolicyBackUpAssociationListResponse> DescribeTrFirewallPolicyBackUpAssociationListWithOptionsAsync(DescribeTrFirewallPolicyBackUpAssociationListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeTrFirewallPolicyBackUpAssociationListShrinkRequest request = new DescribeTrFirewallPolicyBackUpAssociationListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CandidateList))
            {
                request.CandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CandidateList, "CandidateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateListShrink))
            {
                query["CandidateList"] = request.CandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallPolicyBackUpAssociationList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallPolicyBackUpAssociationListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.
         *
         * @param request DescribeTrFirewallPolicyBackUpAssociationListRequest
         * @return DescribeTrFirewallPolicyBackUpAssociationListResponse
         */
        public DescribeTrFirewallPolicyBackUpAssociationListResponse DescribeTrFirewallPolicyBackUpAssociationList(DescribeTrFirewallPolicyBackUpAssociationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallPolicyBackUpAssociationListWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.
         *
         * @param request DescribeTrFirewallPolicyBackUpAssociationListRequest
         * @return DescribeTrFirewallPolicyBackUpAssociationListResponse
         */
        public async Task<DescribeTrFirewallPolicyBackUpAssociationListResponse> DescribeTrFirewallPolicyBackUpAssociationListAsync(DescribeTrFirewallPolicyBackUpAssociationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallPolicyBackUpAssociationListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DescribeTrFirewallV2RoutePolicyListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallV2RoutePolicyListResponse
         */
        public DescribeTrFirewallV2RoutePolicyListResponse DescribeTrFirewallV2RoutePolicyListWithOptions(DescribeTrFirewallV2RoutePolicyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallV2RoutePolicyList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallV2RoutePolicyListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DescribeTrFirewallV2RoutePolicyListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallV2RoutePolicyListResponse
         */
        public async Task<DescribeTrFirewallV2RoutePolicyListResponse> DescribeTrFirewallV2RoutePolicyListWithOptionsAsync(DescribeTrFirewallV2RoutePolicyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallV2RoutePolicyList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallV2RoutePolicyListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DescribeTrFirewallV2RoutePolicyListRequest
         * @return DescribeTrFirewallV2RoutePolicyListResponse
         */
        public DescribeTrFirewallV2RoutePolicyListResponse DescribeTrFirewallV2RoutePolicyList(DescribeTrFirewallV2RoutePolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallV2RoutePolicyListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request DescribeTrFirewallV2RoutePolicyListRequest
         * @return DescribeTrFirewallV2RoutePolicyListResponse
         */
        public async Task<DescribeTrFirewallV2RoutePolicyListResponse> DescribeTrFirewallV2RoutePolicyListAsync(DescribeTrFirewallV2RoutePolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallV2RoutePolicyListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2DetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallsV2DetailResponse
         */
        public DescribeTrFirewallsV2DetailResponse DescribeTrFirewallsV2DetailWithOptions(DescribeTrFirewallsV2DetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallsV2Detail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallsV2DetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2DetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallsV2DetailResponse
         */
        public async Task<DescribeTrFirewallsV2DetailResponse> DescribeTrFirewallsV2DetailWithOptionsAsync(DescribeTrFirewallsV2DetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallsV2Detail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallsV2DetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2DetailRequest
         * @return DescribeTrFirewallsV2DetailResponse
         */
        public DescribeTrFirewallsV2DetailResponse DescribeTrFirewallsV2Detail(DescribeTrFirewallsV2DetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallsV2DetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2DetailRequest
         * @return DescribeTrFirewallsV2DetailResponse
         */
        public async Task<DescribeTrFirewallsV2DetailResponse> DescribeTrFirewallsV2DetailAsync(DescribeTrFirewallsV2DetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallsV2DetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2ListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallsV2ListResponse
         */
        public DescribeTrFirewallsV2ListResponse DescribeTrFirewallsV2ListWithOptions(DescribeTrFirewallsV2ListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallName))
            {
                query["FirewallName"] = request.FirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallsV2List",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallsV2ListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2ListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallsV2ListResponse
         */
        public async Task<DescribeTrFirewallsV2ListResponse> DescribeTrFirewallsV2ListWithOptionsAsync(DescribeTrFirewallsV2ListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallName))
            {
                query["FirewallName"] = request.FirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallsV2List",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallsV2ListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2ListRequest
         * @return DescribeTrFirewallsV2ListResponse
         */
        public DescribeTrFirewallsV2ListResponse DescribeTrFirewallsV2List(DescribeTrFirewallsV2ListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallsV2ListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the virtual private cloud (VPC) firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2ListRequest
         * @return DescribeTrFirewallsV2ListResponse
         */
        public async Task<DescribeTrFirewallsV2ListResponse> DescribeTrFirewallsV2ListAsync(DescribeTrFirewallsV2ListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallsV2ListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the route tables of the VPC firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2RouteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallsV2RouteListResponse
         */
        public DescribeTrFirewallsV2RouteListResponse DescribeTrFirewallsV2RouteListWithOptions(DescribeTrFirewallsV2RouteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallsV2RouteList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallsV2RouteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the route tables of the VPC firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2RouteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTrFirewallsV2RouteListResponse
         */
        public async Task<DescribeTrFirewallsV2RouteListResponse> DescribeTrFirewallsV2RouteListWithOptionsAsync(DescribeTrFirewallsV2RouteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrFirewallsV2RouteList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrFirewallsV2RouteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the route tables of the VPC firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2RouteListRequest
         * @return DescribeTrFirewallsV2RouteListResponse
         */
        public DescribeTrFirewallsV2RouteListResponse DescribeTrFirewallsV2RouteList(DescribeTrFirewallsV2RouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallsV2RouteListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the route tables of the VPC firewalls that are created for transit routers.
         *
         * @param request DescribeTrFirewallsV2RouteListRequest
         * @return DescribeTrFirewallsV2RouteListResponse
         */
        public async Task<DescribeTrFirewallsV2RouteListResponse> DescribeTrFirewallsV2RouteListAsync(DescribeTrFirewallsV2RouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallsV2RouteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.
         *
         * @param request DescribeUserAssetIPTrafficInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserAssetIPTrafficInfoResponse
         */
        public DescribeUserAssetIPTrafficInfoResponse DescribeUserAssetIPTrafficInfoWithOptions(DescribeUserAssetIPTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAssetIPTrafficInfo",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAssetIPTrafficInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.
         *
         * @param request DescribeUserAssetIPTrafficInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserAssetIPTrafficInfoResponse
         */
        public async Task<DescribeUserAssetIPTrafficInfoResponse> DescribeUserAssetIPTrafficInfoWithOptionsAsync(DescribeUserAssetIPTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAssetIPTrafficInfo",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAssetIPTrafficInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.
         *
         * @param request DescribeUserAssetIPTrafficInfoRequest
         * @return DescribeUserAssetIPTrafficInfoResponse
         */
        public DescribeUserAssetIPTrafficInfoResponse DescribeUserAssetIPTrafficInfo(DescribeUserAssetIPTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserAssetIPTrafficInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.
         *
         * @param request DescribeUserAssetIPTrafficInfoRequest
         * @return DescribeUserAssetIPTrafficInfoResponse
         */
        public async Task<DescribeUserAssetIPTrafficInfoResponse> DescribeUserAssetIPTrafficInfoAsync(DescribeUserAssetIPTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserAssetIPTrafficInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户版本信息
         *
         * @param request DescribeUserBuyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserBuyVersionResponse
         */
        public DescribeUserBuyVersionResponse DescribeUserBuyVersionWithOptions(DescribeUserBuyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeUserBuyVersion",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBuyVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户版本信息
         *
         * @param request DescribeUserBuyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserBuyVersionResponse
         */
        public async Task<DescribeUserBuyVersionResponse> DescribeUserBuyVersionWithOptionsAsync(DescribeUserBuyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeUserBuyVersion",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBuyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户版本信息
         *
         * @param request DescribeUserBuyVersionRequest
         * @return DescribeUserBuyVersionResponse
         */
        public DescribeUserBuyVersionResponse DescribeUserBuyVersion(DescribeUserBuyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBuyVersionWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户版本信息
         *
         * @param request DescribeUserBuyVersionRequest
         * @return DescribeUserBuyVersionResponse
         */
        public async Task<DescribeUserBuyVersionResponse> DescribeUserBuyVersionAsync(DescribeUserBuyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBuyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户IPS白名单
         *
         * @param request DescribeUserIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserIPSWhitelistResponse
         */
        public DescribeUserIPSWhitelistResponse DescribeUserIPSWhitelistWithOptions(DescribeUserIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserIPSWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户IPS白名单
         *
         * @param request DescribeUserIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserIPSWhitelistResponse
         */
        public async Task<DescribeUserIPSWhitelistResponse> DescribeUserIPSWhitelistWithOptionsAsync(DescribeUserIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserIPSWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户IPS白名单
         *
         * @param request DescribeUserIPSWhitelistRequest
         * @return DescribeUserIPSWhitelistResponse
         */
        public DescribeUserIPSWhitelistResponse DescribeUserIPSWhitelist(DescribeUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserIPSWhitelistWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户IPS白名单
         *
         * @param request DescribeUserIPSWhitelistRequest
         * @return DescribeUserIPSWhitelistResponse
         */
        public async Task<DescribeUserIPSWhitelistResponse> DescribeUserIPSWhitelistAsync(DescribeUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.
         *
         * @description You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallAclGroupListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallAclGroupListResponse
         */
        public DescribeVpcFirewallAclGroupListResponse DescribeVpcFirewallAclGroupListWithOptions(DescribeVpcFirewallAclGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallConfigureStatus))
            {
                query["FirewallConfigureStatus"] = request.FirewallConfigureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallAclGroupList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallAclGroupListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.
         *
         * @description You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallAclGroupListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallAclGroupListResponse
         */
        public async Task<DescribeVpcFirewallAclGroupListResponse> DescribeVpcFirewallAclGroupListWithOptionsAsync(DescribeVpcFirewallAclGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallConfigureStatus))
            {
                query["FirewallConfigureStatus"] = request.FirewallConfigureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallAclGroupList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallAclGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.
         *
         * @description You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallAclGroupListRequest
         * @return DescribeVpcFirewallAclGroupListResponse
         */
        public DescribeVpcFirewallAclGroupListResponse DescribeVpcFirewallAclGroupList(DescribeVpcFirewallAclGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallAclGroupListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.
         *
         * @description You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallAclGroupListRequest
         * @return DescribeVpcFirewallAclGroupListResponse
         */
        public async Task<DescribeVpcFirewallAclGroupListResponse> DescribeVpcFirewallAclGroupListAsync(DescribeVpcFirewallAclGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallAclGroupListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallCenDetailResponse
         */
        public DescribeVpcFirewallCenDetailResponse DescribeVpcFirewallCenDetailWithOptions(DescribeVpcFirewallCenDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallCenDetailResponse
         */
        public async Task<DescribeVpcFirewallCenDetailResponse> DescribeVpcFirewallCenDetailWithOptionsAsync(DescribeVpcFirewallCenDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenDetailRequest
         * @return DescribeVpcFirewallCenDetailResponse
         */
        public DescribeVpcFirewallCenDetailResponse DescribeVpcFirewallCenDetail(DescribeVpcFirewallCenDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallCenDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenDetailRequest
         * @return DescribeVpcFirewallCenDetailResponse
         */
        public async Task<DescribeVpcFirewallCenDetailResponse> DescribeVpcFirewallCenDetailAsync(DescribeVpcFirewallCenDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallCenDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallCenListResponse
         */
        public DescribeVpcFirewallCenListResponse DescribeVpcFirewallCenListWithOptions(DescribeVpcFirewallCenListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterType))
            {
                query["TransitRouterType"] = request.TransitRouterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallCenListResponse
         */
        public async Task<DescribeVpcFirewallCenListResponse> DescribeVpcFirewallCenListWithOptionsAsync(DescribeVpcFirewallCenListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterType))
            {
                query["TransitRouterType"] = request.TransitRouterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenListRequest
         * @return DescribeVpcFirewallCenListResponse
         */
        public DescribeVpcFirewallCenListResponse DescribeVpcFirewallCenList(DescribeVpcFirewallCenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallCenListWithOptions(request, runtime);
        }

        /**
         * @summary Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallCenListRequest
         * @return DescribeVpcFirewallCenListResponse
         */
        public async Task<DescribeVpcFirewallCenListResponse> DescribeVpcFirewallCenListAsync(DescribeVpcFirewallCenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallCenListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallControlPolicyResponse
         */
        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicyWithOptions(DescribeVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallControlPolicyResponse
         */
        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyWithOptionsAsync(DescribeVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallControlPolicyRequest
         * @return DescribeVpcFirewallControlPolicyResponse
         */
        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicy(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallControlPolicyRequest
         * @return DescribeVpcFirewallControlPolicyResponse
         */
        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyAsync(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallDefaultIPSConfigResponse
         */
        public DescribeVpcFirewallDefaultIPSConfigResponse DescribeVpcFirewallDefaultIPSConfigWithOptions(DescribeVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDefaultIPSConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallDefaultIPSConfigResponse
         */
        public async Task<DescribeVpcFirewallDefaultIPSConfigResponse> DescribeVpcFirewallDefaultIPSConfigWithOptionsAsync(DescribeVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDefaultIPSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDefaultIPSConfigRequest
         * @return DescribeVpcFirewallDefaultIPSConfigResponse
         */
        public DescribeVpcFirewallDefaultIPSConfigResponse DescribeVpcFirewallDefaultIPSConfig(DescribeVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallDefaultIPSConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDefaultIPSConfigRequest
         * @return DescribeVpcFirewallDefaultIPSConfigResponse
         */
        public async Task<DescribeVpcFirewallDefaultIPSConfigResponse> DescribeVpcFirewallDefaultIPSConfigAsync(DescribeVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.  
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure) operation.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallDetailResponse
         */
        public DescribeVpcFirewallDetailResponse DescribeVpcFirewallDetailWithOptions(DescribeVpcFirewallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.  
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure) operation.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallDetailResponse
         */
        public async Task<DescribeVpcFirewallDetailResponse> DescribeVpcFirewallDetailWithOptionsAsync(DescribeVpcFirewallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.  
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure) operation.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDetailRequest
         * @return DescribeVpcFirewallDetailResponse
         */
        public DescribeVpcFirewallDetailResponse DescribeVpcFirewallDetail(DescribeVpcFirewallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.  
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure) operation.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallDetailRequest
         * @return DescribeVpcFirewallDetailResponse
         */
        public async Task<DescribeVpcFirewallDetailResponse> DescribeVpcFirewallDetailAsync(DescribeVpcFirewallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request DescribeVpcFirewallIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallIPSWhitelistResponse
         */
        public DescribeVpcFirewallIPSWhitelistResponse DescribeVpcFirewallIPSWhitelistWithOptions(DescribeVpcFirewallIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallIPSWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request DescribeVpcFirewallIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallIPSWhitelistResponse
         */
        public async Task<DescribeVpcFirewallIPSWhitelistResponse> DescribeVpcFirewallIPSWhitelistWithOptionsAsync(DescribeVpcFirewallIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallIPSWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request DescribeVpcFirewallIPSWhitelistRequest
         * @return DescribeVpcFirewallIPSWhitelistResponse
         */
        public DescribeVpcFirewallIPSWhitelistResponse DescribeVpcFirewallIPSWhitelist(DescribeVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallIPSWhitelistWithOptions(request, runtime);
        }

        /**
         * @summary Queries the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request DescribeVpcFirewallIPSWhitelistRequest
         * @return DescribeVpcFirewallIPSWhitelistResponse
         */
        public async Task<DescribeVpcFirewallIPSWhitelistResponse> DescribeVpcFirewallIPSWhitelistAsync(DescribeVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallListResponse
         */
        public DescribeVpcFirewallListResponse DescribeVpcFirewallListWithOptions(DescribeVpcFirewallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectSubType))
            {
                query["ConnectSubType"] = request.ConnectSubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerUid))
            {
                query["PeerUid"] = request.PeerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
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
                Action = "DescribeVpcFirewallList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallListResponse
         */
        public async Task<DescribeVpcFirewallListResponse> DescribeVpcFirewallListWithOptionsAsync(DescribeVpcFirewallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectSubType))
            {
                query["ConnectSubType"] = request.ConnectSubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerUid))
            {
                query["PeerUid"] = request.PeerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
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
                Action = "DescribeVpcFirewallList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallListRequest
         * @return DescribeVpcFirewallListResponse
         */
        public DescribeVpcFirewallListResponse DescribeVpcFirewallList(DescribeVpcFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallListRequest
         * @return DescribeVpcFirewallListResponse
         */
        public async Task<DescribeVpcFirewallListResponse> DescribeVpcFirewallListAsync(DescribeVpcFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallPolicyPriorUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallPolicyPriorUsedResponse
         */
        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsedWithOptions(DescribeVpcFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallPolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallPolicyPriorUsedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallPolicyPriorUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcFirewallPolicyPriorUsedResponse
         */
        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(DescribeVpcFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallPolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallPolicyPriorUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallPolicyPriorUsedRequest
         * @return DescribeVpcFirewallPolicyPriorUsedResponse
         */
        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsed(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallPolicyPriorUsedWithOptions(request, runtime);
        }

        /**
         * @summary Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeVpcFirewallPolicyPriorUsedRequest
         * @return DescribeVpcFirewallPolicyPriorUsedResponse
         */
        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedAsync(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries virtual private clouds (VPCs).
         *
         * @param request DescribeVpcListLiteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcListLiteResponse
         */
        public DescribeVpcListLiteResponse DescribeVpcListLiteWithOptions(DescribeVpcListLiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcName))
            {
                query["VpcName"] = request.VpcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcListLite",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcListLiteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries virtual private clouds (VPCs).
         *
         * @param request DescribeVpcListLiteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcListLiteResponse
         */
        public async Task<DescribeVpcListLiteResponse> DescribeVpcListLiteWithOptionsAsync(DescribeVpcListLiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcName))
            {
                query["VpcName"] = request.VpcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcListLite",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcListLiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries virtual private clouds (VPCs).
         *
         * @param request DescribeVpcListLiteRequest
         * @return DescribeVpcListLiteResponse
         */
        public DescribeVpcListLiteResponse DescribeVpcListLite(DescribeVpcListLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcListLiteWithOptions(request, runtime);
        }

        /**
         * @summary Queries virtual private clouds (VPCs).
         *
         * @param request DescribeVpcListLiteRequest
         * @return DescribeVpcListLiteResponse
         */
        public async Task<DescribeVpcListLiteResponse> DescribeVpcListLiteAsync(DescribeVpcListLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcListLiteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries virtual private cloud (VPC) zones.
         *
         * @param request DescribeVpcZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcZoneResponse
         */
        public DescribeVpcZoneResponse DescribeVpcZoneWithOptions(DescribeVpcZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcZone",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcZoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries virtual private cloud (VPC) zones.
         *
         * @param request DescribeVpcZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVpcZoneResponse
         */
        public async Task<DescribeVpcZoneResponse> DescribeVpcZoneWithOptionsAsync(DescribeVpcZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcZone",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries virtual private cloud (VPC) zones.
         *
         * @param request DescribeVpcZoneRequest
         * @return DescribeVpcZoneResponse
         */
        public DescribeVpcZoneResponse DescribeVpcZone(DescribeVpcZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcZoneWithOptions(request, runtime);
        }

        /**
         * @summary Queries virtual private cloud (VPC) zones.
         *
         * @param request DescribeVpcZoneRequest
         * @return DescribeVpcZoneResponse
         */
        public async Task<DescribeVpcZoneResponse> DescribeVpcZoneAsync(DescribeVpcZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the vulnerabilities that are supported by Cloud Firewall.
         *
         * @param request DescribeVulnerabilityProtectedListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVulnerabilityProtectedListResponse
         */
        public DescribeVulnerabilityProtectedListResponse DescribeVulnerabilityProtectedListWithOptions(DescribeVulnerabilityProtectedListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyVersion))
            {
                query["BuyVersion"] = request.BuyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnCveName))
            {
                query["VulnCveName"] = request.VulnCveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnLevel))
            {
                query["VulnLevel"] = request.VulnLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnResource))
            {
                query["VulnResource"] = request.VulnResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnStatus))
            {
                query["VulnStatus"] = request.VulnStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnType))
            {
                query["VulnType"] = request.VulnType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVulnerabilityProtectedList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVulnerabilityProtectedListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the vulnerabilities that are supported by Cloud Firewall.
         *
         * @param request DescribeVulnerabilityProtectedListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVulnerabilityProtectedListResponse
         */
        public async Task<DescribeVulnerabilityProtectedListResponse> DescribeVulnerabilityProtectedListWithOptionsAsync(DescribeVulnerabilityProtectedListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyVersion))
            {
                query["BuyVersion"] = request.BuyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnCveName))
            {
                query["VulnCveName"] = request.VulnCveName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnLevel))
            {
                query["VulnLevel"] = request.VulnLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnResource))
            {
                query["VulnResource"] = request.VulnResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnStatus))
            {
                query["VulnStatus"] = request.VulnStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulnType))
            {
                query["VulnType"] = request.VulnType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVulnerabilityProtectedList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVulnerabilityProtectedListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the vulnerabilities that are supported by Cloud Firewall.
         *
         * @param request DescribeVulnerabilityProtectedListRequest
         * @return DescribeVulnerabilityProtectedListResponse
         */
        public DescribeVulnerabilityProtectedListResponse DescribeVulnerabilityProtectedList(DescribeVulnerabilityProtectedListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulnerabilityProtectedListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the vulnerabilities that are supported by Cloud Firewall.
         *
         * @param request DescribeVulnerabilityProtectedListRequest
         * @return DescribeVulnerabilityProtectedListResponse
         */
        public async Task<DescribeVulnerabilityProtectedListResponse> DescribeVulnerabilityProtectedListAsync(DescribeVulnerabilityProtectedListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulnerabilityProtectedListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the address book that is specified in an access control policy.
         *
         * @description You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAddressBookResponse
         */
        public ModifyAddressBookResponse ModifyAddressBookWithOptions(ModifyAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAddressBookResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the address book that is specified in an access control policy.
         *
         * @description You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyAddressBookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAddressBookResponse
         */
        public async Task<ModifyAddressBookResponse> ModifyAddressBookWithOptionsAsync(ModifyAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the address book that is specified in an access control policy.
         *
         * @description You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyAddressBookRequest
         * @return ModifyAddressBookResponse
         */
        public ModifyAddressBookResponse ModifyAddressBook(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAddressBookWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the address book that is specified in an access control policy.
         *
         * @description You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyAddressBookRequest
         * @return ModifyAddressBookResponse
         */
        public async Task<ModifyAddressBookResponse> ModifyAddressBookAsync(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAddressBookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an access control policy.
         *
         * @description You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.
         * ## [](#qps)Limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyControlPolicyResponse
         */
        public ModifyControlPolicyResponse ModifyControlPolicyWithOptions(ModifyControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "ModifyControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an access control policy.
         *
         * @description You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.
         * ## [](#qps)Limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyControlPolicyResponse
         */
        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyWithOptionsAsync(ModifyControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "ModifyControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an access control policy.
         *
         * @description You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.
         * ## [](#qps)Limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyRequest
         * @return ModifyControlPolicyResponse
         */
        public ModifyControlPolicyResponse ModifyControlPolicy(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an access control policy.
         *
         * @description You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.
         * ## [](#qps)Limit
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyRequest
         * @return ModifyControlPolicyResponse
         */
        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyAsync(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.
         *
         * @description You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyPositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyControlPolicyPositionResponse
         */
        public ModifyControlPolicyPositionResponse ModifyControlPolicyPositionWithOptions(ModifyControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyPositionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.
         *
         * @description You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyPositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyControlPolicyPositionResponse
         */
        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionWithOptionsAsync(ModifyControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyPositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.
         *
         * @description You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyPositionRequest
         * @return ModifyControlPolicyPositionResponse
         */
        public ModifyControlPolicyPositionResponse ModifyControlPolicyPosition(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyPositionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.
         *
         * @description You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.
         * ## [](#qps)Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyControlPolicyPositionRequest
         * @return ModifyControlPolicyPositionResponse
         */
        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionAsync(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the default configuration of the intrusion prevention system (IPS).
         *
         * @param request ModifyDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefaultIPSConfigResponse
         */
        public ModifyDefaultIPSConfigResponse ModifyDefaultIPSConfigWithOptions(ModifyDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicRules))
            {
                query["BasicRules"] = request.BasicRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CtiRules))
            {
                query["CtiRules"] = request.CtiRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatchRules))
            {
                query["PatchRules"] = request.PatchRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleClass))
            {
                query["RuleClass"] = request.RuleClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefaultIPSConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the default configuration of the intrusion prevention system (IPS).
         *
         * @param request ModifyDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefaultIPSConfigResponse
         */
        public async Task<ModifyDefaultIPSConfigResponse> ModifyDefaultIPSConfigWithOptionsAsync(ModifyDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicRules))
            {
                query["BasicRules"] = request.BasicRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CtiRules))
            {
                query["CtiRules"] = request.CtiRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatchRules))
            {
                query["PatchRules"] = request.PatchRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleClass))
            {
                query["RuleClass"] = request.RuleClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefaultIPSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the default configuration of the intrusion prevention system (IPS).
         *
         * @param request ModifyDefaultIPSConfigRequest
         * @return ModifyDefaultIPSConfigResponse
         */
        public ModifyDefaultIPSConfigResponse ModifyDefaultIPSConfig(ModifyDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefaultIPSConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the default configuration of the intrusion prevention system (IPS).
         *
         * @param request ModifyDefaultIPSConfigRequest
         * @return ModifyDefaultIPSConfigResponse
         */
        public async Task<ModifyDefaultIPSConfigResponse> ModifyDefaultIPSConfigAsync(ModifyDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the status of a routing policy.
         *
         * @param request ModifyFirewallV2RoutePolicySwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFirewallV2RoutePolicySwitchResponse
         */
        public ModifyFirewallV2RoutePolicySwitchResponse ModifyFirewallV2RoutePolicySwitchWithOptions(ModifyFirewallV2RoutePolicySwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldRecover))
            {
                query["ShouldRecover"] = request.ShouldRecover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicySwitchStatus))
            {
                query["TrFirewallRoutePolicySwitchStatus"] = request.TrFirewallRoutePolicySwitchStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFirewallV2RoutePolicySwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFirewallV2RoutePolicySwitchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the status of a routing policy.
         *
         * @param request ModifyFirewallV2RoutePolicySwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFirewallV2RoutePolicySwitchResponse
         */
        public async Task<ModifyFirewallV2RoutePolicySwitchResponse> ModifyFirewallV2RoutePolicySwitchWithOptionsAsync(ModifyFirewallV2RoutePolicySwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldRecover))
            {
                query["ShouldRecover"] = request.ShouldRecover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicySwitchStatus))
            {
                query["TrFirewallRoutePolicySwitchStatus"] = request.TrFirewallRoutePolicySwitchStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFirewallV2RoutePolicySwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFirewallV2RoutePolicySwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the status of a routing policy.
         *
         * @param request ModifyFirewallV2RoutePolicySwitchRequest
         * @return ModifyFirewallV2RoutePolicySwitchResponse
         */
        public ModifyFirewallV2RoutePolicySwitchResponse ModifyFirewallV2RoutePolicySwitch(ModifyFirewallV2RoutePolicySwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFirewallV2RoutePolicySwitchWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the status of a routing policy.
         *
         * @param request ModifyFirewallV2RoutePolicySwitchRequest
         * @return ModifyFirewallV2RoutePolicySwitchResponse
         */
        public async Task<ModifyFirewallV2RoutePolicySwitchResponse> ModifyFirewallV2RoutePolicySwitchAsync(ModifyFirewallV2RoutePolicySwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFirewallV2RoutePolicySwitchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the information about members in Cloud Firewall.
         *
         * @description You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyInstanceMemberAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceMemberAttributesResponse
         */
        public ModifyInstanceMemberAttributesResponse ModifyInstanceMemberAttributesWithOptions(ModifyInstanceMemberAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceMemberAttributes",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceMemberAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the information about members in Cloud Firewall.
         *
         * @description You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyInstanceMemberAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceMemberAttributesResponse
         */
        public async Task<ModifyInstanceMemberAttributesResponse> ModifyInstanceMemberAttributesWithOptionsAsync(ModifyInstanceMemberAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceMemberAttributes",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceMemberAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the information about members in Cloud Firewall.
         *
         * @description You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyInstanceMemberAttributesRequest
         * @return ModifyInstanceMemberAttributesResponse
         */
        public ModifyInstanceMemberAttributesResponse ModifyInstanceMemberAttributes(ModifyInstanceMemberAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMemberAttributesWithOptions(request, runtime);
        }

        /**
         * @summary Updates the information about members in Cloud Firewall.
         *
         * @description You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyInstanceMemberAttributesRequest
         * @return ModifyInstanceMemberAttributesResponse
         */
        public async Task<ModifyInstanceMemberAttributesResponse> ModifyInstanceMemberAttributesAsync(ModifyInstanceMemberAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMemberAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNatFirewallControlPolicyResponse
         */
        public ModifyNatFirewallControlPolicyResponse ModifyNatFirewallControlPolicyWithOptions(ModifyNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "ModifyNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNatFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNatFirewallControlPolicyResponse
         */
        public async Task<ModifyNatFirewallControlPolicyResponse> ModifyNatFirewallControlPolicyWithOptionsAsync(ModifyNatFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "ModifyNatFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNatFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyRequest
         * @return ModifyNatFirewallControlPolicyResponse
         */
        public ModifyNatFirewallControlPolicyResponse ModifyNatFirewallControlPolicy(ModifyNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a NAT firewall.
         *
         * @description You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyRequest
         * @return ModifyNatFirewallControlPolicyResponse
         */
        public async Task<ModifyNatFirewallControlPolicyResponse> ModifyNatFirewallControlPolicyAsync(ModifyNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyPositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNatFirewallControlPolicyPositionResponse
         */
        public ModifyNatFirewallControlPolicyPositionResponse ModifyNatFirewallControlPolicyPositionWithOptions(ModifyNatFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNatFirewallControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNatFirewallControlPolicyPositionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyPositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNatFirewallControlPolicyPositionResponse
         */
        public async Task<ModifyNatFirewallControlPolicyPositionResponse> ModifyNatFirewallControlPolicyPositionWithOptionsAsync(ModifyNatFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNatFirewallControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNatFirewallControlPolicyPositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyPositionRequest
         * @return ModifyNatFirewallControlPolicyPositionResponse
         */
        public ModifyNatFirewallControlPolicyPositionResponse ModifyNatFirewallControlPolicyPosition(ModifyNatFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNatFirewallControlPolicyPositionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a NAT firewall.
         *
         * @param request ModifyNatFirewallControlPolicyPositionRequest
         * @return ModifyNatFirewallControlPolicyPositionResponse
         */
        public async Task<ModifyNatFirewallControlPolicyPositionResponse> ModifyNatFirewallControlPolicyPositionAsync(ModifyNatFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNatFirewallControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies information about an operation on an object group.
         *
         * @param request ModifyObjectGroupOperationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyObjectGroupOperationResponse
         */
        public ModifyObjectGroupOperationResponse ModifyObjectGroupOperationWithOptions(ModifyObjectGroupOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectList))
            {
                query["ObjectList"] = request.ObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectOperation))
            {
                query["ObjectOperation"] = request.ObjectOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyObjectGroupOperation",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyObjectGroupOperationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies information about an operation on an object group.
         *
         * @param request ModifyObjectGroupOperationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyObjectGroupOperationResponse
         */
        public async Task<ModifyObjectGroupOperationResponse> ModifyObjectGroupOperationWithOptionsAsync(ModifyObjectGroupOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectList))
            {
                query["ObjectList"] = request.ObjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectOperation))
            {
                query["ObjectOperation"] = request.ObjectOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyObjectGroupOperation",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyObjectGroupOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies information about an operation on an object group.
         *
         * @param request ModifyObjectGroupOperationRequest
         * @return ModifyObjectGroupOperationResponse
         */
        public ModifyObjectGroupOperationResponse ModifyObjectGroupOperation(ModifyObjectGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyObjectGroupOperationWithOptions(request, runtime);
        }

        /**
         * @summary Modifies information about an operation on an object group.
         *
         * @param request ModifyObjectGroupOperationRequest
         * @return ModifyObjectGroupOperationResponse
         */
        public async Task<ModifyObjectGroupOperationResponse> ModifyObjectGroupOperationAsync(ModifyObjectGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyObjectGroupOperationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the strict mode for an access control policy.
         *
         * @description You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyPolicyAdvancedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPolicyAdvancedConfigResponse
         */
        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfigWithOptions(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSwitch))
            {
                query["InternetSwitch"] = request.InternetSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyAdvancedConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the strict mode for an access control policy.
         *
         * @description You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyPolicyAdvancedConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPolicyAdvancedConfigResponse
         */
        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigWithOptionsAsync(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSwitch))
            {
                query["InternetSwitch"] = request.InternetSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyAdvancedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the strict mode for an access control policy.
         *
         * @description You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyPolicyAdvancedConfigRequest
         * @return ModifyPolicyAdvancedConfigResponse
         */
        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfig(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyAdvancedConfigWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the strict mode for an access control policy.
         *
         * @description You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyPolicyAdvancedConfigRequest
         * @return ModifyPolicyAdvancedConfigResponse
         */
        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigAsync(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request ModifyTrFirewallV2ConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTrFirewallV2ConfigurationResponse
         */
        public ModifyTrFirewallV2ConfigurationResponse ModifyTrFirewallV2ConfigurationWithOptions(ModifyTrFirewallV2ConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallName))
            {
                query["FirewallName"] = request.FirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTrFirewallV2Configuration",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTrFirewallV2ConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request ModifyTrFirewallV2ConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTrFirewallV2ConfigurationResponse
         */
        public async Task<ModifyTrFirewallV2ConfigurationResponse> ModifyTrFirewallV2ConfigurationWithOptionsAsync(ModifyTrFirewallV2ConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallName))
            {
                query["FirewallName"] = request.FirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTrFirewallV2Configuration",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTrFirewallV2ConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request ModifyTrFirewallV2ConfigurationRequest
         * @return ModifyTrFirewallV2ConfigurationResponse
         */
        public ModifyTrFirewallV2ConfigurationResponse ModifyTrFirewallV2Configuration(ModifyTrFirewallV2ConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTrFirewallV2ConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.
         *
         * @param request ModifyTrFirewallV2ConfigurationRequest
         * @return ModifyTrFirewallV2ConfigurationResponse
         */
        public async Task<ModifyTrFirewallV2ConfigurationResponse> ModifyTrFirewallV2ConfigurationAsync(ModifyTrFirewallV2ConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTrFirewallV2ConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.
         *
         * @param tmpReq ModifyTrFirewallV2RoutePolicyScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTrFirewallV2RoutePolicyScopeResponse
         */
        public ModifyTrFirewallV2RoutePolicyScopeResponse ModifyTrFirewallV2RoutePolicyScopeWithOptions(ModifyTrFirewallV2RoutePolicyScopeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyTrFirewallV2RoutePolicyScopeShrinkRequest request = new ModifyTrFirewallV2RoutePolicyScopeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestCandidateList))
            {
                request.DestCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestCandidateList, "DestCandidateList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SrcCandidateList))
            {
                request.SrcCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SrcCandidateList, "SrcCandidateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestCandidateListShrink))
            {
                query["DestCandidateList"] = request.DestCandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldRecover))
            {
                query["ShouldRecover"] = request.ShouldRecover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcCandidateListShrink))
            {
                query["SrcCandidateList"] = request.SrcCandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTrFirewallV2RoutePolicyScope",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTrFirewallV2RoutePolicyScopeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.
         *
         * @param tmpReq ModifyTrFirewallV2RoutePolicyScopeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTrFirewallV2RoutePolicyScopeResponse
         */
        public async Task<ModifyTrFirewallV2RoutePolicyScopeResponse> ModifyTrFirewallV2RoutePolicyScopeWithOptionsAsync(ModifyTrFirewallV2RoutePolicyScopeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyTrFirewallV2RoutePolicyScopeShrinkRequest request = new ModifyTrFirewallV2RoutePolicyScopeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestCandidateList))
            {
                request.DestCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestCandidateList, "DestCandidateList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SrcCandidateList))
            {
                request.SrcCandidateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SrcCandidateList, "SrcCandidateList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestCandidateListShrink))
            {
                query["DestCandidateList"] = request.DestCandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallId))
            {
                query["FirewallId"] = request.FirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldRecover))
            {
                query["ShouldRecover"] = request.ShouldRecover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcCandidateListShrink))
            {
                query["SrcCandidateList"] = request.SrcCandidateListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrFirewallRoutePolicyId))
            {
                query["TrFirewallRoutePolicyId"] = request.TrFirewallRoutePolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTrFirewallV2RoutePolicyScope",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTrFirewallV2RoutePolicyScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.
         *
         * @param request ModifyTrFirewallV2RoutePolicyScopeRequest
         * @return ModifyTrFirewallV2RoutePolicyScopeResponse
         */
        public ModifyTrFirewallV2RoutePolicyScopeResponse ModifyTrFirewallV2RoutePolicyScope(ModifyTrFirewallV2RoutePolicyScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTrFirewallV2RoutePolicyScopeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.
         *
         * @param request ModifyTrFirewallV2RoutePolicyScopeRequest
         * @return ModifyTrFirewallV2RoutePolicyScopeResponse
         */
        public async Task<ModifyTrFirewallV2RoutePolicyScopeResponse> ModifyTrFirewallV2RoutePolicyScopeAsync(ModifyTrFirewallV2RoutePolicyScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTrFirewallV2RoutePolicyScopeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改用户IPS白名单
         *
         * @param request ModifyUserIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUserIPSWhitelistResponse
         */
        public ModifyUserIPSWhitelistResponse ModifyUserIPSWhitelistWithOptions(ModifyUserIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListType))
            {
                query["ListType"] = request.ListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListValue))
            {
                query["ListValue"] = request.ListValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                query["WhiteType"] = request.WhiteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserIPSWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改用户IPS白名单
         *
         * @param request ModifyUserIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUserIPSWhitelistResponse
         */
        public async Task<ModifyUserIPSWhitelistResponse> ModifyUserIPSWhitelistWithOptionsAsync(ModifyUserIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListType))
            {
                query["ListType"] = request.ListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListValue))
            {
                query["ListValue"] = request.ListValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                query["WhiteType"] = request.WhiteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserIPSWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改用户IPS白名单
         *
         * @param request ModifyUserIPSWhitelistRequest
         * @return ModifyUserIPSWhitelistResponse
         */
        public ModifyUserIPSWhitelistResponse ModifyUserIPSWhitelist(ModifyUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserIPSWhitelistWithOptions(request, runtime);
        }

        /**
         * @summary 修改用户IPS白名单
         *
         * @param request ModifyUserIPSWhitelistRequest
         * @return ModifyUserIPSWhitelistResponse
         */
        public async Task<ModifyUserIPSWhitelistResponse> ModifyUserIPSWhitelistAsync(ModifyUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallCenConfigureResponse
         */
        public ModifyVpcFirewallCenConfigureResponse ModifyVpcFirewallCenConfigureWithOptions(ModifyVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenConfigureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallCenConfigureResponse
         */
        public async Task<ModifyVpcFirewallCenConfigureResponse> ModifyVpcFirewallCenConfigureWithOptionsAsync(ModifyVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenConfigureRequest
         * @return ModifyVpcFirewallCenConfigureResponse
         */
        public ModifyVpcFirewallCenConfigureResponse ModifyVpcFirewallCenConfigure(ModifyVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenConfigureRequest
         * @return ModifyVpcFirewallCenConfigureResponse
         */
        public async Task<ModifyVpcFirewallCenConfigureResponse> ModifyVpcFirewallCenConfigureAsync(ModifyVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
         * Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenSwitchStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallCenSwitchStatusResponse
         */
        public ModifyVpcFirewallCenSwitchStatusResponse ModifyVpcFirewallCenSwitchStatusWithOptions(ModifyVpcFirewallCenSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenSwitchStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
         * Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenSwitchStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallCenSwitchStatusResponse
         */
        public async Task<ModifyVpcFirewallCenSwitchStatusResponse> ModifyVpcFirewallCenSwitchStatusWithOptionsAsync(ModifyVpcFirewallCenSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenSwitchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
         * Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenSwitchStatusRequest
         * @return ModifyVpcFirewallCenSwitchStatusResponse
         */
        public ModifyVpcFirewallCenSwitchStatusResponse ModifyVpcFirewallCenSwitchStatus(ModifyVpcFirewallCenSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallCenSwitchStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.
         *
         * @description You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
         * Before you call this operation, make sure that you have created a VPC firewall by calling the [CreateVpcFirewallCenConfigure](https://help.aliyun.com/document_detail/345772.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallCenSwitchStatusRequest
         * @return ModifyVpcFirewallCenSwitchStatusResponse
         */
        public async Task<ModifyVpcFirewallCenSwitchStatusResponse> ModifyVpcFirewallCenSwitchStatusAsync(ModifyVpcFirewallCenSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallCenSwitchStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallConfigureResponse
         */
        public ModifyVpcFirewallConfigureResponse ModifyVpcFirewallConfigureWithOptions(ModifyVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallConfigureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallConfigureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallConfigureResponse
         */
        public async Task<ModifyVpcFirewallConfigureResponse> ModifyVpcFirewallConfigureWithOptionsAsync(ModifyVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallConfigureRequest
         * @return ModifyVpcFirewallConfigureResponse
         */
        public ModifyVpcFirewallConfigureResponse ModifyVpcFirewallConfigure(ModifyVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallConfigureWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallConfigureRequest
         * @return ModifyVpcFirewallConfigureResponse
         */
        public async Task<ModifyVpcFirewallConfigureResponse> ModifyVpcFirewallConfigureAsync(ModifyVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.
         *
         * @description You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallControlPolicyResponse
         */
        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicyWithOptions(ModifyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.
         *
         * @description You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallControlPolicyResponse
         */
        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyWithOptionsAsync(ModifyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainResolveType))
            {
                query["DomainResolveType"] = request.DomainResolveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatDays))
            {
                query["RepeatDays"] = request.RepeatDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatEndTime))
            {
                query["RepeatEndTime"] = request.RepeatEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatStartTime))
            {
                query["RepeatStartTime"] = request.RepeatStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.
         *
         * @description You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyRequest
         * @return ModifyVpcFirewallControlPolicyResponse
         */
        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicy(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.
         *
         * @description You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyRequest
         * @return ModifyVpcFirewallControlPolicyResponse
         */
        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyAsync(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyPositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallControlPolicyPositionResponse
         */
        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPositionWithOptions(ModifyVpcFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyPositionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyPositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallControlPolicyPositionResponse
         */
        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(ModifyVpcFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyPositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyPositionRequest
         * @return ModifyVpcFirewallControlPolicyPositionResponse
         */
        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPosition(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyPositionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallControlPolicyPositionRequest
         * @return ModifyVpcFirewallControlPolicyPositionResponse
         */
        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionAsync(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call this operation to modify the intrusion prevention configurations of a VPC firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallDefaultIPSConfigResponse
         */
        public ModifyVpcFirewallDefaultIPSConfigResponse ModifyVpcFirewallDefaultIPSConfigWithOptions(ModifyVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicRules))
            {
                query["BasicRules"] = request.BasicRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAllPatch))
            {
                query["EnableAllPatch"] = request.EnableAllPatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleClass))
            {
                query["RuleClass"] = request.RuleClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallDefaultIPSConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call this operation to modify the intrusion prevention configurations of a VPC firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallDefaultIPSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallDefaultIPSConfigResponse
         */
        public async Task<ModifyVpcFirewallDefaultIPSConfigResponse> ModifyVpcFirewallDefaultIPSConfigWithOptionsAsync(ModifyVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicRules))
            {
                query["BasicRules"] = request.BasicRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAllPatch))
            {
                query["EnableAllPatch"] = request.EnableAllPatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleClass))
            {
                query["RuleClass"] = request.RuleClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallDefaultIPSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call this operation to modify the intrusion prevention configurations of a VPC firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallDefaultIPSConfigRequest
         * @return ModifyVpcFirewallDefaultIPSConfigResponse
         */
        public ModifyVpcFirewallDefaultIPSConfigResponse ModifyVpcFirewallDefaultIPSConfig(ModifyVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallDefaultIPSConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.
         *
         * @description You can call this operation to modify the intrusion prevention configurations of a VPC firewall.
         * ## [](#qps-)Limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallDefaultIPSConfigRequest
         * @return ModifyVpcFirewallDefaultIPSConfigResponse
         */
        public async Task<ModifyVpcFirewallDefaultIPSConfigResponse> ModifyVpcFirewallDefaultIPSConfigAsync(ModifyVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request ModifyVpcFirewallIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallIPSWhitelistResponse
         */
        public ModifyVpcFirewallIPSWhitelistResponse ModifyVpcFirewallIPSWhitelistWithOptions(ModifyVpcFirewallIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListType))
            {
                query["ListType"] = request.ListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListValue))
            {
                query["ListValue"] = request.ListValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                query["WhiteType"] = request.WhiteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallIPSWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request ModifyVpcFirewallIPSWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallIPSWhitelistResponse
         */
        public async Task<ModifyVpcFirewallIPSWhitelistResponse> ModifyVpcFirewallIPSWhitelistWithOptionsAsync(ModifyVpcFirewallIPSWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListType))
            {
                query["ListType"] = request.ListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListValue))
            {
                query["ListValue"] = request.ListValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                query["WhiteType"] = request.WhiteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallIPSWhitelist",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallIPSWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request ModifyVpcFirewallIPSWhitelistRequest
         * @return ModifyVpcFirewallIPSWhitelistResponse
         */
        public ModifyVpcFirewallIPSWhitelistResponse ModifyVpcFirewallIPSWhitelist(ModifyVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallIPSWhitelistWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.
         *
         * @param request ModifyVpcFirewallIPSWhitelistRequest
         * @return ModifyVpcFirewallIPSWhitelistResponse
         */
        public async Task<ModifyVpcFirewallIPSWhitelistResponse> ModifyVpcFirewallIPSWhitelistAsync(ModifyVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallSwitchStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallSwitchStatusResponse
         */
        public ModifyVpcFirewallSwitchStatusResponse ModifyVpcFirewallSwitchStatusWithOptions(ModifyVpcFirewallSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallSwitchStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallSwitchStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyVpcFirewallSwitchStatusResponse
         */
        public async Task<ModifyVpcFirewallSwitchStatusResponse> ModifyVpcFirewallSwitchStatusWithOptionsAsync(ModifyVpcFirewallSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallSwitchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallSwitchStatusRequest
         * @return ModifyVpcFirewallSwitchStatusResponse
         */
        public ModifyVpcFirewallSwitchStatusResponse ModifyVpcFirewallSwitchStatus(ModifyVpcFirewallSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallSwitchStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.
         *
         * @description You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
         * Before you call the operation, make sure that you created a VPC firewall by calling the [CreateVpcFirewallConfigure](https://help.aliyun.com/document_detail/342893.html) operation.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyVpcFirewallSwitchStatusRequest
         * @return ModifyVpcFirewallSwitchStatusResponse
         */
        public async Task<ModifyVpcFirewallSwitchStatusResponse> ModifyVpcFirewallSwitchStatusAsync(ModifyVpcFirewallSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallSwitchStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Turns off all firewall switches.
         *
         * @description You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.
         * ## [](#qps-)QPS limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableAllFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutDisableAllFwSwitchResponse
         */
        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitchWithOptions(PutDisableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableAllFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Turns off all firewall switches.
         *
         * @description You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.
         * ## [](#qps-)QPS limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableAllFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutDisableAllFwSwitchResponse
         */
        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchWithOptionsAsync(PutDisableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableAllFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Turns off all firewall switches.
         *
         * @description You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.
         * ## [](#qps-)QPS limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableAllFwSwitchRequest
         * @return PutDisableAllFwSwitchResponse
         */
        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitch(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableAllFwSwitchWithOptions(request, runtime);
        }

        /**
         * @summary Turns off all firewall switches.
         *
         * @description You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.
         * ## [](#qps-)QPS limits
         * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableAllFwSwitchRequest
         * @return PutDisableAllFwSwitchResponse
         */
        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchAsync(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disable a firewall for specific assets.
         *
         * @description You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutDisableFwSwitchResponse
         */
        public PutDisableFwSwitchResponse PutDisableFwSwitchWithOptions(PutDisableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disable a firewall for specific assets.
         *
         * @description You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutDisableFwSwitchResponse
         */
        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchWithOptionsAsync(PutDisableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disable a firewall for specific assets.
         *
         * @description You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableFwSwitchRequest
         * @return PutDisableFwSwitchResponse
         */
        public PutDisableFwSwitchResponse PutDisableFwSwitch(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableFwSwitchWithOptions(request, runtime);
        }

        /**
         * @summary Disable a firewall for specific assets.
         *
         * @description You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutDisableFwSwitchRequest
         * @return PutDisableFwSwitchResponse
         */
        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchAsync(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableFwSwitchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a firewall for all public IP addresses within your Alibaba Cloud account.
         *
         * @description You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutEnableAllFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutEnableAllFwSwitchResponse
         */
        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitchWithOptions(PutEnableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableAllFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables a firewall for all public IP addresses within your Alibaba Cloud account.
         *
         * @description You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutEnableAllFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutEnableAllFwSwitchResponse
         */
        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchWithOptionsAsync(PutEnableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableAllFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables a firewall for all public IP addresses within your Alibaba Cloud account.
         *
         * @description You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutEnableAllFwSwitchRequest
         * @return PutEnableAllFwSwitchResponse
         */
        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitch(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableAllFwSwitchWithOptions(request, runtime);
        }

        /**
         * @summary Enables a firewall for all public IP addresses within your Alibaba Cloud account.
         *
         * @description You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PutEnableAllFwSwitchRequest
         * @return PutEnableAllFwSwitchResponse
         */
        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchAsync(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables firewalls for specific assets.
         *
         * @description You can call the PutEnableFwSwitch operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.
         * ## Limits
         * You can call this operation up to 5 times per second per account. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
         *
         * @param request PutEnableFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutEnableFwSwitchResponse
         */
        public PutEnableFwSwitchResponse PutEnableFwSwitchWithOptions(PutEnableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables firewalls for specific assets.
         *
         * @description You can call the PutEnableFwSwitch operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.
         * ## Limits
         * You can call this operation up to 5 times per second per account. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
         *
         * @param request PutEnableFwSwitchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutEnableFwSwitchResponse
         */
        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchWithOptionsAsync(PutEnableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables firewalls for specific assets.
         *
         * @description You can call the PutEnableFwSwitch operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.
         * ## Limits
         * You can call this operation up to 5 times per second per account. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
         *
         * @param request PutEnableFwSwitchRequest
         * @return PutEnableFwSwitchResponse
         */
        public PutEnableFwSwitchResponse PutEnableFwSwitch(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableFwSwitchWithOptions(request, runtime);
        }

        /**
         * @summary Enables firewalls for specific assets.
         *
         * @description You can call the PutEnableFwSwitch operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.
         * ## Limits
         * You can call this operation up to 5 times per second per account. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
         *
         * @param request PutEnableFwSwitchRequest
         * @return PutEnableFwSwitchResponse
         */
        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchAsync(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableFwSwitchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases Cloud Firewall that uses the pay-as-you-go billing method.
         *
         * @param request ReleasePostInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleasePostInstanceResponse
         */
        public ReleasePostInstanceResponse ReleasePostInstanceWithOptions(ReleasePostInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ReleasePostInstance",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleasePostInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases Cloud Firewall that uses the pay-as-you-go billing method.
         *
         * @param request ReleasePostInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleasePostInstanceResponse
         */
        public async Task<ReleasePostInstanceResponse> ReleasePostInstanceWithOptionsAsync(ReleasePostInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ReleasePostInstance",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleasePostInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases Cloud Firewall that uses the pay-as-you-go billing method.
         *
         * @param request ReleasePostInstanceRequest
         * @return ReleasePostInstanceResponse
         */
        public ReleasePostInstanceResponse ReleasePostInstance(ReleasePostInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePostInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Releases Cloud Firewall that uses the pay-as-you-go billing method.
         *
         * @param request ReleasePostInstanceRequest
         * @return ReleasePostInstanceResponse
         */
        public async Task<ReleasePostInstanceResponse> ReleasePostInstanceAsync(ReleasePostInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePostInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resets the number of NAT firewall hits.
         *
         * @param request ResetNatFirewallRuleHitCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetNatFirewallRuleHitCountResponse
         */
        public ResetNatFirewallRuleHitCountResponse ResetNatFirewallRuleHitCountWithOptions(ResetNatFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetNatFirewallRuleHitCount",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetNatFirewallRuleHitCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Resets the number of NAT firewall hits.
         *
         * @param request ResetNatFirewallRuleHitCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetNatFirewallRuleHitCountResponse
         */
        public async Task<ResetNatFirewallRuleHitCountResponse> ResetNatFirewallRuleHitCountWithOptionsAsync(ResetNatFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetNatFirewallRuleHitCount",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetNatFirewallRuleHitCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Resets the number of NAT firewall hits.
         *
         * @param request ResetNatFirewallRuleHitCountRequest
         * @return ResetNatFirewallRuleHitCountResponse
         */
        public ResetNatFirewallRuleHitCountResponse ResetNatFirewallRuleHitCount(ResetNatFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetNatFirewallRuleHitCountWithOptions(request, runtime);
        }

        /**
         * @summary Resets the number of NAT firewall hits.
         *
         * @param request ResetNatFirewallRuleHitCountRequest
         * @return ResetNatFirewallRuleHitCountResponse
         */
        public async Task<ResetNatFirewallRuleHitCountResponse> ResetNatFirewallRuleHitCountAsync(ResetNatFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetNatFirewallRuleHitCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ResetVpcFirewallRuleHitCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetVpcFirewallRuleHitCountResponse
         */
        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCountWithOptions(ResetVpcFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetVpcFirewallRuleHitCount",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetVpcFirewallRuleHitCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ResetVpcFirewallRuleHitCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetVpcFirewallRuleHitCountResponse
         */
        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountWithOptionsAsync(ResetVpcFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetVpcFirewallRuleHitCount",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetVpcFirewallRuleHitCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ResetVpcFirewallRuleHitCountRequest
         * @return ResetVpcFirewallRuleHitCountResponse
         */
        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCount(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetVpcFirewallRuleHitCountWithOptions(request, runtime);
        }

        /**
         * @summary Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.
         *
         * @description You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ResetVpcFirewallRuleHitCountRequest
         * @return ResetVpcFirewallRuleHitCountResponse
         */
        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountAsync(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetVpcFirewallRuleHitCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables a NAT firewall.
         *
         * @param request SwitchSecurityProxyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchSecurityProxyResponse
         */
        public SwitchSecurityProxyResponse SwitchSecurityProxyWithOptions(SwitchSecurityProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyId))
            {
                query["ProxyId"] = request.ProxyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Switch))
            {
                query["Switch"] = request.Switch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchSecurityProxy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchSecurityProxyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a NAT firewall.
         *
         * @param request SwitchSecurityProxyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchSecurityProxyResponse
         */
        public async Task<SwitchSecurityProxyResponse> SwitchSecurityProxyWithOptionsAsync(SwitchSecurityProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyId))
            {
                query["ProxyId"] = request.ProxyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Switch))
            {
                query["Switch"] = request.Switch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchSecurityProxy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchSecurityProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a NAT firewall.
         *
         * @param request SwitchSecurityProxyRequest
         * @return SwitchSecurityProxyResponse
         */
        public SwitchSecurityProxyResponse SwitchSecurityProxy(SwitchSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchSecurityProxyWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables a NAT firewall.
         *
         * @param request SwitchSecurityProxyRequest
         * @return SwitchSecurityProxyResponse
         */
        public async Task<SwitchSecurityProxyResponse> SwitchSecurityProxyAsync(SwitchSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchSecurityProxyWithOptionsAsync(request, runtime);
        }

    }
}
