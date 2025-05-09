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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAddressBookResponse
        /// </returns>
        public AddAddressBookResponse AddAddressBook(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAddressBookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an address book for access control. Supported address book types are IP address books, Elastic Compute Service (ECS) tag-based address books, port address books, and domain address books. An ECS tag-based address book includes the public IP addresses of the ECS instances that have specific tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddAddressBook operation to create an address book for access control. The address book can be an IP address book, an ECS tag-based address book, a port address book, or a domain address book.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAddressBookResponse
        /// </returns>
        public async Task<AddAddressBookResponse> AddAddressBookAsync(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAddressBookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// AddControlPolicyResponse
        /// </returns>
        public AddControlPolicyResponse AddControlPolicy(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the AddControlPolicy operation to create an access control policy to allow, block, or monitor traffic that reaches Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// AddControlPolicyResponse
        /// </returns>
        public async Task<AddControlPolicyResponse> AddControlPolicyAsync(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to add members to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddInstanceMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to add members to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddInstanceMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to add members to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddInstanceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceMembersResponse
        /// </returns>
        public AddInstanceMembersResponse AddInstanceMembers(AddInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddInstanceMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to add members to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddInstanceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceMembersResponse
        /// </returns>
        public async Task<AddInstanceMembersResponse> AddInstanceMembersAsync(AddInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddInstanceMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.<br>Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy">Back up an access control policy</a>.<br>After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.<br>The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCopyVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCopyVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.<br>Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy">Back up an access control policy</a>.<br>After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.<br>The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCopyVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCopyVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.<br>Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy">Back up an access control policy</a>.<br>After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.<br>The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCopyVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCopyVpcFirewallControlPolicyResponse
        /// </returns>
        public BatchCopyVpcFirewallControlPolicyResponse BatchCopyVpcFirewallControlPolicy(BatchCopyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCopyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies all access control policies from a policy group of a source virtual private cloud (VPC) firewall to a policy group of a destination VPC firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the BatchCopyVpcFirewallControlPolicy operation to copy all access control policies from a policy group of a source VPC firewall to a policy group of a destination VPC firewall.<br>Before you call this operation, we recommend that you back up access control policies. For more information about how to back up an access control policy, see <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/back-up-and-roll-back-an-access-control-policy">Back up an access control policy</a>.<br>After you call this operation, all the access control policies in the policy group of the destination VPC firewall are replaced.<br>The policy groups of the source VPC firewall and the destination VPC firewall must belong to the same Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. When the number of calls to this operation per second exceeds the limit, throttling is triggered. Throttling may affect your business. We recommend that you take note of the limit on this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchCopyVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCopyVpcFirewallControlPolicyResponse
        /// </returns>
        public async Task<BatchCopyVpcFirewallControlPolicyResponse> BatchCopyVpcFirewallControlPolicyAsync(BatchCopyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCopyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteVpcFirewallControlPolicyResponse
        /// </returns>
        public BatchDeleteVpcFirewallControlPolicyResponse BatchDeleteVpcFirewallControlPolicy(BatchDeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple access control policies for a virtual private cloud (VPC) firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteVpcFirewallControlPolicyResponse
        /// </returns>
        public async Task<BatchDeleteVpcFirewallControlPolicyResponse> BatchDeleteVpcFirewallControlPolicyAsync(BatchDeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadTaskResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadTaskResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadTaskResponse
        /// </returns>
        public CreateDownloadTaskResponse CreateDownloadTask(CreateDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a file download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadTaskResponse
        /// </returns>
        public async Task<CreateDownloadTaskResponse> CreateDownloadTaskAsync(CreateDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNatFirewallControlPolicyResponse
        /// </returns>
        public CreateNatFirewallControlPolicyResponse CreateNatFirewallControlPolicy(CreateNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a policy that allows, denies, or monitors the traffic that passes through the NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNatFirewallControlPolicyResponse
        /// </returns>
        public async Task<CreateNatFirewallControlPolicyResponse> CreateNatFirewallControlPolicyAsync(CreateNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityProxyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityProxyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityProxyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityProxyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityProxyResponse
        /// </returns>
        public CreateSecurityProxyResponse CreateSecurityProxy(CreateSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityProxyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityProxyResponse
        /// </returns>
        public async Task<CreateSecurityProxyResponse> CreateSecurityProxyAsync(CreateSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityProxyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云防火墙SLS日志投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSlsLogDispatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSlsLogDispatchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云防火墙SLS日志投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSlsLogDispatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSlsLogDispatchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云防火墙SLS日志投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSlsLogDispatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSlsLogDispatchResponse
        /// </returns>
        public CreateSlsLogDispatchResponse CreateSlsLogDispatch(CreateSlsLogDispatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSlsLogDispatchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云防火墙SLS日志投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSlsLogDispatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSlsLogDispatchResponse
        /// </returns>
        public async Task<CreateSlsLogDispatchResponse> CreateSlsLogDispatchAsync(CreateSlsLogDispatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSlsLogDispatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrFirewallV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrFirewallV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrFirewallV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2Response
        /// </returns>
        public CreateTrFirewallV2Response CreateTrFirewallV2(CreateTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrFirewallV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrFirewallV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2Response
        /// </returns>
        public async Task<CreateTrFirewallV2Response> CreateTrFirewallV2Async(CreateTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrFirewallV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing policy for a VPC firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTrFirewallV2RoutePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2RoutePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing policy for a VPC firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTrFirewallV2RoutePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2RoutePolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing policy for a VPC firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrFirewallV2RoutePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2RoutePolicyResponse
        /// </returns>
        public CreateTrFirewallV2RoutePolicyResponse CreateTrFirewallV2RoutePolicy(CreateTrFirewallV2RoutePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrFirewallV2RoutePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing policy for a VPC firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrFirewallV2RoutePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrFirewallV2RoutePolicyResponse
        /// </returns>
        public async Task<CreateTrFirewallV2RoutePolicyResponse> CreateTrFirewallV2RoutePolicyAsync(CreateTrFirewallV2RoutePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrFirewallV2RoutePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallCenConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallCenConfigureResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcStandbyZoneId))
            {
                query["FirewallVpcStandbyZoneId"] = request.FirewallVpcStandbyZoneId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallCenConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallCenConfigureResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallVpcStandbyZoneId))
            {
                query["FirewallVpcStandbyZoneId"] = request.FirewallVpcStandbyZoneId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallCenConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallCenConfigureResponse
        /// </returns>
        public CreateVpcFirewallCenConfigureResponse CreateVpcFirewallCenConfigure(CreateVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual private cloud (VPC) firewall to protect traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallCenConfigure operation to create a VPC firewall. The VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. The VPC firewall cannot protect mutual access traffic between VBRs, between CCN instances, or between VBRs and CCN instances. For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallCenConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallCenConfigureResponse
        /// </returns>
        public async Task<CreateVpcFirewallCenConfigureResponse> CreateVpcFirewallCenConfigureAsync(CreateVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h3><a href="#qps"></a>QPS limit</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h3><a href="#qps"></a>QPS limit</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h3><a href="#qps"></a>QPS limit</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallConfigureResponse
        /// </returns>
        public CreateVpcFirewallConfigureResponse CreateVpcFirewallConfigure(CreateVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallConfigureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Virtual Private Cloud (VPC) firewall to protect traffic between two VPCs that are connected by using an Express Connect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. The VPC firewall does not control the mutual access traffic between VPCs that reside in different regions or belong to different Alibaba Cloud accounts. The firewall also does not control the mutual access traffic between VPCs and virtual border routers (VBRs). For more information, see <a href="https://help.aliyun.com/document_detail/172295.html">VPC firewall limits</a>.</para>
        /// <h3><a href="#qps"></a>QPS limit</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallConfigureResponse
        /// </returns>
        public async Task<CreateVpcFirewallConfigureResponse> CreateVpcFirewallConfigureAsync(CreateVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallControlPolicyResponse
        /// </returns>
        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicy(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control policy in a specified policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the CreateVpcFirewallControlPolicy operation to create an access control policy in a specified policy group for a VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcFirewallControlPolicyResponse
        /// </returns>
        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyAsync(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an address book for access control.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteAddressBook operation to delete an address book for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an address book for access control.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteAddressBook operation to delete an address book for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an address book for access control.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteAddressBook operation to delete an address book for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddressBookResponse
        /// </returns>
        public DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAddressBookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an address book for access control.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteAddressBook operation to delete an address book for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAddressBookResponse
        /// </returns>
        public async Task<DeleteAddressBookResponse> DeleteAddressBookAsync(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAddressBookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyResponse
        /// </returns>
        public DeleteControlPolicyResponse DeleteControlPolicy(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteControlPolicy operation to delete an access control policy that applies to inbound or outbound traffic.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyResponse
        /// </returns>
        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyAsync(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyTemplateResponse
        /// </returns>
        public DeleteControlPolicyTemplateResponse DeleteControlPolicyTemplate(DeleteControlPolicyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteControlPolicyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteControlPolicyTemplateResponse
        /// </returns>
        public async Task<DeleteControlPolicyTemplateResponse> DeleteControlPolicyTemplateAsync(DeleteControlPolicyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes file download tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete file download tasks and delete the files.
        /// **
        /// <b>Warning</b> Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDownloadTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes file download tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete file download tasks and delete the files.
        /// **
        /// <b>Warning</b> Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDownloadTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes file download tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete file download tasks and delete the files.
        /// **
        /// <b>Warning</b> Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDownloadTaskResponse
        /// </returns>
        public DeleteDownloadTaskResponse DeleteDownloadTask(DeleteDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDownloadTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes file download tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete file download tasks and delete the files.
        /// **
        /// <b>Warning</b> Both tasks and involved files are deleted. You can no longer download the involved files by using the download links. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDownloadTaskResponse
        /// </returns>
        public async Task<DeleteDownloadTaskResponse> DeleteDownloadTaskAsync(DeleteDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDownloadTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFirewallV2RoutePoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallV2RoutePoliciesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFirewallV2RoutePoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallV2RoutePoliciesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFirewallV2RoutePoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallV2RoutePoliciesResponse
        /// </returns>
        public DeleteFirewallV2RoutePoliciesResponse DeleteFirewallV2RoutePolicies(DeleteFirewallV2RoutePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFirewallV2RoutePoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes routing policies for a virtual private cloud (VPC) firewall of a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFirewallV2RoutePoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallV2RoutePoliciesResponse
        /// </returns>
        public async Task<DeleteFirewallV2RoutePoliciesResponse> DeleteFirewallV2RoutePoliciesAsync(DeleteFirewallV2RoutePoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFirewallV2RoutePoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes members from Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the <a href="https://help.aliyun.com/document_detail/271704.html">DescribeInstanceMembers</a> operation to obtain the information about the members that are added to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes members from Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the <a href="https://help.aliyun.com/document_detail/271704.html">DescribeInstanceMembers</a> operation to obtain the information about the members that are added to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes members from Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the <a href="https://help.aliyun.com/document_detail/271704.html">DescribeInstanceMembers</a> operation to obtain the information about the members that are added to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceMembersResponse
        /// </returns>
        public DeleteInstanceMembersResponse DeleteInstanceMembers(DeleteInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes members from Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to remove up to 20 members from Cloud Firewall at a time. Separate multiple members with commas (,). After a member is removed, Cloud Firewall can no longer access the cloud resources of the member. Proceed with caution. Before you call this operation, call the <a href="https://help.aliyun.com/document_detail/271704.html">DescribeInstanceMembers</a> operation to obtain the information about the members that are added to Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceMembersResponse
        /// </returns>
        public async Task<DeleteInstanceMembersResponse> DeleteInstanceMembersAsync(DeleteInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to delete an outbound access control policy that is created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to delete an outbound access control policy that is created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to delete an outbound access control policy that is created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyResponse
        /// </returns>
        public DeleteNatFirewallControlPolicyResponse DeleteNatFirewallControlPolicy(DeleteNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to delete an outbound access control policy that is created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyResponse
        /// </returns>
        public async Task<DeleteNatFirewallControlPolicyResponse> DeleteNatFirewallControlPolicyAsync(DeleteNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes access control policies that are created for a NAT firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyBatchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes access control policies that are created for a NAT firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyBatchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes access control policies that are created for a NAT firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyBatchResponse
        /// </returns>
        public DeleteNatFirewallControlPolicyBatchResponse DeleteNatFirewallControlPolicyBatch(DeleteNatFirewallControlPolicyBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNatFirewallControlPolicyBatchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes access control policies that are created for a NAT firewall at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNatFirewallControlPolicyBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNatFirewallControlPolicyBatchResponse
        /// </returns>
        public async Task<DeleteNatFirewallControlPolicyBatchResponse> DeleteNatFirewallControlPolicyBatchAsync(DeleteNatFirewallControlPolicyBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNatFirewallControlPolicyBatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityProxyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityProxyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityProxyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityProxyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityProxyResponse
        /// </returns>
        public DeleteSecurityProxyResponse DeleteSecurityProxy(DeleteSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityProxyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityProxyResponse
        /// </returns>
        public async Task<DeleteSecurityProxyResponse> DeleteSecurityProxyAsync(DeleteSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityProxyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrFirewallV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrFirewallV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrFirewallV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrFirewallV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrFirewallV2Request
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrFirewallV2Response
        /// </returns>
        public DeleteTrFirewallV2Response DeleteTrFirewallV2(DeleteTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrFirewallV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrFirewallV2Request
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrFirewallV2Response
        /// </returns>
        public async Task<DeleteTrFirewallV2Response> DeleteTrFirewallV2Async(DeleteTrFirewallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrFirewallV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallCenConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallCenConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallCenConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallCenConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallCenConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallCenConfigureResponse
        /// </returns>
        public DeleteVpcFirewallCenConfigureResponse DeleteVpcFirewallCenConfigure(DeleteVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallCenConfigure operation to delete a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallCenConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallCenConfigureResponse
        /// </returns>
        public async Task<DeleteVpcFirewallCenConfigureResponse> DeleteVpcFirewallCenConfigureAsync(DeleteVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallConfigureResponse
        /// </returns>
        public DeleteVpcFirewallConfigureResponse DeleteVpcFirewallConfigure(DeleteVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallConfigureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual private cloud (VPC) firewall that controls traffic between two VPCs. The VPCs are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallConfigure operation to delete a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallConfigureResponse
        /// </returns>
        public async Task<DeleteVpcFirewallConfigureResponse> DeleteVpcFirewallConfigureAsync(DeleteVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallControlPolicyResponse
        /// </returns>
        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicy(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control policy from a specific policy group for a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DeleteVpcFirewallControlPolicy operation to delete an access control policy from a specific policy group for a VPC firewall. Different access control policies are used for the VPC firewall that is used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewall that is used to protect each Express Connect circuit. </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcFirewallControlPolicyResponse
        /// </returns>
        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyAsync(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics on the requests that are blocked by the access control list (ACL) feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeACLProtectTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeACLProtectTrendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics on the requests that are blocked by the access control list (ACL) feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeACLProtectTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeACLProtectTrendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics on the requests that are blocked by the access control list (ACL) feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeACLProtectTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeACLProtectTrendResponse
        /// </returns>
        public DescribeACLProtectTrendResponse DescribeACLProtectTrend(DescribeACLProtectTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeACLProtectTrendWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics on the requests that are blocked by the access control list (ACL) feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeACLProtectTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeACLProtectTrendResponse
        /// </returns>
        public async Task<DescribeACLProtectTrendResponse> DescribeACLProtectTrendAsync(DescribeACLProtectTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeACLProtectTrendWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an address book for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details about an address book for an access control policy.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an address book for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details about an address book for an access control policy.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an address book for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details about an address book for an access control policy.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddressBookResponse
        /// </returns>
        public DescribeAddressBookResponse DescribeAddressBook(DescribeAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddressBookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an address book for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details about an address book for an access control policy.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddressBookResponse
        /// </returns>
        public async Task<DescribeAddressBookResponse> DescribeAddressBookAsync(DescribeAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddressBookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAssetListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetListResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutStatistic))
            {
                query["OutStatistic"] = request.OutStatistic;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveStatus))
            {
                query["SensitiveStatus"] = request.SensitiveStatus;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAssetListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetListResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutStatistic))
            {
                query["OutStatistic"] = request.OutStatistic;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveStatus))
            {
                query["SensitiveStatus"] = request.SensitiveStatus;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAssetListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetListResponse
        /// </returns>
        public DescribeAssetListResponse DescribeAssetList(DescribeAssetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeAssetList operation to query the assets that are protected by Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAssetListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetListResponse
        /// </returns>
        public async Task<DescribeAssetListResponse> DescribeAssetListAsync(DescribeAssetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of assets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetRiskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetRiskListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of assets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetRiskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetRiskListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of assets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetRiskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetRiskListResponse
        /// </returns>
        public DescribeAssetRiskListResponse DescribeAssetRiskList(DescribeAssetRiskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetRiskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of assets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetRiskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetRiskListResponse
        /// </returns>
        public async Task<DescribeAssetRiskListResponse> DescribeAssetRiskListAsync(DescribeAssetRiskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetRiskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetStatisticResponse
        /// </returns>
        public DescribeAssetStatisticResponse DescribeAssetStatisticWithOptions(DescribeAssetStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAssetStatistic",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetStatisticResponse
        /// </returns>
        public async Task<DescribeAssetStatisticResponse> DescribeAssetStatisticWithOptionsAsync(DescribeAssetStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAssetStatistic",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetStatisticResponse
        /// </returns>
        public DescribeAssetStatisticResponse DescribeAssetStatistic(DescribeAssetStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetStatisticResponse
        /// </returns>
        public async Task<DescribeAssetStatisticResponse> DescribeAssetStatisticAsync(DescribeAssetStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall risk level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCfwRiskLevelSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCfwRiskLevelSummaryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall risk level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCfwRiskLevelSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCfwRiskLevelSummaryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall risk level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCfwRiskLevelSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCfwRiskLevelSummaryResponse
        /// </returns>
        public DescribeCfwRiskLevelSummaryResponse DescribeCfwRiskLevelSummary(DescribeCfwRiskLevelSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCfwRiskLevelSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall risk level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCfwRiskLevelSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCfwRiskLevelSummaryResponse
        /// </returns>
        public async Task<DescribeCfwRiskLevelSummaryResponse> DescribeCfwRiskLevelSummaryAsync(DescribeCfwRiskLevelSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCfwRiskLevelSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about all access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeControlPolicy operation to query the details about access control policies by page.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about all access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeControlPolicy operation to query the details about access control policies by page.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about all access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeControlPolicy operation to query the details about access control policies by page.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeControlPolicyResponse
        /// </returns>
        public DescribeControlPolicyResponse DescribeControlPolicy(DescribeControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about all access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeControlPolicy operation to query the details about access control policies by page.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeControlPolicyResponse
        /// </returns>
        public async Task<DescribeControlPolicyResponse> DescribeControlPolicyAsync(DescribeControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default intrusion prevention system (IPS) configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefaultIPSConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default intrusion prevention system (IPS) configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefaultIPSConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default intrusion prevention system (IPS) configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefaultIPSConfigResponse
        /// </returns>
        public DescribeDefaultIPSConfigResponse DescribeDefaultIPSConfig(DescribeDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefaultIPSConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default intrusion prevention system (IPS) configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefaultIPSConfigResponse
        /// </returns>
        public async Task<DescribeDefaultIPSConfigResponse> DescribeDefaultIPSConfigAsync(DescribeDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeDomainResolve is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Domain Name System (DNS) records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDomainResolveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainResolveResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeDomainResolve is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeDomainResolve is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Domain Name System (DNS) records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDomainResolveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainResolveResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeDomainResolve is deprecated")]
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeDomainResolve is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Domain Name System (DNS) records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDomainResolveRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainResolveResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeDomainResolve is deprecated")]
        // Deprecated
        public DescribeDomainResolveResponse DescribeDomainResolve(DescribeDomainResolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainResolveWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeDomainResolve is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Domain Name System (DNS) records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the DNS record of a domain name. This operation can retrieve DNS records only from Alibaba Cloud DNS. Before you can call this operation, make sure that your domain name is hosted on Alibaba Cloud DNS.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDomainResolveRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainResolveResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeDomainResolve is deprecated")]
        // Deprecated
        public async Task<DescribeDomainResolveResponse> DescribeDomainResolveAsync(DescribeDomainResolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainResolveWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file download tasks, including the task information and download URLs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file download tasks, including the task information and download URLs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file download tasks, including the task information and download URLs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
        public DescribeDownloadTaskResponse DescribeDownloadTask(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries file download tasks, including the task information and download URLs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskAsync(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskTypeResponse
        /// </returns>
        public DescribeDownloadTaskTypeResponse DescribeDownloadTaskType(DescribeDownloadTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadTaskTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the types of download tasks. The type corresponds to the TaskType fields in the download task-related operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskTypeResponse
        /// </returns>
        public async Task<DescribeDownloadTaskTypeResponse> DescribeDownloadTaskTypeAsync(DescribeDownloadTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadTaskTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about members in Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about members in Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about members in Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMembersResponse
        /// </returns>
        public DescribeInstanceMembersResponse DescribeInstanceMembers(DescribeInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about members in Cloud Firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceMembersResponse
        /// </returns>
        public async Task<DescribeInstanceMembersResponse> DescribeInstanceMembersAsync(DescribeInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRiskLevelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRiskLevelsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRiskLevelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRiskLevelsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRiskLevelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRiskLevelsResponse
        /// </returns>
        public DescribeInstanceRiskLevelsResponse DescribeInstanceRiskLevels(DescribeInstanceRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceRiskLevelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk levels of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRiskLevelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRiskLevelsResponse
        /// </returns>
        public async Task<DescribeInstanceRiskLevelsResponse> DescribeInstanceRiskLevelsAsync(DescribeInstanceRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceRiskLevelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses that are open to the Internet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetOpenIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetOpenIpResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses that are open to the Internet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetOpenIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetOpenIpResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses that are open to the Internet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetOpenIpRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetOpenIpResponse
        /// </returns>
        public DescribeInternetOpenIpResponse DescribeInternetOpenIp(DescribeInternetOpenIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInternetOpenIpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses that are open to the Internet.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetOpenIpRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetOpenIpResponse
        /// </returns>
        public async Task<DescribeInternetOpenIpResponse> DescribeInternetOpenIpAsync(DescribeInternetOpenIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInternetOpenIpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trends of Internet traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetTrafficTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetTrafficTrendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trends of Internet traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetTrafficTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetTrafficTrendResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trends of Internet traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetTrafficTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetTrafficTrendResponse
        /// </returns>
        public DescribeInternetTrafficTrendResponse DescribeInternetTrafficTrend(DescribeInternetTrafficTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInternetTrafficTrendWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trends of Internet traffic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInternetTrafficTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInternetTrafficTrendResponse
        /// </returns>
        public async Task<DescribeInternetTrafficTrendResponse> DescribeInternetTrafficTrendAsync(DescribeInternetTrafficTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInternetTrafficTrendWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the breach awareness events of a firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvadeEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvadeEventListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the breach awareness events of a firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvadeEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvadeEventListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the breach awareness events of a firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvadeEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvadeEventListResponse
        /// </returns>
        public DescribeInvadeEventListResponse DescribeInvadeEventList(DescribeInvadeEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvadeEventListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the breach awareness events of a firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvadeEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvadeEventListResponse
        /// </returns>
        public async Task<DescribeInvadeEventListResponse> DescribeInvadeEventListAsync(DescribeInvadeEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvadeEventListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志服务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogStoreInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogStoreInfoResponse
        /// </returns>
        public DescribeLogStoreInfoResponse DescribeLogStoreInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogStoreInfo",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogStoreInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志服务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogStoreInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogStoreInfoResponse
        /// </returns>
        public async Task<DescribeLogStoreInfoResponse> DescribeLogStoreInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogStoreInfo",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogStoreInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志服务信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeLogStoreInfoResponse
        /// </returns>
        public DescribeLogStoreInfoResponse DescribeLogStoreInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogStoreInfoWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志服务信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeLogStoreInfoResponse
        /// </returns>
        public async Task<DescribeLogStoreInfoResponse> DescribeLogStoreInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogStoreInfoWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pagination status of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatAclPageStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatAclPageStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pagination status of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatAclPageStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatAclPageStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pagination status of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatAclPageStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatAclPageStatusResponse
        /// </returns>
        public DescribeNatAclPageStatusResponse DescribeNatAclPageStatus(DescribeNatAclPageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatAclPageStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pagination status of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatAclPageStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatAclPageStatusResponse
        /// </returns>
        public async Task<DescribeNatAclPageStatusResponse> DescribeNatAclPageStatusAsync(DescribeNatAclPageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatAclPageStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all access control policies that are created for NAT firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all access control policies that are created for NAT firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all access control policies that are created for NAT firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallControlPolicyResponse
        /// </returns>
        public DescribeNatFirewallControlPolicyResponse DescribeNatFirewallControlPolicy(DescribeNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all access control policies that are created for NAT firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the information about all access control policies that are created for NAT firewalls by page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallControlPolicyResponse
        /// </returns>
        public async Task<DescribeNatFirewallControlPolicyResponse> DescribeNatFirewallControlPolicyAsync(DescribeNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallListResponse
        /// </returns>
        public DescribeNatFirewallListResponse DescribeNatFirewallList(DescribeNatFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of NAT firewalls.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallListResponse
        /// </returns>
        public async Task<DescribeNatFirewallListResponse> DescribeNatFirewallListAsync(DescribeNatFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the priority range of access control policies that are created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallPolicyPriorUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallPolicyPriorUsedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the priority range of access control policies that are created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallPolicyPriorUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallPolicyPriorUsedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the priority range of access control policies that are created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallPolicyPriorUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallPolicyPriorUsedResponse
        /// </returns>
        public DescribeNatFirewallPolicyPriorUsedResponse DescribeNatFirewallPolicyPriorUsed(DescribeNatFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallPolicyPriorUsedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to query the priority range of access control policies that are created for a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallPolicyPriorUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallPolicyPriorUsedResponse
        /// </returns>
        public async Task<DescribeNatFirewallPolicyPriorUsedResponse> DescribeNatFirewallPolicyPriorUsedAsync(DescribeNatFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallPolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>概览页-NAT流量趋势</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallTrafficTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallTrafficTrendResponse
        /// </returns>
        public DescribeNatFirewallTrafficTrendResponse DescribeNatFirewallTrafficTrendWithOptions(DescribeNatFirewallTrafficTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatFirewallTrafficTrend",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallTrafficTrendResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>概览页-NAT流量趋势</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallTrafficTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallTrafficTrendResponse
        /// </returns>
        public async Task<DescribeNatFirewallTrafficTrendResponse> DescribeNatFirewallTrafficTrendWithOptionsAsync(DescribeNatFirewallTrafficTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNatFirewallTrafficTrend",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNatFirewallTrafficTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>概览页-NAT流量趋势</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallTrafficTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallTrafficTrendResponse
        /// </returns>
        public DescribeNatFirewallTrafficTrendResponse DescribeNatFirewallTrafficTrend(DescribeNatFirewallTrafficTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatFirewallTrafficTrendWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>概览页-NAT流量趋势</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNatFirewallTrafficTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNatFirewallTrafficTrendResponse
        /// </returns>
        public async Task<DescribeNatFirewallTrafficTrendResponse> DescribeNatFirewallTrafficTrendAsync(DescribeNatFirewallTrafficTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatFirewallTrafficTrendWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the destination IP addresses in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDestinationIPRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDestinationIPResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the destination IP addresses in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDestinationIPRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDestinationIPResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the destination IP addresses in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDestinationIPRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDestinationIPResponse
        /// </returns>
        public DescribeOutgoingDestinationIPResponse DescribeOutgoingDestinationIP(DescribeOutgoingDestinationIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutgoingDestinationIPWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the destination IP addresses in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDestinationIPRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDestinationIPResponse
        /// </returns>
        public async Task<DescribeOutgoingDestinationIPResponse> DescribeOutgoingDestinationIPAsync(DescribeOutgoingDestinationIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutgoingDestinationIPWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the domain names in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the domain names in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the domain names in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDomainResponse
        /// </returns>
        public DescribeOutgoingDomainResponse DescribeOutgoingDomain(DescribeOutgoingDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutgoingDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the domain names in outbound connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOutgoingDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOutgoingDomainResponse
        /// </returns>
        public async Task<DescribeOutgoingDomainResponse> DescribeOutgoingDomainAsync(DescribeOutgoingDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutgoingDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the strict mode is enabled for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyAdvancedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyAdvancedConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the strict mode is enabled for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyAdvancedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyAdvancedConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the strict mode is enabled for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyAdvancedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyAdvancedConfigResponse
        /// </returns>
        public DescribePolicyAdvancedConfigResponse DescribePolicyAdvancedConfig(DescribePolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyAdvancedConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the strict mode is enabled for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribePolicyAdvancedConfig operation to query whether the strict mode is enabled for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyAdvancedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyAdvancedConfigResponse
        /// </returns>
        public async Task<DescribePolicyAdvancedConfigResponse> DescribePolicyAdvancedConfigAsync(DescribePolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of the access control policies that match specific query conditions.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyPriorUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyPriorUsedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of the access control policies that match specific query conditions.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyPriorUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyPriorUsedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of the access control policies that match specific query conditions.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyPriorUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyPriorUsedResponse
        /// </returns>
        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsed(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyPriorUsedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of the access control policies that match specific query conditions.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePolicyPriorUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyPriorUsedResponse
        /// </returns>
        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedAsync(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of traffic billed based on the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of traffic billed based on the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of traffic billed based on the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficDetailResponse
        /// </returns>
        public DescribePostpayTrafficDetailResponse DescribePostpayTrafficDetail(DescribePostpayTrafficDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePostpayTrafficDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of traffic billed based on the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use Cloud Firewall that uses the pay-as-you-go billing method, you can call this operation to query traffic details accurate to the granularity of specific resource instances. If you use Cloud Firewall that uses the subscription billing method, you can call this operation to query the overall traffic details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficDetailResponse
        /// </returns>
        public async Task<DescribePostpayTrafficDetailResponse> DescribePostpayTrafficDetailAsync(DescribePostpayTrafficDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePostpayTrafficDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficTotalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficTotalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficTotalResponse
        /// </returns>
        public DescribePostpayTrafficTotalResponse DescribePostpayTrafficTotal(DescribePostpayTrafficTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePostpayTrafficTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the total volume of traffic that is billed based on the pay-as-you-go billing method, including all firewalls within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query statistics of the current Cloud Firewall from the date of purchase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePostpayTrafficTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePostpayTrafficTotalResponse
        /// </returns>
        public async Task<DescribePostpayTrafficTotalResponse> DescribePostpayTrafficTotalAsync(DescribePostpayTrafficTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePostpayTrafficTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries prefix lists.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePrefixListsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePrefixListsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries prefix lists.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePrefixListsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePrefixListsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries prefix lists.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePrefixListsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePrefixListsResponse
        /// </returns>
        public DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePrefixListsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries prefix lists.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePrefixListsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePrefixListsResponse
        /// </returns>
        public async Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePrefixListsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of intrusion events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRiskEventGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventGroupResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyPrivateAssoc))
            {
                query["IsOnlyPrivateAssoc"] = request.IsOnlyPrivateAssoc;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of intrusion events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRiskEventGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventGroupResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyPrivateAssoc))
            {
                query["IsOnlyPrivateAssoc"] = request.IsOnlyPrivateAssoc;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of intrusion events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRiskEventGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventGroupResponse
        /// </returns>
        public DescribeRiskEventGroupResponse DescribeRiskEventGroup(DescribeRiskEventGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskEventGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of intrusion events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeRiskEventGroup operation to query and download the details of intrusion events. We recommend that you query the details of 5 to 10 intrusion events at a time. If you do not need to query the geographical information about IP addresses, you can set the NoLocation parameter to true to prevent query timeout.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRiskEventGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventGroupResponse
        /// </returns>
        public async Task<DescribeRiskEventGroupResponse> DescribeRiskEventGroupAsync(DescribeRiskEventGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskEventGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attack payloads of intrusion events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRiskEventPayloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventPayloadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attack payloads of intrusion events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRiskEventPayloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventPayloadResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attack payloads of intrusion events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRiskEventPayloadRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventPayloadResponse
        /// </returns>
        public DescribeRiskEventPayloadResponse DescribeRiskEventPayload(DescribeRiskEventPayloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskEventPayloadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the attack payloads of intrusion events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRiskEventPayloadRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRiskEventPayloadResponse
        /// </returns>
        public async Task<DescribeRiskEventPayloadResponse> DescribeRiskEventPayloadAsync(DescribeRiskEventPayloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskEventPayloadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about signature library versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSignatureLibVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSignatureLibVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about signature library versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSignatureLibVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSignatureLibVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about signature library versions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSignatureLibVersionResponse
        /// </returns>
        public DescribeSignatureLibVersionResponse DescribeSignatureLibVersion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSignatureLibVersionWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about signature library versions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSignatureLibVersionResponse
        /// </returns>
        public async Task<DescribeSignatureLibVersionResponse> DescribeSignatureLibVersionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSignatureLibVersionWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeTrFirewallPolicyBackUpAssociationListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallPolicyBackUpAssociationListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeTrFirewallPolicyBackUpAssociationListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallPolicyBackUpAssociationListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallPolicyBackUpAssociationListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallPolicyBackUpAssociationListResponse
        /// </returns>
        public DescribeTrFirewallPolicyBackUpAssociationListResponse DescribeTrFirewallPolicyBackUpAssociationList(DescribeTrFirewallPolicyBackUpAssociationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallPolicyBackUpAssociationListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the transit routers that are associated with a virtual private cloud (VPC) firewall created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallPolicyBackUpAssociationListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallPolicyBackUpAssociationListResponse
        /// </returns>
        public async Task<DescribeTrFirewallPolicyBackUpAssociationListResponse> DescribeTrFirewallPolicyBackUpAssociationListAsync(DescribeTrFirewallPolicyBackUpAssociationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallPolicyBackUpAssociationListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallV2RoutePolicyListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallV2RoutePolicyListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallV2RoutePolicyListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallV2RoutePolicyListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallV2RoutePolicyListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallV2RoutePolicyListResponse
        /// </returns>
        public DescribeTrFirewallV2RoutePolicyListResponse DescribeTrFirewallV2RoutePolicyList(DescribeTrFirewallV2RoutePolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallV2RoutePolicyListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the routing policies of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallV2RoutePolicyListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallV2RoutePolicyListResponse
        /// </returns>
        public async Task<DescribeTrFirewallV2RoutePolicyListResponse> DescribeTrFirewallV2RoutePolicyListAsync(DescribeTrFirewallV2RoutePolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallV2RoutePolicyListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2DetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2DetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2DetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2DetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2DetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2DetailResponse
        /// </returns>
        public DescribeTrFirewallsV2DetailResponse DescribeTrFirewallsV2Detail(DescribeTrFirewallsV2DetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallsV2DetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2DetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2DetailResponse
        /// </returns>
        public async Task<DescribeTrFirewallsV2DetailResponse> DescribeTrFirewallsV2DetailAsync(DescribeTrFirewallsV2DetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallsV2DetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2ListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2ListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2ListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2ListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2ListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2ListResponse
        /// </returns>
        public DescribeTrFirewallsV2ListResponse DescribeTrFirewallsV2List(DescribeTrFirewallsV2ListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallsV2ListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private cloud (VPC) firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2ListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2ListResponse
        /// </returns>
        public async Task<DescribeTrFirewallsV2ListResponse> DescribeTrFirewallsV2ListAsync(DescribeTrFirewallsV2ListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallsV2ListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route tables of the VPC firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2RouteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2RouteListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route tables of the VPC firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2RouteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2RouteListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route tables of the VPC firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2RouteListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2RouteListResponse
        /// </returns>
        public DescribeTrFirewallsV2RouteListResponse DescribeTrFirewallsV2RouteList(DescribeTrFirewallsV2RouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrFirewallsV2RouteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route tables of the VPC firewalls that are created for transit routers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTrFirewallsV2RouteListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrFirewallsV2RouteListResponse
        /// </returns>
        public async Task<DescribeTrFirewallsV2RouteListResponse> DescribeTrFirewallsV2RouteListAsync(DescribeTrFirewallsV2RouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrFirewallsV2RouteListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAssetIPTrafficInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAssetIPTrafficInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAssetIPTrafficInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAssetIPTrafficInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAssetIPTrafficInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAssetIPTrafficInfoResponse
        /// </returns>
        public DescribeUserAssetIPTrafficInfoResponse DescribeUserAssetIPTrafficInfo(DescribeUserAssetIPTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserAssetIPTrafficInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the traffic of a specified asset that belongs to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAssetIPTrafficInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAssetIPTrafficInfoResponse
        /// </returns>
        public async Task<DescribeUserAssetIPTrafficInfoResponse> DescribeUserAssetIPTrafficInfoAsync(DescribeUserAssetIPTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserAssetIPTrafficInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the edition information about Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the edition information about Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserBuyVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the edition information about Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the edition information about Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserBuyVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the edition information about Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the edition information about Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserBuyVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyVersionResponse
        /// </returns>
        public DescribeUserBuyVersionResponse DescribeUserBuyVersion(DescribeUserBuyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBuyVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the edition information about Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the edition information about Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserBuyVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyVersionResponse
        /// </returns>
        public async Task<DescribeUserBuyVersionResponse> DescribeUserBuyVersionAsync(DescribeUserBuyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBuyVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserIPSWhitelistResponse
        /// </returns>
        public DescribeUserIPSWhitelistResponse DescribeUserIPSWhitelist(DescribeUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserIPSWhitelistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserIPSWhitelistResponse
        /// </returns>
        public async Task<DescribeUserIPSWhitelistResponse> DescribeUserIPSWhitelistAsync(DescribeUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallAclGroupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallAclGroupListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallAclGroupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallAclGroupListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallAclGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallAclGroupListResponse
        /// </returns>
        public DescribeVpcFirewallAclGroupListResponse DescribeVpcFirewallAclGroupList(DescribeVpcFirewallAclGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallAclGroupListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all policy groups of access control policies that are created for virtual private cloud (VPC) firewalls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallAclGroupList operation to query the information about all policy groups of access control policies that are created for VPC firewalls.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallAclGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallAclGroupListResponse
        /// </returns>
        public async Task<DescribeVpcFirewallAclGroupListResponse> DescribeVpcFirewallAclGroupListAsync(DescribeVpcFirewallAclGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallAclGroupListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenDetailResponse
        /// </returns>
        public DescribeVpcFirewallCenDetailResponse DescribeVpcFirewallCenDetail(DescribeVpcFirewallCenDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallCenDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall protects access traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenDetail operation to query the details about a VPC firewall. The VPC firewall protects access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenDetailResponse
        /// </returns>
        public async Task<DescribeVpcFirewallCenDetailResponse> DescribeVpcFirewallCenDetailAsync(DescribeVpcFirewallCenDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallCenDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenListResponse
        /// </returns>
        public DescribeVpcFirewallCenListResponse DescribeVpcFirewallCenList(DescribeVpcFirewallCenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallCenListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) firewalls. Each VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallCenList operation to query VPC firewalls. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallCenListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallCenListResponse
        /// </returns>
        public async Task<DescribeVpcFirewallCenListResponse> DescribeVpcFirewallCenListAsync(DescribeVpcFirewallCenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallCenListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallControlPolicyResponse
        /// </returns>
        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicy(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the access control policies for a specified virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallControlPolicy operation to query the information about all access control policies that are created for a specified VPC firewall. Different access control policies are used when a VPC firewall is used to protect traffic between two VPCs that are connected by using a Cloud Enterprise Network (CEN) instance or an Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallControlPolicyResponse
        /// </returns>
        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyAsync(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDefaultIPSConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDefaultIPSConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDefaultIPSConfigResponse
        /// </returns>
        public DescribeVpcFirewallDefaultIPSConfigResponse DescribeVpcFirewallDefaultIPSConfig(DescribeVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallDefaultIPSConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDefaultIPSConfig operation to query the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDefaultIPSConfigResponse
        /// </returns>
        public async Task<DescribeVpcFirewallDefaultIPSConfigResponse> DescribeVpcFirewallDefaultIPSConfigAsync(DescribeVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.<br>Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure">CreateVpcFirewallConfigure</a> operation.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.<br>Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure">CreateVpcFirewallConfigure</a> operation.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.<br>Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure">CreateVpcFirewallConfigure</a> operation.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDetailResponse
        /// </returns>
        public DescribeVpcFirewallDetailResponse DescribeVpcFirewallDetail(DescribeVpcFirewallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallDetail operation to query the details about a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.<br>Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://www.alibabacloud.com/help/en/cloud-firewall/latest/createvpcfirewallconfigure">CreateVpcFirewallConfigure</a> operation.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallDetailResponse
        /// </returns>
        public async Task<DescribeVpcFirewallDetailResponse> DescribeVpcFirewallDetailAsync(DescribeVpcFirewallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallIPSWhitelistResponse
        /// </returns>
        public DescribeVpcFirewallIPSWhitelistResponse DescribeVpcFirewallIPSWhitelist(DescribeVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallIPSWhitelistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallIPSWhitelistResponse
        /// </returns>
        public async Task<DescribeVpcFirewallIPSWhitelistResponse> DescribeVpcFirewallIPSWhitelistAsync(DescribeVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallListResponse
        /// </returns>
        public DescribeVpcFirewallListResponse DescribeVpcFirewallList(DescribeVpcFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about virtual private cloud (VPC) firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeVpcFirewallList operation to query the details about VPC firewalls by page. Each VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallListResponse
        /// </returns>
        public async Task<DescribeVpcFirewallListResponse> DescribeVpcFirewallListAsync(DescribeVpcFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallPolicyPriorUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallPolicyPriorUsedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallPolicyPriorUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallPolicyPriorUsedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallPolicyPriorUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallPolicyPriorUsedResponse
        /// </returns>
        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsed(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallPolicyPriorUsedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the priority range of access control policies that are created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the priority range of access control policies that are created for a VPC firewall in a specific policy group.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVpcFirewallPolicyPriorUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcFirewallPolicyPriorUsedResponse
        /// </returns>
        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedAsync(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private clouds (VPCs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcListLiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcListLiteResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private clouds (VPCs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcListLiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcListLiteResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private clouds (VPCs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcListLiteRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcListLiteResponse
        /// </returns>
        public DescribeVpcListLiteResponse DescribeVpcListLite(DescribeVpcListLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcListLiteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private clouds (VPCs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcListLiteRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcListLiteResponse
        /// </returns>
        public async Task<DescribeVpcListLiteResponse> DescribeVpcListLiteAsync(DescribeVpcListLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcListLiteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcZoneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcZoneResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcZoneResponse
        /// </returns>
        public DescribeVpcZoneResponse DescribeVpcZone(DescribeVpcZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcZoneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) zones.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVpcZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVpcZoneResponse
        /// </returns>
        public async Task<DescribeVpcZoneResponse> DescribeVpcZoneAsync(DescribeVpcZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcZoneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the vulnerabilities that are supported by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVulnerabilityProtectedListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVulnerabilityProtectedListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the vulnerabilities that are supported by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVulnerabilityProtectedListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVulnerabilityProtectedListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the vulnerabilities that are supported by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVulnerabilityProtectedListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVulnerabilityProtectedListResponse
        /// </returns>
        public DescribeVulnerabilityProtectedListResponse DescribeVulnerabilityProtectedList(DescribeVulnerabilityProtectedListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulnerabilityProtectedListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the vulnerabilities that are supported by Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVulnerabilityProtectedListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVulnerabilityProtectedListResponse
        /// </returns>
        public async Task<DescribeVulnerabilityProtectedListResponse> DescribeVulnerabilityProtectedListAsync(DescribeVulnerabilityProtectedListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulnerabilityProtectedListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the address book that is specified in an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the address book that is specified in an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAddressBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAddressBookResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the address book that is specified in an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAddressBookResponse
        /// </returns>
        public ModifyAddressBookResponse ModifyAddressBook(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAddressBookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the address book that is specified in an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyAddressBook operation to modify the address book that is configured for access control.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAddressBookRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAddressBookResponse
        /// </returns>
        public async Task<ModifyAddressBookResponse> ModifyAddressBookAsync(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAddressBookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.</para>
        /// <h2><a href="#qps"></a>Limit</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.</para>
        /// <h2><a href="#qps"></a>Limit</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.</para>
        /// <h2><a href="#qps"></a>Limit</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyResponse
        /// </returns>
        public ModifyControlPolicyResponse ModifyControlPolicy(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the configurations of an access control policy. The policy allows Cloud Firewall to allow, deny, or monitor the traffic that passes through Cloud Firewall.</para>
        /// <h2><a href="#qps"></a>Limit</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyResponse
        /// </returns>
        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyAsync(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyPositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyPositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyPositionResponse
        /// </returns>
        public ModifyControlPolicyPositionResponse ModifyControlPolicyPosition(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyPositionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an IPv4 access control policy for the Internet firewall. An IPv4 access control policy refers to a policy whose source IP address and destination IP address are IPv4 addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an IPv4 access control policy for the Internet firewall. No API operations are provided for you to modify the priority of an IPv6 access control policy for the Internet firewall.</para>
        /// <h2><a href="#qps"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyControlPolicyPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyControlPolicyPositionResponse
        /// </returns>
        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionAsync(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the default configuration of the intrusion prevention system (IPS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefaultIPSConfigResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSdl))
            {
                query["MaxSdl"] = request.MaxSdl;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the default configuration of the intrusion prevention system (IPS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefaultIPSConfigResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSdl))
            {
                query["MaxSdl"] = request.MaxSdl;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the default configuration of the intrusion prevention system (IPS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefaultIPSConfigResponse
        /// </returns>
        public ModifyDefaultIPSConfigResponse ModifyDefaultIPSConfig(ModifyDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefaultIPSConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the default configuration of the intrusion prevention system (IPS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefaultIPSConfigResponse
        /// </returns>
        public async Task<ModifyDefaultIPSConfigResponse> ModifyDefaultIPSConfigAsync(ModifyDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallV2RoutePolicySwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallV2RoutePolicySwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallV2RoutePolicySwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallV2RoutePolicySwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallV2RoutePolicySwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallV2RoutePolicySwitchResponse
        /// </returns>
        public ModifyFirewallV2RoutePolicySwitchResponse ModifyFirewallV2RoutePolicySwitch(ModifyFirewallV2RoutePolicySwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFirewallV2RoutePolicySwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a routing policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallV2RoutePolicySwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallV2RoutePolicySwitchResponse
        /// </returns>
        public async Task<ModifyFirewallV2RoutePolicySwitchResponse> ModifyFirewallV2RoutePolicySwitchAsync(ModifyFirewallV2RoutePolicySwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFirewallV2RoutePolicySwitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceMemberAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceMemberAttributesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceMemberAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceMemberAttributesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceMemberAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceMemberAttributesResponse
        /// </returns>
        public ModifyInstanceMemberAttributesResponse ModifyInstanceMemberAttributes(ModifyInstanceMemberAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMemberAttributesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about members in Cloud Firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyInstanceMemberAttributes operation to update the information about members in Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second for each account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceMemberAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceMemberAttributesResponse
        /// </returns>
        public async Task<ModifyInstanceMemberAttributesResponse> ModifyInstanceMemberAttributesAsync(ModifyInstanceMemberAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMemberAttributesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyResponse
        /// </returns>
        public ModifyNatFirewallControlPolicyResponse ModifyNatFirewallControlPolicy(ModifyNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNatFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the configurations of an access control policy. The policy is used to allow, deny, or monitor traffic that reaches a NAT firewall.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyResponse
        /// </returns>
        public async Task<ModifyNatFirewallControlPolicyResponse> ModifyNatFirewallControlPolicyAsync(ModifyNatFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNatFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyPositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyPositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyPositionResponse
        /// </returns>
        public ModifyNatFirewallControlPolicyPositionResponse ModifyNatFirewallControlPolicyPosition(ModifyNatFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNatFirewallControlPolicyPositionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNatFirewallControlPolicyPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNatFirewallControlPolicyPositionResponse
        /// </returns>
        public async Task<ModifyNatFirewallControlPolicyPositionResponse> ModifyNatFirewallControlPolicyPositionAsync(ModifyNatFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNatFirewallControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an operation on an object group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyObjectGroupOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyObjectGroupOperationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an operation on an object group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyObjectGroupOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyObjectGroupOperationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an operation on an object group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyObjectGroupOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyObjectGroupOperationResponse
        /// </returns>
        public ModifyObjectGroupOperationResponse ModifyObjectGroupOperation(ModifyObjectGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyObjectGroupOperationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an operation on an object group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyObjectGroupOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyObjectGroupOperationResponse
        /// </returns>
        public async Task<ModifyObjectGroupOperationResponse> ModifyObjectGroupOperationAsync(ModifyObjectGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyObjectGroupOperationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the strict mode for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyAdvancedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyAdvancedConfigResponse
        /// </returns>
        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfigWithOptions(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eips))
            {
                query["Eips"] = request.Eips;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the strict mode for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyAdvancedConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyAdvancedConfigResponse
        /// </returns>
        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigWithOptionsAsync(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eips))
            {
                query["Eips"] = request.Eips;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the strict mode for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyAdvancedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyAdvancedConfigResponse
        /// </returns>
        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfig(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyAdvancedConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the strict mode for an access control policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyPolicyAdvancedConfig operation to enable or disable the strict mode for an access control policy.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyAdvancedConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyAdvancedConfigResponse
        /// </returns>
        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigAsync(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTrFirewallV2ConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2ConfigurationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTrFirewallV2ConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2ConfigurationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTrFirewallV2ConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2ConfigurationResponse
        /// </returns>
        public ModifyTrFirewallV2ConfigurationResponse ModifyTrFirewallV2Configuration(ModifyTrFirewallV2ConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTrFirewallV2ConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a virtual private cloud (VPC) firewall that is created for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTrFirewallV2ConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2ConfigurationResponse
        /// </returns>
        public async Task<ModifyTrFirewallV2ConfigurationResponse> ModifyTrFirewallV2ConfigurationAsync(ModifyTrFirewallV2ConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTrFirewallV2ConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyTrFirewallV2RoutePolicyScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2RoutePolicyScopeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyTrFirewallV2RoutePolicyScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2RoutePolicyScopeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTrFirewallV2RoutePolicyScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2RoutePolicyScopeResponse
        /// </returns>
        public ModifyTrFirewallV2RoutePolicyScopeResponse ModifyTrFirewallV2RoutePolicyScope(ModifyTrFirewallV2RoutePolicyScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTrFirewallV2RoutePolicyScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the effective scope of the routing policy created for the VPC firewall for a transit router.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTrFirewallV2RoutePolicyScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTrFirewallV2RoutePolicyScopeResponse
        /// </returns>
        public async Task<ModifyTrFirewallV2RoutePolicyScopeResponse> ModifyTrFirewallV2RoutePolicyScopeAsync(ModifyTrFirewallV2RoutePolicyScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTrFirewallV2RoutePolicyScopeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserIPSWhitelistResponse
        /// </returns>
        public ModifyUserIPSWhitelistResponse ModifyUserIPSWhitelist(ModifyUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserIPSWhitelistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户IPS白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserIPSWhitelistResponse
        /// </returns>
        public async Task<ModifyUserIPSWhitelistResponse> ModifyUserIPSWhitelistAsync(ModifyUserIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenConfigureResponse
        /// </returns>
        public ModifyVpcFirewallCenConfigureResponse ModifyVpcFirewallCenConfigure(ModifyVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenConfigure operation to modify the configurations of a VPC firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenConfigureResponse
        /// </returns>
        public async Task<ModifyVpcFirewallCenConfigureResponse> ModifyVpcFirewallCenConfigureAsync(ModifyVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
        /// Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenSwitchStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenSwitchStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
        /// Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenSwitchStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenSwitchStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
        /// Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenSwitchStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenSwitchStatusResponse
        /// </returns>
        public ModifyVpcFirewallCenSwitchStatusResponse ModifyVpcFirewallCenSwitchStatus(ModifyVpcFirewallCenSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallCenSwitchStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallCenSwitchStatus operation to enable or disable a VPC firewall. A VPC firewall protects mutual access traffic between a specified VPC and a network instance that is attached to a CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. After you enable the VPC firewall, the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance. After you disable the VPC firewall, the VPC firewall no longer protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance.
        /// Before you call this operation, make sure that you have created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/345772.html">CreateVpcFirewallCenConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallCenSwitchStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallCenSwitchStatusResponse
        /// </returns>
        public async Task<ModifyVpcFirewallCenSwitchStatusResponse> ModifyVpcFirewallCenSwitchStatusAsync(ModifyVpcFirewallCenSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallCenSwitchStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallConfigureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallConfigureResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallConfigureResponse
        /// </returns>
        public ModifyVpcFirewallConfigureResponse ModifyVpcFirewallConfigure(ModifyVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallConfigureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a virtual private cloud (VPC) firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallConfigure operation to modify the configurations of a VPC firewall. The VPC firewall controls traffic between two VPCs that are connected by using an Express Connect circuit. Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallConfigureRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallConfigureResponse
        /// </returns>
        public async Task<ModifyVpcFirewallConfigureResponse> ModifyVpcFirewallConfigureAsync(ModifyVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyResponse
        /// </returns>
        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicy(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of an access control policy that is created for a virtual private cloud (VPC) firewall in a specified policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallControlPolicy operation to modify the configurations of an access control policy that is created for a VPC firewall in a specified policy group. Different access control policies are used for the VPC firewalls that are used to protect each Cloud Enterprise Network (CEN) instance and the VPC firewalls that are used to protect each Express Connect circuit.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyResponse
        /// </returns>
        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyAsync(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyPositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyPositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyPositionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyPositionResponse
        /// </returns>
        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPosition(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyPositionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the priority of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this operation to modify the priority of an access control policy that is created for a VPC firewall in a specific policy group.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallControlPolicyPositionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallControlPolicyPositionResponse
        /// </returns>
        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionAsync(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallDefaultIPSConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallDefaultIPSConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallDefaultIPSConfigResponse
        /// </returns>
        public ModifyVpcFirewallDefaultIPSConfigResponse ModifyVpcFirewallDefaultIPSConfig(ModifyVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallDefaultIPSConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the intrusion prevention configurations of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the intrusion prevention configurations of a VPC firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallDefaultIPSConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallDefaultIPSConfigResponse
        /// </returns>
        public async Task<ModifyVpcFirewallDefaultIPSConfigResponse> ModifyVpcFirewallDefaultIPSConfigAsync(ModifyVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallIPSWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallIPSWhitelistResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallIPSWhitelistResponse
        /// </returns>
        public ModifyVpcFirewallIPSWhitelistResponse ModifyVpcFirewallIPSWhitelist(ModifyVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallIPSWhitelistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IPS whitelist of a virtual private cloud (VPC) firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallIPSWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallIPSWhitelistResponse
        /// </returns>
        public async Task<ModifyVpcFirewallIPSWhitelistResponse> ModifyVpcFirewallIPSWhitelistAsync(ModifyVpcFirewallIPSWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallIPSWhitelistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
        /// Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallSwitchStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallSwitchStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
        /// Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallSwitchStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallSwitchStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
        /// Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallSwitchStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallSwitchStatusResponse
        /// </returns>
        public ModifyVpcFirewallSwitchStatusResponse ModifyVpcFirewallSwitchStatus(ModifyVpcFirewallSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallSwitchStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a virtual private cloud (VPC) firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ModifyVpcFirewallSwitchStatus operation to enable or disable a VPC firewall. The VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit. After you enable the VPC firewall, the VPC firewall protects access traffic between two VPCs that are connected by using an Express Connect circuit. After you disable the VPC firewall, the VPC firewall no longer protects access traffic between two VPCs that are connected by using an Express Connect circuit.
        /// Before you call the operation, make sure that you created a VPC firewall by calling the <a href="https://help.aliyun.com/document_detail/342893.html">CreateVpcFirewallConfigure</a> operation.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcFirewallSwitchStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcFirewallSwitchStatusResponse
        /// </returns>
        public async Task<ModifyVpcFirewallSwitchStatusResponse> ModifyVpcFirewallSwitchStatusAsync(ModifyVpcFirewallSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallSwitchStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Turns off all firewall switches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.</para>
        /// <h2><a href="#qps-"></a>QPS limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableAllFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutDisableAllFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Turns off all firewall switches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.</para>
        /// <h2><a href="#qps-"></a>QPS limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableAllFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutDisableAllFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Turns off all firewall switches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.</para>
        /// <h2><a href="#qps-"></a>QPS limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableAllFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutDisableAllFwSwitchResponse
        /// </returns>
        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitch(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableAllFwSwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Turns off all firewall switches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableAllFwSwitch operation to turn off all firewall switches.</para>
        /// <h2><a href="#qps-"></a>QPS limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableAllFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutDisableAllFwSwitchResponse
        /// </returns>
        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchAsync(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disable a firewall for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutDisableFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disable a firewall for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutDisableFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disable a firewall for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutDisableFwSwitchResponse
        /// </returns>
        public PutDisableFwSwitchResponse PutDisableFwSwitch(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableFwSwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disable a firewall for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutDisableFwSwitch operation to disable a firewall for specific assets. After you disable the firewall, traffic does not pass through Cloud Firewall.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutDisableFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutDisableFwSwitchResponse
        /// </returns>
        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchAsync(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableFwSwitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall for all public IP addresses within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableAllFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutEnableAllFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall for all public IP addresses within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableAllFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutEnableAllFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall for all public IP addresses within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableAllFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutEnableAllFwSwitchResponse
        /// </returns>
        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitch(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableAllFwSwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall for all public IP addresses within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the PutEnableAllFwSwitch operation to enable a firewall for all public IP addresses within your Alibaba Cloud account.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableAllFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutEnableAllFwSwitchResponse
        /// </returns>
        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchAsync(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables firewalls for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutEnableFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables firewalls for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableFwSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutEnableFwSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables firewalls for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutEnableFwSwitchResponse
        /// </returns>
        public PutEnableFwSwitchResponse PutEnableFwSwitch(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableFwSwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables firewalls for specific assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to enable a firewall. After you enable a firewall, traffic passes through Cloud Firewall.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEnableFwSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// PutEnableFwSwitchResponse
        /// </returns>
        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchAsync(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableFwSwitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases Cloud Firewall that uses the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleasePostInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleasePostInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases Cloud Firewall that uses the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleasePostInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleasePostInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases Cloud Firewall that uses the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleasePostInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleasePostInstanceResponse
        /// </returns>
        public ReleasePostInstanceResponse ReleasePostInstance(ReleasePostInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePostInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases Cloud Firewall that uses the pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleasePostInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleasePostInstanceResponse
        /// </returns>
        public async Task<ReleasePostInstanceResponse> ReleasePostInstanceAsync(ReleasePostInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePostInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the number of NAT firewall hits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetNatFirewallRuleHitCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetNatFirewallRuleHitCountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the number of NAT firewall hits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetNatFirewallRuleHitCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetNatFirewallRuleHitCountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the number of NAT firewall hits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetNatFirewallRuleHitCountRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetNatFirewallRuleHitCountResponse
        /// </returns>
        public ResetNatFirewallRuleHitCountResponse ResetNatFirewallRuleHitCount(ResetNatFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetNatFirewallRuleHitCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the number of NAT firewall hits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetNatFirewallRuleHitCountRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetNatFirewallRuleHitCountResponse
        /// </returns>
        public async Task<ResetNatFirewallRuleHitCountResponse> ResetNatFirewallRuleHitCountAsync(ResetNatFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetNatFirewallRuleHitCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetVpcFirewallRuleHitCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetVpcFirewallRuleHitCountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetVpcFirewallRuleHitCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetVpcFirewallRuleHitCountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetVpcFirewallRuleHitCountRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetVpcFirewallRuleHitCountResponse
        /// </returns>
        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCount(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetVpcFirewallRuleHitCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the count on hits of an access control policy that is created for a virtual private cloud (VPC) firewall in a specific policy group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ResetVpcFirewallRuleHitCount operation to clear the count on hits of an access control policy that is created for a VPC firewall in a specific policy group.  </para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetVpcFirewallRuleHitCountRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetVpcFirewallRuleHitCountResponse
        /// </returns>
        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountAsync(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetVpcFirewallRuleHitCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchSecurityProxyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SwitchSecurityProxyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchSecurityProxyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SwitchSecurityProxyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchSecurityProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// SwitchSecurityProxyResponse
        /// </returns>
        public SwitchSecurityProxyResponse SwitchSecurityProxy(SwitchSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchSecurityProxyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a NAT firewall.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SwitchSecurityProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// SwitchSecurityProxyResponse
        /// </returns>
        public async Task<SwitchSecurityProxyResponse> SwitchSecurityProxyAsync(SwitchSecurityProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchSecurityProxyWithOptionsAsync(request, runtime);
        }

    }
}
