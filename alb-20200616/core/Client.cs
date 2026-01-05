// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alb20200616.Models;

namespace AlibabaCloud.SDK.Alb20200616
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("alb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>  Each ACL can contain IP addresses or CIDR blocks. Take note of the following limits on ACLs:
        ///     *   The maximum number of IP entries that can be added to an ACL with each Alibaba Cloud account at a time: 20
        ///     *   The maximum number of IP entries that each ACL can contain: 1,000</para>
        /// <list type="bullet">
        /// <item><description><b>AddEntriesToAcl</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ACL is in the <b>Adding</b> state, the IP entries are being added.</description></item>
        /// <item><description>If the ACL is in the <b>Available</b> state, the IP entries are added.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddEntriesToAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddEntriesToAclResponse
        /// </returns>
        public AddEntriesToAclResponse AddEntriesToAclWithOptions(AddEntriesToAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntries))
            {
                query["AclEntries"] = request.AclEntries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEntriesToAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEntriesToAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each ACL can contain IP addresses or CIDR blocks. Take note of the following limits on ACLs:
        ///     *   The maximum number of IP entries that can be added to an ACL with each Alibaba Cloud account at a time: 20
        ///     *   The maximum number of IP entries that each ACL can contain: 1,000</para>
        /// <list type="bullet">
        /// <item><description><b>AddEntriesToAcl</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ACL is in the <b>Adding</b> state, the IP entries are being added.</description></item>
        /// <item><description>If the ACL is in the <b>Available</b> state, the IP entries are added.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddEntriesToAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddEntriesToAclResponse
        /// </returns>
        public async Task<AddEntriesToAclResponse> AddEntriesToAclWithOptionsAsync(AddEntriesToAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclEntries))
            {
                query["AclEntries"] = request.AclEntries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEntriesToAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEntriesToAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each ACL can contain IP addresses or CIDR blocks. Take note of the following limits on ACLs:
        ///     *   The maximum number of IP entries that can be added to an ACL with each Alibaba Cloud account at a time: 20
        ///     *   The maximum number of IP entries that each ACL can contain: 1,000</para>
        /// <list type="bullet">
        /// <item><description><b>AddEntriesToAcl</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ACL is in the <b>Adding</b> state, the IP entries are being added.</description></item>
        /// <item><description>If the ACL is in the <b>Available</b> state, the IP entries are added.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddEntriesToAclRequest
        /// </param>
        /// 
        /// <returns>
        /// AddEntriesToAclResponse
        /// </returns>
        public AddEntriesToAclResponse AddEntriesToAcl(AddEntriesToAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEntriesToAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds IP entries to an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each ACL can contain IP addresses or CIDR blocks. Take note of the following limits on ACLs:
        ///     *   The maximum number of IP entries that can be added to an ACL with each Alibaba Cloud account at a time: 20
        ///     *   The maximum number of IP entries that each ACL can contain: 1,000</para>
        /// <list type="bullet">
        /// <item><description><b>AddEntriesToAcl</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ACL is in the <b>Adding</b> state, the IP entries are being added.</description></item>
        /// <item><description>If the ACL is in the <b>Available</b> state, the IP entries are added.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddEntriesToAclRequest
        /// </param>
        /// 
        /// <returns>
        /// AddEntriesToAclResponse
        /// </returns>
        public async Task<AddEntriesToAclResponse> AddEntriesToAclAsync(AddEntriesToAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEntriesToAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds backend servers to a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a backend server is in the <b>Adding</b> state, it indicates that the backend server is being added to a server group.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the server is running.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                query["Servers"] = request.Servers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddServersToServerGroup",
                Version = "2020-06-16",
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
        /// <para>Adds backend servers to a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a backend server is in the <b>Adding</b> state, it indicates that the backend server is being added to a server group.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the server is running.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                query["Servers"] = request.Servers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddServersToServerGroup",
                Version = "2020-06-16",
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
        /// <para>Adds backend servers to a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a backend server is in the <b>Adding</b> state, it indicates that the backend server is being added to a server group.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the server is running.</description></item>
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
        /// <para>Adds backend servers to a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AddServersToServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// <ol start="2">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>If a backend server is in the <b>Adding</b> state, it indicates that the backend server is being added to a server group.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the server is running.</description></item>
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
        /// <para>Applies a health check template to a server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyHealthCheckTemplateToServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyHealthCheckTemplateToServerGroupResponse
        /// </returns>
        public ApplyHealthCheckTemplateToServerGroupResponse ApplyHealthCheckTemplateToServerGroupWithOptions(ApplyHealthCheckTemplateToServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateId))
            {
                query["HealthCheckTemplateId"] = request.HealthCheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyHealthCheckTemplateToServerGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyHealthCheckTemplateToServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies a health check template to a server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyHealthCheckTemplateToServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyHealthCheckTemplateToServerGroupResponse
        /// </returns>
        public async Task<ApplyHealthCheckTemplateToServerGroupResponse> ApplyHealthCheckTemplateToServerGroupWithOptionsAsync(ApplyHealthCheckTemplateToServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateId))
            {
                query["HealthCheckTemplateId"] = request.HealthCheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyHealthCheckTemplateToServerGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyHealthCheckTemplateToServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies a health check template to a server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyHealthCheckTemplateToServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyHealthCheckTemplateToServerGroupResponse
        /// </returns>
        public ApplyHealthCheckTemplateToServerGroupResponse ApplyHealthCheckTemplateToServerGroup(ApplyHealthCheckTemplateToServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyHealthCheckTemplateToServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies a health check template to a server group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyHealthCheckTemplateToServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyHealthCheckTemplateToServerGroupResponse
        /// </returns>
        public async Task<ApplyHealthCheckTemplateToServerGroupResponse> ApplyHealthCheckTemplateToServerGroupAsync(ApplyHealthCheckTemplateToServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyHealthCheckTemplateToServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates access control lists (ACLs) with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteDhcpOptionsSet</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Associating</b> state, the ACL is being associated with a listener.</description></item>
        /// <item><description>If an ACL is in the <b>Associated</b> state, the ACL is associated with a listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAclsWithListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateAclsWithListenerResponse
        /// </returns>
        public AssociateAclsWithListenerResponse AssociateAclsWithListenerWithOptions(AssociateAclsWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAclsWithListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAclsWithListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates access control lists (ACLs) with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteDhcpOptionsSet</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Associating</b> state, the ACL is being associated with a listener.</description></item>
        /// <item><description>If an ACL is in the <b>Associated</b> state, the ACL is associated with a listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAclsWithListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateAclsWithListenerResponse
        /// </returns>
        public async Task<AssociateAclsWithListenerResponse> AssociateAclsWithListenerWithOptionsAsync(AssociateAclsWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclType))
            {
                query["AclType"] = request.AclType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAclsWithListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAclsWithListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates access control lists (ACLs) with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteDhcpOptionsSet</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Associating</b> state, the ACL is being associated with a listener.</description></item>
        /// <item><description>If an ACL is in the <b>Associated</b> state, the ACL is associated with a listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAclsWithListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateAclsWithListenerResponse
        /// </returns>
        public AssociateAclsWithListenerResponse AssociateAclsWithListener(AssociateAclsWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateAclsWithListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates access control lists (ACLs) with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteDhcpOptionsSet</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Associating</b> state, the ACL is being associated with a listener.</description></item>
        /// <item><description>If an ACL is in the <b>Associated</b> state, the ACL is associated with a listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAclsWithListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateAclsWithListenerResponse
        /// </returns>
        public async Task<AssociateAclsWithListenerResponse> AssociateAclsWithListenerAsync(AssociateAclsWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateAclsWithListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates additional certificates with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AssociateAdditionalCertificatesWithListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associating</b> state, the additional certificates are being associated.</description></item>
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associated</b> state, the additional certificates are associated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAdditionalCertificatesWithListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateAdditionalCertificatesWithListenerResponse
        /// </returns>
        public AssociateAdditionalCertificatesWithListenerResponse AssociateAdditionalCertificatesWithListenerWithOptions(AssociateAdditionalCertificatesWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAdditionalCertificatesWithListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAdditionalCertificatesWithListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates additional certificates with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AssociateAdditionalCertificatesWithListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associating</b> state, the additional certificates are being associated.</description></item>
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associated</b> state, the additional certificates are associated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAdditionalCertificatesWithListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateAdditionalCertificatesWithListenerResponse
        /// </returns>
        public async Task<AssociateAdditionalCertificatesWithListenerResponse> AssociateAdditionalCertificatesWithListenerWithOptionsAsync(AssociateAdditionalCertificatesWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAdditionalCertificatesWithListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAdditionalCertificatesWithListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates additional certificates with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AssociateAdditionalCertificatesWithListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associating</b> state, the additional certificates are being associated.</description></item>
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associated</b> state, the additional certificates are associated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAdditionalCertificatesWithListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateAdditionalCertificatesWithListenerResponse
        /// </returns>
        public AssociateAdditionalCertificatesWithListenerResponse AssociateAdditionalCertificatesWithListener(AssociateAdditionalCertificatesWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateAdditionalCertificatesWithListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates additional certificates with a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AssociateAdditionalCertificatesWithListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associating</b> state, the additional certificates are being associated.</description></item>
        /// <item><description>If the HTTPS or QUIC listener is in the <b>Associated</b> state, the additional certificates are associated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateAdditionalCertificatesWithListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateAdditionalCertificatesWithListenerResponse
        /// </returns>
        public async Task<AssociateAdditionalCertificatesWithListenerResponse> AssociateAdditionalCertificatesWithListenerAsync(AssociateAdditionalCertificatesWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateAdditionalCertificatesWithListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an EIP bandwidth plan with an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AttachCommonBandwidthPackageToLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being associated with the ALB instance.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is associated with the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachCommonBandwidthPackageToLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachCommonBandwidthPackageToLoadBalancerResponse
        /// </returns>
        public AttachCommonBandwidthPackageToLoadBalancerResponse AttachCommonBandwidthPackageToLoadBalancerWithOptions(AttachCommonBandwidthPackageToLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "AttachCommonBandwidthPackageToLoadBalancer",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachCommonBandwidthPackageToLoadBalancerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an EIP bandwidth plan with an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AttachCommonBandwidthPackageToLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being associated with the ALB instance.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is associated with the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachCommonBandwidthPackageToLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachCommonBandwidthPackageToLoadBalancerResponse
        /// </returns>
        public async Task<AttachCommonBandwidthPackageToLoadBalancerResponse> AttachCommonBandwidthPackageToLoadBalancerWithOptionsAsync(AttachCommonBandwidthPackageToLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "AttachCommonBandwidthPackageToLoadBalancer",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachCommonBandwidthPackageToLoadBalancerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an EIP bandwidth plan with an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AttachCommonBandwidthPackageToLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being associated with the ALB instance.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is associated with the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachCommonBandwidthPackageToLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachCommonBandwidthPackageToLoadBalancerResponse
        /// </returns>
        public AttachCommonBandwidthPackageToLoadBalancerResponse AttachCommonBandwidthPackageToLoadBalancer(AttachCommonBandwidthPackageToLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachCommonBandwidthPackageToLoadBalancerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates an EIP bandwidth plan with an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>AttachCommonBandwidthPackageToLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being associated with the ALB instance.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is associated with the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachCommonBandwidthPackageToLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachCommonBandwidthPackageToLoadBalancerResponse
        /// </returns>
        public async Task<AttachCommonBandwidthPackageToLoadBalancerResponse> AttachCommonBandwidthPackageToLoadBalancerAsync(AttachCommonBandwidthPackageToLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachCommonBandwidthPackageToLoadBalancerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the elastic IP address (EIP) and virtual IP address (VIP) of a zone to a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only by Application Load Balancer (ALB) instances that use static IP addresses. Before you call this operation, you must call the StartShiftLoadBalancerZones operation to remove the zone from the ALB instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelShiftLoadBalancerZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelShiftLoadBalancerZonesResponse
        /// </returns>
        public CancelShiftLoadBalancerZonesResponse CancelShiftLoadBalancerZonesWithOptions(CancelShiftLoadBalancerZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelShiftLoadBalancerZones",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelShiftLoadBalancerZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the elastic IP address (EIP) and virtual IP address (VIP) of a zone to a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only by Application Load Balancer (ALB) instances that use static IP addresses. Before you call this operation, you must call the StartShiftLoadBalancerZones operation to remove the zone from the ALB instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelShiftLoadBalancerZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelShiftLoadBalancerZonesResponse
        /// </returns>
        public async Task<CancelShiftLoadBalancerZonesResponse> CancelShiftLoadBalancerZonesWithOptionsAsync(CancelShiftLoadBalancerZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelShiftLoadBalancerZones",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelShiftLoadBalancerZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the elastic IP address (EIP) and virtual IP address (VIP) of a zone to a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only by Application Load Balancer (ALB) instances that use static IP addresses. Before you call this operation, you must call the StartShiftLoadBalancerZones operation to remove the zone from the ALB instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelShiftLoadBalancerZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelShiftLoadBalancerZonesResponse
        /// </returns>
        public CancelShiftLoadBalancerZonesResponse CancelShiftLoadBalancerZones(CancelShiftLoadBalancerZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelShiftLoadBalancerZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the elastic IP address (EIP) and virtual IP address (VIP) of a zone to a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only by Application Load Balancer (ALB) instances that use static IP addresses. Before you call this operation, you must call the StartShiftLoadBalancerZones operation to remove the zone from the ALB instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelShiftLoadBalancerZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelShiftLoadBalancerZonesResponse
        /// </returns>
        public async Task<CancelShiftLoadBalancerZonesResponse> CancelShiftLoadBalancerZonesAsync(CancelShiftLoadBalancerZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelShiftLoadBalancerZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A standard or WAF-enabled Application Load Balancer (ALB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para><b>CreateAScripts</b> an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of a script.</para>
        /// <list type="bullet">
        /// <item><description>If the script is in the <b>Creating</b> state, the script is being created.</description></item>
        /// <item><description>If the script is in the <b>Available</b>, the script is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAScriptsResponse
        /// </returns>
        public CreateAScriptsResponse CreateAScriptsWithOptions(CreateAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScripts))
            {
                query["AScripts"] = request.AScripts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAScriptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A standard or WAF-enabled Application Load Balancer (ALB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para><b>CreateAScripts</b> an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of a script.</para>
        /// <list type="bullet">
        /// <item><description>If the script is in the <b>Creating</b> state, the script is being created.</description></item>
        /// <item><description>If the script is in the <b>Available</b>, the script is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAScriptsResponse
        /// </returns>
        public async Task<CreateAScriptsResponse> CreateAScriptsWithOptionsAsync(CreateAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScripts))
            {
                query["AScripts"] = request.AScripts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A standard or WAF-enabled Application Load Balancer (ALB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para><b>CreateAScripts</b> an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of a script.</para>
        /// <list type="bullet">
        /// <item><description>If the script is in the <b>Creating</b> state, the script is being created.</description></item>
        /// <item><description>If the script is in the <b>Available</b>, the script is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAScriptsResponse
        /// </returns>
        public CreateAScriptsResponse CreateAScripts(CreateAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAScriptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>A standard or WAF-enabled Application Load Balancer (ALB) instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para><b>CreateAScripts</b> an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of a script.</para>
        /// <list type="bullet">
        /// <item><description>If the script is in the <b>Creating</b> state, the script is being created.</description></item>
        /// <item><description>If the script is in the <b>Available</b>, the script is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAScriptsResponse
        /// </returns>
        public async Task<CreateAScriptsResponse> CreateAScriptsAsync(CreateAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAScriptsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>The <b>CreateAcl</b> operation is asynchronous. After you send a request, the system returns a request ID. However, the operation is still being performed in the system background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of an ACL:</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Creating</b> state, the ACL is being created.</description></item>
        /// <item><description>If an ACL is in the <b>Available</b> state, the ACL is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public CreateAclResponse CreateAclWithOptions(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "CreateAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>The <b>CreateAcl</b> operation is asynchronous. After you send a request, the system returns a request ID. However, the operation is still being performed in the system background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of an ACL:</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Creating</b> state, the ACL is being created.</description></item>
        /// <item><description>If an ACL is in the <b>Available</b> state, the ACL is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public async Task<CreateAclResponse> CreateAclWithOptionsAsync(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclName))
            {
                query["AclName"] = request.AclName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "CreateAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>The <b>CreateAcl</b> operation is asynchronous. After you send a request, the system returns a request ID. However, the operation is still being performed in the system background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of an ACL:</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Creating</b> state, the ACL is being created.</description></item>
        /// <item><description>If an ACL is in the <b>Available</b> state, the ACL is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public CreateAclResponse CreateAcl(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>The <b>CreateAcl</b> operation is asynchronous. After you send a request, the system returns a request ID. However, the operation is still being performed in the system background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of an ACL:</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Creating</b> state, the ACL is being created.</description></item>
        /// <item><description>If an ACL is in the <b>Available</b> state, the ACL is created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public async Task<CreateAclResponse> CreateAclAsync(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a health check template in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHealthCheckTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHealthCheckTemplateResponse
        /// </returns>
        public CreateHealthCheckTemplateResponse CreateHealthCheckTemplateWithOptions(CreateHealthCheckTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckCodes))
            {
                query["HealthCheckCodes"] = request.HealthCheckCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHost))
            {
                query["HealthCheckHost"] = request.HealthCheckHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpVersion))
            {
                query["HealthCheckHttpVersion"] = request.HealthCheckHttpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckPath))
            {
                query["HealthCheckPath"] = request.HealthCheckPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckProtocol))
            {
                query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateName))
            {
                query["HealthCheckTemplateName"] = request.HealthCheckTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHealthCheckTemplate",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHealthCheckTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a health check template in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHealthCheckTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHealthCheckTemplateResponse
        /// </returns>
        public async Task<CreateHealthCheckTemplateResponse> CreateHealthCheckTemplateWithOptionsAsync(CreateHealthCheckTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckCodes))
            {
                query["HealthCheckCodes"] = request.HealthCheckCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHost))
            {
                query["HealthCheckHost"] = request.HealthCheckHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpVersion))
            {
                query["HealthCheckHttpVersion"] = request.HealthCheckHttpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckPath))
            {
                query["HealthCheckPath"] = request.HealthCheckPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckProtocol))
            {
                query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateName))
            {
                query["HealthCheckTemplateName"] = request.HealthCheckTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHealthCheckTemplate",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHealthCheckTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a health check template in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHealthCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHealthCheckTemplateResponse
        /// </returns>
        public CreateHealthCheckTemplateResponse CreateHealthCheckTemplate(CreateHealthCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHealthCheckTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a health check template in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateHealthCheckTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHealthCheckTemplateResponse
        /// </returns>
        public async Task<CreateHealthCheckTemplateResponse> CreateHealthCheckTemplateAsync(CreateHealthCheckTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHealthCheckTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para><b>CreateListener</b> is an asynchronous operation. After you call this operation, the system returns a request ID. However, the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/214353.html">GetListenerAttribute</a> operation to query the status of the HTTP, HTTPS, or QUIC listener.</para>
        /// <list type="bullet">
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Provisioning</b> state, it indicates that the listener is being created.</description></item>
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Running</b> state, it indicates that the listener has been created successfully.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertificates))
            {
                query["CaCertificates"] = request.CaCertificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaEnabled))
            {
                query["CaEnabled"] = request.CaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultActions))
            {
                query["DefaultActions"] = request.DefaultActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GzipEnabled))
            {
                query["GzipEnabled"] = request.GzipEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Enabled))
            {
                query["Http2Enabled"] = request.Http2Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                query["ListenerDescription"] = request.ListenerDescription;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuicConfig))
            {
                query["QuicConfig"] = request.QuicConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedForConfig))
            {
                query["XForwardedForConfig"] = request.XForwardedForConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateListener",
                Version = "2020-06-16",
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
        /// <para>Creates a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para><b>CreateListener</b> is an asynchronous operation. After you call this operation, the system returns a request ID. However, the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/214353.html">GetListenerAttribute</a> operation to query the status of the HTTP, HTTPS, or QUIC listener.</para>
        /// <list type="bullet">
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Provisioning</b> state, it indicates that the listener is being created.</description></item>
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Running</b> state, it indicates that the listener has been created successfully.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertificates))
            {
                query["CaCertificates"] = request.CaCertificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaEnabled))
            {
                query["CaEnabled"] = request.CaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultActions))
            {
                query["DefaultActions"] = request.DefaultActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GzipEnabled))
            {
                query["GzipEnabled"] = request.GzipEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Enabled))
            {
                query["Http2Enabled"] = request.Http2Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                query["ListenerDescription"] = request.ListenerDescription;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuicConfig))
            {
                query["QuicConfig"] = request.QuicConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedForConfig))
            {
                query["XForwardedForConfig"] = request.XForwardedForConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateListener",
                Version = "2020-06-16",
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
        /// <para>Creates a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para><b>CreateListener</b> is an asynchronous operation. After you call this operation, the system returns a request ID. However, the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/214353.html">GetListenerAttribute</a> operation to query the status of the HTTP, HTTPS, or QUIC listener.</para>
        /// <list type="bullet">
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Provisioning</b> state, it indicates that the listener is being created.</description></item>
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Running</b> state, it indicates that the listener has been created successfully.</description></item>
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
        /// <para>Creates a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para><b>CreateListener</b> is an asynchronous operation. After you call this operation, the system returns a request ID. However, the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/214353.html">GetListenerAttribute</a> operation to query the status of the HTTP, HTTPS, or QUIC listener.</para>
        /// <list type="bullet">
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Provisioning</b> state, it indicates that the listener is being created.</description></item>
        /// <item><description>If the HTTP, HTTPS, or QUIC listener is in the <b>Running</b> state, it indicates that the listener has been created successfully.</description></item>
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
        /// <para>Creates an Application Load Balancer (ALB) instance in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Provisioning</b> state, it indicates that the ALB instance is being created.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, it indicates that the ALB instance is created.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressAllocatedMode))
            {
                query["AddressAllocatedMode"] = request.AddressAllocatedMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtectionEnabled))
            {
                query["DeletionProtectionEnabled"] = request.DeletionProtectionEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerBillingConfig))
            {
                query["LoadBalancerBillingConfig"] = request.LoadBalancerBillingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerEdition))
            {
                query["LoadBalancerEdition"] = request.LoadBalancerEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionConfig))
            {
                query["ModificationProtectionConfig"] = request.ModificationProtectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancer",
                Version = "2020-06-16",
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
        /// <para>Creates an Application Load Balancer (ALB) instance in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Provisioning</b> state, it indicates that the ALB instance is being created.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, it indicates that the ALB instance is created.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressAllocatedMode))
            {
                query["AddressAllocatedMode"] = request.AddressAllocatedMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtectionEnabled))
            {
                query["DeletionProtectionEnabled"] = request.DeletionProtectionEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerBillingConfig))
            {
                query["LoadBalancerBillingConfig"] = request.LoadBalancerBillingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerEdition))
            {
                query["LoadBalancerEdition"] = request.LoadBalancerEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionConfig))
            {
                query["ModificationProtectionConfig"] = request.ModificationProtectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoadBalancer",
                Version = "2020-06-16",
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
        /// <para>Creates an Application Load Balancer (ALB) instance in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Provisioning</b> state, it indicates that the ALB instance is being created.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, it indicates that the ALB instance is created.</description></item>
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
        /// <para>Creates an Application Load Balancer (ALB) instance in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Provisioning</b> state, it indicates that the ALB instance is being created.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, it indicates that the ALB instance is created.</description></item>
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
        /// <para>Creates a forwarding rule for a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, you can use the default value only for the <b>HttpCode</b> parameter. Do not use the default values for the other parameters.</description></item>
        /// <item><description>If you specify the <b>Rewrite</b> action together with other actions in a forwarding rule, make sure that the <b>ForwardGroup</b> action is specified.</description></item>
        /// <item><description><b>CreateRule</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule.<list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Provisioning</b> state, the forwarding rule is being created.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. The limits on conditions and actions are:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleActions))
            {
                query["RuleActions"] = request.RuleActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConditions))
            {
                query["RuleConditions"] = request.RuleConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
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
                Action = "CreateRule",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a forwarding rule for a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, you can use the default value only for the <b>HttpCode</b> parameter. Do not use the default values for the other parameters.</description></item>
        /// <item><description>If you specify the <b>Rewrite</b> action together with other actions in a forwarding rule, make sure that the <b>ForwardGroup</b> action is specified.</description></item>
        /// <item><description><b>CreateRule</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule.<list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Provisioning</b> state, the forwarding rule is being created.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. The limits on conditions and actions are:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleActions))
            {
                query["RuleActions"] = request.RuleActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConditions))
            {
                query["RuleConditions"] = request.RuleConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
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
                Action = "CreateRule",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a forwarding rule for a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, you can use the default value only for the <b>HttpCode</b> parameter. Do not use the default values for the other parameters.</description></item>
        /// <item><description>If you specify the <b>Rewrite</b> action together with other actions in a forwarding rule, make sure that the <b>ForwardGroup</b> action is specified.</description></item>
        /// <item><description><b>CreateRule</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule.<list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Provisioning</b> state, the forwarding rule is being created.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. The limits on conditions and actions are:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a forwarding rule for a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, you can use the default value only for the <b>HttpCode</b> parameter. Do not use the default values for the other parameters.</description></item>
        /// <item><description>If you specify the <b>Rewrite</b> action together with other actions in a forwarding rule, make sure that the <b>ForwardGroup</b> action is specified.</description></item>
        /// <item><description><b>CreateRule</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule.<list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Provisioning</b> state, the forwarding rule is being created.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. The limits on conditions and actions are:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple forwarding rules at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, do not use the default values for parameters other than <b>HttpCode</b>.</description></item>
        /// <item><description>If you specify multiple actions in a forward rule, you must specify the <b>ForwardGroup</b> parameter along with the <b>Rewrite</b> parameter.</description></item>
        /// <item><description><b>CreateRules</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the forwarding rules.<list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Provisioning</b> state, the forwarding rules are being created.</description></item>
        /// <item><description>If the forwarding rules are in the <b>Available</b> state, the forwarding rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Conditions: 5 for each basic ALB instance, 10 for each standard ALB instance, and 10 for each WAF-enabled ALB instance.</description></item>
        /// <item><description>Actions: 3 for each basic ALB instance, 5 for each standard ALB instance, and 5 for each WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                bodyFlat["Rules"] = request.Rules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRules",
                Version = "2020-06-16",
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
        /// <para>Creates multiple forwarding rules at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, do not use the default values for parameters other than <b>HttpCode</b>.</description></item>
        /// <item><description>If you specify multiple actions in a forward rule, you must specify the <b>ForwardGroup</b> parameter along with the <b>Rewrite</b> parameter.</description></item>
        /// <item><description><b>CreateRules</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the forwarding rules.<list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Provisioning</b> state, the forwarding rules are being created.</description></item>
        /// <item><description>If the forwarding rules are in the <b>Available</b> state, the forwarding rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Conditions: 5 for each basic ALB instance, 10 for each standard ALB instance, and 10 for each WAF-enabled ALB instance.</description></item>
        /// <item><description>Actions: 3 for each basic ALB instance, 5 for each standard ALB instance, and 5 for each WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                bodyFlat["Rules"] = request.Rules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRules",
                Version = "2020-06-16",
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
        /// <para>Creates multiple forwarding rules at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, do not use the default values for parameters other than <b>HttpCode</b>.</description></item>
        /// <item><description>If you specify multiple actions in a forward rule, you must specify the <b>ForwardGroup</b> parameter along with the <b>Rewrite</b> parameter.</description></item>
        /// <item><description><b>CreateRules</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the forwarding rules.<list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Provisioning</b> state, the forwarding rules are being created.</description></item>
        /// <item><description>If the forwarding rules are in the <b>Available</b> state, the forwarding rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Conditions: 5 for each basic ALB instance, 10 for each standard ALB instance, and 10 for each WAF-enabled ALB instance.</description></item>
        /// <item><description>Actions: 3 for each basic ALB instance, 5 for each standard ALB instance, and 5 for each WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates multiple forwarding rules at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>When you configure the <b>Redirect</b> action, do not use the default values for parameters other than <b>HttpCode</b>.</description></item>
        /// <item><description>If you specify multiple actions in a forward rule, you must specify the <b>ForwardGroup</b> parameter along with the <b>Rewrite</b> parameter.</description></item>
        /// <item><description><b>CreateRules</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the forwarding rules.<list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Provisioning</b> state, the forwarding rules are being created.</description></item>
        /// <item><description>If the forwarding rules are in the <b>Available</b> state, the forwarding rules are created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Conditions: 5 for each basic ALB instance, 10 for each standard ALB instance, and 10 for each WAF-enabled ALB instance.</description></item>
        /// <item><description>Actions: 3 for each basic ALB instance, 5 for each standard ALB instance, and 5 for each WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates a custom security policy in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityPolicyResponse
        /// </returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicyWithOptions(CreateSecurityPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyName))
            {
                query["SecurityPolicyName"] = request.SecurityPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSVersions))
            {
                query["TLSVersions"] = request.TLSVersions;
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
                Action = "CreateSecurityPolicy",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecurityPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom security policy in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityPolicyResponse
        /// </returns>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicyWithOptionsAsync(CreateSecurityPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyName))
            {
                query["SecurityPolicyName"] = request.SecurityPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TLSVersions))
            {
                query["TLSVersions"] = request.TLSVersions;
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
                Action = "CreateSecurityPolicy",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecurityPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom security policy in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityPolicyResponse
        /// </returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicy(CreateSecurityPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom security policy in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecurityPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecurityPolicyResponse
        /// </returns>
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicyAsync(CreateSecurityPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a server group in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> to query the status of a server group.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                query["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZoneEnabled))
            {
                query["CrossZoneEnabled"] = request.CrossZoneEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                query["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Enabled))
            {
                query["Ipv6Enabled"] = request.Ipv6Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                query["ServerGroupName"] = request.ServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                query["ServerGroupType"] = request.ServerGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlowStartConfig))
            {
                query["SlowStartConfig"] = request.SlowStartConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionConfig))
            {
                query["StickySessionConfig"] = request.StickySessionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UchConfig))
            {
                query["UchConfig"] = request.UchConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpstreamKeepaliveEnabled))
            {
                query["UpstreamKeepaliveEnabled"] = request.UpstreamKeepaliveEnabled;
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
                Action = "CreateServerGroup",
                Version = "2020-06-16",
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
        /// <para>Creates a server group in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> to query the status of a server group.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                query["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZoneEnabled))
            {
                query["CrossZoneEnabled"] = request.CrossZoneEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                query["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Enabled))
            {
                query["Ipv6Enabled"] = request.Ipv6Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                query["ServerGroupName"] = request.ServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                query["ServerGroupType"] = request.ServerGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlowStartConfig))
            {
                query["SlowStartConfig"] = request.SlowStartConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionConfig))
            {
                query["StickySessionConfig"] = request.StickySessionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UchConfig))
            {
                query["UchConfig"] = request.UchConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpstreamKeepaliveEnabled))
            {
                query["UpstreamKeepaliveEnabled"] = request.UpstreamKeepaliveEnabled;
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
                Action = "CreateServerGroup",
                Version = "2020-06-16",
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
        /// <para>Creates a server group in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> to query the status of a server group.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
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
        /// <para>Creates a server group in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>CreateServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> to query the status of a server group.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Creating</b> state, it indicates that the server group is being created.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is created.</description></item>
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
        /// <para>Deletes AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAScripts</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If an AScript rule is in the <b>Deleting</b> state, the AScript rule is being deleted.</description></item>
        /// <item><description>If an AScript rule cannot be found, the AScript rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAScriptsResponse
        /// </returns>
        public DeleteAScriptsResponse DeleteAScriptsWithOptions(DeleteAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScriptIds))
            {
                query["AScriptIds"] = request.AScriptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAScriptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAScripts</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If an AScript rule is in the <b>Deleting</b> state, the AScript rule is being deleted.</description></item>
        /// <item><description>If an AScript rule cannot be found, the AScript rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAScriptsResponse
        /// </returns>
        public async Task<DeleteAScriptsResponse> DeleteAScriptsWithOptionsAsync(DeleteAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScriptIds))
            {
                query["AScriptIds"] = request.AScriptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAScripts</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If an AScript rule is in the <b>Deleting</b> state, the AScript rule is being deleted.</description></item>
        /// <item><description>If an AScript rule cannot be found, the AScript rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAScriptsResponse
        /// </returns>
        public DeleteAScriptsResponse DeleteAScripts(DeleteAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAScriptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAScripts</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If an AScript rule is in the <b>Deleting</b> state, the AScript rule is being deleted.</description></item>
        /// <item><description>If an AScript rule cannot be found, the AScript rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAScriptsResponse
        /// </returns>
        public async Task<DeleteAScriptsResponse> DeleteAScriptsAsync(DeleteAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAScriptsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ACL is in the <b>Deleting</b> state, the ACL is being deleted.</description></item>
        /// <item><description>If the ACL cannot be found, the ACL is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public DeleteAclResponse DeleteAclWithOptions(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ACL is in the <b>Deleting</b> state, the ACL is being deleted.</description></item>
        /// <item><description>If the ACL cannot be found, the ACL is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public async Task<DeleteAclResponse> DeleteAclWithOptionsAsync(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ACL is in the <b>Deleting</b> state, the ACL is being deleted.</description></item>
        /// <item><description>If the ACL cannot be found, the ACL is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public DeleteAclResponse DeleteAcl(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213617.html">ListAcls</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ACL is in the <b>Deleting</b> state, the ACL is being deleted.</description></item>
        /// <item><description>If the ACL cannot be found, the ACL is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public async Task<DeleteAclResponse> DeleteAclAsync(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes health check templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHealthCheckTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHealthCheckTemplatesResponse
        /// </returns>
        public DeleteHealthCheckTemplatesResponse DeleteHealthCheckTemplatesWithOptions(DeleteHealthCheckTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateIds))
            {
                query["HealthCheckTemplateIds"] = request.HealthCheckTemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHealthCheckTemplates",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHealthCheckTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes health check templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHealthCheckTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHealthCheckTemplatesResponse
        /// </returns>
        public async Task<DeleteHealthCheckTemplatesResponse> DeleteHealthCheckTemplatesWithOptionsAsync(DeleteHealthCheckTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateIds))
            {
                query["HealthCheckTemplateIds"] = request.HealthCheckTemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHealthCheckTemplates",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHealthCheckTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes health check templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHealthCheckTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHealthCheckTemplatesResponse
        /// </returns>
        public DeleteHealthCheckTemplatesResponse DeleteHealthCheckTemplates(DeleteHealthCheckTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHealthCheckTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes health check templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHealthCheckTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHealthCheckTemplatesResponse
        /// </returns>
        public async Task<DeleteHealthCheckTemplatesResponse> DeleteHealthCheckTemplatesAsync(DeleteHealthCheckTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHealthCheckTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteListener",
                Version = "2020-06-16",
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
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteListener",
                Version = "2020-06-16",
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
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
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
        /// <para>Deletes a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
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
        /// <para>Deletes an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Deleting</b> state, the ALB instance is being deleted.</description></item>
        /// <item><description>If an ALB instance cannot be found, the ALB instance is deleted.</description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2020-06-16",
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
        /// <para>Deletes an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Deleting</b> state, the ALB instance is being deleted.</description></item>
        /// <item><description>If an ALB instance cannot be found, the ALB instance is deleted.</description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoadBalancer",
                Version = "2020-06-16",
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
        /// <para>Deletes an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Deleting</b> state, the ALB instance is being deleted.</description></item>
        /// <item><description>If an ALB instance cannot be found, the ALB instance is deleted.</description></item>
        /// </list>
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
        /// <para>Deletes an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Deleting</b> state, the ALB instance is being deleted.</description></item>
        /// <item><description>If an ALB instance cannot be found, the ALB instance is deleted.</description></item>
        /// </list>
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
        /// <para>Deletes a forwarding rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRule</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rule is in the <b>Deleting</b> state, the forwarding rule is being deleted.</description></item>
        /// <item><description>If the forwarding rule cannot be found, the forwarding rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteRule",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a forwarding rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRule</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rule is in the <b>Deleting</b> state, the forwarding rule is being deleted.</description></item>
        /// <item><description>If the forwarding rule cannot be found, the forwarding rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteRule",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a forwarding rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRule</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rule is in the <b>Deleting</b> state, the forwarding rule is being deleted.</description></item>
        /// <item><description>If the forwarding rule cannot be found, the forwarding rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a forwarding rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRule</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rule is in the <b>Deleting</b> state, the forwarding rule is being deleted.</description></item>
        /// <item><description>If the forwarding rule cannot be found, the forwarding rule is deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes one or more forwarding rules from a listener at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRules</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of forwarding rules.</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Deleting</b> state, the forwarding rules are being deleted.</description></item>
        /// <item><description>If the forwarding rules cannot be found, the forwarding rules are deleted.</description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
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
                Version = "2020-06-16",
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
        /// <para>Deletes one or more forwarding rules from a listener at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRules</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of forwarding rules.</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Deleting</b> state, the forwarding rules are being deleted.</description></item>
        /// <item><description>If the forwarding rules cannot be found, the forwarding rules are deleted.</description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
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
                Version = "2020-06-16",
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
        /// <para>Deletes one or more forwarding rules from a listener at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRules</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of forwarding rules.</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Deleting</b> state, the forwarding rules are being deleted.</description></item>
        /// <item><description>If the forwarding rules cannot be found, the forwarding rules are deleted.</description></item>
        /// </list>
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
        /// <para>Deletes one or more forwarding rules from a listener at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteRules</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of forwarding rules.</para>
        /// <list type="bullet">
        /// <item><description>If the forwarding rules are in the <b>Deleting</b> state, the forwarding rules are being deleted.</description></item>
        /// <item><description>If the forwarding rules cannot be found, the forwarding rules are deleted.</description></item>
        /// </list>
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
        /// <para>Deletes a custom security policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityPolicyResponse
        /// </returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicyWithOptions(DeleteSecurityPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityPolicy",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom security policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityPolicyResponse
        /// </returns>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicyWithOptionsAsync(DeleteSecurityPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityPolicy",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom security policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityPolicyResponse
        /// </returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicy(DeleteSecurityPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom security policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityPolicyResponse
        /// </returns>
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicyAsync(DeleteSecurityPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Deleting</b> state, it indicates that the server group is being deleted.</description></item>
        /// <item><description>If a specified server group cannot be found, it indicates that the server group has been deleted.</description></item>
        /// </list>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServerGroup",
                Version = "2020-06-16",
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
        /// <para>Deletes a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Deleting</b> state, it indicates that the server group is being deleted.</description></item>
        /// <item><description>If a specified server group cannot be found, it indicates that the server group has been deleted.</description></item>
        /// </list>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServerGroup",
                Version = "2020-06-16",
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
        /// <para>Deletes a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Deleting</b> state, it indicates that the server group is being deleted.</description></item>
        /// <item><description>If a specified server group cannot be found, it indicates that the server group has been deleted.</description></item>
        /// </list>
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
        /// <para>Deletes a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DeleteServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Deleting</b> state, it indicates that the server group is being deleted.</description></item>
        /// <item><description>If a specified server group cannot be found, it indicates that the server group has been deleted.</description></item>
        /// </list>
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
        /// <para>查询资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCapacityReservationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapacityReservationResponse
        /// </returns>
        public DescribeCapacityReservationResponse DescribeCapacityReservationWithOptions(DescribeCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCapacityReservation",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapacityReservationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCapacityReservationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapacityReservationResponse
        /// </returns>
        public async Task<DescribeCapacityReservationResponse> DescribeCapacityReservationWithOptionsAsync(DescribeCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCapacityReservation",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapacityReservationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCapacityReservationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapacityReservationResponse
        /// </returns>
        public DescribeCapacityReservationResponse DescribeCapacityReservation(DescribeCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapacityReservationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCapacityReservationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapacityReservationResponse
        /// </returns>
        public async Task<DescribeCapacityReservationResponse> DescribeCapacityReservationAsync(DescribeCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapacityReservationWithOptionsAsync(request, runtime);
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-06-16",
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-06-16",
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
        /// <para>Queries zones in a region.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2020-06-16",
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
        /// <para>Queries zones in a region.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2020-06-16",
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
        /// <para>Queries zones in a region.</para>
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
        /// <para>Queries zones in a region.</para>
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
        /// <para>Disassociates an elastic IP address (EIP) bandwidth plan from an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DetachCommonBandwidthPackageFromLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214359.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being disassociated from the ALB instance.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is disassociated from the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachCommonBandwidthPackageFromLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachCommonBandwidthPackageFromLoadBalancerResponse
        /// </returns>
        public DetachCommonBandwidthPackageFromLoadBalancerResponse DetachCommonBandwidthPackageFromLoadBalancerWithOptions(DetachCommonBandwidthPackageFromLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DetachCommonBandwidthPackageFromLoadBalancer",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachCommonBandwidthPackageFromLoadBalancerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an elastic IP address (EIP) bandwidth plan from an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DetachCommonBandwidthPackageFromLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214359.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being disassociated from the ALB instance.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is disassociated from the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachCommonBandwidthPackageFromLoadBalancerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachCommonBandwidthPackageFromLoadBalancerResponse
        /// </returns>
        public async Task<DetachCommonBandwidthPackageFromLoadBalancerResponse> DetachCommonBandwidthPackageFromLoadBalancerWithOptionsAsync(DetachCommonBandwidthPackageFromLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
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
                Action = "DetachCommonBandwidthPackageFromLoadBalancer",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachCommonBandwidthPackageFromLoadBalancerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an elastic IP address (EIP) bandwidth plan from an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DetachCommonBandwidthPackageFromLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214359.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being disassociated from the ALB instance.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is disassociated from the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachCommonBandwidthPackageFromLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachCommonBandwidthPackageFromLoadBalancerResponse
        /// </returns>
        public DetachCommonBandwidthPackageFromLoadBalancerResponse DetachCommonBandwidthPackageFromLoadBalancer(DetachCommonBandwidthPackageFromLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachCommonBandwidthPackageFromLoadBalancerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an elastic IP address (EIP) bandwidth plan from an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DetachCommonBandwidthPackageFromLoadBalancer</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214359.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the EIP bandwidth plan is being disassociated from the ALB instance.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the EIP bandwidth plan is disassociated from the ALB instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachCommonBandwidthPackageFromLoadBalancerRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachCommonBandwidthPackageFromLoadBalancerResponse
        /// </returns>
        public async Task<DetachCommonBandwidthPackageFromLoadBalancerResponse> DetachCommonBandwidthPackageFromLoadBalancerAsync(DetachCommonBandwidthPackageFromLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachCommonBandwidthPackageFromLoadBalancerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables deletion protection for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDeletionProtectionResponse
        /// </returns>
        public DisableDeletionProtectionResponse DisableDeletionProtectionWithOptions(DisableDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDeletionProtection",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDeletionProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables deletion protection for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDeletionProtectionResponse
        /// </returns>
        public async Task<DisableDeletionProtectionResponse> DisableDeletionProtectionWithOptionsAsync(DisableDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDeletionProtection",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables deletion protection for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDeletionProtectionResponse
        /// </returns>
        public DisableDeletionProtectionResponse DisableDeletionProtection(DisableDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDeletionProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables deletion protection for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDeletionProtectionResponse
        /// </returns>
        public async Task<DisableDeletionProtectionResponse> DisableDeletionProtectionAsync(DisableDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access log feature for a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerAccessLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerAccessLogResponse
        /// </returns>
        public DisableLoadBalancerAccessLogResponse DisableLoadBalancerAccessLogWithOptions(DisableLoadBalancerAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLoadBalancerAccessLog",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableLoadBalancerAccessLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access log feature for a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerAccessLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerAccessLogResponse
        /// </returns>
        public async Task<DisableLoadBalancerAccessLogResponse> DisableLoadBalancerAccessLogWithOptionsAsync(DisableLoadBalancerAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLoadBalancerAccessLog",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableLoadBalancerAccessLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access log feature for a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerAccessLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerAccessLogResponse
        /// </returns>
        public DisableLoadBalancerAccessLogResponse DisableLoadBalancerAccessLog(DisableLoadBalancerAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLoadBalancerAccessLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the access log feature for a Server Load Balancer (SLB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerAccessLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerAccessLogResponse
        /// </returns>
        public async Task<DisableLoadBalancerAccessLogResponse> DisableLoadBalancerAccessLogAsync(DisableLoadBalancerAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLoadBalancerAccessLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from public to private.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the DisableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Intranet</b> and the type of the IPv6 address of the ALB instance is changed from public to private. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, private IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>DisableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerIpv6InternetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerIpv6InternetResponse
        /// </returns>
        public DisableLoadBalancerIpv6InternetResponse DisableLoadBalancerIpv6InternetWithOptions(DisableLoadBalancerIpv6InternetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLoadBalancerIpv6Internet",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableLoadBalancerIpv6InternetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from public to private.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the DisableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Intranet</b> and the type of the IPv6 address of the ALB instance is changed from public to private. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, private IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>DisableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerIpv6InternetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerIpv6InternetResponse
        /// </returns>
        public async Task<DisableLoadBalancerIpv6InternetResponse> DisableLoadBalancerIpv6InternetWithOptionsAsync(DisableLoadBalancerIpv6InternetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLoadBalancerIpv6Internet",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableLoadBalancerIpv6InternetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from public to private.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the DisableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Intranet</b> and the type of the IPv6 address of the ALB instance is changed from public to private. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, private IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>DisableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerIpv6InternetRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerIpv6InternetResponse
        /// </returns>
        public DisableLoadBalancerIpv6InternetResponse DisableLoadBalancerIpv6Internet(DisableLoadBalancerIpv6InternetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLoadBalancerIpv6InternetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from public to private.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the DisableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Intranet</b> and the type of the IPv6 address of the ALB instance is changed from public to private. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, private IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>DisableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableLoadBalancerIpv6InternetRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLoadBalancerIpv6InternetResponse
        /// </returns>
        public async Task<DisableLoadBalancerIpv6InternetResponse> DisableLoadBalancerIpv6InternetAsync(DisableLoadBalancerIpv6InternetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLoadBalancerIpv6InternetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates access control lists (ACLs) from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAclsFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> to query the status of an ACL.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Dissociating</b> state, the ACL is being disassociated from the listener.</description></item>
        /// <item><description>If an ACL is in the <b>Dissociated</b> state, the ACL is disassociated from the listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAclsFromListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateAclsFromListenerResponse
        /// </returns>
        public DissociateAclsFromListenerResponse DissociateAclsFromListenerWithOptions(DissociateAclsFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAclsFromListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAclsFromListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates access control lists (ACLs) from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAclsFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> to query the status of an ACL.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Dissociating</b> state, the ACL is being disassociated from the listener.</description></item>
        /// <item><description>If an ACL is in the <b>Dissociated</b> state, the ACL is disassociated from the listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAclsFromListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateAclsFromListenerResponse
        /// </returns>
        public async Task<DissociateAclsFromListenerResponse> DissociateAclsFromListenerWithOptionsAsync(DissociateAclsFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAclsFromListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAclsFromListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates access control lists (ACLs) from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAclsFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> to query the status of an ACL.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Dissociating</b> state, the ACL is being disassociated from the listener.</description></item>
        /// <item><description>If an ACL is in the <b>Dissociated</b> state, the ACL is disassociated from the listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAclsFromListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateAclsFromListenerResponse
        /// </returns>
        public DissociateAclsFromListenerResponse DissociateAclsFromListener(DissociateAclsFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateAclsFromListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates access control lists (ACLs) from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAclsFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213618.html">ListAclRelations</a> to query the status of an ACL.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Dissociating</b> state, the ACL is being disassociated from the listener.</description></item>
        /// <item><description>If an ACL is in the <b>Dissociated</b> state, the ACL is disassociated from the listener.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAclsFromListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateAclsFromListenerResponse
        /// </returns>
        public async Task<DissociateAclsFromListenerResponse> DissociateAclsFromListenerAsync(DissociateAclsFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateAclsFromListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates additional certificates from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAdditionalCertificatesFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214354.html">ListListenerCertificates</a> operation to query the status of the task. - If an additional certificate is in the <b>Dissociating</b> state, the additional certificate is being disassociated. - If an additional certificate is in the <b>Dissociated</b> state, the additional certificate is disassociated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAdditionalCertificatesFromListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateAdditionalCertificatesFromListenerResponse
        /// </returns>
        public DissociateAdditionalCertificatesFromListenerResponse DissociateAdditionalCertificatesFromListenerWithOptions(DissociateAdditionalCertificatesFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAdditionalCertificatesFromListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAdditionalCertificatesFromListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates additional certificates from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAdditionalCertificatesFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214354.html">ListListenerCertificates</a> operation to query the status of the task. - If an additional certificate is in the <b>Dissociating</b> state, the additional certificate is being disassociated. - If an additional certificate is in the <b>Dissociated</b> state, the additional certificate is disassociated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAdditionalCertificatesFromListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateAdditionalCertificatesFromListenerResponse
        /// </returns>
        public async Task<DissociateAdditionalCertificatesFromListenerResponse> DissociateAdditionalCertificatesFromListenerWithOptionsAsync(DissociateAdditionalCertificatesFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAdditionalCertificatesFromListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAdditionalCertificatesFromListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates additional certificates from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAdditionalCertificatesFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214354.html">ListListenerCertificates</a> operation to query the status of the task. - If an additional certificate is in the <b>Dissociating</b> state, the additional certificate is being disassociated. - If an additional certificate is in the <b>Dissociated</b> state, the additional certificate is disassociated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAdditionalCertificatesFromListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateAdditionalCertificatesFromListenerResponse
        /// </returns>
        public DissociateAdditionalCertificatesFromListenerResponse DissociateAdditionalCertificatesFromListener(DissociateAdditionalCertificatesFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateAdditionalCertificatesFromListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates additional certificates from a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>DissociateAdditionalCertificatesFromListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214354.html">ListListenerCertificates</a> operation to query the status of the task. - If an additional certificate is in the <b>Dissociating</b> state, the additional certificate is being disassociated. - If an additional certificate is in the <b>Dissociated</b> state, the additional certificate is disassociated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DissociateAdditionalCertificatesFromListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateAdditionalCertificatesFromListenerResponse
        /// </returns>
        public async Task<DissociateAdditionalCertificatesFromListenerResponse> DissociateAdditionalCertificatesFromListenerAsync(DissociateAdditionalCertificatesFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateAdditionalCertificatesFromListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables deletion protection for a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDeletionProtectionResponse
        /// </returns>
        public EnableDeletionProtectionResponse EnableDeletionProtectionWithOptions(EnableDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDeletionProtection",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDeletionProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables deletion protection for a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDeletionProtectionResponse
        /// </returns>
        public async Task<EnableDeletionProtectionResponse> EnableDeletionProtectionWithOptionsAsync(EnableDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDeletionProtection",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables deletion protection for a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDeletionProtectionResponse
        /// </returns>
        public EnableDeletionProtectionResponse EnableDeletionProtection(EnableDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDeletionProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables deletion protection for a resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDeletionProtectionResponse
        /// </returns>
        public async Task<EnableDeletionProtectionResponse> EnableDeletionProtectionAsync(EnableDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access log feature for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerAccessLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerAccessLogResponse
        /// </returns>
        public EnableLoadBalancerAccessLogResponse EnableLoadBalancerAccessLogWithOptions(EnableLoadBalancerAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                query["LogProject"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLoadBalancerAccessLog",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableLoadBalancerAccessLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access log feature for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerAccessLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerAccessLogResponse
        /// </returns>
        public async Task<EnableLoadBalancerAccessLogResponse> EnableLoadBalancerAccessLogWithOptionsAsync(EnableLoadBalancerAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                query["LogProject"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                query["LogStore"] = request.LogStore;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLoadBalancerAccessLog",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableLoadBalancerAccessLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access log feature for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerAccessLogRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerAccessLogResponse
        /// </returns>
        public EnableLoadBalancerAccessLogResponse EnableLoadBalancerAccessLog(EnableLoadBalancerAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLoadBalancerAccessLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the access log feature for an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerAccessLogRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerAccessLogResponse
        /// </returns>
        public async Task<EnableLoadBalancerAccessLogResponse> EnableLoadBalancerAccessLogAsync(EnableLoadBalancerAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLoadBalancerAccessLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from private to public.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the EnableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Internet</b> and the type of the IPv6 address of the ALB instance is changed from private to public. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, public IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>EnableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerIpv6InternetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerIpv6InternetResponse
        /// </returns>
        public EnableLoadBalancerIpv6InternetResponse EnableLoadBalancerIpv6InternetWithOptions(EnableLoadBalancerIpv6InternetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLoadBalancerIpv6Internet",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableLoadBalancerIpv6InternetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from private to public.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the EnableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Internet</b> and the type of the IPv6 address of the ALB instance is changed from private to public. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, public IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>EnableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerIpv6InternetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerIpv6InternetResponse
        /// </returns>
        public async Task<EnableLoadBalancerIpv6InternetResponse> EnableLoadBalancerIpv6InternetWithOptionsAsync(EnableLoadBalancerIpv6InternetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLoadBalancerIpv6Internet",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableLoadBalancerIpv6InternetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from private to public.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the EnableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Internet</b> and the type of the IPv6 address of the ALB instance is changed from private to public. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, public IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>EnableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerIpv6InternetRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerIpv6InternetResponse
        /// </returns>
        public EnableLoadBalancerIpv6InternetResponse EnableLoadBalancerIpv6Internet(EnableLoadBalancerIpv6InternetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLoadBalancerIpv6InternetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the type of the IPv6 address that is used by a dual-stack Application Load Balancer (ALB) instance from private to public.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>An ALB instance is created and IPv4/IPv6 dual stack is enabled for the instance. You can call the <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a> operation and set <b>AddressIpVersion</b> to <b>DualStack</b> to create a dual-stack ALB instance.</para>
        /// <remarks>
        /// <para>If you set <b>AddressIpVersion</b> to <b>DualStack</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>AddressType</b> to <b>Internet</b>, the ALB instance uses a public IPv4 IP address and a private IPv6 address.</description></item>
        /// <item><description>If you set <b>AddressType</b> to <b>Intranet</b>, the ALB instance uses a private IPv4 IP address and a private IPv6 address.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>After the EnableLoadBalancerIpv6Internet operation is called, the value of <b>Ipv6AddressType</b> is changed to <b>Internet</b> and the type of the IPv6 address of the ALB instance is changed from private to public. If you upgrade the instance or the instance scales elastic network interfaces (ENIs) along with workloads, public IPv6 addresses are automatically enabled for the instance and the new ENIs. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the value of <b>Ipv6AddressType</b>.</description></item>
        /// <item><description><b>EnableLoadBalancerIpv6Internet</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the network type of the IPv6 address that is used by the ALB instance is being changed.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the network type of the IPv6 address that is used by the ALB instance is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableLoadBalancerIpv6InternetRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLoadBalancerIpv6InternetResponse
        /// </returns>
        public async Task<EnableLoadBalancerIpv6InternetResponse> EnableLoadBalancerIpv6InternetAsync(EnableLoadBalancerIpv6InternetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLoadBalancerIpv6InternetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthCheckTemplateAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHealthCheckTemplateAttributeResponse
        /// </returns>
        public GetHealthCheckTemplateAttributeResponse GetHealthCheckTemplateAttributeWithOptions(GetHealthCheckTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateId))
            {
                query["HealthCheckTemplateId"] = request.HealthCheckTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHealthCheckTemplateAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHealthCheckTemplateAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthCheckTemplateAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHealthCheckTemplateAttributeResponse
        /// </returns>
        public async Task<GetHealthCheckTemplateAttributeResponse> GetHealthCheckTemplateAttributeWithOptionsAsync(GetHealthCheckTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateId))
            {
                query["HealthCheckTemplateId"] = request.HealthCheckTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHealthCheckTemplateAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHealthCheckTemplateAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthCheckTemplateAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHealthCheckTemplateAttributeResponse
        /// </returns>
        public GetHealthCheckTemplateAttributeResponse GetHealthCheckTemplateAttribute(GetHealthCheckTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHealthCheckTemplateAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthCheckTemplateAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHealthCheckTemplateAttributeResponse
        /// </returns>
        public async Task<GetHealthCheckTemplateAttributeResponse> GetHealthCheckTemplateAttributeAsync(GetHealthCheckTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHealthCheckTemplateAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a listener.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListenerAttribute",
                Version = "2020-06-16",
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
        /// <para>Queries the details about a listener.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListenerAttribute",
                Version = "2020-06-16",
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
        /// <para>Queries the details about a listener.</para>
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
        /// <para>Queries the details about a listener.</para>
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
        /// <para>Queries the health check status of a listener and its forwarding rules.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRule))
            {
                query["IncludeRule"] = request.IncludeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListenerHealthStatus",
                Version = "2020-06-16",
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
        /// <para>Queries the health check status of a listener and its forwarding rules.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRule))
            {
                query["IncludeRule"] = request.IncludeRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListenerHealthStatus",
                Version = "2020-06-16",
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
        /// <para>Queries the health check status of a listener and its forwarding rules.</para>
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
        /// <para>Queries the health check status of a listener and its forwarding rules.</para>
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
        /// <para>Queries the details of an Application Load Balancer (ALB) instance.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoadBalancerAttribute",
                Version = "2020-06-16",
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
        /// <para>Queries the details of an Application Load Balancer (ALB) instance.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoadBalancerAttribute",
                Version = "2020-06-16",
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
        /// <para>Queries the details of an Application Load Balancer (ALB) instance.</para>
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
        /// <para>Queries the details of an Application Load Balancer (ALB) instance.</para>
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
        /// <para>Queries AScript rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAScriptsResponse
        /// </returns>
        public ListAScriptsResponse ListAScriptsWithOptions(ListAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScriptIds))
            {
                query["AScriptIds"] = request.AScriptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScriptNames))
            {
                query["AScriptNames"] = request.AScriptNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                query["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAScriptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AScript rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAScriptsResponse
        /// </returns>
        public async Task<ListAScriptsResponse> ListAScriptsWithOptionsAsync(ListAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScriptIds))
            {
                query["AScriptIds"] = request.AScriptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScriptNames))
            {
                query["AScriptNames"] = request.AScriptNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                query["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AScript rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAScriptsResponse
        /// </returns>
        public ListAScriptsResponse ListAScripts(ListAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAScriptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AScript rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAScriptsResponse
        /// </returns>
        public async Task<ListAScriptsResponse> ListAScriptsAsync(ListAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAScriptsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the entries of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclEntriesResponse
        /// </returns>
        public ListAclEntriesResponse ListAclEntriesWithOptions(ListAclEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAclEntries",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclEntriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the entries of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclEntriesResponse
        /// </returns>
        public async Task<ListAclEntriesResponse> ListAclEntriesWithOptionsAsync(ListAclEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAclEntries",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the entries of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclEntriesResponse
        /// </returns>
        public ListAclEntriesResponse ListAclEntries(ListAclEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAclEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the entries of an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclEntriesResponse
        /// </returns>
        public async Task<ListAclEntriesResponse> ListAclEntriesAsync(ListAclEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAclEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclRelationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclRelationsResponse
        /// </returns>
        public ListAclRelationsResponse ListAclRelationsWithOptions(ListAclRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAclRelations",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclRelationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclRelationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclRelationsResponse
        /// </returns>
        public async Task<ListAclRelationsResponse> ListAclRelationsWithOptionsAsync(ListAclRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAclRelations",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclRelationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclRelationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclRelationsResponse
        /// </returns>
        public ListAclRelationsResponse ListAclRelations(ListAclRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAclRelationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclRelationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclRelationsResponse
        /// </returns>
        public async Task<ListAclRelationsResponse> ListAclRelationsAsync(ListAclRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAclRelationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access control lists (ACLs) in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public ListAclsResponse ListAclsWithOptions(ListAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclNames))
            {
                query["AclNames"] = request.AclNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListAcls",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access control lists (ACLs) in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public async Task<ListAclsResponse> ListAclsWithOptionsAsync(ListAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclIds))
            {
                query["AclIds"] = request.AclIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclNames))
            {
                query["AclNames"] = request.AclNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListAcls",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access control lists (ACLs) in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public ListAclsResponse ListAcls(ListAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAclsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access control lists (ACLs) in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclsResponse
        /// </returns>
        public async Task<ListAclsResponse> ListAclsAsync(ListAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAclsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsynJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsynJobsResponse
        /// </returns>
        public ListAsynJobsResponse ListAsynJobsWithOptions(ListAsynJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
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
                Action = "ListAsynJobs",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsynJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsynJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsynJobsResponse
        /// </returns>
        public async Task<ListAsynJobsResponse> ListAsynJobsWithOptionsAsync(ListAsynJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
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
                Action = "ListAsynJobs",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsynJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsynJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsynJobsResponse
        /// </returns>
        public ListAsynJobsResponse ListAsynJobs(ListAsynJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsynJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsynJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsynJobsResponse
        /// </returns>
        public async Task<ListAsynJobsResponse> ListAsynJobsAsync(ListAsynJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsynJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries health check templates in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHealthCheckTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHealthCheckTemplatesResponse
        /// </returns>
        public ListHealthCheckTemplatesResponse ListHealthCheckTemplatesWithOptions(ListHealthCheckTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateIds))
            {
                query["HealthCheckTemplateIds"] = request.HealthCheckTemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateNames))
            {
                query["HealthCheckTemplateNames"] = request.HealthCheckTemplateNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListHealthCheckTemplates",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHealthCheckTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries health check templates in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHealthCheckTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHealthCheckTemplatesResponse
        /// </returns>
        public async Task<ListHealthCheckTemplatesResponse> ListHealthCheckTemplatesWithOptionsAsync(ListHealthCheckTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateIds))
            {
                query["HealthCheckTemplateIds"] = request.HealthCheckTemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateNames))
            {
                query["HealthCheckTemplateNames"] = request.HealthCheckTemplateNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListHealthCheckTemplates",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHealthCheckTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries health check templates in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHealthCheckTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHealthCheckTemplatesResponse
        /// </returns>
        public ListHealthCheckTemplatesResponse ListHealthCheckTemplates(ListHealthCheckTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHealthCheckTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries health check templates in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHealthCheckTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHealthCheckTemplatesResponse
        /// </returns>
        public async Task<ListHealthCheckTemplatesResponse> ListHealthCheckTemplatesAsync(ListHealthCheckTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHealthCheckTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the certificates that are associated with a listener, including additional certificates and the default certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenerCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListListenerCertificatesResponse
        /// </returns>
        public ListListenerCertificatesResponse ListListenerCertificatesWithOptions(ListListenerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateIds))
            {
                query["CertificateIds"] = request.CertificateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateType))
            {
                query["CertificateType"] = request.CertificateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListListenerCertificates",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenerCertificatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the certificates that are associated with a listener, including additional certificates and the default certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenerCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListListenerCertificatesResponse
        /// </returns>
        public async Task<ListListenerCertificatesResponse> ListListenerCertificatesWithOptionsAsync(ListListenerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateIds))
            {
                query["CertificateIds"] = request.CertificateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateType))
            {
                query["CertificateType"] = request.CertificateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListListenerCertificates",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenerCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the certificates that are associated with a listener, including additional certificates and the default certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenerCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListListenerCertificatesResponse
        /// </returns>
        public ListListenerCertificatesResponse ListListenerCertificates(ListListenerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListenerCertificatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the certificates that are associated with a listener, including additional certificates and the default certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListListenerCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListListenerCertificatesResponse
        /// </returns>
        public async Task<ListListenerCertificatesResponse> ListListenerCertificatesAsync(ListListenerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListenerCertificatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners in a region.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                query["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListListeners",
                Version = "2020-06-16",
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
        /// <para>Queries the listeners in a region.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                query["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListListeners",
                Version = "2020-06-16",
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
        /// <para>Queries the listeners in a region.</para>
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
        /// <para>Queries the listeners in a region.</para>
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
        /// <para>Queries the configurations of instances.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSName))
            {
                query["DNSName"] = request.DNSName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressType))
            {
                query["Ipv6AddressType"] = request.Ipv6AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerBussinessStatus))
            {
                query["LoadBalancerBussinessStatus"] = request.LoadBalancerBussinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerNames))
            {
                query["LoadBalancerNames"] = request.LoadBalancerNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIds))
            {
                query["VpcIds"] = request.VpcIds;
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
                Action = "ListLoadBalancers",
                Version = "2020-06-16",
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
        /// <para>Queries the configurations of instances.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressIpVersion))
            {
                query["AddressIpVersion"] = request.AddressIpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSName))
            {
                query["DNSName"] = request.DNSName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressType))
            {
                query["Ipv6AddressType"] = request.Ipv6AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerBussinessStatus))
            {
                query["LoadBalancerBussinessStatus"] = request.LoadBalancerBussinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerNames))
            {
                query["LoadBalancerNames"] = request.LoadBalancerNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerStatus))
            {
                query["LoadBalancerStatus"] = request.LoadBalancerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIds))
            {
                query["VpcIds"] = request.VpcIds;
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
                Action = "ListLoadBalancers",
                Version = "2020-06-16",
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
        /// <para>Queries the configurations of instances.</para>
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
        /// <para>Queries the configurations of instances.</para>
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
        /// <para>Queries the forwarding rules in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRulesWithOptions(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                query["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
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
                Action = "ListRules",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerIds))
            {
                query["ListenerIds"] = request.ListenerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerIds))
            {
                query["LoadBalancerIds"] = request.LoadBalancerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
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
                Action = "ListRules",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the forwarding rules in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom security policies in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPoliciesResponse
        /// </returns>
        public ListSecurityPoliciesResponse ListSecurityPoliciesWithOptions(ListSecurityPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyIds))
            {
                query["SecurityPolicyIds"] = request.SecurityPolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyNames))
            {
                query["SecurityPolicyNames"] = request.SecurityPolicyNames;
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
                Action = "ListSecurityPolicies",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecurityPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom security policies in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPoliciesResponse
        /// </returns>
        public async Task<ListSecurityPoliciesResponse> ListSecurityPoliciesWithOptionsAsync(ListSecurityPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyIds))
            {
                query["SecurityPolicyIds"] = request.SecurityPolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyNames))
            {
                query["SecurityPolicyNames"] = request.SecurityPolicyNames;
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
                Action = "ListSecurityPolicies",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecurityPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom security policies in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPoliciesResponse
        /// </returns>
        public ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecurityPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom security policies in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPoliciesResponse
        /// </returns>
        public async Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecurityPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with security policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPolicyRelationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPolicyRelationsResponse
        /// </returns>
        public ListSecurityPolicyRelationsResponse ListSecurityPolicyRelationsWithOptions(ListSecurityPolicyRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyIds))
            {
                query["SecurityPolicyIds"] = request.SecurityPolicyIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecurityPolicyRelations",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecurityPolicyRelationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with security policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPolicyRelationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPolicyRelationsResponse
        /// </returns>
        public async Task<ListSecurityPolicyRelationsResponse> ListSecurityPolicyRelationsWithOptionsAsync(ListSecurityPolicyRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyIds))
            {
                query["SecurityPolicyIds"] = request.SecurityPolicyIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecurityPolicyRelations",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecurityPolicyRelationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with security policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPolicyRelationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPolicyRelationsResponse
        /// </returns>
        public ListSecurityPolicyRelationsResponse ListSecurityPolicyRelations(ListSecurityPolicyRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecurityPolicyRelationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the listeners that are associated with security policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecurityPolicyRelationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecurityPolicyRelationsResponse
        /// </returns>
        public async Task<ListSecurityPolicyRelationsResponse> ListSecurityPolicyRelationsAsync(ListSecurityPolicyRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecurityPolicyRelationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries servers in a server group.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIds))
            {
                query["ServerIds"] = request.ServerIds;
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
                Action = "ListServerGroupServers",
                Version = "2020-06-16",
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
        /// <para>Queries servers in a server group.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIds))
            {
                query["ServerIds"] = request.ServerIds;
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
                Action = "ListServerGroupServers",
                Version = "2020-06-16",
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
        /// <para>Queries servers in a server group.</para>
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
        /// <para>Queries servers in a server group.</para>
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
        /// <para>Queries server groups.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupIds))
            {
                query["ServerGroupIds"] = request.ServerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupNames))
            {
                query["ServerGroupNames"] = request.ServerGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                query["ServerGroupType"] = request.ServerGroupType;
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
                Action = "ListServerGroups",
                Version = "2020-06-16",
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
        /// <para>Queries server groups.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupIds))
            {
                query["ServerGroupIds"] = request.ServerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupNames))
            {
                query["ServerGroupNames"] = request.ServerGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupType))
            {
                query["ServerGroupType"] = request.ServerGroupType;
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
                Action = "ListServerGroups",
                Version = "2020-06-16",
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
        /// <para>Queries server groups.</para>
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
        /// <para>Queries server groups.</para>
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
        /// <para>Queries system security policies in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSystemSecurityPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSystemSecurityPoliciesResponse
        /// </returns>
        public ListSystemSecurityPoliciesResponse ListSystemSecurityPoliciesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemSecurityPolicies",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemSecurityPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system security policies in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSystemSecurityPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSystemSecurityPoliciesResponse
        /// </returns>
        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemSecurityPolicies",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemSecurityPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system security policies in a region.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSystemSecurityPoliciesResponse
        /// </returns>
        public ListSystemSecurityPoliciesResponse ListSystemSecurityPolicies()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemSecurityPoliciesWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system security policies in a region.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSystemSecurityPoliciesResponse
        /// </returns>
        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemSecurityPoliciesWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2020-06-16",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2020-06-16",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2020-06-16",
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2020-06-16",
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
        /// <para>Queries tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTagValues",
                Version = "2020-06-16",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTagValues",
                Version = "2020-06-16",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag values.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an Application Load Balancer (ALB) instance to a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  By default, security groups are unavailable. To use security groups, contact your account manager.</para>
        /// <list type="bullet">
        /// <item><description>Make sure that a security group is created. For more information about how to create security groups, see <a href="https://help.aliyun.com/document_detail/2679843.html">CreateSecurityGroup</a>.</description></item>
        /// <item><description>Each ALB instance can be added to at most four security groups.</description></item>
        /// <item><description>To query the security groups of an ALB instance, call the <a href="https://help.aliyun.com/document_detail/2254835.html">GetLoadBalancerAttribute</a> operation.</description></item>
        /// <item><description>GetLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the task is in the Succeeded state, the ALB instance is added to the security group.</description></item>
        /// <item><description>If the task is in the Processing state, the ALB instance is being added to the security group. In this case, you can query the task but cannot perform other operations.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerJoinSecurityGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerJoinSecurityGroupResponse
        /// </returns>
        public LoadBalancerJoinSecurityGroupResponse LoadBalancerJoinSecurityGroupWithOptions(LoadBalancerJoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBalancerJoinSecurityGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBalancerJoinSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an Application Load Balancer (ALB) instance to a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  By default, security groups are unavailable. To use security groups, contact your account manager.</para>
        /// <list type="bullet">
        /// <item><description>Make sure that a security group is created. For more information about how to create security groups, see <a href="https://help.aliyun.com/document_detail/2679843.html">CreateSecurityGroup</a>.</description></item>
        /// <item><description>Each ALB instance can be added to at most four security groups.</description></item>
        /// <item><description>To query the security groups of an ALB instance, call the <a href="https://help.aliyun.com/document_detail/2254835.html">GetLoadBalancerAttribute</a> operation.</description></item>
        /// <item><description>GetLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the task is in the Succeeded state, the ALB instance is added to the security group.</description></item>
        /// <item><description>If the task is in the Processing state, the ALB instance is being added to the security group. In this case, you can query the task but cannot perform other operations.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerJoinSecurityGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerJoinSecurityGroupResponse
        /// </returns>
        public async Task<LoadBalancerJoinSecurityGroupResponse> LoadBalancerJoinSecurityGroupWithOptionsAsync(LoadBalancerJoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBalancerJoinSecurityGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBalancerJoinSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an Application Load Balancer (ALB) instance to a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  By default, security groups are unavailable. To use security groups, contact your account manager.</para>
        /// <list type="bullet">
        /// <item><description>Make sure that a security group is created. For more information about how to create security groups, see <a href="https://help.aliyun.com/document_detail/2679843.html">CreateSecurityGroup</a>.</description></item>
        /// <item><description>Each ALB instance can be added to at most four security groups.</description></item>
        /// <item><description>To query the security groups of an ALB instance, call the <a href="https://help.aliyun.com/document_detail/2254835.html">GetLoadBalancerAttribute</a> operation.</description></item>
        /// <item><description>GetLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the task is in the Succeeded state, the ALB instance is added to the security group.</description></item>
        /// <item><description>If the task is in the Processing state, the ALB instance is being added to the security group. In this case, you can query the task but cannot perform other operations.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerJoinSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerJoinSecurityGroupResponse
        /// </returns>
        public LoadBalancerJoinSecurityGroupResponse LoadBalancerJoinSecurityGroup(LoadBalancerJoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoadBalancerJoinSecurityGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an Application Load Balancer (ALB) instance to a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  By default, security groups are unavailable. To use security groups, contact your account manager.</para>
        /// <list type="bullet">
        /// <item><description>Make sure that a security group is created. For more information about how to create security groups, see <a href="https://help.aliyun.com/document_detail/2679843.html">CreateSecurityGroup</a>.</description></item>
        /// <item><description>Each ALB instance can be added to at most four security groups.</description></item>
        /// <item><description>To query the security groups of an ALB instance, call the <a href="https://help.aliyun.com/document_detail/2254835.html">GetLoadBalancerAttribute</a> operation.</description></item>
        /// <item><description>GetLoadBalancerAttribute is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If the task is in the Succeeded state, the ALB instance is added to the security group.</description></item>
        /// <item><description>If the task is in the Processing state, the ALB instance is being added to the security group. In this case, you can query the task but cannot perform other operations.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerJoinSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerJoinSecurityGroupResponse
        /// </returns>
        public async Task<LoadBalancerJoinSecurityGroupResponse> LoadBalancerJoinSecurityGroupAsync(LoadBalancerJoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoadBalancerJoinSecurityGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an Application Load Balancer (ALB) instance from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  LoadBalancerLeaveSecurityGroup is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.
        ///     *   If the task is in the Succeeded state, the ALB instance is removed from the security group.
        ///     *   If the task is in the Processing state, the ALB instance is being removed from the security group. In this case, you can query the task but cannot perform other operations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerLeaveSecurityGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerLeaveSecurityGroupResponse
        /// </returns>
        public LoadBalancerLeaveSecurityGroupResponse LoadBalancerLeaveSecurityGroupWithOptions(LoadBalancerLeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBalancerLeaveSecurityGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBalancerLeaveSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an Application Load Balancer (ALB) instance from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  LoadBalancerLeaveSecurityGroup is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.
        ///     *   If the task is in the Succeeded state, the ALB instance is removed from the security group.
        ///     *   If the task is in the Processing state, the ALB instance is being removed from the security group. In this case, you can query the task but cannot perform other operations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerLeaveSecurityGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerLeaveSecurityGroupResponse
        /// </returns>
        public async Task<LoadBalancerLeaveSecurityGroupResponse> LoadBalancerLeaveSecurityGroupWithOptionsAsync(LoadBalancerLeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadBalancerLeaveSecurityGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadBalancerLeaveSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an Application Load Balancer (ALB) instance from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  LoadBalancerLeaveSecurityGroup is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.
        ///     *   If the task is in the Succeeded state, the ALB instance is removed from the security group.
        ///     *   If the task is in the Processing state, the ALB instance is being removed from the security group. In this case, you can query the task but cannot perform other operations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerLeaveSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerLeaveSecurityGroupResponse
        /// </returns>
        public LoadBalancerLeaveSecurityGroupResponse LoadBalancerLeaveSecurityGroup(LoadBalancerLeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoadBalancerLeaveSecurityGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an Application Load Balancer (ALB) instance from a security group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  LoadBalancerLeaveSecurityGroup is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254893.html">ListAsynJobs</a> operation to query the status of the task.
        ///     *   If the task is in the Succeeded state, the ALB instance is removed from the security group.
        ///     *   If the task is in the Processing state, the ALB instance is being removed from the security group. In this case, you can query the task but cannot perform other operations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadBalancerLeaveSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadBalancerLeaveSecurityGroupResponse
        /// </returns>
        public async Task<LoadBalancerLeaveSecurityGroupResponse> LoadBalancerLeaveSecurityGroupAsync(LoadBalancerLeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoadBalancerLeaveSecurityGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCapacityReservationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCapacityReservationResponse
        /// </returns>
        public ModifyCapacityReservationResponse ModifyCapacityReservationWithOptions(ModifyCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumLoadBalancerCapacity))
            {
                query["MinimumLoadBalancerCapacity"] = request.MinimumLoadBalancerCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetCapacityReservation))
            {
                query["ResetCapacityReservation"] = request.ResetCapacityReservation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCapacityReservation",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCapacityReservationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCapacityReservationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCapacityReservationResponse
        /// </returns>
        public async Task<ModifyCapacityReservationResponse> ModifyCapacityReservationWithOptionsAsync(ModifyCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumLoadBalancerCapacity))
            {
                query["MinimumLoadBalancerCapacity"] = request.MinimumLoadBalancerCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetCapacityReservation))
            {
                query["ResetCapacityReservation"] = request.ResetCapacityReservation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCapacityReservation",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCapacityReservationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCapacityReservationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCapacityReservationResponse
        /// </returns>
        public ModifyCapacityReservationResponse ModifyCapacityReservation(ModifyCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCapacityReservationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改资源预留</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCapacityReservationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCapacityReservationResponse
        /// </returns>
        public async Task<ModifyCapacityReservationResponse> ModifyCapacityReservationAsync(ModifyCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCapacityReservationWithOptionsAsync(request, runtime);
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
                Version = "2020-06-16",
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
                Version = "2020-06-16",
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
        /// <para>Removes entries from an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveEntriesFromAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Removing</b> state, the entries are being removed.</description></item>
        /// <item><description>If an ACL cannot be found, the entries are removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveEntriesFromAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveEntriesFromAclResponse
        /// </returns>
        public RemoveEntriesFromAclResponse RemoveEntriesFromAclWithOptions(RemoveEntriesFromAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entries))
            {
                query["Entries"] = request.Entries;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveEntriesFromAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveEntriesFromAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes entries from an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveEntriesFromAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Removing</b> state, the entries are being removed.</description></item>
        /// <item><description>If an ACL cannot be found, the entries are removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveEntriesFromAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveEntriesFromAclResponse
        /// </returns>
        public async Task<RemoveEntriesFromAclResponse> RemoveEntriesFromAclWithOptionsAsync(RemoveEntriesFromAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclId))
            {
                query["AclId"] = request.AclId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entries))
            {
                query["Entries"] = request.Entries;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveEntriesFromAcl",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveEntriesFromAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes entries from an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveEntriesFromAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Removing</b> state, the entries are being removed.</description></item>
        /// <item><description>If an ACL cannot be found, the entries are removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveEntriesFromAclRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveEntriesFromAclResponse
        /// </returns>
        public RemoveEntriesFromAclResponse RemoveEntriesFromAcl(RemoveEntriesFromAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEntriesFromAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes entries from an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveEntriesFromAcl</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213616.html">ListAclEntries</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ACL is in the <b>Removing</b> state, the entries are being removed.</description></item>
        /// <item><description>If an ACL cannot be found, the entries are removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveEntriesFromAclRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveEntriesFromAclResponse
        /// </returns>
        public async Task<RemoveEntriesFromAclResponse> RemoveEntriesFromAclAsync(RemoveEntriesFromAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEntriesFromAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes backend servers from a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254862.html">ListServerGroups</a> to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254863.html">ListServerGroupServers</a> to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                query["Servers"] = request.Servers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveServersFromServerGroup",
                Version = "2020-06-16",
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
        /// <para>Removes backend servers from a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254862.html">ListServerGroups</a> to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254863.html">ListServerGroupServers</a> to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                query["Servers"] = request.Servers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveServersFromServerGroup",
                Version = "2020-06-16",
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
        /// <para>Removes backend servers from a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254862.html">ListServerGroups</a> to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254863.html">ListServerGroupServers</a> to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
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
        /// <para>Removes backend servers from a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>RemoveServersFromServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254862.html">ListServerGroups</a> to query the status of a server group.<list type="bullet">
        /// <item><description>If the server group is in the <b>Configuring</b> state, the server group is being modified.</description></item>
        /// <item><description>If the server group is in the <b>Available</b> state, the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/2254863.html">ListServerGroupServers</a> to query the status of a backend server.<list type="bullet">
        /// <item><description>If the backend server is in the <b>Removing</b> state, the backend server is being removed from the server group.</description></item>
        /// <item><description>If the backend server cannot be found, the backend server is no longer in the server group.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
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
        /// <para>Replaces backend servers in a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ReplaceServersInServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Replacing</b> state, it indicates that the server is being removed from the server group and a new server is added to the server group.</description></item>
        /// <item><description>If a backend server is in the \<em>\<em>Available\</em>\</em> state, it indicates that the server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceServersInServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceServersInServerGroupResponse
        /// </returns>
        public ReplaceServersInServerGroupResponse ReplaceServersInServerGroupWithOptions(ReplaceServersInServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedServers))
            {
                query["AddedServers"] = request.AddedServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovedServers))
            {
                query["RemovedServers"] = request.RemovedServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceServersInServerGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceServersInServerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ReplaceServersInServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Replacing</b> state, it indicates that the server is being removed from the server group and a new server is added to the server group.</description></item>
        /// <item><description>If a backend server is in the \<em>\<em>Available\</em>\</em> state, it indicates that the server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceServersInServerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceServersInServerGroupResponse
        /// </returns>
        public async Task<ReplaceServersInServerGroupResponse> ReplaceServersInServerGroupWithOptionsAsync(ReplaceServersInServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedServers))
            {
                query["AddedServers"] = request.AddedServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovedServers))
            {
                query["RemovedServers"] = request.RemovedServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceServersInServerGroup",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceServersInServerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ReplaceServersInServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Replacing</b> state, it indicates that the server is being removed from the server group and a new server is added to the server group.</description></item>
        /// <item><description>If a backend server is in the \<em>\<em>Available\</em>\</em> state, it indicates that the server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceServersInServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceServersInServerGroupResponse
        /// </returns>
        public ReplaceServersInServerGroupResponse ReplaceServersInServerGroup(ReplaceServersInServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceServersInServerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Replaces backend servers in a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>ReplaceServersInServerGroup</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Replacing</b> state, it indicates that the server is being removed from the server group and a new server is added to the server group.</description></item>
        /// <item><description>If a backend server is in the \<em>\<em>Available\</em>\</em> state, it indicates that the server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceServersInServerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceServersInServerGroupResponse
        /// </returns>
        public async Task<ReplaceServersInServerGroupResponse> ReplaceServersInServerGroupAsync(ReplaceServersInServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceServersInServerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StartListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being enabled.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the listener is enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartListenerResponse
        /// </returns>
        public StartListenerResponse StartListenerWithOptions(StartListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StartListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being enabled.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the listener is enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartListenerResponse
        /// </returns>
        public async Task<StartListenerResponse> StartListenerWithOptionsAsync(StartListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StartListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being enabled.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the listener is enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StartListenerResponse
        /// </returns>
        public StartListenerResponse StartListener(StartListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StartListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being enabled.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the listener is enabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StartListenerResponse
        /// </returns>
        public async Task<StartListenerResponse> StartListenerAsync(StartListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an elastic IP address (EIP) or a virtual IP address (VIP) of a zone from a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported by Application Load Balancer (ALB) instances that use static IP addresses. The zone cannot be removed if the ALB instance has only one available zone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartShiftLoadBalancerZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartShiftLoadBalancerZonesResponse
        /// </returns>
        public StartShiftLoadBalancerZonesResponse StartShiftLoadBalancerZonesWithOptions(StartShiftLoadBalancerZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartShiftLoadBalancerZones",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartShiftLoadBalancerZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an elastic IP address (EIP) or a virtual IP address (VIP) of a zone from a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported by Application Load Balancer (ALB) instances that use static IP addresses. The zone cannot be removed if the ALB instance has only one available zone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartShiftLoadBalancerZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartShiftLoadBalancerZonesResponse
        /// </returns>
        public async Task<StartShiftLoadBalancerZonesResponse> StartShiftLoadBalancerZonesWithOptionsAsync(StartShiftLoadBalancerZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartShiftLoadBalancerZones",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartShiftLoadBalancerZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an elastic IP address (EIP) or a virtual IP address (VIP) of a zone from a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported by Application Load Balancer (ALB) instances that use static IP addresses. The zone cannot be removed if the ALB instance has only one available zone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartShiftLoadBalancerZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartShiftLoadBalancerZonesResponse
        /// </returns>
        public StartShiftLoadBalancerZonesResponse StartShiftLoadBalancerZones(StartShiftLoadBalancerZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartShiftLoadBalancerZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an elastic IP address (EIP) or a virtual IP address (VIP) of a zone from a DNS record.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported by Application Load Balancer (ALB) instances that use static IP addresses. The zone cannot be removed if the ALB instance has only one available zone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartShiftLoadBalancerZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartShiftLoadBalancerZonesResponse
        /// </returns>
        public async Task<StartShiftLoadBalancerZonesResponse> StartShiftLoadBalancerZonesAsync(StartShiftLoadBalancerZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartShiftLoadBalancerZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StopListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being disabled.</description></item>
        /// <item><description>If a listener is in the <b>Stopped</b> state, the listener is disabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopListenerResponse
        /// </returns>
        public StopListenerResponse StopListenerWithOptions(StopListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopListenerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StopListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being disabled.</description></item>
        /// <item><description>If a listener is in the <b>Stopped</b> state, the listener is disabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopListenerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopListenerResponse
        /// </returns>
        public async Task<StopListenerResponse> StopListenerWithOptionsAsync(StopListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopListener",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StopListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being disabled.</description></item>
        /// <item><description>If a listener is in the <b>Stopped</b> state, the listener is disabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StopListenerResponse
        /// </returns>
        public StopListenerResponse StopListener(StopListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopListenerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a listener.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>StopListener</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the listener is being disabled.</description></item>
        /// <item><description>If a listener is in the <b>Stopped</b> state, the listener is disabled.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopListenerRequest
        /// </param>
        /// 
        /// <returns>
        /// StopListenerResponse
        /// </returns>
        public async Task<StopListenerResponse> StopListenerAsync(StopListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopListenerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources.</para>
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
                Version = "2020-06-16",
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
        /// <para>Adds tags to resources.</para>
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
                Version = "2020-06-16",
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
        /// <para>Adds tags to resources.</para>
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
        /// <para>Adds tags to resources.</para>
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
                Version = "2020-06-16",
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
        /// <para>Removes tags from resources.</para>
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
                Version = "2020-06-16",
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
        /// <para>Removes tags from resources.</para>
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
        /// <para>Removes tags from resources.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateAScripts</em>* is an an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of an AScript rule.</para>
        /// <list type="bullet">
        /// <item><description>If the rule is in the <b>Configuring</b> state, the rule is being updated.</description></item>
        /// <item><description>If the rule is in the <b>Available</b> state, the rule is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAScriptsResponse
        /// </returns>
        public UpdateAScriptsResponse UpdateAScriptsWithOptions(UpdateAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScripts))
            {
                query["AScripts"] = request.AScripts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAScriptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateAScripts</em>* is an an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of an AScript rule.</para>
        /// <list type="bullet">
        /// <item><description>If the rule is in the <b>Configuring</b> state, the rule is being updated.</description></item>
        /// <item><description>If the rule is in the <b>Available</b> state, the rule is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAScriptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAScriptsResponse
        /// </returns>
        public async Task<UpdateAScriptsResponse> UpdateAScriptsWithOptionsAsync(UpdateAScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AScripts))
            {
                query["AScripts"] = request.AScripts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAScripts",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateAScripts</em>* is an an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of an AScript rule.</para>
        /// <list type="bullet">
        /// <item><description>If the rule is in the <b>Configuring</b> state, the rule is being updated.</description></item>
        /// <item><description>If the rule is in the <b>Available</b> state, the rule is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAScriptsResponse
        /// </returns>
        public UpdateAScriptsResponse UpdateAScripts(UpdateAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAScriptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates AScript rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateAScripts</em>* is an an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/472574.html">ListAScripts</a> operation to query the status of an AScript rule.</para>
        /// <list type="bullet">
        /// <item><description>If the rule is in the <b>Configuring</b> state, the rule is being updated.</description></item>
        /// <item><description>If the rule is in the <b>Available</b> state, the rule is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAScriptsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAScriptsResponse
        /// </returns>
        public async Task<UpdateAScriptsResponse> UpdateAScriptsAsync(UpdateAScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAScriptsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of an access control list (ACL), such as the name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAclAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAclAttributeResponse
        /// </returns>
        public UpdateAclAttributeResponse UpdateAclAttributeWithOptions(UpdateAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAclAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAclAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of an access control list (ACL), such as the name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAclAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAclAttributeResponse
        /// </returns>
        public async Task<UpdateAclAttributeResponse> UpdateAclAttributeWithOptionsAsync(UpdateAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAclAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAclAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of an access control list (ACL), such as the name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAclAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAclAttributeResponse
        /// </returns>
        public UpdateAclAttributeResponse UpdateAclAttribute(UpdateAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAclAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of an access control list (ACL), such as the name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAclAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAclAttributeResponse
        /// </returns>
        public async Task<UpdateAclAttributeResponse> UpdateAclAttributeAsync(UpdateAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAclAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes, such as the name and protocol, of a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHealthCheckTemplateAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHealthCheckTemplateAttributeResponse
        /// </returns>
        public UpdateHealthCheckTemplateAttributeResponse UpdateHealthCheckTemplateAttributeWithOptions(UpdateHealthCheckTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckCodes))
            {
                query["HealthCheckCodes"] = request.HealthCheckCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHost))
            {
                query["HealthCheckHost"] = request.HealthCheckHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpVersion))
            {
                query["HealthCheckHttpVersion"] = request.HealthCheckHttpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckPath))
            {
                query["HealthCheckPath"] = request.HealthCheckPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckProtocol))
            {
                query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateId))
            {
                query["HealthCheckTemplateId"] = request.HealthCheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateName))
            {
                query["HealthCheckTemplateName"] = request.HealthCheckTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHealthCheckTemplateAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHealthCheckTemplateAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes, such as the name and protocol, of a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHealthCheckTemplateAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHealthCheckTemplateAttributeResponse
        /// </returns>
        public async Task<UpdateHealthCheckTemplateAttributeResponse> UpdateHealthCheckTemplateAttributeWithOptionsAsync(UpdateHealthCheckTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckCodes))
            {
                query["HealthCheckCodes"] = request.HealthCheckCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConnectPort))
            {
                query["HealthCheckConnectPort"] = request.HealthCheckConnectPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHost))
            {
                query["HealthCheckHost"] = request.HealthCheckHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckHttpVersion))
            {
                query["HealthCheckHttpVersion"] = request.HealthCheckHttpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckMethod))
            {
                query["HealthCheckMethod"] = request.HealthCheckMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckPath))
            {
                query["HealthCheckPath"] = request.HealthCheckPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckProtocol))
            {
                query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateId))
            {
                query["HealthCheckTemplateId"] = request.HealthCheckTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTemplateName))
            {
                query["HealthCheckTemplateName"] = request.HealthCheckTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTimeout))
            {
                query["HealthCheckTimeout"] = request.HealthCheckTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnhealthyThreshold))
            {
                query["UnhealthyThreshold"] = request.UnhealthyThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHealthCheckTemplateAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHealthCheckTemplateAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes, such as the name and protocol, of a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHealthCheckTemplateAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHealthCheckTemplateAttributeResponse
        /// </returns>
        public UpdateHealthCheckTemplateAttributeResponse UpdateHealthCheckTemplateAttribute(UpdateHealthCheckTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHealthCheckTemplateAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes, such as the name and protocol, of a health check template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHealthCheckTemplateAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHealthCheckTemplateAttributeResponse
        /// </returns>
        public async Task<UpdateHealthCheckTemplateAttributeResponse> UpdateHealthCheckTemplateAttributeAsync(UpdateHealthCheckTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHealthCheckTemplateAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a listener, such as the name and the default action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the configuration of the listener is modified.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertificates))
            {
                query["CaCertificates"] = request.CaCertificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaEnabled))
            {
                query["CaEnabled"] = request.CaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultActions))
            {
                query["DefaultActions"] = request.DefaultActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GzipEnabled))
            {
                query["GzipEnabled"] = request.GzipEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Enabled))
            {
                query["Http2Enabled"] = request.Http2Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                query["ListenerDescription"] = request.ListenerDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuicConfig))
            {
                query["QuicConfig"] = request.QuicConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedForConfig))
            {
                query["XForwardedForConfig"] = request.XForwardedForConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListenerAttribute",
                Version = "2020-06-16",
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
        /// <para>Updates the attributes of a listener, such as the name and the default action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the configuration of the listener is modified.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertificates))
            {
                query["CaCertificates"] = request.CaCertificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaEnabled))
            {
                query["CaEnabled"] = request.CaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificates))
            {
                query["Certificates"] = request.Certificates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultActions))
            {
                query["DefaultActions"] = request.DefaultActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GzipEnabled))
            {
                query["GzipEnabled"] = request.GzipEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Enabled))
            {
                query["Http2Enabled"] = request.Http2Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerDescription))
            {
                query["ListenerDescription"] = request.ListenerDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuicConfig))
            {
                query["QuicConfig"] = request.QuicConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XForwardedForConfig))
            {
                query["XForwardedForConfig"] = request.XForwardedForConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListenerAttribute",
                Version = "2020-06-16",
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
        /// <para>Updates the attributes of a listener, such as the name and the default action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the configuration of the listener is modified.</description></item>
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
        /// <para>Updates the attributes of a listener, such as the name and the default action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the configuration of the listener is modified.</description></item>
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
        /// <para>Updates the log configuration of a listener, such as the access log configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerLogConfig</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the log configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the log configuration of the listener is modified.<remarks>
        /// <para>You can update the log configuration of a listener only after you enable the access log feature.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerLogConfigResponse
        /// </returns>
        public UpdateListenerLogConfigResponse UpdateListenerLogConfigWithOptions(UpdateListenerLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogRecordCustomizedHeadersEnabled))
            {
                query["AccessLogRecordCustomizedHeadersEnabled"] = request.AccessLogRecordCustomizedHeadersEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogTracingConfig))
            {
                query["AccessLogTracingConfig"] = request.AccessLogTracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListenerLogConfig",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListenerLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the log configuration of a listener, such as the access log configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerLogConfig</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the log configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the log configuration of the listener is modified.<remarks>
        /// <para>You can update the log configuration of a listener only after you enable the access log feature.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerLogConfigResponse
        /// </returns>
        public async Task<UpdateListenerLogConfigResponse> UpdateListenerLogConfigWithOptionsAsync(UpdateListenerLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogRecordCustomizedHeadersEnabled))
            {
                query["AccessLogRecordCustomizedHeadersEnabled"] = request.AccessLogRecordCustomizedHeadersEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogTracingConfig))
            {
                query["AccessLogTracingConfig"] = request.AccessLogTracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerId))
            {
                query["ListenerId"] = request.ListenerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListenerLogConfig",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListenerLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the log configuration of a listener, such as the access log configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerLogConfig</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the log configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the log configuration of the listener is modified.<remarks>
        /// <para>You can update the log configuration of a listener only after you enable the access log feature.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerLogConfigResponse
        /// </returns>
        public UpdateListenerLogConfigResponse UpdateListenerLogConfig(UpdateListenerLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateListenerLogConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the log configuration of a listener, such as the access log configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateListenerLogConfig</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/2254865.html">GetListenerAttribute</a> to query the status of the task:</para>
        /// <list type="bullet">
        /// <item><description>If a listener is in the <b>Configuring</b> state, the log configuration of the listener is being modified.</description></item>
        /// <item><description>If a listener is in the <b>Running</b> state, the log configuration of the listener is modified.<remarks>
        /// <para>You can update the log configuration of a listener only after you enable the access log feature.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateListenerLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateListenerLogConfigResponse
        /// </returns>
        public async Task<UpdateListenerLogConfigResponse> UpdateListenerLogConfigAsync(UpdateListenerLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateListenerLogConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network type of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>An ALB instance is created. For more information about how to create an ALB instance, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>If you want to change the network type from internal-facing to Internet-facing, you must first create an elastic IP address (EIP). For more information, see <a href="https://help.aliyun.com/document_detail/120192.html">AllocateEipAddress</a>.</description></item>
        /// </list>
        /// <h2>Usage notes</h2>
        /// <para><b>UpdateLoadBalancerAddressTypeConfig</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the network type is being changed.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the network type has been changed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAddressTypeConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAddressTypeConfigResponse
        /// </returns>
        public UpdateLoadBalancerAddressTypeConfigResponse UpdateLoadBalancerAddressTypeConfigWithOptions(UpdateLoadBalancerAddressTypeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerAddressTypeConfig",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerAddressTypeConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network type of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>An ALB instance is created. For more information about how to create an ALB instance, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>If you want to change the network type from internal-facing to Internet-facing, you must first create an elastic IP address (EIP). For more information, see <a href="https://help.aliyun.com/document_detail/120192.html">AllocateEipAddress</a>.</description></item>
        /// </list>
        /// <h2>Usage notes</h2>
        /// <para><b>UpdateLoadBalancerAddressTypeConfig</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the network type is being changed.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the network type has been changed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAddressTypeConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAddressTypeConfigResponse
        /// </returns>
        public async Task<UpdateLoadBalancerAddressTypeConfigResponse> UpdateLoadBalancerAddressTypeConfigWithOptionsAsync(UpdateLoadBalancerAddressTypeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerAddressTypeConfig",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerAddressTypeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network type of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>An ALB instance is created. For more information about how to create an ALB instance, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>If you want to change the network type from internal-facing to Internet-facing, you must first create an elastic IP address (EIP). For more information, see <a href="https://help.aliyun.com/document_detail/120192.html">AllocateEipAddress</a>.</description></item>
        /// </list>
        /// <h2>Usage notes</h2>
        /// <para><b>UpdateLoadBalancerAddressTypeConfig</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the network type is being changed.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the network type has been changed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAddressTypeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAddressTypeConfigResponse
        /// </returns>
        public UpdateLoadBalancerAddressTypeConfigResponse UpdateLoadBalancerAddressTypeConfig(UpdateLoadBalancerAddressTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoadBalancerAddressTypeConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network type of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>An ALB instance is created. For more information about how to create an ALB instance, see <a href="https://help.aliyun.com/document_detail/214358.html">CreateLoadBalancer</a>.</description></item>
        /// <item><description>If you want to change the network type from internal-facing to Internet-facing, you must first create an elastic IP address (EIP). For more information, see <a href="https://help.aliyun.com/document_detail/120192.html">AllocateEipAddress</a>.</description></item>
        /// </list>
        /// <h2>Usage notes</h2>
        /// <para><b>UpdateLoadBalancerAddressTypeConfig</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the network type is being changed.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the network type has been changed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerAddressTypeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerAddressTypeConfigResponse
        /// </returns>
        public async Task<UpdateLoadBalancerAddressTypeConfigResponse> UpdateLoadBalancerAddressTypeConfigAsync(UpdateLoadBalancerAddressTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoadBalancerAddressTypeConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an Application Load Balancer (ALB) instance, such as the name and the configuration read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerAttribute</em>* is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the ALB instance is modified.</description></item>
        /// </list>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionConfig))
            {
                query["ModificationProtectionConfig"] = request.ModificationProtectionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerAttribute",
                Version = "2020-06-16",
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
        /// <para>Modifies the attributes of an Application Load Balancer (ALB) instance, such as the name and the configuration read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerAttribute</em>* is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the ALB instance is modified.</description></item>
        /// </list>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerName))
            {
                query["LoadBalancerName"] = request.LoadBalancerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModificationProtectionConfig))
            {
                query["ModificationProtectionConfig"] = request.ModificationProtectionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerAttribute",
                Version = "2020-06-16",
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
        /// <para>Modifies the attributes of an Application Load Balancer (ALB) instance, such as the name and the configuration read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerAttribute</em>* is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the ALB instance is modified.</description></item>
        /// </list>
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
        /// <para>Modifies the attributes of an Application Load Balancer (ALB) instance, such as the name and the configuration read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerAttribute</em>* is an asynchronous operation. After you send a request, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the ALB instance is modified.</description></item>
        /// </list>
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
        /// <para>Changes the edition of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can only upgrade a basic ALB instance to a standard ALB instance or a WAF-enabled ALB instance. You cannot downgrade a standard ALB instance or a WAF-enabled ALB instance to a basic ALB instance. For more information, see <a href="https://help.aliyun.com/document_detail/214654.html">Upgrade an ALB instance</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>UpdateLoadBalancerEdition</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the edition of the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the edition of the ALB instance is modified.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerEditionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerEditionResponse
        /// </returns>
        public UpdateLoadBalancerEditionResponse UpdateLoadBalancerEditionWithOptions(UpdateLoadBalancerEditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerEdition))
            {
                query["LoadBalancerEdition"] = request.LoadBalancerEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerEdition",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerEditionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the edition of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can only upgrade a basic ALB instance to a standard ALB instance or a WAF-enabled ALB instance. You cannot downgrade a standard ALB instance or a WAF-enabled ALB instance to a basic ALB instance. For more information, see <a href="https://help.aliyun.com/document_detail/214654.html">Upgrade an ALB instance</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>UpdateLoadBalancerEdition</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the edition of the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the edition of the ALB instance is modified.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerEditionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerEditionResponse
        /// </returns>
        public async Task<UpdateLoadBalancerEditionResponse> UpdateLoadBalancerEditionWithOptionsAsync(UpdateLoadBalancerEditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerEdition))
            {
                query["LoadBalancerEdition"] = request.LoadBalancerEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerEdition",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoadBalancerEditionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the edition of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can only upgrade a basic ALB instance to a standard ALB instance or a WAF-enabled ALB instance. You cannot downgrade a standard ALB instance or a WAF-enabled ALB instance to a basic ALB instance. For more information, see <a href="https://help.aliyun.com/document_detail/214654.html">Upgrade an ALB instance</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>UpdateLoadBalancerEdition</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the edition of the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the edition of the ALB instance is modified.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerEditionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerEditionResponse
        /// </returns>
        public UpdateLoadBalancerEditionResponse UpdateLoadBalancerEdition(UpdateLoadBalancerEditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoadBalancerEditionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the edition of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can only upgrade a basic ALB instance to a standard ALB instance or a WAF-enabled ALB instance. You cannot downgrade a standard ALB instance or a WAF-enabled ALB instance to a basic ALB instance. For more information, see <a href="https://help.aliyun.com/document_detail/214654.html">Upgrade an ALB instance</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>UpdateLoadBalancerEdition</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> operation to query the status of an ALB instance.<list type="bullet">
        /// <item><description>If the ALB instance is in the <b>Configuring</b> state, the edition of the ALB instance is being modified.</description></item>
        /// <item><description>If the ALB instance is in the <b>Active</b> state, the edition of the ALB instance is modified.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateLoadBalancerEditionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoadBalancerEditionResponse
        /// </returns>
        public async Task<UpdateLoadBalancerEditionResponse> UpdateLoadBalancerEditionAsync(UpdateLoadBalancerEditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoadBalancerEditionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the zones of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerZones</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the zones are being modified.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the zones are modified.<remarks>
        /// <para>You may be charged after you call UpdateLoadBalancerZones.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerZones",
                Version = "2020-06-16",
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
        /// <para>Modifies the zones of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerZones</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the zones are being modified.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the zones are modified.<remarks>
        /// <para>You may be charged after you call UpdateLoadBalancerZones.</para>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                query["LoadBalancerId"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoadBalancerZones",
                Version = "2020-06-16",
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
        /// <para>Modifies the zones of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerZones</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the zones are being modified.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the zones are modified.<remarks>
        /// <para>You may be charged after you call UpdateLoadBalancerZones.</para>
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
        /// <para>Modifies the zones of an Application Load Balancer (ALB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateLoadBalancerZones</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/214362.html">GetLoadBalancerAttribute</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If an ALB instance is in the <b>Configuring</b> state, the zones are being modified.</description></item>
        /// <item><description>If an ALB instance is in the <b>Active</b> state, the zones are modified.<remarks>
        /// <para>You may be charged after you call UpdateLoadBalancerZones.</para>
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
        /// <para>Updates a forwarding rule, such as the match condition, action, and name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>UpdateRuleAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:
        ///     *   If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.
        ///     *   If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</para>
        /// <list type="bullet">
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Number of conditions: You can specify at most 5 for a basic Application Load Balancer (ALB) instance, at most 10 for a standard ALB instance, and at most 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Number of actions: You can specify at most 3 for a basic ALB instance, at most 5 for a standard ALB instance, and at most 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleAttributeResponse
        /// </returns>
        public UpdateRuleAttributeResponse UpdateRuleAttributeWithOptions(UpdateRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleActions))
            {
                query["RuleActions"] = request.RuleActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConditions))
            {
                query["RuleConditions"] = request.RuleConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a forwarding rule, such as the match condition, action, and name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>UpdateRuleAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:
        ///     *   If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.
        ///     *   If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</para>
        /// <list type="bullet">
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Number of conditions: You can specify at most 5 for a basic Application Load Balancer (ALB) instance, at most 10 for a standard ALB instance, and at most 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Number of actions: You can specify at most 3 for a basic ALB instance, at most 5 for a standard ALB instance, and at most 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleAttributeResponse
        /// </returns>
        public async Task<UpdateRuleAttributeResponse> UpdateRuleAttributeWithOptionsAsync(UpdateRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleActions))
            {
                query["RuleActions"] = request.RuleActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleConditions))
            {
                query["RuleConditions"] = request.RuleConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a forwarding rule, such as the match condition, action, and name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>UpdateRuleAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:
        ///     *   If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.
        ///     *   If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</para>
        /// <list type="bullet">
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Number of conditions: You can specify at most 5 for a basic Application Load Balancer (ALB) instance, at most 10 for a standard ALB instance, and at most 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Number of actions: You can specify at most 3 for a basic ALB instance, at most 5 for a standard ALB instance, and at most 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleAttributeResponse
        /// </returns>
        public UpdateRuleAttributeResponse UpdateRuleAttribute(UpdateRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a forwarding rule, such as the match condition, action, and name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>UpdateRuleAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of a forwarding rule:
        ///     *   If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.
        ///     *   If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</para>
        /// <list type="bullet">
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the number of conditions and the number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Number of conditions: You can specify at most 5 for a basic Application Load Balancer (ALB) instance, at most 10 for a standard ALB instance, and at most 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Number of actions: You can specify at most 3 for a basic ALB instance, at most 5 for a standard ALB instance, and at most 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleAttributeResponse
        /// </returns>
        public async Task<UpdateRuleAttributeResponse> UpdateRuleAttributeAsync(UpdateRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateRulesAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the maximum number of conditions and the maximum number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRulesAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRulesAttributeResponse
        /// </returns>
        public UpdateRulesAttributeResponse UpdateRulesAttributeWithOptions(UpdateRulesAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                bodyFlat["Rules"] = request.Rules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRulesAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRulesAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateRulesAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the maximum number of conditions and the maximum number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRulesAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRulesAttributeResponse
        /// </returns>
        public async Task<UpdateRulesAttributeResponse> UpdateRulesAttributeWithOptionsAsync(UpdateRulesAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                bodyFlat["Rules"] = request.Rules;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRulesAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRulesAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateRulesAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the maximum number of conditions and the maximum number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRulesAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRulesAttributeResponse
        /// </returns>
        public UpdateRulesAttributeResponse UpdateRulesAttribute(UpdateRulesAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRulesAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of forwarding rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateRulesAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/214379.html">ListRules</a> operation to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a forwarding rule is in the <b>Configuring</b> state, the forwarding rule is being updated.</description></item>
        /// <item><description>If a forwarding rule is in the <b>Available</b> state, the forwarding rule is updated.</description></item>
        /// <item><description>You can set <b>RuleConditions</b> and <b>RuleActions</b> to add conditions and actions to a forwarding rule. Take note of the following limits on the maximum number of conditions and the maximum number of actions in each forwarding rule:<list type="bullet">
        /// <item><description>Limits on conditions: 5 for a basic Application Load Balancer (ALB) instance, 10 for a standard ALB instance, and 10 for a WAF-enabled ALB instance.</description></item>
        /// <item><description>Limits on actions: 3 for a basic ALB instance, 5 for a standard ALB instance, and 5 for a WAF-enabled ALB instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRulesAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRulesAttributeResponse
        /// </returns>
        public async Task<UpdateRulesAttributeResponse> UpdateRulesAttributeAsync(UpdateRulesAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRulesAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a security policy, such as the TLS protocol version and the supported cipher suites.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para><b>UpdateSecurityPolicyAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213609.html">ListSecurityPolicies</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a security policy is in the <b>Configuring</b> state, the security policy is being updated.</description></item>
        /// <item><description>If a security policy is in the <b>Available</b> state, the security policy is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecurityPolicyAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityPolicyAttributeResponse
        /// </returns>
        public UpdateSecurityPolicyAttributeResponse UpdateSecurityPolicyAttributeWithOptions(UpdateSecurityPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyName))
            {
                query["SecurityPolicyName"] = request.SecurityPolicyName;
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
                Action = "UpdateSecurityPolicyAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecurityPolicyAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a security policy, such as the TLS protocol version and the supported cipher suites.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para><b>UpdateSecurityPolicyAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213609.html">ListSecurityPolicies</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a security policy is in the <b>Configuring</b> state, the security policy is being updated.</description></item>
        /// <item><description>If a security policy is in the <b>Available</b> state, the security policy is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecurityPolicyAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityPolicyAttributeResponse
        /// </returns>
        public async Task<UpdateSecurityPolicyAttributeResponse> UpdateSecurityPolicyAttributeWithOptionsAsync(UpdateSecurityPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ciphers))
            {
                query["Ciphers"] = request.Ciphers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyName))
            {
                query["SecurityPolicyName"] = request.SecurityPolicyName;
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
                Action = "UpdateSecurityPolicyAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecurityPolicyAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a security policy, such as the TLS protocol version and the supported cipher suites.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para><b>UpdateSecurityPolicyAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213609.html">ListSecurityPolicies</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a security policy is in the <b>Configuring</b> state, the security policy is being updated.</description></item>
        /// <item><description>If a security policy is in the <b>Available</b> state, the security policy is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecurityPolicyAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityPolicyAttributeResponse
        /// </returns>
        public UpdateSecurityPolicyAttributeResponse UpdateSecurityPolicyAttribute(UpdateSecurityPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecurityPolicyAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attributes of a security policy, such as the TLS protocol version and the supported cipher suites.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para><b>UpdateSecurityPolicyAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/213609.html">ListSecurityPolicies</a> to query the status of the task.</para>
        /// <list type="bullet">
        /// <item><description>If a security policy is in the <b>Configuring</b> state, the security policy is being updated.</description></item>
        /// <item><description>If a security policy is in the <b>Available</b> state, the security policy is updated.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecurityPolicyAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityPolicyAttributeResponse
        /// </returns>
        public async Task<UpdateSecurityPolicyAttributeResponse> UpdateSecurityPolicyAttributeAsync(UpdateSecurityPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecurityPolicyAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a server group, such as health checks, session persistence, server group names, routing algorithms, and protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>UpdateServerGroupAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group:</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                query["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZoneEnabled))
            {
                query["CrossZoneEnabled"] = request.CrossZoneEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                query["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                query["ServerGroupName"] = request.ServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlowStartConfig))
            {
                query["SlowStartConfig"] = request.SlowStartConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionConfig))
            {
                query["StickySessionConfig"] = request.StickySessionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UchConfig))
            {
                query["UchConfig"] = request.UchConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpstreamKeepaliveEnabled))
            {
                query["UpstreamKeepaliveEnabled"] = request.UpstreamKeepaliveEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServerGroupAttribute",
                Version = "2020-06-16",
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
        /// <para>Modifies the configurations of a server group, such as health checks, session persistence, server group names, routing algorithms, and protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>UpdateServerGroupAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group:</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDrainConfig))
            {
                query["ConnectionDrainConfig"] = request.ConnectionDrainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZoneEnabled))
            {
                query["CrossZoneEnabled"] = request.CrossZoneEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckConfig))
            {
                query["HealthCheckConfig"] = request.HealthCheckConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                query["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupName))
            {
                query["ServerGroupName"] = request.ServerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlowStartConfig))
            {
                query["SlowStartConfig"] = request.SlowStartConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StickySessionConfig))
            {
                query["StickySessionConfig"] = request.StickySessionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UchConfig))
            {
                query["UchConfig"] = request.UchConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpstreamKeepaliveEnabled))
            {
                query["UpstreamKeepaliveEnabled"] = request.UpstreamKeepaliveEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServerGroupAttribute",
                Version = "2020-06-16",
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
        /// <para>Modifies the configurations of a server group, such as health checks, session persistence, server group names, routing algorithms, and protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>UpdateServerGroupAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group:</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
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
        /// <para>Modifies the configurations of a server group, such as health checks, session persistence, server group names, routing algorithms, and protocols.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>UpdateServerGroupAttribute</b> is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group:</para>
        /// <list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, the configuration of the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, the configuration of the server group is modified.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations, such as the backend server weight and description, of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupServersAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Configuring</b> state, it indicates that the backend server is being modified.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the backend server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupServersAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupServersAttributeResponse
        /// </returns>
        public UpdateServerGroupServersAttributeResponse UpdateServerGroupServersAttributeWithOptions(UpdateServerGroupServersAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                query["Servers"] = request.Servers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServerGroupServersAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServerGroupServersAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations, such as the backend server weight and description, of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupServersAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Configuring</b> state, it indicates that the backend server is being modified.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the backend server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupServersAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupServersAttributeResponse
        /// </returns>
        public async Task<UpdateServerGroupServersAttributeResponse> UpdateServerGroupServersAttributeWithOptionsAsync(UpdateServerGroupServersAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                query["ServerGroupId"] = request.ServerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Servers))
            {
                query["Servers"] = request.Servers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServerGroupServersAttribute",
                Version = "2020-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServerGroupServersAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations, such as the backend server weight and description, of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupServersAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Configuring</b> state, it indicates that the backend server is being modified.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the backend server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupServersAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupServersAttributeResponse
        /// </returns>
        public UpdateServerGroupServersAttributeResponse UpdateServerGroupServersAttribute(UpdateServerGroupServersAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServerGroupServersAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations, such as the backend server weight and description, of a server group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>UpdateServerGroupServersAttribute</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213627.html">ListServerGroups</a> operation to query the status of a server group.<list type="bullet">
        /// <item><description>If a server group is in the <b>Configuring</b> state, it indicates that the server group is being modified.</description></item>
        /// <item><description>If a server group is in the <b>Available</b> state, it indicates that the server group is running.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/213628.html">ListServerGroupServers</a> operation to query the status of a backend server.<list type="bullet">
        /// <item><description>If a backend server is in the <b>Configuring</b> state, it indicates that the backend server is being modified.</description></item>
        /// <item><description>If a backend server is in the <b>Available</b> state, it indicates that the backend server is running.</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateServerGroupServersAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServerGroupServersAttributeResponse
        /// </returns>
        public async Task<UpdateServerGroupServersAttributeResponse> UpdateServerGroupServersAttributeAsync(UpdateServerGroupServersAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServerGroupServersAttributeWithOptionsAsync(request, runtime);
        }

    }
}
